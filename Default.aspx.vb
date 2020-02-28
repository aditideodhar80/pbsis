
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        C21MIT.PBSIS.BLL.pbslogindetails.logincheck("sfakih@admin.usf.edu", "abcde1", "District")
    End Sub


    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        C21MIT.PBSIS.BLL.pbslogindetails.logincheck("030331", "030331", "School")
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Response.Redirect("users/pbsis_login.aspx")
    End Sub
End Class
