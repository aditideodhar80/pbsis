'-------------------------------------------------------------------------------------------------------------------
' Created By : Satish Hanumanthu
' Created Dt : March 24,2010
' Last Updated Dt : March 25,2010
'-------------------------------------------------------------------------------------------------------------------

Partial Class pbsisrpts_endyrslr_bat
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not Page.IsPostBack Then
            C21MIT.PBSIS.BLL.pbsloginsession.chkloginsession("schrpt")

            Dim objbat As New C21MIT.PBSIS.BO.pbsschoolreport
            If Not CStr(C21MIT.PBSIS.BLL.pbslogindetails.GetCurrentPrimTracker.v_actid) Is Nothing Then
                If Not CStr(Session("sRptSchID")) Is Nothing Then
                    objbat.SchoolID = CStr(Session("sRptSchID"))
                ElseIf Not Request.QueryString("sRptSchID") Is Nothing Then
                    objbat.SchoolID = C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("sRptSchID"))
                Else
                    objbat.SchoolID = C21MIT.PBSIS.BLL.pbslogindetails.GetCurrentPrimTracker.v_actid
                End If
            End If

            If Not Session("SchYrId") Is Nothing Then
                objbat.SchoolYear = Session("SchYrId")
            Else
                If Not CStr(C21MIT.PBSIS.BLL.pbslogindetails.GetCurrentPrimTracker.schoolyear) Is Nothing Then
                    objbat.SchoolYear = C21MIT.PBSIS.BLL.pbslogindetails.GetCurrentPrimTracker.schoolyear
                End If
            End If
            'Get all the PIC details and bind them to the form.
            binddata(objbat.SchoolID, objbat.SchoolYear)
            bindropdown(objbat.SchoolYear)
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
        lblSchoolName.Text = C21MIT.PBSIS.BLL.pbslbat.pbsschoolbatendyrreport.fngetBatEndYearSchool(schoolID, schoolyR).SchoolName
        lblDistrictName.Text = C21MIT.PBSIS.BLL.pbslbat.pbsschoolbatendyrreport.fngetBatEndYearSchool(schoolID, schoolyR).DistrictName
        lblCoachName.Text = C21MIT.PBSIS.BLL.pbslbat.pbsschoolbatendyrreport.fngetBatEndYearSchool(schoolID, schoolyR).CoachName
        '  lblYear.Text = C21MIT.PBSIS.BLL.pbsschoolyeardesc.getschoolyeardesc(schoolyR)
        'ddlYear.SelectedValue = schoolyR
        lblTeamleader.Text = C21MIT.PBSIS.BLL.pbslbat.pbsschoolbatendyrreport.fngetBatEndYearSchool(schoolID, schoolyR).TeamLeader
        lblTeammember.Text = C21MIT.PBSIS.BLL.pbslbat.pbsschoolbatendyrreport.fngetBatEndYearSchool(schoolID, schoolyR).TeamMember

        lblBATQuestion1.Text = C21MIT.PBSIS.BLL.pbslbat.pbsschoolbatendyrreport.fngetBatEndYearSchool(schoolID, schoolyR).Question1
        lblBATQuestion2.Text = C21MIT.PBSIS.BLL.pbslbat.pbsschoolbatendyrreport.fngetBatEndYearSchool(schoolID, schoolyR).Question2
        lblBATQuestion3.Text = C21MIT.PBSIS.BLL.pbslbat.pbsschoolbatendyrreport.fngetBatEndYearSchool(schoolID, schoolyR).Question3
        lblBATQuestion4.Text = C21MIT.PBSIS.BLL.pbslbat.pbsschoolbatendyrreport.fngetBatEndYearSchool(schoolID, schoolyR).Question4
        lblBATQuestion5.Text = C21MIT.PBSIS.BLL.pbslbat.pbsschoolbatendyrreport.fngetBatEndYearSchool(schoolID, schoolyR).Question5
        lblBATQuestion6.Text = C21MIT.PBSIS.BLL.pbslbat.pbsschoolbatendyrreport.fngetBatEndYearSchool(schoolID, schoolyR).Question6
        lblBATQuestion7.Text = C21MIT.PBSIS.BLL.pbslbat.pbsschoolbatendyrreport.fngetBatEndYearSchool(schoolID, schoolyR).Question7
        lblBATQuestion8.Text = C21MIT.PBSIS.BLL.pbslbat.pbsschoolbatendyrreport.fngetBatEndYearSchool(schoolID, schoolyR).Question8
        lblBATQuestion9.Text = C21MIT.PBSIS.BLL.pbslbat.pbsschoolbatendyrreport.fngetBatEndYearSchool(schoolID, schoolyR).Question9
        lblBATQuestion10.Text = C21MIT.PBSIS.BLL.pbslbat.pbsschoolbatendyrreport.fngetBatEndYearSchool(schoolID, schoolyR).Question10

        lblBATQuestion11.Text = C21MIT.PBSIS.BLL.pbslbat.pbsschoolbatendyrreport.fngetBatEndYearSchool(schoolID, schoolyR).Question11
        lblBATQuestion12.Text = C21MIT.PBSIS.BLL.pbslbat.pbsschoolbatendyrreport.fngetBatEndYearSchool(schoolID, schoolyR).Question12
        lblBATQuestion13.Text = C21MIT.PBSIS.BLL.pbslbat.pbsschoolbatendyrreport.fngetBatEndYearSchool(schoolID, schoolyR).Question13
        lblBATQuestion14.Text = C21MIT.PBSIS.BLL.pbslbat.pbsschoolbatendyrreport.fngetBatEndYearSchool(schoolID, schoolyR).Question14
        lblBATQuestion15.Text = C21MIT.PBSIS.BLL.pbslbat.pbsschoolbatendyrreport.fngetBatEndYearSchool(schoolID, schoolyR).Question15
        lblBATQuestion16.Text = C21MIT.PBSIS.BLL.pbslbat.pbsschoolbatendyrreport.fngetBatEndYearSchool(schoolID, schoolyR).Question16
        lblBATQuestion17.Text = C21MIT.PBSIS.BLL.pbslbat.pbsschoolbatendyrreport.fngetBatEndYearSchool(schoolID, schoolyR).Question17
        lblBATQuestion18.Text = C21MIT.PBSIS.BLL.pbslbat.pbsschoolbatendyrreport.fngetBatEndYearSchool(schoolID, schoolyR).Question18
        lblBATQuestion19.Text = C21MIT.PBSIS.BLL.pbslbat.pbsschoolbatendyrreport.fngetBatEndYearSchool(schoolID, schoolyR).Question19
        lblBATQuestion20.Text = C21MIT.PBSIS.BLL.pbslbat.pbsschoolbatendyrreport.fngetBatEndYearSchool(schoolID, schoolyR).Question20

        lblBATQuestion21.Text = C21MIT.PBSIS.BLL.pbslbat.pbsschoolbatendyrreport.fngetBatEndYearSchool(schoolID, schoolyR).Question21
        lblBATQuestion22.Text = C21MIT.PBSIS.BLL.pbslbat.pbsschoolbatendyrreport.fngetBatEndYearSchool(schoolID, schoolyR).Question22
        lblBATQuestion23.Text = C21MIT.PBSIS.BLL.pbslbat.pbsschoolbatendyrreport.fngetBatEndYearSchool(schoolID, schoolyR).Question23
        lblBATQuestion24.Text = C21MIT.PBSIS.BLL.pbslbat.pbsschoolbatendyrreport.fngetBatEndYearSchool(schoolID, schoolyR).Question24
        lblBATQuestion25.Text = C21MIT.PBSIS.BLL.pbslbat.pbsschoolbatendyrreport.fngetBatEndYearSchool(schoolID, schoolyR).Question25
        lblBATQuestion26.Text = C21MIT.PBSIS.BLL.pbslbat.pbsschoolbatendyrreport.fngetBatEndYearSchool(schoolID, schoolyR).Question26
        lblBATQuestion27.Text = C21MIT.PBSIS.BLL.pbslbat.pbsschoolbatendyrreport.fngetBatEndYearSchool(schoolID, schoolyR).Question27
        lblBATQuestion28.Text = C21MIT.PBSIS.BLL.pbslbat.pbsschoolbatendyrreport.fngetBatEndYearSchool(schoolID, schoolyR).Question28
        lblBATQuestion29.Text = C21MIT.PBSIS.BLL.pbslbat.pbsschoolbatendyrreport.fngetBatEndYearSchool(schoolID, schoolyR).Question29
        lblBATQuestion30.Text = C21MIT.PBSIS.BLL.pbslbat.pbsschoolbatendyrreport.fngetBatEndYearSchool(schoolID, schoolyR).Question30

        lblBATQuestion31.Text = C21MIT.PBSIS.BLL.pbslbat.pbsschoolbatendyrreport.fngetBatEndYearSchool(schoolID, schoolyR).Question31
        lblBATQuestion32.Text = C21MIT.PBSIS.BLL.pbslbat.pbsschoolbatendyrreport.fngetBatEndYearSchool(schoolID, schoolyR).Question32
        lblBATQuestion33.Text = C21MIT.PBSIS.BLL.pbslbat.pbsschoolbatendyrreport.fngetBatEndYearSchool(schoolID, schoolyR).Question33
        lblBATQuestion34.Text = C21MIT.PBSIS.BLL.pbslbat.pbsschoolbatendyrreport.fngetBatEndYearSchool(schoolID, schoolyR).Question34
        lblBATQuestion35.Text = C21MIT.PBSIS.BLL.pbslbat.pbsschoolbatendyrreport.fngetBatEndYearSchool(schoolID, schoolyR).Question35
        lblBATQuestion36.Text = C21MIT.PBSIS.BLL.pbslbat.pbsschoolbatendyrreport.fngetBatEndYearSchool(schoolID, schoolyR).Question36
        lblBATQuestion37.Text = C21MIT.PBSIS.BLL.pbslbat.pbsschoolbatendyrreport.fngetBatEndYearSchool(schoolID, schoolyR).Question37
        lblBATQuestion38.Text = C21MIT.PBSIS.BLL.pbslbat.pbsschoolbatendyrreport.fngetBatEndYearSchool(schoolID, schoolyR).Question38
        lblBATQuestion39.Text = C21MIT.PBSIS.BLL.pbslbat.pbsschoolbatendyrreport.fngetBatEndYearSchool(schoolID, schoolyR).Question39
        lblBATQuestion40.Text = C21MIT.PBSIS.BLL.pbslbat.pbsschoolbatendyrreport.fngetBatEndYearSchool(schoolID, schoolyR).Question40

        lblBATQuestion41.Text = C21MIT.PBSIS.BLL.pbslbat.pbsschoolbatendyrreport.fngetBatEndYearSchool(schoolID, schoolyR).Question41
        lblBATQuestion42.Text = C21MIT.PBSIS.BLL.pbslbat.pbsschoolbatendyrreport.fngetBatEndYearSchool(schoolID, schoolyR).Question42
        lblBATQuestion43.Text = C21MIT.PBSIS.BLL.pbslbat.pbsschoolbatendyrreport.fngetBatEndYearSchool(schoolID, schoolyR).Question43
        lblBATQuestion44.Text = C21MIT.PBSIS.BLL.pbslbat.pbsschoolbatendyrreport.fngetBatEndYearSchool(schoolID, schoolyR).Question44
        lblBATQuestion45.Text = C21MIT.PBSIS.BLL.pbslbat.pbsschoolbatendyrreport.fngetBatEndYearSchool(schoolID, schoolyR).Question45
        lblBATQuestion46.Text = C21MIT.PBSIS.BLL.pbslbat.pbsschoolbatendyrreport.fngetBatEndYearSchool(schoolID, schoolyR).Question46
        lblBATQuestion47.Text = C21MIT.PBSIS.BLL.pbslbat.pbsschoolbatendyrreport.fngetBatEndYearSchool(schoolID, schoolyR).Question47
        lblBATQuestion48.Text = C21MIT.PBSIS.BLL.pbslbat.pbsschoolbatendyrreport.fngetBatEndYearSchool(schoolID, schoolyR).Question48
        lblBATQuestion49.Text = C21MIT.PBSIS.BLL.pbslbat.pbsschoolbatendyrreport.fngetBatEndYearSchool(schoolID, schoolyR).Question49
        lblBATQuestion50.Text = C21MIT.PBSIS.BLL.pbslbat.pbsschoolbatendyrreport.fngetBatEndYearSchool(schoolID, schoolyR).Question50

        lblBATQuestion51.Text = C21MIT.PBSIS.BLL.pbslbat.pbsschoolbatendyrreport.fngetBatEndYearSchool(schoolID, schoolyR).Question51
        lblBATQuestion52.Text = C21MIT.PBSIS.BLL.pbslbat.pbsschoolbatendyrreport.fngetBatEndYearSchool(schoolID, schoolyR).Question52
        lblBATQuestion53.Text = C21MIT.PBSIS.BLL.pbslbat.pbsschoolbatendyrreport.fngetBatEndYearSchool(schoolID, schoolyR).Question53
        lblBATQuestion54.Text = C21MIT.PBSIS.BLL.pbslbat.pbsschoolbatendyrreport.fngetBatEndYearSchool(schoolID, schoolyR).Question54
        lblBATQuestion55.Text = C21MIT.PBSIS.BLL.pbslbat.pbsschoolbatendyrreport.fngetBatEndYearSchool(schoolID, schoolyR).Question55
        lblBATQuestion56.Text = C21MIT.PBSIS.BLL.pbslbat.pbsschoolbatendyrreport.fngetBatEndYearSchool(schoolID, schoolyR).Question56
        'lblbatQuestion57.Text = C21MIT.PBSIS.BLL.pbsschoolbat.pbslbat.pbsschoolbatendyrreport.fngetbatEndYearSchool(schoolID, schoolyR).Question57
        'lblbatQuestion58.Text = C21MIT.PBSIS.BLL.pbsschoolbat.pbslbat.pbsschoolbatendyrreport.fngetbatEndYearSchool(schoolID, schoolyR).Question58
        'lblbatQuestion59.Text = C21MIT.PBSIS.BLL.pbsschoolbat.pbslbat.pbsschoolbatendyrreport.fngetbatEndYearSchool(schoolID, schoolyR).Question59
        'lblbatQuestion60.Text = C21MIT.PBSIS.BLL.pbsschoolbat.pbslbat.pbsschoolbatendyrreport.fngetbatEndYearSchool(schoolID, schoolyR).Question60

        Dim i As Integer
        Dim count As Integer = 0

        For i = 1 To 56
            Dim labelcontrol As Label = C21MIT.PBSIS.BLL.pbsfindcontroliterative.FindControlIterative(Me, "lblBATQuestion" & i)
            Dim labelval As String = labelcontrol.Text
            count = count + CInt(labelval)
        Next

        lblBATTotalScore.Text = count
    End Sub

    Protected Sub ddlYear_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddlYear.SelectedIndexChanged
        Dim objbat As New C21MIT.PBSIS.BO.pbsdemodata
        If Not CStr(C21MIT.PBSIS.BLL.pbslogindetails.GetCurrentPrimTracker.v_actid) Is Nothing Then
            If Not CStr(Session("sRptSchID")) Is Nothing Then
                objbat.SchoolID = CStr(Session("sRptSchID"))
            ElseIf Not Request.QueryString("sRptSchID") Is Nothing Then
                objbat.SchoolID = C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("sRptSchID"))
            Else
                objbat.SchoolID = C21MIT.PBSIS.BLL.pbslogindetails.GetCurrentPrimTracker.v_actid
            End If
        End If

        binddata(objbat.SchoolID, ddlYear.SelectedItem.Value)
    End Sub

    Protected Sub Page_LoadComplete(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.LoadComplete
        Session("sRptSchID") = Nothing
        Session("SchYrId") = Nothing
    End Sub
End Class
