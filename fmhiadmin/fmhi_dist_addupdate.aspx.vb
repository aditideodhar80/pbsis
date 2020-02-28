'-------------------------------------------------------------------------------------------------------------------
' Created By : Aditi Deodhar
' Created Dt : April 01,2010
' Last Updated Dt : April 05,2010
'-------------------------------------------------------------------------------------------------------------------
Partial Class fmhiadmin_fmhi_dist_addupdate
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            C21MIT.PBSIS.BLL.pbsloginsession.chkloginsession("fmhiadm")
            C21MIT.PBSIS.BLL.pbsloginsession.chkAdminLevel() '?

            If Not Request.QueryString("Status") Is Nothing Then

                bindlabel(Request.QueryString("Status"))
                bindbuttonlabels(Request.QueryString("Status"))
                If Request.QueryString("Status") = "New" Then

                ElseIf Request.QueryString("Status") = "Update" Then
                    binddata()
                End If
            Else
            End If
        End If
    End Sub

    Sub bindbuttonlabels(ByVal status As String)
        If status = "New" Then
            btnsubmit.Text = "Submit"
        ElseIf status = "Update" Then
            btnsubmit.Text = "Update"
        End If
    End Sub

    Sub binddata()
        'bind all the controls to the values from the district table

        'C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString()
        txtDistrictName.Text = C21MIT.PBSIS.BLL.pbsfmhi.getfmhidistprofile(C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistID"))).DistName
        txtDistrictID.Text = C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistID"))
        txtStreetAddress1.Text = C21MIT.PBSIS.BLL.pbsfmhi.getfmhidistprofile(C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistID"))).DistStreetAddress1
        txtStreetAddress2.Text = C21MIT.PBSIS.BLL.pbsfmhi.getfmhidistprofile(C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistID"))).DistStreetAddress2
        txtDistrictCity.Text = C21MIT.PBSIS.BLL.pbsfmhi.getfmhidistprofile(C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistID"))).DistrictCity
        txtDistrictState.Text = C21MIT.PBSIS.BLL.pbsfmhi.getfmhidistprofile(C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistID"))).DistrictState
        txtDistrictZip.Text = C21MIT.PBSIS.BLL.pbsfmhi.getfmhidistprofile(C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistID"))).DistrictZip

        txtDistrictPhone01.Text = Left(C21MIT.PBSIS.BLL.pbsfmhi.getfmhidistprofile(C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistID"))).DistrictPhone, 3)
        txtDistrictPhone02.Text = Mid(C21MIT.PBSIS.BLL.pbsfmhi.getfmhidistprofile(C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistID"))).DistrictPhone, 4, 3)
        txtDistrictPhone03.Text = Right(C21MIT.PBSIS.BLL.pbsfmhi.getfmhidistprofile(C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistID"))).DistrictPhone, 4)

        txtDistrictFax01.Text = Left(C21MIT.PBSIS.BLL.pbsfmhi.getfmhidistprofile(C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistID"))).DistrictFax, 3)
        txtDistrictFax02.Text = Mid(C21MIT.PBSIS.BLL.pbsfmhi.getfmhidistprofile(C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistID"))).DistrictFax, 4, 3)
        txtDistrictFax03.Text = Right(C21MIT.PBSIS.BLL.pbsfmhi.getfmhidistprofile(C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistID"))).DistrictFax, 4)

        txtDistrictCell01.Text = Left(C21MIT.PBSIS.BLL.pbsfmhi.getfmhidistprofile(C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistID"))).DistrictCell, 3)
        txtDistrictCell02.Text = Mid(C21MIT.PBSIS.BLL.pbsfmhi.getfmhidistprofile(C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistID"))).DistrictCell, 4, 3)
        txtDistrictCell03.Text = Right(C21MIT.PBSIS.BLL.pbsfmhi.getfmhidistprofile(C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistID"))).DistrictCell, 4)

        If C21MIT.PBSIS.BLL.pbsfmhi.getfmhidistprofile(C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistID"))).DistrictInactive = 1 Then
            chkInactive.Checked = True
        ElseIf C21MIT.PBSIS.BLL.pbsfmhi.getfmhidistprofile(C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistID"))).DistrictInactive = 0 Then
            chkInactive.Checked = False
        End If
    End Sub
    Protected Sub btnsubmit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnsubmit.Click

        If Not Request.QueryString("Status") Is Nothing Then
            savedistprofile(Request.QueryString("Status"))
            Response.Redirect("~/users/smessages.aspx?qModule=DataSavedFMHI", False)
        Else
        End If
    End Sub

    Sub bindlabel(ByVal status As String)
        If status = "New" Then
            lblCaption.Text = "ADD A DISTRICT PROFILE"
        ElseIf status = "Update" Then
            lblCaption.Text = "EDIT A DISTRICT PROFILE"
        End If
    End Sub
    Sub cleartextboxes()
        txtDistrictName.Text = ""
        txtDistrictID.Text = ""
        txtStreetAddress2.Text = ""
        txtDistrictCity.Text = ""
        txtDistrictState.Text = ""
        txtDistrictZip.Text = ""
        txtDistrictPhone01.Text = ""
        txtDistrictPhone02.Text = ""
        txtDistrictPhone03.Text = ""
        txtDistrictFax01.Text = ""
        txtDistrictFax02.Text = ""
        txtDistrictFax03.Text = ""
        txtDistrictCell01.Text = ""
        txtDistrictCell02.Text = ""
        txtDistrictCell03.Text = ""
    End Sub

    Sub savedistprofile(ByVal status As String)
        Dim objFMHIDistrictProfile As New C21MIT.PBSIS.BO.pbsdistprofile

        objFMHIDistrictProfile.DistName = txtDistrictName.Text
        objFMHIDistrictProfile.DistId = txtDistrictID.Text

        'objFMHIAddDistrictProfile.DistCoordFirstName = txtCoordFirstName.Text
        'objFMHIAddDistrictProfile.DistCoordLastName = txtCoordLastName.Text
        'objFMHIAddDistrictProfile.DistStreetAddress1 = txtStreetAddress1.Text
        objFMHIDistrictProfile.DistCoordFirstName = DBNull.Value.ToString
        objFMHIDistrictProfile.DistCoordLastName = DBNull.Value.ToString
        objFMHIDistrictProfile.DistStreetAddress1 = txtStreetAddress1.Text

        objFMHIDistrictProfile.DistStreetAddress2 = txtStreetAddress2.Text
        objFMHIDistrictProfile.DistrictCity = txtDistrictCity.Text
        objFMHIDistrictProfile.DistrictState = txtDistrictState.Text
        objFMHIDistrictProfile.DistrictZip = txtDistrictZip.Text
        objFMHIDistrictProfile.DistrictPhone = txtDistrictPhone01.Text & txtDistrictPhone02.Text & txtDistrictPhone03.Text
        objFMHIDistrictProfile.DistrictFax = txtDistrictFax01.Text & txtDistrictFax02.Text & txtDistrictFax03.Text
        objFMHIDistrictProfile.DistrictCell = txtDistrictCell01.Text & txtDistrictCell02.Text & txtDistrictCell03.Text


        'objFMHIAddDistrictProfile.CoordFirstName_2 = txtCoordFirstName_2.Text
        'objFMHIAddDistrictProfile.CoordLastName_2 = txtCoordLastName_2.Text
        'objFMHIAddDistrictProfile.StreetAddress1_2 = txtStreetAddress1_2.Text
        'objFMHIAddDistrictProfile.StreetAddress2_2 = txtStreetAddress2_2.Text
        'objFMHIAddDistrictProfile.StreetAddress2_2 = txtStreetAddress2_2.Text
        'objFMHIAddDistrictProfile.DistrictCity_2 = txtDistrictCity_2.Text
        'objFMHIAddDistrictProfile.DistrictState_2 = txtDistrictState_2.Text
        'objFMHIAddDistrictProfile.DistrictZip_2 = txtDistrictZip_2.Text
        ''objFMHIAddDistrictProfile.DistrictPhone_2 = txtDistrictPhone01_2.Text & txtDistrictPhone02_2.Text & txtDistrictPhone03_2.Text
        'objFMHIAddDistrictProfile.DistrictFax_2 = txtDistrictFax01_2.Text & txtDistrictFax02_2.Text & txtDistrictFax03_2.Text
        'objFMHIAddDistrictProfile.DistrictCell_2 = txtDistrictCell01_2.Text & txtDistrictCell02_2.Text & txtDistrictCell03_2.Text
        'objFMHIAddDistrictProfile.DistrictCoordEmail_2 = txtDistrictCoordEmail_2.Text
        'objFMHIAddDistrictProfile.DistrictCoordEmail_2 = txtDistrictCoordEmail_2.Text
        'objFMHIAddDistrictProfile.DistrictInactive = checkradioinactive(chkInactive.Checked)

        objFMHIDistrictProfile.CoordFirstName_2 = DBNull.Value.ToString
        objFMHIDistrictProfile.CoordLastName_2 = DBNull.Value.ToString
        objFMHIDistrictProfile.StreetAddress1_2 = DBNull.Value.ToString
        objFMHIDistrictProfile.StreetAddress2_2 = DBNull.Value.ToString
        objFMHIDistrictProfile.StreetAddress2_2 = DBNull.Value.ToString
        objFMHIDistrictProfile.DistrictCity_2 = DBNull.Value.ToString
        objFMHIDistrictProfile.DistrictState_2 = DBNull.Value.ToString
        objFMHIDistrictProfile.DistrictZip_2 = DBNull.Value.ToString
        objFMHIDistrictProfile.DistrictPhone_2 = DBNull.Value.ToString
        objFMHIDistrictProfile.DistrictFax_2 = DBNull.Value.ToString
        objFMHIDistrictProfile.DistrictCell_2 = DBNull.Value.ToString
        objFMHIDistrictProfile.DistrictCoordEmail_2 = DBNull.Value.ToString
        objFMHIDistrictProfile.DistrictCoordEmail_2 = DBNull.Value.ToString

        objFMHIDistrictProfile.DistrictInactive = checkradioinactive(chkInactive.Checked)

        If status = "New" Then
            C21MIT.PBSIS.BLL.pbsfmhi.addfmhidistprofile(objFMHIDistrictProfile)
            lblstatus.Text = "The District profile has been successfully created."
        ElseIf status = "Update" Then
            C21MIT.PBSIS.BLL.pbsfmhi.updatefmhidistprofile(objFMHIDistrictProfile)
            lblstatus.Text = "The District profile has been successfully updated."
            btnsubmit.Focus()
        End If

    End Sub

    Function checkradioinactive(ByVal chkvalue As Boolean) As Integer
        If chkvalue = True Then
            Return 1
        ElseIf chkvalue = False Then
            Return 0
        End If
    End Function
End Class
