
Partial Class users_smessages
    Inherits System.Web.UI.Page
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load



        Dim vMessageIndicator As String = CType(Request.QueryString("qModule"), String)

        If IsNothing(vMessageIndicator) Then
            vMessageIndicator = ""
        End If

        Dim vEMessage As C21MIT.PBSIS.BO.pbsemessageobj
        vEMessage = C21MIT.PBSIS.Util.pbsmessagemanager.EPageMessage(vMessageIndicator)


        lblHeader.Text = vEMessage.EPageHeader
        lblMessage.Text = vEMessage.EPageMessage


        hlinkNext.Visible = False

        If vEMessage.LinkVisible Then
            hlinkNext.Visible = True

            hlinkNext.Text = vEMessage.LinkText
            hlinkNext.NavigateUrl = vEMessage.LinkPath

        End If

    End Sub
End Class
