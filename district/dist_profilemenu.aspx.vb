
Partial Class district_dist_profilemenu
    Inherits System.Web.UI.Page

    Protected Sub hyladdSchoolCo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles hyladdSchoolCo.Click
        Response.Redirect("../fmhiadmin/fmhi_sch_addupdate.aspx?Status=New")
    End Sub

    Protected Sub hyladdCoaches_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles hyladdCoaches.Click
        Response.Redirect("../fmhiadmin/fmhi_distcoaches_addupdate.aspx?Status=New")
    End Sub

    Protected Sub hylUpdateSchools_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles hylUpdateSchools.Click
        Response.Redirect("../fmhiadmin/fmhi_schprofilemenu.aspx?Status=Update&DistId=" & C21MIT.PBSIS.BLL.pbsencryption.getEncryptedQString(C21MIT.PBSIS.BLL.pbslogindetails.GetCurrentPrimTracker.v_actid) & "")
    End Sub
    Protected Sub hylUpdateCoaches_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles hylUpdateCoaches.Click
        Response.Redirect("../fmhiadmin/fmhi_distcoachprofilemenu.aspx?Status=Update&DistId=" & C21MIT.PBSIS.BLL.pbsencryption.getEncryptedQString(C21MIT.PBSIS.BLL.pbslogindetails.GetCurrentPrimTracker.v_actid) & "")
    End Sub
End Class
