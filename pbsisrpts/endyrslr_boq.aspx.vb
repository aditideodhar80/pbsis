'-------------------------------------------------------------------------------------------------------------------
' Created By : Aditi Deodhar
' Created Dt : Feb 09,2010
' Last Updated Dt : Apr 01,2010
'-------------------------------------------------------------------------------------------------------------------
Partial Class pbsisrpts_endyrslr_boq
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            C21MIT.PBSIS.BLL.pbsloginsession.chkloginsession("schrpt")

            Dim objBOQ As New C21MIT.PBSIS.BO.pbsschoolreport

            If Not CStr(C21MIT.PBSIS.BLL.pbslogindetails.GetCurrentPrimTracker.v_actid) Is Nothing Then
                If Not CStr(Session("sRptSchID")) Is Nothing Then
                    objBOQ.SchoolID = CStr(Session("sRptSchID"))
                ElseIf Not Request.QueryString("sRptSchID") Is Nothing Then
                    objBOQ.SchoolID = C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("sRptSchID"))
                Else
                    objBOQ.SchoolID = C21MIT.PBSIS.BLL.pbslogindetails.GetCurrentPrimTracker.v_actid
                End If
            End If


            If Not Session("SchYrId") Is Nothing Then
                objBOQ.SchoolYear = Session("SchYrId")
            Else
                If Not CStr(C21MIT.PBSIS.BLL.pbslogindetails.GetCurrentPrimTracker.schoolyear) Is Nothing Then
                    objBOQ.SchoolYear = C21MIT.PBSIS.BLL.pbslogindetails.GetCurrentPrimTracker.schoolyear
                End If
            End If
            

            'Get all the PIC details and bind them to the form.
            binddata(objBOQ.SchoolID, objBOQ.SchoolYear)
            bindropdown(objBOQ.SchoolYear)
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
        lblSchoolName.Text = C21MIT.PBSIS.BLL.pbsschoolboqendyrreport.fngetBOQEndYearSchool(schoolID, schoolyR).SchoolName
        lblDistrictName.Text = C21MIT.PBSIS.BLL.pbsschoolboqendyrreport.fngetBOQEndYearSchool(schoolID, schoolyR).DistrictName
        lblCoachName.Text = C21MIT.PBSIS.BLL.pbsschoolboqendyrreport.fngetBOQEndYearSchool(schoolID, schoolyR).CoachName
        '  lblYear.Text = C21MIT.PBSIS.BLL.pbsschoolyeardesc.getschoolyeardesc(schoolyR)
        'ddlYear.SelectedValue = schoolyR


        If IsDBNull(C21MIT.PBSIS.BLL.pbsschoolboqendyrreport.fngetBOQEndYearSchool(schoolID, schoolyR).ScoringMethod) Then
            lblScoringMethod.Text = ""
        Else
            If C21MIT.PBSIS.BLL.pbsschoolboqendyrreport.fngetBOQEndYearSchool(schoolID, schoolyR).ScoringMethod = 1 Then
                lblScoringMethod.Text = "Coach uses Scoring Guide to select score, team members use Rating Form, coach addresses discrepancies with the team."
            Else
                lblScoringMethod.Text = "Team and coach use the Scoring Guide, team and coach meet to reach consensus on each item."
            End If
        End If
      

        lblBOQQuestion1.Text = C21MIT.PBSIS.BLL.pbsschoolboqendyrreport.fngetBOQEndYearSchool(schoolID, schoolyR).Question1
        lblBOQQuestion2.Text = C21MIT.PBSIS.BLL.pbsschoolboqendyrreport.fngetBOQEndYearSchool(schoolID, schoolyR).Question2
        lblBOQQuestion3.Text = C21MIT.PBSIS.BLL.pbsschoolboqendyrreport.fngetBOQEndYearSchool(schoolID, schoolyR).Question3
        lblBOQQuestion4.Text = C21MIT.PBSIS.BLL.pbsschoolboqendyrreport.fngetBOQEndYearSchool(schoolID, schoolyR).Question4
        lblBOQQuestion5.Text = C21MIT.PBSIS.BLL.pbsschoolboqendyrreport.fngetBOQEndYearSchool(schoolID, schoolyR).Question5
        lblBOQQuestion6.Text = C21MIT.PBSIS.BLL.pbsschoolboqendyrreport.fngetBOQEndYearSchool(schoolID, schoolyR).Question6
        lblBOQQuestion7.Text = C21MIT.PBSIS.BLL.pbsschoolboqendyrreport.fngetBOQEndYearSchool(schoolID, schoolyR).Question7
        lblBOQQuestion8.Text = C21MIT.PBSIS.BLL.pbsschoolboqendyrreport.fngetBOQEndYearSchool(schoolID, schoolyR).Question8
        lblBOQQuestion9.Text = C21MIT.PBSIS.BLL.pbsschoolboqendyrreport.fngetBOQEndYearSchool(schoolID, schoolyR).Question9
        lblBOQQuestion10.Text = C21MIT.PBSIS.BLL.pbsschoolboqendyrreport.fngetBOQEndYearSchool(schoolID, schoolyR).Question10

        lblBOQQuestion11.Text = C21MIT.PBSIS.BLL.pbsschoolboqendyrreport.fngetBOQEndYearSchool(schoolID, schoolyR).Question11
        lblBOQQuestion12.Text = C21MIT.PBSIS.BLL.pbsschoolboqendyrreport.fngetBOQEndYearSchool(schoolID, schoolyR).Question12
        lblBOQQuestion13.Text = C21MIT.PBSIS.BLL.pbsschoolboqendyrreport.fngetBOQEndYearSchool(schoolID, schoolyR).Question13
        lblBOQQuestion14.Text = C21MIT.PBSIS.BLL.pbsschoolboqendyrreport.fngetBOQEndYearSchool(schoolID, schoolyR).Question14
        lblBOQQuestion15.Text = C21MIT.PBSIS.BLL.pbsschoolboqendyrreport.fngetBOQEndYearSchool(schoolID, schoolyR).Question15
        lblBOQQuestion16.Text = C21MIT.PBSIS.BLL.pbsschoolboqendyrreport.fngetBOQEndYearSchool(schoolID, schoolyR).Question16
        lblBOQQuestion17.Text = C21MIT.PBSIS.BLL.pbsschoolboqendyrreport.fngetBOQEndYearSchool(schoolID, schoolyR).Question17
        lblBOQQuestion18.Text = C21MIT.PBSIS.BLL.pbsschoolboqendyrreport.fngetBOQEndYearSchool(schoolID, schoolyR).Question18
        lblBOQQuestion19.Text = C21MIT.PBSIS.BLL.pbsschoolboqendyrreport.fngetBOQEndYearSchool(schoolID, schoolyR).Question19
        lblBOQQuestion20.Text = C21MIT.PBSIS.BLL.pbsschoolboqendyrreport.fngetBOQEndYearSchool(schoolID, schoolyR).Question20

        lblBOQQuestion21.Text = C21MIT.PBSIS.BLL.pbsschoolboqendyrreport.fngetBOQEndYearSchool(schoolID, schoolyR).Question21
        lblBOQQuestion22.Text = C21MIT.PBSIS.BLL.pbsschoolboqendyrreport.fngetBOQEndYearSchool(schoolID, schoolyR).Question22
        lblBOQQuestion23.Text = C21MIT.PBSIS.BLL.pbsschoolboqendyrreport.fngetBOQEndYearSchool(schoolID, schoolyR).Question23
        lblBOQQuestion24.Text = C21MIT.PBSIS.BLL.pbsschoolboqendyrreport.fngetBOQEndYearSchool(schoolID, schoolyR).Question24
        lblBOQQuestion25.Text = C21MIT.PBSIS.BLL.pbsschoolboqendyrreport.fngetBOQEndYearSchool(schoolID, schoolyR).Question25
        lblBOQQuestion26.Text = C21MIT.PBSIS.BLL.pbsschoolboqendyrreport.fngetBOQEndYearSchool(schoolID, schoolyR).Question26
        lblBOQQuestion27.Text = C21MIT.PBSIS.BLL.pbsschoolboqendyrreport.fngetBOQEndYearSchool(schoolID, schoolyR).Question27
        lblBOQQuestion28.Text = C21MIT.PBSIS.BLL.pbsschoolboqendyrreport.fngetBOQEndYearSchool(schoolID, schoolyR).Question28
        lblBOQQuestion29.Text = C21MIT.PBSIS.BLL.pbsschoolboqendyrreport.fngetBOQEndYearSchool(schoolID, schoolyR).Question29
        lblBOQQuestion30.Text = C21MIT.PBSIS.BLL.pbsschoolboqendyrreport.fngetBOQEndYearSchool(schoolID, schoolyR).Question30

        lblBOQQuestion31.Text = C21MIT.PBSIS.BLL.pbsschoolboqendyrreport.fngetBOQEndYearSchool(schoolID, schoolyR).Question31
        lblBOQQuestion32.Text = C21MIT.PBSIS.BLL.pbsschoolboqendyrreport.fngetBOQEndYearSchool(schoolID, schoolyR).Question32
        lblBOQQuestion33.Text = C21MIT.PBSIS.BLL.pbsschoolboqendyrreport.fngetBOQEndYearSchool(schoolID, schoolyR).Question33
        lblBOQQuestion34.Text = C21MIT.PBSIS.BLL.pbsschoolboqendyrreport.fngetBOQEndYearSchool(schoolID, schoolyR).Question34
        lblBOQQuestion35.Text = C21MIT.PBSIS.BLL.pbsschoolboqendyrreport.fngetBOQEndYearSchool(schoolID, schoolyR).Question35
        lblBOQQuestion36.Text = C21MIT.PBSIS.BLL.pbsschoolboqendyrreport.fngetBOQEndYearSchool(schoolID, schoolyR).Question36
        lblBOQQuestion37.Text = C21MIT.PBSIS.BLL.pbsschoolboqendyrreport.fngetBOQEndYearSchool(schoolID, schoolyR).Question37
        lblBOQQuestion38.Text = C21MIT.PBSIS.BLL.pbsschoolboqendyrreport.fngetBOQEndYearSchool(schoolID, schoolyR).Question38
        lblBOQQuestion39.Text = C21MIT.PBSIS.BLL.pbsschoolboqendyrreport.fngetBOQEndYearSchool(schoolID, schoolyR).Question39
        lblBOQQuestion40.Text = C21MIT.PBSIS.BLL.pbsschoolboqendyrreport.fngetBOQEndYearSchool(schoolID, schoolyR).Question40

        lblBOQQuestion41.Text = C21MIT.PBSIS.BLL.pbsschoolboqendyrreport.fngetBOQEndYearSchool(schoolID, schoolyR).Question41
        lblBOQQuestion42.Text = C21MIT.PBSIS.BLL.pbsschoolboqendyrreport.fngetBOQEndYearSchool(schoolID, schoolyR).Question42
        lblBOQQuestion43.Text = C21MIT.PBSIS.BLL.pbsschoolboqendyrreport.fngetBOQEndYearSchool(schoolID, schoolyR).Question43
        lblBOQQuestion44.Text = C21MIT.PBSIS.BLL.pbsschoolboqendyrreport.fngetBOQEndYearSchool(schoolID, schoolyR).Question44
        lblBOQQuestion45.Text = C21MIT.PBSIS.BLL.pbsschoolboqendyrreport.fngetBOQEndYearSchool(schoolID, schoolyR).Question45
        lblBOQQuestion46.Text = C21MIT.PBSIS.BLL.pbsschoolboqendyrreport.fngetBOQEndYearSchool(schoolID, schoolyR).Question46
        lblBOQQuestion47.Text = C21MIT.PBSIS.BLL.pbsschoolboqendyrreport.fngetBOQEndYearSchool(schoolID, schoolyR).Question47
        lblBOQQuestion48.Text = C21MIT.PBSIS.BLL.pbsschoolboqendyrreport.fngetBOQEndYearSchool(schoolID, schoolyR).Question48
        lblBOQQuestion49.Text = C21MIT.PBSIS.BLL.pbsschoolboqendyrreport.fngetBOQEndYearSchool(schoolID, schoolyR).Question49
        lblBOQQuestion50.Text = C21MIT.PBSIS.BLL.pbsschoolboqendyrreport.fngetBOQEndYearSchool(schoolID, schoolyR).Question50

        lblBOQQuestion51.Text = C21MIT.PBSIS.BLL.pbsschoolboqendyrreport.fngetBOQEndYearSchool(schoolID, schoolyR).Question51
        lblBOQQuestion52.Text = C21MIT.PBSIS.BLL.pbsschoolboqendyrreport.fngetBOQEndYearSchool(schoolID, schoolyR).Question52
        lblBOQQuestion53.Text = C21MIT.PBSIS.BLL.pbsschoolboqendyrreport.fngetBOQEndYearSchool(schoolID, schoolyR).Question53
        'lblBOQQuestion54.Text = C21MIT.PBSIS.BLL.pbsschoolboq.pbsschoolboqendyrreport.fngetBOQEndYearSchool(schoolID, schoolyR).Question54
        'lblBOQQuestion55.Text = C21MIT.PBSIS.BLL.pbsschoolboq.pbsschoolboqendyrreport.fngetBOQEndYearSchool(schoolID, schoolyR).Question55
        'lblBOQQuestion56.Text = C21MIT.PBSIS.BLL.pbsschoolboq.pbsschoolboqendyrreport.fngetBOQEndYearSchool(schoolID, schoolyR).Question56
        'lblBOQQuestion57.Text = C21MIT.PBSIS.BLL.pbsschoolboq.pbsschoolboqendyrreport.fngetBOQEndYearSchool(schoolID, schoolyR).Question57
        'lblBOQQuestion58.Text = C21MIT.PBSIS.BLL.pbsschoolboq.pbsschoolboqendyrreport.fngetBOQEndYearSchool(schoolID, schoolyR).Question58
        'lblBOQQuestion59.Text = C21MIT.PBSIS.BLL.pbsschoolboq.pbsschoolboqendyrreport.fngetBOQEndYearSchool(schoolID, schoolyR).Question59
        'lblBOQQuestion60.Text = C21MIT.PBSIS.BLL.pbsschoolboq.pbsschoolboqendyrreport.fngetBOQEndYearSchool(schoolID, schoolyR).Question60

        '' ''Dim i As Integer
        '' ''Dim count As Integer = 0

        '' ''For i = 1 To 53
        '' ''    Dim labelcontrol As Label = C21MIT.PBSIS.BLL.pbsfindcontroliterative.FindControlIterative(Me, "lblBOQQuestion" & i)
        '' ''    Dim labelval As String = labelcontrol.Text
        '' ''    count = count + CInt(labelval)
        '' ''Next

        '' ''lblBOQTotalScore.Text = count & "/107"

        Dim i As Integer
        Dim count As Integer = 0
        If schoolyR < 13 Then
            For i = 1 To 53
                Dim labelcontrol As Label = C21MIT.PBSIS.BLL.pbsfindcontroliterative.FindControlIterative(Me, "lblBOQQuestion" & i)
                Dim labelval As String = labelcontrol.Text
                count = count + CInt(labelval)
            Next
            lblBOQTotalScore.Text = count
        Else
            For i = 1 To 53
                Dim varcontrol As Label = C21MIT.PBSIS.BLL.pbsfindcontroliterative.FindControlIterative(Me, "lblBOQQuestion" & i)                Dim labelval As String = varcontrol.Text
                count = count + CInt(labelval)
            Next

            count += CInt(C21MIT.PBSIS.BLL.pbsschoolboqendyrreport.fngetBOQEndYearSchool(schoolID, schoolyR).Question54) + CInt(C21MIT.PBSIS.BLL.pbsschoolboqendyrreport.fngetBOQEndYearSchool(schoolID, schoolyR).Question55) + CInt(C21MIT.PBSIS.BLL.pbsschoolboqendyrreport.fngetBOQEndYearSchool(schoolID, schoolyR).Question56) + CInt(C21MIT.PBSIS.BLL.pbsschoolboqendyrreport.fngetBOQEndYearSchool(schoolID, schoolyR).Question57) + CInt(C21MIT.PBSIS.BLL.pbsschoolboqendyrreport.fngetBOQEndYearSchool(schoolID, schoolyR).Question58) + CInt(C21MIT.PBSIS.BLL.pbsschoolboqendyrreport.fngetBOQEndYearSchool(schoolID, schoolyR).Question59) + CInt(C21MIT.PBSIS.BLL.pbsschoolboqendyrreport.fngetBOQEndYearSchool(schoolID, schoolyR).Question60)

            count -= CInt(C21MIT.PBSIS.BLL.pbsschoolboqendyrreport.fngetBOQEndYearSchool(schoolID, schoolyR).Question1.ToString) + CInt(C21MIT.PBSIS.BLL.pbsschoolboqendyrreport.fngetBOQEndYearSchool(schoolID, schoolyR).Question13.ToString) + CInt(C21MIT.PBSIS.BLL.pbsschoolboqendyrreport.fngetBOQEndYearSchool(schoolID, schoolyR).Question17.ToString) + CInt(C21MIT.PBSIS.BLL.pbsschoolboqendyrreport.fngetBOQEndYearSchool(schoolID, schoolyR).Question29.ToString) + CInt(C21MIT.PBSIS.BLL.pbsschoolboqendyrreport.fngetBOQEndYearSchool(schoolID, schoolyR).Question46.ToString) + CInt(C21MIT.PBSIS.BLL.pbsschoolboqendyrreport.fngetBOQEndYearSchool(schoolID, schoolyR).Question47.ToString) + CInt(C21MIT.PBSIS.BLL.pbsschoolboqendyrreport.fngetBOQEndYearSchool(schoolID, schoolyR).Question48.ToString)

            If Not IsDBNull(count) Then
                lblBOQTotalScore.Text = count & "/107"
            Else
                lblBOQTotalScore.Text = ""
            End If
        End If
    End Sub

    Protected Sub ddlYear_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddlYear.SelectedIndexChanged
        Dim objBOQ As New C21MIT.PBSIS.BO.pbsdemodata
        If Not CStr(C21MIT.PBSIS.BLL.pbslogindetails.GetCurrentPrimTracker.v_actid) Is Nothing Then
            If Not CStr(Session("sRptSchID")) Is Nothing Then
                objBOQ.SchoolID = CStr(Session("sRptSchID"))
            ElseIf Not Request.QueryString("sRptSchID") Is Nothing Then
                objBOQ.SchoolID = C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("sRptSchID"))
            Else
                objBOQ.SchoolID = C21MIT.PBSIS.BLL.pbslogindetails.GetCurrentPrimTracker.v_actid
            End If
        End If
        binddata(objBOQ.SchoolID, ddlYear.SelectedItem.Value)
    End Sub

    Protected Sub Page_LoadComplete(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.LoadComplete
        Session("sRptSchID") = Nothing
    End Sub
End Class
