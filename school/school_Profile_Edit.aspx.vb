'-------------------------------------------------------------------------------------------------------------------
' Created By : Aditi Deodhar
' Created Dt : Feb 3,2010
' Last Updated Dt : Feb 3,2010
'-------------------------------------------------------------------------------------------------------------------
Partial Class users_school_Profile_Edit
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            C21MIT.PBSIS.BLL.pbsloginsession.chkloginsession("School")

            'Get all the school profile details and bind them to the form.
            bindschoolprofiledata(Session("MM_Username"))
        End If
    End Sub

    Sub bindschoolprofiledata(ByVal sUserName As String)
        C21MIT.PBSIS.BLL.pbsschoolprofile.getschoolprofile(sUserName)

        lblSchoolName.Text = C21MIT.PBSIS.BLL.pbsschoolprofile.getschoolprofile(sUserName).SchoolName
        txtSchoolStreetAddress1.Text = C21MIT.PBSIS.BLL.pbsschoolprofile.getschoolprofile(sUserName).SchoolStreetAddress1
        txtSchoolStreetAddress2.Text = C21MIT.PBSIS.BLL.pbsschoolprofile.getschoolprofile(sUserName).SchoolStreetAddress2
        txtSchoolCity.Text = C21MIT.PBSIS.BLL.pbsschoolprofile.getschoolprofile(sUserName).SchoolCity
        txtSchoolState.Text = C21MIT.PBSIS.BLL.pbsschoolprofile.getschoolprofile(sUserName).SchoolState
        txtSchoolZip.Text = C21MIT.PBSIS.BLL.pbsschoolprofile.getschoolprofile(sUserName).SchoolZip
        txtSchoolAdministratorName.Text = C21MIT.PBSIS.BLL.pbsschoolprofile.getschoolprofile(sUserName).SchoolAdministratorName

        txtSchoolPhone01.Text = Left(C21MIT.PBSIS.BLL.pbsschoolprofile.getschoolprofile(sUserName).SchoolPhone, 3)
        txtSchoolPhone02.Text = Mid(C21MIT.PBSIS.BLL.pbsschoolprofile.getschoolprofile(sUserName).SchoolPhone, 4, 3)
        txtSchoolPhone03.Text = Right(C21MIT.PBSIS.BLL.pbsschoolprofile.getschoolprofile(sUserName).SchoolPhone, 4)

        txtSchoolFax01.Text = Left(C21MIT.PBSIS.BLL.pbsschoolprofile.getschoolprofile(sUserName).SchoolFax, 3)
        txtSchoolFax02.Text = Mid(C21MIT.PBSIS.BLL.pbsschoolprofile.getschoolprofile(sUserName).SchoolFax, 4, 3)
        txtSchoolFax03.Text = Right(C21MIT.PBSIS.BLL.pbsschoolprofile.getschoolprofile(sUserName).SchoolFax, 4)

        txtSchoolAdministratorPhone01.Text = Left(C21MIT.PBSIS.BLL.pbsschoolprofile.getschoolprofile(sUserName).SchoolAdministratorPhone, 3)
        txtSchoolAdministratorPhone02.Text = Mid(C21MIT.PBSIS.BLL.pbsschoolprofile.getschoolprofile(sUserName).SchoolAdministratorPhone, 4, 3)
        txtSchoolAdministratorPhone03.Text = Right(C21MIT.PBSIS.BLL.pbsschoolprofile.getschoolprofile(sUserName).SchoolAdministratorPhone, 4)

        txtSchoolAdministratorEmail.Text = C21MIT.PBSIS.BLL.pbsschoolprofile.getschoolprofile(sUserName).SchoolAdministratorEmail

        'Bind dropdownlist (Type of School)
        'ddlSchoolType.Items.Insert(0, "Select a Type")

        If Not (C21MIT.PBSIS.BLL.pbsschoolprofile.getschoolprofile(sUserName).SchoolType) Is DBNull.Value Then
            If CStr(C21MIT.PBSIS.BLL.pbsschoolprofile.getschoolprofile(sUserName).SchoolType) = "" Or CStr(C21MIT.PBSIS.BLL.pbsschoolprofile.getschoolprofile(sUserName).SchoolType) = -1 Then
                ddlSchoolType.SelectedItem.Text = "Select a Type"
            ElseIf CStr(C21MIT.PBSIS.BLL.pbsschoolprofile.getschoolprofile(sUserName).SchoolType) <> "" Then
                ddlSchoolType.SelectedIndex = C21MIT.PBSIS.BLL.pbsschoolprofile.getschoolprofile(sUserName).SchoolType + 1
            End If
        End If
    End Sub

    Sub validatecontrols()
        Dim i As Integer
        Dim profdata(12) As String

        profdata(0) = txtSchoolStreetAddress1.Text
        profdata(1) = txtSchoolStreetAddress2.Text
        profdata(2) = txtSchoolCity.Text
        profdata(3) = txtSchoolState.Text
        profdata(4) = txtSchoolZip.Text
        profdata(5) = txtSchoolPhone01.Text & txtSchoolPhone02.Text & txtSchoolPhone03.Text
        profdata(6) = txtSchoolFax01.Text & txtSchoolFax02.Text & txtSchoolFax03.Text
        profdata(7) = txtSchoolAdministratorName.Text
        profdata(8) = txtSchoolAdministratorPhone01.Text & txtSchoolAdministratorPhone02.Text & txtSchoolAdministratorPhone03.Text
        profdata(9) = txtSchoolAdministratorEmail.Text
        profdata(10) = ddlSchoolType.SelectedItem.Value

        Dim fieldDescription() As String
        fieldDescription = New String() {"School Street Address", "School Street Address (Line 2)", "School City", "School State", "School Zip Code", "School Phone Number", "School Fax Number", "School Administrator's Name", "School Administrator's Phone Number", "School Administrator's Email Address", "School Type"}

        Dim errorMessage As String = ""
        Dim errorsFound As Integer
        Dim errorType As Integer

        errorsFound = 0
        errorType = 0

        'Checking all of the required fields	
        For i = 0 To 10
            If ((i <> 1) And profdata(i) = "") Then
                errorType = 1
                errorsFound = errorsFound + 1
                errorMessage = errorMessage & fieldDescription(i) & "<br>"
            End If
        Next
    End Sub

    Protected Sub btnSubmit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSubmit.Click
        'save school profile edits to the database
        saveschoolprofile()
    End Sub

    Sub saveschoolprofile()
        Dim objSchoolProfile As New C21MIT.PBSIS.BO.pbsschoolprofile

        objSchoolProfile.SchoolId = Session("MM_Username")
        If txtSchoolStreetAddress1.Text <> "" Then
            objSchoolProfile.SchoolStreetAddress1 = txtSchoolStreetAddress1.Text
        Else
            objSchoolProfile.SchoolStreetAddress1 = ""
        End If

        If txtSchoolStreetAddress2.Text <> "" Then
            objSchoolProfile.SchoolStreetAddress2 = txtSchoolStreetAddress2.Text
        Else
            objSchoolProfile.SchoolStreetAddress2 = ""
        End If

        If txtSchoolPhone01.Text <> "" And txtSchoolPhone02.Text <> "" And txtSchoolPhone03.Text <> "" Then
            objSchoolProfile.SchoolPhone = txtSchoolPhone01.Text & txtSchoolPhone02.Text & txtSchoolPhone03.Text
        Else
            objSchoolProfile.SchoolPhone = ""
        End If

        If txtSchoolFax01.Text <> "" And txtSchoolFax02.Text <> "" And txtSchoolFax03.Text <> "" Then
            objSchoolProfile.SchoolFax = txtSchoolFax01.Text & txtSchoolFax02.Text & txtSchoolFax03.Text
        Else
            objSchoolProfile.SchoolFax = ""
        End If

        If txtSchoolCity.Text <> "" Then
            objSchoolProfile.SchoolCity = txtSchoolCity.Text
        Else
            objSchoolProfile.SchoolCity = ""
        End If

        If txtSchoolState.Text <> "" Then
            objSchoolProfile.SchoolState = txtSchoolState.Text
        Else
            objSchoolProfile.SchoolState = ""
        End If

        If txtSchoolZip.Text <> "" Then
            objSchoolProfile.SchoolZip = txtSchoolZip.Text
        Else
            objSchoolProfile.SchoolZip = ""
        End If

        If txtSchoolAdministratorName.Text <> "" Then
            objSchoolProfile.SchoolAdministratorName = txtSchoolAdministratorName.Text
        Else
            objSchoolProfile.SchoolAdministratorName = ""
        End If

        If txtSchoolAdministratorName.Text <> "" Then
            objSchoolProfile.SchoolAdministratorName = txtSchoolAdministratorName.Text
        Else
            objSchoolProfile.SchoolAdministratorName = ""
        End If

        If txtSchoolAdministratorPhone01.Text <> "" And txtSchoolAdministratorPhone02.Text <> "" And txtSchoolAdministratorPhone03.Text <> "" Then
            objSchoolProfile.SchoolAdministratorPhone = txtSchoolAdministratorPhone01.Text & txtSchoolAdministratorPhone02.Text & txtSchoolAdministratorPhone03.Text
        Else
            objSchoolProfile.SchoolAdministratorPhone = ""
        End If

        If txtSchoolAdministratorEmail.Text <> "" Then
            objSchoolProfile.SchoolAdministratorEmail = txtSchoolAdministratorEmail.Text
        Else
            objSchoolProfile.SchoolAdministratorEmail = ""
        End If

        If ddlSchoolType.SelectedItem.Value >= 0 Then
            objSchoolProfile.SchoolType = ddlSchoolType.SelectedItem.Value
        ElseIf ddlSchoolType.SelectedItem.Value = -1 Then
            objSchoolProfile.SchoolType = 0
        End If

        C21MIT.PBSIS.BLL.pbsschoolprofile.updschoolprofile(objSchoolProfile)
    End Sub
End Class
