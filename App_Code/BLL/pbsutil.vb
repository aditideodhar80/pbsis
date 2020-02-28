Imports Microsoft.VisualBasic
Imports C21MIT.PBSIS.BO
Namespace C21MIT.PBSIS.BLL
#Region "School Login"
    Public Class pbsloginsession
        Shared Sub chkloginsession(ByVal pblogintype As String)
            If System.Web.HttpContext.Current.Session("MM_Username") = "" Then
                System.Web.HttpContext.Current.Response.Redirect _
                                               ("~/users/smessages.aspx?qModule=InvalidSession")
            Else
                If pblogintype = "dist" Then
                    If Not ((System.Web.HttpContext.Current.Session("sRptAuth") = "aD") Or (System.Web.HttpContext.Current.Session("sRptAuth") = "aF")) Then
                        System.Web.HttpContext.Current.Response.Redirect _
                                              ("~/users/smessages.aspx?qModule=InvalidSession")
                    End If
                ElseIf pblogintype = "school" Then
                    If Not (System.Web.HttpContext.Current.Session("sRptAuth") = "aS") Then
                        System.Web.HttpContext.Current.Response.Redirect _
                                             ("~/users/smessages.aspx?qModule=InvalidSession")
                    End If
                ElseIf pblogintype = "fmhiadm" Then
                    If Not (System.Web.HttpContext.Current.Session("sRptAuth") = "aF") Then
                        System.Web.HttpContext.Current.Response.Redirect _
                                             ("~/users/smessages.aspx?qModule=InvalidSession")
                    End If
                ElseIf pblogintype = "schrpt" Then
                    If System.Web.HttpContext.Current.Session("sRptSchID") Is DBNull.Value Then
                        System.Web.HttpContext.Current.Response.Redirect _
                                             ("~/users/smessages.aspx?qModule=InvalidSession")
                    End If
                End If
            End If
        End Sub

        Shared Function fnchkloginsession() As String

            Dim logintype As String = ""
            If System.Web.HttpContext.Current.Session("MM_Username") = "" Then
                System.Web.HttpContext.Current.Response.Redirect _
                                               ("~/users/smessages.aspx?qModule=InvalidSession")
            Else

                If (System.Web.HttpContext.Current.Session("sRptAuth") = "aD") Then
                    logintype = "aD"
                ElseIf (System.Web.HttpContext.Current.Session("sRptAuth") = "aS") Then
                    logintype = "aS"
                ElseIf (System.Web.HttpContext.Current.Session("sRptAuth") = "aF") Then
                    logintype = ("aF")

                End If
            End If

            Return logintype
        End Function

        '' Function to check if the user can create/manage user accounts (8/13/2007)
        Shared Sub chkAdminLevel()
            If System.Web.HttpContext.Current.Session("MM_Username") = "" Then
                System.Web.HttpContext.Current.Response.Redirect _
                                             ("~/users/smessages.aspx?qModule=InvalidSession")
            Else
                If Not ((System.Web.HttpContext.Current.Session("sALevel") = "4")) Then
                    System.Web.HttpContext.Current.Response.Redirect _
                                             ("~/users/smessages.aspx?qModule=InvalidSession")
                End If
            End If
        End Sub
    End Class

    Public Class pbsnavigate
        '-------------------------------------------------------------------------------------------------------------------
        ' Function Name : navigateurl  
        ' Created By : Aditi Deodhar
        ' Created Dt : Feb 04,2010
        ' Last Updated Dt : Feb 04,2010
        '-------------------------------------------------------------------------------------------------------------------
        'Shared Function navigateurl(ByVal sUserName As String, ByVal acadyear As Integer, ByVal frmcompleted As Integer, ByVal frmavailable As Integer, ByVal linkid As String) As C21MIT.PBSIS.BO.pbsnavigate
        Shared Function navigateurl(ByVal sUserName As String, ByVal acadyear As Integer, ByVal frmcompleted As Integer, ByVal frmavailable As Integer, ByVal linkid As String) As C21MIT.PBSIS.BO.pbsnavigatelistobj

            Dim myPbsNavLinks As New C21MIT.PBSIS.BO.pbsnavigatelistobj

            Dim pendingFrmLink As String = ""
            Dim viewFrmLink As String = ""

            If linkid = "BI" Then
                pendingFrmLink = "~/school/school_baseline_Add.aspx"
                viewFrmLink = "~/pbsisrpts/slr_DemoData.aspx"
            ElseIf linkid = "SchDemoData" Then
                pendingFrmLink = "~/school/school_DemoData_Add.aspx"
                viewFrmLink = "~/pbsisrpts/slr_DemoData.aspx"
            ElseIf linkid = "PICFall" Then
                pendingFrmLink = "~/school/school_PIC_Splash.aspx?PICTerm=" & C21MIT.PBSIS.BLL.pbsencryption.getEncryptedQString(1) & ""
                viewFrmLink = "~/pbsisrpts/midyrslr_avgpic.aspx?PICTerm=" & C21MIT.PBSIS.BLL.pbsencryption.getEncryptedQString(1) & ""
                'viewFrmLink = "~/school/school_PIC_Splash.aspx?PICTerm=Fall"
            ElseIf linkid = "PICSpring" Then
                pendingFrmLink = "~/school/school_PIC_Splash.aspx?PICTerm=" & C21MIT.PBSIS.BLL.pbsencryption.getEncryptedQString(2) & ""
                viewFrmLink = "~/pbsisrpts/midyrslr_avgpic.aspx?PICTerm=" & C21MIT.PBSIS.BLL.pbsencryption.getEncryptedQString(2) & ""
            ElseIf linkid = "BOQ" Then
                'pendingFrmLink = "~/school/school_BOQ_Add.aspx"
                pendingFrmLink = "~/school/school_BOQ_Splash.aspx"
                viewFrmLink = "~/pbsisrpts/endyrslr_boq.aspx"
            ElseIf linkid = "ODS" Then
                pendingFrmLink = "~/school/school_ODS_Add.aspx"
                viewFrmLink = "~/pbsisrpts/endyrslr_ods.aspx"
            ElseIf linkid = "BAT" Then
                pendingFrmLink = "~/school/school_BAT_Splash.aspx"
                viewFrmLink = "~/pbsisrpts/endyrslr_BAT.aspx"

            End If


            If frmcompleted > 0 Then
                myPbsNavLinks.NavigationStatus = "Completed -"
                myPbsNavLinks.NavigationText = "View"
                myPbsNavLinks.NavigationLink = viewFrmLink
            Else
                If frmavailable = 1 Then
                    myPbsNavLinks.NavigationStatus = "Pending Submission -"
                    myPbsNavLinks.NavigationText = "Proceed"
                    myPbsNavLinks.NavigationLink = pendingFrmLink
                Else
                    myPbsNavLinks.NavigationStatus = "Not Available"
                End If
            End If

            Return myPbsNavLinks

        End Function

    End Class

    Public Class pbsschoolyeardesc
        '-------------------------------------------------------------------------------------------------------------------
        ' Function Name : getschoolyeardesc  
        ' Created By : Aditi Deodhar
        ' Created Dt : Feb 08,2010
        ' Last Updated Dt : Feb 08,2010
        '-------------------------------------------------------------------------------------------------------------------
        Shared Function getschoolyeardesc(ByVal yrID As Integer) As String

            If yrID = 1 Then
                getschoolyeardesc = "1997-1998"

            ElseIf yrID = 2 Then
                getschoolyeardesc = "1998-1999"

            ElseIf yrID = 3 Then
                getschoolyeardesc = "1999-2000"

            ElseIf yrID = 4 Then
                getschoolyeardesc = "2000-2001"

            ElseIf yrID = 5 Then
                getschoolyeardesc = "2001-2002"

            ElseIf yrID = 6 Then
                getschoolyeardesc = "2002-2003"

            ElseIf yrID = 7 Then
                getschoolyeardesc = "2003-2004"

            ElseIf yrID = 8 Then
                getschoolyeardesc = "2004-2005"

            ElseIf yrID = 9 Then
                getschoolyeardesc = "2005-2006"

            ElseIf yrID = 10 Then
                getschoolyeardesc = "2006-2007"

            ElseIf yrID = 11 Then
                getschoolyeardesc = "2007-2008"

            ElseIf yrID = 12 Then
                getschoolyeardesc = "2008-2009"

            ElseIf yrID = 13 Then
                getschoolyeardesc = "2009-2010"

            ElseIf yrID = 14 Then
                getschoolyeardesc = "2010-2011"

            ElseIf yrID = 15 Then
                getschoolyeardesc = "2011-2012"

            ElseIf yrID = 16 Then
                getschoolyeardesc = "2012-2013"

            Else
                getschoolyeardesc = ""
            End If

        End Function

        Shared Function getSchTypeName(ByVal sID As Integer) As String
            If sID = 0 Then
                getSchTypeName = "PreK"
            ElseIf sID = 1 Then
                getSchTypeName = "Elementary"
            ElseIf sID = 2 Then
                getSchTypeName = "Middle"
            ElseIf sID = 3 Then
                getSchTypeName = "High"
            ElseIf sID = 4 Then
                getSchTypeName = "Alt/Center"
            ElseIf sID = 5 Then
                getSchTypeName = "Other"
            Else
                getSchTypeName = ""
            End If
        End Function
    End Class

    Public Class pbsfindcontroliterative
        '-------------------------------------------------------------------------------------------------------------------
        ' Function Name : FindControlIterative  
        ' Created By : Aditi Deodhar
        ' Created Dt : Feb 08,2010
        ' Last Updated Dt : Feb 08,2010
        ' Description : This function is used to get all the controls with a particular name iteratively.
        '-------------------------------------------------------------------------------------------------------------------
        Public Shared Function FindControlIterative(ByVal myRoot As Control, ByVal myIDOfControlToFind As String) As Control
            Dim myRootControl As Control = New Control
            myRootControl = myRoot
            Dim setOfChildControls As LinkedList(Of Control) = New LinkedList(Of Control)

            Do While (myRootControl IsNot Nothing)
                If myRootControl.ID = myIDOfControlToFind Then
                    Return myRootControl
                End If
                For Each childControl As Control In myRootControl.Controls
                    If childControl.ID = myIDOfControlToFind Then
                        Return childControl
                    End If
                    If childControl.HasControls() Then
                        setOfChildControls.AddLast(childControl)
                    End If
                Next
                myRootControl = setOfChildControls.First.Value
                setOfChildControls.Remove(myRootControl)
            Loop
            Return Nothing
        End Function

    End Class

    Public Class pbsvalidate
        Function checkBlank(ByVal paramValue As String) As String
            Dim tempValue As String

            If paramValue = "" Then
                tempValue = DBNull.Value.ToString
            Else
                tempValue = CInt(paramValue)
            End If

            checkBlank = tempValue
        End Function
    End Class

    Public Class ODSDocuments
        Public Shared Function isDocFile(ByVal v_extension As String) As Boolean

            'To check file extensions
            Dim v_extstr As String
            Dim myarr As Array
            Dim strlocation As Integer

            v_extstr = System.Configuration.ConfigurationManager.AppSettings("docext")
            myarr = v_extstr.Split("|")
            Array.Sort(myarr)

            strlocation = Array.BinarySearch(myarr, v_extension.ToLower)

            If strlocation > 0 Then
                Return True
            Else
                Return False
            End If

        End Function

        Public Shared Function getDocumentFolderPath(ByVal filename As String) As String
            Dim strPath As String = ""

            strPath = getWebFolderRoot() & "\" & System.Configuration.ConfigurationManager.AppSettings("odsdocs") & "\" & filename

            Return strPath
        End Function
        Public Shared Function getWebFolderRoot() As String
            Dim v_basedirlen As Integer

            Dim v_maindir As String

            Dim v_basedir As String

            v_basedir = System.AppDomain.CurrentDomain.BaseDirectory

            v_basedirlen = v_basedir.Length

            v_basedir = v_basedir.Substring(0, v_basedirlen - 1)

            v_basedirlen = v_basedir.LastIndexOf("\")

            v_maindir = v_basedir.Substring(0, v_basedirlen)

            Return v_maindir
        End Function
    End Class
#End Region
#Region "District Login"
    Public Class pbsDistrctNavigate
        '-------------------------------------------------------------------------------------------------------------------
        ' Function Name : lnkDistMonitor  
        ' Created By : Aditi Deodhar
        ' Created Dt : Feb 24,2010
        ' Last Updated Dt : Feb 24,2010
        '-------------------------------------------------------------------------------------------------------------------
        ''' Function to provide links for district monitoring tool
        Public Shared Function lnkDistMonitor(ByVal pFrmID As Integer, ByVal pSchID As String) As pbsnavigatelistobj
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
            If rpttype = 2 Then
                myPbsNavLinks.NavigationLink = "~/pbsisrpts/slr_demodata.aspx?sRptSchID=" & C21MIT.PBSIS.BLL.pbsencryption.getEncryptedQString(pSchID) & ""
            ElseIf rpttype = 19 Then
                myPbsNavLinks.NavigationLink = "~/pbsisrpts/midyrslr_avgpic.aspx?sRptSchID=" & C21MIT.PBSIS.BLL.pbsencryption.getEncryptedQString(pSchID) & "&PICTerm=" & C21MIT.PBSIS.BLL.pbsencryption.getEncryptedQString(1) & ""
            ElseIf rpttype = 20 Then
                myPbsNavLinks.NavigationLink = "~/pbsisrpts/midyrslr_avgpic.aspx?sRptSchID=" & C21MIT.PBSIS.BLL.pbsencryption.getEncryptedQString(pSchID) & "&PICTerm=" & C21MIT.PBSIS.BLL.pbsencryption.getEncryptedQString(2) & ""
            ElseIf rpttype = 5 Then
                myPbsNavLinks.NavigationLink = "~/pbsisrpts/endyrslr_boq.aspx?sRptSchID=" & C21MIT.PBSIS.BLL.pbsencryption.getEncryptedQString(pSchID) & ""
            ElseIf rpttype = 6 Then
                myPbsNavLinks.NavigationLink = "~/pbsisrpts/endyrslr_ods.aspx?sRptSchID=" & C21MIT.PBSIS.BLL.pbsencryption.getEncryptedQString(pSchID) & ""
            ElseIf rpttype = 23 Then
                myPbsNavLinks.NavigationLink = "~/pbsisrpts/endyrslr_bat.aspx?sRptSchID=" & C21MIT.PBSIS.BLL.pbsencryption.getEncryptedQString(pSchID) & ""
            End If

            Return myPbsNavLinks

        End Function

        '-------------------------------------------------------------------------------------------------------------------
        ' Function Name : lnkDistMonitor  
        ' Created By : Aditi Deodhar
        ' Created Dt : Feb 24,2010
        ' Last Updated Dt : Feb 24,2010
        '-------------------------------------------------------------------------------------------------------------------
        ''' Function to provide links for district monitoring tool
        Public Shared Function lnktoCharts(ByVal pFrmID As String, ByVal pSchID As String) As pbsnavigatelistobj
            Dim myPbsNavLinks As New C21MIT.PBSIS.BO.pbsnavigatelistobj
            Dim rpttype As String
            Dim rptyear As Integer


            Dim pendingFrmLink As String = ""
            Dim viewFrmLink As String = ""

            rpttype = pFrmID
            If System.Web.HttpContext.Current.Session("MM_UserName") = "" Then
                System.Web.HttpContext.Current.Response.Redirect("~/users/smessages.aspx?qModule=InvalidSession", False)

            End If
            rptyear = CInt(System.Web.HttpContext.Current.Session("ActYrId"))
            System.Web.HttpContext.Current.Session("SchYrId") = rptyear
            If rpttype = "7_0" Then
                myPbsNavLinks.NavigationLink = "~/pbsisrpts/chart.aspx?chartid=" & rpttype & "&sRptSchID=" & pSchID & ""
            ElseIf rpttype = "8_0" Then
                myPbsNavLinks.NavigationLink = "~/pbsisrpts/chart.aspx?chartid=" & rpttype & "&sRptSchID=" & pSchID & ""
            ElseIf rpttype = "9_0" Then
                myPbsNavLinks.NavigationLink = "~/pbsisrpts/chart.aspx?chartid=" & rpttype & "&sRptSchID=" & pSchID & ""
            ElseIf rpttype = "10_0" Then
                myPbsNavLinks.NavigationLink = "~/pbsisrpts/chart.aspx?chartid=" & rpttype & "&sRptSchID=" & pSchID & ""
            ElseIf rpttype = "11_0" Then
                myPbsNavLinks.NavigationLink = "~/pbsisrpts/chart.aspx?chartid=" & rpttype & "&sRptSchID=" & pSchID & ""
            ElseIf rpttype = "12_0" Then
                myPbsNavLinks.NavigationLink = "~/pbsisrpts/chart.aspx?chartid=" & rpttype & "&sRptSchID=" & pSchID & ""
            ElseIf rpttype = "42_0" Then
                myPbsNavLinks.NavigationLink = "~/pbsisrpts/chart.aspx?chartid=" & rpttype & "&sRptSchID=" & pSchID & ""
            ElseIf rpttype = "43_0" Then
                myPbsNavLinks.NavigationLink = "~/pbsisrpts/chart.aspx?chartid=" & rpttype & "&sRptSchID=" & pSchID & ""

            End If

            Return myPbsNavLinks

        End Function


        '-------------------------------------------------------------------------------------------------------------------
        ' Function Name : lnktoMidYrSLReports  
        ' Created By : Aditi Deodhar
        ' Created Dt : May 05,2010
        ' Last Updated Dt : May 05,2010
        '-------------------------------------------------------------------------------------------------------------------
        ''' Function to provide links for district monitoring tool
        Public Shared Function lnktoMidYrSLReports(ByVal chartid As String, ByVal pSchID As String) As pbsnavigatelistobj
            Dim myPbsNavLinks As New C21MIT.PBSIS.BO.pbsnavigatelistobj
            Dim rpttype As String
            Dim rptyear As Integer
            'SchoolYear=" & C21MIT.PBSIS.BLL.pbslogindetails.GetCurrentPrimTracker.schoolyear & "&DistId=" & distid & "&DistName=" & Session("sDistName") & ")
            'Response.Redirect("chart.aspx?SchoolYear=" & C21MIT.PBSIS.BLL.pbslogindetails.GetCurrentPrimTracker.schoolyear & "&DistId=" & distid & "&DistName=" & Session("sDistName") & "&SchType=" & Session("sSchType") & "&chartid=21_0")
            Dim pendingFrmLink As String = ""
            Dim viewFrmLink As String = ""

            rpttype = chartid
            If System.Web.HttpContext.Current.Session("MM_UserName") = "" Then
                System.Web.HttpContext.Current.Response.Redirect("~/users/smessages.aspx?qModule=InvalidSession", False)

            End If
            rptyear = CInt(System.Web.HttpContext.Current.Session("ActYrId"))
            System.Web.HttpContext.Current.Session("SchYrId") = rptyear
            If rpttype = "13_0" Then
                myPbsNavLinks.NavigationLink = "~/pbsisrpts/chart.aspx?&chartid=" & chartid & "&sRptSchID=" & pSchID & "&SchoolYear=" & C21MIT.PBSIS.BLL.pbslogindetails.GetCurrentPrimTracker.schoolyear & ""
            ElseIf rpttype = "14_0" Then
                myPbsNavLinks.NavigationLink = "~/pbsisrpts/chart.aspx?&chartid=" & chartid & "&sRptSchID=" & pSchID & "&SchoolYear=" & C21MIT.PBSIS.BLL.pbslogindetails.GetCurrentPrimTracker.schoolyear & ""
            End If
            Return myPbsNavLinks

        End Function
    End Class

    Public Class pbsencryption
        Shared Function getEncryptedQString(ByVal strQString As String) As String
            Dim encQString As String = C21MIT.Util.RJEncryp.EncryptString128Bit(strQString, _
                System.Web.HttpContext.Current.Session("sDKey"))
            Return encQString
        End Function

        Shared Function getDecryptedQString(ByVal strQString As String) As String
            If strQString Is Nothing Then
                Return ""
            Else
                strQString = strQString.Replace(" ", "+")
                Dim decQString As String = C21MIT.Util.RJEncryp.DecryptString128Bit(strQString, _
                    System.Web.HttpContext.Current.Session("sDKey"))

                Return decQString
            End If
        End Function
    End Class
#End Region
#Region "PBS - Password Manager"
    Public Class pbsPass
        Public Shared Function getRndPwd(ByVal nLen As Integer) As String
            Dim bchoice As Integer
            Dim mystr As String
            Dim pwd As String
            Dim RandomNumber As Integer
            Dim i As Integer
            mystr = "abcdefghjkmnopqrstuvwxyz"
            pwd = ""

            For i = 1 To nLen
                Randomize()
                bchoice = Int((2 * Rnd()) + 1)
                If bchoice = 1 Then
                    RandomNumber = Int((24 * Rnd()) + 1)
                    pwd = pwd & Mid(mystr, RandomNumber, 1)
                Else
                    pwd = pwd & Int((9 * Rnd()) + 1)
                End If
            Next

            getRndPwd = pwd
            Return getRndPwd
        End Function


    End Class
#End Region
#Region "Email Manager"
    Public Class pbsemailmanager

        Public Sub SendEmailAlert(ByVal v_emessage As String)

            Dim emailFrom As String
            Dim emailTo As String

            emailFrom = System.Configuration.ConfigurationManager.AppSettings("errEmail")
            emailTo = System.Configuration.ConfigurationManager.AppSettings("errEmail")

            '(1) Create the MailMessage instance
            Dim objMailMessage As New System.Net.Mail.MailMessage(emailFrom, emailTo)

            '(2) Assign the MailMessage's properties
            objMailMessage.Subject = "PBS - Application Error"
            objMailMessage.Body = v_emessage
            objMailMessage.IsBodyHtml = False

            '(3) Create the SmtpClient object
            Dim smtp As New System.Net.Mail.SmtpClient
            smtp.Send(objMailMessage)

        End Sub
    End Class
#End Region
End Namespace