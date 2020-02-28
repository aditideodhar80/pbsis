'-------------------------------------------------------------------------------------------------------------------
' Created By : Aditi Deodhar
' Created Dt : April 02,2010
' Last Updated Dt : April 05,2010
'-------------------------------------------------------------------------------------------------------------------
Partial Class fmhiadmin_fmhi_distcoord_addupdate
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            C21MIT.PBSIS.BLL.pbsloginsession.chkloginsession("fmhiadm")

            If Not Request.QueryString("Status") Is Nothing Then
                bindlabel(Request.QueryString("Status"))
                bindbuttonlabels(Request.QueryString("Status"))
                binddropdown()
                If Request.QueryString("Status") = "New" Then

                Else
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
        ddlSchoolDistrict.SelectedValue = C21MIT.PBSIS.BLL.pbsfmhi.getfmhidistcoorprofile(C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistCoordID"))).DistId
        '' ''txtCoordFirstName.Text = C21MIT.PBSIS.BLL.pbsfmhi.getfmhidistcoorprofile(C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistCoordID"))).DistCoordFirstName
        '' ''txtCoordLastName.Text = C21MIT.PBSIS.BLL.pbsfmhi.getfmhidistcoorprofile(C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistCoordID"))).DistCoordLastName
        '' ''txtDistrictCoordEmail.Text = C21MIT.PBSIS.BLL.pbsfmhi.getfmhidistcoorprofile(C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistCoordID"))).DistrictCoordEmail

        txtCoordFirstName_2.Text = C21MIT.PBSIS.BLL.pbsfmhi.getfmhidistcoorprofile(C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistCoordID"))).DistCoordFirstName
        txtCoordLastName_2.Text = C21MIT.PBSIS.BLL.pbsfmhi.getfmhidistcoorprofile(C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistCoordID"))).DistCoordLastName

        txtStreetAddress1_2.Text = C21MIT.PBSIS.BLL.pbsfmhi.getfmhidistcoorprofile(C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistCoordID"))).StreetAddress1_2
        txtStreetAddress2_2.Text = C21MIT.PBSIS.BLL.pbsfmhi.getfmhidistcoorprofile(C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistCoordID"))).StreetAddress2_2

        txtDistrictCity_2.Text = C21MIT.PBSIS.BLL.pbsfmhi.getfmhidistcoorprofile(C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistCoordID"))).DistrictCity_2
        txtDistrictState_2.Text = C21MIT.PBSIS.BLL.pbsfmhi.getfmhidistcoorprofile(C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistCoordID"))).DistrictState_2

        txtDistrictZip_2.Text = C21MIT.PBSIS.BLL.pbsfmhi.getfmhidistcoorprofile(C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistCoordID"))).DistrictZip_2

        txtDistrictPhone01_2.Text = Left(C21MIT.PBSIS.BLL.pbsfmhi.getfmhidistcoorprofile(C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistCoordID"))).DistrictPhone_2, 3)
        txtDistrictPhone02_2.Text = Mid(C21MIT.PBSIS.BLL.pbsfmhi.getfmhidistcoorprofile(C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistCoordID"))).DistrictPhone_2, 4, 3)
        txtDistrictPhone03_2.Text = Right(C21MIT.PBSIS.BLL.pbsfmhi.getfmhidistcoorprofile(C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistCoordID"))).DistrictPhone_2, 4)

        txtDistrictFax01_2.Text = Left(C21MIT.PBSIS.BLL.pbsfmhi.getfmhidistcoorprofile(C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistCoordID"))).DistrictFax_2, 3)
        txtDistrictFax02_2.Text = Mid(C21MIT.PBSIS.BLL.pbsfmhi.getfmhidistcoorprofile(C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistCoordID"))).DistrictFax_2, 4, 3)
        txtDistrictFax03_2.Text = Right(C21MIT.PBSIS.BLL.pbsfmhi.getfmhidistcoorprofile(C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistCoordID"))).DistrictFax_2, 4)


        txtDistrictCell01_2.Text = Left(C21MIT.PBSIS.BLL.pbsfmhi.getfmhidistcoorprofile(C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistCoordID"))).DistrictCell_2, 3)
        txtDistrictCell02_2.Text = Mid(C21MIT.PBSIS.BLL.pbsfmhi.getfmhidistcoorprofile(C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistCoordID"))).DistrictCell_2, 4, 3)
        txtDistrictCell03_2.Text = Right(C21MIT.PBSIS.BLL.pbsfmhi.getfmhidistcoorprofile(C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistCoordID"))).DistrictCell_2, 4)

        txtDistrictCoordEmail_2.Text = C21MIT.PBSIS.BLL.pbsfmhi.getfmhidistcoorprofile(C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistCoordID"))).DistrictCoordEmail

        If C21MIT.PBSIS.BLL.pbsfmhi.getfmhidistcoorprofile(C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistCoordID"))).DistCoordInactive = 1 Then
            chkInactive.Checked = True
        ElseIf C21MIT.PBSIS.BLL.pbsfmhi.getfmhidistcoorprofile(C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistCoordID"))).DistCoordInactive = 0 Then
            chkInactive.Checked = False
        End If
        'If C21MIT.PBSIS.BLL.pbsfmhi.getfmhidistprofile(C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistID"))).DistrictInactive = 1 Then
        '    chkInactive.Checked = True
        'ElseIf C21MIT.PBSIS.BLL.pbsfmhi.getfmhidistprofile(C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistID"))).DistrictInactive = 0 Then
        '    chkInactive.Checked = False
        'End If
    End Sub

    Sub bindlabel(ByVal status As String)
        If status = "New" Then
            lblCaption.Text = "ADD A DISTRICT COORDINATOR PROFILE"
            'lblDistName.Visible = False
        ElseIf status = "Update" Then
            lblCaption.Text = "EDIT A DISTRICT COORDINATOR PROFILE"
            'lblDistName.Visible = True
        End If
    End Sub

    Sub binddropdown()
        ddlSchoolDistrict.DataSource = C21MIT.PBSIS.BLL.pbsfmhinavigate.gedistlist()
        ddlSchoolDistrict.DataValueField = C21MIT.PBSIS.BLL.pbsfmhinavigate.gedistlist().Tables(0).Columns(0).ToString
        ddlSchoolDistrict.DataTextField = C21MIT.PBSIS.BLL.pbsfmhinavigate.gedistlist().Tables(0).Columns(1).ToString
        ddlSchoolDistrict.DataBind()
        ddlSchoolDistrict.Items.Insert(0, "Select a District")

    End Sub

    Protected Sub btnsubmit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnsubmit.Click
        If Not Request.QueryString("Status") Is Nothing Then
            savedistcoordprofile(Request.QueryString("Status"))
            Response.Redirect("~/users/smessages.aspx?qModule=DataSavedFMHI", False)
        Else
        End If
    End Sub

    Sub cleartextboxes()
    
        txtCoordFirstName_2.Text = ""
        txtCoordLastName_2.Text = ""

        txtStreetAddress1_2.Text = ""
        txtStreetAddress2_2.Text = ""

        txtDistrictCity_2.Text = ""
        txtDistrictState_2.Text = ""

        txtDistrictZip_2.Text = ""

        txtDistrictPhone01_2.Text = ""
        txtDistrictPhone02_2.Text = ""
        txtDistrictPhone03_2.Text = ""

        txtDistrictFax01_2.Text = ""
        txtDistrictFax02_2.Text = ""
        txtDistrictFax03_2.Text = ""

        txtDistrictCell01_2.Text = ""
        txtDistrictCell02_2.Text = ""
        txtDistrictCell03_2.Text = ""

        txtDistrictCoordEmail_2.Text = ""
    End Sub

    Sub savedistcoordprofile(ByVal status As String)
        Dim objFMHIAddDistrictCoordProfile As New C21MIT.PBSIS.BO.pbsdistprofile

        objFMHIAddDistrictCoordProfile.DistId = ddlSchoolDistrict.SelectedItem.Value
        objFMHIAddDistrictCoordProfile.DistCoordID = C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistCoordID"))
        objFMHIAddDistrictCoordProfile.DistCoordFirstName = txtCoordFirstName_2.Text
        objFMHIAddDistrictCoordProfile.DistCoordLastName = txtCoordLastName_2.Text
        objFMHIAddDistrictCoordProfile.DistrictCoordEmail = txtDistrictCoordEmail_2.Text

        'objFMHIAddDistrictCoordProfile.CoordFirstName_2 = txtCoordFirstName_2.Text
        'objFMHIAddDistrictCoordProfile.CoordLastName_2 = txtCoordLastName_2.Text
        objFMHIAddDistrictCoordProfile.StreetAddress1_2 = txtStreetAddress1_2.Text
        objFMHIAddDistrictCoordProfile.StreetAddress2_2 = txtStreetAddress2_2.Text
        objFMHIAddDistrictCoordProfile.DistrictCity_2 = txtDistrictCity_2.Text
        objFMHIAddDistrictCoordProfile.DistrictState_2 = txtDistrictState_2.Text
        objFMHIAddDistrictCoordProfile.DistrictZip_2 = txtDistrictZip_2.Text
        objFMHIAddDistrictCoordProfile.DistrictPhone_2 = txtDistrictPhone01_2.Text & txtDistrictPhone02_2.Text & txtDistrictPhone03_2.Text
        objFMHIAddDistrictCoordProfile.DistrictFax_2 = txtDistrictFax01_2.Text & txtDistrictFax02_2.Text & txtDistrictFax03_2.Text
        objFMHIAddDistrictCoordProfile.DistrictCell_2 = txtDistrictCell01_2.Text & txtDistrictCell02_2.Text & txtDistrictCell03_2.Text
        'objFMHIAddDistrictCoordProfile.DistrictCoordEmail_2 = txtDistrictCoordEmail_2.Text
        objFMHIAddDistrictCoordProfile.DistCoordInactive = checkradioinactive(chkInactive.Checked)

        If status = "New" Then
            C21MIT.PBSIS.BLL.pbsfmhi.addfmhidistcoorprofile(objFMHIAddDistrictCoordProfile)
            lblstatus.Text = "The District Coordinator profile has been successfully created."
        ElseIf status = "Update" Then
            C21MIT.PBSIS.BLL.pbsfmhi.updfmhidistcoorprofile(objFMHIAddDistrictCoordProfile)
            lblstatus.Text = "The District Coordinator profile has been successfully updated."
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
