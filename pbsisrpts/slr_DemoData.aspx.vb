'-------------------------------------------------------------------------------------------------------------------
' Page Name : slr_DemoData.aspx  
' Created By : Aditi Deodhar
' Created Dt : Feb 25,2010
' Last Updated Dt : Feb 25,2010
'-------------------------------------------------------------------------------------------------------------------
Partial Class pbsisrpts_slr_DemoData
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            C21MIT.PBSIS.BLL.pbsloginsession.chkloginsession("schrpt")

            Dim objDemoData As New C21MIT.PBSIS.BO.pbsdemodata

            If Not CStr(C21MIT.PBSIS.BLL.pbslogindetails.GetCurrentPrimTracker.v_actid) Is Nothing Then
                If Not CStr(Session("sRptSchID")) Is Nothing Then
                    objDemoData.SchoolID = CStr(Session("sRptSchID"))
                ElseIf Not Request.QueryString("sRptSchID") Is Nothing Then
                    objDemoData.SchoolID = C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("sRptSchID"))
                Else
                    objDemoData.SchoolID = C21MIT.PBSIS.BLL.pbslogindetails.GetCurrentPrimTracker.v_actid
                End If
            End If

            If Not Session("SchYrId") Is Nothing Then
                objDemoData.SchoolYear = Session("SchYrId")
            Else
                If Not CStr(C21MIT.PBSIS.BLL.pbslogindetails.GetCurrentPrimTracker.schoolyear) Is Nothing Then
                    objDemoData.SchoolYear = C21MIT.PBSIS.BLL.pbslogindetails.GetCurrentPrimTracker.schoolyear
                End If
            End If

            'Get all the PIC details and bind them to the form.
            binddata(objDemoData.SchoolID, objDemoData.SchoolYear)
            bindropdown(objDemoData.SchoolYear)
        End If
    End Sub

    Sub bindropdown(ByVal schyr As String)
        ddlYear.DataSource = C21MIT.PBSIS.BLL.pbsfmhiformactivation.getfmhiformactivationyrlist()
        ddlYear.DataValueField = C21MIT.PBSIS.BLL.pbsfmhiformactivation.getfmhiformactivationyrlist().Tables(0).Columns(0).ToString
        ddlYear.DataTextField = C21MIT.PBSIS.BLL.pbsfmhiformactivation.getfmhiformactivationyrlist().Tables(0).Columns(1).ToString
        ddlYear.DataBind()

        If Not CStr(C21MIT.PBSIS.BLL.pbslogindetails.GetCurrentPrimTracker.schoolyear) Is Nothing Then
            ddlYear.SelectedValue = schyr
        End If

        ddlYear.SelectedValue = schyr
    End Sub

    Sub binddata(ByVal schoolID As String, ByVal schoolyR As Integer)
        lblSchoolName.Text = C21MIT.PBSIS.BLL.pbsdemodata.fngetdemodataEndYearSchool(schoolID, schoolyR).SchoolName
        lblDisName.Text = C21MIT.PBSIS.BLL.pbsdemodata.fngetdemodataEndYearSchool(schoolID, schoolyR).DistrictName
      
        lblAmIndian.Text = C21MIT.PBSIS.BLL.pbsdemodata.fngetdemodataEndYearSchool(schoolID, schoolyR).DemoTchAmericanIndian
        lblAsian.Text = C21MIT.PBSIS.BLL.pbsdemodata.fngetdemodataEndYearSchool(schoolID, schoolyR).DemoTchAsian
        lblBlack.Text = C21MIT.PBSIS.BLL.pbsdemodata.fngetdemodataEndYearSchool(schoolID, schoolyR).DemoTchBlack
        lblHisp.Text = C21MIT.PBSIS.BLL.pbsdemodata.fngetdemodataEndYearSchool(schoolID, schoolyR).DemoTchHispanic
        lblMultiracial.Text = C21MIT.PBSIS.BLL.pbsdemodata.fngetdemodataEndYearSchool(schoolID, schoolyR).DemoTchMulticultural
        lblWhite.Text = C21MIT.PBSIS.BLL.pbsdemodata.fngetdemodataEndYearSchool(schoolID, schoolyR).DemoTchWhite
        lblOther.Text = C21MIT.PBSIS.BLL.pbsdemodata.fngetdemodataEndYearSchool(schoolID, schoolyR).DemoTchOther
        lblTotEnroll.Text = C21MIT.PBSIS.BLL.pbsdemodata.fngetdemodataEndYearSchool(schoolID, schoolyR).DemoTchTotalEnrollment

        lblNumwIEP.Text = C21MIT.PBSIS.BLL.pbsdemodata.fngetdemodataEndYearSchool(schoolID, schoolyR).DemoTchStudentsWithIEP
        lblPerFreeLunch.Text = C21MIT.PBSIS.BLL.pbsdemodata.fngetdemodataEndYearSchool(schoolID, schoolyR).DemoTchPercFreeRedcLunch

        chkTitleOne.Enabled = False
        If C21MIT.PBSIS.BLL.pbsdemodata.fngetdemodataEndYearSchool(schoolID, schoolyR).DemoTchTitleOne = 1 Then
            chkTitleOne.Checked = True
        ElseIf C21MIT.PBSIS.BLL.pbsdemodata.fngetdemodataEndYearSchool(schoolID, schoolyR).DemoTchTitleOne = 0 Then
            chkTitleOne.Checked = False
        End If

        chkReadingFirst.Enabled = False
        If C21MIT.PBSIS.BLL.pbsdemodata.fngetdemodataEndYearSchool(schoolID, schoolyR).DemoTchReadingFirst = 1 Then
            chkReadingFirst.Checked = True
        ElseIf C21MIT.PBSIS.BLL.pbsdemodata.fngetdemodataEndYearSchool(schoolID, schoolyR).DemoTchReadingFirst = 0 Then
            chkReadingFirst.Checked = False
        End If

        chkPSModel.Enabled = False
        If C21MIT.PBSIS.BLL.pbsdemodata.fngetdemodataEndYearSchool(schoolID, schoolyR).DemoTchProblemSolvModel = 1 Then
            chkPSModel.Checked = True
        ElseIf C21MIT.PBSIS.BLL.pbsdemodata.fngetdemodataEndYearSchool(schoolID, schoolyR).DemoTchProblemSolvModel = 0 Then
            chkPSModel.Checked = False
        End If

        chkBEP.Enabled = False
        If C21MIT.PBSIS.BLL.pbsdemodata.fngetdemodataEndYearSchool(schoolID, schoolyR).DemoTchIntvBEP = 1 Then
            chkBEP.Checked = True
        ElseIf C21MIT.PBSIS.BLL.pbsdemodata.fngetdemodataEndYearSchool(schoolID, schoolyR).DemoTchIntvBEP = 0 Then
            chkBEP.Checked = False
        End If

        chkIcanSProb.Enabled = False
        If C21MIT.PBSIS.BLL.pbsdemodata.fngetdemodataEndYearSchool(schoolID, schoolyR).DemoTchIntvICPS = 1 Then
            chkIcanSProb.Checked = True
        ElseIf C21MIT.PBSIS.BLL.pbsdemodata.fngetdemodataEndYearSchool(schoolID, schoolyR).DemoTchIntvICPS = 0 Then
            chkIcanSProb.Checked = False
        End If

        chkSkillStreaming.Enabled = False
        If C21MIT.PBSIS.BLL.pbsdemodata.fngetdemodataEndYearSchool(schoolID, schoolyR).DemoTchIntvSklStr = 1 Then
            chkSkillStreaming.Checked = True
        ElseIf C21MIT.PBSIS.BLL.pbsdemodata.fngetdemodataEndYearSchool(schoolID, schoolyR).DemoTchIntvSklStr = 0 Then
            chkSkillStreaming.Checked = False
        End If

        chkPrepare.Enabled = False
        If C21MIT.PBSIS.BLL.pbsdemodata.fngetdemodataEndYearSchool(schoolID, schoolyR).DemoTchIntvPrep = 1 Then
            chkPrepare.Checked = True
        ElseIf C21MIT.PBSIS.BLL.pbsdemodata.fngetdemodataEndYearSchool(schoolID, schoolyR).DemoTchIntvPrep = 0 Then
            chkPrepare.Checked = False
        End If

        chklStepstoRes.Enabled = False
        If C21MIT.PBSIS.BLL.pbsdemodata.fngetdemodataEndYearSchool(schoolID, schoolyR).DemoTchIntvSTR = 1 Then
            chklStepstoRes.Checked = True
        ElseIf C21MIT.PBSIS.BLL.pbsdemodata.fngetdemodataEndYearSchool(schoolID, schoolyR).DemoTchIntvSTR = 0 Then
            chklStepstoRes.Checked = False
        End If

        chkSecondStep.Enabled = False
        If C21MIT.PBSIS.BLL.pbsdemodata.fngetdemodataEndYearSchool(schoolID, schoolyR).DemoTchIntvSecStp = 1 Then
            chkSecondStep.Checked = True
        ElseIf C21MIT.PBSIS.BLL.pbsdemodata.fngetdemodataEndYearSchool(schoolID, schoolyR).DemoTchIntvSecStp = 0 Then
            chkSecondStep.Checked = False
        End If

        chkSchConnect.Enabled = False
        If C21MIT.PBSIS.BLL.pbsdemodata.fngetdemodataEndYearSchool(schoolID, schoolyR).DemoTchIntvSC = 1 Then
            chkSchConnect.Checked = True
        ElseIf C21MIT.PBSIS.BLL.pbsdemodata.fngetdemodataEndYearSchool(schoolID, schoolyR).DemoTchIntvSC = 0 Then
            chkSchConnect.Checked = False
        End If

        chkErase.Enabled = False
        If C21MIT.PBSIS.BLL.pbsdemodata.fngetdemodataEndYearSchool(schoolID, schoolyR).DemoTchPbsERASE = 1 Then
            chkErase.Checked = True
        ElseIf C21MIT.PBSIS.BLL.pbsdemodata.fngetdemodataEndYearSchool(schoolID, schoolyR).DemoTchPbsERASE = 0 Then
            chkErase.Checked = False
        End If

        chkPTR.Enabled = False
        If C21MIT.PBSIS.BLL.pbsdemodata.fngetdemodataEndYearSchool(schoolID, schoolyR).DemoTchPbsPTR = 1 Then
            chkPTR.Checked = True
        ElseIf C21MIT.PBSIS.BLL.pbsdemodata.fngetdemodataEndYearSchool(schoolID, schoolyR).DemoTchPbsPTR = 0 Then
            chkPTR.Checked = False
        End If

        lblAcDataSys.Text = C21MIT.PBSIS.BLL.pbsdemodata.fngetdemodataEndYearSchool(schoolID, schoolyR).DemoTchAcademicSystems
        lblBehaDatasys.Text = C21MIT.PBSIS.BLL.pbsdemodata.fngetdemodataEndYearSchool(schoolID, schoolyR).DemoTchBehaviorSystems
        lblTotInsStaff.Text = C21MIT.PBSIS.BLL.pbsdemodata.fngetdemodataEndYearSchool(schoolID, schoolyR).DemoTchTotalInstStaff
        lblPerStaffInst.Text = C21MIT.PBSIS.BLL.pbsdemodata.fngetdemodataEndYearSchool(schoolID, schoolyR).DemoTchTotalInstStaff
        lblPerTeacherAdvDeg.Text = C21MIT.PBSIS.BLL.pbsdemodata.fngetdemodataEndYearSchool(schoolID, schoolyR).DemoTchPercAdvDegree
        lblOOFTeachers.Text = C21MIT.PBSIS.BLL.pbsdemodata.fngetdemodataEndYearSchool(schoolID, schoolyR).DemoTchPercOOFTeacher
    End Sub

    Protected Sub Page_LoadComplete(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.LoadComplete
        Session("sRptSchID") = Nothing
        Session("SchYrId") = Nothing
    End Sub

    Protected Sub ddlYear_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddlYear.SelectedIndexChanged
        Dim objDemoData As New C21MIT.PBSIS.BO.pbsdemodata
        If Not CStr(C21MIT.PBSIS.BLL.pbslogindetails.GetCurrentPrimTracker.v_actid) Is Nothing Then
            If Not CStr(Session("sRptSchID")) Is Nothing Then
                objDemoData.SchoolID = CStr(Session("sRptSchID"))
            ElseIf Not Request.QueryString("sRptSchID") Is Nothing Then
                objDemoData.SchoolID = C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("sRptSchID"))
            Else
                objDemoData.SchoolID = C21MIT.PBSIS.BLL.pbslogindetails.GetCurrentPrimTracker.v_actid
            End If
        End If
        binddata(objDemoData.SchoolID, ddlYear.SelectedItem.Value)
    End Sub
End Class
