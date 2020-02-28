'-------------------------------------------------------------------------------------------------------------------
' Created By : Aditi Deodhar
' Created Dt : Feb 18,2010
' Last Updated Dt : Feb 18,2010
'-------------------------------------------------------------------------------------------------------------------
Partial Class school_school_ODS_Add
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        C21MIT.PBSIS.BLL.pbsloginsession.chkloginsession("School")

        Dim objODS As New C21MIT.PBSIS.BO.pbsods

        objODS.SchoolID = Session("MM_Username")
        objODS.SchoolYear = C21MIT.PBSIS.BLL.pbslogindetails.GetCurrentPrimTracker.schoolyear
        bindata(objODS.SchoolID, objODS.SchoolYear)

        objODS.OdProgMonIndDesc = txtOdProgMonIndDesc.Text
    End Sub

    Sub bindata(ByVal schoolID As String, ByVal schoolYr As String)
        lblSchoolName.Text = C21MIT.PBSIS.BLL.pbsschoolprofile.getschoolprofile(schoolID).SchoolName
        lblSchoolYr.Text = C21MIT.PBSIS.BLL.pbsschoolyeardesc.getschoolyeardesc(schoolYr)
        'ahref1.HRef = "mailto:childs@fmhi.usf.edu?subject=ODS support documents for School:" & Session("MM_Username")
    End Sub

    Protected Sub btnsubmit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnsubmit.Click
        addschoolODS()
    End Sub

    Sub addschoolODS()
        Dim objODS As New C21MIT.PBSIS.BO.pbsods

        objODS.SchoolID = Session("MM_Username")
        objODS.SchoolYear = C21MIT.PBSIS.BLL.pbslogindetails.GetCurrentPrimTracker.schoolyear

        objODS.OdTotalSchoolDays = txtOdTotalSchoolDays.Text
        objODS.OdAvgDailyAttendance = txtOdAvgDailyAttendance.Text
        objODS.OdTotalOfficeReferrals = txtOdTotalOfficeReferrals.Text
        objODS.OdTotalISSDays = txtOdTotalISSDays.Text
        objODS.OdTotalOSSDays = txtOdTotalOSSDays.Text

        If radioOdProgMonTargetYes.Checked Then
            objODS.OdProgMonTarget = 1
        ElseIf radioOdProgMonTargetNo.Checked Then
            objODS.OdProgMonTarget = 0
        End If

        objODS.OdProgMonTargDesc = txtOdProgMonTargDesc.Text

        If radioOdProgMonIndivYes.Checked Then
            objODS.OdProgMonIndiv = 1
        ElseIf radioOdProgMonIndivYes.Checked Then
            objODS.OdProgMonIndiv = 0
        End If

        objODS.OdProgMonIndDesc = txtOdProgMonIndDesc.Text
        objODS.OdIdOut = C21MIT.PBSIS.BLL.pbsods.addSchoolODS(objODS).OdIdOut

        'Get the School year and the School Id based on the OdId received and pass all the 3 of them encrypted (Cancel).
        Response.Redirect("school_ODS_Upload.aspx?ODID=" & objODS.OdIdOut & "")
    End Sub

  
End Class
