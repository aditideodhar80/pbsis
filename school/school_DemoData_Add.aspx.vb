
Partial Class school_school_DemoData_Add
    Inherits System.Web.UI.Page
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        C21MIT.PBSIS.BLL.pbsloginsession.chkloginsession("School")

        Dim objdemodata As New C21MIT.PBSIS.BO.pbsdemodata

        objdemodata.SchoolID = Session("MM_Username")
        objdemodata.SchoolYear = C21MIT.PBSIS.BLL.pbslogindetails.GetCurrentPrimTracker.schoolyear
        bindata(objdemodata.SchoolID, objdemodata.SchoolYear)
    End Sub

    Sub bindata(ByVal schoolID As String, ByVal schoolYr As String)
        lblSchoolName.Text = C21MIT.PBSIS.BLL.pbsschoolprofile.getschoolprofile(schoolID).SchoolName
        lblSchoolYr.Text = C21MIT.PBSIS.BLL.pbsschoolyeardesc.getschoolyeardesc(schoolYr)
    End Sub

    Protected Sub btnsubmit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSubmit.Click
        addschooldemodata()
        Response.Redirect("~/users/smessages.aspx?qModule=DataSaved", False)
    End Sub

    'Modified by Aditi on Feb 25
    Sub addschooldemodata()
        Dim objdemodata As New C21MIT.PBSIS.BO.pbsdemodata

        objdemodata.SchoolID = Session("MM_Username")
        objdemodata.SchoolYear = C21MIT.PBSIS.BLL.pbslogindetails.GetCurrentPrimTracker.schoolyear
        objdemodata.DemoTchAmericanIndian = Integer.Parse(C21MIT.Util.DBNullHandler.BlankToDBSingle(txtDemoTchAmericanIndian.Text))
        objdemodata.DemoTchAsian = Integer.Parse(C21MIT.Util.DBNullHandler.BlankToDBSingle(txtDemoTchAsian.Text))
        objdemodata.DemoTchBlack = Integer.Parse(C21MIT.Util.DBNullHandler.BlankToDBSingle(txtDemoTchBlack.Text))
        objdemodata.DemoTchHispanic = Integer.Parse(C21MIT.Util.DBNullHandler.BlankToDBSingle(txtDemoTchHispanic.Text))
        objdemodata.DemoTchMulticultural = Integer.Parse(C21MIT.Util.DBNullHandler.BlankToDBSingle(txtDemoTchMulticultural.Text))
        objdemodata.DemoTchWhite = Integer.Parse(C21MIT.Util.DBNullHandler.BlankToDBSingle(txtDemoTchWhite.Text))
        objdemodata.DemoTchOther = Integer.Parse(C21MIT.Util.DBNullHandler.BlankToDBSingle(txtDemoTchOther.Text))
        objdemodata.DemoTchTotalEnrollment = Integer.Parse(C21MIT.Util.DBNullHandler.BlankToDBSingle(txtDemoTchTotalEnrollment.Text))

        objdemodata.DemoTchStudentsWithIEP = Integer.Parse(C21MIT.Util.DBNullHandler.BlankToDBSingle(txtDemoTchStudentsWithIEP.Text))
        objdemodata.DemoTchPercFreeRedcLunch = Integer.Parse(C21MIT.Util.DBNullHandler.BlankToDBSingle(txtDemoTchPercFreeRedcLunch.Text))

        If chkDemoTchTitleOne.Checked Then
            objdemodata.DemoTchTitleOne = 1
        Else
            objdemodata.DemoTchTitleOne = 0
        End If

        If chkDemoTchReadingFirst.Checked Then
            objdemodata.DemoTchReadingFirst = 1
        Else
            objdemodata.DemoTchReadingFirst = 0
        End If

        If chkDemoTchProblemSolvModel.Checked Then
            objdemodata.DemoTchProblemSolvModel = 1
        Else
            objdemodata.DemoTchProblemSolvModel = 0
        End If

        objdemodata.DemoTchOtherInitiatives = DemoTchOtherInitiatives.Text

        If DemoTchTargBehIntvyes.Checked Then
            objdemodata.DemoTchTargBehIntv = 1
        ElseIf DemoTchTargBehIntvno.Checked Then
            objdemodata.DemoTchTargBehIntv = 0
        End If

        If DemoTchIndLvlPbsyes.Checked Then
            objdemodata.DemoTchIndLvlPbs = 1
        ElseIf DemoTchIndLvlPbsno.Checked Then
            objdemodata.DemoTchIndLvlPbs = 0
        End If

        If chkDemoTchIntvBEP.Checked Then
            objdemodata.DemoTchIntvBEP = 1
        Else
            objdemodata.DemoTchIntvBEP = 0
        End If

        If chkDemoTchIntvICPS.Checked Then
            objdemodata.DemoTchIntvSTR = 1
        Else
            objdemodata.DemoTchIntvSTR = 0
        End If

        If chkDemoTchIntvSklStr.Checked Then
            objdemodata.DemoTchIntvSklStr = 1
        Else
            objdemodata.DemoTchIntvSklStr = 0
        End If

        If chkDemoTchIntvPrep.Checked Then
            objdemodata.DemoTchIntvPrep = 1
        Else
            objdemodata.DemoTchIntvPrep = 0
        End If

        If chkDemoTchIntvSTR.Checked Then
            objdemodata.DemoTchIntvSTR = 1
        Else
            objdemodata.DemoTchIntvSTR = 0
        End If

        If chkDemoTchIntvSecStp.Checked Then
            objdemodata.DemoTchIntvSecStp = 1
        Else
            objdemodata.DemoTchIntvSecStp = 0
        End If

        If chkDemoTchIntvSC.Checked Then
            objdemodata.DemoTchIntvSC = 1
        Else
            objdemodata.DemoTchIntvSC = 0
        End If

        If chkDemoTchIntvOth.Checked Then
            objdemodata.DemoTchIntvOth = 1
        Else
            objdemodata.DemoTchIntvOth = 0
        End If

        If chkDemoTchPbsERASE.Checked Then
            objdemodata.DemoTchPbsERASE = 1
        Else
            objdemodata.DemoTchPbsERASE = 0
        End If

        If chkDemoTchPbsPTR.Checked Then
            objdemodata.DemoTchPbsPTR = 1
        Else
            objdemodata.DemoTchPbsPTR = 0
        End If

        If chkDemoTchPbsOth.Checked Then
            objdemodata.DemoTchPbsOth = 1
        Else
            objdemodata.DemoTchPbsOth = 0
        End If


        objdemodata.DemoTchPbsOthDesc = txtDemoTchPbsOthDesc.Text

        objdemodata.DemoTchAcademicSystems = txtDemoTchAcademicSystems.Text
        objdemodata.DemoTchBehaviorSystems = txtDemoTchBehaviorSystems.Text

        objdemodata.DemoTchTotalInstStaff = Integer.Parse(C21MIT.Util.DBNullHandler.BlankToDBSingle(txtDemoTchTotalInstStaff.Text))
        objdemodata.DemoTchPercInstStaff = Integer.Parse(C21MIT.Util.DBNullHandler.BlankToDBSingle(txtDemoTchPercInstStaff.Text))
        objdemodata.DemoTchPercAdvDegree = Integer.Parse(C21MIT.Util.DBNullHandler.BlankToDBSingle(txtDemoTchPercAdvDegree.Text))
        objdemodata.DemoTchPercOOFTeacher = Integer.Parse(C21MIT.Util.DBNullHandler.BlankToDBSingle(txtDemoTchPercOOFTeacher.Text))

        C21MIT.PBSIS.BLL.pbsdemodata.addSchooldemodata(objdemodata)


    End Sub

End Class
