
Partial Class pbsisrpts_rptschmpage
    Inherits System.Web.UI.Page
    Dim distid As String

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            'C21MIT.PBSIS.BLL.pbsloginsession.chkloginsession("dist")

            Dim pbsDisSchReports As New C21MIT.PBSIS.BO.pbsschoolreport

            Session("SchYrId") = C21MIT.PBSIS.BLL.pbslogindetails.GetCurrentPrimTracker.schoolyear
        End If
    End Sub
'

    Protected Sub btnSubmit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSubmit.Click
        Dim valRadio As Integer
        If radioPICImpLevel.Checked Then
            valRadio = "44"
        ElseIf radioPICTier1CrtEle.Checked = True Then
            valRadio = "43"
        ElseIf radioODRs.Checked = True Then
            valRadio = "45"
        ElseIf radioODRRefP100Stu.Checked = True Then
            valRadio = "46"
        ElseIf radioISSOSSYOfImpl.Checked = True Then
            valRadio = "47"
        ElseIf radioISSOSSP100Stu.Checked = True Then
            valRadio = "48"
        ElseIf radioAvgDaiAtt.Checked = True Then
            valRadio = "49"
        ElseIf radioBOQPerCritElem.Checked = True Then
            valRadio = "50"
        ElseIf radioAnnBATSubrep.Checked = True Then
            valRadio = "51"
        ElseIf radioMultiYrBATRep.Checked = True Then
            valRadio = "52"
        End If

        getdistid()

        redirecttoreports(valRadio, distid)
    End Sub

    Sub getdistid()
        If Not Request.QueryString("DistId") Is Nothing Then
            distid = C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistId"))
        Else
            distid = Session("sDistId")
        End If
    End Sub

    Sub redirecttoreports(ByVal valRadio As Integer, ByVal distid As String)
        Dim objreports As New C21MIT.PBSIS.BO.pbsschoolreport

        If Not CStr(C21MIT.PBSIS.BLL.pbslogindetails.GetCurrentPrimTracker.v_actid) Is Nothing Then
            If Not CStr(Session("sRptSchID")) Is Nothing Then
                objreports.SchoolID = CStr(Session("sRptSchID"))
            ElseIf Not Request.QueryString("sRptSchID") Is Nothing Then
                objreports.SchoolID = C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("sRptSchID"))
            Else
                objreports.SchoolID = C21MIT.PBSIS.BLL.pbslogindetails.GetCurrentPrimTracker.v_actid
            End If
        End If

        If valRadio = 43 Then
            Response.Redirect("chart.aspx?chartid=13_0&sRptSchID=" & C21MIT.PBSIS.BLL.pbsencryption.getEncryptedQString(objreports.SchoolID) & "&SchoolYear=" & C21MIT.PBSIS.BLL.pbslogindetails.GetCurrentPrimTracker.schoolyear & "")
        ElseIf valRadio = 44 Then
            Response.Redirect("chart.aspx?chartid=14_0&sRptSchID=" & C21MIT.PBSIS.BLL.pbsencryption.getEncryptedQString(objreports.SchoolID) & "&SchoolYear=" & C21MIT.PBSIS.BLL.pbslogindetails.GetCurrentPrimTracker.schoolyear & "")
        ElseIf valRadio = 45 Then
            Response.Redirect("chart.aspx?chartid=7_0&sRptSchID=" & C21MIT.PBSIS.BLL.pbsencryption.getEncryptedQString(objreports.SchoolID) & "&SchoolYear=" & C21MIT.PBSIS.BLL.pbslogindetails.GetCurrentPrimTracker.schoolyear & "")
        ElseIf valRadio = 46 Then
            Response.Redirect("chart.aspx?chartid=8_0&sRptSchID=" & C21MIT.PBSIS.BLL.pbsencryption.getEncryptedQString(objreports.SchoolID) & "&SchoolYear=" & C21MIT.PBSIS.BLL.pbslogindetails.GetCurrentPrimTracker.schoolyear & "")
        ElseIf valRadio = 47 Then
            Response.Redirect("chart.aspx?chartid=9_0&sRptSchID=" & C21MIT.PBSIS.BLL.pbsencryption.getEncryptedQString(objreports.SchoolID) & "&SchoolYear=" & C21MIT.PBSIS.BLL.pbslogindetails.GetCurrentPrimTracker.schoolyear & "")
        ElseIf valRadio = 48 Then
            Response.Redirect("chart.aspx?chartid=10_0&sRptSchID=" & C21MIT.PBSIS.BLL.pbsencryption.getEncryptedQString(objreports.SchoolID) & "&SchoolYear=" & C21MIT.PBSIS.BLL.pbslogindetails.GetCurrentPrimTracker.schoolyear & "")
        ElseIf valRadio = 49 Then
            Response.Redirect("chart.aspx?chartid=11_0&sRptSchID=" & C21MIT.PBSIS.BLL.pbsencryption.getEncryptedQString(objreports.SchoolID) & "&SchoolYear=" & C21MIT.PBSIS.BLL.pbslogindetails.GetCurrentPrimTracker.schoolyear & "")
        ElseIf valRadio = 50 Then
            Response.Redirect("chart.aspx?chartid=12_0&sRptSchID=" & C21MIT.PBSIS.BLL.pbsencryption.getEncryptedQString(objreports.SchoolID) & "&SchoolYear=" & C21MIT.PBSIS.BLL.pbslogindetails.GetCurrentPrimTracker.schoolyear & "")
        ElseIf valRadio = 51 Then
            Response.Redirect("chart.aspx?chartid=42_0&sRptSchID=" & C21MIT.PBSIS.BLL.pbsencryption.getEncryptedQString(objreports.SchoolID) & "&SchoolYear=" & C21MIT.PBSIS.BLL.pbslogindetails.GetCurrentPrimTracker.schoolyear & "")
        ElseIf valRadio = 52 Then
            Response.Redirect("chart.aspx?chartid=43_0&sRptSchID=" & C21MIT.PBSIS.BLL.pbsencryption.getEncryptedQString(objreports.SchoolID) & "&SchoolYear=" & C21MIT.PBSIS.BLL.pbslogindetails.GetCurrentPrimTracker.schoolyear & "")

        Else
            Response.Redirect("rpterrpage.asp")

        End If

    End Sub
End Class
