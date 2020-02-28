
Partial Class school_school_Bat_Add
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            C21MIT.PBSIS.BLL.pbsloginsession.chkloginsession("School")

            Dim objBAT As New C21MIT.PBSIS.BO.pbsschoolreport

            objBAT.SchoolID = Session("MM_Username")
            objBAT.SchoolYear = CInt(Session("ActYrId"))

            binddropdown(objBAT.SchoolID)
            bindata(objBAT.SchoolID, objBAT.SchoolYear)
        End If
    End Sub

    Sub binddropdown(ByVal schoolID As String)
        ddlcoach.DataSource = C21MIT.PBSIS.BLL.pbsschoolpicboq.getSchoolPICBOQCoaches(schoolID)
        ddlcoach.DataValueField = C21MIT.PBSIS.BLL.pbsschoolpicboq.getSchoolPICBOQCoaches(schoolID).Tables(0).Columns(0).ToString
        ddlcoach.DataTextField = C21MIT.PBSIS.BLL.pbsschoolpicboq.getSchoolPICBOQCoaches(schoolID).Tables(0).Columns(1).ToString
        ddlcoach.DataBind()
        ddlcoach.Items.Insert(0, ("Select One"))
        ddlcoach.Items.Insert(1, "Name not in list")
    End Sub

    Sub bindata(ByVal schoolID As String, ByVal schoolYr As String)
        lblSchoolName.Text = C21MIT.PBSIS.BLL.pbsschoolprofile.getschoolprofile(schoolID).SchoolName
        lblSchoolYr.Text = C21MIT.PBSIS.BLL.pbsschoolyeardesc.getschoolyeardesc(schoolYr)
        lblDistrict.Text = C21MIT.PBSIS.BLL.pbslbat.pbsschoolbatendyrreport.fngetBatEndYearSchool(schoolID, schoolYr).DistrictName
    End Sub

    Protected Sub btnSubmit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnsubmit.Click
        Dim objBAT As New C21MIT.PBSIS.BO.pbsschoolreport

        objBAT.SchoolID = Session("MM_Username")
        objBAT.SchoolYear = CInt(Session("ActYrId"))

        addschoolBat()
        Response.Redirect("~/users/smessages.aspx?qModule=DataSaved", False)
    End Sub

    Sub addschoolBat()
        Dim objBat As New C21MIT.PBSIS.BO.pbsschoolreport

        objBat.SchoolID = Session("MM_Username")
        objBat.SchoolYear = CInt(Session("ActYrId"))

        If ddlcoach.SelectedIndex = "0" Then
            objBat.BOQCoachID = "0"
        ElseIf ddlcoach.SelectedIndex = "1" Then
            objBat.BOQCoachID = "1" '=9999?
        Else
            objBat.BOQCoachID = ddlcoach.SelectedItem.Value.ToString
        End If

        If radio1_4.Checked Then
            objBat.Question1 = 2
        ElseIf radio1_5.Checked Then
            objBat.Question1 = 1
        ElseIf radio1_6.Checked Then
            objBat.Question1 = 0
        End If

        If radio2_4.Checked Then
            objBat.Question2 = 2
        ElseIf radio2_5.Checked Then
            objBat.Question2 = 1
        ElseIf radio2_6.Checked Then
            objBat.Question2 = 0
        End If

        If radio3_4.Checked Then
            objBat.Question3 = 2
        ElseIf radio3_5.Checked Then
            objBat.Question3 = 1
        ElseIf radio3_6.Checked Then
            objBat.Question3 = 0
        End If

        If radio4_4.Checked Then
            objBat.Question4 = 2
        ElseIf radio4_5.Checked Then
            objBat.Question4 = 1
        ElseIf radio4_6.Checked Then
            objBat.Question4 = 0
        End If

        If radio5_4.Checked Then
            objBat.Question5 = 2
        ElseIf radio5_5.Checked Then
            objBat.Question5 = 1
        ElseIf radio5_6.Checked Then
            objBat.Question5 = 0
        End If

        If radio6_4.Checked Then
            objBat.Question6 = 2
        ElseIf radio6_5.Checked Then
            objBat.Question6 = 1
        ElseIf radio6_6.Checked Then
            objBat.Question6 = 0
        End If

        If radio7_4.Checked Then
            objBat.Question7 = 2
        ElseIf radio7_5.Checked Then
            objBat.Question7 = 1
        ElseIf radio7_6.Checked Then
            objBat.Question7 = 0
        End If

        If radio8_4.Checked Then
            objBat.Question8 = 2
        ElseIf radio8_5.Checked Then
            objBat.Question8 = 1
        ElseIf radio8_6.Checked Then
            objBat.Question8 = 0
        End If

        If radio9_4.Checked Then
            objBat.Question9 = 2
        ElseIf radio9_5.Checked Then
            objBat.Question9 = 1
        ElseIf radio9_6.Checked Then
            objBat.Question9 = 0
        End If

        If radio10_4.Checked Then
            objBat.Question10 = 2
        ElseIf radio10_5.Checked Then
            objBat.Question10 = 1
        ElseIf radio10_6.Checked Then
            objBat.Question10 = 0
        End If

        ''
        If radio11_4.Checked Then
            objBat.Question11 = 2
        ElseIf radio11_5.Checked Then
            objBat.Question11 = 1
        ElseIf radio11_6.Checked Then
            objBat.Question11 = 0
        End If

        If radio12_4.Checked Then
            objBat.Question14 = 2
        ElseIf radio12_5.Checked Then
            objBat.Question12 = 1
        ElseIf radio12_6.Checked Then
            objBat.Question12 = 0
        End If

        If radio13_4.Checked Then
            objBat.Question13 = 2
        ElseIf radio13_5.Checked Then
            objBat.Question13 = 1
        ElseIf radio13_6.Checked Then
            objBat.Question13 = 0
        End If

        If radio14_4.Checked Then
            objBat.Question14 = 2
        ElseIf radio14_5.Checked Then
            objBat.Question14 = 1
        ElseIf radio14_6.Checked Then
            objBat.Question14 = 0
        End If

        If radio15_4.Checked Then
            objBat.Question15 = 2
        ElseIf radio15_5.Checked Then
            objBat.Question15 = 1
        ElseIf radio15_6.Checked Then
            objBat.Question15 = 0
        End If

        If radio16_4.Checked Then
            objBat.Question16 = 2
        ElseIf radio16_5.Checked Then
            objBat.Question16 = 1
        ElseIf radio16_6.Checked Then
            objBat.Question16 = 0
        End If

        If radio17_4.Checked Then
            objBat.Question17 = 2
        ElseIf radio17_5.Checked Then
            objBat.Question17 = 1
        ElseIf radio17_6.Checked Then
            objBat.Question17 = 0
        End If

        If radio18_4.Checked Then
            objBat.Question18 = 2
        ElseIf radio18_5.Checked Then
            objBat.Question18 = 1
        ElseIf radio18_6.Checked Then
            objBat.Question18 = 0
        End If

        If radio19_4.Checked Then
            objBat.Question19 = 2
        ElseIf radio19_5.Checked Then
            objBat.Question19 = 1
        ElseIf radio19_6.Checked Then
            objBat.Question19 = 0
        End If

        If radio20_4.Checked Then
            objBat.Question40 = 2
        ElseIf radio20_5.Checked Then
            objBat.Question20 = 1
        ElseIf radio20_6.Checked Then
            objBat.Question20 = 0
        End If

        ''

        If radio21_4.Checked Then
            objBat.Question21 = 2
        ElseIf radio21_5.Checked Then
            objBat.Question21 = 1
        ElseIf radio21_6.Checked Then
            objBat.Question21 = 0
        End If


        If radio22_4.Checked Then
            objBat.Question22 = 2
        ElseIf radio22_5.Checked Then
            objBat.Question22 = 1
        ElseIf radio22_6.Checked Then
            objBat.Question22 = 0
        End If

        If radio23_4.Checked Then
            objBat.Question23 = 2
        ElseIf radio23_5.Checked Then
            objBat.Question23 = 1
        ElseIf radio23_6.Checked Then
            objBat.Question23 = 0
        End If

        If radio24_7.Checked Then
            objBat.Question24 = 2
        ElseIf radio24_5.Checked Then
            objBat.Question24 = 1
        ElseIf radio24_6.Checked Then
            objBat.Question24 = 0
        End If

        If radio25_4.Checked Then
            objBat.Question25 = 2
        ElseIf radio25_5.Checked Then
            objBat.Question25 = 1
        ElseIf radio25_6.Checked Then
            objBat.Question25 = 0
        End If

        If radio26_4.Checked Then
            objBat.Question26 = 2
        ElseIf radio26_5.Checked Then
            objBat.Question26 = 1
        ElseIf radio26_6.Checked Then
            objBat.Question26 = 0
        End If

        If radio27_4.Checked Then
            objBat.Question27 = 2
        ElseIf radio27_5.Checked Then
            objBat.Question27 = 1
        ElseIf radio27_6.Checked Then
            objBat.Question27 = 0
        End If

        If radio28_4.Checked Then
            objBat.Question28 = 2
        ElseIf radio28_5.Checked Then
            objBat.Question28 = 1
        ElseIf radio28_6.Checked Then
            objBat.Question28 = 0
        End If

        If radio29_4.Checked Then
            objBat.Question29 = 2
        ElseIf radio29_5.Checked Then
            objBat.Question29 = 1
        ElseIf radio29_6.Checked Then
            objBat.Question29 = 0
        End If

        If radio30_4.Checked Then
            objBat.Question30 = 2
        ElseIf radio30_5.Checked Then
            objBat.Question30 = 1
        ElseIf radio30_6.Checked Then
            objBat.Question30 = 0
        End If

        ''


        If radio31_4.Checked Then
            objBat.Question31 = 2
        ElseIf radio31_5.Checked Then
            objBat.Question31 = 1
        ElseIf radio31_6.Checked Then
            objBat.Question31 = 0
        End If


        If radio32_4.Checked Then
            objBat.Question32 = 2
        ElseIf radio32_5.Checked Then
            objBat.Question32 = 1
        ElseIf radio32_6.Checked Then
            objBat.Question32 = 0
        End If

        If radio33_4.Checked Then
            objBat.Question33 = 2
        ElseIf radio33_5.Checked Then
            objBat.Question33 = 1
        ElseIf radio33_6.Checked Then
            objBat.Question33 = 0
        End If

        If radio34_4.Checked Then
            objBat.Question34 = 2
        ElseIf radio34_5.Checked Then
            objBat.Question34 = 1
        ElseIf radio34_6.Checked Then
            objBat.Question34 = 0
        End If

        If radio35_4.Checked Then
            objBat.Question35 = 2
        ElseIf radio35_5.Checked Then
            objBat.Question35 = 1
        ElseIf radio35_6.Checked Then
            objBat.Question35 = 0
        End If

        If radio36_4.Checked Then
            objBat.Question36 = 2
        ElseIf radio36_5.Checked Then
            objBat.Question36 = 1
        ElseIf radio36_6.Checked Then
            objBat.Question36 = 0
        End If

        If radio37_4.Checked Then
            objBat.Question37 = 2
        ElseIf radio37_5.Checked Then
            objBat.Question37 = 1
        ElseIf radio37_6.Checked Then
            objBat.Question37 = 0
        End If

        If radio38_4.Checked Then
            objBat.Question38 = 2
        ElseIf radio38_5.Checked Then
            objBat.Question38 = 1
        ElseIf radio38_6.Checked Then
            objBat.Question38 = 0
        End If

        If radio39_4.Checked Then
            objBat.Question39 = 2
        ElseIf radio39_5.Checked Then
            objBat.Question39 = 1
        ElseIf radio39_6.Checked Then
            objBat.Question39 = 0
        End If

        If radio40_4.Checked Then
            objBat.Question40 = 2
        ElseIf radio40_5.Checked Then
            objBat.Question40 = 1
        ElseIf radio40_6.Checked Then
            objBat.Question40 = 0
        End If

        ''

        If radio41_4.Checked Then
            objBat.Question41 = 2
        ElseIf radio41_5.Checked Then
            objBat.Question41 = 1
        ElseIf radio41_6.Checked Then
            objBat.Question41 = 0
        End If

        If radio42_4.Checked Then
            objBat.Question42 = 2
        ElseIf radio42_5.Checked Then
            objBat.Question42 = 1
        ElseIf radio42_6.Checked Then
            objBat.Question42 = 0
        End If

        If radio43_4.Checked Then
            objBat.Question43 = 2
        ElseIf radio43_5.Checked Then
            objBat.Question43 = 1
        ElseIf radio43_6.Checked Then
            objBat.Question43 = 0
        End If

        If radio44_4.Checked Then
            objBat.Question44 = 2
        ElseIf radio44_5.Checked Then
            objBat.Question44 = 1
        ElseIf radio44_6.Checked Then
            objBat.Question44 = 0
        End If

        If radio46_4.Checked Then
            objBat.Question46 = 2
        ElseIf radio46_5.Checked Then
            objBat.Question46 = 1
        ElseIf radio46_6.Checked Then
            objBat.Question46 = 0
        End If

        If radio47_4.Checked Then
            objBat.Question47 = 2
        ElseIf radio47_5.Checked Then
            objBat.Question47 = 1
        ElseIf radio47_6.Checked Then
            objBat.Question47 = 0
        End If

        If radio48_4.Checked Then
            objBat.Question48 = 2
        ElseIf radio48_5.Checked Then
            objBat.Question48 = 1
        ElseIf radio48_6.Checked Then
            objBat.Question48 = 0
        End If

        If radio49_4.Checked Then
            objBat.Question49 = 2
        ElseIf radio49_5.Checked Then
            objBat.Question49 = 1
        ElseIf radio49_6.Checked Then
            objBat.Question49 = 0
        End If

        If radio50_4.Checked Then
            objBat.Question50 = 2
        ElseIf radio50_5.Checked Then
            objBat.Question50 = 1
        ElseIf radio50_6.Checked Then
            objBat.Question50 = 0
        End If

        If radio51_4.Checked Then
            objBat.Question51 = 2
        ElseIf radio51_5.Checked Then
            objBat.Question51 = 1
        ElseIf radio51_6.Checked Then
            objBat.Question51 = 0
        End If

        If radio52_4.Checked Then
            objBat.Question52 = 2
        ElseIf radio52_5.Checked Then
            objBat.Question52 = 1
        ElseIf radio52_6.Checked Then
            objBat.Question52 = 0
        End If

        If radio53_4.Checked Then
            objBat.Question53 = 2
        ElseIf radio53_5.Checked Then
            objBat.Question53 = 1
        ElseIf radio53_6.Checked Then
            objBat.Question53 = 0
        End If

        If radio54_4.Checked Then
            objBat.Question54 = 2
        ElseIf radio54_5.Checked Then
            objBat.Question54 = 1
        ElseIf radio54_6.Checked Then
            objBat.Question54 = 0
        End If

        If radio55_4.Checked Then
            objBat.Question55 = 2
        ElseIf radio55_5.Checked Then
            objBat.Question55 = 1
        ElseIf radio55_6.Checked Then
            objBat.Question55 = 0
        End If

        If radio56_4.Checked Then
            objBat.Question56 = 2
        ElseIf radio56_5.Checked Then
            objBat.Question56 = 1
        ElseIf radio56_6.Checked Then
            objBat.Question56 = 0
        End If

        objBat.InterviewUsed = IntrvUsd.Text
        objBat.TeamLeader = txtTLeader.Text
        objBat.TeamMember = txtTMembers.Text
        C21MIT.PBSIS.BLL.pbslbat.pbsschoolbatendyrreport.addSchoolBAT(objBat)
    End Sub
End Class
