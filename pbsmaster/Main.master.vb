
Partial Class pbsmaster_Main
    Inherits System.Web.UI.MasterPage

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            Dim vSessionTracker As New C21MIT.PBSIS.BO.pbslogindetails(System.Web.HttpContext.Current.Session("vSessionTracker"))
            'load user menu
            Menu1.Visible = True
            xmlMenu.DataFile = Server.MapPath("~/pbsisresources/menuitems.xml")
            If Session("straccesslevel") = "District" Then
                xmlMenu.XPath = "/menuitems/districtprofile/menuitem"
            ElseIf Session("straccesslevel") = "School" Then
                xmlMenu.XPath = "/menuitems/schoolprofile/menuitem"
            ElseIf Session("straccesslevel") = "FMHI" Then
                xmlMenu.XPath = "/menuitems/fmhiprofile/menuitem"
            End If
        End If
    End Sub

    Protected Sub Menu1_MenuItemDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.MenuEventArgs) Handles Menu1.MenuItemDataBound

    End Sub
End Class

