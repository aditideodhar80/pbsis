Imports URDAL
Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.VisualBasic
Namespace C21MIT.PBSIS.DAL
#Region "FMHI - Account profiles"
    Public Class pbsfmhiaccountprofiles
#Region "School Profile"
        '-------------------------------------------------------------------------------------------------------------------
        ' Function Name : addfmhischoolprofile  
        ' Created By : Aditi Deodhar
        ' Created Dt : March 25,2010
        ' Last Updated Dt : March 25,2010
        ' Description : This function is used to insert the school profile data for a particular school for FMHI login.
        '-------------------------------------------------------------------------------------------------------------------
        Shared Sub addfmhischoolprofile(ByVal objschoolprofile As C21MIT.PBSIS.BO.pbsschoolprofile)
            Dim oRequest As New URDALRequest
            Dim oFactory As URDALAbsDBFactory
            Dim oNonQuery As URDALNonQuery
            oFactory = New URDALSQLFactory

            With oRequest
                .Command = "dbo.flpbsis_fmhi_schoolprofile_insert"
                .CommandType = CommandType.StoredProcedure
            End With

            oRequest.AddParameter("@p_SchoolName", objschoolprofile.SchoolName, URDALRequest.myDataType.dtString, 75, ParameterDirection.Input)
            oRequest.AddParameter("@p_SchoolID", objschoolprofile.SchoolId, URDALRequest.myDataType.dtChar, 6, ParameterDirection.Input)
            oRequest.AddParameter("@p_SchoolDistrict", objschoolprofile.SchoolDistrict, URDALRequest.myDataType.dtChar, 2, ParameterDirection.Input)
            oRequest.AddParameter("@p_SchoolStreetAddress1", objschoolprofile.SchoolStreetAddress1, URDALRequest.myDataType.dtString, 100, ParameterDirection.Input)
            oRequest.AddParameter("@p_SchoolStreetAddress2", objschoolprofile.SchoolStreetAddress2, URDALRequest.myDataType.dtString, 100, ParameterDirection.Input)
            oRequest.AddParameter("@p_SchoolCity", objschoolprofile.SchoolCity, URDALRequest.myDataType.dtString, 50, ParameterDirection.Input)
            oRequest.AddParameter("@p_SchoolState", objschoolprofile.SchoolState, URDALRequest.myDataType.dtString, 2, ParameterDirection.Input)
            oRequest.AddParameter("@p_SchoolZip", objschoolprofile.SchoolZip, URDALRequest.myDataType.dtString, 9, ParameterDirection.Input)
            oRequest.AddParameter("@p_SchoolPhone", objschoolprofile.SchoolPhone, URDALRequest.myDataType.dtString, 20, ParameterDirection.Input)
            oRequest.AddParameter("@p_SchoolFax", objschoolprofile.SchoolFax, URDALRequest.myDataType.dtString, 20, ParameterDirection.Input)
            oRequest.AddParameter("@p_SchoolAdministratorName", objschoolprofile.SchoolAdministratorName, URDALRequest.myDataType.dtString, 75, ParameterDirection.Input)
            oRequest.AddParameter("@p_SchoolAdministratorPhone", objschoolprofile.SchoolAdministratorPhone, URDALRequest.myDataType.dtString, 20, ParameterDirection.Input)
            oRequest.AddParameter("@p_SchoolAdministratorEmail", objschoolprofile.SchoolAdministratorEmail, URDALRequest.myDataType.dtString, 75, ParameterDirection.Input)
            oRequest.AddParameter("@p_SchoolType", objschoolprofile.SchoolType, URDALRequest.myDataType.dtChar, 2, ParameterDirection.Input)
            oRequest.AddParameter("@p_SchoolPass", C21MIT.PBSIS.BLL.pbsPass.getRndPwd(8), URDALRequest.myDataType.dtString, 8, ParameterDirection.Input)
            oRequest.AddParameter("@p_BaselineAvailable", objschoolprofile.Baseline_Available, URDALRequest.myDataType.dtTinyInt, , ParameterDirection.Input)
            Try
                oNonQuery = oFactory.ExecuteNonQuery(oRequest)

                If Not IsNothing(oRequest.Exception) Then
                    Throw New ApplicationException("sqlexception", oRequest.Exception)
                End If

            Catch ex As Exception
                Dim objerrLog As New MITErrorHandling.MITErrorHandling("Exception: " & "in addnewuser - " & ex.ToString())
                objerrLog.logError()
                System.Web.HttpContext.Current.Response.Redirect("~/users/smessages.aspx?qModule=TechErr", False)
            Finally
                oFactory.ConDispose()
            End Try
        End Sub
        '-------------------------------------------------------------------------------------------------------------------
        ' Function Name : updfmhischoolprofile  
        ' Created By : Aditi Deodhar
        ' Created Dt : March 30,2010
        ' Last Updated Dt : March 30,2010
        ' Description : This function is used to update the school profile data for a particular school for FMHI login.
        '-------------------------------------------------------------------------------------------------------------------
        Shared Sub updfmhischoolprofile(ByVal objschoolprofile As C21MIT.PBSIS.BO.pbsschoolprofile)
            Dim oRequest As New URDALRequest
            Dim oFactory As URDALAbsDBFactory
            Dim oNonQuery As URDALNonQuery
            oFactory = New URDALSQLFactory

            With oRequest
                .Command = "dbo.flpbsis_fmhi_schprofile_update"
                .CommandType = CommandType.StoredProcedure
            End With

            oRequest.AddParameter("@p_SchoolID", objschoolprofile.SchoolId, URDALRequest.myDataType.dtChar, 6, ParameterDirection.Input)
            oRequest.AddParameter("@p_SchoolName", objschoolprofile.SchoolName, URDALRequest.myDataType.dtString, 75, ParameterDirection.Input)
            oRequest.AddParameter("@p_SchoolDistrictID", objschoolprofile.SchoolDistrict, URDALRequest.myDataType.dtChar, 2, ParameterDirection.Input)
            oRequest.AddParameter("@p_SchoolStreetAddress1", objschoolprofile.SchoolStreetAddress1, URDALRequest.myDataType.dtString, 100, ParameterDirection.Input)
            oRequest.AddParameter("@p_SchoolStreetAddress2", objschoolprofile.SchoolStreetAddress2, URDALRequest.myDataType.dtString, 100, ParameterDirection.Input)
            oRequest.AddParameter("@p_SchoolCity", objschoolprofile.SchoolCity, URDALRequest.myDataType.dtString, 50, ParameterDirection.Input)
            oRequest.AddParameter("@p_SchoolState", objschoolprofile.SchoolState, URDALRequest.myDataType.dtString, 2, ParameterDirection.Input)
            oRequest.AddParameter("@p_SchoolZip", objschoolprofile.SchoolZip, URDALRequest.myDataType.dtString, 9, ParameterDirection.Input)
            oRequest.AddParameter("@p_SchoolPhone", objschoolprofile.SchoolPhone, URDALRequest.myDataType.dtString, 20, ParameterDirection.Input)
            oRequest.AddParameter("@p_SchoolFax", objschoolprofile.SchoolFax, URDALRequest.myDataType.dtString, 20, ParameterDirection.Input)
            oRequest.AddParameter("@p_SchoolAdministratorName", objschoolprofile.SchoolAdministratorName, URDALRequest.myDataType.dtString, 75, ParameterDirection.Input)
            oRequest.AddParameter("@p_SchoolAdministratorPhone", objschoolprofile.SchoolAdministratorPhone, URDALRequest.myDataType.dtString, 20, ParameterDirection.Input)
            oRequest.AddParameter("@p_SchoolAdministratorEmail", objschoolprofile.SchoolAdministratorEmail, URDALRequest.myDataType.dtString, 75, ParameterDirection.Input)
            oRequest.AddParameter("@p_SchoolType", objschoolprofile.SchoolType, URDALRequest.myDataType.dtChar, 2, ParameterDirection.Input)
            oRequest.AddParameter("@p_SchoolInactive", objschoolprofile.SchoolInactive, URDALRequest.myDataType.dtChar, 2, ParameterDirection.Input)
            oRequest.AddParameter("@p_BaselineAvailable", objschoolprofile.Baseline_Available, URDALRequest.myDataType.dtTinyInt, , ParameterDirection.Input)
            Try
                oNonQuery = oFactory.ExecuteNonQuery(oRequest)

                If Not IsNothing(oRequest.Exception) Then
                    Throw New ApplicationException("sqlexception", oRequest.Exception)
                End If

            Catch ex As Exception
                Dim objerrLog As New MITErrorHandling.MITErrorHandling("Exception: " & "in addnewuser - " & ex.ToString())
                objerrLog.logError()
                System.Web.HttpContext.Current.Response.Redirect("~/users/smessages.aspx?qModule=TechErr", False)
            Finally
                oFactory.ConDispose()
            End Try
        End Sub
        '-------------------------------------------------------------------------------------------------------------------
        ' Function Name : getfmhischprofile  
        ' Created By : Aditi Deodhar
        ' Created Dt : March 30,2010
        ' Last Updated Dt : March 30,2010
        ' Description : This function is used to get the school profile data for FMHI login.
        '-------------------------------------------------------------------------------------------------------------------
        Shared Function getfmhischprofile(ByVal schid As String) As C21MIT.PBSIS.BO.pbsschoolprofile
            Dim oRequest As New URDALRequest
            Dim oFactory As URDALAbsDBFactory
            Dim oNonQuery As URDALNonQuery
            oFactory = New URDALSQLFactory
            Dim myparOutput As New Hashtable

            Dim objpbsschoolprofile As New C21MIT.PBSIS.BO.pbsschoolprofile

            With oRequest
                .Command = "dbo.flpbsis_fmhi_schprofile_select"
                .CommandType = CommandType.StoredProcedure
            End With

            oRequest.AddParameter("@p_SchoolID", schid, URDALRequest.myDataType.dtChar, 6, ParameterDirection.Input)
            oRequest.AddParameter("@p_SchoolName", , URDALRequest.myDataType.dtString, 75, ParameterDirection.Output)
            oRequest.AddParameter("@p_SchoolDistrictID", , URDALRequest.myDataType.dtChar, 2, ParameterDirection.Output)
            oRequest.AddParameter("@p_SchoolStreetAddress1", , URDALRequest.myDataType.dtString, 100, ParameterDirection.Output)
            oRequest.AddParameter("@p_SchoolStreetAddress2", , URDALRequest.myDataType.dtString, 100, ParameterDirection.Output)
            oRequest.AddParameter("@p_SchoolCity", , URDALRequest.myDataType.dtString, 50, ParameterDirection.Output)
            oRequest.AddParameter("@p_SchoolState", , URDALRequest.myDataType.dtString, 2, ParameterDirection.Output)
            oRequest.AddParameter("@p_SchoolZip", , URDALRequest.myDataType.dtString, 9, ParameterDirection.Output)
            oRequest.AddParameter("@p_SchoolPhone", , URDALRequest.myDataType.dtString, 20, ParameterDirection.Output)
            oRequest.AddParameter("@p_SchoolFax", , URDALRequest.myDataType.dtString, 20, ParameterDirection.Output)
            oRequest.AddParameter("@p_SchoolAdministratorName", , URDALRequest.myDataType.dtString, 75, ParameterDirection.Output)
            oRequest.AddParameter("@p_SchoolAdministratorPhone", , URDALRequest.myDataType.dtString, 20, ParameterDirection.Output)
            oRequest.AddParameter("@p_SchoolAdministratorEmail", , URDALRequest.myDataType.dtString, 75, ParameterDirection.Output)
            oRequest.AddParameter("@p_SchoolType", , URDALRequest.myDataType.dtTinyInt, , ParameterDirection.Output)
            oRequest.AddParameter("@p_SchoolInactive", , URDALRequest.myDataType.dtTinyInt, , ParameterDirection.Output)
            oRequest.AddParameter("@p_BaselineAvailable", , URDALRequest.myDataType.dtTinyInt, , ParameterDirection.Output)
            oRequest.AddParameter("@p_BaselineCompleted", , URDALRequest.myDataType.dtTinyInt, , ParameterDirection.Output)

            Try
                oNonQuery = oFactory.ExecuteNonQuery(oRequest)
                myparOutput = oRequest.URParOutputs

                If Not IsNothing(oRequest.Exception) Then
                    Throw New ApplicationException("sqlexception", oRequest.Exception)
                End If
            Catch ex As Exception
                Dim objerrLog As New C21MIT.MITErrorHandling.MITErrorHandling("Exception in 'getfmhischprofile': " & ex.Message)
                objerrLog.logError()
                System.Web.HttpContext.Current.Response.Redirect("~/users/smessages.aspx?qModule=TechErr", False)
            Finally
                oFactory.ConDispose()
            End Try



            If myparOutput("@p_SchoolName") Is DBNull.Value Then
                objpbsschoolprofile.SchoolName = ""
            Else
                objpbsschoolprofile.SchoolName = CType(myparOutput("@p_SchoolName"), String)
            End If
            If myparOutput("@p_SchoolDistrictID") Is DBNull.Value Then
                objpbsschoolprofile.SchoolDistrict = ""
            Else
                objpbsschoolprofile.SchoolDistrict = CType(myparOutput("@p_SchoolDistrictID"), String)
            End If
            If myparOutput("@p_SchoolStreetAddress1") Is DBNull.Value Then
                objpbsschoolprofile.SchoolStreetAddress1 = ""
            Else
                objpbsschoolprofile.SchoolStreetAddress1 = CType(myparOutput("@p_SchoolStreetAddress1"), String)
            End If
            If myparOutput("@p_SchoolStreetAddress2") Is DBNull.Value Then
                objpbsschoolprofile.SchoolStreetAddress2 = ""
            Else
                objpbsschoolprofile.SchoolStreetAddress2 = CType(myparOutput("@p_SchoolStreetAddress2"), String)
            End If
            If myparOutput("@p_SchoolCity") Is DBNull.Value Then
                objpbsschoolprofile.SchoolCity = ""
            Else
                objpbsschoolprofile.SchoolCity = CType(myparOutput("@p_SchoolCity"), String)
            End If
            If myparOutput("@p_SchoolState") Is DBNull.Value Then
                objpbsschoolprofile.SchoolState = ""
            Else
                objpbsschoolprofile.SchoolState = CType(myparOutput("@p_SchoolState"), String)
            End If
            If myparOutput("@p_SchoolZip") Is DBNull.Value Then
                objpbsschoolprofile.SchoolZip = ""
            Else
                objpbsschoolprofile.SchoolZip = CType(myparOutput("@p_SchoolZip"), String)
            End If
            If myparOutput("@p_SchoolPhone") Is DBNull.Value Then
                objpbsschoolprofile.SchoolPhone = ""
            Else
                objpbsschoolprofile.SchoolPhone = CType(myparOutput("@p_SchoolPhone"), String)
            End If
            If myparOutput("@p_SchoolFax") Is DBNull.Value Then
                objpbsschoolprofile.SchoolFax = ""
            Else
                objpbsschoolprofile.SchoolFax = CType(myparOutput("@p_SchoolFax"), String)
            End If
            If myparOutput("@p_SchoolAdministratorName") Is DBNull.Value Then
                objpbsschoolprofile.SchoolAdministratorName = ""
            Else
                objpbsschoolprofile.SchoolAdministratorName = CType(myparOutput("@p_SchoolAdministratorName"), String)
            End If
            If myparOutput("@p_SchoolAdministratorPhone") Is DBNull.Value Then
                objpbsschoolprofile.SchoolAdministratorPhone = ""
            Else
                objpbsschoolprofile.SchoolAdministratorPhone = CType(myparOutput("@p_SchoolAdministratorPhone"), String)
            End If
            If myparOutput("@p_SchoolAdministratorEmail") Is DBNull.Value Then
                objpbsschoolprofile.SchoolAdministratorEmail = ""
            Else
                objpbsschoolprofile.SchoolAdministratorEmail = CType(myparOutput("@p_SchoolAdministratorEmail"), String)
            End If

            If myparOutput("@p_SchoolType") Is DBNull.Value Then
                objpbsschoolprofile.SchoolType = 0
            Else
                objpbsschoolprofile.SchoolType = CType(myparOutput("@p_SchoolType"), Integer)
            End If

            If myparOutput("@p_SchoolInactive") Is DBNull.Value Then
                objpbsschoolprofile.SchoolInactive = 0
            Else
                objpbsschoolprofile.SchoolInactive = CType(myparOutput("@p_SchoolInactive"), Integer)
            End If

            If myparOutput("@p_BaselineAvailable") Is DBNull.Value Then
                objpbsschoolprofile.Baseline_Available = 0
            Else
                objpbsschoolprofile.Baseline_Available = CType(myparOutput("@p_BaselineAvailable"), Integer)
            End If
            If myparOutput("@p_BaselineCompleted") Is DBNull.Value Then
                objpbsschoolprofile.Baseline_Completed = 0
            Else
                objpbsschoolprofile.Baseline_Completed = CType(myparOutput("@p_BaselineCompleted"), Integer)
            End If

            Return objpbsschoolprofile
        End Function
#End Region
#Region "District Profile"
        '-------------------------------------------------------------------------------------------------------------------
        ' Function Name : addfmhidistprofile  
        ' Created By : Aditi Deodhar
        ' Created Dt : March 25,2010
        ' Last Updated Dt : March 25,2010
        ' Description : This function is used to insert the school profile data for a particular school for FMHI login.
        '-------------------------------------------------------------------------------------------------------------------
        Shared Sub addfmhidistprofile(ByVal objdistprofile As C21MIT.PBSIS.BO.pbsdistprofile)
            Dim oRequest As New URDALRequest
            Dim oFactory As URDALAbsDBFactory
            Dim oNonQuery As URDALNonQuery
            oFactory = New URDALSQLFactory

            With oRequest
                .Command = "dbo.flpbsis_fmhi_districtprofile_insert"
                .CommandType = CommandType.StoredProcedure
            End With


            oRequest.AddParameter("@p_DistrictName", objdistprofile.DistName, URDALRequest.myDataType.dtString, 75, ParameterDirection.Input)
            oRequest.AddParameter("@p_DistrictID", objdistprofile.DistId, URDALRequest.myDataType.dtChar, 2, ParameterDirection.Input)
            oRequest.AddParameter("@p_CoordFirstName", objdistprofile.DistCoordFirstName, URDALRequest.myDataType.dtString, 50, ParameterDirection.Input)
            oRequest.AddParameter("@p_CoordLastName", objdistprofile.DistCoordFirstName, URDALRequest.myDataType.dtString, 50, ParameterDirection.Input)
            oRequest.AddParameter("@p_StreetAddress1", objdistprofile.DistStreetAddress1, URDALRequest.myDataType.dtString, 100, ParameterDirection.Input)
            oRequest.AddParameter("@p_StreetAddress2", objdistprofile.DistStreetAddress2, URDALRequest.myDataType.dtString, 100, ParameterDirection.Input)
            oRequest.AddParameter("@p_DistrictCity", objdistprofile.DistrictCity, URDALRequest.myDataType.dtString, 50, ParameterDirection.Input)
            oRequest.AddParameter("@p_DistrictState", objdistprofile.DistrictState, URDALRequest.myDataType.dtString, 2, ParameterDirection.Input)
            oRequest.AddParameter("@p_DistrictZip", objdistprofile.DistrictZip, URDALRequest.myDataType.dtString, 9, ParameterDirection.Input)
            oRequest.AddParameter("@p_DistrictPhone", objdistprofile.DistrictPhone, URDALRequest.myDataType.dtString, 20, ParameterDirection.Input)
            oRequest.AddParameter("@p_DistrictFax", objdistprofile.DistrictFax, URDALRequest.myDataType.dtString, 20, ParameterDirection.Input)
            oRequest.AddParameter("@p_DistrictCell", objdistprofile.DistrictCell, URDALRequest.myDataType.dtString, 20, ParameterDirection.Input)
            oRequest.AddParameter("@p_DistrictCoordEmail", objdistprofile.DistrictCoordEmail, URDALRequest.myDataType.dtString, 75, ParameterDirection.Input)
            oRequest.AddParameter("@p_DistrictPass", C21MIT.PBSIS.BLL.pbsPass.getRndPwd(8), URDALRequest.myDataType.dtString, 8, ParameterDirection.Input)

            oRequest.AddParameter("@p_CoordFirstName_2", objdistprofile.CoordFirstName_2, URDALRequest.myDataType.dtString, 50, ParameterDirection.Input)
            oRequest.AddParameter("@p_CoordLastName_2", objdistprofile.CoordLastName_2, URDALRequest.myDataType.dtString, 50, ParameterDirection.Input)
            oRequest.AddParameter("@p_StreetAddress1_2", objdistprofile.StreetAddress1_2, URDALRequest.myDataType.dtString, 100, ParameterDirection.Input)
            oRequest.AddParameter("@p_StreetAddress2_2", objdistprofile.StreetAddress2_2, URDALRequest.myDataType.dtString, 100, ParameterDirection.Input)
            oRequest.AddParameter("@p_DistrictCity_2", objdistprofile.DistrictCity_2, URDALRequest.myDataType.dtString, 50, ParameterDirection.Input)
            oRequest.AddParameter("@p_DistrictState_2", objdistprofile.DistrictState_2, URDALRequest.myDataType.dtString, 2, ParameterDirection.Input)
            oRequest.AddParameter("@p_DistrictZip_2", objdistprofile.DistrictZip_2, URDALRequest.myDataType.dtString, 9, ParameterDirection.Input)
            oRequest.AddParameter("@p_DistrictPhone_2", objdistprofile.DistrictPhone_2, URDALRequest.myDataType.dtString, 20, ParameterDirection.Input)
            oRequest.AddParameter("@p_DistrictFax_2", objdistprofile.DistrictFax_2, URDALRequest.myDataType.dtString, 20, ParameterDirection.Input)
            oRequest.AddParameter("@p_DistrictCell_2", objdistprofile.DistrictCell_2, URDALRequest.myDataType.dtString, 20, ParameterDirection.Input)
            oRequest.AddParameter("@p_DistrictCoordEmail_2", objdistprofile.DistrictCoordEmail_2, URDALRequest.myDataType.dtString, 75, ParameterDirection.Input)
            oRequest.AddParameter("@p_DistrictInactive", objdistprofile.DistrictInactive, URDALRequest.myDataType.dtTinyInt, , ParameterDirection.Input)

            Try
                oNonQuery = oFactory.ExecuteNonQuery(oRequest)

                If Not IsNothing(oRequest.Exception) Then
                    Throw New ApplicationException("sqlexception", oRequest.Exception)
                End If

            Catch ex As Exception
                Dim objerrLog As New MITErrorHandling.MITErrorHandling("Exception: " & "in addnewuser - " & ex.ToString())
                objerrLog.logError()
                System.Web.HttpContext.Current.Response.Redirect("~/users/smessages.aspx?qModule=TechErr", False)
            Finally
                oFactory.ConDispose()
            End Try
        End Sub
        '-------------------------------------------------------------------------------------------------------------------
        ' Function Name : getfmhidistprofile  
        ' Created By : Aditi Deodhar
        ' Created Dt : March 29,2010
        ' Last Updated Dt : March 29,2010
        ' Description : This function is used to get the district profile data for FMHI login.
        '-------------------------------------------------------------------------------------------------------------------
        Shared Function getfmhidistprofile(ByVal distid As String) As C21MIT.PBSIS.BO.pbsdistprofile
            Dim oRequest As New URDALRequest
            Dim oFactory As URDALAbsDBFactory
            Dim oNonQuery As URDALNonQuery
            oFactory = New URDALSQLFactory
            Dim myparOutput As New Hashtable

            Dim objpbsdistrictprofile As New C21MIT.PBSIS.BO.pbsdistprofile
            With oRequest
                .Command = "dbo.flpbsis_fmhi_distprofile_select"
                .CommandType = CommandType.StoredProcedure
            End With


            oRequest.AddParameter("@p_DistrictID", distid, URDALRequest.myDataType.dtChar, 2, ParameterDirection.Input)
            oRequest.AddParameter("@p_DistrictName", , URDALRequest.myDataType.dtString, 75, ParameterDirection.Output)
            oRequest.AddParameter("@p_CoordFirstName", , URDALRequest.myDataType.dtString, 50, ParameterDirection.Output)
            oRequest.AddParameter("@p_CoordLastName", , URDALRequest.myDataType.dtString, 50, ParameterDirection.Output)
            oRequest.AddParameter("@p_StreetAddress1", , URDALRequest.myDataType.dtString, 100, ParameterDirection.Output)
            oRequest.AddParameter("@p_StreetAddress2", , URDALRequest.myDataType.dtString, 100, ParameterDirection.Output)
            oRequest.AddParameter("@p_DistrictCity", , URDALRequest.myDataType.dtString, 50, ParameterDirection.Output)
            oRequest.AddParameter("@p_DistrictState", , URDALRequest.myDataType.dtString, 2, ParameterDirection.Output)
            oRequest.AddParameter("@p_DistrictZip", , URDALRequest.myDataType.dtString, 9, ParameterDirection.Output)
            oRequest.AddParameter("@p_DistrictPhone", , URDALRequest.myDataType.dtString, 20, ParameterDirection.Output)
            oRequest.AddParameter("@p_DistrictFax", , URDALRequest.myDataType.dtString, 20, ParameterDirection.Output)
            oRequest.AddParameter("@p_DistrictCell", , URDALRequest.myDataType.dtString, 20, ParameterDirection.Output)
            oRequest.AddParameter("@p_DistrictCoordEmail", , URDALRequest.myDataType.dtString, 75, ParameterDirection.Output)
            oRequest.AddParameter("@p_DistrictPass", , URDALRequest.myDataType.dtString, 8, ParameterDirection.Output)

            oRequest.AddParameter("@p_CoordFirstName_2", , URDALRequest.myDataType.dtString, 50, ParameterDirection.Output)
            oRequest.AddParameter("@p_CoordLastName_2", , URDALRequest.myDataType.dtString, 50, ParameterDirection.Output)
            oRequest.AddParameter("@p_StreetAddress1_2", , URDALRequest.myDataType.dtString, 100, ParameterDirection.Output)
            oRequest.AddParameter("@p_StreetAddress2_2", , URDALRequest.myDataType.dtString, 100, ParameterDirection.Output)
            oRequest.AddParameter("@p_DistrictCity_2", , URDALRequest.myDataType.dtString, 50, ParameterDirection.Output)
            oRequest.AddParameter("@p_DistrictState_2", , URDALRequest.myDataType.dtString, 2, ParameterDirection.Output)
            oRequest.AddParameter("@p_DistrictZip_2", , URDALRequest.myDataType.dtString, 9, ParameterDirection.Output)
            oRequest.AddParameter("@p_DistrictPhone_2", , URDALRequest.myDataType.dtString, 20, ParameterDirection.Output)
            oRequest.AddParameter("@p_DistrictFax_2", , URDALRequest.myDataType.dtString, 20, ParameterDirection.Output)
            oRequest.AddParameter("@p_DistrictCell_2", , URDALRequest.myDataType.dtString, 20, ParameterDirection.Output)
            oRequest.AddParameter("@p_DistrictCoordEmail_2", , URDALRequest.myDataType.dtString, 75, ParameterDirection.Output)

            oRequest.AddParameter("@p_DistrictInactive", , URDALRequest.myDataType.dtTinyInt, , ParameterDirection.Output)
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


            If myparOutput("@p_DistrictName") Is DBNull.Value Then
                objpbsdistrictprofile.DistName = ""
            Else
                objpbsdistrictprofile.DistName = CType(myparOutput("@p_DistrictName"), String)
            End If

            If myparOutput("@p_CoordFirstName") Is DBNull.Value Then
                objpbsdistrictprofile.DistCoordFirstName = ""
            Else
                objpbsdistrictprofile.DistCoordFirstName = CType(myparOutput("@p_CoordFirstName"), String)
            End If
            If myparOutput("@p_CoordLastName") Is DBNull.Value Then
                objpbsdistrictprofile.DistCoordLastName = ""
            Else
                objpbsdistrictprofile.DistCoordLastName = CType(myparOutput("@p_CoordLastName"), String)
            End If
            If myparOutput("@p_StreetAddress1") Is DBNull.Value Then
                objpbsdistrictprofile.DistStreetAddress1 = ""
            Else
                objpbsdistrictprofile.DistStreetAddress1 = CType(myparOutput("@p_StreetAddress1"), String)
            End If
            If myparOutput("@p_StreetAddress2") Is DBNull.Value Then
                objpbsdistrictprofile.DistStreetAddress2 = ""
            Else
                objpbsdistrictprofile.DistStreetAddress2 = CType(myparOutput("@p_StreetAddress2"), String)
            End If
            If myparOutput("@p_DistrictCity") Is DBNull.Value Then
                objpbsdistrictprofile.DistrictCity = ""
            Else
                objpbsdistrictprofile.DistrictCity = CType(myparOutput("@p_DistrictCity"), String)
            End If
            If myparOutput("@p_DistrictState") Is DBNull.Value Then
                objpbsdistrictprofile.DistrictState = ""
            Else
                objpbsdistrictprofile.DistrictState = CType(myparOutput("@p_DistrictState"), String)
            End If
            If myparOutput("@p_DistrictZip") Is DBNull.Value Then
                objpbsdistrictprofile.DistrictZip = ""
            Else
                objpbsdistrictprofile.DistrictZip = CType(myparOutput("@p_DistrictZip"), String)
            End If
            If myparOutput("@p_DistrictPhone") Is DBNull.Value Then
                objpbsdistrictprofile.DistrictPhone = ""
            Else
                objpbsdistrictprofile.DistrictPhone = CType(myparOutput("@p_DistrictPhone"), String)
            End If
            If myparOutput("@p_DistrictFax") Is DBNull.Value Then
                objpbsdistrictprofile.DistrictFax = ""
            Else
                objpbsdistrictprofile.DistrictFax = CType(myparOutput("@p_DistrictFax"), String)
            End If
            If myparOutput("@p_DistrictCell") Is DBNull.Value Then
                objpbsdistrictprofile.DistrictCell = ""
            Else
                objpbsdistrictprofile.DistrictCell = CType(myparOutput("@p_DistrictCell"), String)
            End If
            If myparOutput("@p_DistrictCoordEmail") Is DBNull.Value Then
                objpbsdistrictprofile.DistrictCoordEmail = ""
            Else
                objpbsdistrictprofile.DistrictCoordEmail = CType(myparOutput("@p_DistrictCoordEmail"), String)
            End If
            If myparOutput("@p_DistrictPass") Is DBNull.Value Then
                objpbsdistrictprofile.DistrictPass = ""
            Else
                objpbsdistrictprofile.DistrictPass = CType(myparOutput("@p_DistrictPass"), String)
            End If

            If myparOutput("@p_CoordFirstName_2") Is DBNull.Value Then
                objpbsdistrictprofile.CoordFirstName_2 = ""
            Else
                objpbsdistrictprofile.CoordFirstName_2 = CType(myparOutput("@p_CoordFirstName_2"), String)
            End If
            If myparOutput("@p_CoordLastName_2") Is DBNull.Value Then
                objpbsdistrictprofile.CoordLastName_2 = ""
            Else
                objpbsdistrictprofile.CoordLastName_2 = CType(myparOutput("@p_CoordLastName_2"), String)
            End If
            If myparOutput("@p_StreetAddress1_2") Is DBNull.Value Then
                objpbsdistrictprofile.StreetAddress1_2 = ""
            Else
                objpbsdistrictprofile.StreetAddress1_2 = CType(myparOutput("@p_StreetAddress1_2"), String)
            End If
            If myparOutput("@p_StreetAddress2_2") Is DBNull.Value Then
                objpbsdistrictprofile.StreetAddress2_2 = ""
            Else
                objpbsdistrictprofile.StreetAddress2_2 = CType(myparOutput("@p_StreetAddress2_2"), String)
            End If
            If myparOutput("@p_DistrictCity_2") Is DBNull.Value Then
                objpbsdistrictprofile.DistrictCity_2 = ""
            Else
                objpbsdistrictprofile.DistrictCity_2 = CType(myparOutput("@p_DistrictCity_2"), String)
            End If
            If myparOutput("@p_DistrictState_2") Is DBNull.Value Then
                objpbsdistrictprofile.DistrictState_2 = ""
            Else
                objpbsdistrictprofile.DistrictState_2 = CType(myparOutput("@p_DistrictState_2"), String)
            End If
            If myparOutput("@p_DistrictZip_2") Is DBNull.Value Then
                objpbsdistrictprofile.DistrictZip_2 = ""
            Else
                objpbsdistrictprofile.DistrictZip_2 = CType(myparOutput("@p_DistrictZip_2"), String)
            End If
            If myparOutput("@p_DistrictPhone_2") Is DBNull.Value Then
                objpbsdistrictprofile.DistrictPhone_2 = ""
            Else
                objpbsdistrictprofile.DistrictPhone_2 = CType(myparOutput("@p_DistrictPhone_2"), String)
            End If
            If myparOutput("@p_DistrictFax_2") Is DBNull.Value Then
                objpbsdistrictprofile.DistrictFax_2 = ""
            Else
                objpbsdistrictprofile.DistrictFax_2 = CType(myparOutput("@p_DistrictFax_2"), String)
            End If
            If myparOutput("@p_DistrictCell_2") Is DBNull.Value Then
                objpbsdistrictprofile.DistrictCell_2 = ""
            Else
                objpbsdistrictprofile.DistrictCell_2 = CType(myparOutput("@p_DistrictCell_2"), String)
            End If
            If myparOutput("@p_DistrictCoordEmail_2") Is DBNull.Value Then
                objpbsdistrictprofile.DistrictCoordEmail_2 = ""
            Else
                objpbsdistrictprofile.DistrictCoordEmail_2 = CType(myparOutput("@p_DistrictCoordEmail_2"), String)
            End If
            If myparOutput("@p_DistrictInactive") Is DBNull.Value Then
                objpbsdistrictprofile.DistrictInactive = 0
            Else
                objpbsdistrictprofile.DistrictInactive = CType(myparOutput("@p_DistrictInactive"), Integer)
            End If

            Return objpbsdistrictprofile
        End Function
        '-------------------------------------------------------------------------------------------------------------------
        ' Function Name : updatefmhidistprofile  
        ' Created By : Aditi Deodhar
        ' Created Dt : March 30,2010
        ' Last Updated Dt : March 30,2010
        ' Description : This function is used to update the district profile data for FMHI login.
        '-------------------------------------------------------------------------------------------------------------------
        Shared Sub updatefmhidistprofile(ByVal objdistprofile As C21MIT.PBSIS.BO.pbsdistprofile)
            Dim oRequest As New URDALRequest
            Dim oFactory As URDALAbsDBFactory
            Dim oNonQuery As URDALNonQuery
            oFactory = New URDALSQLFactory

            With oRequest
                .Command = "dbo.flpbsis_fmhi_districtprofile_update"
                .CommandType = CommandType.StoredProcedure
            End With

            oRequest.AddParameter("@p_DistrictName", objdistprofile.DistName, URDALRequest.myDataType.dtString, 75, ParameterDirection.Input)
            oRequest.AddParameter("@p_DistrictID", objdistprofile.DistId, URDALRequest.myDataType.dtChar, 2, ParameterDirection.Input)
            oRequest.AddParameter("@p_CoordFirstName", objdistprofile.DistCoordFirstName, URDALRequest.myDataType.dtString, 50, ParameterDirection.Input)
            oRequest.AddParameter("@p_CoordLastName", objdistprofile.DistCoordFirstName, URDALRequest.myDataType.dtString, 50, ParameterDirection.Input)
            oRequest.AddParameter("@p_StreetAddress1", objdistprofile.DistStreetAddress1, URDALRequest.myDataType.dtString, 100, ParameterDirection.Input)
            oRequest.AddParameter("@p_StreetAddress2", objdistprofile.DistStreetAddress2, URDALRequest.myDataType.dtString, 100, ParameterDirection.Input)
            oRequest.AddParameter("@p_DistrictCity", objdistprofile.DistrictCity, URDALRequest.myDataType.dtString, 50, ParameterDirection.Input)
            oRequest.AddParameter("@p_DistrictState", objdistprofile.DistrictState, URDALRequest.myDataType.dtString, 2, ParameterDirection.Input)
            oRequest.AddParameter("@p_DistrictZip", objdistprofile.DistrictZip, URDALRequest.myDataType.dtString, 9, ParameterDirection.Input)
            oRequest.AddParameter("@p_DistrictPhone", objdistprofile.DistrictPhone, URDALRequest.myDataType.dtString, 20, ParameterDirection.Input)
            oRequest.AddParameter("@p_DistrictFax", objdistprofile.DistrictFax, URDALRequest.myDataType.dtString, 20, ParameterDirection.Input)
            oRequest.AddParameter("@p_DistrictCell", objdistprofile.DistrictCell, URDALRequest.myDataType.dtString, 20, ParameterDirection.Input)
            oRequest.AddParameter("@p_DistrictCoordEmail", objdistprofile.DistrictCoordEmail, URDALRequest.myDataType.dtString, 75, ParameterDirection.Input)
            oRequest.AddParameter("@p_CoordFirstName_2", objdistprofile.CoordFirstName_2, URDALRequest.myDataType.dtString, 50, ParameterDirection.Input)
            oRequest.AddParameter("@p_CoordLastName_2", objdistprofile.CoordLastName_2, URDALRequest.myDataType.dtString, 50, ParameterDirection.Input)
            oRequest.AddParameter("@p_StreetAddress1_2", objdistprofile.StreetAddress1_2, URDALRequest.myDataType.dtString, 100, ParameterDirection.Input)
            oRequest.AddParameter("@p_StreetAddress2_2", objdistprofile.StreetAddress2_2, URDALRequest.myDataType.dtString, 100, ParameterDirection.Input)
            oRequest.AddParameter("@p_DistrictCity_2", objdistprofile.DistrictCity_2, URDALRequest.myDataType.dtString, 50, ParameterDirection.Input)
            oRequest.AddParameter("@p_DistrictState_2", objdistprofile.DistrictState_2, URDALRequest.myDataType.dtString, 2, ParameterDirection.Input)
            oRequest.AddParameter("@p_DistrictZip_2", objdistprofile.DistrictZip_2, URDALRequest.myDataType.dtString, 9, ParameterDirection.Input)
            oRequest.AddParameter("@p_DistrictPhone_2", objdistprofile.DistrictPhone_2, URDALRequest.myDataType.dtString, 20, ParameterDirection.Input)
            oRequest.AddParameter("@p_DistrictFax_2", objdistprofile.DistrictFax_2, URDALRequest.myDataType.dtString, 20, ParameterDirection.Input)
            oRequest.AddParameter("@p_DistrictCell_2", objdistprofile.DistrictCell_2, URDALRequest.myDataType.dtString, 20, ParameterDirection.Input)
            oRequest.AddParameter("@p_DistrictCoordEmail_2", objdistprofile.DistrictCoordEmail_2, URDALRequest.myDataType.dtString, 75, ParameterDirection.Input)
            oRequest.AddParameter("@p_DistrictInactive", objdistprofile.DistrictInactive, URDALRequest.myDataType.dtTinyInt, , ParameterDirection.Input)

            Try
                oNonQuery = oFactory.ExecuteNonQuery(oRequest)

                If Not IsNothing(oRequest.Exception) Then
                    Throw New ApplicationException("sqlexception", oRequest.Exception)
                End If

            Catch ex As Exception
                Dim objerrLog As New MITErrorHandling.MITErrorHandling("Exception: " & "in addnewuser - " & ex.ToString())
                objerrLog.logError()
                System.Web.HttpContext.Current.Response.Redirect("~/users/smessages.aspx?qModule=TechErr", False)
            Finally
                oFactory.ConDispose()
            End Try
        End Sub
#End Region
#Region "District Coordinator Profile"
        '-------------------------------------------------------------------------------------------------------------------
        ' Function Name : addfmhidistcoordprofile  
        ' Created By : Aditi Deodhar
        ' Created Dt : March 29,2010
        ' Last Updated Dt : March 29,2010
        ' Description : This function is used to insert the DISTRICT COORDINATOR Profile data for a particular DISTRICT for FMHI login.
        '-------------------------------------------------------------------------------------------------------------------
        Shared Sub addfmhidistcoordprofile(ByVal objdistprofile As C21MIT.PBSIS.BO.pbsdistprofile)
            Dim oRequest As New URDALRequest
            Dim oFactory As URDALAbsDBFactory
            Dim oNonQuery As URDALNonQuery
            oFactory = New URDALSQLFactory

            With oRequest
                .Command = "dbo.flpbsis_fmhi_districtcoordinatorprofile_insert"
                .CommandType = CommandType.StoredProcedure
            End With


            oRequest.AddParameter("@p_DistrictID", objdistprofile.DistId, URDALRequest.myDataType.dtChar, 2, ParameterDirection.Input)
            oRequest.AddParameter("@p_CoordFirstName", objdistprofile.DistCoordFirstName, URDALRequest.myDataType.dtString, 50, ParameterDirection.Input)
            oRequest.AddParameter("@p_CoordLastName", objdistprofile.DistCoordLastName, URDALRequest.myDataType.dtString, 50, ParameterDirection.Input)
            oRequest.AddParameter("@p_DistrictCoordEmail", objdistprofile.DistrictCoordEmail, URDALRequest.myDataType.dtString, 75, ParameterDirection.Input)
            oRequest.AddParameter("@p_DistrictCoord2FirstName", objdistprofile.CoordFirstName_2, URDALRequest.myDataType.dtString, 50, ParameterDirection.Input)
            oRequest.AddParameter("@p_DistrictCoord2LastName", objdistprofile.CoordLastName_2, URDALRequest.myDataType.dtString, 50, ParameterDirection.Input)
            oRequest.AddParameter("@p_DistrictCoord2StreetAdd1", objdistprofile.StreetAddress1_2, URDALRequest.myDataType.dtString, 100, ParameterDirection.Input)
            oRequest.AddParameter("@p_DistrictCoord2StreetAdd2", objdistprofile.StreetAddress2_2, URDALRequest.myDataType.dtString, 100, ParameterDirection.Input)
            oRequest.AddParameter("@p_DistrictCoord2City", objdistprofile.DistrictCity_2, URDALRequest.myDataType.dtString, 50, ParameterDirection.Input)
            oRequest.AddParameter("@p_DistrictCoord2State", objdistprofile.DistrictState_2, URDALRequest.myDataType.dtString, 2, ParameterDirection.Input)
            oRequest.AddParameter("@p_DistrictCoord2Zip", objdistprofile.DistrictZip_2, URDALRequest.myDataType.dtString, 9, ParameterDirection.Input)
            oRequest.AddParameter("@p_DistrictCoord2Phone", objdistprofile.DistrictPhone_2, URDALRequest.myDataType.dtString, 20, ParameterDirection.Input)
            oRequest.AddParameter("@p_DistrictCoord2Fax", objdistprofile.DistrictFax_2, URDALRequest.myDataType.dtString, 20, ParameterDirection.Input)
            oRequest.AddParameter("@p_DistrictCoord2Cell", objdistprofile.DistrictCell_2, URDALRequest.myDataType.dtString, 20, ParameterDirection.Input)
            oRequest.AddParameter("@p_DistrictCoord2Email", objdistprofile.DistrictCoordEmail_2, URDALRequest.myDataType.dtString, 75, ParameterDirection.Input)
            oRequest.AddParameter("@p_DistrictCoordInactive", objdistprofile.DistCoordInactive, URDALRequest.myDataType.dtTinyInt, , ParameterDirection.Input)
            oRequest.AddParameter("@p_DistrictCoordPass", C21MIT.PBSIS.BLL.pbsPass.getRndPwd(8), URDALRequest.myDataType.dtString, 8, ParameterDirection.Input)


            Try
                oNonQuery = oFactory.ExecuteNonQuery(oRequest)

                If Not IsNothing(oRequest.Exception) Then
                    Throw New ApplicationException("sqlexception", oRequest.Exception)
                End If

            Catch ex As Exception
                Dim objerrLog As New MITErrorHandling.MITErrorHandling("Exception: " & "in addnewuser - " & ex.ToString())
                objerrLog.logError()
                System.Web.HttpContext.Current.Response.Redirect("~/users/smessages.aspx?qModule=TechErr", False)
            Finally
                oFactory.ConDispose()
            End Try
        End Sub
        '-------------------------------------------------------------------------------------------------------------------
        ' Function Name : updfmhidistcoordprofile  
        ' Created By : Aditi Deodhar
        ' Created Dt : March 31,2010
        ' Last Updated Dt : March 31,2010
        ' Description : This function is used to update the DISTRICT COORDINATOR Profile data for a particular DISTRICT for FMHI login.
        '-------------------------------------------------------------------------------------------------------------------
        Shared Sub updfmhidistcoordprofile(ByVal objdistprofile As C21MIT.PBSIS.BO.pbsdistprofile)
            Dim oRequest As New URDALRequest
            Dim oFactory As URDALAbsDBFactory
            Dim oNonQuery As URDALNonQuery
            oFactory = New URDALSQLFactory

            With oRequest
                .Command = "dbo.flpbsis_fmhi_distcoordprofile_update"
                .CommandType = CommandType.StoredProcedure
            End With


            oRequest.AddParameter("@p_DistrictCoorID", objdistprofile.DistCoordID, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_DistrictCoordDistID", objdistprofile.DistId, URDALRequest.myDataType.dtChar, 2, ParameterDirection.Input)
            oRequest.AddParameter("@p_DistrictCoordFirstName", objdistprofile.DistCoordFirstName, URDALRequest.myDataType.dtString, 50, ParameterDirection.Input)
            oRequest.AddParameter("@p_DistrictCoordLastName", objdistprofile.DistCoordLastName, URDALRequest.myDataType.dtString, 50, ParameterDirection.Input)
            oRequest.AddParameter("@p_DistrictCoordEmail", objdistprofile.DistrictCoordEmail, URDALRequest.myDataType.dtString, 75, ParameterDirection.Input)
            oRequest.AddParameter("@p_DistrictCoord2FirstName", objdistprofile.CoordFirstName_2, URDALRequest.myDataType.dtString, 50, ParameterDirection.Input)
            oRequest.AddParameter("@p_DistrictCoord2LastName", objdistprofile.CoordLastName_2, URDALRequest.myDataType.dtString, 50, ParameterDirection.Input)
            oRequest.AddParameter("@p_DistrictCoord2StreetAdd1", objdistprofile.StreetAddress1_2, URDALRequest.myDataType.dtString, 100, ParameterDirection.Input)
            oRequest.AddParameter("@p_DistrictCoord2StreetAdd2", objdistprofile.StreetAddress2_2, URDALRequest.myDataType.dtString, 100, ParameterDirection.Input)
            oRequest.AddParameter("@p_DistrictCoord2City", objdistprofile.DistrictCity_2, URDALRequest.myDataType.dtString, 50, ParameterDirection.Input)
            oRequest.AddParameter("@p_DistrictCoord2State", objdistprofile.DistrictState_2, URDALRequest.myDataType.dtString, 2, ParameterDirection.Input)
            oRequest.AddParameter("@p_DistrictCoord2Zip", objdistprofile.DistrictZip_2, URDALRequest.myDataType.dtString, 9, ParameterDirection.Input)
            oRequest.AddParameter("@p_DistrictCoord2Phone", objdistprofile.DistrictPhone_2, URDALRequest.myDataType.dtString, 20, ParameterDirection.Input)
            oRequest.AddParameter("@p_DistrictCoord2Fax", objdistprofile.DistrictFax_2, URDALRequest.myDataType.dtString, 20, ParameterDirection.Input)
            oRequest.AddParameter("@p_DistrictCoord2Cell", objdistprofile.DistrictCell_2, URDALRequest.myDataType.dtString, 20, ParameterDirection.Input)
            oRequest.AddParameter("@p_DistrictCoord2Email", objdistprofile.DistrictCoordEmail_2, URDALRequest.myDataType.dtString, 75, ParameterDirection.Input)
            oRequest.AddParameter("@p_DistrictCoordInactive", objdistprofile.DistCoordInactive, URDALRequest.myDataType.dtTinyInt, , ParameterDirection.Input)

            Try
                oNonQuery = oFactory.ExecuteNonQuery(oRequest)

                If Not IsNothing(oRequest.Exception) Then
                    Throw New ApplicationException("sqlexception", oRequest.Exception)
                End If

            Catch ex As Exception
                Dim objerrLog As New MITErrorHandling.MITErrorHandling("Exception: " & "in addnewuser - " & ex.ToString())
                objerrLog.logError()
                System.Web.HttpContext.Current.Response.Redirect("~/users/smessages.aspx?qModule=TechErr", False)
            Finally
                oFactory.ConDispose()
            End Try
        End Sub
        '-------------------------------------------------------------------------------------------------------------------
        ' Function Name : getfmhidistcoordprofile  
        ' Created By : Aditi Deodhar
        ' Created Dt : March 31,2010
        ' Last Updated Dt : March 31,2010
        ' Description : This function is used to get the district coordinate profile data for FMHI login.
        '-------------------------------------------------------------------------------------------------------------------
        Shared Function getfmhidistcoordprofile(ByVal distcoordid As String) As C21MIT.PBSIS.BO.pbsdistprofile
            Dim oRequest As New URDALRequest
            Dim oFactory As URDALAbsDBFactory
            Dim oNonQuery As URDALNonQuery
            oFactory = New URDALSQLFactory
            Dim myparOutput As New Hashtable

            Dim objpbsdistrictprofile As New C21MIT.PBSIS.BO.pbsdistprofile
            With oRequest
                .Command = "dbo.flpbsis_fmhi_distcoordprofile_select"
                .CommandType = CommandType.StoredProcedure
            End With


            oRequest.AddParameter("@p_DistrictCoorID", distcoordid, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_DistrictCoordDistID", , URDALRequest.myDataType.dtChar, 2, ParameterDirection.Output)
            oRequest.AddParameter("@p_DistrictCoordFirstName", , URDALRequest.myDataType.dtString, 50, ParameterDirection.Output)
            oRequest.AddParameter("@p_DistrictCoordLastName", , URDALRequest.myDataType.dtString, 50, ParameterDirection.Output)
            oRequest.AddParameter("@p_DistrictCoordEmail", , URDALRequest.myDataType.dtString, 75, ParameterDirection.Output)
            oRequest.AddParameter("@p_DistrictCoord2FirstName", , URDALRequest.myDataType.dtString, 50, ParameterDirection.Output)
            oRequest.AddParameter("@p_DistrictCoord2LastName", , URDALRequest.myDataType.dtString, 50, ParameterDirection.Output)
            oRequest.AddParameter("@p_DistrictCoord2StreetAdd1", , URDALRequest.myDataType.dtString, 100, ParameterDirection.Output)
            oRequest.AddParameter("@p_DistrictCoord2StreetAdd2", , URDALRequest.myDataType.dtString, 100, ParameterDirection.Output)
            oRequest.AddParameter("@p_DistrictCoord2City", , URDALRequest.myDataType.dtString, 50, ParameterDirection.Output)
            oRequest.AddParameter("@p_DistrictCoord2State", , URDALRequest.myDataType.dtString, 2, ParameterDirection.Output)
            oRequest.AddParameter("@p_DistrictCoord2Zip", , URDALRequest.myDataType.dtString, 9, ParameterDirection.Output)
            oRequest.AddParameter("@p_DistrictCoord2Phone", , URDALRequest.myDataType.dtString, 20, ParameterDirection.Output)
            oRequest.AddParameter("@p_DistrictCoord2Fax", , URDALRequest.myDataType.dtString, 20, ParameterDirection.Output)
            oRequest.AddParameter("@p_DistrictCoord2Cell", , URDALRequest.myDataType.dtString, 20, ParameterDirection.Output)
            oRequest.AddParameter("@p_DistrictCoord2Email", , URDALRequest.myDataType.dtString, 75, ParameterDirection.Output)
            oRequest.AddParameter("@p_DistrictCoordInactive", , URDALRequest.myDataType.dtTinyInt, , ParameterDirection.Output)

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
            If myparOutput("@p_DistrictCoordDistID") Is DBNull.Value Then
                objpbsdistrictprofile.DistId = ""
            Else
                objpbsdistrictprofile.DistId = CType(myparOutput("@p_DistrictCoordDistID"), String)
            End If

            If myparOutput("@p_DistrictCoordFirstName") Is DBNull.Value Then
                objpbsdistrictprofile.DistCoordFirstName = ""
            Else
                objpbsdistrictprofile.DistCoordFirstName = CType(myparOutput("@p_DistrictCoordFirstName"), String)
            End If
            If myparOutput("@p_DistrictCoordLastName") Is DBNull.Value Then
                objpbsdistrictprofile.DistCoordLastName = ""
            Else
                objpbsdistrictprofile.DistCoordLastName = CType(myparOutput("@p_DistrictCoordLastName"), String)
            End If

            If myparOutput("@p_DistrictCoordEmail") Is DBNull.Value Then
                objpbsdistrictprofile.DistrictCoordEmail = ""
            Else
                objpbsdistrictprofile.DistrictCoordEmail = CType(myparOutput("@p_DistrictCoordEmail"), String)
            End If

            If myparOutput("@p_DistrictCoord2FirstName") Is DBNull.Value Then
                objpbsdistrictprofile.CoordFirstName_2 = ""
            Else
                objpbsdistrictprofile.CoordFirstName_2 = CType(myparOutput("@p_DistrictCoord2FirstName"), String)
            End If
            If myparOutput("@p_DistrictCoord2LastName") Is DBNull.Value Then
                objpbsdistrictprofile.CoordLastName_2 = ""
            Else
                objpbsdistrictprofile.CoordLastName_2 = CType(myparOutput("@p_DistrictCoord2LastName"), String)
            End If
            If myparOutput("@p_DistrictCoord2StreetAdd1") Is DBNull.Value Then
                objpbsdistrictprofile.StreetAddress1_2 = ""
            Else
                objpbsdistrictprofile.StreetAddress1_2 = CType(myparOutput("@p_DistrictCoord2StreetAdd1"), String)
            End If
            If myparOutput("@p_DistrictCoord2StreetAdd2") Is DBNull.Value Then
                objpbsdistrictprofile.StreetAddress2_2 = ""
            Else
                objpbsdistrictprofile.StreetAddress2_2 = CType(myparOutput("@p_DistrictCoord2StreetAdd2"), String)
            End If
            If myparOutput("@p_DistrictCoord2City") Is DBNull.Value Then
                objpbsdistrictprofile.DistrictCity_2 = ""
            Else
                objpbsdistrictprofile.DistrictCity_2 = CType(myparOutput("@p_DistrictCoord2City"), String)
            End If
            If myparOutput("@p_DistrictCoord2State") Is DBNull.Value Then
                objpbsdistrictprofile.DistrictState_2 = ""
            Else
                objpbsdistrictprofile.DistrictState_2 = CType(myparOutput("@p_DistrictCoord2State"), String)
            End If
            If myparOutput("@p_DistrictCoord2Zip") Is DBNull.Value Then
                objpbsdistrictprofile.DistrictZip_2 = ""
            Else
                objpbsdistrictprofile.DistrictZip_2 = CType(myparOutput("@p_DistrictCoord2Zip"), String)
            End If
            If myparOutput("@p_DistrictCoord2Phone") Is DBNull.Value Then
                objpbsdistrictprofile.DistrictPhone_2 = ""
            Else
                objpbsdistrictprofile.DistrictPhone_2 = CType(myparOutput("@p_DistrictCoord2Phone"), String)
            End If
            If myparOutput("@p_DistrictCoord2Fax") Is DBNull.Value Then
                objpbsdistrictprofile.DistrictFax_2 = ""
            Else
                objpbsdistrictprofile.DistrictFax_2 = CType(myparOutput("@p_DistrictCoord2Fax"), String)
            End If
            If myparOutput("@p_DistrictCoord2Cell") Is DBNull.Value Then
                objpbsdistrictprofile.DistrictCell_2 = ""
            Else
                objpbsdistrictprofile.DistrictCell_2 = CType(myparOutput("@p_DistrictCoord2Cell"), String)
            End If
            If myparOutput("@p_DistrictCoord2Email") Is DBNull.Value Then
                objpbsdistrictprofile.DistrictCoordEmail_2 = ""
            Else
                objpbsdistrictprofile.DistrictCoordEmail_2 = CType(myparOutput("@p_DistrictCoord2Email"), String)
            End If

            If myparOutput("@p_DistrictCoordInactive") Is DBNull.Value Then
                objpbsdistrictprofile.DistCoordInactive = 0
            Else
                objpbsdistrictprofile.DistCoordInactive = CType(myparOutput("@p_DistrictCoordInactive"), Integer)
            End If

            Return objpbsdistrictprofile
        End Function
#End Region
#Region "District Coach Profile"
        '-------------------------------------------------------------------------------------------------------------------
        ' Function Name : getfmhidistcoachprofile  
        ' Created By : Aditi Deodhar
        ' Created Dt : April 01,2010
        ' Last Updated Dt : April 01,2010
        ' Description : This function is used to get the district coach profile data for FMHI login.
        '-------------------------------------------------------------------------------------------------------------------
        Shared Function getfmhidistcoachprofile(ByVal distcoachid As String) As C21MIT.PBSIS.BO.pbscoachprofile
            Dim oRequest As New URDALRequest
            Dim oFactory As URDALAbsDBFactory
            Dim oNonQuery As URDALNonQuery
            oFactory = New URDALSQLFactory
            Dim myparOutput As New Hashtable

            Dim objpbscoachprofile As New C21MIT.PBSIS.BO.pbscoachprofile
            With oRequest
                .Command = "dbo.flpbsis_fmhi_districtcoachprofile_select"
                .CommandType = CommandType.StoredProcedure
            End With

            oRequest.AddParameter("@p_CoachId", distcoachid, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_DistrictID", , URDALRequest.myDataType.dtChar, 2, ParameterDirection.Output)
            oRequest.AddParameter("@p_CoachFirstName", , URDALRequest.myDataType.dtString, 50, ParameterDirection.Output)
            oRequest.AddParameter("@p_CachLastName", , URDALRequest.myDataType.dtString, 50, ParameterDirection.Output)
            oRequest.AddParameter("@p_CoachStreetAddress1", , URDALRequest.myDataType.dtString, 100, ParameterDirection.Output)
            oRequest.AddParameter("@p_CoachStreetAddress2", , URDALRequest.myDataType.dtString, 100, ParameterDirection.Output)
            oRequest.AddParameter("@p_CoachCity", , URDALRequest.myDataType.dtString, 50, ParameterDirection.Output)
            oRequest.AddParameter("@p_CoachState", , URDALRequest.myDataType.dtString, 2, ParameterDirection.Output)
            oRequest.AddParameter("@p_CoachZip", , URDALRequest.myDataType.dtString, 9, ParameterDirection.Output)
            oRequest.AddParameter("@p_CoachPhone", , URDALRequest.myDataType.dtString, 20, ParameterDirection.Output)
            oRequest.AddParameter("@p_CoachFax", , URDALRequest.myDataType.dtString, 20, ParameterDirection.Output)
            oRequest.AddParameter("@p_CoachCell", , URDALRequest.myDataType.dtString, 20, ParameterDirection.Output)
            oRequest.AddParameter("@p_CoachEmail", , URDALRequest.myDataType.dtString, 75, ParameterDirection.Output)
            oRequest.AddParameter("@p_CoachInactive", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)

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
            If myparOutput("@p_DistrictID") Is DBNull.Value Then
                objpbscoachprofile.DistId = ""
            Else
                objpbscoachprofile.DistId = CType(myparOutput("@p_DistrictID"), String)
            End If

            If myparOutput("@p_CoachFirstName") Is DBNull.Value Then
                objpbscoachprofile.CoachFirstName = ""
            Else
                objpbscoachprofile.CoachFirstName = CType(myparOutput("@p_CoachFirstName"), String)
            End If
            If myparOutput("@p_CachLastName") Is DBNull.Value Then
                objpbscoachprofile.CoachLastName = ""
            Else
                objpbscoachprofile.CoachLastName = CType(myparOutput("@p_CachLastName"), String)
            End If

            If myparOutput("@p_CoachStreetAddress1") Is DBNull.Value Then
                objpbscoachprofile.CoachStreetAddress1 = ""
            Else
                objpbscoachprofile.CoachStreetAddress1 = CType(myparOutput("@p_CoachStreetAddress1"), String)
            End If

            If myparOutput("@p_CoachStreetAddress2") Is DBNull.Value Then
                objpbscoachprofile.CoachStreetAddress2 = ""
            Else
                objpbscoachprofile.CoachStreetAddress2 = CType(myparOutput("@p_CoachStreetAddress2"), String)
            End If

            If myparOutput("@p_CoachCity") Is DBNull.Value Then
                objpbscoachprofile.CoachCity = ""
            Else
                objpbscoachprofile.CoachCity = CType(myparOutput("@p_CoachCity"), String)
            End If
            If myparOutput("@p_CoachState") Is DBNull.Value Then
                objpbscoachprofile.CoachState = ""
            Else
                objpbscoachprofile.CoachState = CType(myparOutput("@p_CoachState"), String)
            End If
            If myparOutput("@p_CoachZip") Is DBNull.Value Then
                objpbscoachprofile.CoachZip = ""
            Else
                objpbscoachprofile.CoachZip = CType(myparOutput("@p_CoachZip"), String)
            End If
            If myparOutput("@p_CoachPhone") Is DBNull.Value Then
                objpbscoachprofile.CoachOfficePhone = ""
            Else
                objpbscoachprofile.CoachOfficePhone = CType(myparOutput("@p_CoachPhone"), String)
            End If
            If myparOutput("@p_CoachFax") Is DBNull.Value Then
                objpbscoachprofile.CoachFax = ""
            Else
                objpbscoachprofile.CoachFax = CType(myparOutput("@p_CoachFax"), String)
            End If
            If myparOutput("@p_CoachCell") Is DBNull.Value Then
                objpbscoachprofile.CoachCellPhone = ""
            Else
                objpbscoachprofile.CoachCellPhone = CType(myparOutput("@p_CoachCell"), String)
            End If
            If myparOutput("@p_CoachEmail") Is DBNull.Value Then
                objpbscoachprofile.CoachEmail = ""
            Else
                objpbscoachprofile.CoachEmail = CType(myparOutput("@p_CoachEmail"), String)
            End If
            If myparOutput("@p_CoachInactive") Is DBNull.Value Then
                objpbscoachprofile.CoachInactive = 0
            Else
                objpbscoachprofile.CoachInactive = CType(myparOutput("@p_CoachInactive"), String)
            End If

            Return objpbscoachprofile
        End Function
        '-------------------------------------------------------------------------------------------------------------------
        ' Function Name : addfmhidistcoachprofile  
        ' Created By : Aditi Deodhar
        ' Created Dt : March 29,2010
        ' Last Updated Dt : March 29,2010
        ' Description : This function is used to insert the DISTRICT COORDINATOR Profile data for a particular DISTRICT for FMHI login.
        '-------------------------------------------------------------------------------------------------------------------
        Shared Sub addfmhidistcoachprofile(ByVal objdistcoachprofile As C21MIT.PBSIS.BO.pbscoachprofile)
            Dim oRequest As New URDALRequest
            Dim oFactory As URDALAbsDBFactory
            Dim oNonQuery As URDALNonQuery
            oFactory = New URDALSQLFactory

            With oRequest
                .Command = "dbo.flpbsis_fmhi_districtcoachprofile_insert"
                .CommandType = CommandType.StoredProcedure
            End With


            oRequest.AddParameter("@p_DistrictID", objdistcoachprofile.DistId, URDALRequest.myDataType.dtChar, 2, ParameterDirection.Input)
            oRequest.AddParameter("@p_CoachFirstName", objdistcoachprofile.CoachFirstName, URDALRequest.myDataType.dtString, 50, ParameterDirection.Input)
            oRequest.AddParameter("@p_CoachLastName", objdistcoachprofile.CoachLastName, URDALRequest.myDataType.dtString, 50, ParameterDirection.Input)
            oRequest.AddParameter("@p_CoachStreetAddress1", objdistcoachprofile.CoachStreetAddress1, URDALRequest.myDataType.dtString, 100, ParameterDirection.Input)
            oRequest.AddParameter("@p_CoachStreetAddress2", objdistcoachprofile.CoachStreetAddress2, URDALRequest.myDataType.dtString, 100, ParameterDirection.Input)
            oRequest.AddParameter("@p_CoachCity", objdistcoachprofile.CoachCity, URDALRequest.myDataType.dtString, 50, ParameterDirection.Input)
            oRequest.AddParameter("@p_CoachState", objdistcoachprofile.CoachState, URDALRequest.myDataType.dtString, 2, ParameterDirection.Input)
            oRequest.AddParameter("@p_CoachZip", objdistcoachprofile.CoachZip, URDALRequest.myDataType.dtString, 100, ParameterDirection.Input)
            oRequest.AddParameter("@p_CoachPhone", objdistcoachprofile.CoachOfficePhone, URDALRequest.myDataType.dtString, 20, ParameterDirection.Input)
            oRequest.AddParameter("@p_CoachFax", objdistcoachprofile.CoachFax, URDALRequest.myDataType.dtString, 20, ParameterDirection.Input)
            oRequest.AddParameter("@p_CoachCell", objdistcoachprofile.CoachCellPhone, URDALRequest.myDataType.dtString, 20, ParameterDirection.Input)
            oRequest.AddParameter("@p_CoachEmail", objdistcoachprofile.CoachEmail, URDALRequest.myDataType.dtString, 75, ParameterDirection.Input)
            oRequest.AddParameter("@p_CoachInactive", objdistcoachprofile.CoachInactive, URDALRequest.myDataType.dtTinyInt, , ParameterDirection.Input)


            Try
                oNonQuery = oFactory.ExecuteNonQuery(oRequest)

                If Not IsNothing(oRequest.Exception) Then
                    Throw New ApplicationException("sqlexception", oRequest.Exception)
                End If

            Catch ex As Exception
                Dim objerrLog As New MITErrorHandling.MITErrorHandling("Exception: " & "in addnewuser - " & ex.ToString())
                objerrLog.logError()
                System.Web.HttpContext.Current.Response.Redirect("~/users/smessages.aspx?qModule=TechErr", False)
            Finally
                oFactory.ConDispose()
            End Try
        End Sub
        '-------------------------------------------------------------------------------------------------------------------
        ' Function Name : updfmhidistcoachprofile  
        ' Created By : Aditi Deodhar
        ' Created Dt : April 05,2010
        ' Last Updated Dt :April 05,2010
        ' Description : This function is used to update the DISTRICT COACH Profile data for a particular DISTRICT for FMHI login.
        '-------------------------------------------------------------------------------------------------------------------
        Shared Sub updfmhidistcoachprofile(ByVal objcoachprofile As C21MIT.PBSIS.BO.pbscoachprofile)
            Dim oRequest As New URDALRequest
            Dim oFactory As URDALAbsDBFactory
            Dim oNonQuery As URDALNonQuery
            oFactory = New URDALSQLFactory

            With oRequest
                .Command = "dbo.flpbsis_fmhi_distcoachprofile_update"
                .CommandType = CommandType.StoredProcedure
            End With


            oRequest.AddParameter("@p_CoachID", objcoachprofile.CoachID, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_DistrictID", objcoachprofile.DistId, URDALRequest.myDataType.dtChar, 2, ParameterDirection.Input)
            oRequest.AddParameter("@p_CoachFirstName", objcoachprofile.CoachFirstName, URDALRequest.myDataType.dtString, 50, ParameterDirection.Input)
            oRequest.AddParameter("@p_CoachLastName", objcoachprofile.CoachLastName, URDALRequest.myDataType.dtString, 50, ParameterDirection.Input)
            oRequest.AddParameter("@p_CoachStreetAddress1", objcoachprofile.CoachStreetAddress1, URDALRequest.myDataType.dtString, 100, ParameterDirection.Input)
            oRequest.AddParameter("@p_CoachStreetAddress2", objcoachprofile.CoachStreetAddress2, URDALRequest.myDataType.dtString, 100, ParameterDirection.Input)
            oRequest.AddParameter("@p_CoachCity", objcoachprofile.CoachCity, URDALRequest.myDataType.dtString, 50, ParameterDirection.Input)
            oRequest.AddParameter("@p_CoachState", objcoachprofile.CoachState, URDALRequest.myDataType.dtString, 2, ParameterDirection.Input)
            oRequest.AddParameter("@p_CoachZip", objcoachprofile.CoachZip, URDALRequest.myDataType.dtString, 9, ParameterDirection.Input)
            oRequest.AddParameter("@p_CoachPhone", objcoachprofile.CoachOfficePhone, URDALRequest.myDataType.dtString, 20, ParameterDirection.Input)
            oRequest.AddParameter("@p_CoachFax", objcoachprofile.CoachFax, URDALRequest.myDataType.dtString, 20, ParameterDirection.Input)
            oRequest.AddParameter("@p_CoachCell", objcoachprofile.CoachCellPhone, URDALRequest.myDataType.dtString, 20, ParameterDirection.Input)
            oRequest.AddParameter("@p_CoachEmail", objcoachprofile.CoachEmail, URDALRequest.myDataType.dtString, 75, ParameterDirection.Input)
            oRequest.AddParameter("@p_CoachInactive", objcoachprofile.CoachInactive, URDALRequest.myDataType.dtTinyInt, , ParameterDirection.Input)

            Try
                oNonQuery = oFactory.ExecuteNonQuery(oRequest)

                If Not IsNothing(oRequest.Exception) Then
                    Throw New ApplicationException("sqlexception", oRequest.Exception)
                End If

            Catch ex As Exception
                Dim objerrLog As New MITErrorHandling.MITErrorHandling("Exception: " & "in addnewuser - " & ex.ToString())
                objerrLog.logError()
                System.Web.HttpContext.Current.Response.Redirect("~/users/smessages.aspx?qModule=TechErr", False)
            Finally
                oFactory.ConDispose()
            End Try
        End Sub

        '-------------------------------------------------------------------------------------------------------------------
        ' Function Name : updfmhidistcoachinactive  
        ' Created By : Aditi Deodhar
        ' Created Dt : June 03,2010
        ' Last Updated Dt :June 03,2010
        ' Description : This function is used to update the DISTRICT COACH Inactive data for a particular DISTRICT for FMHI login.
        '-------------------------------------------------------------------------------------------------------------------
        Shared Sub updfmhidistcoachinactive(ByVal objcoachprofile As C21MIT.PBSIS.BO.pbscoachprofile)
            Dim oRequest As New URDALRequest
            Dim oFactory As URDALAbsDBFactory
            Dim oNonQuery As URDALNonQuery
            oFactory = New URDALSQLFactory

            With oRequest
                .Command = "dbo.flpbsis_fmhi_distcoachinactive_update"
                .CommandType = CommandType.StoredProcedure
            End With


            oRequest.AddParameter("@p_CoachID", objcoachprofile.CoachID, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_ActInactive", objcoachprofile.CoachInactive, URDALRequest.myDataType.dtBit, , ParameterDirection.Input)

            Try
                oNonQuery = oFactory.ExecuteNonQuery(oRequest)

                If Not IsNothing(oRequest.Exception) Then
                    Throw New ApplicationException("sqlexception", oRequest.Exception)
                End If

            Catch ex As Exception
                Dim objerrLog As New MITErrorHandling.MITErrorHandling("Exception: " & "in updfmhidistcoachinactive - " & ex.ToString())
                objerrLog.logError()
                System.Web.HttpContext.Current.Response.Redirect("~/users/smessages.aspx?qModule=TechErr", False)
            Finally
                oFactory.ConDispose()
            End Try
        End Sub
#End Region
#Region "FMHI - Form Activation"
        '-------------------------------------------------------------------------------------------------------------------
        ' Function Name : getfmhiformactivation  
        ' Created By : Aditi Deodhar
        ' Created Dt : April 06,2010
        ' Last Updated Dt : April 06,2010
        ' Description : This function is used to get the fmhi form activation/deactivation values.
        '-------------------------------------------------------------------------------------------------------------------
        Shared Function getfmhiformactivation() As C21MIT.PBSIS.BO.pbsschooldataentrylinks
            Dim oRequest As New URDALRequest
            Dim oFactory As URDALAbsDBFactory
            Dim oNonQuery As URDALNonQuery
            oFactory = New URDALSQLFactory

            Dim myparOutput As New Hashtable

            Dim objFMHIFormActDeact As New C21MIT.PBSIS.BO.pbsschooldataentrylinks

            With oRequest
                .Command = "dbo.flpbsis_fmhi_formactivate_new"
                .CommandType = CommandType.StoredProcedure
            End With


            'Output data
            oRequest.AddParameter("@p_schprofileEdit", , URDALRequest.myDataType.dtTinyInt, , ParameterDirection.Output)
            oRequest.AddParameter("@p_schDemoDataAdd", , URDALRequest.myDataType.dtTinyInt, , ParameterDirection.Output)
            oRequest.AddParameter("@p_schSTUAdd", , URDALRequest.myDataType.dtTinyInt, , ParameterDirection.Output)
            oRequest.AddParameter("@p_schTPEAdd", , URDALRequest.myDataType.dtTinyInt, , ParameterDirection.Output)
            oRequest.AddParameter("@p_schBOQSp", , URDALRequest.myDataType.dtTinyInt, , ParameterDirection.Output)
            oRequest.AddParameter("@p_schODSAdd", , URDALRequest.myDataType.dtTinyInt, , ParameterDirection.Output)
            oRequest.AddParameter("@p_schPICFall", , URDALRequest.myDataType.dtTinyInt, , ParameterDirection.Output)
            oRequest.AddParameter("@p_schPICSpring", , URDALRequest.myDataType.dtTinyInt, , ParameterDirection.Output)
            oRequest.AddParameter("@p_schBAT", , URDALRequest.myDataType.dtTinyInt, , ParameterDirection.Output)

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

            objFMHIFormActDeact.FinSchoolProfile = CType(myparOutput("@p_schprofileEdit"), Integer)
            objFMHIFormActDeact.FinSchoolDemoData = CType(myparOutput("@p_schDemoDataAdd"), Integer)
            objFMHIFormActDeact.FinSchoolTeamUpdate = CType(myparOutput("@p_schSTUAdd"), Integer)
            objFMHIFormActDeact.FinTeamProcessEval = CType(myparOutput("@p_schTPEAdd"), Integer)
            objFMHIFormActDeact.FinBOQ = CType(myparOutput("@p_schBOQSp"), Integer)
            objFMHIFormActDeact.FinOutcomeDataSum = CType(myparOutput("@p_schODSAdd"), Integer)
            objFMHIFormActDeact.FinPICFall = CType(myparOutput("@p_schPICFall"), Integer)
            objFMHIFormActDeact.FinPICSpring = CType(myparOutput("@p_schPICSpring"), Integer)
            objFMHIFormActDeact.FinBAT = CType(myparOutput("@p_schBAT"), Integer)

            Return objFMHIFormActDeact
        End Function
        '-------------------------------------------------------------------------------------------------------------------
        ' Function Name : getfmhiformactivationyrlist  
        ' Created By : Aditi Deodhar
        ' Created Dt : April 20,2010
        ' Last Updated Dt : April 20,2010
        ' Description : This function is used to get the fmhi form activation/deactivation values.
        '-------------------------------------------------------------------------------------------------------------------
        Shared Function getfmhiformactivationyrlist() As DataSet

            Dim objPBSFMHISchActMgmt As New BO.pbsgridviewobj
            Dim oRequest As New URDALRequest
            Dim oFactory As URDALAbsDBFactory
            Dim mydataset As New DataSet

            oFactory = New URDALSQLFactory
            With oRequest
                .Command = "dbo.flpbsis_fmhi_formactivate_new"
                .CommandType = CommandType.StoredProcedure
            End With

            'Output data
            oRequest.AddParameter("@p_schprofileEdit", , URDALRequest.myDataType.dtTinyInt, , ParameterDirection.Output)
            oRequest.AddParameter("@p_schDemoDataAdd", , URDALRequest.myDataType.dtTinyInt, , ParameterDirection.Output)
            oRequest.AddParameter("@p_schSTUAdd", , URDALRequest.myDataType.dtTinyInt, , ParameterDirection.Output)
            oRequest.AddParameter("@p_schTPEAdd", , URDALRequest.myDataType.dtTinyInt, , ParameterDirection.Output)
            oRequest.AddParameter("@p_schBOQSp", , URDALRequest.myDataType.dtTinyInt, , ParameterDirection.Output)
            oRequest.AddParameter("@p_schODSAdd", , URDALRequest.myDataType.dtTinyInt, , ParameterDirection.Output)
            oRequest.AddParameter("@p_schPICFall", , URDALRequest.myDataType.dtTinyInt, , ParameterDirection.Output)
            oRequest.AddParameter("@p_schPICSpring", , URDALRequest.myDataType.dtTinyInt, , ParameterDirection.Output)
            oRequest.AddParameter("@p_schBAT", , URDALRequest.myDataType.dtTinyInt, , ParameterDirection.Output)

            Try
                mydataset = oFactory.ExecuteDataSet(oRequest).ReturnedDataSet

                If Not IsNothing(oRequest.Exception) Then
                    Throw New ApplicationException("sqlexception", oRequest.Exception)
                End If
            Catch ex As Exception
                Dim objerrLog As New MITErrorHandling.MITErrorHandling(ex.ToString())
                objerrLog.logError()

                If ex.Message.Equals("sqlexception") Then
                    System.Web.HttpContext.Current.Response.Redirect _
                                               ("~/users/omessages.aspx?qModule=TechErr")
                End If

            Finally
                oFactory.ConDispose()
            End Try

            Return mydataset

        End Function
        '-------------------------------------------------------------------------------------------------------------------
        ' Function Name : updatefmhiformactivation  
        ' Created By : Aditi Deodhar
        ' Created Dt : April 07,2010
        ' Last Updated Dt : April 07,2010
        ' Description : This function is used to get the fmhi form activation/deactivation.
        '-------------------------------------------------------------------------------------------------------------------
        Shared Sub updatefmhiformactivation(ByVal objformactivation As C21MIT.PBSIS.BO.pbsschooldataentrylinks)
            Dim oRequest As New URDALRequest
            Dim oFactory As URDALAbsDBFactory
            Dim oNonQuery As URDALNonQuery
            oFactory = New URDALSQLFactory

            Dim myparOutput As New Hashtable

            Dim objFMHIFormActDeact As New C21MIT.PBSIS.BO.pbsschooldataentrylinks

            With oRequest
                .Command = "dbo.flpbsis_fmhi_formactivate_insert_new"
                .CommandType = CommandType.StoredProcedure
            End With


            'Output data
            oRequest.AddParameter("@p_schprofileEdit", objformactivation.FinSchoolProfile, URDALRequest.myDataType.dtTinyInt, , ParameterDirection.Input)
            oRequest.AddParameter("@p_schDemoDataAdd", objformactivation.FinSchoolDemoData, URDALRequest.myDataType.dtTinyInt, , ParameterDirection.Input)
            oRequest.AddParameter("@p_schSTUAdd", objformactivation.FinSchoolTeamUpdate, URDALRequest.myDataType.dtTinyInt, , ParameterDirection.Input)
            oRequest.AddParameter("@p_schTPEAdd", objformactivation.FinTeamProcessEval, URDALRequest.myDataType.dtTinyInt, , ParameterDirection.Input)
            oRequest.AddParameter("@p_schBOQSp", objformactivation.FinBOQ, URDALRequest.myDataType.dtTinyInt, , ParameterDirection.Input)
            oRequest.AddParameter("@p_schODSAdd", objformactivation.FinOutcomeDataSum, URDALRequest.myDataType.dtTinyInt, , ParameterDirection.Input)
            oRequest.AddParameter("@p_schPICFall", objformactivation.FinPICFall, URDALRequest.myDataType.dtTinyInt, , ParameterDirection.Input)
            oRequest.AddParameter("@p_schPICSpring", objformactivation.FinPICSpring, URDALRequest.myDataType.dtTinyInt, , ParameterDirection.Input)
            oRequest.AddParameter("@p_schBAT", objformactivation.FinBAT, URDALRequest.myDataType.dtTinyInt, , ParameterDirection.Input)

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

        End Sub
        '-------------------------------------------------------------------------------------------------------------------
        ' Function Name : updatefmhiformactivation  
        ' Created By : Aditi Deodhar
        ' Created Dt : April 07,2010
        ' Last Updated Dt : April 07,2010
        ' Description : This function is used to get the fmhi form activation/deactivation.
        '-------------------------------------------------------------------------------------------------------------------
        Shared Sub updatefmhiformYractivation(ByVal SchYear As Integer)
            Dim oRequest As New URDALRequest
            Dim oFactory As URDALAbsDBFactory
            Dim oNonQuery As URDALNonQuery
            oFactory = New URDALSQLFactory

            Dim myparOutput As New Hashtable

            Dim objFMHIFormActDeact As New C21MIT.PBSIS.BO.pbsschooldataentrylinks

            With oRequest
                .Command = "dbo.flpbsis_fmhi_setschoolyear_update"
                .CommandType = CommandType.StoredProcedure
            End With


            'Output data
            oRequest.AddParameter("@p_currentschYear", SchYear, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)

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

        End Sub
#End Region
    End Class
#End Region
#Region "FMHI - Tabular Reports"
    Public Class pbsfmhireports
#Region "Admin Home"
        '-------------------------------------------------------------------------------------------------------------------
        ' Function Name : getfmhiadminhomedistlist  
        ' Created By : Aditi Deodhar
        ' Description : This function is used to get the links on the FMHI Admin Home
        '-------------------------------------------------------------------------------------------------------------------
        Public Shared Function getfmhiadminhomedistlist(ByVal myDS As DataSet) As C21MIT.PBSIS.BO.PBSNavObjectList
            Dim objPBSFMHIDistReportsList As New C21MIT.PBSIS.BO.PBSNavObjectList
            Dim myRow1 As DataRow

            Dim I As Integer

            For Each myRow1 In myDS.Tables(0).Rows

                Dim myPBSFMHIDistobj1 As New C21MIT.PBSIS.BO.pbsnavigatelistobj
                myPBSFMHIDistobj1.Id = C21MIT.Util.DBNullHandler.DBNullToBlank(myRow1.Item("DistrictId"))
                myPBSFMHIDistobj1.Name = C21MIT.Util.DBNullHandler.DBNullToBlank(myRow1.Item("DistrictName"))


                'myresearchobj.HeaderText1 = "School Profile"
                myPBSFMHIDistobj1.NavigationText1 = "MYr-Monitor"
                myPBSFMHIDistobj1.NavigationLink1 = C21MIT.PBSIS.BLL.pbsclFMHINavigate.lnkFMHIAdminHome(1, myPBSFMHIDistobj1.Id).NavigationLink
                myPBSFMHIDistobj1.NavigationStatus1 = "False"

                ' myresearchobj.HeaderText2 = "School Profile"
                myPBSFMHIDistobj1.NavigationText2 = "EYr-Monitor"
                myPBSFMHIDistobj1.NavigationLink2 = C21MIT.PBSIS.BLL.pbsclFMHINavigate.lnkFMHIAdminHome(2, myPBSFMHIDistobj1.Id).NavigationLink
                myPBSFMHIDistobj1.NavigationStatus2 = "False"

                myPBSFMHIDistobj1.NavigationText3 = "MYr-SLR"
                myPBSFMHIDistobj1.NavigationLink3 = C21MIT.PBSIS.BLL.pbsclFMHINavigate.lnkFMHIAdminHome(3, myPBSFMHIDistobj1.Id).NavigationLink
                myPBSFMHIDistobj1.NavigationStatus3 = "False"


                myPBSFMHIDistobj1.NavigationText4 = "EYr-SLR"
                myPBSFMHIDistobj1.NavigationLink4 = C21MIT.PBSIS.BLL.pbsclFMHINavigate.lnkFMHIAdminHome(4, myPBSFMHIDistobj1.Id).NavigationLink
                myPBSFMHIDistobj1.NavigationStatus4 = "False"


                myPBSFMHIDistobj1.NavigationText5 = "MYr-DLR"
                myPBSFMHIDistobj1.NavigationLink5 = C21MIT.PBSIS.BLL.pbsclFMHINavigate.lnkFMHIAdminHome(5, myPBSFMHIDistobj1.Id).NavigationLink
                myPBSFMHIDistobj1.NavigationStatus5 = "False"

                myPBSFMHIDistobj1.NavigationText6 = "EYr-DLR"
                myPBSFMHIDistobj1.NavigationLink6 = C21MIT.PBSIS.BLL.pbsclFMHINavigate.lnkFMHIAdminHome(6, myPBSFMHIDistobj1.Id).NavigationLink
                myPBSFMHIDistobj1.NavigationStatus6 = "False"

                I = myDS.Tables(0).Rows.IndexOf(myRow1)
                If I = 0 Then
                Else
                    For I = 0 To 0
                        Dim myPBSFMHIDistobj2 As New C21MIT.PBSIS.BO.pbsnavigatelistobj
                        myPBSFMHIDistobj2.NavigationText2 = ""
                        myPBSFMHIDistobj2.NavigationLink2 = ""
                        myPBSFMHIDistobj2.NavigationStatus2 = ""
                        objPBSFMHIDistReportsList.Add(myPBSFMHIDistobj2)
                    Next
                End If


                objPBSFMHIDistReportsList.Add(myPBSFMHIDistobj1)
            Next ' Main Loop - Column One
            'Add row here
            Dim myPBSFMHIDistobj3 As New C21MIT.PBSIS.BO.pbsnavigatelistobj
            myPBSFMHIDistobj3.NavigationText2 = ""
            myPBSFMHIDistobj3.NavigationLink2 = ""
            myPBSFMHIDistobj3.NavigationStatus2 = ""
            objPBSFMHIDistReportsList.Add(myPBSFMHIDistobj3)

            Return objPBSFMHIDistReportsList
        End Function
#End Region
#Region "District"
        '-------------------------------------------------------------------------------------------------------------------
        ' Function Name : getfmhidistlist  
        ' Created By : Aditi Deodhar
        ' Description : This function is used to get list of districts
        '-------------------------------------------------------------------------------------------------------------------
        Public Shared Function getfmhidistlist(ByVal strPage As String) As C21MIT.PBSIS.BO.pbsgridviewobj
            Dim objPBSFMHIAdminHome As New BO.pbsgridviewobj
            Dim oRequest As New URDALRequest
            Dim oFactory As URDALAbsDBFactory
            Dim mydataset As New DataSet

            oFactory = New URDALSQLFactory

            With oRequest
                .Command = "dbo.flpbs_fmhi_getdistlist"
                .CommandType = CommandType.StoredProcedure
            End With

            Try
                mydataset = oFactory.ExecuteDataSet(oRequest).ReturnedDataSet

                If Not IsNothing(oRequest.Exception) Then
                    Throw New ApplicationException("sqlexception", oRequest.Exception)
                End If
            Catch ex As Exception
                Dim objerrLog As New MITErrorHandling.MITErrorHandling(ex.ToString())
                objerrLog.logError()

                If ex.Message.Equals("sqlexception") Then
                    System.Web.HttpContext.Current.Response.Redirect _
                                               ("~/users/omessages.aspx?qModule=TechErr")
                End If

            Finally
                oFactory.ConDispose()
            End Try

            If strPage = "AH" Then
                objPBSFMHIAdminHome.PageTitle = "PBSES Admin Home"
                objPBSFMHIAdminHome.PBSGridviewNavObjectListobj = getfmhiadminhomedistlist(mydataset)

            ElseIf strPage = "DAM" Then
                objPBSFMHIAdminHome.PageTitle = "District Account Management"
                objPBSFMHIAdminHome.PBSGridviewNavObjectListobj = getfmhidistacctlist(mydataset)
            End If

            Return objPBSFMHIAdminHome
        End Function
        '-------------------------------------------------------------------------------------------------------------------
        ' Function Name : getdistlist  
        ' Created By : Aditi Deodhar
        ' Description : This function is used to get list of districts
        '-------------------------------------------------------------------------------------------------------------------
        Public Shared Function getdistlist() As DataSet
            Dim objPBSFMHIAdminHome As New BO.pbsgridviewobj
            Dim oRequest As New URDALRequest
            Dim oFactory As URDALAbsDBFactory
            Dim mydataset As New DataSet

            oFactory = New URDALSQLFactory

            With oRequest
                .Command = "dbo.flpbs_fmhi_getdistlist"
                .CommandType = CommandType.StoredProcedure
            End With

            Try
                mydataset = oFactory.ExecuteDataSet(oRequest).ReturnedDataSet

                If Not IsNothing(oRequest.Exception) Then
                    Throw New ApplicationException("sqlexception", oRequest.Exception)
                End If
            Catch ex As Exception
                Dim objerrLog As New MITErrorHandling.MITErrorHandling(ex.ToString())
                objerrLog.logError()

                If ex.Message.Equals("sqlexception") Then
                    System.Web.HttpContext.Current.Response.Redirect _
                                               ("~/users/omessages.aspx?qModule=TechErr")
                End If

            Finally
                oFactory.ConDispose()
            End Try

            Return mydataset
        End Function
        '-------------------------------------------------------------------------------------------------------------------
        ' Function Name : getfmhidistacctlist  
        ' Created By : Aditi Deodhar
        ' Description : This function is used to get list of districts
        '-------------------------------------------------------------------------------------------------------------------
        Public Shared Function getfmhidistacctlist(ByVal myDS As DataSet) As C21MIT.PBSIS.BO.PBSNavObjectList
            Dim objPBSFMHIDistReportsList As New C21MIT.PBSIS.BO.PBSNavObjectList
            Dim myRow1 As DataRow

            Dim I As Integer

            For Each myRow1 In myDS.Tables(0).Rows

                Dim myPBSFMHIDistobj1 As New C21MIT.PBSIS.BO.pbsnavigatelistobj
                myPBSFMHIDistobj1.Id = C21MIT.Util.DBNullHandler.DBNullToBlank(myRow1.Item("DistrictId"))
                myPBSFMHIDistobj1.Name = C21MIT.Util.DBNullHandler.DBNullToBlank(myRow1.Item("DistrictName"))


                'myresearchobj.HeaderText1 = "School Profile"
                myPBSFMHIDistobj1.NavigationText1 = "Update District"
                myPBSFMHIDistobj1.NavigationLink1 = C21MIT.PBSIS.BLL.pbsclFMHINavigate.lnkFMHIDistrictAccount(1, C21MIT.PBSIS.BLL.pbsencryption.getEncryptedQString(myPBSFMHIDistobj1.Id)).NavigationLink
                myPBSFMHIDistobj1.NavigationStatus1 = "False"

                ' myresearchobj.HeaderText2 = "School Profile"
                myPBSFMHIDistobj1.NavigationText2 = "Schools"
                myPBSFMHIDistobj1.NavigationLink2 = C21MIT.PBSIS.BLL.pbsclFMHINavigate.lnkFMHIDistrictAccount(2, C21MIT.PBSIS.BLL.pbsencryption.getEncryptedQString(myPBSFMHIDistobj1.Id)).NavigationLink
                myPBSFMHIDistobj1.NavigationStatus2 = "False"

                myPBSFMHIDistobj1.NavigationText3 = "Coordinators"
                myPBSFMHIDistobj1.NavigationLink3 = C21MIT.PBSIS.BLL.pbsclFMHINavigate.lnkFMHIDistrictAccount(3, C21MIT.PBSIS.BLL.pbsencryption.getEncryptedQString(myPBSFMHIDistobj1.Id)).NavigationLink
                myPBSFMHIDistobj1.NavigationStatus3 = "False"

                myPBSFMHIDistobj1.NavigationText4 = "Coaches"
                myPBSFMHIDistobj1.NavigationLink4 = C21MIT.PBSIS.BLL.pbsclFMHINavigate.lnkFMHIDistrictAccount(4, C21MIT.PBSIS.BLL.pbsencryption.getEncryptedQString(myPBSFMHIDistobj1.Id)).NavigationLink
                myPBSFMHIDistobj1.NavigationStatus4 = "False"


                I = myDS.Tables(0).Rows.IndexOf(myRow1)
                If I = 0 Then
                Else
                    For I = 0 To 0
                        Dim myPBSFMHIDistobj2 As New C21MIT.PBSIS.BO.pbsnavigatelistobj
                        myPBSFMHIDistobj2.NavigationText2 = ""
                        myPBSFMHIDistobj2.NavigationLink2 = ""
                        myPBSFMHIDistobj2.NavigationStatus2 = ""
                        objPBSFMHIDistReportsList.Add(myPBSFMHIDistobj2)
                    Next
                End If


                objPBSFMHIDistReportsList.Add(myPBSFMHIDistobj1)
            Next ' Main Loop - Column One
            'Add row here
            Dim myPBSFMHIDistobj3 As New C21MIT.PBSIS.BO.pbsnavigatelistobj
            myPBSFMHIDistobj3.NavigationText2 = ""
            myPBSFMHIDistobj3.NavigationLink2 = ""
            myPBSFMHIDistobj3.NavigationStatus2 = ""
            objPBSFMHIDistReportsList.Add(myPBSFMHIDistobj3)

            Return objPBSFMHIDistReportsList
        End Function
#End Region
#Region "School"
        '-------------------------------------------------------------------------------------------------------------------
        ' Function Name : getfmhischoollist  
        ' Created By : Aditi Deodhar
        ' Description : This function is used to get list of schools
        '-------------------------------------------------------------------------------------------------------------------
        Public Shared Function getfmhischoollist(ByVal DistId As String, ByVal strPage As String) As C21MIT.PBSIS.BO.pbsgridviewobj
            Dim objPBSFMHISchActMgmt As New BO.pbsgridviewobj
            Dim oRequest As New URDALRequest
            Dim oFactory As URDALAbsDBFactory
            Dim mydataset As New DataSet

            oFactory = New URDALSQLFactory

            With oRequest
                .Command = "dbo.flpbs_dist_endyrslr"
                .CommandType = CommandType.StoredProcedure
            End With
            oRequest.AddParameter("@p_distid", DistId, URDALRequest.myDataType.dtChar, 2, ParameterDirection.Input)
            oRequest.AddParameter("@p_districtname", , URDALRequest.myDataType.dtString, 75, ParameterDirection.Output)
            Try
                mydataset = oFactory.ExecuteDataSet(oRequest).ReturnedDataSet


                If Not IsNothing(oRequest.Exception) Then
                    Throw New ApplicationException("sqlexception", oRequest.Exception)
                End If
            Catch ex As Exception
                Dim objerrLog As New MITErrorHandling.MITErrorHandling(ex.ToString())
                objerrLog.logError()

                If ex.Message.Equals("sqlexception") Then
                    System.Web.HttpContext.Current.Response.Redirect _
                                               ("~/users/omessages.aspx?qModule=TechErr")
                End If

            Finally
                oFactory.ConDispose()
            End Try

            If strPage = "SchAM" Then
                objPBSFMHISchActMgmt.PageTitle = "School Account Management"
                objPBSFMHISchActMgmt.PBSGridviewNavObjectListobj = getfmhischacctlist(mydataset)
            End If

            Return objPBSFMHISchActMgmt
        End Function
        '-------------------------------------------------------------------------------------------------------------------
        ' Function Name : getfmhischacctlist  
        ' Created By : Aditi Deodhar
        ' Description : This function is used to get list of schools and attach links
        '-------------------------------------------------------------------------------------------------------------------
        Public Shared Function getfmhischacctlist(ByVal myDS As DataSet) As C21MIT.PBSIS.BO.PBSNavObjectList
            Dim objPBSFMHIDistReportsList As New C21MIT.PBSIS.BO.PBSNavObjectList
            Dim myRow1 As DataRow

            Dim I As Integer

            For Each myRow1 In myDS.Tables(0).Rows

                Dim myPBSFMHISchobj1 As New C21MIT.PBSIS.BO.pbsnavigatelistobj
                myPBSFMHISchobj1.Id = C21MIT.Util.DBNullHandler.DBNullToBlank(myRow1.Item("SchoolID"))
                myPBSFMHISchobj1.Name = C21MIT.Util.DBNullHandler.DBNullToBlank(myRow1.Item("SchoolName"))


                'myresearchobj.HeaderText1 = "School Profile"
                myPBSFMHISchobj1.NavigationText1 = "Update School"
                myPBSFMHISchobj1.NavigationLink1 = C21MIT.PBSIS.BLL.pbsclFMHINavigate.lnkFMHISchoolAccount(1, C21MIT.PBSIS.BLL.pbsencryption.getEncryptedQString(myPBSFMHISchobj1.Id)).NavigationLink
                myPBSFMHISchobj1.NavigationStatus1 = "False"



                I = myDS.Tables(0).Rows.IndexOf(myRow1)
                If I = 0 Then
                Else
                    For I = 0 To 0
                        Dim myPBSFMHISchobj2 As New C21MIT.PBSIS.BO.pbsnavigatelistobj
                        myPBSFMHISchobj2.NavigationText2 = ""
                        myPBSFMHISchobj2.NavigationLink2 = ""
                        myPBSFMHISchobj2.NavigationStatus2 = ""
                        objPBSFMHIDistReportsList.Add(myPBSFMHISchobj2)
                    Next
                End If


                objPBSFMHIDistReportsList.Add(myPBSFMHISchobj1)
            Next ' Main Loop - Column One
            'Add row here
            Dim myPBSFMHISchobj3 As New C21MIT.PBSIS.BO.pbsnavigatelistobj
            myPBSFMHISchobj3.NavigationText2 = ""
            myPBSFMHISchobj3.NavigationLink2 = ""
            myPBSFMHISchobj3.NavigationStatus2 = ""
            objPBSFMHIDistReportsList.Add(myPBSFMHISchobj3)

            Return objPBSFMHIDistReportsList
        End Function
#End Region
#Region "District Coordinators"
        '-------------------------------------------------------------------------------------------------------------------
        ' Function Name : getfmhidistcoordlist  
        ' Created By : Aditi Deodhar
        ' Description : This function is used to get list of district coordinates
        '-------------------------------------------------------------------------------------------------------------------
        Public Shared Function getfmhidistcoordlist(ByVal DistId As String, ByVal strPage As String) As C21MIT.PBSIS.BO.pbsgridviewobj
            Dim objPBSFMHIDistCoordActMgmt As New BO.pbsgridviewobj
            Dim oRequest As New URDALRequest
            Dim oFactory As URDALAbsDBFactory
            Dim mydataset As New DataSet

            oFactory = New URDALSQLFactory

            With oRequest
                .Command = "dbo.flpbs_distcoord_endyrslr"
                .CommandType = CommandType.StoredProcedure
            End With
            oRequest.AddParameter("@p_distid", DistId, URDALRequest.myDataType.dtChar, 2, ParameterDirection.Input)
            oRequest.AddParameter("@p_districtname", , URDALRequest.myDataType.dtString, 75, ParameterDirection.Output)
            Try
                mydataset = oFactory.ExecuteDataSet(oRequest).ReturnedDataSet


                If Not IsNothing(oRequest.Exception) Then
                    Throw New ApplicationException("sqlexception", oRequest.Exception)
                End If
            Catch ex As Exception
                Dim objerrLog As New MITErrorHandling.MITErrorHandling(ex.ToString())
                objerrLog.logError()

                If ex.Message.Equals("sqlexception") Then
                    System.Web.HttpContext.Current.Response.Redirect _
                                               ("~/users/omessages.aspx?qModule=TechErr")
                End If

            Finally
                oFactory.ConDispose()
            End Try

            If strPage = "DistCAM" Then
                objPBSFMHIDistCoordActMgmt.PageTitle = "District Coordinator Account Management"
                objPBSFMHIDistCoordActMgmt.PBSGridviewNavObjectListobj = getfmhidistcoordacctlist(mydataset)
            End If

            Return objPBSFMHIDistCoordActMgmt
        End Function
        '-------------------------------------------------------------------------------------------------------------------
        ' Function Name : getfmhidistcoordacctlist  
        ' Created By : Aditi Deodhar
        ' Description : This function is used to get list of district coordinates
        '-------------------------------------------------------------------------------------------------------------------
        Public Shared Function getfmhidistcoordacctlist(ByVal myDS As DataSet) As C21MIT.PBSIS.BO.PBSNavObjectList
            Dim objPBSFMHIDistCoordReportsList As New C21MIT.PBSIS.BO.PBSNavObjectList
            Dim myRow1 As DataRow

            Dim I As Integer

            For Each myRow1 In myDS.Tables(0).Rows

                Dim myPBSFMHIDistCoordobj1 As New C21MIT.PBSIS.BO.pbsnavigatelistobj
                myPBSFMHIDistCoordobj1.Id = C21MIT.Util.DBNullHandler.DBNullToBlank(myRow1.Item("DistrictCoorID"))
                myPBSFMHIDistCoordobj1.Name = C21MIT.Util.DBNullHandler.DBNullToBlank(myRow1.Item("DistCoordName"))


                'myresearchobj.HeaderText1 = "School Profile"
                myPBSFMHIDistCoordobj1.NavigationText1 = "Update District Coordinator"
                myPBSFMHIDistCoordobj1.NavigationLink1 = C21MIT.PBSIS.BLL.pbsclFMHINavigate.lnkFMHIDistCoordAccount(1, C21MIT.PBSIS.BLL.pbsencryption.getEncryptedQString(myPBSFMHIDistCoordobj1.Id)).NavigationLink
                myPBSFMHIDistCoordobj1.NavigationStatus1 = "False"



                I = myDS.Tables(0).Rows.IndexOf(myRow1)
                If I = 0 Then
                Else
                    For I = 0 To 0
                        Dim myPBSFMHIDistCoordobj2 As New C21MIT.PBSIS.BO.pbsnavigatelistobj
                        myPBSFMHIDistCoordobj2.NavigationText2 = ""
                        myPBSFMHIDistCoordobj2.NavigationLink2 = ""
                        myPBSFMHIDistCoordobj2.NavigationStatus2 = ""
                        objPBSFMHIDistCoordReportsList.Add(myPBSFMHIDistCoordobj2)
                    Next
                End If


                objPBSFMHIDistCoordReportsList.Add(myPBSFMHIDistCoordobj1)
            Next ' Main Loop - Column One
            'Add row here
            Dim myPBSFMHIDistCoordobj3 As New C21MIT.PBSIS.BO.pbsnavigatelistobj
            myPBSFMHIDistCoordobj3.NavigationText2 = ""
            myPBSFMHIDistCoordobj3.NavigationLink2 = ""
            myPBSFMHIDistCoordobj3.NavigationStatus2 = ""
            objPBSFMHIDistCoordReportsList.Add(myPBSFMHIDistCoordobj3)

            Return objPBSFMHIDistCoordReportsList
        End Function
#End Region
#Region "District Coaches"
        '-------------------------------------------------------------------------------------------------------------------
        ' Function Name : getfmhidistcoachlist  
        ' Created By : Aditi Deodhar
        ' Description : This function is used to get list of district coaches
        '-------------------------------------------------------------------------------------------------------------------
        Public Shared Function getfmhidistcoachlist(ByVal DistId As String, ByVal strPage As String) As C21MIT.PBSIS.BO.pbsgridviewobj
            Dim objPBSFMHIDistCoachActMgmt As New BO.pbsgridviewobj
            Dim oRequest As New URDALRequest
            Dim oFactory As URDALAbsDBFactory
            Dim mydataset As New DataSet

            oFactory = New URDALSQLFactory

            With oRequest
                .Command = "dbo.flpbs_distcoach_endyrslr"
                .CommandType = CommandType.StoredProcedure
            End With
            oRequest.AddParameter("@p_distid", DistId, URDALRequest.myDataType.dtChar, 2, ParameterDirection.Input)
            oRequest.AddParameter("@p_districtname", , URDALRequest.myDataType.dtString, 75, ParameterDirection.Output)
            Try
                mydataset = oFactory.ExecuteDataSet(oRequest).ReturnedDataSet


                If Not IsNothing(oRequest.Exception) Then
                    Throw New ApplicationException("sqlexception", oRequest.Exception)
                End If
            Catch ex As Exception
                Dim objerrLog As New MITErrorHandling.MITErrorHandling(ex.ToString())
                objerrLog.logError()

                If ex.Message.Equals("sqlexception") Then
                    System.Web.HttpContext.Current.Response.Redirect _
                                               ("~/users/omessages.aspx?qModule=TechErr")
                End If

            Finally
                oFactory.ConDispose()
            End Try

            If strPage = "DCoachAM" Then
                objPBSFMHIDistCoachActMgmt.PageTitle = "District Coach Account Management"
                objPBSFMHIDistCoachActMgmt.PBSGridviewNavObjectListobj = getfmhidistcoachacctlist(mydataset)
            End If

            Return objPBSFMHIDistCoachActMgmt

        End Function
        '-------------------------------------------------------------------------------------------------------------------
        ' Function Name : getfmhidistcoachacctlist  
        ' Created By : Aditi Deodhar
        ' Description : This function is used to get list of district coaches
        '-------------------------------------------------------------------------------------------------------------------
        Public Shared Function getfmhidistcoachacctlist(ByVal myDS As DataSet) As C21MIT.PBSIS.BO.PBSNavObjectList
            Dim objPBSFMHIDistCoachReportsList As New C21MIT.PBSIS.BO.PBSNavObjectList
            Dim myRow1 As DataRow

            'Dim I As Integer

            For Each myRow1 In myDS.Tables(0).Rows
                Dim myPBSFMHIDistCoachobj1 As New C21MIT.PBSIS.BO.pbsnavigatelistobj
                myPBSFMHIDistCoachobj1.Id = C21MIT.Util.DBNullHandler.DBNullToBlank(myRow1.Item("CoachID"))
                myPBSFMHIDistCoachobj1.Name = C21MIT.Util.DBNullHandler.DBNullToBlank(myRow1.Item("CoachName"))
                myPBSFMHIDistCoachobj1.CoachInactive = C21MIT.Util.DBNullHandler.DBNullToBlank(myRow1.Item("CoachInactive"))

                myPBSFMHIDistCoachobj1.NavigationText1 = "Update Coach"
                myPBSFMHIDistCoachobj1.NavigationLink1 = C21MIT.PBSIS.BLL.pbsclFMHINavigate.lnkFMHIDistCoachAccount(1, C21MIT.PBSIS.BLL.pbsencryption.getEncryptedQString(myPBSFMHIDistCoachobj1.Id)).NavigationLink
                myPBSFMHIDistCoachobj1.NavigationStatus1 = "False"

                myPBSFMHIDistCoachobj1.itemtemplate = Nothing
                myPBSFMHIDistCoachobj1.NavigationLink3 = C21MIT.PBSIS.BLL.pbsclFMHINavigate.lnkFMHIDistCoachAccount(1, C21MIT.PBSIS.BLL.pbsencryption.getEncryptedQString(myPBSFMHIDistCoachobj1.Id)).NavigationLink
                myPBSFMHIDistCoachobj1.NavigationStatus3 = "False"

                'I = myDS.Tables(0).Rows.IndexOf(myRow1)
                'If I = 0 Then
                'Else
                '    For I = 0 To 0
                '        Dim myPBSFMHIDistCoachobj2 As New C21MIT.PBSIS.BO.pbsnavigatelistobj
                '        myPBSFMHIDistCoachobj2.NavigationText2 = ""
                '        myPBSFMHIDistCoachobj2.NavigationLink2 = ""
                '        myPBSFMHIDistCoachobj2.NavigationStatus2 = ""
                '        objPBSFMHIDistCoachReportsList.Add(myPBSFMHIDistCoachobj2)
                '    Next
                'End If
                objPBSFMHIDistCoachReportsList.Add(myPBSFMHIDistCoachobj1)
            Next ' Main Loop - Column One
            'Add row here
            'Dim myPBSFMHIDistCoachobj3 As New C21MIT.PBSIS.BO.pbsnavigatelistobj
            'myPBSFMHIDistCoachobj3.NavigationText2 = ""
            'myPBSFMHIDistCoachobj3.NavigationLink2 = ""
            'myPBSFMHIDistCoachobj3.NavigationStatus2 = ""
            'objPBSFMHIDistCoachReportsList.Add(myPBSFMHIDistCoachobj3)

            Return objPBSFMHIDistCoachReportsList
        End Function
#End Region
    End Class

    
#End Region
End Namespace
