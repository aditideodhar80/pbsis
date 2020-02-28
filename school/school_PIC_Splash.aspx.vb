'-------------------------------------------------------------------------------------------------------------------
' Created By : Aditi Deodhar
' Created Dt : Feb 10,2010
' Last Updated Dt : Feb 25,2010
'-------------------------------------------------------------------------------------------------------------------
Partial Class school_school_PIC_Splash
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        C21MIT.PBSIS.BLL.pbsloginsession.chkloginsession("School")

        hylGotoAddPIC.NavigateUrl = "school_PIC_Add.aspx?PICTerm=" & Request.QueryString("PICTerm") & ""

        If C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("PICTerm")) = 1 Then
            lblCaption.Text = "PBS Implementation Checklist - Fall"
        ElseIf C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("PICTerm")) = 2 Then
            lblCaption.Text = "PBS Implementation Checklist - Spring"
        End If
    End Sub
End Class
