'-------------------------------------------------------------------------------------------------------------------
' Created By : Aditi Deodhar
' Created Dt : Jan 25,2010
' Last Updated Dt : Jan 25,2010
'-------------------------------------------------------------------------------------------------------------------
Partial Class users_pbsis_login
    Inherits System.Web.UI.Page

    Protected Sub Submit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Submit.Click
        C21MIT.PBSIS.BLL.pbslogindetails.logincheck(txtUser.Text, txtPass.Text, ddlAccessLevel.SelectedItem.Text)
    End Sub

    Protected Sub hylFPass_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles hylFPass.Click
        Response.Redirect("forgotpassword.aspx")
    End Sub
End Class
