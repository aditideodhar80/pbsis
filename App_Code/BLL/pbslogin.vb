Imports Microsoft.VisualBasic
Namespace C21MIT.PBSIS.BLL
#Region "LOGIN FUNCTIONS"
    Public Class pbslogindetails
        '-------------------------------------------------------------------------------------------------------------------
        ' Procedure Name : logincheck  
        ' Created By : Aditi Deodhar
        ' Created Dt : Dec 12,2009
        ' Last Updated Dt : Dec 12,2009
        ' Description : This subroutine checks for the login credentials of the signed-in user /account to authorize whether 
        '               its a valid account.
        '--------------------------------------------------------------------------------------------------------------------
        Shared Sub logincheck(ByVal sUserName As String, ByVal sPassword As String, ByVal sAccessLevel As String)
            Dim straccesslevel As String
            Dim sURL As String = ""

            Dim objLoginDetails As New C21MIT.PBSIS.DAL.pbslogindetails

            Dim objPrimTracker As New C21MIT.PBSIS.BO.pbslogindetails

            objPrimTracker.strUsername = sUserName
            objPrimTracker.strPassword = ""
            straccesslevel = sAccessLevel

            System.Web.HttpContext.Current.Session("straccesslevel") = straccesslevel
            Dim vLoginSessionTracker As New C21MIT.PBSIS.BO.pbslogindetails

            If objPrimTracker.strUsername <> "" Or objPrimTracker.strPassword <> "" Then
                If straccesslevel = "District" Then
                    objPrimTracker.strPassword = Left(CStr(sPassword), 10)
                    vLoginSessionTracker = objLoginDetails.fnvalidateaccount("District", objPrimTracker.strUsername, objPrimTracker.strPassword)
                    sURL = "~/district/district_mainmenu.aspx"
                ElseIf straccesslevel = "School" Then
                    objPrimTracker.strPassword = Left(CStr(sPassword), 8)
                    vLoginSessionTracker = objLoginDetails.fnvalidateaccount("School", objPrimTracker.strUsername, objPrimTracker.strPassword)
                    sURL = "~/school/school_mainmenu.aspx"
                ElseIf straccesslevel = "FMHI" Then
                    objPrimTracker.strPassword = Left(CStr(sPassword), 10)
                    vLoginSessionTracker = objLoginDetails.fnvalidateaccount("FMHI", objPrimTracker.strUsername, objPrimTracker.strPassword)
                    sURL = "~/fmhiadmin/fmhi_mainmenu.aspx"
                End If
            End If

            If vLoginSessionTracker Is Nothing Then
                System.Web.HttpContext.Current.Response.Redirect("~/users/smessages.aspx?qModule=InvalidLogin", False)
            Else
                System.Web.HttpContext.Current.Session("sPrimTracker") = vLoginSessionTracker.PSessionTracker
                'Response.Redirect("~/school/dentryview.aspx")

                If vLoginSessionTracker.isCorrect = 1 Then
                    ' username and password match - this is a valid user
                    System.Web.HttpContext.Current.Session("ActYrId") = vLoginSessionTracker.schoolyear
                    System.Web.HttpContext.Current.Session("MM_Username") = objPrimTracker.strUsername
                    System.Web.HttpContext.Current.Session("MM_Password") = objPrimTracker.strPassword
                    'aditi
                    'vLoginSessionTracker.strUsername = System.Web.HttpContext.Current.Session("MM_Username")
                    'aditi
                    ' Session variable to user type authentiction for reports
                    If straccesslevel = "School" Then
                        System.Web.HttpContext.Current.Session("sRptAuth") = "aS"
                        System.Web.HttpContext.Current.Session("accttype") = "School"
                    ElseIf straccesslevel = "District" Then
                        System.Web.HttpContext.Current.Session("sRptAuth") = "aD"
                        System.Web.HttpContext.Current.Session("sDistId") = vLoginSessionTracker.v_actid
                        System.Web.HttpContext.Current.Session("accttype") = "District"
                    ElseIf straccesslevel = "FMHI" Then
                        System.Web.HttpContext.Current.Session("sRptAuth") = "aF"
                        System.Web.HttpContext.Current.Session("sALevel") = vLoginSessionTracker.v_actid '' For FMHI Account Managers the value is 4
                        System.Web.HttpContext.Current.Session("accttype") = "FMHI"
                    End If
                    System.Web.HttpContext.Current.Session("sDKey") = C21MIT.Util.RandomKeyString.Generate(32)

                    If vLoginSessionTracker.v_isInactive = 0 Then
                        System.Web.HttpContext.Current.Response.Redirect(sURL)
                    Else
                        System.Web.HttpContext.Current.Response.Redirect("~/users/smessages.aspx?qModule=InvalidLogin", False)
                    End If

                Else
                    System.Web.HttpContext.Current.Response.Redirect("~/users/smessages.aspx?qModule=InvalidLogin", False)
                End If
            End If
        End Sub

        Shared Function GetCurrentPrimTracker() As C21MIT.PBSIS.BO.pbslogindetails
            Dim objLoginDetails As New C21MIT.PBSIS.DAL.pbslogindetails
            Dim sPrimTracker As New C21MIT.PBSIS.BO.pbslogindetails( _
            System.Web.HttpContext.Current.Session("sPrimTracker"))
            Return objLoginDetails.fnvalidateaccount(System.Web.HttpContext.Current.Session("accttype"), System.Web.HttpContext.Current.Session("MM_Username"), System.Web.HttpContext.Current.Session("MM_Password"))
        End Function

        Shared Function GetPrimTracker() As C21MIT.PBSIS.BO.pbslogindetails
            Dim objLoginDetails As New C21MIT.PBSIS.DAL.pbslogindetails
            Dim sPrimTracker As New C21MIT.PBSIS.BO.pbslogindetails(System.Web.HttpContext.Current.Session("sPrimTracker"))
            Dim url As String = ""

            Return sPrimTracker
        End Function
    End Class
#End Region
End Namespace