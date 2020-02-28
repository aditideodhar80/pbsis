'-------------------------------------------------------------------------------------------------------------------
' Created By : Aditi Deodhar
' Created Dt : March 02,2010
' Last Updated Dt : March 30,2010
'-------------------------------------------------------------------------------------------------------------------
Partial Class pbsisrpts_midyrdlr_indvtrgtdist
    Inherits System.Web.UI.Page

    Dim distId As String

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            getdistid()
            bindlabels()
        End If
    End Sub

    Sub getdistid()
        If Not Request.QueryString("DistId") Is Nothing Then
            distId = C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistId"))
        Else
            distId = Session("sDistId")
        End If
    End Sub

    Sub bindlabels()
        lblDistName.Text = Session("sDistName")
        lblYear.Text = C21MIT.PBSIS.BLL.pbsschoolyeardesc.getschoolyeardesc(C21MIT.PBSIS.BLL.pbslogindetails.GetCurrentPrimTracker.schoolyear)
        lblSchUnivPBSITier1.Text = C21MIT.PBSIS.BLL.pbsdistrict.getdisttierofsupport(distId, C21MIT.PBSIS.BLL.pbslogindetails.GetCurrentPrimTracker.schoolyear).SchUniPBSTier1
        lblSchTargGrpTier2.Text = C21MIT.PBSIS.BLL.pbsdistrict.getdisttierofsupport(distId, C21MIT.PBSIS.BLL.pbslogindetails.GetCurrentPrimTracker.schoolyear).SchTargGroupTier2
        lblSchInPBSTier3.Text = C21MIT.PBSIS.BLL.pbsdistrict.getdisttierofsupport(distId, C21MIT.PBSIS.BLL.pbslogindetails.GetCurrentPrimTracker.schoolyear).SchIndPBSTier3
    End Sub
End Class
