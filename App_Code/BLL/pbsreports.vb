Imports Microsoft.VisualBasic
Imports System.Xml
Imports URDAL

Namespace C21MIT.PBSIS.BLL
    Public Class pbsreports
#Region "Report Information"
        '-------------------------------------------------------------------------------------------------------------------
        ' Function Name : getReportInfo  
        ' Created By : Aditi Deodhar
        ' Created Dt : Apr 22,2010
        ' Last Updated Dt : Apr 29,2010
        ' Description : This function is used for report settings
        '-------------------------------------------------------------------------------------------------------------------
        Public Shared Function getReportInfo(Optional ByVal chartid As String = "", Optional ByVal SchoolYear As Integer = 0, Optional ByVal distid As String = "", Optional ByVal schType As Integer = 0, Optional ByVal schoolID As String = "") As C21MIT.PBSIS.BO.ChartInfoset
            Dim myChart As New C21MIT.PBSIS.BO.ChartInfoset

            Dim xmlpath As String
            xmlpath = HttpContext.Current.Server.MapPath("~/pbsisresources/chart.xml")

            Dim xmlDoc As New XmlDocument
            xmlDoc.Load(xmlpath)
            Dim nodeList1 As XmlNodeList = xmlDoc.SelectNodes("charts/chartsettings/chart")

            Dim I As Integer


            For I = 0 To nodeList1.Count - 1
                If nodeList1.Item(I).Attributes.ItemOf(0).Value = chartid Then
                    Dim index As Integer = I + 1

                    getChartHeight(myChart, xmlDoc, index)
                    getChartWidth(myChart, xmlDoc, index)
                    getBarStyle(myChart, xmlDoc, index)
                    getMultiBar(myChart, xmlDoc, index)
                    getPlotPositionHeight(myChart, xmlDoc, index)
                    getChartTitle(myChart, xmlDoc, index)
                    getGroupBy(myChart, xmlDoc, index)
                    getLegendLabelFont(myChart, xmlDoc, index)
                    getAxisTitle(myChart, xmlDoc, index)
                    getTopMargin(myChart, xmlDoc, index)
                    getLabelInfo(myChart, xmlDoc, index)
                    getAxisLabel(myChart, xmlDoc, index)
                    getDataStyle(myChart, xmlDoc, index)

                    '-=========================================================================================================================-'

                    'School Login - END YEAR REPORTS

                    'ODR's over Years of Implementation 
                    If chartid = "7_0" Then
                        myChart.ChartData = fngtEndYrODR(schoolID, "data")

                        If myChart.XAxisLabelType = "db" Then
                            myChart.XAxisLabel = fngtEndYrODR(schoolID, "XAxisTitle")
                        End If

                        If myChart.LegendType = "db" Then
                            myChart.LegendLabels = fngtEndYrODR(schoolID, "legend")
                        End If
                    End If

                    'ODR Referrals per 100 Students
                    If chartid = "8_0" Then
                        myChart.ChartData = fngtEndYrODR_100(schoolID, "data")

                        If myChart.XAxisLabelType = "db" Then
                            myChart.XAxisLabel = fngtEndYrODR_100(schoolID, "XAxisTitle")
                        End If

                        If myChart.LegendType = "db" Then
                            myChart.LegendLabels = fngtEndYrODR_100(schoolID, "legend")
                        End If
                    End If

                    'ISS & OSS Over Years of Implementation
                    If chartid = "9_0" Then
                        myChart.ChartData = fngtEndYrISS_OSS(schoolID, "data")

                        If myChart.XAxisLabelType = "db" Then
                            myChart.XAxisLabel = fngtEndYrISS_OSS(schoolID, "XAxisTitle")
                        End If

                        If myChart.LegendType = "db" Then
                            myChart.LegendLabels = fngtEndYrISS_OSS(schoolID, "legend")
                        End If
                    End If

                    'ISS & OSS per 100 Students
                    If chartid = "10_0" Then
                        myChart.ChartData = fngtEndYrISS_OSS_100(schoolID, "data")

                        If myChart.XAxisLabelType = "db" Then
                            myChart.XAxisLabel = fngtEndYrISS_OSS_100(schoolID, "XAxisTitle")
                        End If

                        If myChart.LegendType = "db" Then
                            myChart.LegendLabels = fngtEndYrISS_OSS_100(schoolID, "legend")
                        End If
                    End If

                    'Average Daily Attendance
                    If chartid = "11_0" Then
                        myChart.ChartData = fngtEndYrAttend(schoolID, "data")

                        If myChart.XAxisLabelType = "db" Then
                            myChart.XAxisLabel = fngtEndYrAttend(schoolID, "XAxisTitle")
                        End If
                        If myChart.LegendType = "db" Then
                            myChart.LegendLabels = fngtEndYrAttend(schoolID, "legend")
                        End If
                    End If

                    'Benchmark of Quality Score per Critical Element
                    If chartid = "12_0" Then
                        myChart.ChartData = fngtEndYrBOQ(schoolID, "data")

                        If myChart.XAxisLabelType = "db" Then
                            myChart.XAxisLabel = fngtEndYrBOQ(schoolID, "XAxisTitle")
                        End If

                        If myChart.LegendType = "db" Then
                            myChart.LegendLabels = fngtEndYrBOQ(schoolID, "legend")
                        End If
                    End If

                    'Annual B.A.T. Subsection Report 
                    If chartid = "42_0" Then
                        myChart.ChartData = fngtBATSubsectionRep(schoolID, SchoolYear, "data")
                        If myChart.XAxisLabelType = "db" Then
                            myChart.XAxisLabel = fngtBATSubsectionRep(schoolID, SchoolYear, "XAxisTitle")
                        End If
                        If myChart.LegendType = "db" Then
                            myChart.LegendLabels = fngtBATSubsectionRep(schoolID, SchoolYear, "legend")
                        End If
                    End If

                    'Multi-Year B.A.T. Report 
                    If chartid = "43_0" Then
                        myChart.ChartData = fngtMultiYrBATreport(schoolID, "data")
                        If myChart.XAxisLabelType = "db" Then
                            myChart.XAxisLabel = fngtMultiYrBATreport(schoolID, "XAxisTitle")
                        End If
                        If myChart.LegendType = "db" Then
                            myChart.LegendLabels = fngtMultiYrBATreport(schoolID, "legend")
                        End If
                    End If
                    '-=========================================================================================================================-'


                    'School Login - MID YEAR REPORTS

                    'PIC - Tier 1 Critical Element
                    If chartid = "13_0" Then
                        myChart.ChartData = fngtMidYrPICTier1CriElem(schoolID, SchoolYear, "data")

                        If myChart.XAxisLabelType = "db" Then
                            myChart.XAxisLabel = fngtMidYrPICTier1CriElem(schoolID, SchoolYear, "XAxisTitle")
                        End If

                        If myChart.LegendType = "db" Then
                            myChart.LegendLabels = fngtMidYrPICTier1CriElem(schoolID, SchoolYear, "legend")
                        End If
                    End If

                    'PIC -  Implementation Level 
                    If chartid = "14_0" Then
                        myChart.ChartData = fngtMidYrPICImplLevel(schoolID, SchoolYear, "data")

                        If myChart.XAxisLabelType = "db" Then
                            myChart.XAxisLabel = fngtMidYrPICImplLevel(schoolID, SchoolYear, "XAxisTitle")
                        End If

                        If myChart.LegendType = "db" Then
                            myChart.LegendLabels = fngtMidYrPICImplLevel(schoolID, SchoolYear, "legend")
                        End If
                    End If
                    '-=========================================================================================================================-'

                    'District / FMHI Login - Mid-Year District Level Reports

                    'PIC - Implementation Level 
                    If chartid = "19_0" Then
                        myChart.ChartData = fngtImplLevelCat(SchoolYear, distid, "data")

                        If myChart.XAxisLabelType = "db" Then
                            myChart.XAxisLabel = fngtImplLevelCat(SchoolYear, distid, "XAxisTitle")
                        End If

                        If myChart.LegendType = "db" Then
                            myChart.LegendLabels = fngtImplLevelCat(SchoolYear, distid, "legend")
                        End If
                    End If

                    'PIC - Tier 1 Critical Elements 
                    If chartid = "20_0" Then
                        myChart.ChartData = fngtTier1ImplForAllSch(SchoolYear, distid, "data")

                        If myChart.XAxisLabelType = "db" Then
                            myChart.XAxisLabel = fngtTier1ImplForAllSch(SchoolYear, distid, "XAxisTitle")
                        End If

                        If myChart.LegendType = "db" Then
                            myChart.LegendLabels = fngtTier1ImplForAllSch(SchoolYear, distid, "legend")
                        End If
                    End If

                    'PIC - Implementation Level (Grouped by School Type)
                    If chartid = "21_0" Or chartid = "21_1" Or chartid = "21_2" Or chartid = "21_3" Or chartid = "21_4" Or chartid = "21_5" Then
                        myChart.ChartData = fngtAvgPICImplLeCat(SchoolYear, distid, schType, "data")

                        If myChart.XAxisLabelType = "db" Then
                            myChart.XAxisLabel = fngtAvgPICImplLeCat(SchoolYear, distid, schType, "XAxisTitle")
                        End If

                        If myChart.LegendType = "db" Then
                            myChart.LegendLabels = fngtAvgPICImplLeCat(SchoolYear, distid, schType, "legend")
                        End If
                    End If

                    'Tier 1 Critical Elements (Grouped by School Type)
                    If chartid = "22_0" Or chartid = "22_1" Or chartid = "22_2" Or chartid = "22_3" Or chartid = "22_4" Or chartid = "22_5" Then
                        myChart.ChartData = fngetpicDistImplChklistTr1byType(SchoolYear, distid, schType, "data")

                        If myChart.XAxisLabelType = "db" Then
                            myChart.XAxisLabel = fngetpicDistImplChklistTr1byType(SchoolYear, distid, schType, "XAxisTitle")
                        End If

                        If myChart.LegendType = "db" Then
                            myChart.LegendLabels = fngetpicDistImplChklistTr1byType(SchoolYear, distid, schType, "legend")
                        End If
                    End If
                    '-=========================================================================================================================-'


                    'END YEAR DISTRICT LEVEL REPORTS
                    'Average ODR per 100 Students by Implementation level 
                    If chartid = "31_0" Then
                        myChart.ChartData = fngtEndYrDlrODRper100(distid, "data")
                        If myChart.XAxisLabelType = "db" Then
                            myChart.XAxisLabel = fngtEndYrDlrODRper100(distid, "XAxisTitle")
                        End If

                        If myChart.LegendType = "db" Then
                            myChart.LegendLabels = fngtEndYrDlrODRper100(distid, "legend")
                        End If
                    End If

                    'Average ISS Days per 100 Students by Implementation level 
                    If chartid = "32_0" Then
                        myChart.ChartData = fngtEndYrDlrISSPer100Stu(distid, "data")
                        If myChart.XAxisLabelType = "db" Then
                            myChart.XAxisLabel = fngtEndYrDlrISSPer100Stu(distid, "XAxisTitle")
                        End If

                        If myChart.LegendType = "db" Then
                            myChart.LegendLabels = fngtEndYrDlrISSPer100Stu(distid, "legend")
                        End If
                    End If

                    'Average OSS Days per 100 Students by Implementation level 
                    If chartid = "33_0" Then
                        myChart.ChartData = fngtEndYrDlrOSSPer100Stu(distid, "data")
                        If myChart.XAxisLabelType = "db" Then
                            myChart.XAxisLabel = fngtEndYrDlrOSSPer100Stu(distid, "XAxisTitle")
                        End If

                        If myChart.LegendType = "db" Then
                            myChart.LegendLabels = fngtEndYrDlrOSSPer100Stu(distid, "legend")
                        End If
                    End If

                    'Percentage making gains in reading by School Implementation level 
                    If chartid = "34_0" Then
                        myChart.ChartData = fngtEndYrDlrPerMGInReadingBySchImp(distid, "data")
                        If myChart.XAxisLabelType = "db" Then
                            myChart.XAxisLabel = fngtEndYrDlrPerMGInReadingBySchImp(distid, "XAxisTitle")
                        End If

                        If myChart.LegendType = "db" Then
                            myChart.LegendLabels = fngtEndYrDlrPerMGInReadingBySchImp(distid, "legend")
                        End If
                    End If

                    'Percentage of Lowest 25% Making Gains in Reading By School Implementation Level 
                    If chartid = "35_0" Then
                        myChart.ChartData = fngtEndYrDlrPerofLow25MGiReadBySchImpl(distid, "data")
                        If myChart.XAxisLabelType = "db" Then
                            myChart.XAxisLabel = fngtEndYrDlrPerofLow25MGiReadBySchImpl(distid, "XAxisTitle")
                        End If

                        If myChart.LegendType = "db" Then
                            myChart.LegendLabels = fngtEndYrDlrPerofLow25MGiReadBySchImpl(distid, "legend")
                        End If
                    End If

                    'Average Daily attendance for Higher and Lower implementing schools 
                    If chartid = "36_0" Then
                        myChart.ChartData = fngtAvgDAttendforHiALoImpl(distid, "data")
                        If myChart.XAxisLabelType = "db" Then
                            myChart.XAxisLabel = fngtAvgDAttendforHiALoImpl(distid, "XAxisTitle")
                        End If

                        If myChart.LegendType = "db" Then
                            myChart.LegendLabels = fngtAvgDAttendforHiALoImpl(distid, "legend")
                        End If
                    End If

                    'District percentage of Students at FCAT reading Level 3 by PBS Implementation Level 
                    If chartid = "37_0" Then
                        myChart.ChartData = fngtPerFCATREadLvl3(distid, "data")
                        If myChart.XAxisLabelType = "db" Then
                            myChart.XAxisLabel = fngtPerFCATREadLvl3(distid, "XAxisTitle")
                        End If

                        If myChart.LegendType = "db" Then
                            myChart.LegendLabels = fngtPerFCATREadLvl3(distid, "legend")
                        End If
                    End If

                    'Average Benchmark Score Per Critical Element Category (All School Types)
                    If chartid = "38_0" Then
                        myChart.ChartData = fngtAvgBScPerCritEleAllSchType(distid, "data")
                        If myChart.XAxisLabelType = "db" Then
                            myChart.XAxisLabel = fngtAvgBScPerCritEleAllSchType(distid, "XAxisTitle")
                        End If

                        If myChart.LegendType = "db" Then
                            myChart.LegendLabels = fngtAvgBScPerCritEleAllSchType(distid, "legend")
                        End If
                    End If

                    'Schools Trained in PBS : Inactive/Active
                    If chartid = "39_0" Then
                        myChart.ChartData = fngtSchTrInPBSAcInact(distid, "data")
                        If myChart.XAxisLabelType = "db" Then
                            myChart.XAxisLabel = fngtSchTrInPBSAcInact(distid, "XAxisTitle")
                        End If

                        If myChart.LegendType = "db" Then
                            myChart.LegendLabels = fngtSchTrInPBSAcInact(distid, "legend")
                        End If
                    End If

                    'Average ODR per 100 Students for Lower and Higher Implementing Schools (Grouped by School Type)
                    '40_0 Pending
                    If chartid = "40_0" Then
                        myChart.ChartData = fngtAvgODRP100StuImplLev(distid, schType, "data")
                        If myChart.XAxisLabelType = "db" Then
                            myChart.XAxisLabel = fngtAvgODRP100StuImplLev(distid, schType, "XAxisTitle")
                        End If

                        If myChart.LegendType = "db" Then
                            myChart.LegendLabels = fngtAvgODRP100StuImplLev(distid, schType, "legend")
                        End If
                    End If

                    'Average Benchmark Score Per Critical Element Category (Grouped by School Type)
                    If chartid = "41_0" Then
                        myChart.ChartData = fngtAvgBScPCEleCat(distid, schType, "data")
                        If myChart.XAxisLabelType = "db" Then
                            myChart.XAxisLabel = fngtAvgBScPCEleCat(distid, schType, "XAxisTitle")
                        End If

                        If myChart.LegendType = "db" Then
                            myChart.LegendLabels = fngtAvgBScPCEleCat(distid, schType, "legend")
                        End If
                    End If

                    'Annual B.A.T. Subsection Report
                    If chartid = "44_0" Then
                        myChart.ChartData = fngtAllSchBATSubsectionRep(distid, SchoolYear, "data")
                        If myChart.XAxisLabelType = "db" Then
                            myChart.XAxisLabel = fngtAllSchBATSubsectionRep(distid, SchoolYear, "XAxisTitle")
                        End If
                        If myChart.LegendType = "db" Then
                            myChart.LegendLabels = fngtAllSchBATSubsectionRep(distid, SchoolYear, "legend")
                        End If
                    End If

                    'Multi-Year B.A.T. Report
                    If chartid = "45_0" Then
                        myChart.ChartData = fngtAllSchMultiBATRep(distid, "data")
                        If myChart.XAxisLabelType = "db" Then
                            myChart.XAxisLabel = fngtAllSchMultiBATRep(distid, "XAxisTitle")
                        End If
                        If myChart.LegendType = "db" Then
                            myChart.LegendLabels = fngtAllSchMultiBATRep(distid, "legend")
                        End If
                    End If

                    'Annual B.A.T. Subsection Report (Grouped by School Type)
                    If chartid = "46_0" Then
                        myChart.ChartData = fngtSchBATBySchTypeSubsectionRep(distid, SchoolYear, schType, "data")
                        If myChart.XAxisLabelType = "db" Then
                            myChart.XAxisLabel = fngtSchBATBySchTypeSubsectionRep(distid, SchoolYear, schType, "XAxisTitle")
                        End If
                        If myChart.LegendType = "db" Then
                            myChart.LegendLabels = fngtSchBATBySchTypeSubsectionRep(distid, SchoolYear, schType, "legend")
                        End If
                    End If

                    'Multi-Year B.A.T. Report (Grouped by School Type)
                    If chartid = "47_0" Then
                        myChart.ChartData = fngtSchMultiBATBySchTypeRep(distid, schType, "data")
                        If myChart.XAxisLabelType = "db" Then
                            myChart.XAxisLabel = fngtSchMultiBATBySchTypeRep(distid, schType, "XAxisTitle")
                        End If
                        If myChart.LegendType = "db" Then
                            myChart.LegendLabels = fngtSchMultiBATBySchTypeRep(distid, schType, "legend")
                        End If
                    End If
                Else
                End If
            Next I
            Return myChart
        End Function
#Region "Chart Height"
        Shared Sub getChartHeight(ByVal myChart As C21MIT.PBSIS.BO.ChartInfoset, ByVal xmlDoc As XmlDocument, ByVal K As Integer)
            myChart.ChartHeight = xmlDoc.SelectSingleNode("charts/chartsettings/chart[" & K & "]").Attributes.ItemOf(1).Value
        End Sub
#End Region
#Region "Chart Width"
        Shared Sub getChartWidth(ByVal myChart As C21MIT.PBSIS.BO.ChartInfoset, ByVal xmlDoc As XmlDocument, ByVal K As Integer)
            myChart.ChartWidth = xmlDoc.SelectSingleNode("charts/chartsettings/chart[" & K & "]").Attributes.ItemOf(2).Value
        End Sub
#End Region
#Region "Bar Style"
        Shared Sub getBarStyle(ByVal myChart As C21MIT.PBSIS.BO.ChartInfoset, ByVal xmlDoc As XmlDocument, ByVal K As Integer)
            myChart.BarStyle = xmlDoc.SelectSingleNode("charts/chartsettings/chart[" & K & "]").Attributes.ItemOf(3).Value
        End Sub
#End Region
#Region "Multi Bar"
        Shared Sub getMultiBar(ByVal myChart As C21MIT.PBSIS.BO.ChartInfoset, ByVal xmlDoc As XmlDocument, ByVal K As Integer)
            If xmlDoc.SelectSingleNode("charts/chartsettings/chart[" & K & "]/Multibar").Attributes.ItemOf(0).Value = "False" Then
                myChart.IsMultiBar = 0
            ElseIf xmlDoc.SelectSingleNode("charts/chartsettings/chart[" & K & "]/Multibar").Attributes.ItemOf(0).Value = "True" Then
                myChart.IsMultiBar = xmlDoc.SelectSingleNode("charts/chartsettings/chart[" & K & "]/Multibar").InnerText
            End If
        End Sub
#End Region
#Region "Plot Position Height"
        Shared Sub getPlotPositionHeight(ByVal myChart As C21MIT.PBSIS.BO.ChartInfoset, ByVal xmlDoc As XmlDocument, ByVal K As Integer)
            'ChartPlotXPosition
            myChart.ChartPlotXPosition = xmlDoc.SelectSingleNode("charts/chartsettings/chart[" & K & "]/PlotXPosition").InnerText

            'ChartPlotYPosition
            myChart.ChartPlotYPosition = xmlDoc.SelectSingleNode("charts/chartsettings/chart[" & K & "]/PlotYPosition").InnerText

            'ChartPlotHeight
            myChart.ChartPlotHeight = xmlDoc.SelectSingleNode("charts/chartsettings/chart[" & K & "]/PlotHeight").InnerText

            'ChartPlotWidth
            myChart.ChartPlotWidth = xmlDoc.SelectSingleNode("charts/chartsettings/chart[" & K & "]/PlotWidth").InnerText
        End Sub
#End Region
#Region "Chart Title"
        Shared Sub getChartTitle(ByVal myChart As C21MIT.PBSIS.BO.ChartInfoset, ByVal xmlDoc As XmlDocument, ByVal K As Integer)
            Dim xmlChartTitle As XmlNode = xmlDoc.SelectSingleNode("charts/chartsettings/chart[" & K & "]/Title")
            myChart.ChartTitle = xmlDoc.SelectSingleNode("charts/chartsettings/chart[" & K & "]/Title").InnerText
            If xmlDoc.SelectSingleNode("charts/chartsettings/chart[" & K & "]/Title").HasChildNodes Then
                myChart.ChartTitleFont = C21MIT.Reports.pbsreports.getFontInfo(xmlChartTitle, K).FontFace
                myChart.ChartTitleFontSize = C21MIT.Reports.pbsreports.getFontInfo(xmlChartTitle, K).FontSize
                myChart.ChartTitleColor = C21MIT.Reports.pbsreports.getFontInfo(xmlChartTitle, K).FontColor
            End If
        End Sub

#End Region
#Region "Group By"
        Shared Sub getGroupBy(ByVal myChart As C21MIT.PBSIS.BO.ChartInfoset, ByVal xmlDoc As XmlDocument, ByVal K As Integer)
            Dim xmlGroupBy As XmlNode = xmlDoc.SelectSingleNode("charts/chartsettings/chart[" & K & "]/GroupBy")
            myChart.ChartGroupBy = xmlGroupBy.InnerText
        End Sub
#End Region
#Region "Legend Label Font"
        Shared Sub getLegendLabelFont(ByVal myChart As C21MIT.PBSIS.BO.ChartInfoset, ByVal xmlDoc As XmlDocument, ByVal K As Integer)
            Dim xmlLegend As XmlNode = xmlDoc.SelectSingleNode("charts/chartsettings/chart[" & K & "]/Legend")

            myChart.IsLegendPresent = xmlLegend.Attributes.ItemOf(0).Value.ToString
            myChart.LegendType = xmlLegend.Attributes.ItemOf(1).Value.ToString ''newly added
            myChart.LegendIsVertical = xmlLegend.Attributes.ItemOf(4).Value.ToString

            'Loop through the legend items
            Dim C As Integer
            Dim strLegendItem(xmlLegend.ChildNodes.Count - 1) As String
            If xmlLegend.HasChildNodes Then
                For C = 0 To xmlLegend.ChildNodes.Count - 1
                    strLegendItem(C) = xmlLegend.ChildNodes(C).InnerText
                    myChart.LegendLabels = strLegendItem
                Next
            End If

            'Legend Font
            Dim xmllegendFont As XmlNode = xmlDoc.SelectSingleNode("charts/chartsettings/chart[" & K & "]/LegendFont")
            myChart.LegendFont = C21MIT.Reports.pbsreports.getFontInfo(xmllegendFont, K).FontFace
            ' myChart.LegendFontSize = getFontInfo(xmllegendFont, K).FontSize
        End Sub
#End Region
#Region "Axis Title"
        Shared Sub getAxisTitle(ByVal myChart As C21MIT.PBSIS.BO.ChartInfoset, ByVal xmlDoc As XmlDocument, ByVal K As Integer)
            'XAxisTitle
            Dim nodeXAxisTitle As XmlNode = xmlDoc.SelectSingleNode("charts/chartsettings/chart[" & K & "]/XAxisTitle")
            If nodeXAxisTitle.Attributes.ItemOf(0).Value = "True" Then
                myChart.XAxisTitle = nodeXAxisTitle.FirstChild.InnerText
            End If

            'YAxis
            Dim nodeYAxisTitle As XmlNode = xmlDoc.SelectSingleNode("charts/chartsettings/chart[" & K & "]/YAxisTitle")

            If nodeYAxisTitle.Attributes.ItemOf(0).Value = "True" Then
                Dim nodeYAxisTit As XmlNode = xmlDoc.SelectSingleNode("charts/chartsettings/chart[" & K & "]/YAxisTitle").FirstChild
                Dim nodeYAxisLowerLimit As XmlNode = nodeYAxisTit.NextSibling
                Dim nodeYYAxisUpperLimit As XmlNode = nodeYAxisLowerLimit.NextSibling
                Dim nodeYAxisMaxTic As XmlNode = nodeYYAxisUpperLimit.NextSibling
                Dim nodeYAxisMinTic As XmlNode = nodeYAxisMaxTic.NextSibling

                myChart.YAxisTitle = nodeYAxisTit.InnerText
                myChart.YAxisLowerLimit = nodeYAxisLowerLimit.InnerText
                myChart.YAxisUpperLimit = nodeYYAxisUpperLimit.InnerText
                myChart.YAxisMaxTic = nodeYAxisMaxTic.InnerText
                myChart.YAxisMinTic = nodeYAxisMinTic.InnerText
            End If
        End Sub
#End Region
#Region "Top Margin"
        Shared Sub getTopMargin(ByVal myChart As C21MIT.PBSIS.BO.ChartInfoset, ByVal xmlDoc As XmlDocument, ByVal K As Integer)
            'Top Margin
            Dim xmlTopMArgin As XmlNode = xmlDoc.SelectSingleNode("charts/chartsettings/chart[" & K & "]/TopMargin")

            If xmlTopMArgin.Attributes.ItemOf(0).Value = "True" Then
                myChart.YAxisSetTopmargin = xmlTopMArgin.LastChild.InnerText
            End If
        End Sub
#End Region
#Region "Label Info"
        Shared Sub getLabelInfo(ByVal myChart As C21MIT.PBSIS.BO.ChartInfoset, ByVal xmlDoc As XmlDocument, ByVal K As Integer)
            'X - Labels
            Dim nodeLabelFont As XmlNode = xmlDoc.SelectSingleNode("charts/chartsettings/chart[" & K & "]/Label")
            myChart.LabelFontStyle = C21MIT.Reports.pbsreports.getFontInfo(nodeLabelFont, K).FontFace
            myChart.LabelFontSize = C21MIT.Reports.pbsreports.getFontInfo(nodeLabelFont, K).FontSize
            myChart.LabelFontColor = C21MIT.Reports.pbsreports.getFontInfo(nodeLabelFont, K).FontColor
            '        Dim strColorcode As String = getFontInfo(nodeLabelFont, K).FontColor.Remove("""", String.Empty)
            '        myChart.LabelFontColor = Int32.Parse(getFontInfo(nodeLabelFont, K).FontColor, System.Globalization.NumberStyles.HexNumber)
        End Sub
#End Region
#Region "Axis Label"
        Shared Sub getAxisLabel(ByVal myChart As C21MIT.PBSIS.BO.ChartInfoset, ByVal xmlDoc As XmlDocument, ByVal K As Integer)
            Dim nodeSeries As XmlNode = xmlDoc.SelectSingleNode("charts/chartsettings/chart[" & K & "]/XAxisLabels")
            Dim J As Integer
            Dim nodeXAxisLabel As XmlNode = xmlDoc.SelectSingleNode("charts/chartsettings/chart[" & K & "]/XAxisLabels")
            myChart.XLabelFontAngle = nodeXAxisLabel.Attributes.ItemOf(1).Value

            myChart.XAxisLabelType = nodeXAxisLabel.Attributes.ItemOf(0).Value

            If myChart.XAxisLabelType = "xml" Then
                Dim strLabel(nodeSeries.ChildNodes.Count - 1) As String
                If nodeSeries.HasChildNodes Then
                    For J = 0 To nodeSeries.ChildNodes.Count - 1
                        strLabel(J) = nodeSeries.ChildNodes(J).Attributes.ItemOf(0).Value
                        myChart.XAxisLabel = strLabel
                    Next
                End If
            End If
        End Sub
#End Region
#Region "Data Style"
        Shared Sub getDataStyle(ByVal myChart As C21MIT.PBSIS.BO.ChartInfoset, ByVal xmlDoc As XmlDocument, ByVal K As Integer)
            If xmlDoc.SelectSingleNode("charts/chartsettings/chart[" & K & "]/Multibar").Attributes.ItemOf(1).Value = "dataset" Then
                myChart.DataStyle = "Dataset"
            ElseIf xmlDoc.SelectSingleNode("charts/chartsettings/chart[" & K & "]/Multibar").Attributes.ItemOf(1).Value = "barlayer" Then
                myChart.DataStyle = "BarLayer"
            End If
        End Sub
#End Region
#End Region
#Region "School Login - END YEAR REPORTS"
        Shared Function fngtEndYrODR(ByVal schID As String, ByVal type As String) As String()
            Return C21MIT.PBSIS.DAL.endyrschloginreports.fngtEndYrODR(schID, type)
        End Function

        Shared Function fngtEndYrODR_100(ByVal schID As String, ByVal type As String) As String()
            Return C21MIT.PBSIS.DAL.endyrschloginreports.fngtEndYrODR_100(schID, type)
        End Function

        Shared Function fngtEndYrISS_OSS(ByVal schID As String, ByVal type As String) As String()
            Return C21MIT.PBSIS.DAL.endyrschloginreports.fngtEndYrISS_OSS(schID, type)
        End Function

        Shared Function fngtEndYrISS_OSS_100(ByVal schID As String, ByVal type As String) As String()
            Return C21MIT.PBSIS.DAL.endyrschloginreports.fngtEndYrISS_OSS_100(schID, type)
        End Function

        Shared Function fngtEndYrAttend(ByVal schID As String, ByVal type As String) As String()
            Return C21MIT.PBSIS.DAL.endyrschloginreports.fngtEndYrAttend(schID, type)
        End Function

        Shared Function fngtEndYrBOQ(ByVal schID As String, ByVal type As String) As String()
            Return C21MIT.PBSIS.DAL.endyrschloginreports.fngtEndYrBOQ(schID, type)
        End Function

        Shared Function fngtBATSubsectionRep(ByVal schID As String, ByVal schYr As Integer, ByVal type As String) As String()
            Return C21MIT.PBSIS.DAL.endyrschloginreports.fngtBATSubsectionRep(schID, schYr, type)
        End Function

        Shared Function fngtMultiYrBATreport(ByVal schID As String, ByVal type As String) As String()
            Return C21MIT.PBSIS.DAL.endyrschloginreports.fngtMultiYrBATreport(schID, type)
        End Function
#End Region
#Region "School Login - MID YEAR REPORTS"
        Shared Function fngtMidYrPICImplLevel(ByVal schID As String, ByVal schYr As Integer, ByVal type As String) As String()
            Return C21MIT.PBSIS.DAL.midyrschloginreports.fngtMidYrPICImplLevel(schID, schYr, type)
        End Function

        Shared Function fngtMidYrPICTier1CriElem(ByVal schID As String, ByVal schYr As Integer, ByVal type As String) As String()
            Return C21MIT.PBSIS.DAL.midyrschloginreports.fngtMidYrPICTier1CriElem(schID, schYr, type)
        End Function
#End Region
#Region "District / FMHI Login - Mid-Year District Level Reports"
        Shared Function fngetpicDistImplChklistTr1byType(ByVal schYr As Integer, ByVal distid As String, ByVal schType As Integer, ByVal type As String) As String()
            Return C21MIT.PBSIS.DAL.midyrdistlevelreports.fngtpicDistImplChklistTr1byType(schYr, distid, schType, type)
        End Function

        Shared Function fngtImplLevelCat(ByVal schYr As Integer, ByVal distid As String, ByVal type As String) As String()
            Return C21MIT.PBSIS.DAL.midyrdistlevelreports.fngtImplLevelCat(schYr, distid, type)
        End Function

        Shared Function fngtTier1ImplForAllSch(ByVal schYr As Integer, ByVal distid As String, ByVal type As String) As String()
            Return C21MIT.PBSIS.DAL.midyrdistlevelreports.fngtTier1ImplForAllSch(schYr, distid, type)
        End Function

        Shared Function fngtAvgPICImplLeCat(ByVal schYr As Integer, ByVal distid As String, ByVal schType As Integer, ByVal type As String) As String()
            Return C21MIT.PBSIS.DAL.midyrdistlevelreports.fngtAvgPICImplLeCat(schYr, distid, schType, type)
        End Function
#End Region
#Region "END YEAR DISTRICT LEVEL REPORTS"
        'END YR DLR REPORTS
        Shared Function fngtEndYrDlrODRper100(ByVal distid As String, ByVal type As String) As String()
            Return C21MIT.PBSIS.DAL.endyrdlrreports.fngtEndYrDlrODRper100(distid, type)
        End Function

        Shared Function fngtEndYrDlrISSPer100Stu(ByVal distid As String, ByVal type As String) As String()
            Return C21MIT.PBSIS.DAL.endyrdlrreports.fngtEndYrDlrISSPer100Stu(distid, type)
        End Function

        Shared Function fngtEndYrDlrOSSPer100Stu(ByVal distid As String, ByVal type As String) As String()
            Return C21MIT.PBSIS.DAL.endyrdlrreports.fngtEndYrDlrOSSPer100Stu(distid, type)
        End Function

        Shared Function fngtEndYrDlrPerMGInReadingBySchImp(ByVal distid As String, ByVal type As String) As String()
            Return C21MIT.PBSIS.DAL.endyrdlrreports.fngtEndYrDlrPerMGInReadingBySchImp(distid, type)
        End Function

        Shared Function fngtEndYrDlrPerofLow25MGiReadBySchImpl(ByVal distid As String, ByVal type As String) As String()
            Return C21MIT.PBSIS.DAL.endyrdlrreports.fngtEndYrDlrPerofLow25MGiReadBySchImpl(distid, type)
        End Function

        Shared Function fngtAvgDAttendforHiALoImpl(ByVal distid As String, ByVal type As String) As String()
            Return C21MIT.PBSIS.DAL.endyrdlrreports.fngtAvgDAttendforHiALoImpl(distid, type)
        End Function

        Shared Function fngtPerFCATREadLvl3(ByVal distid As String, ByVal type As String) As String()
            Return C21MIT.PBSIS.DAL.endyrdlrreports.fngtPerFCATREadLvl3(distid, type)
        End Function

        Shared Function fngtAvgBScPerCritEleAllSchType(ByVal distid As String, ByVal type As String) As String()
            Return C21MIT.PBSIS.DAL.endyrdlrreports.fngtAvgBScPerCritEleAllSchType(distid, type)
        End Function

        Shared Function fngtSchTrInPBSAcInact(ByVal distid As String, ByVal type As String) As String()
            Return C21MIT.PBSIS.DAL.endyrdlrreports.fngtSchTrInPBSAcInact(distid, type)
        End Function

        Shared Function fngtAvgODRP100StuImplLev(ByVal distid As String, ByVal schType As Integer, ByVal type As String) As String()
            Return C21MIT.PBSIS.DAL.endyrdlrreports.fngtAvgODRP100StuImplLev(distid, schType, type)
        End Function

        Shared Function fngtAvgBScPCEleCat(ByVal distid As String, ByVal schType As Integer, ByVal type As String) As String()
            Return C21MIT.PBSIS.DAL.endyrdlrreports.fngtAvgBScPCEleCat(distid, schType, type)
        End Function

        Shared Function fngtAllSchBATSubsectionRep(ByVal distid As String, ByVal schyr As Integer, ByVal type As String) As String()
            Return C21MIT.PBSIS.DAL.endyrdlrreports.fngtAllSchBATSubsectionRep(distid, schyr, type)
        End Function

        Shared Function fngtAllSchMultiBATRep(ByVal distid As String, ByVal type As String) As String()
            Return C21MIT.PBSIS.DAL.endyrdlrreports.fngtAllSchMultiBATRep(distid, type)
        End Function

        Shared Function fngtSchBATBySchTypeSubsectionRep(ByVal distid As String, ByVal schyr As Integer, ByVal schType As Integer, ByVal type As String) As String()
            Return C21MIT.PBSIS.DAL.endyrdlrreports.fngtSchBATBySchTypeSubsectionRep(distid, schyr, schType, type)
        End Function

        Shared Function fngtSchMultiBATBySchTypeRep(ByVal distid As String, ByVal schType As Integer, ByVal type As String) As String()
            Return C21MIT.PBSIS.DAL.endyrdlrreports.fngtSchMultiBATBySchTypeRep(distid, schType, type)
        End Function
#End Region
     End Class
End Namespace

