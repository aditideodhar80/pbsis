
Partial Class school_school_baseline_Add
    Inherits System.Web.UI.Page
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        C21MIT.PBSIS.BLL.pbsloginsession.chkloginsession("School")

        Dim objdemodata As New C21MIT.PBSIS.BO.pbsdemodata
        Dim objODS As New C21MIT.PBSIS.BO.pbsods

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
        addschoolODS()
        Response.Redirect("~/users/smessages.aspx?qModule=DataSaved", False)
    End Sub

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


        C21MIT.PBSIS.BLL.pbsdemodata.addSchooldemodata(objdemodata)
    End Sub

    Sub addschoolODS()
        Dim objODS As New C21MIT.PBSIS.BO.pbsods

        objODS.SchoolID = Session("MM_Username")
        objODS.SchoolYear = C21MIT.PBSIS.BLL.pbslogindetails.GetCurrentPrimTracker.schoolyear

        objODS.OdTotalOfficeReferrals = Integer.Parse(C21MIT.Util.DBNullHandler.BlankToDBSingle(txtbdDisciplineReferrals.Text))
        objODS.OdAvgDailyAttendance = Integer.Parse(C21MIT.Util.DBNullHandler.BlankToDBSingle(txtbdDailyAttendance.Text))
        objODS.OdTotalISSDays = Integer.Parse(C21MIT.Util.DBNullHandler.BlankToDBSingle(txtbdInSchoolSuspensions.Text))
        objODS.OdTotalOSSDays = Integer.Parse(C21MIT.Util.DBNullHandler.BlankToDBSingle(txtbdOutSchoolSuspensions.Text))

        objODS.OdPercentReadingGains = Integer.Parse(C21MIT.Util.DBNullHandler.BlankToDBSingle(txtbdLearningGains.Text))
        objODS.OdPercentLowest25Reading = Integer.Parse(C21MIT.Util.DBNullHandler.BlankToDBSingle(txtbdLowestLearningGains.Text))
        objODS.OdPercLvl3FcatRead = Integer.Parse(C21MIT.Util.DBNullHandler.BlankToDBSingle(txtbdLevel3Reading.Text))
        objODS.OdSchoolGrade = txtbdSchoolGrade.Text
        objODS.OdTotalSchoolPoints = Integer.Parse(C21MIT.Util.DBNullHandler.BlankToDBSingle(txtbdTotSchoolPoints.Text))
        objODS.OdIdOut = C21MIT.PBSIS.BLL.pbsods.addSchoolBaselineODS(objODS).OdIdOut
    End Sub
End Class
