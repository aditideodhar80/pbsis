Imports Microsoft.VisualBasic
Imports URDAL
Imports System.Data
Imports System.Data.SqlClient
Namespace C21MIT.PBSIS.DAL
#Region "PBS - Login"
    Public Class pbslogindetails
        '-------------------------------------------------------------------------------------------------------------------
        ' Function Name : fnvalidateaccount  
        ' Created By : Aditi Deodhar
        ' Description : This function is used validate all the accounts at login
        '-------------------------------------------------------------------------------------------------------------------
        Public Function fnvalidateaccount(ByVal accounttype As String, ByVal username As String, ByVal password As String) As C21MIT.PBSIS.BO.pbslogindetails
            Dim oRequest As New URDALRequest
            Dim oFactory As URDALAbsDBFactory
            Dim oNonQuery As URDALNonQuery
            oFactory = New URDALSQLFactory

            Dim myparOutput As New Hashtable

            Dim objSessionTracker As New C21MIT.PBSIS.BO.pbslogindetails

            With oRequest
                If accounttype = "District" Then
                    '.Command = "dbo.flpbs_district_login"
                    .Command = "dbo.flpbs_district_login_new"
                ElseIf accounttype = "School" Then
                    .Command = "dbo.flpbs_school_login"
                ElseIf accounttype = "FMHI" Then
                    .Command = "dbo.flpbsis_fmhi_login"
                End If
                .CommandType = CommandType.StoredProcedure
            End With

            oRequest.AddParameter("@p_username", username, URDALRequest.myDataType.dtString, 75, ParameterDirection.Input)
            oRequest.AddParameter("@p_pass", password, URDALRequest.myDataType.dtString, 10, ParameterDirection.Input)
            oRequest.AddParameter("@p_actid", , URDALRequest.myDataType.dtString, 10, ParameterDirection.Output)
            oRequest.AddParameter("@p_schoolyear", , URDALRequest.myDataType.dtTinyInt, , ParameterDirection.Output)
            oRequest.AddParameter("@p_isCorrect", , URDALRequest.myDataType.dtTinyInt, , ParameterDirection.Output)
            oRequest.AddParameter("@p_isInactive", , URDALRequest.myDataType.dtTinyInt, , ParameterDirection.Output)

            Try
                oNonQuery = oFactory.ExecuteNonQuery(oRequest)
                myparOutput = oRequest.URParOutputs

                If Not IsNothing(oRequest.Exception) Then
                    Throw New ApplicationException("sqlexception", oRequest.Exception)
                End If
            Catch ex As Exception
                Dim objerrLog As New C21MIT.MITErrorHandling.MITErrorHandling("Invalid Log Name: " & ex.Message)
                objerrLog.logError()
                System.Web.HttpContext.Current.Response.Redirect("~/users/smessages.aspx?qModule=TechErr", False)
            Finally
                oFactory.ConDispose()
            End Try
            If myparOutput("@p_isCorrect") Is System.DBNull.Value Then
                Return Nothing

            Else
                objSessionTracker.strUsername = CType(myparOutput("@p_username"), String)
                objSessionTracker.strPassword = CType(myparOutput("@p_pass"), String)
                objSessionTracker.v_actid = CType(myparOutput("@p_actid"), String)
                objSessionTracker.schoolyear = CType(myparOutput("@p_schoolyear"), Integer)
                objSessionTracker.isCorrect = CType(myparOutput("@p_isCorrect"), Integer)
                objSessionTracker.v_isInactive = CType(myparOutput("@p_isInactive"), Integer)

                Return objSessionTracker
            End If
        End Function

        '-------------------------------------------------------------------------------------------------------------------
        ' Function Name : fnvalidateforgotpass  
        ' Created By : Aditi Deodhar
        ' Description : This function is used validate all the accounts at login
        '-------------------------------------------------------------------------------------------------------------------
        Public Function fnvalidateforgotpassdist(ByVal accounttype As String, ByVal password As String, ByVal email As String) As C21MIT.PBSIS.BO.pbslogindetails
            Dim oRequest As New URDALRequest
            Dim oFactory As URDALAbsDBFactory
            Dim oNonQuery As URDALNonQuery
            oFactory = New URDALSQLFactory

            Dim myparOutput As New Hashtable

            Dim objSessionTracker As New C21MIT.PBSIS.BO.pbslogindetails

            With oRequest
                .Command = "dbo.flpbs_dist_pwdreset"
                .CommandType = CommandType.StoredProcedure
            End With

            oRequest.AddParameter("@p_pass", password, URDALRequest.myDataType.dtChar, 10, ParameterDirection.Input)
            oRequest.AddParameter("@p_email", email, URDALRequest.myDataType.dtString, 75, ParameterDirection.Input)
            oRequest.AddParameter("@p_resetresult", , URDALRequest.myDataType.dtTinyInt, , ParameterDirection.Output)
            Try
                oNonQuery = oFactory.ExecuteNonQuery(oRequest)
                myparOutput = oRequest.URParOutputs

                If Not IsNothing(oRequest.Exception) Then
                    Throw New ApplicationException("sqlexception", oRequest.Exception)
                End If
            Catch ex As Exception
                Dim objerrLog As New C21MIT.MITErrorHandling.MITErrorHandling("Invalid Log Name: " & ex.Message)
                objerrLog.logError()
                System.Web.HttpContext.Current.Response.Redirect("~/users/smessages.aspx?qModule=TechErr", False)
            Finally
                oFactory.ConDispose()
            End Try
            If myparOutput("@p_resetresult") Is System.DBNull.Value Then
                Return Nothing
            Else
                objSessionTracker.resultpforgotpass = CType(myparOutput("@p_resetresult"), Integer)
                Return objSessionTracker
            End If
        End Function

        Public Function fnvalidateforgotpasssch(ByVal accounttype As String, ByVal password As String, ByVal email As String) As C21MIT.PBSIS.BO.pbslogindetails
            Dim oRequest As New URDALRequest
            Dim oFactory As URDALAbsDBFactory
            Dim oNonQuery As URDALNonQuery
            oFactory = New URDALSQLFactory

            Dim myparOutput As New Hashtable

            Dim objSessionTracker As New C21MIT.PBSIS.BO.pbslogindetails

            With oRequest
                .Command = "dbo.flpbs_school_pwdreset"
                .CommandType = CommandType.StoredProcedure
            End With

            oRequest.AddParameter("@p_pwd", password, URDALRequest.myDataType.dtChar, 10, ParameterDirection.Input)
            oRequest.AddParameter("@p_email", email, URDALRequest.myDataType.dtString, 75, ParameterDirection.Input)
            oRequest.AddParameter("@p_resetresult", , URDALRequest.myDataType.dtTinyInt, , ParameterDirection.Output)
            Try
                oNonQuery = oFactory.ExecuteNonQuery(oRequest)
                myparOutput = oRequest.URParOutputs

                If Not IsNothing(oRequest.Exception) Then
                    Throw New ApplicationException("sqlexception", oRequest.Exception)
                End If
            Catch ex As Exception
                Dim objerrLog As New C21MIT.MITErrorHandling.MITErrorHandling("Invalid Log Name: " & ex.Message)
                objerrLog.logError()
                System.Web.HttpContext.Current.Response.Redirect("~/users/smessages.aspx?qModule=TechErr", False)
            Finally
                oFactory.ConDispose()
            End Try
            If myparOutput("@p_resetresult") Is System.DBNull.Value Then
                Return Nothing
            Else
                objSessionTracker.resultpforgotpass = CType(myparOutput("@p_resetresult"), Integer)
                Return objSessionTracker
            End If
        End Function
    End Class
#End Region
End Namespace