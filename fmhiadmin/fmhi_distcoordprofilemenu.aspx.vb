'-------------------------------------------------------------------------------------------------------------------
' Created By : Aditi Deodhar
' Created Dt : March 31,2010
' Last Updated Dt : March 31,2010
'-------------------------------------------------------------------------------------------------------------------
Partial Class fmhiadmin_fmhi_distcoordprofilemenu
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        C21MIT.PBSIS.BLL.pbsloginsession.chkloginsession("fmhiadm")
        lblMonHeading.Text = C21MIT.PBSIS.BLL.pbsfmhinavigate.gefmhidistcoordlist("", "DistCAM").PageTitle
        lblDistName.Text = C21MIT.PBSIS.BLL.pbsdistrict.getdistname(C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistID"))).DistrictName
        getpbsdistcoordacct()
    End Sub

    Sub getpbsdistcoordacct()

        Dim nameColumn1 As New BoundColumn
        nameColumn1.DataField = "Name"
        nameColumn1.DataFormatString = "{0}"
        nameColumn1.HeaderText = "District Coordinators"
        gvDynamicFMHI.Columns.Add(nameColumn1)
        nameColumn1.HeaderStyle.Wrap = False
        With nameColumn1
            .ItemStyle.Width = "180"
            .HeaderStyle.HorizontalAlign = HorizontalAlign.Left
            .HeaderStyle.Font.Bold = True
            .HeaderStyle.Font.Size = 11
        End With

        Dim nameColumn2 As New HyperLinkColumn
        nameColumn2.DataTextField = "NavigationText1"
        nameColumn2.DataNavigateUrlField = "NavigationLink1"
        gvDynamicFMHI.Columns.Add(nameColumn2)
        nameColumn2.HeaderStyle.Wrap = False
        With nameColumn2
            .ItemStyle.Width = "100"
            .HeaderStyle.HorizontalAlign = HorizontalAlign.Left
            .HeaderStyle.Font.Bold = True
            .HeaderStyle.Font.Size = 11
        End With

        gvDynamicFMHI.AutoGenerateColumns = False

        If Not Request.QueryString("DistID") Is Nothing Then
            If Not C21MIT.PBSIS.BLL.pbsfmhinavigate.gefmhidistcoordlist(C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistID")), "DistCAM").PBSGridviewNavObjectListobj Is Nothing Then
                gvDynamicFMHI.DataSource = C21MIT.PBSIS.BLL.pbsfmhinavigate.gefmhidistcoordlist(C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistID")), "DistCAM").PBSGridviewNavObjectListobj
                gvDynamicFMHI.DataBind()
            Else
                If C21MIT.PBSIS.BLL.pbsfmhinavigate.gefmhidistcoordlist(C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistID")), "DistCAM").PBSGridviewNavObjectListobj Is Nothing Then
                    gvDynamicFMHI.Caption = "No records found"
                    gvDynamicFMHI.ShowFooter = True
                End If
            End If
        End If
    End Sub

    Protected Sub hyladdDistCoord_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles hyladdDistCoord.Click
        Response.Redirect("fmhi_distcoord_addupdate.aspx?Status=New")
    End Sub
End Class
