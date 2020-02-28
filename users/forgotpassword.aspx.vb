Imports System.Web.Mail

Partial Class users_forgotyourpassword
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim objPrimTracker As New C21MIT.PBSIS.BO.pbslogindetails
        Dim objLoginDetails As New C21MIT.PBSIS.DAL.pbslogindetails
        If txtemailadd.Text = "" Then
        Else
            If ddlAccessLevel.SelectedValue = "District" Then
                objPrimTracker.strPassword = C21MIT.PBSIS.BLL.pbsPass.getRndPwd(8)
                objPrimTracker.resultpforgotpass = objLoginDetails.fnvalidateforgotpassdist("District", objPrimTracker.strPassword, txtemailadd.Text).resultpforgotpass

             
            ElseIf ddlAccessLevel.SelectedValue = "School" Then
                objPrimTracker.resultpforgotpass = objLoginDetails.fnvalidateforgotpasssch("School", objPrimTracker.strPassword, txtemailadd.Text).resultpforgotpass
            End If

            If objPrimTracker.resultpforgotpass > 0 Then
                'lblmess.Text = 
                SendEmailAlert(txtemailadd.Text, objPrimTracker.strPassword)
            End If

        End If
    End Sub

    Public Sub SendEmailAlert(ByVal email As String, ByVal password As String)
        Dim objMailMessage As MailMessage

        objMailMessage = New MailMessage
        objMailMessage.From = "flpbs@fmhi.usf.edu"
        objMailMessage.To = email
        objMailMessage.Subject = "PBSES - Password Reset"
        objMailMessage.Body = "Your password for the PBSES Online site has been reset." & vbCrLf & _
    "Your new password is: " & password & vbCrLf & vbCrLf & _
    "You can now use the updated password to login." & vbCrLf & _
    "For other questions or concerns please contact FLPBS staff at flpbs@fmhi.usf.edu" & vbCrLf
        objMailMessage.BodyFormat = MailFormat.Text

        SmtpMail.Send(objMailMessage)

    End Sub
End Class

