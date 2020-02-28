
Partial Class fmhiadmin_fmhi_formactivation
    Inherits System.Web.UI.Page
    Dim objformactivation As New C21MIT.PBSIS.BO.pbsschooldataentrylinks
    Dim objFormAct As New C21MIT.PBSIS.BO.pbsschoolreport
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            C21MIT.PBSIS.BLL.pbsloginsession.chkloginsession("fmhiadm")
            C21MIT.PBSIS.BLL.pbsloginsession.chkAdminLevel()

            'get the values
            binddata()
            bindropdown()
        End If

    End Sub

    Sub binddata()
        chkEditSchProfile.Checked = C21MIT.PBSIS.BLL.pbsfmhiformactivation.getfmhiformactivation().FinSchoolProfile
        chkDemoData.Checked = C21MIT.PBSIS.BLL.pbsfmhiformactivation.getfmhiformactivation().FinSchoolDemoData
        chkSchTeamUp.Checked = C21MIT.PBSIS.BLL.pbsfmhiformactivation.getfmhiformactivation().FinSchoolTeamUpdate
        chkTeamEval.Checked = C21MIT.PBSIS.BLL.pbsfmhiformactivation.getfmhiformactivation().FinTeamProcessEval
        chkBOQ.Checked = C21MIT.PBSIS.BLL.pbsfmhiformactivation.getfmhiformactivation().FinBOQ
        chkODS.Checked = C21MIT.PBSIS.BLL.pbsfmhiformactivation.getfmhiformactivation().FinOutcomeDataSum
        chkPICFall.Checked = C21MIT.PBSIS.BLL.pbsfmhiformactivation.getfmhiformactivation().FinPICFall
        chkPICSpring.Checked = C21MIT.PBSIS.BLL.pbsfmhiformactivation.getfmhiformactivation().FinPICSpring
        chkBAT.Checked = C21MIT.PBSIS.BLL.pbsfmhiformactivation.getfmhiformactivation().FinBAT


    End Sub

    Sub bindropdown()
        ddlschyr.DataSource = C21MIT.PBSIS.BLL.pbsfmhiformactivation.getfmhiformactivationyrlist()
        ddlschyr.DataValueField = C21MIT.PBSIS.BLL.pbsfmhiformactivation.getfmhiformactivationyrlist().Tables(0).Columns(0).ToString
        ddlschyr.DataTextField = C21MIT.PBSIS.BLL.pbsfmhiformactivation.getfmhiformactivationyrlist().Tables(0).Columns(1).ToString
        ddlschyr.DataBind()


        If Not CStr(C21MIT.PBSIS.BLL.pbslogindetails.GetCurrentPrimTracker.schoolyear) Is Nothing Then
            
            objFormAct.SchoolYear = C21MIT.PBSIS.BLL.pbslogindetails.GetCurrentPrimTracker.schoolyear

        End If


        ddlschyr.SelectedValue = objFormAct.SchoolYear
       
    End Sub

    Protected Sub btnsubmit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnsubmit.Click
        updatevalues()
        binddata()
    End Sub

    Sub updatevalues()


        If chkEditSchProfile.Checked Then
            objformactivation.FinSchoolProfile = 1
        Else
            objformactivation.FinSchoolProfile = 0
        End If

        If chkDemoData.Checked Then
            objformactivation.FinSchoolDemoData = 1
        Else
            objformactivation.FinSchoolDemoData = 0
        End If

        If chkSchTeamUp.Checked Then
            objformactivation.FinSchoolTeamUpdate = 1
        Else
            objformactivation.FinSchoolTeamUpdate = 0
        End If

        If chkTeamEval.Checked Then
            objformactivation.FinTeamProcessEval = 1
        Else
            objformactivation.FinTeamProcessEval = 0
        End If

        If chkBOQ.Checked Then
            objformactivation.FinBOQ = 1
        Else
            objformactivation.FinBOQ = 0
        End If

        If chkODS.Checked Then
            objformactivation.FinOutcomeDataSum = 1
        Else
            objformactivation.FinOutcomeDataSum = 0
        End If

        If chkPICFall.Checked Then
            objformactivation.FinPICFall = 1
        Else
            objformactivation.FinPICFall = 0
        End If

        If chkPICSpring.Checked Then
            objformactivation.FinPICSpring = 1
        Else
            objformactivation.FinPICSpring = 0
        End If

        If chkBAT.Checked Then
            objformactivation.FinBAT = 1
        Else
            objformactivation.FinBAT = 0
        End If

        C21MIT.PBSIS.BLL.pbsfmhiformactivation.updatefmhiformactivation(objformactivation)
    End Sub

    Protected Sub btnSaveYr_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSaveYr.Click
        updateyrvalues()
        bindropdown()
    End Sub

    Sub updateyrvalues()

        objformactivation.AcadYear = ddlschyr.SelectedItem.Value
        C21MIT.PBSIS.BLL.pbsfmhiformactivation.updatefmhiformYractivation(objformactivation.AcadYear)
    End Sub
End Class
