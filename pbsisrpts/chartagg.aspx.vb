Imports ChartDirector

Partial Class pbsisrpts_chartagg
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Request.QueryString("sRptSchID") Is Nothing Then
            lblSchoolName.Text = C21MIT.PBSIS.BLL.pbsdemodata.fngetdemodataEndYearSchool(C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("sRptSchID")), C21MIT.PBSIS.BLL.pbslogindetails.GetCurrentPrimTracker.schoolyear).SchoolName
            lblDistName.Text = C21MIT.PBSIS.BLL.pbsdemodata.fngetdemodataEndYearSchool(C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("sRptSchID")), C21MIT.PBSIS.BLL.pbslogindetails.GetCurrentPrimTracker.schoolyear).DistrictName
            Image1.ImageUrl = "~/pbsisrpts/Chart.ashx?sRptSchID=" & C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("sRptSchID")) & "&SchoolYear=" & Request.QueryString("SchoolYear") & "&DistId=" & C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistId")) & "&DistName=" & Request.QueryString("DistName") & "&SchType=" & Request.QueryString("SchType") & "&chartid=" & Request.QueryString("chartid") & ""
        Else
            lblschName.Visible = False
            If Not Request.QueryString("DistId") Is Nothing Then
                lblDistName.Text = C21MIT.PBSIS.BLL.pbsdistrict.getdistname(C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistId"))).DistrictName
                Image1.ImageUrl = "~/pbsisrpts/Chart.ashx?SchoolYear=" & Request.QueryString("SchoolYear") & "&DistId=" & C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistId")) & "&DistName=" & Request.QueryString("DistName") & "&SchType=" & Request.QueryString("SchType") & "&chartid=39_0"
                Image2.ImageUrl = "~/pbsisrpts/Chart.ashx?SchoolYear=" & Request.QueryString("SchoolYear") & "&DistId=" & C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistId")) & "&DistName=" & Request.QueryString("DistName") & "&SchType=" & Request.QueryString("SchType") & "&chartid=38_0"
                Image3.ImageUrl = "~/pbsisrpts/Chart.ashx?SchoolYear=" & Request.QueryString("SchoolYear") & "&DistId=" & C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistId")) & "&DistName=" & Request.QueryString("DistName") & "&SchType=0&chartid=41_0"
                Image4.ImageUrl = "~/pbsisrpts/Chart.ashx?SchoolYear=" & Request.QueryString("SchoolYear") & "&DistId=" & C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistId")) & "&DistName=" & Request.QueryString("DistName") & "&SchType=1&chartid=41_0"
                Image5.ImageUrl = "~/pbsisrpts/Chart.ashx?SchoolYear=" & Request.QueryString("SchoolYear") & "&DistId=" & C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistId")) & "&DistName=" & Request.QueryString("DistName") & "&SchType=2&chartid=41_0"
                Image6.ImageUrl = "~/pbsisrpts/Chart.ashx?SchoolYear=" & Request.QueryString("SchoolYear") & "&DistId=" & C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistId")) & "&DistName=" & Request.QueryString("DistName") & "&SchType=3&chartid=41_0"
                Image7.ImageUrl = "~/pbsisrpts/Chart.ashx?SchoolYear=" & Request.QueryString("SchoolYear") & "&DistId=" & C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistId")) & "&DistName=" & Request.QueryString("DistName") & "&SchType=4&chartid=41_0"
                Image8.ImageUrl = "~/pbsisrpts/Chart.ashx?SchoolYear=" & Request.QueryString("SchoolYear") & "&DistId=" & C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistId")) & "&DistName=" & Request.QueryString("DistName") & "&chartid=36_0"
                Image9.ImageUrl = "~/pbsisrpts/Chart.ashx?SchoolYear=" & Request.QueryString("SchoolYear") & "&DistId=" & C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistId")) & "&DistName=" & Request.QueryString("DistName") & "&chartid=32_0"
                Image10.ImageUrl = "~/pbsisrpts/Chart.ashx?SchoolYear=" & Request.QueryString("SchoolYear") & "&DistId=" & C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistId")) & "&DistName=" & Request.QueryString("DistName") & "&chartid=31_0"
                Image11.ImageUrl = "~/pbsisrpts/Chart.ashx?SchoolYear=" & Request.QueryString("SchoolYear") & "&DistId=" & C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistId")) & "&DistName=" & Request.QueryString("DistName") & "&SchType=0&chartid=40_0"
                Image12.ImageUrl = "~/pbsisrpts/Chart.ashx?SchoolYear=" & Request.QueryString("SchoolYear") & "&DistId=" & C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistId")) & "&DistName=" & Request.QueryString("DistName") & "&SchType=1&chartid=40_0"
                Image13.ImageUrl = "~/pbsisrpts/Chart.ashx?SchoolYear=" & Request.QueryString("SchoolYear") & "&DistId=" & C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistId")) & "&DistName=" & Request.QueryString("DistName") & "&SchType=2&chartid=40_0"
                Image14.ImageUrl = "~/pbsisrpts/Chart.ashx?SchoolYear=" & Request.QueryString("SchoolYear") & "&DistId=" & C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistId")) & "&DistName=" & Request.QueryString("DistName") & "&SchType=3&chartid=40_0"
                Image15.ImageUrl = "~/pbsisrpts/Chart.ashx?SchoolYear=" & Request.QueryString("SchoolYear") & "&DistId=" & C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistId")) & "&DistName=" & Request.QueryString("DistName") & "&SchType=4&chartid=40_0"
                Image16.ImageUrl = "~/pbsisrpts/Chart.ashx?SchoolYear=" & Request.QueryString("SchoolYear") & "&DistId=" & C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistId")) & "&DistName=" & Request.QueryString("DistName") & "&chartid=33_0"
                Image17.ImageUrl = "~/pbsisrpts/Chart.ashx?SchoolYear=" & Request.QueryString("SchoolYear") & "&DistId=" & C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistId")) & "&DistName=" & Request.QueryString("DistName") & "&chartid=34_0"
                Image18.ImageUrl = "~/pbsisrpts/Chart.ashx?SchoolYear=" & Request.QueryString("SchoolYear") & "&DistId=" & C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistId")) & "&DistName=" & Request.QueryString("DistName") & "&chartid=35_0"
                Image19.ImageUrl = "~/pbsisrpts/Chart.ashx?SchoolYear=" & Request.QueryString("SchoolYear") & "&DistId=" & C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistId")) & "&DistName=" & Request.QueryString("DistName") & "&chartid=37_0"

                Image20.ImageUrl = "~/pbsisrpts/Chart.ashx?SchoolYear=" & Request.QueryString("SchoolYear") & "&DistId=" & C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistId")) & "&DistName=" & Request.QueryString("DistName") & "&chartid=44_0"
                Image21.ImageUrl = "~/pbsisrpts/Chart.ashx?SchoolYear=" & Request.QueryString("SchoolYear") & "&DistId=" & C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistId")) & "&DistName=" & Request.QueryString("DistName") & "&chartid=45_0"

                Image22.ImageUrl = "~/pbsisrpts/Chart.ashx?SchoolYear=" & Request.QueryString("SchoolYear") & "&DistId=" & C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistId")) & "&DistName=" & Request.QueryString("DistName") & "&SchType=0&chartid=46_0"
                Image23.ImageUrl = "~/pbsisrpts/Chart.ashx?SchoolYear=" & Request.QueryString("SchoolYear") & "&DistId=" & C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistId")) & "&DistName=" & Request.QueryString("DistName") & "&SchType=1&chartid=46_0"
                Image24.ImageUrl = "~/pbsisrpts/Chart.ashx?SchoolYear=" & Request.QueryString("SchoolYear") & "&DistId=" & C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistId")) & "&DistName=" & Request.QueryString("DistName") & "&SchType=2&chartid=46_0"
                Image25.ImageUrl = "~/pbsisrpts/Chart.ashx?SchoolYear=" & Request.QueryString("SchoolYear") & "&DistId=" & C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistId")) & "&DistName=" & Request.QueryString("DistName") & "&SchType=3&chartid=46_0"
                Image26.ImageUrl = "~/pbsisrpts/Chart.ashx?SchoolYear=" & Request.QueryString("SchoolYear") & "&DistId=" & C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistId")) & "&DistName=" & Request.QueryString("DistName") & "&SchType=4&chartid=46_0"

                Image27.ImageUrl = "~/pbsisrpts/Chart.ashx?SchoolYear=" & Request.QueryString("SchoolYear") & "&DistId=" & C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistId")) & "&DistName=" & Request.QueryString("DistName") & "&SchType=0&chartid=47_0"
                Image28.ImageUrl = "~/pbsisrpts/Chart.ashx?SchoolYear=" & Request.QueryString("SchoolYear") & "&DistId=" & C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistId")) & "&DistName=" & Request.QueryString("DistName") & "&SchType=1&chartid=47_0"
                Image29.ImageUrl = "~/pbsisrpts/Chart.ashx?SchoolYear=" & Request.QueryString("SchoolYear") & "&DistId=" & C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistId")) & "&DistName=" & Request.QueryString("DistName") & "&SchType=2&chartid=47_0"
                Image30.ImageUrl = "~/pbsisrpts/Chart.ashx?SchoolYear=" & Request.QueryString("SchoolYear") & "&DistId=" & C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistId")) & "&DistName=" & Request.QueryString("DistName") & "&SchType=3&chartid=47_0"
                Image31.ImageUrl = "~/pbsisrpts/Chart.ashx?SchoolYear=" & Request.QueryString("SchoolYear") & "&DistId=" & C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistId")) & "&DistName=" & Request.QueryString("DistName") & "&SchType=4&chartid=47_0"

            Else
                lblDistName.Text = C21MIT.PBSIS.BLL.pbsdistrict.getdistname(C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Session("sDistId"))).DistrictName
                Image1.ImageUrl = "~/pbsisrpts/Chart.ashx?SchoolYear=" & Request.QueryString("SchoolYear") & "&DistId=" & C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistId")) & "&DistName=" & Request.QueryString("DistName") & "&SchType=" & Request.QueryString("SchType") & "&chartid=39_0"
                Image2.ImageUrl = "~/pbsisrpts/Chart.ashx?SchoolYear=" & Request.QueryString("SchoolYear") & "&DistId=" & C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistId")) & "&DistName=" & Request.QueryString("DistName") & "&SchType=" & Request.QueryString("SchType") & "&chartid=38_0"
                Image3.ImageUrl = "~/pbsisrpts/Chart.ashx?SchoolYear=" & Request.QueryString("SchoolYear") & "&DistId=" & C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistId")) & "&DistName=" & Request.QueryString("DistName") & "&SchType=0&chartid=41_0"
                Image4.ImageUrl = "~/pbsisrpts/Chart.ashx?SchoolYear=" & Request.QueryString("SchoolYear") & "&DistId=" & C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistId")) & "&DistName=" & Request.QueryString("DistName") & "&SchType=1&chartid=41_0"
                Image5.ImageUrl = "~/pbsisrpts/Chart.ashx?SchoolYear=" & Request.QueryString("SchoolYear") & "&DistId=" & C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistId")) & "&DistName=" & Request.QueryString("DistName") & "&SchType=2&chartid=41_0"
                Image6.ImageUrl = "~/pbsisrpts/Chart.ashx?SchoolYear=" & Request.QueryString("SchoolYear") & "&DistId=" & C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistId")) & "&DistName=" & Request.QueryString("DistName") & "&SchType=3&chartid=41_0"
                Image7.ImageUrl = "~/pbsisrpts/Chart.ashx?SchoolYear=" & Request.QueryString("SchoolYear") & "&DistId=" & C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistId")) & "&DistName=" & Request.QueryString("DistName") & "&SchType=4&chartid=41_0"
                Image8.ImageUrl = "~/pbsisrpts/Chart.ashx?SchoolYear=" & Request.QueryString("SchoolYear") & "&DistId=" & C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistId")) & "&DistName=" & Request.QueryString("DistName") & "&chartid=36_0"
                Image9.ImageUrl = "~/pbsisrpts/Chart.ashx?SchoolYear=" & Request.QueryString("SchoolYear") & "&DistId=" & C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistId")) & "&DistName=" & Request.QueryString("DistName") & "&chartid=32_0"
                Image10.ImageUrl = "~/pbsisrpts/Chart.ashx?SchoolYear=" & Request.QueryString("SchoolYear") & "&DistId=" & C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistId")) & "&DistName=" & Request.QueryString("DistName") & "&chartid=31_0"
                Image11.ImageUrl = "~/pbsisrpts/Chart.ashx?SchoolYear=" & Request.QueryString("SchoolYear") & "&DistId=" & C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistId")) & "&DistName=" & Request.QueryString("DistName") & "&SchType=0&chartid=40_0"
                Image12.ImageUrl = "~/pbsisrpts/Chart.ashx?SchoolYear=" & Request.QueryString("SchoolYear") & "&DistId=" & C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistId")) & "&DistName=" & Request.QueryString("DistName") & "&SchType=1&chartid=40_0"
                Image13.ImageUrl = "~/pbsisrpts/Chart.ashx?SchoolYear=" & Request.QueryString("SchoolYear") & "&DistId=" & C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistId")) & "&DistName=" & Request.QueryString("DistName") & "&SchType=2&chartid=40_0"
                Image14.ImageUrl = "~/pbsisrpts/Chart.ashx?SchoolYear=" & Request.QueryString("SchoolYear") & "&DistId=" & C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistId")) & "&DistName=" & Request.QueryString("DistName") & "&SchType=3&chartid=40_0"
                Image15.ImageUrl = "~/pbsisrpts/Chart.ashx?SchoolYear=" & Request.QueryString("SchoolYear") & "&DistId=" & C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistId")) & "&DistName=" & Request.QueryString("DistName") & "&SchType=4&chartid=40_0"
                Image16.ImageUrl = "~/pbsisrpts/Chart.ashx?SchoolYear=" & Request.QueryString("SchoolYear") & "&DistId=" & C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistId")) & "&DistName=" & Request.QueryString("DistName") & "&chartid=33_0"
                Image17.ImageUrl = "~/pbsisrpts/Chart.ashx?SchoolYear=" & Request.QueryString("SchoolYear") & "&DistId=" & C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistId")) & "&DistName=" & Request.QueryString("DistName") & "&chartid=34_0"
                Image18.ImageUrl = "~/pbsisrpts/Chart.ashx?SchoolYear=" & Request.QueryString("SchoolYear") & "&DistId=" & C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistId")) & "&DistName=" & Request.QueryString("DistName") & "&chartid=35_0"
                Image19.ImageUrl = "~/pbsisrpts/Chart.ashx?SchoolYear=" & Request.QueryString("SchoolYear") & "&DistId=" & C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistId")) & "&DistName=" & Request.QueryString("DistName") & "&chartid=37_0"

                Image20.ImageUrl = "~/pbsisrpts/Chart.ashx?SchoolYear=" & Request.QueryString("SchoolYear") & "&DistId=" & C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistId")) & "&DistName=" & Request.QueryString("DistName") & "&chartid=44_0"
                Image21.ImageUrl = "~/pbsisrpts/Chart.ashx?SchoolYear=" & Request.QueryString("SchoolYear") & "&DistId=" & C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistId")) & "&DistName=" & Request.QueryString("DistName") & "&chartid=45_0"

                Image22.ImageUrl = "~/pbsisrpts/Chart.ashx?SchoolYear=" & Request.QueryString("SchoolYear") & "&DistId=" & C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistId")) & "&DistName=" & Request.QueryString("DistName") & "&SchType=0&chartid=46_0"
                Image23.ImageUrl = "~/pbsisrpts/Chart.ashx?SchoolYear=" & Request.QueryString("SchoolYear") & "&DistId=" & C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistId")) & "&DistName=" & Request.QueryString("DistName") & "&SchType=1&chartid=46_0"
                Image24.ImageUrl = "~/pbsisrpts/Chart.ashx?SchoolYear=" & Request.QueryString("SchoolYear") & "&DistId=" & C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistId")) & "&DistName=" & Request.QueryString("DistName") & "&SchType=2&chartid=46_0"
                Image25.ImageUrl = "~/pbsisrpts/Chart.ashx?SchoolYear=" & Request.QueryString("SchoolYear") & "&DistId=" & C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistId")) & "&DistName=" & Request.QueryString("DistName") & "&SchType=3&chartid=46_0"
                Image26.ImageUrl = "~/pbsisrpts/Chart.ashx?SchoolYear=" & Request.QueryString("SchoolYear") & "&DistId=" & C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistId")) & "&DistName=" & Request.QueryString("DistName") & "&SchType=4&chartid=46_0"


                Image27.ImageUrl = "~/pbsisrpts/Chart.ashx?SchoolYear=" & Request.QueryString("SchoolYear") & "&DistId=" & C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistId")) & "&DistName=" & Request.QueryString("DistName") & "&SchType=0&chartid=47_0"
                Image28.ImageUrl = "~/pbsisrpts/Chart.ashx?SchoolYear=" & Request.QueryString("SchoolYear") & "&DistId=" & C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistId")) & "&DistName=" & Request.QueryString("DistName") & "&SchType=1&chartid=47_0"
                Image29.ImageUrl = "~/pbsisrpts/Chart.ashx?SchoolYear=" & Request.QueryString("SchoolYear") & "&DistId=" & C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistId")) & "&DistName=" & Request.QueryString("DistName") & "&SchType=2&chartid=47_0"
                Image30.ImageUrl = "~/pbsisrpts/Chart.ashx?SchoolYear=" & Request.QueryString("SchoolYear") & "&DistId=" & C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistId")) & "&DistName=" & Request.QueryString("DistName") & "&SchType=3&chartid=47_0"
                Image31.ImageUrl = "~/pbsisrpts/Chart.ashx?SchoolYear=" & Request.QueryString("SchoolYear") & "&DistId=" & C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistId")) & "&DistName=" & Request.QueryString("DistName") & "&SchType=4&chartid=47_0"

            End If
        End If
        '=============================
        ' To set the title of the page


        Dim myChart1 As New C21MIT.PBSIS.BO.ChartInfoset
        Dim myChart2 As New C21MIT.PBSIS.BO.ChartInfoset
        Dim myChart3 As New C21MIT.PBSIS.BO.ChartInfoset
        Dim myChart4 As New C21MIT.PBSIS.BO.ChartInfoset
        Dim myChart5 As New C21MIT.PBSIS.BO.ChartInfoset
        Dim myChart6 As New C21MIT.PBSIS.BO.ChartInfoset
        Dim myChart7 As New C21MIT.PBSIS.BO.ChartInfoset
        Dim myChart8 As New C21MIT.PBSIS.BO.ChartInfoset
        Dim myChart9 As New C21MIT.PBSIS.BO.ChartInfoset
        Dim myChart10 As New C21MIT.PBSIS.BO.ChartInfoset
        Dim myChart11 As New C21MIT.PBSIS.BO.ChartInfoset
        Dim myChart12 As New C21MIT.PBSIS.BO.ChartInfoset
        Dim myChart13 As New C21MIT.PBSIS.BO.ChartInfoset
        Dim myChart14 As New C21MIT.PBSIS.BO.ChartInfoset
        Dim myChart15 As New C21MIT.PBSIS.BO.ChartInfoset
        Dim myChart16 As New C21MIT.PBSIS.BO.ChartInfoset
        Dim myChart17 As New C21MIT.PBSIS.BO.ChartInfoset
        Dim myChart18 As New C21MIT.PBSIS.BO.ChartInfoset
        Dim myChart19 As New C21MIT.PBSIS.BO.ChartInfoset

        Dim myChart20 As New C21MIT.PBSIS.BO.ChartInfoset
        Dim myChart21 As New C21MIT.PBSIS.BO.ChartInfoset
        Dim myChart22 As New C21MIT.PBSIS.BO.ChartInfoset
        Dim myChart23 As New C21MIT.PBSIS.BO.ChartInfoset
        Dim myChart24 As New C21MIT.PBSIS.BO.ChartInfoset
        Dim myChart25 As New C21MIT.PBSIS.BO.ChartInfoset
        Dim myChart26 As New C21MIT.PBSIS.BO.ChartInfoset
        Dim myChart27 As New C21MIT.PBSIS.BO.ChartInfoset
        Dim myChart28 As New C21MIT.PBSIS.BO.ChartInfoset
        Dim myChart29 As New C21MIT.PBSIS.BO.ChartInfoset
        Dim myChart30 As New C21MIT.PBSIS.BO.ChartInfoset
        Dim myChart31 As New C21MIT.PBSIS.BO.ChartInfoset

        'Chart1
        myChart1 = C21MIT.PBSIS.BLL.pbsreports.getReportInfo("39_0", Context.Request.QueryString("SchoolYear"), C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Context.Request.QueryString("DistId")), Context.Request.QueryString("SchType"), "")
        If myChart1.ChartGroupBy = "True" Then
            Label1.Text = C21MIT.PBSIS.BLL.pbsreports.getReportInfo("39_0", Context.Request.QueryString("SchoolYear"), C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Context.Request.QueryString("DistId")), Context.Request.QueryString("SchType"), "").ChartTitle & " " & "(Grouped by " & C21MIT.PBSIS.BLL.pbsschoolyeardesc.getSchTypeName(Context.Request.QueryString("SchType")) & ")"
        ElseIf myChart1.ChartGroupBy = "False" Then
            Label1.Text = C21MIT.PBSIS.BLL.pbsreports.getReportInfo("39_0", Context.Request.QueryString("SchoolYear"), C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Context.Request.QueryString("DistId")), Context.Request.QueryString("SchType"), "").ChartTitle
        End If

        'Chart2
        myChart2 = C21MIT.PBSIS.BLL.pbsreports.getReportInfo("38_0", Context.Request.QueryString("SchoolYear"), C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Context.Request.QueryString("DistId")), Context.Request.QueryString("SchType"), "")

        If myChart2.ChartGroupBy = "True" Then
            Label2.Text = C21MIT.PBSIS.BLL.pbsreports.getReportInfo("38_0", Context.Request.QueryString("SchoolYear"), C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Context.Request.QueryString("DistId")), Context.Request.QueryString("SchType"), "").ChartTitle & " " & "(Grouped by " & C21MIT.PBSIS.BLL.pbsschoolyeardesc.getSchTypeName(Context.Request.QueryString("SchType")) & ")"
        ElseIf myChart2.ChartGroupBy = "False" Then
            Label2.Text = C21MIT.PBSIS.BLL.pbsreports.getReportInfo("38_0", Context.Request.QueryString("SchoolYear"), C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Context.Request.QueryString("DistId")), Context.Request.QueryString("SchType"), "").ChartTitle
        End If

        'Chart3
        myChart3 = C21MIT.PBSIS.BLL.pbsreports.getReportInfo("41_0", Context.Request.QueryString("SchoolYear"), C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Context.Request.QueryString("DistId")), 0, "")

        If myChart3.ChartGroupBy = "True" Then
            Label3.Text = C21MIT.PBSIS.BLL.pbsreports.getReportInfo("41_0", Context.Request.QueryString("SchoolYear"), C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Context.Request.QueryString("DistId")), 0, "").ChartTitle & " " & "(Grouped by " & C21MIT.PBSIS.BLL.pbsschoolyeardesc.getSchTypeName(0) & ")"
        ElseIf myChart3.ChartGroupBy = "False" Then
            Label3.Text = C21MIT.PBSIS.BLL.pbsreports.getReportInfo("41_0", Context.Request.QueryString("SchoolYear"), C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Context.Request.QueryString("DistId")), 0, "").ChartTitle
        End If

        'Chart4
        myChart4 = C21MIT.PBSIS.BLL.pbsreports.getReportInfo("41_0", Context.Request.QueryString("SchoolYear"), C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Context.Request.QueryString("DistId")), 1, "")

        If myChart4.ChartGroupBy = "True" Then
            Label4.Text = C21MIT.PBSIS.BLL.pbsreports.getReportInfo("41_0", Context.Request.QueryString("SchoolYear"), C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Context.Request.QueryString("DistId")), 1, "").ChartTitle & " " & "(Grouped by " & C21MIT.PBSIS.BLL.pbsschoolyeardesc.getSchTypeName(1) & ")"
        ElseIf myChart4.ChartGroupBy = "False" Then
            Label4.Text = C21MIT.PBSIS.BLL.pbsreports.getReportInfo("41_0", Context.Request.QueryString("SchoolYear"), C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Context.Request.QueryString("DistId")), 1, "").ChartTitle
        End If

        'Chart5
        myChart5 = C21MIT.PBSIS.BLL.pbsreports.getReportInfo("41_0", Context.Request.QueryString("SchoolYear"), C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Context.Request.QueryString("DistId")), 2, "")

        If myChart5.ChartGroupBy = "True" Then
            Label5.Text = C21MIT.PBSIS.BLL.pbsreports.getReportInfo("41_0", Context.Request.QueryString("SchoolYear"), C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Context.Request.QueryString("DistId")), 2, "").ChartTitle & " " & "(Grouped by " & C21MIT.PBSIS.BLL.pbsschoolyeardesc.getSchTypeName(2) & ")"
        ElseIf myChart5.ChartGroupBy = "False" Then
            Label5.Text = C21MIT.PBSIS.BLL.pbsreports.getReportInfo("41_0", Context.Request.QueryString("SchoolYear"), C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Context.Request.QueryString("DistId")), 2, "").ChartTitle
        End If

        'Chart6
        myChart6 = C21MIT.PBSIS.BLL.pbsreports.getReportInfo("41_0", Context.Request.QueryString("SchoolYear"), C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Context.Request.QueryString("DistId")), 3, "")

        If myChart6.ChartGroupBy = "True" Then
            Label6.Text = C21MIT.PBSIS.BLL.pbsreports.getReportInfo("41_0", Context.Request.QueryString("SchoolYear"), C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Context.Request.QueryString("DistId")), 3, "").ChartTitle & " " & "(Grouped by " & C21MIT.PBSIS.BLL.pbsschoolyeardesc.getSchTypeName(3) & ")"
        ElseIf myChart6.ChartGroupBy = "False" Then
            Label6.Text = C21MIT.PBSIS.BLL.pbsreports.getReportInfo("41_0", Context.Request.QueryString("SchoolYear"), C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Context.Request.QueryString("DistId")), 3, "").ChartTitle
        End If

        'Chart7
        myChart7 = C21MIT.PBSIS.BLL.pbsreports.getReportInfo("41_0", Context.Request.QueryString("SchoolYear"), C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Context.Request.QueryString("DistId")), 4, "")

        If myChart7.ChartGroupBy = "True" Then
            Label7.Text = C21MIT.PBSIS.BLL.pbsreports.getReportInfo("41_0", Context.Request.QueryString("SchoolYear"), C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Context.Request.QueryString("DistId")), 4, "").ChartTitle & " " & "(Grouped by " & C21MIT.PBSIS.BLL.pbsschoolyeardesc.getSchTypeName(4) & ")"
        ElseIf myChart7.ChartGroupBy = "False" Then
            Label7.Text = C21MIT.PBSIS.BLL.pbsreports.getReportInfo("41_0", Context.Request.QueryString("SchoolYear"), C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Context.Request.QueryString("DistId")), 4, "").ChartTitle
        End If

        'Chart8
        myChart8 = C21MIT.PBSIS.BLL.pbsreports.getReportInfo("36_0", Context.Request.QueryString("SchoolYear"), C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Context.Request.QueryString("DistId")), Context.Request.QueryString("SchType"), "")

        If myChart8.ChartGroupBy = "True" Then
            Label8.Text = C21MIT.PBSIS.BLL.pbsreports.getReportInfo("36_0", Context.Request.QueryString("SchoolYear"), C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Context.Request.QueryString("DistId")), Context.Request.QueryString("SchType"), "").ChartTitle & " " & "(Grouped by " & C21MIT.PBSIS.BLL.pbsschoolyeardesc.getSchTypeName(Context.Request.QueryString("SchType")) & ")"
        ElseIf myChart8.ChartGroupBy = "False" Then
            Label8.Text = C21MIT.PBSIS.BLL.pbsreports.getReportInfo("36_0", Context.Request.QueryString("SchoolYear"), C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Context.Request.QueryString("DistId")), Context.Request.QueryString("SchType"), "").ChartTitle
        End If

        'Chart9
        myChart9 = C21MIT.PBSIS.BLL.pbsreports.getReportInfo("32_0", Context.Request.QueryString("SchoolYear"), C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Context.Request.QueryString("DistId")), Context.Request.QueryString("SchType"), "")

        If myChart9.ChartGroupBy = "True" Then
            Label9.Text = C21MIT.PBSIS.BLL.pbsreports.getReportInfo("32_0", Context.Request.QueryString("SchoolYear"), C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Context.Request.QueryString("DistId")), Context.Request.QueryString("SchType"), "").ChartTitle & " " & "(Grouped by " & C21MIT.PBSIS.BLL.pbsschoolyeardesc.getSchTypeName(Context.Request.QueryString("SchType")) & ")"
        ElseIf myChart9.ChartGroupBy = "False" Then
            Label9.Text = C21MIT.PBSIS.BLL.pbsreports.getReportInfo("32_0", Context.Request.QueryString("SchoolYear"), C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Context.Request.QueryString("DistId")), Context.Request.QueryString("SchType"), "").ChartTitle
        End If

        'Chart10
        myChart10 = C21MIT.PBSIS.BLL.pbsreports.getReportInfo("31_0", Context.Request.QueryString("SchoolYear"), C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Context.Request.QueryString("DistId")), Context.Request.QueryString("SchType"), "")

        If myChart10.ChartGroupBy = "True" Then
            Label10.Text = C21MIT.PBSIS.BLL.pbsreports.getReportInfo("31_0", Context.Request.QueryString("SchoolYear"), C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Context.Request.QueryString("DistId")), Context.Request.QueryString("SchType"), "").ChartTitle & " " & "(Grouped by " & C21MIT.PBSIS.BLL.pbsschoolyeardesc.getSchTypeName(Context.Request.QueryString("SchType")) & ")"
        ElseIf myChart10.ChartGroupBy = "False" Then
            Label10.Text = C21MIT.PBSIS.BLL.pbsreports.getReportInfo("31_0", Context.Request.QueryString("SchoolYear"), C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Context.Request.QueryString("DistId")), Context.Request.QueryString("SchType"), "").ChartTitle
        End If

        'Chart11
        myChart11 = C21MIT.PBSIS.BLL.pbsreports.getReportInfo("40_0", Context.Request.QueryString("SchoolYear"), C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Context.Request.QueryString("DistId")), 0, "")

        If myChart11.ChartGroupBy = "True" Then
            Label11.Text = C21MIT.PBSIS.BLL.pbsreports.getReportInfo("40_0", Context.Request.QueryString("SchoolYear"), C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Context.Request.QueryString("DistId")), 0, "").ChartTitle & " " & "(Grouped by " & C21MIT.PBSIS.BLL.pbsschoolyeardesc.getSchTypeName(0) & ")"
        ElseIf myChart6.ChartGroupBy = "False" Then
            Label11.Text = C21MIT.PBSIS.BLL.pbsreports.getReportInfo("40_0", Context.Request.QueryString("SchoolYear"), C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Context.Request.QueryString("DistId")), 0, "").ChartTitle
        End If

        'Chart12
        myChart12 = C21MIT.PBSIS.BLL.pbsreports.getReportInfo("40_0", Context.Request.QueryString("SchoolYear"), C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Context.Request.QueryString("DistId")), 1, "")

        If myChart12.ChartGroupBy = "True" Then
            Label12.Text = C21MIT.PBSIS.BLL.pbsreports.getReportInfo("40_0", Context.Request.QueryString("SchoolYear"), C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Context.Request.QueryString("DistId")), 1, "").ChartTitle & " " & "(Grouped by " & C21MIT.PBSIS.BLL.pbsschoolyeardesc.getSchTypeName(1) & ")"
        ElseIf myChart12.ChartGroupBy = "False" Then
            Label12.Text = C21MIT.PBSIS.BLL.pbsreports.getReportInfo("40_0", Context.Request.QueryString("SchoolYear"), C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Context.Request.QueryString("DistId")), 1, "").ChartTitle
        End If

        'Chart13
        myChart13 = C21MIT.PBSIS.BLL.pbsreports.getReportInfo("40_0", Context.Request.QueryString("SchoolYear"), C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Context.Request.QueryString("DistId")), 2, "")

        If myChart13.ChartGroupBy = "True" Then
            Label13.Text = C21MIT.PBSIS.BLL.pbsreports.getReportInfo("40_0", Context.Request.QueryString("SchoolYear"), C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Context.Request.QueryString("DistId")), 2, "").ChartTitle & " " & "(Grouped by " & C21MIT.PBSIS.BLL.pbsschoolyeardesc.getSchTypeName(2) & ")"
        ElseIf myChart13.ChartGroupBy = "False" Then
            Label13.Text = C21MIT.PBSIS.BLL.pbsreports.getReportInfo("40_0", Context.Request.QueryString("SchoolYear"), C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Context.Request.QueryString("DistId")), 2, "").ChartTitle
        End If

        'Chart14
        myChart14 = C21MIT.PBSIS.BLL.pbsreports.getReportInfo("40_0", Context.Request.QueryString("SchoolYear"), C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Context.Request.QueryString("DistId")), 3, "")

        If myChart14.ChartGroupBy = "True" Then
            Label14.Text = C21MIT.PBSIS.BLL.pbsreports.getReportInfo("40_0", Context.Request.QueryString("SchoolYear"), C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Context.Request.QueryString("DistId")), 3, "").ChartTitle & " " & "(Grouped by " & C21MIT.PBSIS.BLL.pbsschoolyeardesc.getSchTypeName(3) & ")"
        ElseIf myChart14.ChartGroupBy = "False" Then
            Label14.Text = C21MIT.PBSIS.BLL.pbsreports.getReportInfo("40_0", Context.Request.QueryString("SchoolYear"), C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Context.Request.QueryString("DistId")), 3, "").ChartTitle
        End If

        'Chart15
        myChart15 = C21MIT.PBSIS.BLL.pbsreports.getReportInfo("40_0", Context.Request.QueryString("SchoolYear"), C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Context.Request.QueryString("DistId")), 4, "")

        If myChart15.ChartGroupBy = "True" Then
            Label15.Text = C21MIT.PBSIS.BLL.pbsreports.getReportInfo("40_0", Context.Request.QueryString("SchoolYear"), C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Context.Request.QueryString("DistId")), 4, "").ChartTitle & " " & "(Grouped by " & C21MIT.PBSIS.BLL.pbsschoolyeardesc.getSchTypeName(4) & ")"
        ElseIf myChart15.ChartGroupBy = "False" Then
            Label15.Text = C21MIT.PBSIS.BLL.pbsreports.getReportInfo("40_0", Context.Request.QueryString("SchoolYear"), C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Context.Request.QueryString("DistId")), 4, "").ChartTitle
        End If

        'Chart16
        myChart16 = C21MIT.PBSIS.BLL.pbsreports.getReportInfo("33_0", Context.Request.QueryString("SchoolYear"), C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Context.Request.QueryString("DistId")), Context.Request.QueryString("SchType"), "")

        If myChart16.ChartGroupBy = "True" Then
            Label16.Text = C21MIT.PBSIS.BLL.pbsreports.getReportInfo("33_0", Context.Request.QueryString("SchoolYear"), C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Context.Request.QueryString("DistId")), Context.Request.QueryString("SchType"), "").ChartTitle & " " & "(Grouped by " & C21MIT.PBSIS.BLL.pbsschoolyeardesc.getSchTypeName(Context.Request.QueryString("SchType")) & ")"
        ElseIf myChart16.ChartGroupBy = "False" Then
            Label16.Text = C21MIT.PBSIS.BLL.pbsreports.getReportInfo("33_0", Context.Request.QueryString("SchoolYear"), C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Context.Request.QueryString("DistId")), Context.Request.QueryString("SchType"), "").ChartTitle
        End If

        'Chart17
        myChart17 = C21MIT.PBSIS.BLL.pbsreports.getReportInfo("34_0", Context.Request.QueryString("SchoolYear"), C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Context.Request.QueryString("DistId")), Context.Request.QueryString("SchType"), "")

        If myChart17.ChartGroupBy = "True" Then
            Label17.Text = C21MIT.PBSIS.BLL.pbsreports.getReportInfo("34_0", Context.Request.QueryString("SchoolYear"), C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Context.Request.QueryString("DistId")), Context.Request.QueryString("SchType"), "").ChartTitle & " " & "(Grouped by " & C21MIT.PBSIS.BLL.pbsschoolyeardesc.getSchTypeName(Context.Request.QueryString("SchType")) & ")"
        ElseIf myChart17.ChartGroupBy = "False" Then
            Label17.Text = C21MIT.PBSIS.BLL.pbsreports.getReportInfo("34_0", Context.Request.QueryString("SchoolYear"), C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Context.Request.QueryString("DistId")), Context.Request.QueryString("SchType"), "").ChartTitle
        End If

        'Chart18
        myChart18 = C21MIT.PBSIS.BLL.pbsreports.getReportInfo("35_0", Context.Request.QueryString("SchoolYear"), C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Context.Request.QueryString("DistId")), Context.Request.QueryString("SchType"), "")

        If myChart18.ChartGroupBy = "True" Then
            Label18.Text = C21MIT.PBSIS.BLL.pbsreports.getReportInfo("35_0", Context.Request.QueryString("SchoolYear"), C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Context.Request.QueryString("DistId")), Context.Request.QueryString("SchType"), "").ChartTitle & " " & "(Grouped by " & C21MIT.PBSIS.BLL.pbsschoolyeardesc.getSchTypeName(Context.Request.QueryString("SchType")) & ")"
        ElseIf myChart18.ChartGroupBy = "False" Then
            Label18.Text = C21MIT.PBSIS.BLL.pbsreports.getReportInfo("35_0", Context.Request.QueryString("SchoolYear"), C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Context.Request.QueryString("DistId")), Context.Request.QueryString("SchType"), "").ChartTitle
        End If

        'Chart19
        myChart19 = C21MIT.PBSIS.BLL.pbsreports.getReportInfo("37_0", Context.Request.QueryString("SchoolYear"), C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Context.Request.QueryString("DistId")), Context.Request.QueryString("SchType"), "")

        If myChart19.ChartGroupBy = "True" Then
            Label19.Text = C21MIT.PBSIS.BLL.pbsreports.getReportInfo("37_0", Context.Request.QueryString("SchoolYear"), C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Context.Request.QueryString("DistId")), Context.Request.QueryString("SchType"), "").ChartTitle & " " & "(Grouped by " & C21MIT.PBSIS.BLL.pbsschoolyeardesc.getSchTypeName(Context.Request.QueryString("SchType")) & ")"
        ElseIf myChart19.ChartGroupBy = "False" Then
            Label19.Text = C21MIT.PBSIS.BLL.pbsreports.getReportInfo("37_0", Context.Request.QueryString("SchoolYear"), C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Context.Request.QueryString("DistId")), Context.Request.QueryString("SchType"), "").ChartTitle
        End If


        'Chart20
        myChart20 = C21MIT.PBSIS.BLL.pbsreports.getReportInfo("44_0", Context.Request.QueryString("SchoolYear"), C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Context.Request.QueryString("DistId")), Context.Request.QueryString("SchType"), "")

        If myChart20.ChartGroupBy = "True" Then
            Label20.Text = C21MIT.PBSIS.BLL.pbsreports.getReportInfo("44_0", Context.Request.QueryString("SchoolYear"), C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Context.Request.QueryString("DistId")), Context.Request.QueryString("SchType"), "").ChartTitle & " " & "(Grouped by " & C21MIT.PBSIS.BLL.pbsschoolyeardesc.getSchTypeName(Context.Request.QueryString("SchType")) & ")"
        ElseIf myChart20.ChartGroupBy = "False" Then
            Label20.Text = C21MIT.PBSIS.BLL.pbsreports.getReportInfo("44_0", Context.Request.QueryString("SchoolYear"), C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Context.Request.QueryString("DistId")), Context.Request.QueryString("SchType"), "").ChartTitle
        End If

        'Chart21
        myChart21 = C21MIT.PBSIS.BLL.pbsreports.getReportInfo("45_0", Context.Request.QueryString("SchoolYear"), C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Context.Request.QueryString("DistId")), Context.Request.QueryString("SchType"), "")

        If myChart21.ChartGroupBy = "True" Then
            Label21.Text = C21MIT.PBSIS.BLL.pbsreports.getReportInfo("45_0", Context.Request.QueryString("SchoolYear"), C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Context.Request.QueryString("DistId")), Context.Request.QueryString("SchType"), "").ChartTitle & " " & "(Grouped by " & C21MIT.PBSIS.BLL.pbsschoolyeardesc.getSchTypeName(Context.Request.QueryString("SchType")) & ")"
        ElseIf myChart21.ChartGroupBy = "False" Then
            Label21.Text = C21MIT.PBSIS.BLL.pbsreports.getReportInfo("45_0", Context.Request.QueryString("SchoolYear"), C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Context.Request.QueryString("DistId")), Context.Request.QueryString("SchType"), "").ChartTitle
        End If

        'Chart22
        myChart22 = C21MIT.PBSIS.BLL.pbsreports.getReportInfo("46_0", Context.Request.QueryString("SchoolYear"), C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Context.Request.QueryString("DistId")), 0, "")

        If myChart22.ChartGroupBy = "True" Then
            Label22.Text = C21MIT.PBSIS.BLL.pbsreports.getReportInfo("46_0", Context.Request.QueryString("SchoolYear"), C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Context.Request.QueryString("DistId")), 0, "").ChartTitle & " " & "(Grouped by " & C21MIT.PBSIS.BLL.pbsschoolyeardesc.getSchTypeName(0) & ")"
        ElseIf myChart22.ChartGroupBy = "False" Then
            Label22.Text = C21MIT.PBSIS.BLL.pbsreports.getReportInfo("46_0", Context.Request.QueryString("SchoolYear"), C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Context.Request.QueryString("DistId")), 0, "").ChartTitle
        End If


        'Chart23
        myChart23 = C21MIT.PBSIS.BLL.pbsreports.getReportInfo("46_0", Context.Request.QueryString("SchoolYear"), C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Context.Request.QueryString("DistId")), 1, "")

        If myChart23.ChartGroupBy = "True" Then
            Label23.Text = C21MIT.PBSIS.BLL.pbsreports.getReportInfo("46_0", Context.Request.QueryString("SchoolYear"), C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Context.Request.QueryString("DistId")), 1, "").ChartTitle & " " & "(Grouped by " & C21MIT.PBSIS.BLL.pbsschoolyeardesc.getSchTypeName(1) & ")"
        ElseIf myChart23.ChartGroupBy = "False" Then
            Label23.Text = C21MIT.PBSIS.BLL.pbsreports.getReportInfo("46_0", Context.Request.QueryString("SchoolYear"), C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Context.Request.QueryString("DistId")), 1, "").ChartTitle
        End If


        'Chart24
        myChart24 = C21MIT.PBSIS.BLL.pbsreports.getReportInfo("46_0", Context.Request.QueryString("SchoolYear"), C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Context.Request.QueryString("DistId")), 2, "")

        If myChart24.ChartGroupBy = "True" Then
            Label24.Text = C21MIT.PBSIS.BLL.pbsreports.getReportInfo("46_0", Context.Request.QueryString("SchoolYear"), C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Context.Request.QueryString("DistId")), 2, "").ChartTitle & " " & "(Grouped by " & C21MIT.PBSIS.BLL.pbsschoolyeardesc.getSchTypeName(2) & ")"
        ElseIf myChart24.ChartGroupBy = "False" Then
            Label24.Text = C21MIT.PBSIS.BLL.pbsreports.getReportInfo("46_0", Context.Request.QueryString("SchoolYear"), C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Context.Request.QueryString("DistId")), 2, "").ChartTitle
        End If

        'Chart25
        myChart25 = C21MIT.PBSIS.BLL.pbsreports.getReportInfo("46_0", Context.Request.QueryString("SchoolYear"), C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Context.Request.QueryString("DistId")), 3, "")

        If myChart25.ChartGroupBy = "True" Then
            Label25.Text = C21MIT.PBSIS.BLL.pbsreports.getReportInfo("46_0", Context.Request.QueryString("SchoolYear"), C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Context.Request.QueryString("DistId")), 3, "").ChartTitle & " " & "(Grouped by " & C21MIT.PBSIS.BLL.pbsschoolyeardesc.getSchTypeName(3) & ")"
        ElseIf myChart25.ChartGroupBy = "False" Then
            Label25.Text = C21MIT.PBSIS.BLL.pbsreports.getReportInfo("46_0", Context.Request.QueryString("SchoolYear"), C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Context.Request.QueryString("DistId")), 3, "").ChartTitle
        End If

        'Chart26
        myChart26 = C21MIT.PBSIS.BLL.pbsreports.getReportInfo("46_0", Context.Request.QueryString("SchoolYear"), C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Context.Request.QueryString("DistId")), 4, "")

        If myChart26.ChartGroupBy = "True" Then
            Label26.Text = C21MIT.PBSIS.BLL.pbsreports.getReportInfo("46_0", Context.Request.QueryString("SchoolYear"), C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Context.Request.QueryString("DistId")), 4, "").ChartTitle & " " & "(Grouped by " & C21MIT.PBSIS.BLL.pbsschoolyeardesc.getSchTypeName(4) & ")"
        ElseIf myChart26.ChartGroupBy = "False" Then
            Label26.Text = C21MIT.PBSIS.BLL.pbsreports.getReportInfo("46_0", Context.Request.QueryString("SchoolYear"), C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Context.Request.QueryString("DistId")), 4, "").ChartTitle
        End If

        'Chart27
        myChart27 = C21MIT.PBSIS.BLL.pbsreports.getReportInfo("47_0", Context.Request.QueryString("SchoolYear"), C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Context.Request.QueryString("DistId")), 0, "")

        If myChart27.ChartGroupBy = "True" Then
            Label27.Text = C21MIT.PBSIS.BLL.pbsreports.getReportInfo("47_0", Context.Request.QueryString("SchoolYear"), C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Context.Request.QueryString("DistId")), 0, "").ChartTitle & " " & "(Grouped by " & C21MIT.PBSIS.BLL.pbsschoolyeardesc.getSchTypeName(0) & ")"
        ElseIf myChart27.ChartGroupBy = "False" Then
            Label27.Text = C21MIT.PBSIS.BLL.pbsreports.getReportInfo("47_0", Context.Request.QueryString("SchoolYear"), C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Context.Request.QueryString("DistId")), 0, "").ChartTitle
        End If

        'Chart28
        myChart28 = C21MIT.PBSIS.BLL.pbsreports.getReportInfo("47_0", Context.Request.QueryString("SchoolYear"), C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Context.Request.QueryString("DistId")), 1, "")

        If myChart28.ChartGroupBy = "True" Then
            Label28.Text = C21MIT.PBSIS.BLL.pbsreports.getReportInfo("47_0", Context.Request.QueryString("SchoolYear"), C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Context.Request.QueryString("DistId")), 1, "").ChartTitle & " " & "(Grouped by " & C21MIT.PBSIS.BLL.pbsschoolyeardesc.getSchTypeName(1) & ")"
        ElseIf myChart28.ChartGroupBy = "False" Then
            Label28.Text = C21MIT.PBSIS.BLL.pbsreports.getReportInfo("47_0", Context.Request.QueryString("SchoolYear"), C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Context.Request.QueryString("DistId")), 1, "").ChartTitle
        End If

        'Chart29
        myChart29 = C21MIT.PBSIS.BLL.pbsreports.getReportInfo("47_0", Context.Request.QueryString("SchoolYear"), C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Context.Request.QueryString("DistId")), 2, "")

        If myChart29.ChartGroupBy = "True" Then
            Label29.Text = C21MIT.PBSIS.BLL.pbsreports.getReportInfo("47_0", Context.Request.QueryString("SchoolYear"), C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Context.Request.QueryString("DistId")), 2, "").ChartTitle & " " & "(Grouped by " & C21MIT.PBSIS.BLL.pbsschoolyeardesc.getSchTypeName(2) & ")"
        ElseIf myChart29.ChartGroupBy = "False" Then
            Label29.Text = C21MIT.PBSIS.BLL.pbsreports.getReportInfo("47_0", Context.Request.QueryString("SchoolYear"), C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Context.Request.QueryString("DistId")), 2, "").ChartTitle
        End If

        'Chart30
        myChart30 = C21MIT.PBSIS.BLL.pbsreports.getReportInfo("47_0", Context.Request.QueryString("SchoolYear"), C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Context.Request.QueryString("DistId")), 3, "")

        If myChart30.ChartGroupBy = "True" Then
            Label30.Text = C21MIT.PBSIS.BLL.pbsreports.getReportInfo("47_0", Context.Request.QueryString("SchoolYear"), C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Context.Request.QueryString("DistId")), 3, "").ChartTitle & " " & "(Grouped by " & C21MIT.PBSIS.BLL.pbsschoolyeardesc.getSchTypeName(3) & ")"
        ElseIf myChart30.ChartGroupBy = "False" Then
            Label30.Text = C21MIT.PBSIS.BLL.pbsreports.getReportInfo("47_0", Context.Request.QueryString("SchoolYear"), C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Context.Request.QueryString("DistId")), 3, "").ChartTitle
        End If


        'Chart31
        myChart31 = C21MIT.PBSIS.BLL.pbsreports.getReportInfo("47_0", Context.Request.QueryString("SchoolYear"), C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Context.Request.QueryString("DistId")), 4, "")

        If myChart31.ChartGroupBy = "True" Then
            Label31.Text = C21MIT.PBSIS.BLL.pbsreports.getReportInfo("47_0", Context.Request.QueryString("SchoolYear"), C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Context.Request.QueryString("DistId")), 4, "").ChartTitle & " " & "(Grouped by " & C21MIT.PBSIS.BLL.pbsschoolyeardesc.getSchTypeName(4) & ")"
        ElseIf myChart31.ChartGroupBy = "False" Then
            Label31.Text = C21MIT.PBSIS.BLL.pbsreports.getReportInfo("47_0", Context.Request.QueryString("SchoolYear"), C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Context.Request.QueryString("DistId")), 4, "").ChartTitle
        End If

        lblYear.Text = C21MIT.PBSIS.BLL.pbsschoolyeardesc.getschoolyeardesc(C21MIT.PBSIS.BLL.pbslogindetails.GetCurrentPrimTracker.schoolyear)
    End Sub
  
End Class
