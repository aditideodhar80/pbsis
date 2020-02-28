'-------------------------------------------------------------------------------------------------------------------
' Created By : Aditi Deodhar
' Created Dt : March 31,2010
' Last Updated Dt : April 1,2010
'-------------------------------------------------------------------------------------------------------------------
Partial Class fmhiadmin_fmhi_sch_addupdate
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            '  C21MIT.PBSIS.BLL.pbsloginsession.chkloginsession("fmhiadm")

            If System.Web.HttpContext.Current.Session("sRptAuth") = "aD" Then
                ddlSchoolDistrict.Enabled = False
                ddlSchoolDistrict.SelectedValue = Session("sDistId")
            End If

            If Not Request.QueryString("Status") Is Nothing Then
                bindlabel(Request.QueryString("Status"))
                bindbuttonlabels(Request.QueryString("Status"))
                If Request.QueryString("Status") = "New" Then
                    binddropdown()

                ElseIf Request.QueryString("Status") = "Update" Then
                    binddropdown()
                    binddata()
                End If
            Else

            End If
        End If
    End Sub

    Sub binddata()
        txtSchoolName.Text = C21MIT.PBSIS.BLL.pbsfmhi.getfmhischprofile(C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("SchID"))).SchoolName
        txtSchoolID.Text = C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("SchID"))
        txtSchoolPhone01.Text = Left(C21MIT.PBSIS.BLL.pbsfmhi.getfmhischprofile(C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("SchID"))).SchoolPhone, 3)
        txtSchoolPhone02.Text = Mid(C21MIT.PBSIS.BLL.pbsfmhi.getfmhischprofile(C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("SchID"))).SchoolPhone, 4, 3)
        txtSchoolPhone03.Text = Right(C21MIT.PBSIS.BLL.pbsfmhi.getfmhischprofile(C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("SchID"))).SchoolPhone, 4)
        ddlSchoolDistrict.SelectedValue = C21MIT.PBSIS.BLL.pbsfmhi.getfmhischprofile(C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("SchID"))).SchoolDistrict
        txtSchoolFax01.Text = Left(C21MIT.PBSIS.BLL.pbsfmhi.getfmhischprofile(C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("SchID"))).SchoolFax, 3)
        txtSchoolFax02.Text = Mid(C21MIT.PBSIS.BLL.pbsfmhi.getfmhischprofile(C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("SchID"))).SchoolFax, 4, 3)
        txtSchoolFax03.Text = Right(C21MIT.PBSIS.BLL.pbsfmhi.getfmhischprofile(C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("SchID"))).SchoolFax, 4)
        txtSchoolStreetAddress1.Text = C21MIT.PBSIS.BLL.pbsfmhi.getfmhischprofile(C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("SchID"))).SchoolStreetAddress1
        txtSchoolStreetAddress2.Text = C21MIT.PBSIS.BLL.pbsfmhi.getfmhischprofile(C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("SchID"))).SchoolStreetAddress2
        txtSchoolCity.Text = C21MIT.PBSIS.BLL.pbsfmhi.getfmhischprofile(C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("SchID"))).SchoolCity
        txtSchoolState.Text = C21MIT.PBSIS.BLL.pbsfmhi.getfmhischprofile(C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("SchID"))).SchoolState
        txtSchoolZip.Text = C21MIT.PBSIS.BLL.pbsfmhi.getfmhischprofile(C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("SchID"))).SchoolZip
        txtSchoolAdministratorName.Text = C21MIT.PBSIS.BLL.pbsfmhi.getfmhischprofile(C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("SchID"))).SchoolAdministratorName
        txtSchoolAdministratorPhone01.Text = Left(C21MIT.PBSIS.BLL.pbsfmhi.getfmhischprofile(C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("SchID"))).SchoolAdministratorPhone, 3)
        txtSchoolAdministratorPhone02.Text = Mid(C21MIT.PBSIS.BLL.pbsfmhi.getfmhischprofile(C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("SchID"))).SchoolAdministratorPhone, 4, 3)
        txtSchoolAdministratorPhone03.Text = Right(C21MIT.PBSIS.BLL.pbsfmhi.getfmhischprofile(C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("SchID"))).SchoolAdministratorPhone, 4)
        txtSchoolAdministratorEmail.Text = C21MIT.PBSIS.BLL.pbsfmhi.getfmhischprofile(C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("SchID"))).SchoolAdministratorEmail
        ddlSchoolType.SelectedValue = C21MIT.PBSIS.BLL.pbsfmhi.getfmhischprofile(C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("SchID"))).SchoolType

        If C21MIT.PBSIS.BLL.pbsfmhi.getfmhischprofile(C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("SchID"))).SchoolInactive = 1 Then
            chkInactive.Checked = True
        ElseIf C21MIT.PBSIS.BLL.pbsfmhi.getfmhischprofile(C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("SchID"))).SchoolInactive = 0 Then
            chkInactive.Checked = False
        End If

        If C21MIT.PBSIS.BLL.pbsfmhi.getfmhischprofile(C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("SchID"))).Baseline_Available = 1 Then
            rbbaseline1.Checked = True
        ElseIf C21MIT.PBSIS.BLL.pbsfmhi.getfmhischprofile(C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("SchID"))).Baseline_Available = 0 Then
            rbbaseline0.Checked = True
        End If

        If C21MIT.PBSIS.BLL.pbsfmhi.getfmhischprofile(C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("SchID"))).Baseline_Completed = 1 Then
            rbbaseline1.Enabled = False
            rbbaseline0.Enabled = False
        ElseIf C21MIT.PBSIS.BLL.pbsfmhi.getfmhischprofile(C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("SchID"))).Baseline_Completed = 0 Then
            rbbaseline1.Enabled = True
            rbbaseline0.Enabled = True
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
            lblCaption.Text = "ADD A SCHOOL PROFILE"
        ElseIf status = "Update" Then
            lblCaption.Text = "EDIT A SCHOOL PROFILE"
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
        If System.Web.HttpContext.Current.Session("sRptAuth") = "aD" Then
            If Not Request.QueryString("Status") Is Nothing Then
                saveschoolprofile(Request.QueryString("Status"))
                If C21MIT.PBSIS.BLL.pbsloginsession.fnchkloginsession() = "aF" Then
                    Response.Redirect("~/users/smessages.aspx?qModule=DataSavedFMHI", False)
                ElseIf C21MIT.PBSIS.BLL.pbsloginsession.fnchkloginsession() = "aD" Then
                    Response.Redirect("~/users/smessages.aspx?qModule=DataSavedDist", False)
                End If

            Else
            End If

        End If

        If Not Request.QueryString("Status") Is Nothing Then
            saveschoolprofile(Request.QueryString("Status"))
            If C21MIT.PBSIS.BLL.pbsloginsession.fnchkloginsession() = "aF" Then
                Response.Redirect("~/users/smessages.aspx?qModule=DataSavedFMHI", False)
            ElseIf C21MIT.PBSIS.BLL.pbsloginsession.fnchkloginsession() = "aD" Then
                Response.Redirect("~/users/smessages.aspx?qModule=DataSavedDist", False)
            End If
          
        Else
        End If
    End Sub

    Sub cleartextboxes()
        txtSchoolName.Text = ""
        txtSchoolID.Text = ""
        txtSchoolStreetAddress1.Text = ""
        txtSchoolStreetAddress2.Text = ""
        txtSchoolCity.Text = ""
        txtSchoolState.Text = ""
        txtSchoolZip.Text = ""
        txtSchoolPhone01.Text = ""
        txtSchoolPhone02.Text = ""
        txtSchoolPhone03.Text = ""
        '
        txtSchoolFax01.Text = ""
        txtSchoolFax02.Text = ""
        txtSchoolFax03.Text = ""

        txtSchoolAdministratorName.Text = ""
        txtSchoolAdministratorPhone01.Text = ""
        txtSchoolAdministratorPhone02.Text = ""
        txtSchoolAdministratorPhone03.Text = ""
        txtSchoolAdministratorEmail.Text = ""
        ddlSchoolDistrict.SelectedIndex = 0
        ddlSchoolType.SelectedIndex = 0
    End Sub

    Sub saveschoolprofile(ByVal status As String)
        Dim objFMHISchoolProfile As New C21MIT.PBSIS.BO.pbsschoolprofile

        If txtSchoolName.Text <> "" Then
            objFMHISchoolProfile.SchoolName = txtSchoolName.Text
        Else
            objFMHISchoolProfile.SchoolName = ""
        End If

        If txtSchoolID.Text <> "" Then
            objFMHISchoolProfile.SchoolId = txtSchoolID.Text
        Else
            objFMHISchoolProfile.SchoolId = ""
        End If

        If ddlSchoolDistrict.SelectedItem.Value >= 0 Then
            objFMHISchoolProfile.SchoolDistrict = ddlSchoolDistrict.SelectedItem.Value
        ElseIf ddlSchoolType.SelectedItem.Value = -1 Then
            objFMHISchoolProfile.SchoolDistrict = 0
        End If


        If txtSchoolStreetAddress1.Text <> "" Then
            objFMHISchoolProfile.SchoolStreetAddress1 = txtSchoolStreetAddress1.Text
        Else
            objFMHISchoolProfile.SchoolStreetAddress1 = ""
        End If

        If txtSchoolStreetAddress2.Text <> "" Then
            objFMHISchoolProfile.SchoolStreetAddress2 = txtSchoolStreetAddress2.Text
        Else
            objFMHISchoolProfile.SchoolStreetAddress2 = ""
        End If

        If txtSchoolCity.Text <> "" Then
            objFMHISchoolProfile.SchoolCity = txtSchoolCity.Text
        Else
            objFMHISchoolProfile.SchoolCity = ""
        End If

        If txtSchoolState.Text <> "" Then
            objFMHISchoolProfile.SchoolState = txtSchoolState.Text
        Else
            objFMHISchoolProfile.SchoolState = ""
        End If

        If txtSchoolZip.Text <> "" Then
            objFMHISchoolProfile.SchoolZip = txtSchoolZip.Text
        Else
            objFMHISchoolProfile.SchoolZip = ""
        End If

        If txtSchoolPhone01.Text <> "" And txtSchoolPhone02.Text <> "" And txtSchoolPhone03.Text <> "" Then
            objFMHISchoolProfile.SchoolPhone = txtSchoolPhone01.Text & txtSchoolPhone02.Text & txtSchoolPhone03.Text
        Else
            objFMHISchoolProfile.SchoolPhone = ""
        End If

        If txtSchoolFax01.Text <> "" And txtSchoolFax02.Text <> "" And txtSchoolFax03.Text <> "" Then
            objFMHISchoolProfile.SchoolFax = txtSchoolFax01.Text & txtSchoolFax02.Text & txtSchoolFax03.Text
        Else
            objFMHISchoolProfile.SchoolFax = ""
        End If

        If txtSchoolAdministratorName.Text <> "" Then
            objFMHISchoolProfile.SchoolAdministratorName = txtSchoolAdministratorName.Text
        Else
            objFMHISchoolProfile.SchoolAdministratorName = ""
        End If

        If txtSchoolAdministratorPhone01.Text <> "" And txtSchoolAdministratorPhone02.Text <> "" And txtSchoolAdministratorPhone03.Text <> "" Then
            objFMHISchoolProfile.SchoolAdministratorPhone = txtSchoolAdministratorPhone01.Text & txtSchoolAdministratorPhone02.Text & txtSchoolAdministratorPhone03.Text
        Else
            objFMHISchoolProfile.SchoolAdministratorPhone = ""
        End If

        If txtSchoolAdministratorEmail.Text <> "" Then
            objFMHISchoolProfile.SchoolAdministratorEmail = txtSchoolAdministratorEmail.Text
        Else
            objFMHISchoolProfile.SchoolAdministratorEmail = ""
        End If

        If ddlSchoolType.SelectedItem.Value >= 0 Then
            objFMHISchoolProfile.SchoolType = ddlSchoolType.SelectedItem.Value
        ElseIf ddlSchoolType.SelectedItem.Value = -1 Then
            objFMHISchoolProfile.SchoolType = 0
        End If

        If rbbaseline0.Checked = True Then
            objFMHISchoolProfile.Baseline_Available = 0
        ElseIf rbbaseline1.Checked = True Then
            objFMHISchoolProfile.Baseline_Available = 1
        End If
        objFMHISchoolProfile.SchoolInactive = checkradioinactive(chkInactive.Checked)

        If status = "New" Then
            C21MIT.PBSIS.BLL.pbsfmhi.addfmhischoolprofile(objFMHISchoolProfile)
            lblstatus.Text = "The School profile has been successfully created."
        ElseIf status = "Update" Then
            C21MIT.PBSIS.BLL.pbsfmhi.updatefmhischoolprofile(objFMHISchoolProfile)
            lblstatus.Text = "The School profile has been successfully updated."
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
