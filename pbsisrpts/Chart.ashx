<%@ WebHandler Language="VB" Class="Chart" %>
Imports System
Imports System.Web
Imports ChartDirector
Imports System.Web.SessionState
Imports System.Drawing
Imports System.IO
Imports System.Drawing.Imaging

Public Class Chart : Implements IHttpHandler
    
    Dim myChart As C21MIT.PBSIS.BO.ChartInfoset
   
    Public Sub ProcessRequest(ByVal context As HttpContext) Implements IHttpHandler.ProcessRequest
        
        Try
            Dim colorset As Array = C21MIT.Reports.pbsreports.colorArray(context)
                    
            If Not context.Request.QueryString("sRptSchID") Is Nothing Then
                If context.Request.QueryString("sRptSchID") <> "" Then
                       If context.Request.QueryString("SchoolYear") = "" then
                            myChart = C21MIT.PBSIS.BLL.pbsreports.getReportInfo(context.Request.QueryString("chartid"), 0, "", 0, context.Request.QueryString("sRptSchID"))
                       Else
                            myChart = C21MIT.PBSIS.BLL.pbsreports.getReportInfo(context.Request.QueryString("chartid"), context.Request.QueryString("SchoolYear"), "", 0, context.Request.QueryString("sRptSchID"))
                       End if
                Else
                    myChart = C21MIT.PBSIS.BLL.pbsreports.getReportInfo(context.Request.QueryString("chartid"), context.Request.QueryString("SchoolYear"), context.Request.QueryString("DistId"), context.Request.QueryString("SchType"), "")
                End If
            Else
                myChart = C21MIT.PBSIS.BLL.pbsreports.getReportInfo(context.Request.QueryString("chartid"), context.Request.QueryString("SchoolYear"), context.Request.QueryString("DistId"), context.Request.QueryString("SchType"), "")
            End If
            
            'XYChart object
            Dim c As XYChart = New XYChart(myChart.ChartWidth, myChart.ChartHeight)
            
            c.xAxis().setColors(222)

            'Plotarea at (30, 20) and of size 200 x 200 pixels
            c.setPlotArea(myChart.ChartPlotXPosition, myChart.ChartPlotYPosition, _
                          myChart.ChartPlotWidth, myChart.ChartPlotHeight)
            
            ' Add a title to the chart using 10 pt Arial font
            If myChart.ChartData Is Nothing Then
                c.addTitle("No data is available for the selected report", myChart.ChartTitleFont, 14)
            Else
                If myChart.ChartGroupBy = "True" Then
                    'c.addTitle(myChart.ChartTitle & " " & "(Grouped by " & getSchTypeName(context.Request.QueryString("SchType")) & ")", myChart.ChartTitleFont, myChart.ChartTitleFontSize)
                    
                    If not context.Request.QueryString("sRptSchID") is Nothing then
                     c.addTitle(C21MIT.PBSIS.BLL.pbsdemodata.fngetdemodataEndYearSchool(context.Request.QueryString("sRptSchID"),context.Request.QueryString("SchoolYear")).SchoolName & "<*br*>" & myChart.ChartTitle & " " & "(Grouped by " & C21MIT.PBSIS.BLL.pbsschoolyeardesc.getSchTypeName(context.Request.QueryString("SchType")) & ")", "", myChart.ChartTitleFontSize)
                    Else
                     c.addTitle(context.Request.QueryString("DistName") & "<*br*>" & myChart.ChartTitle & " " & "(Grouped by " & C21MIT.PBSIS.BLL.pbsschoolyeardesc.getSchTypeName(context.Request.QueryString("SchType")) & ")", "", myChart.ChartTitleFontSize)
                    End if
                    
                   ' c.addTitle(context.Request.QueryString("DistName") & "<*br*>" & myChart.ChartTitle & " " & "(Grouped by " & C21MIT.PBSIS.BLL.pbsschoolyeardesc.getSchTypeName(context.Request.QueryString("SchType")) & ")", "", myChart.ChartTitleFontSize)
                ElseIf myChart.ChartGroupBy = "False" Then
                    'c.addTitle(myChart.ChartTitle, myChart.ChartTitleFont, myChart.ChartTitleFontSize)
                   
                   
                   If not context.Request.QueryString("sRptSchID") is Nothing then
                     c.addTitle(C21MIT.PBSIS.BLL.pbsdemodata.fngetdemodataEndYearSchool(context.Request.QueryString("sRptSchID"),context.Request.QueryString("SchoolYear")).SchoolName & "<*br*>" & myChart.ChartTitle , "", myChart.ChartTitleFontSize)
                   Else
                     c.addTitle(context.Request.QueryString("DistName") & "<*br*>" & myChart.ChartTitle, "", myChart.ChartTitleFontSize)
                   End if
                    
                    
                    'c.addTitle(context.Request.QueryString("DistName") & "<*br*>" & myChart.ChartTitle, "", myChart.ChartTitleFontSize)
                End If
            End If
         
            ' Add a title to the x-axis
            c.xAxis.setTitle(myChart.XAxisTitle, "", myChart.ChartTitleFontSize)
            c.xAxis.setLabelStyle(myChart.LabelFontStyle, myChart.LabelFontSize, myChart.LabelFontColor, myChart.XLabelFontAngle)
            c.yAxis().setTopMargin(20)
         
            'if legend is true then below else nothing   
            If myChart.IsLegendPresent = "True" Then
                c.addLegend(75, 26, myChart.LegendIsVertical, myChart.LegendFont, myChart.LabelFontSize).setBackground(ChartDirector.Chart.Transparent)
                c.getLegend().setKeySize(12, 12, -1)
            End If
           
            'Set the x axis labels using the given labels
            c.xAxis.setLabels(myChart.XAxisLabel)
                      
            ' c.yAxis.setTitle(myChart.YAxisTitle, myChart.LabelFontStyle, myChart.LabelFontSize, _
            '                    myChart.LabelFontColor)
            
            c.yAxis.setTitle(myChart.YAxisTitle, "", myChart.LabelFontSize, myChart.LabelFontColor)
         
            c.yAxis.setLinearScale(myChart.YAxisLowerLimit, myChart.YAxisUpperLimit, _
            myChart.YAxisMaxTic, myChart.YAxisMinTic)
                        
            c.yAxis.setTopMargin(myChart.YAxisSetTopmargin)
            
            'if multibar then
                   Dim barColor(2) As Integer
            barColor(0) = c.patternColor(New Integer() {&HFFFFFF, &HFFFFFF, _
            &HFFFFFF, &H66CC, &HFFFFFF, &HFFFFFF, &H66CC, &HFFFFFF, &HFFFFFF, _
            &H66CC, &HFFFFFF, &HFFFFFF, &H66CC, &HFFFFFF, &HFFFFFF, &HFFFFFF}, 4)

            barColor(1) = c.patternColor(New Integer() {&HFFFFFF, &HFFFFFF, _
            &HFFFFFF, &H4B0082, &HFFFFFF, &HFFFFFF, &H4B0082, &HFFFFFF, &HFFFFFF, _
            &H4B0082, &HFFFFFF, &HFFFFFF, &H4B0082, &HFFFFFF, &HFFFFFF, &HFFFFFF}, 6)

            barColor(2) = c.patternColor(New Integer() {&HFFFFFF, &HFFFFFF, _
            &HFFFFFF, &H2E4CD0, &HFFFFFF, &HFFFFFF, &H2E4CD0, &HFFFFFF, &HFFFFFF, _
            &H2E4CD0, &HFFFFFF, &HFFFFFF, &H2E4CD0, &HFFFFFF, &HFFFFFF, &HFFFFFF}, 4)
     
                      
            
            Dim barcount As Integer
            Dim nochartdata() As Double = {}
            
            If myChart.BarStyle = "Side" then
                Dim layer As BarLayer = c.addBarLayer2(ChartDirector.Chart.Side, 0)
                If myChart.ChartData Is Nothing and myChart.LegendLabels is nothing Then
                         System.Web.HttpContext.Current.Response.ContentType = "image/png"
                         System.Web.HttpContext.Current.Response.BinaryWrite(c.makeChart2(ChartDirector.Chart.PNG))
                         Exit sub
                    If not myChart.ChartData  is Nothing and myChart.LegendLabels.Length > 0  then
                        If myChart.DataStyle = "Dataset" then
                            For barcount = 0 To myChart.IsMultiBar - 1
                                    If myChart.LegendLabels(barcount) is Nothing then
                                        Exit for
                                    End if  
                                layer.addDataSet(nochartdata, colorset(barcount), myChart.LegendLabels(barcount))
                                
                            next
                        ElseIf myChart.DataStyle = "BarLayer" then
                            For barcount = 0 To myChart.IsMultiBar - 1
                                    If myChart.LegendLabels(barcount) is Nothing then
                                        Exit for
                                    End if  
                                    
                                c.addBarLayer(nochartdata, colorset(barcount), myChart.LegendLabels(barcount), 0)
                            Next 
                        End If
                    Else
                         System.Web.HttpContext.Current.Response.ContentType = "image/png"
                         System.Web.HttpContext.Current.Response.BinaryWrite(c.makeChart2(ChartDirector.Chart.PNG))
                         Exit sub
                     
                     End If
                Else
                        If myChart.IsMultiBar = 0 Then
                            layer.addDataSet(C21MIT.Reports.pbsreports.getChartData(myChart.ChartData(barcount)), colorset(barcount), myChart.LegendLabels(barcount))
                        ElseIf myChart.IsMultiBar > 0 Then
                            If myChart.DataStyle = "Dataset" then
                              For barcount = 0 To myChart.IsMultiBar - 1
                                    If myChart.LegendLabels(barcount) is Nothing then
                                        Exit for
                                    End if  
                                    
                                    'layer.addDataSet(C21MIT.Reports.pbsreports.getChartData(myChart.ChartData(barcount)), colorset(barcount), myChart.LegendLabels(barcount))
                                    
                                    If not myChart.ChartData  is Nothing and myChart.LegendLabels.Length > 0 then
                                       layer.addDataSet(C21MIT.Reports.pbsreports.getChartData(myChart.ChartData(barcount)), colorset(barcount), myChart.LegendLabels(barcount))
                                    Else If myChart.ChartData Is Nothing and myChart.LegendLabels.Length > 0 
                                        layer.addDataSet(nochartdata, colorset(barcount), myChart.LegendLabels(barcount))
                                    end if
                               Next
                           End If
                                             
                           If myChart.DataStyle = "BarLayer" then
                               For barcount = 0 To myChart.IsMultiBar - 1
                                    If myChart.LegendLabels(barcount) is Nothing then
                                        Exit for
                                    End if  
                                    
                                    'c.addBarLayer(C21MIT.Reports.pbsreports.getChartData(myChart.ChartData(barcount)),colorset(barcount), myChart.LegendLabels(barcount),0)
                                    
                                    If not myChart.ChartData  is Nothing and myChart.LegendLabels.Length > 0 then
                                        c.addBarLayer(C21MIT.Reports.pbsreports.getChartData(myChart.ChartData(barcount)),colorset(barcount), myChart.LegendLabels(barcount),0)
                                    Else If myChart.ChartData Is Nothing and myChart.LegendLabels.Length > 0 
                                       c.addBarLayer(nochartdata,colorset(barcount), myChart.LegendLabels(barcount),0)
                                    end if
                                   
                               Next
                           End If
                        End If
            End If
            
            layer.setAggregateLabelStyle()
            
        ElseIf myChart.BarStyle = "Stack" then
            Dim layer As BarLayer = c.addBarLayer2(ChartDirector.Chart.Stack, 0)
                If myChart.ChartData Is Nothing and myChart.LegendLabels is nothing Then
                         System.Web.HttpContext.Current.Response.ContentType = "image/png"
                         System.Web.HttpContext.Current.Response.BinaryWrite(c.makeChart2(ChartDirector.Chart.PNG))
                         Exit sub
                    If not myChart.ChartData  is Nothing and myChart.LegendLabels.Length > 0  then
                        If myChart.DataStyle = "Dataset" then
                            For barcount = 0 To myChart.IsMultiBar - 1
                                    If myChart.LegendLabels(barcount) is Nothing then
                                        Exit for
                                    End if  
                                    layer.addDataSet(nochartdata, colorset(barcount), myChart.LegendLabels(barcount))
                            next
                        ElseIf myChart.DataStyle = "BarLayer" then
                            For barcount = 0 To myChart.IsMultiBar - 1
                                    If myChart.LegendLabels(barcount) is Nothing then
                                        Exit for
                                    End if  
                                    
                                    c.addBarLayer(nochartdata,colorset(barcount), myChart.LegendLabels(barcount),0)
                            Next 
                        End If
                        
                    Else
                         System.Web.HttpContext.Current.Response.ContentType = "image/png"
                         System.Web.HttpContext.Current.Response.BinaryWrite(c.makeChart2(ChartDirector.Chart.PNG))
                         Exit sub
                     
                     End If
                Else
                        If myChart.IsMultiBar = 0 Then
                            layer.addDataSet(C21MIT.Reports.pbsreports.getChartData(myChart.ChartData(barcount)), colorset(barcount), myChart.LegendLabels(barcount))
                        ElseIf myChart.IsMultiBar > 0 Then
                            If myChart.DataStyle = "Dataset" then
                              For barcount = 0 To myChart.IsMultiBar - 1
                                    If myChart.LegendLabels(barcount) is Nothing then
                                        Exit for
                                    End if  
                                    
                                    'layer.addDataSet(C21MIT.Reports.pbsreports.getChartData(myChart.ChartData(barcount)), colorset(barcount), myChart.LegendLabels(barcount))
                                    
                                    If not myChart.ChartData  is Nothing and myChart.LegendLabels.Length > 0 then
                                       layer.addDataSet(C21MIT.Reports.pbsreports.getChartData(myChart.ChartData(barcount)), colorset(barcount), myChart.LegendLabels(barcount))
                                    Else If myChart.ChartData Is Nothing and myChart.LegendLabels.Length > 0 
                                        layer.addDataSet(nochartdata, colorset(barcount), myChart.LegendLabels(barcount))
                                    end if
                               Next
                           End If
                                             
                           If myChart.DataStyle = "BarLayer" then
                               For barcount = 0 To myChart.IsMultiBar - 1
                                    If myChart.LegendLabels(barcount) is Nothing then
                                        Exit for
                                    End if  
                                    
                                    'c.addBarLayer(C21MIT.Reports.pbsreports.getChartData(myChart.ChartData(barcount)),colorset(barcount), myChart.LegendLabels(barcount),0)
                                    
                                    If not myChart.ChartData  is Nothing and myChart.LegendLabels.Length > 0 then
                                        c.addBarLayer(C21MIT.Reports.pbsreports.getChartData(myChart.ChartData(barcount)),colorset(barcount), myChart.LegendLabels(barcount),0)
                                    Else If myChart.ChartData Is Nothing and myChart.LegendLabels.Length > 0 
                                       c.addBarLayer(nochartdata,colorset(barcount), myChart.LegendLabels(barcount),0)
                                    end if
                                   
                               Next
                           End If
                        End If
            End If
            
            layer.setAggregateLabelStyle()
            
       End If
            
            'output the chart      
            System.Web.HttpContext.Current.Response.ContentType = "image/png"
            System.Web.HttpContext.Current.Response.BinaryWrite(c.makeChart2(ChartDirector.Chart.PNG))
        Catch ex As Exception
            System.Web.HttpContext.Current.Response.ContentType = "text/plain"
            System.Web.HttpContext.Current.Response.Write(ex.Message.ToString)
        End Try
    End Sub
     
    Public ReadOnly Property IsReusable() As Boolean Implements IHttpHandler.IsReusable
        Get
            Return False
        End Get
    End Property
    
End Class
