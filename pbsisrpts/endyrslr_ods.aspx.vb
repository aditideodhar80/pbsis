'-------------------------------------------------------------------------------------------------------------------
' Created By : Aditi Deodhar
' Created Dt : March 03,2010
' Last Updated Dt : March 30,2010
'-------------------------------------------------------------------------------------------------------------------
Partial Class pbsisrpts_endyrslr_ods
    Inherits System.Web.UI.Page
    Dim objODS As New C21MIT.PBSIS.BO.pbsods

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then

            C21MIT.PBSIS.BLL.pbsloginsession.chkloginsession("schrpt")

            If Not CStr(C21MIT.PBSIS.BLL.pbslogindetails.GetCurrentPrimTracker.v_actid) Is Nothing Then
                If Not CStr(Session("sRptSchID")) Is Nothing Then
                    objODS.SchoolID = CStr(Session("sRptSchID"))
                ElseIf Not Request.QueryString("sRptSchID") Is Nothing Then
                    objODS.SchoolID = C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("sRptSchID"))
                Else
                    objODS.SchoolID = C21MIT.PBSIS.BLL.pbslogindetails.GetCurrentPrimTracker.v_actid
                End If
            End If

            If Not Session("SchYrId") Is Nothing Then
                objODS.SchoolYear = Session("SchYrId")
            Else
                If Not CStr(C21MIT.PBSIS.BLL.pbslogindetails.GetCurrentPrimTracker.schoolyear) Is Nothing Then
                    objODS.SchoolYear = C21MIT.PBSIS.BLL.pbslogindetails.GetCurrentPrimTracker.schoolyear
                End If
            End If


            binddata(objODS.SchoolID, objODS.SchoolYear)
            bindropdown(objODS.SchoolYear)
            If Session("accttype") = "District" Or Session("accttype") = "FMHI" Then
                hylViewDocs.Text = "View Documents"
            Else
                hylViewDocs.Text = "View / Upload Documents"
            End If
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
        lblSchoolName.Text = C21MIT.PBSIS.BLL.pbsods.fngetODSEndYearSchool(schoolID, schoolyR).SchoolName
        lblSchDistrict.Text = C21MIT.PBSIS.BLL.pbsods.fngetODSEndYearSchool(schoolID, schoolyR).DistrictName
 
        lblOdTotalSchoolDays.Text = C21MIT.PBSIS.BLL.pbsods.fngetODSEndYearSchool(schoolID, schoolyR).OdTotalSchoolDays
        lblOdAvgDailyAttendance.Text = C21MIT.PBSIS.BLL.pbsods.fngetODSEndYearSchool(schoolID, schoolyR).OdAvgDailyAttendance

        lblOdTotalOfficeReferrals.Text = C21MIT.PBSIS.BLL.pbsods.fngetODSEndYearSchool(schoolID, schoolyR).OdTotalOfficeReferrals
        lblOdTotalISSDays.Text = C21MIT.PBSIS.BLL.pbsods.fngetODSEndYearSchool(schoolID, schoolyR).OdTotalISSDays
        lblOdTotalOSSDays.Text = C21MIT.PBSIS.BLL.pbsods.fngetODSEndYearSchool(schoolID, schoolyR).OdTotalOSSDays

        If C21MIT.PBSIS.BLL.pbsods.fngetODSEndYearSchool(schoolID, schoolyR).OdProgMonTarget = 1 Then
            lblOdProgMonTarg.Text = "Yes"
        ElseIf C21MIT.PBSIS.BLL.pbsods.fngetODSEndYearSchool(schoolID, schoolyR).OdProgMonTarget = 0 Then
            lblOdProgMonTarg.Text = "No"
        End If

        If C21MIT.PBSIS.BLL.pbsods.fngetODSEndYearSchool(schoolID, schoolyR).OdProgMonIndiv = 1 Then
            lblOdProgMonInd.Text = "Yes"
        ElseIf C21MIT.PBSIS.BLL.pbsods.fngetODSEndYearSchool(schoolID, schoolyR).OdProgMonIndiv = 0 Then
            lblOdProgMonInd.Text = "No"
        End If

        lblOdProgMonTargDesc.Text = C21MIT.PBSIS.BLL.pbsods.fngetODSEndYearSchool(schoolID, schoolyR).OdProgMonTargDesc
        lblOdProgMonIndDesc.Text = C21MIT.PBSIS.BLL.pbsods.fngetODSEndYearSchool(schoolID, schoolyR).OdProgMonIndDesc
    End Sub

    Protected Sub hylViewDocs_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles hylViewDocs.Click
        If Not Request.QueryString("sRptSchID") Is Nothing Then
            objODS.SchoolID = C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("sRptSchID"))
            Response.Redirect("~/school/school_ODS_Upload.aspx?P=Edit&sRptSchID=" & C21MIT.PBSIS.BLL.pbsencryption.getEncryptedQString(objODS.SchoolID) & "&Yr=" & C21MIT.PBSIS.BLL.pbsencryption.getEncryptedQString(ddlYear.SelectedItem.Value) & "")
        Else
            Response.Redirect("~/school/school_ODS_Upload.aspx?P=Edit&Yr=" & C21MIT.PBSIS.BLL.pbsencryption.getEncryptedQString(ddlYear.SelectedItem.Value) & "")
        End If
    End Sub

    Protected Sub ddlYear_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddlYear.SelectedIndexChanged

        If Not CStr(C21MIT.PBSIS.BLL.pbslogindetails.GetCurrentPrimTracker.v_actid) Is Nothing Then
            If Not CStr(Session("sRptSchID")) Is Nothing Then
                objODS.SchoolID = CStr(Session("sRptSchID"))
            ElseIf Not Request.QueryString("sRptSchID") Is Nothing Then
                objODS.SchoolID = C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("sRptSchID"))
            Else
                objODS.SchoolID = C21MIT.PBSIS.BLL.pbslogindetails.GetCurrentPrimTracker.v_actid
            End If
        End If

        binddata(objODS.SchoolID, ddlYear.SelectedItem.Value)
    End Sub

    Protected Sub Page_LoadComplete(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.LoadComplete
        Session("sRptSchID") = Nothing
        Session("SchYrId") = Nothing
    End Sub
End Class
