'-------------------------------------------------------------------------------------------------------------------
' Created By : Aditi Deodhar
' Created Dt : Feb 17,2010
' Last Updated Dt : Feb 17,2010
'-------------------------------------------------------------------------------------------------------------------
Partial Class school_school_BOQ_Add
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            C21MIT.PBSIS.BLL.pbsloginsession.chkloginsession("School")

            Dim objBOQ As New C21MIT.PBSIS.BO.pbsschoolreport

            objBOQ.SchoolID = Session("MM_Username")
            objBOQ.SchoolYear = C21MIT.PBSIS.BLL.pbslogindetails.GetCurrentPrimTracker.schoolyear

            binddropdown(objBOQ.SchoolID)
            bindata(objBOQ.SchoolID, objBOQ.SchoolYear)
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
        lblDistrict.Text = C21MIT.PBSIS.BLL.pbsschoolboqendyrreport.fngetBOQEndYearSchool(schoolID, schoolYr).DistrictName
    End Sub

    Protected Sub btnSubmit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnsubmit.Click
        Dim objBOQ As New C21MIT.PBSIS.BO.pbsschoolreport

        objBOQ.SchoolID = Session("MM_Username")
        objBOQ.SchoolYear = C21MIT.PBSIS.BLL.pbslogindetails.GetCurrentPrimTracker.schoolyear
        objBOQ.Interval = C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("PICTerm"))

        addschoolBOQ()
        Response.Redirect("~/users/smessages.aspx?qModule=DataSaved", False)
        ' objBOQ = Nothing
    End Sub

    Sub addschoolBOQ()
        Dim objBOQ As New C21MIT.PBSIS.BO.pbsschoolreport

        objBOQ.SchoolID = Session("MM_Username")
        objBOQ.SchoolYear = C21MIT.PBSIS.BLL.pbslogindetails.GetCurrentPrimTracker.schoolyear

        If ddlcoach.SelectedIndex = "0" Then
            objBOQ.BOQCoachID = "0"
        ElseIf ddlcoach.SelectedIndex = "1" Then
            objBOQ.BOQCoachID = "1" '=9999?
        Else
            objBOQ.BOQCoachID = ddlcoach.SelectedItem.Value.ToString
        End If

        If BoqQuestion1_3.Checked = True Then
            objBOQ.Question1 = BoqQuestion1_3.Text
        ElseIf BoqQuestion1_2.Checked = True Then
            objBOQ.Question1 = BoqQuestion1_2.Text
        ElseIf BoqQuestion1_1.Checked = True Then
            objBOQ.Question1 = BoqQuestion1_1.Text
        ElseIf BoqQuestion1_0.Checked = True Then
            objBOQ.Question1 = BoqQuestion1_0.Text
        End If

        If BoqQuestion2_2.Checked = True Then
            objBOQ.Question2 = BoqQuestion2_2.Text
        ElseIf BoqQuestion2_1.Checked = True Then
            objBOQ.Question2 = BoqQuestion2_1.Text
        ElseIf BoqQuestion2_0.Checked = True Then
            objBOQ.Question2 = BoqQuestion2_0.Text
        End If

        If BoqQuestion3_1.Checked = True Then
            objBOQ.Question3 = BoqQuestion3_1.Text
        ElseIf BoqQuestion3_0.Checked = True Then
            objBOQ.Question3 = BoqQuestion3_0.Text
        End If

        If BoqQuestion4_2.Checked = True Then
            objBOQ.Question4 = BoqQuestion4_2.Text
        ElseIf BoqQuestion4_1.Checked = True Then
            objBOQ.Question4 = BoqQuestion4_1.Text
        ElseIf BoqQuestion4_0.Checked = True Then
            objBOQ.Question4 = BoqQuestion4_0.Text
        End If

        If BoqQuestion5_2.Checked = True Then
            objBOQ.Question5 = BoqQuestion5_2.Text
        ElseIf BoqQuestion5_1.Checked = True Then
            objBOQ.Question5 = BoqQuestion5_1.Text
        ElseIf BoqQuestion5_0.Checked = True Then
            objBOQ.Question5 = BoqQuestion5_0.Text
        End If

        If BoqQuestion6_2.Checked = True Then
            objBOQ.Question6 = BoqQuestion6_2.Text
        ElseIf BoqQuestion6_1.Checked = True Then
            objBOQ.Question6 = BoqQuestion6_1.Text
        ElseIf BoqQuestion6_0.Checked = True Then
            objBOQ.Question6 = BoqQuestion6_0.Text
        End If

        If BoqQuestion7_2.Checked = True Then
            objBOQ.Question7 = BoqQuestion7_2.Text
        ElseIf BoqQuestion7_1.Checked = True Then
            objBOQ.Question7 = BoqQuestion7_1.Text
        ElseIf BoqQuestion7_0.Checked = True Then
            objBOQ.Question7 = BoqQuestion7_0.Text
        End If

        If BoqQuestion8_1.Checked = True Then
            objBOQ.Question8 = BoqQuestion8_1.Text
        ElseIf BoqQuestion8_0.Checked = True Then
            objBOQ.Question8 = BoqQuestion8_0.Text
        End If

        If BoqQuestion9_2.Checked = True Then
            objBOQ.Question9 = BoqQuestion9_2.Text
        ElseIf BoqQuestion9_1.Checked = True Then
            objBOQ.Question9 = BoqQuestion9_1.Text
        ElseIf BoqQuestion9_0.Checked = True Then
            objBOQ.Question9 = BoqQuestion9_0.Text
        End If

        If BoqQuestion10_3.Checked = True Then
            objBOQ.Question10 = BoqQuestion10_3.Text
        ElseIf BoqQuestion10_2.Checked = True Then
            objBOQ.Question10 = BoqQuestion10_2.Text
        ElseIf BoqQuestion10_1.Checked = True Then
            objBOQ.Question10 = BoqQuestion10_1.Text
        ElseIf BoqQuestion10_0.Checked = True Then
            objBOQ.Question10 = BoqQuestion10_0.Text
        End If

        If BoqQuestion11_2.Checked = True Then
            objBOQ.Question11 = BoqQuestion11_2.Text
        ElseIf BoqQuestion11_1.Checked = True Then
            objBOQ.Question11 = BoqQuestion11_1.Text
        ElseIf BoqQuestion11_0.Checked = True Then
            objBOQ.Question11 = BoqQuestion11_0.Text
        End If

        If BoqQuestion12_1.Checked = True Then
            objBOQ.Question12 = BoqQuestion12_1.Text
        ElseIf BoqQuestion12_0.Checked = True Then
            objBOQ.Question12 = BoqQuestion12_0.Text
        End If

        If BoqQuestion13_3.Checked = True Then
            objBOQ.Question13 = BoqQuestion13_3.Text
        ElseIf BoqQuestion13_2.Checked = True Then
            objBOQ.Question13 = BoqQuestion13_2.Text
        ElseIf BoqQuestion13_1.Checked = True Then
            objBOQ.Question13 = BoqQuestion13_1.Text
        ElseIf BoqQuestion13_0.Checked = True Then
            objBOQ.Question13 = BoqQuestion13_0.Text
        End If

        If BoqQuestion14_1.Checked = True Then
            objBOQ.Question14 = BoqQuestion14_1.Text
        ElseIf BoqQuestion14_0.Checked = True Then
            objBOQ.Question14 = BoqQuestion14_0.Text
        End If

        If BoqQuestion15_2.Checked = True Then
            objBOQ.Question15 = BoqQuestion15_2.Text
        ElseIf BoqQuestion15_1.Checked = True Then
            objBOQ.Question15 = BoqQuestion15_1.Text
        ElseIf BoqQuestion15_0.Checked = True Then
            objBOQ.Question15 = BoqQuestion15_0.Text
        End If

        If BoqQuestion16_2.Checked = True Then
            objBOQ.Question16 = BoqQuestion16_2.Text
        ElseIf BoqQuestion16_1.Checked = True Then
            objBOQ.Question16 = BoqQuestion16_1.Text
        ElseIf BoqQuestion16_0.Checked = True Then
            objBOQ.Question16 = BoqQuestion16_0.Text
        End If

        If BoqQuestion17_3.Checked = True Then
            objBOQ.Question17 = BoqQuestion17_3.Text
        ElseIf BoqQuestion17_2.Checked = True Then
            objBOQ.Question17 = BoqQuestion17_2.Text
        ElseIf BoqQuestion17_1.Checked = True Then
            objBOQ.Question17 = BoqQuestion17_1.Text
        ElseIf BoqQuestion17_0.Checked = True Then
            objBOQ.Question17 = BoqQuestion17_0.Text
        End If

        If BoqQuestion18_3.Checked = True Then
            objBOQ.Question18 = BoqQuestion18_3.Text
        ElseIf BoqQuestion18_2.Checked = True Then
            objBOQ.Question18 = BoqQuestion18_2.Text
        ElseIf BoqQuestion18_1.Checked = True Then
            objBOQ.Question18 = BoqQuestion18_1.Text
        ElseIf BoqQuestion18_0.Checked = True Then
            objBOQ.Question18 = BoqQuestion18_0.Text
        End If

        If BoqQuestion19_2.Checked = True Then
            objBOQ.Question19 = BoqQuestion19_2.Text
        ElseIf BoqQuestion19_1.Checked = True Then
            objBOQ.Question19 = BoqQuestion19_1.Text
        ElseIf BoqQuestion19_0.Checked = True Then
            objBOQ.Question19 = BoqQuestion19_0.Text
        End If

        If BoqQuestion20_1.Checked = True Then
            objBOQ.Question20 = BoqQuestion20_1.Text
        ElseIf BoqQuestion20_0.Checked = True Then
            objBOQ.Question20 = BoqQuestion20_0.Text
        End If

        If BoqQuestion21_2.Checked = True Then
            objBOQ.Question21 = BoqQuestion21_2.Text
        ElseIf BoqQuestion21_1.Checked = True Then
            objBOQ.Question21 = BoqQuestion21_1.Text
        ElseIf BoqQuestion21_0.Checked = True Then
            objBOQ.Question21 = BoqQuestion21_0.Text
        End If

        If BoqQuestion22_3.Checked = True Then
            objBOQ.Question22 = BoqQuestion22_3.Text
        ElseIf BoqQuestion22_2.Checked = True Then
            objBOQ.Question22 = BoqQuestion22_2.Text
        ElseIf BoqQuestion22_1.Checked = True Then
            objBOQ.Question22 = BoqQuestion22_1.Text
        ElseIf BoqQuestion22_0.Checked = True Then
            objBOQ.Question22 = BoqQuestion22_0.Text
        End If

        If BoqQuestion23_2.Checked = True Then
            objBOQ.Question23 = BoqQuestion23_2.Text
        ElseIf BoqQuestion23_1.Checked = True Then
            objBOQ.Question23 = BoqQuestion23_1.Text
        ElseIf BoqQuestion23_0.Checked = True Then
            objBOQ.Question23 = BoqQuestion23_0.Text
        End If

        If BoqQuestion24_3.Checked = True Then
            objBOQ.Question24 = BoqQuestion24_3.Text
        ElseIf BoqQuestion24_2.Checked = True Then
            objBOQ.Question24 = BoqQuestion24_2.Text
        ElseIf BoqQuestion24_1.Checked = True Then
            objBOQ.Question24 = BoqQuestion24_1.Text
        ElseIf BoqQuestion24_0.Checked = True Then
            objBOQ.Question24 = BoqQuestion24_0.Text
        End If

        If BoqQuestion25_2.Checked = True Then
            objBOQ.Question25 = BoqQuestion25_2.Text
        ElseIf BoqQuestion25_1.Checked = True Then
            objBOQ.Question25 = BoqQuestion25_1.Text
        ElseIf BoqQuestion25_0.Checked = True Then
            objBOQ.Question25 = BoqQuestion25_0.Text
        End If

        If BoqQuestion26_3.Checked = True Then
            objBOQ.Question26 = BoqQuestion26_3.Text
        ElseIf BoqQuestion26_2.Checked = True Then
            objBOQ.Question26 = BoqQuestion26_2.Text
        ElseIf BoqQuestion26_1.Checked = True Then
            objBOQ.Question26 = BoqQuestion26_1.Text
        ElseIf BoqQuestion26_0.Checked = True Then
            objBOQ.Question26 = BoqQuestion26_0.Text
        End If

        If BoqQuestion27_1.Checked = True Then
            objBOQ.Question27 = BoqQuestion27_1.Text
        ElseIf BoqQuestion27_0.Checked = True Then
            objBOQ.Question27 = BoqQuestion27_0.Text
        End If

        If BoqQuestion28_2.Checked = True Then
            objBOQ.Question28 = BoqQuestion28_2.Text
        ElseIf BoqQuestion28_1.Checked = True Then
            objBOQ.Question28 = BoqQuestion28_1.Text
        ElseIf BoqQuestion28_0.Checked = True Then
            objBOQ.Question28 = BoqQuestion28_0.Text
        End If

        If BoqQuestion29_2.Checked = True Then
            objBOQ.Question29 = BoqQuestion29_2.Text
        ElseIf BoqQuestion29_1.Checked = True Then
            objBOQ.Question29 = BoqQuestion29_1.Text
        ElseIf BoqQuestion29_0.Checked = True Then
            objBOQ.Question29 = BoqQuestion29_0.Text
        End If

        If BoqQuestion30_1.Checked = True Then
            objBOQ.Question30 = BoqQuestion30_1.Text
        ElseIf BoqQuestion30_0.Checked = True Then
            objBOQ.Question30 = BoqQuestion30_0.Text
        End If

        If BoqQuestion31_2.Checked = True Then
            objBOQ.Question31 = BoqQuestion31_2.Text
        ElseIf BoqQuestion31_1.Checked = True Then
            objBOQ.Question31 = BoqQuestion31_1.Text
        ElseIf BoqQuestion31_0.Checked = True Then
            objBOQ.Question31 = BoqQuestion31_0.Text
        End If

        If BoqQuestion32_2.Checked = True Then
            objBOQ.Question32 = BoqQuestion32_2.Text
        ElseIf BoqQuestion32_1.Checked = True Then
            objBOQ.Question32 = BoqQuestion32_1.Text
        ElseIf BoqQuestion32_0.Checked = True Then
            objBOQ.Question32 = BoqQuestion32_0.Text
        End If

        If BoqQuestion33_1.Checked = True Then
            objBOQ.Question33 = BoqQuestion33_1.Text
        ElseIf BoqQuestion33_0.Checked = True Then
            objBOQ.Question33 = BoqQuestion33_0.Text
        End If

        If BoqQuestion34_1.Checked = True Then
            objBOQ.Question34 = BoqQuestion34_1.Text
        ElseIf BoqQuestion34_0.Checked = True Then
            objBOQ.Question34 = BoqQuestion34_0.Text
        End If

        If BoqQuestion35_2.Checked = True Then
            objBOQ.Question35 = BoqQuestion35_2.Text
        ElseIf BoqQuestion35_1.Checked = True Then
            objBOQ.Question35 = BoqQuestion35_1.Text
        ElseIf BoqQuestion35_0.Checked = True Then
            objBOQ.Question35 = BoqQuestion35_0.Text
        End If

        If BoqQuestion36_2.Checked = True Then
            objBOQ.Question36 = BoqQuestion36_2.Text
        ElseIf BoqQuestion36_1.Checked = True Then
            objBOQ.Question36 = BoqQuestion36_1.Text
        ElseIf BoqQuestion36_0.Checked = True Then
            objBOQ.Question36 = BoqQuestion36_0.Text
        End If

        If BoqQuestion37_3.Checked = True Then
            objBOQ.Question37 = BoqQuestion37_3.Text
        ElseIf BoqQuestion37_2.Checked = True Then
            objBOQ.Question37 = BoqQuestion37_2.Text
        ElseIf BoqQuestion37_1.Checked = True Then
            objBOQ.Question37 = BoqQuestion37_1.Text
        ElseIf BoqQuestion37_0.Checked = True Then
            objBOQ.Question37 = BoqQuestion37_0.Text
        End If

        If BoqQuestion38_2.Checked = True Then
            objBOQ.Question38 = BoqQuestion38_2.Text
        ElseIf BoqQuestion38_1.Checked = True Then
            objBOQ.Question38 = BoqQuestion38_1.Text
        ElseIf BoqQuestion38_0.Checked = True Then
            objBOQ.Question38 = BoqQuestion38_0.Text
        End If

        If BoqQuestion39_1.Checked = True Then
            objBOQ.Question39 = BoqQuestion39_1.Text
        ElseIf BoqQuestion39_0.Checked = True Then
            objBOQ.Question39 = BoqQuestion39_0.Text
        End If

        If BoqQuestion40_2.Checked = True Then
            objBOQ.Question40 = BoqQuestion40_2.Text
        ElseIf BoqQuestion40_1.Checked = True Then
            objBOQ.Question40 = BoqQuestion40_1.Text
        ElseIf BoqQuestion40_0.Checked = True Then
            objBOQ.Question40 = BoqQuestion40_0.Text
        End If

        If BoqQuestion41_1.Checked = True Then
            objBOQ.Question41 = BoqQuestion41_1.Text
        ElseIf BoqQuestion41_0.Checked = True Then
            objBOQ.Question41 = BoqQuestion41_0.Text
        End If

        If BoqQuestion42_2.Checked = True Then
            objBOQ.Question42 = BoqQuestion42_2.Text
        ElseIf BoqQuestion42_1.Checked = True Then
            objBOQ.Question42 = BoqQuestion42_1.Text
        ElseIf BoqQuestion42_0.Checked = True Then
            objBOQ.Question42 = BoqQuestion42_0.Text
        End If

        If BoqQuestion43_2.Checked = True Then
            objBOQ.Question43 = BoqQuestion43_2.Text
        ElseIf BoqQuestion43_1.Checked = True Then
            objBOQ.Question43 = BoqQuestion43_1.Text
        ElseIf BoqQuestion43_0.Checked = True Then
            objBOQ.Question43 = BoqQuestion43_0.Text
        End If

        If BoqQuestion44_2.Checked = True Then
            objBOQ.Question44 = BoqQuestion44_2.Text
        ElseIf BoqQuestion44_1.Checked = True Then
            objBOQ.Question44 = BoqQuestion44_1.Text
        ElseIf BoqQuestion44_0.Checked = True Then
            objBOQ.Question44 = BoqQuestion44_0.Text
        End If

        If BoqQuestion45_2.Checked = True Then
            objBOQ.Question45 = BoqQuestion45_2.Text
        ElseIf BoqQuestion45_1.Checked = True Then
            objBOQ.Question45 = BoqQuestion45_1.Text
        ElseIf BoqQuestion45_0.Checked = True Then
            objBOQ.Question45 = BoqQuestion45_0.Text
        End If

        If BoqQuestion46_2.Checked = True Then
            objBOQ.Question46 = BoqQuestion46_2.Text
        ElseIf BoqQuestion46_1.Checked = True Then
            objBOQ.Question46 = BoqQuestion46_1.Text
        ElseIf BoqQuestion46_0.Checked = True Then
            objBOQ.Question46 = BoqQuestion46_0.Text
        End If

        If BoqQuestion47_2.Checked = True Then
            objBOQ.Question47 = BoqQuestion47_2.Text
        ElseIf BoqQuestion47_1.Checked = True Then
            objBOQ.Question47 = BoqQuestion47_1.Text
        ElseIf BoqQuestion47_0.Checked = True Then
            objBOQ.Question47 = BoqQuestion47_0.Text
        End If

        If BoqQuestion48_2.Checked = True Then
            objBOQ.Question48 = BoqQuestion48_2.Text
        ElseIf BoqQuestion48_1.Checked = True Then
            objBOQ.Question48 = BoqQuestion48_1.Text
        ElseIf BoqQuestion48_0.Checked = True Then
            objBOQ.Question48 = BoqQuestion48_0.Text
        End If

        If BoqQuestion49_2.Checked = True Then
            objBOQ.Question49 = BoqQuestion49_2.Text
        ElseIf BoqQuestion49_1.Checked = True Then
            objBOQ.Question49 = BoqQuestion49_1.Text
        ElseIf BoqQuestion49_0.Checked = True Then
            objBOQ.Question49 = BoqQuestion49_0.Text
        End If

        If BoqQuestion50_2.Checked = True Then
            objBOQ.Question50 = BoqQuestion50_2.Text
        ElseIf BoqQuestion50_1.Checked = True Then
            objBOQ.Question50 = BoqQuestion50_1.Text
        ElseIf BoqQuestion50_0.Checked = True Then
            objBOQ.Question50 = BoqQuestion50_0.Text
        End If

        If BoqQuestion51_3.Checked = True Then
            objBOQ.Question51 = BoqQuestion51_3.Text
        ElseIf BoqQuestion51_2.Checked = True Then
            objBOQ.Question51 = BoqQuestion51_2.Text
        ElseIf BoqQuestion51_1.Checked = True Then
            objBOQ.Question51 = BoqQuestion51_1.Text
        ElseIf BoqQuestion51_0.Checked = True Then
            objBOQ.Question51 = BoqQuestion51_0.Text
        End If


        If BoqQuestion52_3.Checked = True Then
            objBOQ.Question52 = BoqQuestion52_3.Text
        ElseIf BoqQuestion52_2.Checked = True Then
            objBOQ.Question52 = BoqQuestion52_2.Text
        ElseIf BoqQuestion52_1.Checked = True Then
            objBOQ.Question52 = BoqQuestion52_1.Text
        ElseIf BoqQuestion52_0.Checked = True Then
            objBOQ.Question52 = BoqQuestion52_0.Text
        End If

        If BoqQuestion53_3.Checked = True Then
            objBOQ.Question53 = BoqQuestion53_3.Text
        ElseIf BoqQuestion53_2.Checked = True Then
            objBOQ.Question53 = BoqQuestion53_2.Text
        ElseIf BoqQuestion53_1.Checked = True Then
            objBOQ.Question53 = BoqQuestion53_1.Text
        ElseIf BoqQuestion53_0.Checked = True Then
            objBOQ.Question53 = BoqQuestion53_0.Text
        End If




        'commented before
        'If BoqQuestion54_2.Checked = True Then
        '    objBOQ.Question54 = BoqQuestion54_2.Text
        'ElseIf BoqQuestion54_1.Checked = True Then
        '    objBOQ.Question54 = BoqQuestion54_1.Text
        'ElseIf BoqQuestion54_0.Checked = True Then
        '    objBOQ.Question54 = BoqQuestion54_0.Text
        'End If

        'If BoqQuestion55_2.Checked = True Then
        '    objBOQ.Question55 = BoqQuestion55_2.Text
        'ElseIf BoqQuestion55_1.Checked = True Then
        '    objBOQ.Question55 = BoqQuestion55_1.Text
        'ElseIf BoqQuestion55_0.Checked = True Then
        '    objBOQ.Question55 = BoqQuestion55_0.Text
        'End If

        'If BoqQuestion56_2.Checked = True Then
        '    objBOQ.Question56 = BoqQuestion56_2.Text
        'ElseIf BoqQuestion56_1.Checked = True Then
        '    objBOQ.Question56 = BoqQuestion56_1.Text
        'ElseIf BoqQuestion56_0.Checked = True Then
        '    objBOQ.Question56 = BoqQuestion56_0.Text
        'End If

        'If BoqQuestion57_2.Checked = True Then
        '    objBOQ.Question57 = BoqQuestion57_2.Text
        'ElseIf BoqQuestion57_1.Checked = True Then
        '    objBOQ.Question57 = BoqQuestion57_1.Text
        'ElseIf BoqQuestion57_0.Checked = True Then
        '    objBOQ.Question57 = BoqQuestion57_0.Text
        'End If

        'If BoqQuestion58_2.Checked = True Then
        '    objBOQ.Question58 = BoqQuestion58_2.Text
        'ElseIf BoqQuestion58_1.Checked = True Then
        '    objBOQ.Question58 = BoqQuestion58_1.Text
        'ElseIf BoqQuestion58_0.Checked = True Then
        '    objBOQ.Question58 = BoqQuestion58_0.Text
        'End If

        'If BoqQuestion60_2.Checked = True Then
        '    objBOQ.Question60 = BoqQuestion60_2.Text
        'ElseIf BoqQuestion60_1.Checked = True Then
        '    objBOQ.Question60 = BoqQuestion60_1.Text
        'ElseIf BoqQuestion60_0.Checked = True Then
        '    objBOQ.Question60 = BoqQuestion60_0.Text
        'End If


        C21MIT.PBSIS.BLL.pbsschoolboqendyrreport.addSchoolBOQ(objBOQ)
    End Sub
End Class

