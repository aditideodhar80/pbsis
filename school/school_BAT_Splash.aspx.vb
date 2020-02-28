
Partial Class school_school_BAT_Splash
    Inherits System.Web.UI.Page
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        C21MIT.PBSIS.BLL.pbsloginsession.chkloginsession("School")
        hylGotoAddBAT.NavigateUrl = "school_BAT_Add.aspx"
    End Sub
End Class
