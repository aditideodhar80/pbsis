Imports Microsoft.VisualBasic
Imports ChartDirector
Imports System.IO
Imports System.Drawing
Imports System.Xml

Namespace C21MIT.Reports
    Public Class pbsreports
        Dim myChart As C21MIT.PBSIS.BO.ChartInfoset
        Private Function getBarColor(ByVal colorid As Integer) As Integer
            Dim c As XYChart = New XYChart(myChart.ChartWidth, myChart.ChartHeight)
            If colorid = 1 Then
                Dim actualColor1 As Integer = c.patternColor(New Integer() {&HFFFFFF, &HFFFFFF, _
      &HFFFFFF, &H66CC, &HFFFFFF, &HFFFFFF, &H66CC, &HFFFFFF, &HFFFFFF, _
      &H66CC, &HFFFFFF, &HFFFFFF, &H66CC, &HFFFFFF, &HFFFFFF, &HFFFFFF}, 4)
                Return actualColor1
            ElseIf colorid = 2 Then

                Dim actualColor2 As Integer = c.patternColor(New Integer() {&HFFFFFF, &HFFFFFF, _
           &HFFFFFF, &H29ABB0, &HFFFFFF, &HFFFFFF, &H29ABB0, &HFFFFFF, &HFFFFFF, _
           &H29ABB0, &HFFFFFF, &HFFFFFF, &H29ABB0, &HFFFFFF, &HFFFFFF, &HFFFFFF}, 4)

                Return actualColor2
            ElseIf colorid = 3 Then

                Dim actualColor3 As Integer = c.patternColor(New Integer() {&HFFFFFF, &HFFFFFF, _
          &HFFFFFF, &H2E4CD0, &HFFFFFF, &HFFFFFF, &H2E4CD0, &HFFFFFF, &HFFFFFF, _
          &H2E4CD0, &HFFFFFF, &HFFFFFF, &H2E4CD0, &HFFFFFF, &HFFFFFF, &HFFFFFF}, 4)

                Return actualColor3
            End If

        End Function

        Shared Function getChartData(ByVal pData As String) As Double()
            Dim arrdata2() As String = pData.Split(",")

            Dim arrLength As Integer = arrdata2.Length - 1

            Dim arrdata(arrLength) As Double

            For i As Integer = 0 To arrLength
                arrdata(i) = Convert.ToDecimal(arrdata2(i))
            Next

            Return arrdata

        End Function

        Shared Function ReturnArrayMethod(Optional ByVal str1 As Integer = 0, Optional ByVal str2 As Integer = 0, Optional ByVal str3 As Integer = 0, Optional ByVal str4 As Integer = 0, Optional ByVal str5 As Integer = 0, Optional ByVal str6 As Integer = 0, Optional ByVal str7 As Integer = 0, Optional ByVal str8 As Integer = 0, Optional ByVal str9 As Integer = 0, Optional ByVal str10 As Integer = 0, Optional ByVal str11 As Integer = 0, Optional ByVal str12 As Integer = 0, Optional ByVal str13 As Integer = 0, Optional ByVal str14 As Integer = 0, Optional ByVal str15 As Integer = 0, Optional ByVal str16 As Integer = 0, Optional ByVal str17 As Integer = 0, Optional ByVal str18 As Integer = 0, Optional ByVal str19 As Integer = 0, Optional ByVal str20 As Integer = 0, Optional ByVal str21 As Integer = 0, Optional ByVal str22 As Integer = 0, Optional ByVal str23 As Integer = 0, Optional ByVal str24 As Integer = 0, Optional ByVal str25 As Integer = 0) As Integer()

            Dim ar(25) As Integer

            ar(0) = str1
            ar(1) = str2
            ar(2) = str3
            ar(3) = str4
            ar(4) = str5
            ar(5) = str6
            ar(6) = str7
            ar(7) = str8
            ar(8) = str9
            ar(9) = str10
            ar(10) = str11
            ar(11) = str12
            ar(12) = str13
            ar(13) = str14
            ar(14) = str15
            ar(15) = str16
            ar(16) = str17
            ar(17) = str18
            ar(18) = str19
            ar(19) = str20
            ar(20) = str21
            ar(21) = str22
            ar(22) = str23
            ar(23) = str24
            ar(24) = str25

            Return ar

        End Function

        Shared Function colorArray(ByVal context As HttpContext) As Array
            Dim myChart As C21MIT.PBSIS.BO.ChartInfoset
            'myChart = C21MIT.PBSIS.BLL.pbsreports.getReportInfo(context.Request.QueryString("chartid"), context.Request.QueryString("SchoolYear"), context.Request.QueryString("DistId"), context.Request.QueryString("SchType"))

            ''If Not context.Request.QueryString("sRptSchID") Is Nothing Then
            ''    If context.Request.QueryString("sRptSchID") = "" Then
            ''        myChart = C21MIT.PBSIS.BLL.pbsreports.getReportInfo(context.Request.QueryString("chartid"), context.Request.QueryString("SchoolYear"), context.Request.QueryString("DistId"), context.Request.QueryString("SchType"), "")
            ''    Else
            ''        myChart = C21MIT.PBSIS.BLL.pbsreports.getReportInfo(context.Request.QueryString("chartid"), 0, "", 0, context.Request.QueryString("sRptSchID"))
            ''    End If

            ''Else
            ''    myChart = C21MIT.PBSIS.BLL.pbsreports.getReportInfo(context.Request.QueryString("chartid"), context.Request.QueryString("SchoolYear"), context.Request.QueryString("DistId"), context.Request.QueryString("SchType"), "")
            ''End If

            If context.Request.QueryString("sRptSchID") <> "" Then
                '     myChart = C21MIT.PBSIS.BLL.pbsreports.getReportInfo(chartid, 0, "", 0, context.Request.QueryString("sRptSchID"))

                If context.Request.QueryString("SchoolYear") = "" Then
                    myChart = C21MIT.PBSIS.BLL.pbsreports.getReportInfo(context.Request.QueryString("chartid"), 0, "", 0, context.Request.QueryString("sRptSchID"))
                Else
                    myChart = C21MIT.PBSIS.BLL.pbsreports.getReportInfo(context.Request.QueryString("chartid"), context.Request.QueryString("SchoolYear"), "", 0, context.Request.QueryString("sRptSchID"))
                End If


            Else
                myChart = C21MIT.PBSIS.BLL.pbsreports.getReportInfo(context.Request.QueryString("chartid"), context.Request.QueryString("SchoolYear"), context.Request.QueryString("DistId"), context.Request.QueryString("SchType"), "")

            End If



            Dim c As XYChart = New XYChart(myChart.ChartWidth, myChart.ChartHeight)
            Dim bcol As String = "&H0066CC"
            Dim wcol As String = "&Hffffff"

            Dim actualColor As String

            actualColor = c.patternColor(ReturnArrayMethod(wcol, wcol, wcol, bcol, _
             wcol, wcol, bcol, wcol, wcol, bcol, wcol, _
             wcol, bcol, wcol, wcol, wcol), 4)

            Dim actualColor2 As String

            actualColor2 = c.patternColor(ReturnArrayMethod(wcol, wcol, wcol, wcol, _
             wcol, wcol, wcol, wcol, bcol, bcol, bcol, _
             bcol, bcol, bcol, bcol, bcol), 4)

            Dim actualColor3 As String
            actualColor3 = c.patternColor(ReturnArrayMethod(wcol, bcol, wcol, _
             bcol, bcol, bcol, _
             wcol, bcol, wcol), 3)

            Dim actualColor4 As String

            actualColor4 = c.patternColor(ReturnArrayMethod(bcol, wcol, wcol, wcol, _
             wcol, bcol, wcol, wcol, wcol, wcol, bcol, _
             wcol, wcol, wcol, wcol, bcol), 4)

            Dim actualColor5 As String

            actualColor5 = c.patternColor(ReturnArrayMethod(wcol, wcol, bcol, wcol, wcol, _
             wcol, wcol, bcol, wcol, wcol, _
             bcol, bcol, bcol, bcol, bcol, _
             wcol, wcol, bcol, wcol, wcol, _
             wcol, wcol, bcol, wcol, wcol), 5)

            'colorArray = ReturnArrayMethod("&H760c0c", "&H29abb0", "&H2e4cd0", "&H83bcf0", "&H488a13", "&He7eb72")
            colorArray = ReturnArrayMethod(bcol, actualColor, actualColor2, actualColor3, actualColor4, actualColor5)

        End Function

        Private Function GetImage(ByVal id As Integer) As Image
            ' Not sure how you are building your MemoryStream
            ' Once you have it, you just use the Image class to 
            ' create the image from the stream.

            Dim stream As New MemoryStream()
            Return System.Drawing.Image.FromStream(stream)
        End Function


        Shared Function getFontInfo(ByVal strnode As XmlNode, ByVal index As Integer) As C21MIT.PBSIS.BO.ChartInfoset
            Dim myChart As New C21MIT.PBSIS.BO.ChartInfoset
            If strnode.HasChildNodes Then
                myChart.FontFace = strnode.LastChild.Attributes.ItemOf(0).Value
                myChart.FontColor = strnode.LastChild.Attributes.ItemOf(1).Value
                myChart.FontSize = strnode.LastChild.Attributes.ItemOf(2).Value
            End If
            Return myChart
        End Function

    End Class
End Namespace