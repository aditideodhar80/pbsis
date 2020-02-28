'-------------------------------------------------------------------------------------------------------------------
' Created By : Aditi Deodhar
' Created Dt : Feb 10,2010
' Last Updated Dt : Feb 10,2010
'-------------------------------------------------------------------------------------------------------------------
Partial Class school_school_PIC_Add
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            C21MIT.PBSIS.BLL.pbsloginsession.chkloginsession("School")

            Dim objPIC As New C21MIT.PBSIS.BO.pbsschoolreport

            objPIC.SchoolID = Session("MM_Username")
            objPIC.SchoolYear = C21MIT.PBSIS.BLL.pbslogindetails.GetCurrentPrimTracker.schoolyear
            objPIC.Interval = Request.QueryString("PICTerm")

            bindata(objPIC.SchoolID, objPIC.SchoolYear, objPIC.Interval)
            binddropdown(objPIC.SchoolID)
        End If
    End Sub

    Sub bindata(ByVal schoolID As String, ByVal schoolYr As String, ByVal schoolInterval As String)
        lblschoolname.Text = C21MIT.PBSIS.BLL.pbsschoolprofile.getschoolprofile(schoolID).SchoolName
        lblschoolyr.Text = C21MIT.PBSIS.BLL.pbsschoolyeardesc.getschoolyeardesc(schoolYr)
 
        If C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("PICTerm")) = 1 Then
            lblTermCaption.Text = "FALL"
        ElseIf C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("PICTerm")) = 2 Then
            lblTermCaption.Text = "SPRING"
        End If
    End Sub

    Sub binddropdown(ByVal schoolID As String)
        ddlcoach.DataSource = C21MIT.PBSIS.BLL.pbsschoolpicboq.getSchoolPICBOQCoaches(schoolID)
        ddlcoach.DataValueField = C21MIT.PBSIS.BLL.pbsschoolpicboq.getSchoolPICBOQCoaches(schoolID).Tables(0).Columns(0).ToString
        ddlcoach.DataTextField = C21MIT.PBSIS.BLL.pbsschoolpicboq.getSchoolPICBOQCoaches(schoolID).Tables(0).Columns(1).ToString
        ddlcoach.DataBind()

        ddlcoach.Items.Insert(0, "Select One")
        ddlcoach.Items.Insert(1, "Name not in list")
    End Sub

    Protected Sub btnSubmit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSubmit.Click
        addschoolPIC()
        Response.Redirect("~/users/smessages.aspx?qModule=DataSaved", False)
    End Sub

    Sub addschoolPIC()
        Dim objPIC As New C21MIT.PBSIS.BO.pbsschoolreport

        objPIC.SchoolID = Session("MM_Username")
        objPIC.SchoolYear = C21MIT.PBSIS.BLL.pbslogindetails.GetCurrentPrimTracker.schoolyear
        objPIC.Interval = C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("PICTerm"))

        If ddlcoach.selectedindex = "0" Then
            objPIC.CoachID = 0
        ElseIf ddlcoach.selectedindex = "1" Then
            objPIC.CoachID = 1 '=9999?
        Else
            objPIC.CoachID = ddlcoach.SelectedItem.Value
        End If

        If rdPicQuestion1_2.Checked Then
            objPIC.Question1 = rdPicQuestion1_2.Text
        ElseIf rdPicQuestion1_1.Checked Then
            objPIC.Question1 = rdPicQuestion1_1.Text
        ElseIf rdPicQuestion1_0.Checked Then
            objPIC.Question1 = rdPicQuestion1_0.Text
        End If


        If rdPicQuestion2_2.Checked Then
            objPIC.Question2 = rdPicQuestion2_2.Text
        ElseIf rdPicQuestion2_1.Checked Then
            objPIC.Question2 = rdPicQuestion2_1.Text
        ElseIf rdPicQuestion2_0.Checked Then
            objPIC.Question2 = rdPicQuestion2_0.Text
        End If

        If rdPicQuestion3_2.Checked Then
            objPIC.Question3 = rdPicQuestion3_2.Text
        ElseIf rdPicQuestion3_1.Checked Then
            objPIC.Question3 = rdPicQuestion3_1.Text
        ElseIf rdPicQuestion3_0.Checked Then
            objPIC.Question3 = rdPicQuestion3_0.Text
        End If

        If rdPicQuestion4_2.Checked Then
            objPIC.Question4 = rdPicQuestion4_2.Text
        ElseIf rdPicQuestion4_1.Checked Then
            objPIC.Question4 = rdPicQuestion4_1.Text
        ElseIf rdPicQuestion4_0.Checked Then
            objPIC.Question4 = rdPicQuestion4_0.Text
        End If

        If rdPicQuestion5_2.Checked Then
            objPIC.Question5 = rdPicQuestion5_2.Text
        ElseIf rdPicQuestion5_1.Checked Then
            objPIC.Question5 = rdPicQuestion5_1.Text
        ElseIf rdPicQuestion5_0.Checked Then
            objPIC.Question5 = rdPicQuestion5_0.Text
        End If

        If rdPicQuestion6_2.Checked Then
            objPIC.Question6 = rdPicQuestion6_2.Text
        ElseIf rdPicQuestion6_1.Checked Then
            objPIC.Question6 = rdPicQuestion6_1.Text
        ElseIf rdPicQuestion6_0.Checked Then
            objPIC.Question6 = rdPicQuestion6_0.Text
        End If

        If rdPicQuestion7_2.Checked Then
            objPIC.Question7 = rdPicQuestion7_2.Text
        ElseIf rdPicQuestion7_1.Checked Then
            objPIC.Question7 = rdPicQuestion7_1.Text
        ElseIf rdPicQuestion7_0.Checked Then
            objPIC.Question7 = rdPicQuestion7_0.Text
        End If

        If rdPicQuestion8_2.Checked Then
            objPIC.Question8 = rdPicQuestion8_2.Text
        ElseIf rdPicQuestion8_1.Checked Then
            objPIC.Question8 = rdPicQuestion8_1.Text
        ElseIf rdPicQuestion8_0.Checked Then
            objPIC.Question8 = rdPicQuestion8_0.Text
        End If

        If rdPicQuestion9_2.Checked Then
            objPIC.Question9 = rdPicQuestion9_2.Text
        ElseIf rdPicQuestion9_1.Checked Then
            objPIC.Question9 = rdPicQuestion9_1.Text
        ElseIf rdPicQuestion9_0.Checked Then
            objPIC.Question9 = rdPicQuestion9_0.Text
        End If

        If rdPicQuestion10_2.Checked Then
            objPIC.Question10 = rdPicQuestion10_2.Text
        ElseIf rdPicQuestion10_1.Checked Then
            objPIC.Question10 = rdPicQuestion10_1.Text
        ElseIf rdPicQuestion10_0.Checked Then
            objPIC.Question10 = rdPicQuestion10_0.Text
        End If

        ''

        If rdPicQuestion11_2.Checked Then
            objPIC.Question11 = rdPicQuestion11_2.Text
        ElseIf rdPicQuestion11_1.Checked Then
            objPIC.Question11 = rdPicQuestion11_1.Text
        ElseIf rdPicQuestion11_0.Checked Then
            objPIC.Question11 = rdPicQuestion11_0.Text
        End If


        If rdPicQuestion12_2.Checked Then
            objPIC.Question12 = rdPicQuestion12_2.Text
        ElseIf rdPicQuestion12_1.Checked Then
            objPIC.Question12 = rdPicQuestion12_1.Text
        ElseIf rdPicQuestion12_0.Checked Then
            objPIC.Question12 = rdPicQuestion12_0.Text
        End If

        If rdPicQuestion13_2.Checked Then
            objPIC.Question13 = rdPicQuestion13_2.Text
        ElseIf rdPicQuestion13_1.Checked Then
            objPIC.Question13 = rdPicQuestion13_1.Text
        ElseIf rdPicQuestion13_0.Checked Then
            objPIC.Question13 = rdPicQuestion13_0.Text
        End If

        If rdPicQuestion14_2.Checked Then
            objPIC.Question14 = rdPicQuestion14_2.Text
        ElseIf rdPicQuestion14_1.Checked Then
            objPIC.Question14 = rdPicQuestion14_1.Text
        ElseIf rdPicQuestion14_0.Checked Then
            objPIC.Question14 = rdPicQuestion14_0.Text
        End If

        If rdPicQuestion15_2.Checked Then
            objPIC.Question15 = rdPicQuestion15_2.Text
        ElseIf rdPicQuestion15_1.Checked Then
            objPIC.Question15 = rdPicQuestion15_1.Text
        ElseIf rdPicQuestion15_0.Checked Then
            objPIC.Question15 = rdPicQuestion15_0.Text
        End If

        If rdPicQuestion16_2.Checked Then
            objPIC.Question16 = rdPicQuestion16_2.Text
        ElseIf rdPicQuestion16_1.Checked Then
            objPIC.Question16 = rdPicQuestion16_1.Text
        ElseIf rdPicQuestion16_0.Checked Then
            objPIC.Question16 = rdPicQuestion16_0.Text
        End If

        If rdPicQuestion17_2.Checked Then
            objPIC.Question17 = rdPicQuestion17_2.Text
        ElseIf rdPicQuestion17_1.Checked Then
            objPIC.Question17 = rdPicQuestion17_1.Text
        ElseIf rdPicQuestion17_0.Checked Then
            objPIC.Question17 = rdPicQuestion17_0.Text
        End If

        If rdPicQuestion18_2.Checked Then
            objPIC.Question18 = rdPicQuestion18_2.Text
        ElseIf rdPicQuestion18_1.Checked Then
            objPIC.Question18 = rdPicQuestion18_1.Text
        ElseIf rdPicQuestion18_0.Checked Then
            objPIC.Question18 = rdPicQuestion18_0.Text
        End If

        If rdPicQuestion19_2.Checked Then
            objPIC.Question19 = rdPicQuestion19_2.Text
        ElseIf rdPicQuestion19_1.Checked Then
            objPIC.Question19 = rdPicQuestion19_1.Text
        ElseIf rdPicQuestion19_0.Checked Then
            objPIC.Question19 = rdPicQuestion19_0.Text
        End If

        If rdPicQuestion20_2.Checked Then
            objPIC.Question20 = rdPicQuestion20_2.Text
        ElseIf rdPicQuestion20_1.Checked Then
            objPIC.Question20 = rdPicQuestion20_1.Text
        ElseIf rdPicQuestion20_0.Checked Then
            objPIC.Question20 = rdPicQuestion20_0.Text
        End If

        ''

        If rdPicQuestion21_2.Checked Then
            objPIC.Question21 = rdPicQuestion21_2.Text
        ElseIf rdPicQuestion21_1.Checked Then
            objPIC.Question21 = rdPicQuestion21_1.Text
        ElseIf rdPicQuestion21_0.Checked Then
            objPIC.Question21 = rdPicQuestion21_0.Text
        End If


        If rdPicQuestion22_2.Checked Then
            objPIC.Question22 = rdPicQuestion22_2.Text
        ElseIf rdPicQuestion22_1.Checked Then
            objPIC.Question22 = rdPicQuestion22_1.Text
        ElseIf rdPicQuestion22_0.Checked Then
            objPIC.Question22 = rdPicQuestion22_0.Text
        End If

        If rdPicQuestion23_2.Checked Then
            objPIC.Question23 = rdPicQuestion23_2.Text
        ElseIf rdPicQuestion23_1.Checked Then
            objPIC.Question23 = rdPicQuestion23_1.Text
        ElseIf rdPicQuestion23_0.Checked Then
            objPIC.Question23 = rdPicQuestion23_0.Text
        End If

        If rdPicQuestion24_2.Checked Then
            objPIC.Question24 = rdPicQuestion24_2.Text
        ElseIf rdPicQuestion24_1.Checked Then
            objPIC.Question24 = rdPicQuestion24_1.Text
        ElseIf rdPicQuestion24_0.Checked Then
            objPIC.Question24 = rdPicQuestion24_0.Text
        End If

        If rdPicQuestion25_2.Checked Then
            objPIC.Question25 = rdPicQuestion25_2.Text
        ElseIf rdPicQuestion25_1.Checked Then
            objPIC.Question25 = rdPicQuestion25_1.Text
        ElseIf rdPicQuestion25_0.Checked Then
            objPIC.Question25 = rdPicQuestion25_0.Text
        End If

        If rdPicQuestion26_2.Checked Then
            objPIC.Question26 = rdPicQuestion26_2.Text
        ElseIf rdPicQuestion26_1.Checked Then
            objPIC.Question26 = rdPicQuestion26_1.Text
        ElseIf rdPicQuestion26_0.Checked Then
            objPIC.Question26 = rdPicQuestion26_0.Text
        End If

        If rdPicQuestion27_2.Checked Then
            objPIC.Question27 = rdPicQuestion27_2.Text
        ElseIf rdPicQuestion27_1.Checked Then
            objPIC.Question27 = rdPicQuestion27_1.Text
        ElseIf rdPicQuestion27_0.Checked Then
            objPIC.Question27 = rdPicQuestion27_0.Text
        End If

        If rdPicQuestion28_2.Checked Then
            objPIC.Question28 = rdPicQuestion28_2.Text
        ElseIf rdPicQuestion28_1.Checked Then
            objPIC.Question28 = rdPicQuestion28_1.Text
        ElseIf rdPicQuestion28_0.Checked Then
            objPIC.Question28 = rdPicQuestion28_0.Text
        End If

        If rdPicQuestion29_2.Checked Then
            objPIC.Question29 = rdPicQuestion29_2.Text
        ElseIf rdPicQuestion29_1.Checked Then
            objPIC.Question29 = rdPicQuestion29_1.Text
        ElseIf rdPicQuestion29_0.Checked Then
            objPIC.Question29 = rdPicQuestion29_0.Text
        End If

        If rdPicQuestion30_2.Checked Then
            objPIC.Question30 = rdPicQuestion30_2.Text
        ElseIf rdPicQuestion30_1.Checked Then
            objPIC.Question30 = rdPicQuestion30_1.Text
        ElseIf rdPicQuestion30_0.Checked Then
            objPIC.Question30 = rdPicQuestion30_0.Text
        End If

        ''


        If rdPicQuestion31_2.Checked Then
            objPIC.Question31 = rdPicQuestion31_2.Text
        ElseIf rdPicQuestion31_1.Checked Then
            objPIC.Question31 = rdPicQuestion31_1.Text
        ElseIf rdPicQuestion31_0.Checked Then
            objPIC.Question31 = rdPicQuestion31_0.Text
        End If


        If rdPicQuestion32_2.Checked Then
            objPIC.Question32 = rdPicQuestion32_2.Text
        ElseIf rdPicQuestion32_1.Checked Then
            objPIC.Question32 = rdPicQuestion32_1.Text
        ElseIf rdPicQuestion32_0.Checked Then
            objPIC.Question32 = rdPicQuestion32_0.Text
        End If

        If rdPicQuestion3_2.Checked Then
            objPIC.Question3 = rdPicQuestion3_2.Text
        ElseIf rdPicQuestion3_1.Checked Then
            objPIC.Question3 = rdPicQuestion3_1.Text
        ElseIf rdPicQuestion3_0.Checked Then
            objPIC.Question3 = rdPicQuestion3_0.Text
        End If

        If rdPicQuestion34_2.Checked Then
            objPIC.Question34 = rdPicQuestion34_2.Text
        ElseIf rdPicQuestion34_1.Checked Then
            objPIC.Question34 = rdPicQuestion34_1.Text
        ElseIf rdPicQuestion34_0.Checked Then
            objPIC.Question34 = rdPicQuestion34_0.Text
        End If

        If rdPicQuestion35_2.Checked Then
            objPIC.Question35 = rdPicQuestion35_2.Text
        ElseIf rdPicQuestion35_1.Checked Then
            objPIC.Question35 = rdPicQuestion35_1.Text
        ElseIf rdPicQuestion35_0.Checked Then
            objPIC.Question35 = rdPicQuestion35_0.Text
        End If

        If rdPicQuestion36_2.Checked Then
            objPIC.Question36 = rdPicQuestion36_2.Text
        ElseIf rdPicQuestion36_1.Checked Then
            objPIC.Question36 = rdPicQuestion36_1.Text
        ElseIf rdPicQuestion36_0.Checked Then
            objPIC.Question36 = rdPicQuestion36_0.Text
        End If

        If rdPicQuestion37_2.Checked Then
            objPIC.Question37 = rdPicQuestion37_2.Text
        ElseIf rdPicQuestion37_1.Checked Then
            objPIC.Question37 = rdPicQuestion37_1.Text
        ElseIf rdPicQuestion37_0.Checked Then
            objPIC.Question37 = rdPicQuestion37_0.Text
        End If

        If rdPicQuestion38_2.Checked Then
            objPIC.Question38 = rdPicQuestion38_2.Text
        ElseIf rdPicQuestion38_1.Checked Then
            objPIC.Question38 = rdPicQuestion38_1.Text
        ElseIf rdPicQuestion38_0.Checked Then
            objPIC.Question38 = rdPicQuestion38_0.Text
        End If

        If rdPicQuestion39_2.Checked Then
            objPIC.Question39 = rdPicQuestion39_2.Text
        ElseIf rdPicQuestion39_1.Checked Then
            objPIC.Question39 = rdPicQuestion39_1.Text
        ElseIf rdPicQuestion39_0.Checked Then
            objPIC.Question39 = rdPicQuestion39_0.Text
        End If

        If rdPicQuestion40_2.Checked Then
            objPIC.Question40 = rdPicQuestion40_2.Text
        ElseIf rdPicQuestion40_1.Checked Then
            objPIC.Question40 = rdPicQuestion40_1.Text
        ElseIf rdPicQuestion40_0.Checked Then
            objPIC.Question40 = rdPicQuestion40_0.Text
        End If

        If rdPicQuestion41_2.Checked Then
            objPIC.Question41 = rdPicQuestion41_2.Text
        ElseIf rdPicQuestion41_1.Checked Then
            objPIC.Question41 = rdPicQuestion41_1.Text
        ElseIf rdPicQuestion41_0.Checked Then
            objPIC.Question41 = rdPicQuestion41_0.Text
        End If

        If rdPicQuestion42_2.Checked Then
            objPIC.Question42 = rdPicQuestion42_2.Text
        ElseIf rdPicQuestion42_1.Checked Then
            objPIC.Question42 = rdPicQuestion42_1.Text
        ElseIf rdPicQuestion42_0.Checked Then
            objPIC.Question42 = rdPicQuestion42_0.Text
        End If

        If rdPicQuestion43_2.Checked Then
            objPIC.Question43 = rdPicQuestion43_2.Text
        ElseIf rdPicQuestion43_1.Checked Then
            objPIC.Question43 = rdPicQuestion43_1.Text
        ElseIf rdPicQuestion43_0.Checked Then
            objPIC.Question43 = rdPicQuestion43_0.Text
        End If

        If rdPicQuestion44_2.Checked Then
            objPIC.Question44 = rdPicQuestion44_2.Text
        ElseIf rdPicQuestion44_1.Checked Then
            objPIC.Question44 = rdPicQuestion44_1.Text
        ElseIf rdPicQuestion44_0.Checked Then
            objPIC.Question44 = rdPicQuestion44_0.Text
        End If

        C21MIT.PBSIS.BLL.pbsschoolpicmidyrreport.addSchoolPIC(objPIC)
    End Sub
End Class
