Imports ChartDirector

Partial Class pbsisrpts_chart
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim distId As String

        If Not Request.QueryString("sRptSchID") Is Nothing Then
            lblSchoolName.Text = C21MIT.PBSIS.BLL.pbsdemodata.fngetdemodataEndYearSchool(C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("sRptSchID")), C21MIT.PBSIS.BLL.pbslogindetails.GetCurrentPrimTracker.schoolyear).SchoolName
            lblDistName.Text = C21MIT.PBSIS.BLL.pbsdemodata.fngetdemodataEndYearSchool(C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("sRptSchID")), C21MIT.PBSIS.BLL.pbslogindetails.GetCurrentPrimTracker.schoolyear).DistrictName
            Image1.ImageUrl = "~/pbsisrpts/Chart.ashx?sRptSchID=" & C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("sRptSchID")) & "&SchoolYear=" & C21MIT.PBSIS.BLL.pbslogindetails.GetCurrentPrimTracker.schoolyear & "&DistId=" & Request.QueryString("DistId") & "&DistName=" & Request.QueryString("DistName") & "&SchType=" & Request.QueryString("SchType") & "&chartid=" & Request.QueryString("chartid") & ""
        Else
            lblschName.Visible = False
            If Not Request.QueryString("DistId") Is Nothing Then
                distId = Request.QueryString("DistId")
                lblDistName.Text = C21MIT.PBSIS.BLL.pbsdistrict.getdistname(C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(distId)).DistrictName
                Image1.ImageUrl = "~/pbsisrpts/Chart.ashx?SchoolYear=" & Request.QueryString("SchoolYear") & "&DistId=" & C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistId")) & "&DistName=" & Request.QueryString("DistName") & "&SchType=" & Request.QueryString("SchType") & "&chartid=" & Request.QueryString("chartid") & ""
            Else
                distId = Session("sDistId")
                lblDistName.Text = C21MIT.PBSIS.BLL.pbsdistrict.getdistname(distId).DistrictName
                Image1.ImageUrl = "~/pbsisrpts/Chart.ashx?SchoolYear=" & Request.QueryString("SchoolYear") & "&DistId=" & Request.QueryString("DistId") & "&DistName=" & Request.QueryString("DistName") & "&SchType=" & Request.QueryString("SchType") & "&chartid=" & Request.QueryString("chartid") & ""
            End If
        End If
        '=============================
        ' To set the title of the page
        Dim myChart As New C21MIT.PBSIS.BO.ChartInfoset

        If Not Context.Request.QueryString("sRptSchID") Is Nothing Then
            If Context.Request.QueryString("sRptSchID") <> "" Then
                If Context.Request.QueryString("SchoolYear") = "" Then
                    myChart = C21MIT.PBSIS.BLL.pbsreports.getReportInfo(Context.Request.QueryString("chartid"), 0, "", 0, C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Context.Request.QueryString("sRptSchID")))
                Else
                    myChart = C21MIT.PBSIS.BLL.pbsreports.getReportInfo(Context.Request.QueryString("chartid"), Context.Request.QueryString("SchoolYear"), "", 0, C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Context.Request.QueryString("sRptSchID")))
                End If
            Else
                myChart = C21MIT.PBSIS.BLL.pbsreports.getReportInfo(Context.Request.QueryString("chartid"), Context.Request.QueryString("SchoolYear"), C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Context.Request.QueryString("DistId")), Context.Request.QueryString("SchType"), "")
            End If
        Else
            myChart = C21MIT.PBSIS.BLL.pbsreports.getReportInfo(Context.Request.QueryString("chartid"), Context.Request.QueryString("SchoolYear"), C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Context.Request.QueryString("DistId")), Context.Request.QueryString("SchType"), "")
        End If

        If myChart.ChartGroupBy = "True" Then
            lblMonHeading.Text = myChart.ChartTitle & " " & "(Grouped by " & C21MIT.PBSIS.BLL.pbsschoolyeardesc.getSchTypeName(Context.Request.QueryString("SchType")) & ")"
        ElseIf myChart.ChartGroupBy = "False" Then
            lblMonHeading.Text = myChart.ChartTitle
        End If

        lblYear.Text = C21MIT.PBSIS.BLL.pbsschoolyeardesc.getschoolyeardesc(C21MIT.PBSIS.BLL.pbslogindetails.GetCurrentPrimTracker.schoolyear)
    End Sub
End Class
