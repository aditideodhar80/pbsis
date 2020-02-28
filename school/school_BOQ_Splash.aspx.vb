'-------------------------------------------------------------------------------------------------------------------
' Created By : Aditi Deodhar
' Created Dt : Feb 17,2010
' Last Updated Dt : Feb 17,2010
'-------------------------------------------------------------------------------------------------------------------
Partial Class school_school_BOQ_Splash
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        C21MIT.PBSIS.BLL.pbsloginsession.chkloginsession("School")
        hylGotoAddBOQ.NavigateUrl = "school_BOQ_Add.aspx"
    End Sub
End Class
