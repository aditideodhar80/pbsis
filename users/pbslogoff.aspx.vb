
Partial Class users_pbslogoff
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Response.Cache.SetCacheability(HttpCacheability.NoCache)
        Session.RemoveAll()
        Session.Abandon()
    End Sub
End Class
