'-------------------------------------------------------------------------------------------------------------------
' Created By : Aditi Deodhar
' Created Dt : Feb 09,2010
' Last Updated Dt : May 13,2010
'-------------------------------------------------------------------------------------------------------------------
Partial Class pbsisrpts_rptdistmpage_midyr
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
        If radioTier.Checked Then
            valRadio = "17"
        ElseIf radioAvgPIC11.Checked = True Then
            valRadio = "20"
        ElseIf radioAgPIC12.Checked = True Then
            valRadio = "19"
        ElseIf radioAvgPIC21.Checked = True Then
            valRadio = "22"
        ElseIf radioAvgPIC22.Checked = True Then
            valRadio = "21"
        End If

        If Not Request.QueryString("DistId") Is Nothing Then
            redirecttoreports(valRadio, C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistId")))
        Else
            redirecttoreports(valRadio, Session("sDistId"))
        End If

    End Sub

    Sub redirecttoreports(ByVal valRadio As Integer, ByVal distid As String)
        If valRadio = 17 Then
            Response.Redirect("midyrdlr_indvtrgtdist.aspx?DistId=" & C21MIT.PBSIS.BLL.pbsencryption.getEncryptedQString(distid) & "")
        ElseIf valRadio = 19 Then
            Response.Redirect("chart.aspx?SchoolYear=" & C21MIT.PBSIS.BLL.pbslogindetails.GetCurrentPrimTracker.schoolyear & "&DistId=" & C21MIT.PBSIS.BLL.pbsencryption.getEncryptedQString(distid) & "&DistName=" & Session("sDistName") & "&SchType=" & ddlSchType.SelectedItem.Value & "&chartid=19_0")
        ElseIf valRadio = 20 Then
            Response.Redirect("chart.aspx?SchoolYear=" & C21MIT.PBSIS.BLL.pbslogindetails.GetCurrentPrimTracker.schoolyear & "&DistId=" & C21MIT.PBSIS.BLL.pbsencryption.getEncryptedQString(distid) & "&DistName=" & Session("sDistName") & "&SchType=" & ddlSchType.SelectedItem.Value & "&chartid=20_0")
        ElseIf valRadio = 21 Then
            If ddlSchType.SelectedItem.Value = "0" Then
                Response.Redirect("chart.aspx?SchoolYear=" & C21MIT.PBSIS.BLL.pbslogindetails.GetCurrentPrimTracker.schoolyear & "&DistId=" & C21MIT.PBSIS.BLL.pbsencryption.getEncryptedQString(distid) & "&DistName=" & Session("sDistName") & "&SchType=" & ddlSchType.SelectedItem.Value & "&chartid=21_0")
            ElseIf ddlSchType.SelectedItem.Value = "1" Then
                Response.Redirect("chart.aspx?SchoolYear=" & C21MIT.PBSIS.BLL.pbslogindetails.GetCurrentPrimTracker.schoolyear & "&DistId=" & C21MIT.PBSIS.BLL.pbsencryption.getEncryptedQString(distid) & "&DistName=" & Session("sDistName") & "&SchType=" & ddlSchType.SelectedItem.Value & "&chartid=21_1")
            ElseIf ddlSchType.SelectedItem.Value = "2" Then
                Response.Redirect("chart.aspx?SchoolYear=" & C21MIT.PBSIS.BLL.pbslogindetails.GetCurrentPrimTracker.schoolyear & "&DistId=" & C21MIT.PBSIS.BLL.pbsencryption.getEncryptedQString(distid) & "&DistName=" & Session("sDistName") & "&SchType=" & ddlSchType.SelectedItem.Value & "&chartid=21_2")
            ElseIf ddlSchType.SelectedItem.Value = "3" Then
                Response.Redirect("chart.aspx?SchoolYear=" & C21MIT.PBSIS.BLL.pbslogindetails.GetCurrentPrimTracker.schoolyear & "&DistId=" & C21MIT.PBSIS.BLL.pbsencryption.getEncryptedQString(distid) & "&DistName=" & Session("sDistName") & "&SchType=" & ddlSchType.SelectedItem.Value & "&chartid=21_3")
            ElseIf ddlSchType.SelectedItem.Value = "4" Then
                Response.Redirect("chart.aspx?SchoolYear=" & C21MIT.PBSIS.BLL.pbslogindetails.GetCurrentPrimTracker.schoolyear & "&DistId=" & C21MIT.PBSIS.BLL.pbsencryption.getEncryptedQString(distid) & "&DistName=" & Session("sDistName") & "&SchType=" & ddlSchType.SelectedItem.Value & "&chartid=21_4")
            ElseIf ddlSchType.SelectedItem.Value = "5" Then
                Response.Redirect("chart.aspx?SchoolYear=" & C21MIT.PBSIS.BLL.pbslogindetails.GetCurrentPrimTracker.schoolyear & "&DistId=" & C21MIT.PBSIS.BLL.pbsencryption.getEncryptedQString(distid) & "&DistName=" & Session("sDistName") & "&SchType=" & ddlSchType.SelectedItem.Value & "&chartid=21_5")
            End If
        ElseIf valRadio = 22 Then
            If ddlSchType.SelectedItem.Value = "0" Then
                Response.Redirect("chart.aspx?SchoolYear=" & C21MIT.PBSIS.BLL.pbslogindetails.GetCurrentPrimTracker.schoolyear & "&DistId=" & C21MIT.PBSIS.BLL.pbsencryption.getEncryptedQString(distid) & "&DistName=" & Session("sDistName") & "&SchType=" & ddlSchType.SelectedItem.Value & "&chartid=22_0")
            ElseIf ddlSchType.SelectedItem.Value = "1" Then
                Response.Redirect("chart.aspx?SchoolYear=" & C21MIT.PBSIS.BLL.pbslogindetails.GetCurrentPrimTracker.schoolyear & "&DistId=" & C21MIT.PBSIS.BLL.pbsencryption.getEncryptedQString(distid) & "&DistName=" & Session("sDistName") & "&SchType=" & ddlSchType.SelectedItem.Value & "&chartid=22_1")
            ElseIf ddlSchType.SelectedItem.Value = "2" Then
                Response.Redirect("chart.aspx?SchoolYear=" & C21MIT.PBSIS.BLL.pbslogindetails.GetCurrentPrimTracker.schoolyear & "&DistId=" & C21MIT.PBSIS.BLL.pbsencryption.getEncryptedQString(distid) & "&DistName=" & Session("sDistName") & "&SchType=" & ddlSchType.SelectedItem.Value & "&chartid=22_2")
            ElseIf ddlSchType.SelectedItem.Value = "3" Then
                Response.Redirect("chart.aspx?SchoolYear=" & C21MIT.PBSIS.BLL.pbslogindetails.GetCurrentPrimTracker.schoolyear & "&DistId=" & C21MIT.PBSIS.BLL.pbsencryption.getEncryptedQString(distid) & "&DistName=" & Session("sDistName") & "&SchType=" & ddlSchType.SelectedItem.Value & "&chartid=22_3")
            ElseIf ddlSchType.SelectedItem.Value = "4" Then
                Response.Redirect("chart.aspx?SchoolYear=" & C21MIT.PBSIS.BLL.pbslogindetails.GetCurrentPrimTracker.schoolyear & "&DistId=" & C21MIT.PBSIS.BLL.pbsencryption.getEncryptedQString(distid) & "&DistName=" & Session("sDistName") & "&SchType=" & ddlSchType.SelectedItem.Value & "&chartid=22_4")
            ElseIf ddlSchType.SelectedItem.Value = "5" Then
                Response.Redirect("chart.aspx?SchoolYear=" & C21MIT.PBSIS.BLL.pbslogindetails.GetCurrentPrimTracker.schoolyear & "&DistId=" & C21MIT.PBSIS.BLL.pbsencryption.getEncryptedQString(distid) & "&DistName=" & Session("sDistName") & "&SchType=" & ddlSchType.SelectedItem.Value & "&chartid=22_5")
            End If
        Else
            Response.Redirect("rpterrpage.asp")
        End If
    End Sub

End Class
