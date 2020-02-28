'-------------------------------------------------------------------------------------------------------------------
' Created By : Aditi Deodhar
' Created Dt : Feb 04,2010
' Last Updated Dt : Feb 04,2010
'-------------------------------------------------------------------------------------------------------------------
Partial Class school_school_dentryview
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        C21MIT.PBSIS.BLL.pbsloginsession.chkloginsession("School")

        'Stored Procedure code to bring in all pertinent variables for link access
        binddataentrylinks(Session("MM_Username"))
    End Sub

    Sub binddataentrylinks(ByVal sUserName As String)
        Dim acadyear As Integer
        acadyear = Session("ActYrId")

        lblSchoolName.Text = C21MIT.PBSIS.BLL.pbsschoolprofile.getschoolprofile(sUserName).SchoolName

        'Basline implementation
        lblBIStatus.Text = C21MIT.PBSIS.BLL.pbsnavigate.navigateurl(sUserName, acadyear, C21MIT.PBSIS.BLL.pbsschooldataentrylinks.getschooldataentrylinks(sUserName, acadyear).FinBI, C21MIT.PBSIS.BLL.pbsschooldataentrylinks.getschooldataentrylinks(sUserName, acadyear).AvailBI, "BI").NavigationStatus
        hylBILink.Text = C21MIT.PBSIS.BLL.pbsnavigate.navigateurl(sUserName, acadyear, C21MIT.PBSIS.BLL.pbsschooldataentrylinks.getschooldataentrylinks(sUserName, acadyear).FinBI, C21MIT.PBSIS.BLL.pbsschooldataentrylinks.getschooldataentrylinks(sUserName, acadyear).AvailBI, "BI").NavigationText
        hylBILink.NavigateUrl = C21MIT.PBSIS.BLL.pbsnavigate.navigateurl(sUserName, acadyear, C21MIT.PBSIS.BLL.pbsschooldataentrylinks.getschooldataentrylinks(sUserName, acadyear).FinBI, C21MIT.PBSIS.BLL.pbsschooldataentrylinks.getschooldataentrylinks(sUserName, acadyear).AvailBI, "BI").NavigationLink

        'School Demographic Data bind
        lblSProStatus.Text = C21MIT.PBSIS.BLL.pbsnavigate.navigateurl(sUserName, acadyear, C21MIT.PBSIS.BLL.pbsschooldataentrylinks.getschooldataentrylinks(sUserName, acadyear).FinSchoolDemoData, C21MIT.PBSIS.BLL.pbsschooldataentrylinks.getschooldataentrylinks(sUserName, acadyear).AvailSchoolDemoData, "SchDemoData").NavigationStatus
        hylSProLink.Text = C21MIT.PBSIS.BLL.pbsnavigate.navigateurl(sUserName, acadyear, C21MIT.PBSIS.BLL.pbsschooldataentrylinks.getschooldataentrylinks(sUserName, acadyear).FinSchoolDemoData, C21MIT.PBSIS.BLL.pbsschooldataentrylinks.getschooldataentrylinks(sUserName, acadyear).AvailSchoolDemoData, "SchDemoData").NavigationText
        hylSProLink.NavigateUrl = C21MIT.PBSIS.BLL.pbsnavigate.navigateurl(sUserName, acadyear, C21MIT.PBSIS.BLL.pbsschooldataentrylinks.getschooldataentrylinks(sUserName, acadyear).FinSchoolDemoData, C21MIT.PBSIS.BLL.pbsschooldataentrylinks.getschooldataentrylinks(sUserName, acadyear).AvailSchoolDemoData, "SchDemoData").NavigationLink

        'PBS Implementation Checklist - Fall bind
        lblPBSImpFallStatus.Text = C21MIT.PBSIS.BLL.pbsnavigate.navigateurl(sUserName, acadyear, C21MIT.PBSIS.BLL.pbsschooldataentrylinks.getschooldataentrylinks(sUserName, acadyear).FinPICFall, C21MIT.PBSIS.BLL.pbsschooldataentrylinks.getschooldataentrylinks(sUserName, acadyear).AvailPICFall, "PICFall").NavigationStatus
        hylPBSChecklistFallLink.Text = C21MIT.PBSIS.BLL.pbsnavigate.navigateurl(sUserName, acadyear, C21MIT.PBSIS.BLL.pbsschooldataentrylinks.getschooldataentrylinks(sUserName, acadyear).FinPICFall, C21MIT.PBSIS.BLL.pbsschooldataentrylinks.getschooldataentrylinks(sUserName, acadyear).AvailPICFall, "PICFall").NavigationText
        hylPBSChecklistFallLink.NavigateUrl = C21MIT.PBSIS.BLL.pbsnavigate.navigateurl(sUserName, acadyear, C21MIT.PBSIS.BLL.pbsschooldataentrylinks.getschooldataentrylinks(sUserName, acadyear).FinPICFall, C21MIT.PBSIS.BLL.pbsschooldataentrylinks.getschooldataentrylinks(sUserName, acadyear).AvailPICFall, "PICFall").NavigationLink

        'PBS Implementation Checklist - Spring bind
        lblPBSImpSpringStatus.Text = C21MIT.PBSIS.BLL.pbsnavigate.navigateurl(sUserName, acadyear, C21MIT.PBSIS.BLL.pbsschooldataentrylinks.getschooldataentrylinks(sUserName, acadyear).FinPICSpring, C21MIT.PBSIS.BLL.pbsschooldataentrylinks.getschooldataentrylinks(sUserName, acadyear).AvailPICSpring, "PICSpring").NavigationStatus
        hylPBSChecklistSpringLink.Text = C21MIT.PBSIS.BLL.pbsnavigate.navigateurl(sUserName, acadyear, C21MIT.PBSIS.BLL.pbsschooldataentrylinks.getschooldataentrylinks(sUserName, acadyear).FinPICSpring, C21MIT.PBSIS.BLL.pbsschooldataentrylinks.getschooldataentrylinks(sUserName, acadyear).AvailPICSpring, "PICSpring").NavigationText
        hylPBSChecklistSpringLink.NavigateUrl = C21MIT.PBSIS.BLL.pbsnavigate.navigateurl(sUserName, acadyear, C21MIT.PBSIS.BLL.pbsschooldataentrylinks.getschooldataentrylinks(sUserName, acadyear).FinPICSpring, C21MIT.PBSIS.BLL.pbsschooldataentrylinks.getschooldataentrylinks(sUserName, acadyear).AvailPICSpring, "PICSpring").NavigationLink

        'BOQ bind
        lblBOQStatus.Text = C21MIT.PBSIS.BLL.pbsnavigate.navigateurl(sUserName, acadyear, C21MIT.PBSIS.BLL.pbsschooldataentrylinks.getschooldataentrylinks(sUserName, acadyear).FinBOQ, C21MIT.PBSIS.BLL.pbsschooldataentrylinks.getschooldataentrylinks(sUserName, acadyear).AvailBOQ, "BOQ").NavigationStatus
        hylBOQLink.Text = C21MIT.PBSIS.BLL.pbsnavigate.navigateurl(sUserName, acadyear, C21MIT.PBSIS.BLL.pbsschooldataentrylinks.getschooldataentrylinks(sUserName, acadyear).FinBOQ, C21MIT.PBSIS.BLL.pbsschooldataentrylinks.getschooldataentrylinks(sUserName, acadyear).AvailBOQ, "BOQ").NavigationText
        hylBOQLink.NavigateUrl = C21MIT.PBSIS.BLL.pbsnavigate.navigateurl(sUserName, acadyear, C21MIT.PBSIS.BLL.pbsschooldataentrylinks.getschooldataentrylinks(sUserName, acadyear).FinBOQ, C21MIT.PBSIS.BLL.pbsschooldataentrylinks.getschooldataentrylinks(sUserName, acadyear).AvailBOQ, "BOQ").NavigationLink

        'ODS bind
        lblODSStatus.Text = C21MIT.PBSIS.BLL.pbsnavigate.navigateurl(sUserName, acadyear, C21MIT.PBSIS.BLL.pbsschooldataentrylinks.getschooldataentrylinks(sUserName, acadyear).FinOutcomeDataSum, C21MIT.PBSIS.BLL.pbsschooldataentrylinks.getschooldataentrylinks(sUserName, acadyear).AvailOutcomeDataSum, "ODS").NavigationStatus
        hylODSLink.Text = C21MIT.PBSIS.BLL.pbsnavigate.navigateurl(sUserName, acadyear, C21MIT.PBSIS.BLL.pbsschooldataentrylinks.getschooldataentrylinks(sUserName, acadyear).FinOutcomeDataSum, C21MIT.PBSIS.BLL.pbsschooldataentrylinks.getschooldataentrylinks(sUserName, acadyear).AvailOutcomeDataSum, "ODS").NavigationText
        hylODSLink.NavigateUrl = C21MIT.PBSIS.BLL.pbsnavigate.navigateurl(sUserName, acadyear, C21MIT.PBSIS.BLL.pbsschooldataentrylinks.getschooldataentrylinks(sUserName, acadyear).FinOutcomeDataSum, C21MIT.PBSIS.BLL.pbsschooldataentrylinks.getschooldataentrylinks(sUserName, acadyear).AvailOutcomeDataSum, "ODS").NavigationLink

        'BAT bind
        lblBATStatus.Text = C21MIT.PBSIS.BLL.pbsnavigate.navigateurl(sUserName, acadyear, C21MIT.PBSIS.BLL.pbsschooldataentrylinks.getschooldataentrylinks(sUserName, acadyear).FinBAT, C21MIT.PBSIS.BLL.pbsschooldataentrylinks.getschooldataentrylinks(sUserName, acadyear).AvailBAT, "BAT").NavigationStatus
        hylBATLink.Text = C21MIT.PBSIS.BLL.pbsnavigate.navigateurl(sUserName, acadyear, C21MIT.PBSIS.BLL.pbsschooldataentrylinks.getschooldataentrylinks(sUserName, acadyear).FinBAT, C21MIT.PBSIS.BLL.pbsschooldataentrylinks.getschooldataentrylinks(sUserName, acadyear).AvailBAT, "BAT").NavigationText
        hylBATLink.NavigateUrl = C21MIT.PBSIS.BLL.pbsnavigate.navigateurl(sUserName, acadyear, C21MIT.PBSIS.BLL.pbsschooldataentrylinks.getschooldataentrylinks(sUserName, acadyear).FinBAT, C21MIT.PBSIS.BLL.pbsschooldataentrylinks.getschooldataentrylinks(sUserName, acadyear).AvailBAT, "BAT").NavigationLink
    End Sub

End Class
