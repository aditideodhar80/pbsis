Imports Microsoft.VisualBasic
Imports C21MIT.PBSIS.BO
Namespace C21MIT.PBSIS.BLL
#Region "FMHI"
    Public Class pbsfmhi
        Shared Sub addfmhischoolprofile(ByVal objfmhischoolprofile As C21MIT.PBSIS.BO.pbsschoolprofile)
            C21MIT.PBSIS.DAL.pbsfmhiaccountprofiles.addfmhischoolprofile(objfmhischoolprofile)
        End Sub
        Shared Sub updatefmhischoolprofile(ByVal objfmhischoolprofile As C21MIT.PBSIS.BO.pbsschoolprofile)
            C21MIT.PBSIS.DAL.pbsfmhiaccountprofiles.updfmhischoolprofile(objfmhischoolprofile)
        End Sub
        Shared Function getfmhischprofile(ByVal schid As String) As C21MIT.PBSIS.BO.pbsschoolprofile
            Return C21MIT.PBSIS.DAL.pbsfmhiaccountprofiles.getfmhischprofile(schid)
        End Function
        Shared Sub addfmhidistprofile(ByVal objfmhidistprofile As C21MIT.PBSIS.BO.pbsdistprofile)
            C21MIT.PBSIS.DAL.pbsfmhiaccountprofiles.addfmhidistprofile(objfmhidistprofile)
        End Sub
        Shared Function getfmhidistprofile(ByVal distid As String) As C21MIT.PBSIS.BO.pbsdistprofile
            Return C21MIT.PBSIS.DAL.pbsfmhiaccountprofiles.getfmhidistprofile(distid)
        End Function
        Shared Sub updatefmhidistprofile(ByVal objfmhidistprofile As C21MIT.PBSIS.BO.pbsdistprofile)
            C21MIT.PBSIS.DAL.pbsfmhiaccountprofiles.updatefmhidistprofile(objfmhidistprofile)
        End Sub
        Shared Sub addfmhidistcoorprofile(ByVal objfmhidistcoordprofile As C21MIT.PBSIS.BO.pbsdistprofile)
            C21MIT.PBSIS.DAL.pbsfmhiaccountprofiles.addfmhidistcoordprofile(objfmhidistcoordprofile)
        End Sub
        Shared Sub addfmhidistcoachprofile(ByVal objfmhidistcoachprofile As C21MIT.PBSIS.BO.pbscoachprofile)
            C21MIT.PBSIS.DAL.pbsfmhiaccountprofiles.addfmhidistcoachprofile(objfmhidistcoachprofile)
        End Sub
        Shared Sub updfmhidistcoorprofile(ByVal objfmhidistcoordprofile As C21MIT.PBSIS.BO.pbsdistprofile)
            C21MIT.PBSIS.DAL.pbsfmhiaccountprofiles.updfmhidistcoordprofile(objfmhidistcoordprofile)
        End Sub
        Shared Function getfmhidistcoorprofile(ByVal distcoordid As String) As C21MIT.PBSIS.BO.pbsdistprofile
            Return C21MIT.PBSIS.DAL.pbsfmhiaccountprofiles.getfmhidistcoordprofile(distcoordid)
        End Function
        Shared Function getfmhidistcoachprofile(ByVal distCoachID As String) As C21MIT.PBSIS.BO.pbscoachprofile
            Return C21MIT.PBSIS.DAL.pbsfmhiaccountprofiles.getfmhidistcoachprofile(distCoachID)
        End Function
        Shared Sub updfmhidistcoachprofile(ByVal objfmhidistcoachprofile As C21MIT.PBSIS.BO.pbscoachprofile)
            C21MIT.PBSIS.DAL.pbsfmhiaccountprofiles.updfmhidistcoachprofile(objfmhidistcoachprofile)
        End Sub

        Shared Sub updfmhidistcoachinactive(ByVal objfmhidistcoachprofile As C21MIT.PBSIS.BO.pbscoachprofile)
            C21MIT.PBSIS.DAL.pbsfmhiaccountprofiles.updfmhidistcoachinactive(objfmhidistcoachprofile)
        End Sub
    End Class
#End Region
#Region "FMHI NAVIGATION"
    Public Class pbsfmhinavigate
        Public Shared Function gefmhidistlist(ByVal strPage As String) As C21MIT.PBSIS.BO.pbsgridviewobj
            Return C21MIT.PBSIS.DAL.pbsfmhireports.getfmhidistlist(strPage)
        End Function
        Public Shared Function gedistlist() As System.Data.DataSet
            Return C21MIT.PBSIS.DAL.pbsfmhireports.getdistlist()
        End Function
        Public Shared Function gefmhischlist(ByVal DistId As String, ByVal strPage As String) As C21MIT.PBSIS.BO.pbsgridviewobj
            Return C21MIT.PBSIS.DAL.pbsfmhireports.getfmhischoollist(DistId, strPage)
        End Function
        Public Shared Function gefmhidistcoordlist(ByVal DistId As String, ByVal strPage As String) As C21MIT.PBSIS.BO.pbsgridviewobj
            Return C21MIT.PBSIS.DAL.pbsfmhireports.getfmhidistcoordlist(DistId, strPage)
        End Function
        Public Shared Function gefmhidistcoachlist(ByVal DistId As String, ByVal strPage As String) As C21MIT.PBSIS.BO.pbsgridviewobj
            Return C21MIT.PBSIS.DAL.pbsfmhireports.getfmhidistcoachlist(DistId, strPage)
        End Function
    End Class
    Public Class pbsclFMHINavigate
        '-------------------------------------------------------------------------------------------------------------------
        ' Function Name : lnkFMHIAdminHome  
        ' Created By : Aditi Deodhar
        ' Created Dt : Feb 25,2010
        ' Last Updated Dt : Feb 25,2010
        '-------------------------------------------------------------------------------------------------------------------
        Public Shared Function lnkFMHIAdminHome(ByVal pFrmID As Integer, ByVal pDistID As String) As pbsnavigatelistobj
            C21MIT.PBSIS.BLL.pbsloginsession.chkloginsession("fmhiadm")

            If pDistID <> "" Then
                System.Web.HttpContext.Current.Session("sDistId") = CStr(System.Web.HttpContext.Current.Request.QueryString("qDistID"))
            End If

            Dim myPbsNavLinks As New C21MIT.PBSIS.BO.pbsnavigatelistobj
            Dim rpttype As Integer
            Dim rptyear As Integer
            Dim pendingFrmLink As String = ""
            Dim viewFrmLink As String = ""

            rpttype = pFrmID
            If System.Web.HttpContext.Current.Session("MM_UserName") = "" Then
                System.Web.HttpContext.Current.Response.Redirect("~/users/smessages.aspx?qModule=InvalidSession", False)
            End If
            rptyear = CInt(System.Web.HttpContext.Current.Session("ActYrId"))
            System.Web.HttpContext.Current.Session("SchYrId") = rptyear
            If rpttype = 1 Then
                '  myPbsNavLinks.NavigationLink = "~/fmhiadmin/fmhi_dist_addupdate.aspx?Status=Update&DistID=" & pDistID & ""
                myPbsNavLinks.NavigationLink = "~/district/schoolaccess_monitoring.aspx?qOptId=MidYearMon&DistId=" & C21MIT.PBSIS.BLL.pbsencryption.getEncryptedQString(pDistID) & ""
            ElseIf rpttype = 2 Then
                myPbsNavLinks.NavigationLink = "~/district/schoolaccess_monitoring.aspx?qOptId=EndYearMon&DistId=" & C21MIT.PBSIS.BLL.pbsencryption.getEncryptedQString(pDistID) & ""
            ElseIf rpttype = 3 Then
                myPbsNavLinks.NavigationLink = "~/district/schoolaccess_monitoring.aspx?qOptID=MidYearSLR&DistId=" & C21MIT.PBSIS.BLL.pbsencryption.getEncryptedQString(pDistID) & ""
            ElseIf rpttype = 4 Then
                myPbsNavLinks.NavigationLink = "~/district/schoolaccess_monitoring.aspx?qOptID=EndYearSLR&DistId=" & C21MIT.PBSIS.BLL.pbsencryption.getEncryptedQString(pDistID) & ""
            ElseIf rpttype = 5 Then
                myPbsNavLinks.NavigationLink = "~/pbsisrpts/midyr_district_dlr.aspx?DistId=" & C21MIT.PBSIS.BLL.pbsencryption.getEncryptedQString(pDistID) & ""
            ElseIf rpttype = 6 Then
                myPbsNavLinks.NavigationLink = "~/pbsisrpts/endyr_district_dlr.aspx?DistId=" & C21MIT.PBSIS.BLL.pbsencryption.getEncryptedQString(pDistID) & ""
            End If
            Return myPbsNavLinks
        End Function
        '-------------------------------------------------------------------------------------------------------------------
        ' Function Name : lnkFMHIDistrictAccount  
        ' Created By : Aditi Deodhar
        ' Created Dt : Feb 25,2010
        ' Last Updated Dt : Feb 25,2010
        '-------------------------------------------------------------------------------------------------------------------
        Public Shared Function lnkFMHIDistrictAccount(ByVal pFrmID As Integer, ByVal pDistID As String) As pbsnavigatelistobj
            C21MIT.PBSIS.BLL.pbsloginsession.chkloginsession("fmhiadm")

            If pDistID <> "" Then
                System.Web.HttpContext.Current.Session("sDistId") = CStr(System.Web.HttpContext.Current.Request.QueryString("qDistID"))
            End If

            Dim myPbsNavLinks As New C21MIT.PBSIS.BO.pbsnavigatelistobj
            Dim rpttype As Integer
            Dim rptyear As Integer

            Dim pendingFrmLink As String = ""
            Dim viewFrmLink As String = ""

            rpttype = pFrmID
            If System.Web.HttpContext.Current.Session("MM_UserName") = "" Then
                System.Web.HttpContext.Current.Response.Redirect("~/users/smessages.aspx?qModule=InvalidSession", False)

            End If

            rptyear = CInt(System.Web.HttpContext.Current.Session("ActYrId"))
            System.Web.HttpContext.Current.Session("SchYrId") = rptyear
            If rpttype = 1 Then
                '  myPbsNavLinks.NavigationLink = "~/fmhiadmin/fmhi_dist_addupdate.aspx?Status=Update&DistID=" & pDistID & ""
                myPbsNavLinks.NavigationLink = "~/fmhiadmin/fmhi_dist_addupdate.aspx?Status=Update&DistID=" & pDistID & ""
            ElseIf rpttype = 2 Then
                myPbsNavLinks.NavigationLink = "~/fmhiadmin/fmhi_schprofilemenu.aspx?Status=Update&DistId=" & pDistID & ""
            ElseIf rpttype = 3 Then
                myPbsNavLinks.NavigationLink = "~/fmhiadmin/fmhi_distcoordprofilemenu.aspx?Status=Update&DistID=" & pDistID & ""
            ElseIf rpttype = 4 Then
                myPbsNavLinks.NavigationLink = "~/fmhiadmin/fmhi_distcoachprofilemenu.aspx?Status=Update&DistID=" & pDistID & ""
            End If

            Return myPbsNavLinks
        End Function
        '-------------------------------------------------------------------------------------------------------------------
        ' Function Name : lnkFMHISchoolAccount  
        ' Created By : Aditi Deodhar
        ' Created Dt : Feb 26,2010
        ' Last Updated Dt : Feb 26,2010
        '-------------------------------------------------------------------------------------------------------------------
        Public Shared Function lnkFMHISchoolAccount(ByVal pFrmID As Integer, ByVal pSchID As String) As pbsnavigatelistobj
            'C21MIT.PBSIS.BLL.pbsloginsession.chkloginsession("fmhiadm")

            Dim myPbsNavLinks As New C21MIT.PBSIS.BO.pbsnavigatelistobj
            Dim rpttype As Integer
            Dim rptyear As Integer

            Dim pendingFrmLink As String = ""
            Dim viewFrmLink As String = ""

            rpttype = pFrmID
            If System.Web.HttpContext.Current.Session("MM_UserName") = "" Then
                System.Web.HttpContext.Current.Response.Redirect("~/users/smessages.aspx?qModule=InvalidSession", False)

            End If

            rptyear = CInt(System.Web.HttpContext.Current.Session("ActYrId"))
            System.Web.HttpContext.Current.Session("SchYrId") = rptyear

            If rpttype = 1 Then
                '  myPbsNavLinks.NavigationLink = "~/fmhiadmin/fmhi_dist_addupdate.aspx?Status=Update&DistID=" & pDistID & ""
                myPbsNavLinks.NavigationLink = "~/fmhiadmin/fmhi_sch_addupdate.aspx?Status=Update&SchID=" & pSchID & ""

            End If

            Return myPbsNavLinks
        End Function
        '-------------------------------------------------------------------------------------------------------------------
        ' Function Name : lnkFMHIDistCoordAccount  
        ' Created By : Aditi Deodhar
        ' Created Dt : Feb 26,2010
        ' Last Updated Dt : Feb 26,2010
        '-------------------------------------------------------------------------------------------------------------------
        Public Shared Function lnkFMHIDistCoordAccount(ByVal pFrmID As Integer, ByVal pDistCoordID As String) As pbsnavigatelistobj
            C21MIT.PBSIS.BLL.pbsloginsession.chkloginsession("fmhiadm")

            Dim myPbsNavLinks As New C21MIT.PBSIS.BO.pbsnavigatelistobj
            Dim rpttype As Integer
            Dim rptyear As Integer

            Dim pendingFrmLink As String = ""
            Dim viewFrmLink As String = ""

            rpttype = pFrmID
            If System.Web.HttpContext.Current.Session("MM_UserName") = "" Then
                System.Web.HttpContext.Current.Response.Redirect("~/users/smessages.aspx?qModule=InvalidSession", False)
            End If
            rptyear = CInt(System.Web.HttpContext.Current.Session("ActYrId"))
            System.Web.HttpContext.Current.Session("SchYrId") = rptyear

            If rpttype = 1 Then
                '  myPbsNavLinks.NavigationLink = "~/fmhiadmin/fmhi_dist_addupdate.aspx?Status=Update&DistID=" & pDistID & ""
                myPbsNavLinks.NavigationLink = "~/fmhiadmin/fmhi_distcoord_addupdate.aspx?Status=Update&DistCoordID=" & pDistCoordID & ""

            End If

            Return myPbsNavLinks
        End Function
        '-------------------------------------------------------------------------------------------------------------------
        ' Function Name : lnkFMHIDistCoachAccount  
        ' Created By : Aditi Deodhar
        ' Created Dt : Feb 26,2010
        ' Last Updated Dt : Feb 26,2010
        '-------------------------------------------------------------------------------------------------------------------
        Public Shared Function lnkFMHIDistCoachAccount(ByVal pFrmID As Integer, ByVal pDistCoordID As String) As pbsnavigatelistobj
            ' C21MIT.PBSIS.BLL.pbsloginsession.chkloginsession("fmhiadm")

            Dim myPbsNavLinks As New C21MIT.PBSIS.BO.pbsnavigatelistobj
            Dim rpttype As Integer
            Dim rptyear As Integer

            Dim pendingFrmLink As String = ""
            Dim viewFrmLink As String = ""

            rpttype = pFrmID
            If System.Web.HttpContext.Current.Session("MM_UserName") = "" Then
                System.Web.HttpContext.Current.Response.Redirect("~/users/smessages.aspx?qModule=InvalidSession", False)
            End If
            rptyear = CInt(System.Web.HttpContext.Current.Session("ActYrId"))
            System.Web.HttpContext.Current.Session("SchYrId") = rptyear

            If rpttype = 1 Then
                '  myPbsNavLinks.NavigationLink = "~/fmhiadmin/fmhi_dist_addupdate.aspx?Status=Update&DistID=" & pDistID & ""
                myPbsNavLinks.NavigationLink = "~/fmhiadmin/fmhi_distcoaches_addupdate.aspx?Status=Update&DistCoachID=" & pDistCoordID & ""

            End If

            Return myPbsNavLinks
        End Function
    End Class
#End Region
#Region "FMHI FORM ACTIVATION/DEACTIVATION"
    Public Class pbsfmhiformactivation
        Shared Function getfmhiformactivation() As C21MIT.PBSIS.BO.pbsschooldataentrylinks
            Return C21MIT.PBSIS.DAL.pbsfmhiaccountprofiles.getfmhiformactivation()
        End Function

        Shared Sub updatefmhiformactivation(ByVal objformactivation As C21MIT.PBSIS.BO.pbsschooldataentrylinks)
            C21MIT.PBSIS.DAL.pbsfmhiaccountprofiles.updatefmhiformactivation(objformactivation)
        End Sub

        Shared Function getfmhiformactivationyrlist() As System.Data.DataSet
            Return C21MIT.PBSIS.DAL.pbsfmhiaccountprofiles.getfmhiformactivationyrlist()
        End Function

        Shared Sub updatefmhiformYractivation(ByVal SchYear As Integer)
            C21MIT.PBSIS.DAL.pbsfmhiaccountprofiles.updatefmhiformYractivation(SchYear)
        End Sub
    End Class
#End Region
#Region "Dist Accounts Update"
    Public Class pbsdistaccountupdate
        Public Shared Function gedistupdatelist(ByVal strPage As String) As C21MIT.PBSIS.BO.pbsgridviewobj
            Return C21MIT.PBSIS.DAL.pbsfmhireports.getfmhidistlist(strPage)
        End Function
    End Class
#End Region
End Namespace