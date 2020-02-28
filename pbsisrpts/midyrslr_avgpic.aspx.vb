'-------------------------------------------------------------------------------------------------------------------
' Created By : Aditi Deodhar
' Created Dt : Feb 08,2010
' Last Updated Dt : May 13,2010
'-------------------------------------------------------------------------------------------------------------------
Partial Class pbsisrpts_midyrslr_avgpic
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            Dim objPIC As New C21MIT.PBSIS.BO.pbsschoolreport

            C21MIT.PBSIS.BLL.pbsloginsession.chkloginsession("schrpt")

            If Not CStr(C21MIT.PBSIS.BLL.pbslogindetails.GetCurrentPrimTracker.v_actid) Is Nothing Then
                If Not CStr(Session("sRptSchID")) Is Nothing Then
                    objPIC.SchoolID = CStr(Session("sRptSchID"))
                ElseIf Not Request.QueryString("sRptSchID") Is Nothing Then
                    objPIC.SchoolID = C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("sRptSchID"))
                Else
                    objPIC.SchoolID = C21MIT.PBSIS.BLL.pbslogindetails.GetCurrentPrimTracker.v_actid
                End If
            End If

            If Not Session("SchYrId") Is Nothing Then
                objPIC.SchoolYear = Session("SchYrId")
            Else
                If Not CStr(C21MIT.PBSIS.BLL.pbslogindetails.GetCurrentPrimTracker.schoolyear) Is Nothing Then
                    objPIC.SchoolYear = C21MIT.PBSIS.BLL.pbslogindetails.GetCurrentPrimTracker.schoolyear
                End If
            End If


            If Not Request.QueryString("PICTerm") Is Nothing Then
                objPIC.Interval = C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("PICTerm"))
            Else
                objPIC.Interval = Session("PICTerm")
            End If

            binddata(objPIC.SchoolID, objPIC.SchoolYear, objPIC.Interval)
            bindropdown(objPIC.SchoolYear)
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

    Sub binddata(ByVal schoolID As String, ByVal schoolyR As Integer, ByVal schoolInterval As Integer)
        lblSchoolName.Text = C21MIT.PBSIS.BLL.pbsschoolpicmidyrreport.fngetPICMidYearSchool(schoolID, schoolyR, schoolInterval).SchoolName
        lblDistrictName.Text = C21MIT.PBSIS.BLL.pbsschoolpicmidyrreport.fngetPICMidYearSchool(schoolID, schoolyR, schoolInterval).DistrictName
        lblCoachName.Text = C21MIT.PBSIS.BLL.pbsschoolpicmidyrreport.fngetPICMidYearSchool(schoolID, schoolyR, schoolInterval).CoachName
        lblPicQuestion1.Text = C21MIT.PBSIS.BLL.pbsschoolpicmidyrreport.fngetPICMidYearSchool(schoolID, schoolyR, schoolInterval).Question1
        lblPicQuestion2.Text = C21MIT.PBSIS.BLL.pbsschoolpicmidyrreport.fngetPICMidYearSchool(schoolID, schoolyR, schoolInterval).Question2
        lblPicQuestion3.Text = C21MIT.PBSIS.BLL.pbsschoolpicmidyrreport.fngetPICMidYearSchool(schoolID, schoolyR, schoolInterval).Question3
        lblPicQuestion4.Text = C21MIT.PBSIS.BLL.pbsschoolpicmidyrreport.fngetPICMidYearSchool(schoolID, schoolyR, schoolInterval).Question4
        lblPicQuestion5.Text = C21MIT.PBSIS.BLL.pbsschoolpicmidyrreport.fngetPICMidYearSchool(schoolID, schoolyR, schoolInterval).Question5
        lblPicQuestion6.Text = C21MIT.PBSIS.BLL.pbsschoolpicmidyrreport.fngetPICMidYearSchool(schoolID, schoolyR, schoolInterval).Question6
        lblPicQuestion7.Text = C21MIT.PBSIS.BLL.pbsschoolpicmidyrreport.fngetPICMidYearSchool(schoolID, schoolyR, schoolInterval).Question7
        lblPicQuestion8.Text = C21MIT.PBSIS.BLL.pbsschoolpicmidyrreport.fngetPICMidYearSchool(schoolID, schoolyR, schoolInterval).Question8
        lblPicQuestion9.Text = C21MIT.PBSIS.BLL.pbsschoolpicmidyrreport.fngetPICMidYearSchool(schoolID, schoolyR, schoolInterval).Question9
        lblPicQuestion10.Text = C21MIT.PBSIS.BLL.pbsschoolpicmidyrreport.fngetPICMidYearSchool(schoolID, schoolyR, schoolInterval).Question10

        lblPicQuestion11.Text = C21MIT.PBSIS.BLL.pbsschoolpicmidyrreport.fngetPICMidYearSchool(schoolID, schoolyR, schoolInterval).Question11
        lblPicQuestion12.Text = C21MIT.PBSIS.BLL.pbsschoolpicmidyrreport.fngetPICMidYearSchool(schoolID, schoolyR, schoolInterval).Question12
        lblPicQuestion13.Text = C21MIT.PBSIS.BLL.pbsschoolpicmidyrreport.fngetPICMidYearSchool(schoolID, schoolyR, schoolInterval).Question13
        lblPicQuestion14.Text = C21MIT.PBSIS.BLL.pbsschoolpicmidyrreport.fngetPICMidYearSchool(schoolID, schoolyR, schoolInterval).Question14
        lblPicQuestion15.Text = C21MIT.PBSIS.BLL.pbsschoolpicmidyrreport.fngetPICMidYearSchool(schoolID, schoolyR, schoolInterval).Question15
        lblPicQuestion16.Text = C21MIT.PBSIS.BLL.pbsschoolpicmidyrreport.fngetPICMidYearSchool(schoolID, schoolyR, schoolInterval).Question16
        lblPicQuestion17.Text = C21MIT.PBSIS.BLL.pbsschoolpicmidyrreport.fngetPICMidYearSchool(schoolID, schoolyR, schoolInterval).Question17
        lblPicQuestion18.Text = C21MIT.PBSIS.BLL.pbsschoolpicmidyrreport.fngetPICMidYearSchool(schoolID, schoolyR, schoolInterval).Question18
        lblPicQuestion19.Text = C21MIT.PBSIS.BLL.pbsschoolpicmidyrreport.fngetPICMidYearSchool(schoolID, schoolyR, schoolInterval).Question19
        lblPicQuestion20.Text = C21MIT.PBSIS.BLL.pbsschoolpicmidyrreport.fngetPICMidYearSchool(schoolID, schoolyR, schoolInterval).Question20


        lblPicQuestion21.Text = C21MIT.PBSIS.BLL.pbsschoolpicmidyrreport.fngetPICMidYearSchool(schoolID, schoolyR, schoolInterval).Question21
        lblPicQuestion22.Text = C21MIT.PBSIS.BLL.pbsschoolpicmidyrreport.fngetPICMidYearSchool(schoolID, schoolyR, schoolInterval).Question22
        lblPicQuestion23.Text = C21MIT.PBSIS.BLL.pbsschoolpicmidyrreport.fngetPICMidYearSchool(schoolID, schoolyR, schoolInterval).Question23
        lblPicQuestion24.Text = C21MIT.PBSIS.BLL.pbsschoolpicmidyrreport.fngetPICMidYearSchool(schoolID, schoolyR, schoolInterval).Question24
        lblPicQuestion25.Text = C21MIT.PBSIS.BLL.pbsschoolpicmidyrreport.fngetPICMidYearSchool(schoolID, schoolyR, schoolInterval).Question25
        lblPicQuestion26.Text = C21MIT.PBSIS.BLL.pbsschoolpicmidyrreport.fngetPICMidYearSchool(schoolID, schoolyR, schoolInterval).Question26
        lblPicQuestion27.Text = C21MIT.PBSIS.BLL.pbsschoolpicmidyrreport.fngetPICMidYearSchool(schoolID, schoolyR, schoolInterval).Question27
        lblPicQuestion28.Text = C21MIT.PBSIS.BLL.pbsschoolpicmidyrreport.fngetPICMidYearSchool(schoolID, schoolyR, schoolInterval).Question28
        lblPicQuestion29.Text = C21MIT.PBSIS.BLL.pbsschoolpicmidyrreport.fngetPICMidYearSchool(schoolID, schoolyR, schoolInterval).Question29
        lblPicQuestion30.Text = C21MIT.PBSIS.BLL.pbsschoolpicmidyrreport.fngetPICMidYearSchool(schoolID, schoolyR, schoolInterval).Question30

        lblPicQuestion31.Text = C21MIT.PBSIS.BLL.pbsschoolpicmidyrreport.fngetPICMidYearSchool(schoolID, schoolyR, schoolInterval).Question31
        lblPicQuestion32.Text = C21MIT.PBSIS.BLL.pbsschoolpicmidyrreport.fngetPICMidYearSchool(schoolID, schoolyR, schoolInterval).Question32
        lblPicQuestion33.Text = C21MIT.PBSIS.BLL.pbsschoolpicmidyrreport.fngetPICMidYearSchool(schoolID, schoolyR, schoolInterval).Question33
        lblPicQuestion34.Text = C21MIT.PBSIS.BLL.pbsschoolpicmidyrreport.fngetPICMidYearSchool(schoolID, schoolyR, schoolInterval).Question34
        lblPicQuestion35.Text = C21MIT.PBSIS.BLL.pbsschoolpicmidyrreport.fngetPICMidYearSchool(schoolID, schoolyR, schoolInterval).Question35
        lblPicQuestion36.Text = C21MIT.PBSIS.BLL.pbsschoolpicmidyrreport.fngetPICMidYearSchool(schoolID, schoolyR, schoolInterval).Question36
        lblPicQuestion37.Text = C21MIT.PBSIS.BLL.pbsschoolpicmidyrreport.fngetPICMidYearSchool(schoolID, schoolyR, schoolInterval).Question37
        lblPicQuestion38.Text = C21MIT.PBSIS.BLL.pbsschoolpicmidyrreport.fngetPICMidYearSchool(schoolID, schoolyR, schoolInterval).Question38
        lblPicQuestion39.Text = C21MIT.PBSIS.BLL.pbsschoolpicmidyrreport.fngetPICMidYearSchool(schoolID, schoolyR, schoolInterval).Question39
        lblPicQuestion40.Text = C21MIT.PBSIS.BLL.pbsschoolpicmidyrreport.fngetPICMidYearSchool(schoolID, schoolyR, schoolInterval).Question40

        lblPicQuestion41.Text = C21MIT.PBSIS.BLL.pbsschoolpicmidyrreport.fngetPICMidYearSchool(schoolID, schoolyR, schoolInterval).Question41
        lblPicQuestion42.Text = C21MIT.PBSIS.BLL.pbsschoolpicmidyrreport.fngetPICMidYearSchool(schoolID, schoolyR, schoolInterval).Question42
        lblPicQuestion43.Text = C21MIT.PBSIS.BLL.pbsschoolpicmidyrreport.fngetPICMidYearSchool(schoolID, schoolyR, schoolInterval).Question43
        lblPicQuestion44.Text = C21MIT.PBSIS.BLL.pbsschoolpicmidyrreport.fngetPICMidYearSchool(schoolID, schoolyR, schoolInterval).Question44

        Dim i As Integer
        Dim count As Integer = 0

        For i = 1 To 44
            Dim labelcontrol As Label = C21MIT.PBSIS.BLL.pbsfindcontroliterative.FindControlIterative(Me, "lblPicQuestion" & i)
            Dim labelval As String = labelcontrol.Text
            count = count + CInt(labelval)
        Next

        lblPicQuestionTotalScore.Text = count
    End Sub

    Protected Sub Page_LoadComplete(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.LoadComplete
        Session("sRptSchID") = Nothing
        Session("SchYrId") = Nothing
    End Sub

    Protected Sub ddlYear_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddlYear.SelectedIndexChanged
        Dim objPIC As New C21MIT.PBSIS.BO.pbsschoolreport
        If Not CStr(C21MIT.PBSIS.BLL.pbslogindetails.GetCurrentPrimTracker.v_actid) Is Nothing Then
            If Not CStr(Session("sRptSchID")) Is Nothing Then
                objPIC.SchoolID = CStr(Session("sRptSchID"))
            ElseIf Not Request.QueryString("sRptSchID") Is Nothing Then
                objPIC.SchoolID = C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("sRptSchID"))
            Else
                objPIC.SchoolID = C21MIT.PBSIS.BLL.pbslogindetails.GetCurrentPrimTracker.v_actid
            End If
        End If

        If Not Request.QueryString("PICTerm") Is Nothing Then
            objPIC.Interval = C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("PICTerm"))
        Else
            objPIC.Interval = Session("PICTerm")
        End If
        binddata(objPIC.SchoolID, ddlYear.SelectedItem.Value, objPIC.Interval)
    End Sub
End Class
