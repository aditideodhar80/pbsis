
Partial Class pbsisrpts_endyr_district_dlr
    Inherits System.Web.UI.Page
    Dim distid As String
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            C21MIT.PBSIS.BLL.pbsloginsession.chkloginsession("dist")
            getdistid()
            getdistname(distid)
        End If
    End Sub

    Sub getdistid()
        If Not Request.QueryString("DistId") Is Nothing Then
            distid = C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistId"))
        Else
            distid = Session("sDistId")
        End If
    End Sub

    Sub getdistname(ByVal distId As String)
        Session("sDistName") = C21MIT.PBSIS.BLL.pbsdistrict.getdistname(distId).DistrictName
    End Sub

    Protected Sub btnSubmit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSubmit.Click
        Dim valRadio As Integer
        If radioavgODRper100.Checked Then
            valRadio = "31"
        ElseIf radioAvgISSper100.Checked = True Then
            valRadio = "32"
        ElseIf radioAvgOSSper100.Checked = True Then
            valRadio = "33"
        ElseIf radioPerMakiingGainsinReading.Checked = True Then
            valRadio = "34"
        ElseIf radioPerLowest25MGInR.Checked = True Then
            valRadio = "35"
        ElseIf radioAbgDailyAttend.Checked = True Then
            valRadio = "36"
        ElseIf radioPerAtFCATRL3.Checked = True Then
            valRadio = "37"
        ElseIf radioAvgBSpCrtEleCatAllSchType.Checked = True Then
            valRadio = "38"
        ElseIf radioSchTrInPBS.Checked = True Then
            valRadio = "39"
        ElseIf radioODRper100ByImpLev.Checked = True Then
            valRadio = "40"
        ElseIf radioAvgBSPerCrtEleCat.Checked = True Then
            valRadio = "41"
        ElseIf radioCompiledEndYrRep.Checked = True Then
            valRadio = "42"
        ElseIf radioBATAllSchTypes.Checked = True Then
            valRadio = "44"
        ElseIf radioMultiBATAllSchTypes.Checked = True Then
            valRadio = "45"
        ElseIf radioBATBySchTypes.Checked = True Then
            valRadio = "46"
        ElseIf radioMultiBATBySchTypes.Checked = True Then
            valRadio = "47"
        End If

        If Not Request.QueryString("DistId") Is Nothing Then
            distid = C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistId"))
        Else
            distid = Session("sDistId")
        End If
        redirecttoreports(valRadio, distid)
    End Sub

    Sub redirecttoreports(ByVal valRadio As Integer, ByVal distid As String)
        Dim disschoolreports As New C21MIT.PBSIS.BO.pbsschoolreport
        Dim rpttype As Integer

        rpttype = valRadio
        disschoolreports.SchoolType = ddlSchType.SelectedItem.Value

        Session("sSchType") = disschoolreports.SchoolType

        If rpttype = 31 Then
            Response.Redirect("chart.aspx?SchoolYear=" & C21MIT.PBSIS.BLL.pbslogindetails.GetCurrentPrimTracker.schoolyear & "&DistId=" & C21MIT.PBSIS.BLL.pbsencryption.getEncryptedQString(distid) & "&DistName=" & Session("sDistName") & "&SchType=" & Session("sSchType") & "&chartid=31_0")

        ElseIf rpttype = 32 Then
            Response.Redirect("chart.aspx?SchoolYear=" & C21MIT.PBSIS.BLL.pbslogindetails.GetCurrentPrimTracker.schoolyear & "&DistId=" & C21MIT.PBSIS.BLL.pbsencryption.getEncryptedQString(distid) & "&DistName=" & Session("sDistName") & "&SchType=" & Session("sSchType") & "&chartid=32_0")

        ElseIf rpttype = 33 Then
            Response.Redirect("chart.aspx?SchoolYear=" & C21MIT.PBSIS.BLL.pbslogindetails.GetCurrentPrimTracker.schoolyear & "&DistId=" & C21MIT.PBSIS.BLL.pbsencryption.getEncryptedQString(distid) & "&DistName=" & Session("sDistName") & "&SchType=" & Session("sSchType") & "&chartid=33_0")

        ElseIf rpttype = 34 Then
            Response.Redirect("chart.aspx?SchoolYear=" & C21MIT.PBSIS.BLL.pbslogindetails.GetCurrentPrimTracker.schoolyear & "&DistId=" & C21MIT.PBSIS.BLL.pbsencryption.getEncryptedQString(distid) & "&DistName=" & Session("sDistName") & "&SchType=" & Session("sSchType") & "&chartid=34_0")

        ElseIf rpttype = 35 Then
            Response.Redirect("chart.aspx?SchoolYear=" & C21MIT.PBSIS.BLL.pbslogindetails.GetCurrentPrimTracker.schoolyear & "&DistId=" & C21MIT.PBSIS.BLL.pbsencryption.getEncryptedQString(distid) & "&DistName=" & Session("sDistName") & "&SchType=" & Session("sSchType") & "&chartid=35_0")

        ElseIf rpttype = 36 Then
            Response.Redirect("chart.aspx?SchoolYear=" & C21MIT.PBSIS.BLL.pbslogindetails.GetCurrentPrimTracker.schoolyear & "&DistId=" & C21MIT.PBSIS.BLL.pbsencryption.getEncryptedQString(distid) & "&DistName=" & Session("sDistName") & "&SchType=" & Session("sSchType") & "&chartid=36_0")

        ElseIf rpttype = 37 Then
            Response.Redirect("chart.aspx?SchoolYear=" & C21MIT.PBSIS.BLL.pbslogindetails.GetCurrentPrimTracker.schoolyear & "&DistId=" & C21MIT.PBSIS.BLL.pbsencryption.getEncryptedQString(distid) & "&DistName=" & Session("sDistName") & "&SchType=" & Session("sSchType") & "&chartid=37_0")
        ElseIf rpttype = 38 Then
            'Response.Redirect("midyrdlr_distpiccritical_average_all.asp")
            Response.Redirect("chart.aspx?SchoolYear=" & C21MIT.PBSIS.BLL.pbslogindetails.GetCurrentPrimTracker.schoolyear & "&DistId=" & C21MIT.PBSIS.BLL.pbsencryption.getEncryptedQString(distid) & "&DistName=" & Session("sDistName") & "&SchType=" & Session("sSchType") & "&chartid=38_0")
        ElseIf rpttype = 39 Then
            Response.Redirect("chart.aspx?SchoolYear=" & C21MIT.PBSIS.BLL.pbslogindetails.GetCurrentPrimTracker.schoolyear & "&DistId=" & C21MIT.PBSIS.BLL.pbsencryption.getEncryptedQString(distid) & "&DistName=" & Session("sDistName") & "&SchType=" & Session("sSchType") & "&chartid=39_0")

        ElseIf rpttype = 40 Then
            Response.Redirect("chart.aspx?SchoolYear=" & C21MIT.PBSIS.BLL.pbslogindetails.GetCurrentPrimTracker.schoolyear & "&DistId=" & C21MIT.PBSIS.BLL.pbsencryption.getEncryptedQString(distid) & "&DistName=" & Session("sDistName") & "&SchType=" & Session("sSchType") & "&chartid=40_0")
            'If disschoolreports.SchoolType = "0" Then
            '    Response.Redirect("chart.aspx?SchoolYear=" & C21MIT.PBSIS.BLL.pbslogindetails.GetCurrentPrimTracker.schoolyear & "&DistId=" & distid & "&DistName=" & Session("sDistName") & "&SchType=" & Session("sSchType") & "&chartid=40_0")
            'ElseIf disschoolreports.SchoolType = "1" Then
            '    Response.Redirect("chart.aspx?SchoolYear=" & C21MIT.PBSIS.BLL.pbslogindetails.GetCurrentPrimTracker.schoolyear & "&DistId=" & distid & "&DistName=" & Session("sDistName") & "&SchType=" & Session("sSchType") & "&chartid=40_0")
            'ElseIf disschoolreports.SchoolType = "2" Then
            '    Response.Redirect("chart.aspx?SchoolYear=" & C21MIT.PBSIS.BLL.pbslogindetails.GetCurrentPrimTracker.schoolyear & "&DistId=" & distid & "&DistName=" & Session("sDistName") & "&SchType=" & Session("sSchType") & "&chartid=40_0")
            'ElseIf disschoolreports.SchoolType = "3" Then
            '    Response.Redirect("chart.aspx?SchoolYear=" & C21MIT.PBSIS.BLL.pbslogindetails.GetCurrentPrimTracker.schoolyear & "&DistId=" & distid & "&DistName=" & Session("sDistName") & "&SchType=" & Session("sSchType") & "&chartid=40_0")
            'ElseIf disschoolreports.SchoolType = "4" Then
            '    Response.Redirect("chart.aspx?SchoolYear=" & C21MIT.PBSIS.BLL.pbslogindetails.GetCurrentPrimTracker.schoolyear & "&DistId=" & distid & "&DistName=" & Session("sDistName") & "&SchType=" & Session("sSchType") & "&chartid=40_0")
            'ElseIf disschoolreports.SchoolType = "5" Then
            '    Response.Redirect("chart.aspx?SchoolYear=" & C21MIT.PBSIS.BLL.pbslogindetails.GetCurrentPrimTracker.schoolyear & "&DistId=" & distid & "&DistName=" & Session("sDistName") & "&SchType=" & Session("sSchType") & "&chartid=40_0")
            'End If

            '' Phase three reports
        ElseIf rpttype = 41 Then
            '' Average ODR per 100 students for Lower and Higher Implementing Schools
            Response.Redirect("chart.aspx?SchoolYear=" & C21MIT.PBSIS.BLL.pbslogindetails.GetCurrentPrimTracker.schoolyear & "&DistId=" & C21MIT.PBSIS.BLL.pbsencryption.getEncryptedQString(distid) & "&DistName=" & Session("sDistName") & "&SchType=" & Session("sSchType") & "&chartid=41_0")

        ElseIf rpttype = 42 Then
            '' Average ODR per 100 students for Lower and Higher Implementing Schools grouped by School Type
            Response.Redirect("chartagg.aspx?SchoolYear=" & C21MIT.PBSIS.BLL.pbslogindetails.GetCurrentPrimTracker.schoolyear & "&DistId=" & C21MIT.PBSIS.BLL.pbsencryption.getEncryptedQString(distid) & "&DistName=" & Session("sDistName") & "&SchType=" & Session("sSchType") & "")
        ElseIf rpttype = 44 Then

            Response.Redirect("chart.aspx?SchoolYear=" & C21MIT.PBSIS.BLL.pbslogindetails.GetCurrentPrimTracker.schoolyear & "&DistId=" & C21MIT.PBSIS.BLL.pbsencryption.getEncryptedQString(distid) & "&DistName=" & Session("sDistName") & "&SchType=" & Session("sSchType") & "&chartid=44_0")
        ElseIf rpttype = 45 Then

            Response.Redirect("chart.aspx?SchoolYear=" & C21MIT.PBSIS.BLL.pbslogindetails.GetCurrentPrimTracker.schoolyear & "&DistId=" & C21MIT.PBSIS.BLL.pbsencryption.getEncryptedQString(distid) & "&DistName=" & Session("sDistName") & "&SchType=" & Session("sSchType") & "&chartid=45_0")
        ElseIf rpttype = 46 Then

            Response.Redirect("chart.aspx?SchoolYear=" & C21MIT.PBSIS.BLL.pbslogindetails.GetCurrentPrimTracker.schoolyear & "&DistId=" & C21MIT.PBSIS.BLL.pbsencryption.getEncryptedQString(distid) & "&DistName=" & Session("sDistName") & "&SchType=" & Session("sSchType") & "&chartid=46_0")
        ElseIf rpttype = 47 Then

            Response.Redirect("chart.aspx?SchoolYear=" & C21MIT.PBSIS.BLL.pbslogindetails.GetCurrentPrimTracker.schoolyear & "&DistId=" & C21MIT.PBSIS.BLL.pbsencryption.getEncryptedQString(distid) & "&DistName=" & Session("sDistName") & "&SchType=" & Session("sSchType") & "&chartid=47_0")

        Else
            System.Web.HttpContext.Current.Response.Redirect("~/users/smessages.aspx?qModule=NoNode", False)

        End If

    End Sub


End Class
