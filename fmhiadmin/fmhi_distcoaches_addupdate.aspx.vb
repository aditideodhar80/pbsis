'-------------------------------------------------------------------------------------------------------------------
' Created By : Aditi Deodhar
' Created Dt : April 2,2010
' Last Updated Dt : April 5,2010
'-------------------------------------------------------------------------------------------------------------------
Partial Class fmhiadmin_fmhi_distcoaches_addupdate
    Inherits System.Web.UI.Page
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            ' C21MIT.PBSIS.BLL.pbsloginsession.chkloginsession("fmhiadm")
            If System.Web.HttpContext.Current.Session("sRptAuth") = "aD" Then
                ddlSchoolDistrict.Enabled = False
                ddlSchoolDistrict.SelectedValue = Session("sDistId")
            End If

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

    Sub bindlabel(ByVal status As String)
        If status = "New" Then
            lblCaption.Text = "ADD A DISTRICT COACH PROFILE"
        ElseIf status = "Update" Then
            lblCaption.Text = "EDIT A DISTRICT COACH PROFILE"
        End If
    End Sub

    Sub binddropdown()
        ddlSchoolDistrict.DataSource = C21MIT.PBSIS.BLL.pbsfmhinavigate.gedistlist()
        ddlSchoolDistrict.DataValueField = C21MIT.PBSIS.BLL.pbsfmhinavigate.gedistlist().Tables(0).Columns(0).ToString
        ddlSchoolDistrict.DataTextField = C21MIT.PBSIS.BLL.pbsfmhinavigate.gedistlist().Tables(0).Columns(1).ToString
        ddlSchoolDistrict.DataBind()
        ddlSchoolDistrict.Items.Insert(0, "Select a District")

    End Sub

    'Protected Sub btnsubmit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnsubmit.Click
    '    If Not Request.QueryString("Status") Is Nothing Then
    '        savedistcoachprofile(Request.QueryString("Status"))
    '        If Request.QueryString("Status") = "New" Then
    '            cleartextboxes()
    '        End If
    '    Else
    '    End If
    'End Sub

    Sub binddata()
        ddlSchoolDistrict.SelectedValue = C21MIT.PBSIS.BLL.pbsfmhi.getfmhidistcoachprofile(C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistCoachID"))).DistId
        txtCoachFirstName.Text = C21MIT.PBSIS.BLL.pbsfmhi.getfmhidistcoachprofile(C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistCoachID"))).CoachFirstName
        txtCoachLastName.Text = C21MIT.PBSIS.BLL.pbsfmhi.getfmhidistcoachprofile(C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistCoachID"))).CoachLastName
        txtDistrictCoachEmail.Text = C21MIT.PBSIS.BLL.pbsfmhi.getfmhidistcoachprofile(C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistCoachID"))).CoachEmail
        txtStreetAddress1_2.Text = C21MIT.PBSIS.BLL.pbsfmhi.getfmhidistcoachprofile(C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistCoachID"))).CoachStreetAddress1
        txtStreetAddress2_2.Text = C21MIT.PBSIS.BLL.pbsfmhi.getfmhidistcoachprofile(C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistCoachID"))).CoachStreetAddress2
        txtDistrictCity.Text = C21MIT.PBSIS.BLL.pbsfmhi.getfmhidistcoachprofile(C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistCoachID"))).CoachCity
        txtDistrictState.Text = C21MIT.PBSIS.BLL.pbsfmhi.getfmhidistcoachprofile(C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistCoachID"))).CoachState
        txtDistrictZip.Text = C21MIT.PBSIS.BLL.pbsfmhi.getfmhidistcoachprofile(C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistCoachID"))).CoachZip

        txtDistrictPhone01.Text = Left(C21MIT.PBSIS.BLL.pbsfmhi.getfmhidistcoachprofile(C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistCoachID"))).CoachOfficePhone, 3)
        txtDistrictPhone02.Text = Mid(C21MIT.PBSIS.BLL.pbsfmhi.getfmhidistcoachprofile(C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistCoachID"))).CoachOfficePhone, 4, 3)
        txtDistrictPhone03.Text = Right(C21MIT.PBSIS.BLL.pbsfmhi.getfmhidistcoachprofile(C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistCoachID"))).CoachOfficePhone, 4)

        txtDistrictFax01.Text = Left(C21MIT.PBSIS.BLL.pbsfmhi.getfmhidistcoachprofile(C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistCoachID"))).CoachFax, 3)
        txtDistrictFax02.Text = Mid(C21MIT.PBSIS.BLL.pbsfmhi.getfmhidistcoachprofile(C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistCoachID"))).CoachFax, 4, 3)
        txtDistrictFax03.Text = Right(C21MIT.PBSIS.BLL.pbsfmhi.getfmhidistcoachprofile(C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistCoachID"))).CoachFax, 4)


        txtDistrictCell01.Text = Left(C21MIT.PBSIS.BLL.pbsfmhi.getfmhidistcoachprofile(C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistCoachID"))).CoachCellPhone, 3)
        txtDistrictCell02.Text = Mid(C21MIT.PBSIS.BLL.pbsfmhi.getfmhidistcoachprofile(C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistCoachID"))).CoachCellPhone, 4, 3)
        txtDistrictCell03.Text = Right(C21MIT.PBSIS.BLL.pbsfmhi.getfmhidistcoachprofile(C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistCoachID"))).CoachCellPhone, 4)

        If C21MIT.PBSIS.BLL.pbsfmhi.getfmhidistcoachprofile(C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistCoachID"))).CoachInactive = 1 Then
            chkInactive.Checked = True
        ElseIf C21MIT.PBSIS.BLL.pbsfmhi.getfmhidistcoachprofile(C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistCoachID"))).CoachInactive = 0 Then
            chkInactive.Checked = False
        End If


    End Sub

    Protected Sub btnsubmit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnsubmit.Click
        If System.Web.HttpContext.Current.Session("sRptAuth") = "aD" Then
            If Not Request.QueryString("Status") Is Nothing Then
                savedistcoachprofile(Request.QueryString("Status"))
                If C21MIT.PBSIS.BLL.pbsloginsession.fnchkloginsession() = "aF" Then
                    Response.Redirect("~/users/smessages.aspx?qModule=DataSavedFMHI", False)
                ElseIf C21MIT.PBSIS.BLL.pbsloginsession.fnchkloginsession() = "aD" Then
                    Response.Redirect("~/users/smessages.aspx?qModule=DataSavedDist", False)
                End If
               
            Else
            End If

        End If


        If Not Request.QueryString("Status") Is Nothing Then
            savedistcoachprofile(Request.QueryString("Status"))
            If C21MIT.PBSIS.BLL.pbsloginsession.fnchkloginsession() = "aF" Then
                Response.Redirect("~/users/smessages.aspx?qModule=DataSavedFMHI", False)
            ElseIf C21MIT.PBSIS.BLL.pbsloginsession.fnchkloginsession() = "aD" Then
                Response.Redirect("~/users/smessages.aspx?qModule=DataSavedDist", False)
            End If
            
        Else
        End If
    End Sub

    Sub cleartextboxes()
        txtCoachFirstName.Text = ""
        txtCoachLastName.Text = ""
        txtDistrictCoachEmail.Text = ""

        txtStreetAddress1_2.Text = ""
        txtStreetAddress2_2.Text = ""

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

    Sub savedistcoachprofile(ByVal status As String)
        Dim objFMHIAddDistrictCoachProfile As New C21MIT.PBSIS.BO.pbscoachprofile
       
        objFMHIAddDistrictCoachProfile.DistId = ddlSchoolDistrict.SelectedItem.Value
        objFMHIAddDistrictCoachProfile.CoachFirstName = txtCoachFirstName.Text
        objFMHIAddDistrictCoachProfile.CoachLastName = txtCoachLastName.Text
        objFMHIAddDistrictCoachProfile.CoachEmail = txtDistrictCoachEmail.Text

        'POSTION

        objFMHIAddDistrictCoachProfile.CoachStreetAddress1 = txtStreetAddress1_2.Text
        objFMHIAddDistrictCoachProfile.CoachStreetAddress2 = txtStreetAddress2_2.Text
        objFMHIAddDistrictCoachProfile.CoachCity = txtDistrictCity.Text
        objFMHIAddDistrictCoachProfile.CoachState = txtDistrictState.Text
        objFMHIAddDistrictCoachProfile.CoachZip = txtDistrictZip.Text

        objFMHIAddDistrictCoachProfile.CoachOfficePhone = txtDistrictPhone01.Text & txtDistrictPhone02.Text & txtDistrictPhone03.Text
        objFMHIAddDistrictCoachProfile.CoachFax = txtDistrictFax01.Text & txtDistrictFax02.Text & txtDistrictFax03.Text
        objFMHIAddDistrictCoachProfile.CoachCellPhone = txtDistrictCell01.Text & txtDistrictCell02.Text & txtDistrictCell03.Text
        objFMHIAddDistrictCoachProfile.CoachInactive = checkradioinactive(chkInactive.Checked)
        If status = "New" Then
            C21MIT.PBSIS.BLL.pbsfmhi.addfmhidistcoachprofile(objFMHIAddDistrictCoachProfile)
            lblstatus.Text = "The District Coach profile has been successfully created."
        ElseIf status = "Update" Then
            objFMHIAddDistrictCoachProfile.CoachID = C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistCoachID"))
            C21MIT.PBSIS.BLL.pbsfmhi.updfmhidistcoachprofile(objFMHIAddDistrictCoachProfile)
            lblstatus.Text = "The District Coach profile has been successfully updated."
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
