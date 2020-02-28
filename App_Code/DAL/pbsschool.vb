Imports URDAL
Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.VisualBasic
Namespace C21MIT.PBSIS.DAL
#Region "School Data entry Links"
    Public Class pbsschooldataentrylinks
        '-------------------------------------------------------------------------------------------------------------------
        ' Function Name : getschooldataentrylinks  
        ' Created By : Aditi Deodhar
        ' Created Dt : Feb 11,2010
        ' Last Updated Dt : Feb 11,2010
        ' Description : This function is used to get the school data entry links for a particular school and acadyear.
        '-------------------------------------------------------------------------------------------------------------------
        Shared Function getschooldataentrylinks(ByVal schoolid As String, ByVal acadyear As Integer) As C21MIT.PBSIS.BO.pbsschooldataentrylinks
            Dim oRequest As New URDALRequest
            Dim oFactory As URDALAbsDBFactory
            Dim oNonQuery As URDALNonQuery
            oFactory = New URDALSQLFactory

            Dim myparOutput As New Hashtable

            Dim objSchoolDataEntryLinks As New C21MIT.PBSIS.BO.pbsschooldataentrylinks

            With oRequest
                .Command = "dbo.flpbs_school_mainmenu_new"
                .CommandType = CommandType.StoredProcedure
            End With

            'Input data
            oRequest.AddParameter("@p_SchoolID", schoolid, URDALRequest.myDataType.dtString, 6, ParameterDirection.Input)
            oRequest.AddParameter("@p_acadyear", acadyear, URDALRequest.myDataType.dtTinyInt, , ParameterDirection.Input)

            'Output data
            oRequest.AddParameter("@p_schoolname", , URDALRequest.myDataType.dtString, 75, ParameterDirection.Output)
            oRequest.AddParameter("@p_districtname", , URDALRequest.myDataType.dtString, 75, ParameterDirection.Output)

            'Check existing records to mark completion (count returns 0 or 1)
            oRequest.AddParameter("@p_FinBI", , URDALRequest.myDataType.dtTinyInt, , ParameterDirection.Output)
            oRequest.AddParameter("@p_FinSchoolDemoData", , URDALRequest.myDataType.dtTinyInt, , ParameterDirection.Output)
            oRequest.AddParameter("@p_FinSchoolTeamUpdate", , URDALRequest.myDataType.dtTinyInt, , ParameterDirection.Output)
            oRequest.AddParameter("@p_FinPEVALTAR", , URDALRequest.myDataType.dtTinyInt, , ParameterDirection.Output)
            oRequest.AddParameter("@p_Fintic", , URDALRequest.myDataType.dtTinyInt, , ParameterDirection.Output)
            oRequest.AddParameter("@p_Fintic1", , URDALRequest.myDataType.dtTinyInt, , ParameterDirection.Output)
            oRequest.AddParameter("@p_FinBOQ", , URDALRequest.myDataType.dtTinyInt, , ParameterDirection.Output)
            oRequest.AddParameter("@p_FinOutcomeDataSum", , URDALRequest.myDataType.dtTinyInt, , ParameterDirection.Output)
            oRequest.AddParameter("@p_FinBAT", , URDALRequest.myDataType.dtTinyInt, , ParameterDirection.Output)

            'Check if admin has allowed links to be seen for this time period (returns a 0 or 1)
            oRequest.AddParameter("@p_AvailBI", , URDALRequest.myDataType.dtTinyInt, , ParameterDirection.Output)
            oRequest.AddParameter("@p_AvailSchoolDemoData", , URDALRequest.myDataType.dtTinyInt, , ParameterDirection.Output)
            oRequest.AddParameter("@p_AvailSchoolTeamUpdate", , URDALRequest.myDataType.dtTinyInt, , ParameterDirection.Output)
            oRequest.AddParameter("@p_AvailPEVALTAR", , URDALRequest.myDataType.dtTinyInt, , ParameterDirection.Output)
            oRequest.AddParameter("@p_Availtic", , URDALRequest.myDataType.dtTinyInt, , ParameterDirection.Output)
            oRequest.AddParameter("@p_Availtic1", , URDALRequest.myDataType.dtTinyInt, , ParameterDirection.Output)
            oRequest.AddParameter("@p_AvailBOQ", , URDALRequest.myDataType.dtTinyInt, , ParameterDirection.Output)
            oRequest.AddParameter("@p_AvailOutcomeDataSum", , URDALRequest.myDataType.dtTinyInt, , ParameterDirection.Output)
            oRequest.AddParameter("@p_AvailBAT", , URDALRequest.myDataType.dtTinyInt, , ParameterDirection.Output)

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
            If myparOutput("@p_SchoolName") Is DBNull.Value Then
                objSchoolDataEntryLinks.SchoolName = ""
            Else
                objSchoolDataEntryLinks.SchoolName = CType(myparOutput("@p_SchoolName"), String)
            End If

            If myparOutput("@p_districtname") Is DBNull.Value Then
                objSchoolDataEntryLinks.DistName = ""
            Else
                objSchoolDataEntryLinks.DistName = CType(myparOutput("@p_districtname"), String)
            End If

            objSchoolDataEntryLinks.FinBI = CType(myparOutput("@p_FinBI"), Integer)
            objSchoolDataEntryLinks.FinSchoolDemoData = CType(myparOutput("@p_FinSchoolDemoData"), Integer)
            objSchoolDataEntryLinks.FinSchoolTeamUpdate = CType(myparOutput("@p_FinSchoolTeamUpdate"), Integer)
            objSchoolDataEntryLinks.FinPEVALTAR = CType(myparOutput("@p_FinPEVALTARv"), Integer)
            objSchoolDataEntryLinks.FinPICFall = CType(myparOutput("@p_Fintic"), Integer)
            objSchoolDataEntryLinks.FinPICSpring = CType(myparOutput("@p_Fintic1"), Integer)
            objSchoolDataEntryLinks.FinBOQ = CType(myparOutput("@p_FinBOQ"), Integer)
            objSchoolDataEntryLinks.FinOutcomeDataSum = CType(myparOutput("@p_FinOutcomeDataSum"), Integer)
            objSchoolDataEntryLinks.FinBAT = CType(myparOutput("@p_FinBAT"), Integer)

            objSchoolDataEntryLinks.AvailBI = CType(myparOutput("@p_AvailBI"), Integer)
            objSchoolDataEntryLinks.AvailSchoolDemoData = CType(myparOutput("@p_AvailSchoolDemoData"), Integer)
            objSchoolDataEntryLinks.AvailSchoolTeamUpdate = CType(myparOutput("@p_AvailSchoolTeamUpdate"), Integer)
            objSchoolDataEntryLinks.AvailPEVALTAR = CType(myparOutput("@p_AvailPEVALTAR"), Integer)
            objSchoolDataEntryLinks.AvailPICFall = CType(myparOutput("@p_Availtic"), Integer)
            objSchoolDataEntryLinks.AvailPICSpring = CType(myparOutput("@p_Availtic1"), Integer)
            objSchoolDataEntryLinks.AvailBOQ = CType(myparOutput("@p_AvailBOQ"), Integer)
            objSchoolDataEntryLinks.AvailOutcomeDataSum = CType(myparOutput("@p_AvailOutcomeDataSum"), Integer)
            objSchoolDataEntryLinks.AvailBAT = CType(myparOutput("@p_AvailBAT"), Integer)

            Return objSchoolDataEntryLinks
        End Function
    End Class
#End Region
#Region "School Forms"
#Region "School Profile"
    Public Class pbsschoolprofile
        '-------------------------------------------------------------------------------------------------------------------
        ' Function Name : fngetschoolprofile  
        ' Created By : Aditi Deodhar
        ' Created Dt : Feb 04,2010
        ' Last Updated Dt : Feb 04,2010
        ' Description : This function is used to get the school profile data for a particular school.
        '-------------------------------------------------------------------------------------------------------------------
        Shared Function fngetschoolprofile(ByVal schoolid As String) As C21MIT.PBSIS.BO.pbsschoolprofile
            Dim oRequest As New URDALRequest
            Dim oFactory As URDALAbsDBFactory
            Dim oNonQuery As URDALNonQuery
            oFactory = New URDALSQLFactory

            Dim myparOutput As New Hashtable

            Dim objSchoolProfile As New C21MIT.PBSIS.BO.pbsschoolprofile

            With oRequest
                .Command = "dbo.flpbsis_school_profile_select"
                .CommandType = CommandType.StoredProcedure
            End With

            oRequest.AddParameter("@p_SchoolID", schoolid, URDALRequest.myDataType.dtString, 6, ParameterDirection.Input)
            oRequest.AddParameter("@p_SchoolName", , URDALRequest.myDataType.dtString, 75, ParameterDirection.Output)
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
            oRequest.AddParameter("@p_SchoolType", , URDALRequest.myDataType.dtChar, 2, ParameterDirection.Output)

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

            If myparOutput("@p_SchoolName") Is DBNull.Value Then
                objSchoolProfile.SchoolName = ""
            Else
                objSchoolProfile.SchoolName = CType(myparOutput("@p_SchoolName"), String)
            End If

            If myparOutput("@p_SchoolStreetAddress1") Is DBNull.Value Then
                objSchoolProfile.SchoolStreetAddress1 = ""
            Else
                objSchoolProfile.SchoolStreetAddress1 = CType(myparOutput("@p_SchoolStreetAddress1"), String)
            End If

            If myparOutput("@p_SchoolStreetAddress2") Is DBNull.Value Then
                objSchoolProfile.SchoolStreetAddress2 = ""
            Else
                objSchoolProfile.SchoolStreetAddress2 = CType(myparOutput("@p_SchoolStreetAddress2"), String)
            End If

            If myparOutput("@p_SchoolCity") Is DBNull.Value Then
                objSchoolProfile.SchoolCity = ""
            Else
                objSchoolProfile.SchoolCity = CType(myparOutput("@p_SchoolCity"), String)
            End If

            If myparOutput("@p_SchoolState") Is DBNull.Value Then
                objSchoolProfile.SchoolState = ""
            Else
                objSchoolProfile.SchoolState = CType(myparOutput("@p_SchoolState"), String)
            End If

            If myparOutput("@p_SchoolZip") Is DBNull.Value Then
                objSchoolProfile.SchoolZip = ""
            Else
                objSchoolProfile.SchoolZip = CType(myparOutput("@p_SchoolZip"), String)
            End If

            If myparOutput("@p_SchoolPhone") Is DBNull.Value Then
                objSchoolProfile.SchoolPhone = ""
            Else
                objSchoolProfile.SchoolPhone = CType(myparOutput("@p_SchoolPhone"), String)
            End If

            If myparOutput("@p_SchoolFax") Is DBNull.Value Then
                objSchoolProfile.SchoolFax = ""
            Else
                objSchoolProfile.SchoolFax = CType(myparOutput("@p_SchoolFax"), String)
            End If

            If myparOutput("@p_SchoolAdministratorName") Is DBNull.Value Then
                objSchoolProfile.SchoolAdministratorName = ""
            Else
                objSchoolProfile.SchoolAdministratorName = CType(myparOutput("@p_SchoolAdministratorName"), String)
            End If

            If myparOutput("@p_SchoolAdministratorPhone") Is DBNull.Value Then
                objSchoolProfile.SchoolAdministratorPhone = ""
            Else
                objSchoolProfile.SchoolAdministratorPhone = CType(myparOutput("@p_SchoolAdministratorPhone"), String)
            End If

            If myparOutput("@p_SchoolAdministratorEmail") Is DBNull.Value Then
                objSchoolProfile.SchoolAdministratorEmail = ""
            Else
                objSchoolProfile.SchoolAdministratorEmail = CType(myparOutput("@p_SchoolAdministratorEmail"), String)
            End If

            If myparOutput("@p_SchoolType") Is DBNull.Value Then
                objSchoolProfile.SchoolType = ""
            Else
                objSchoolProfile.SchoolType = CType(myparOutput("@p_SchoolType"), String)
            End If

            Return objSchoolProfile

        End Function
        '-------------------------------------------------------------------------------------------------------------------
        ' Function Name : updschoolprofile  
        ' Created By : Aditi Deodhar
        ' Created Dt : Feb 09,2010
        ' Last Updated Dt : Feb 09,2010
        ' Description : This function is used to update the school profile data for a particular school.
        '-------------------------------------------------------------------------------------------------------------------
        Shared Sub updschoolprofile(ByVal objschoolprofile As C21MIT.PBSIS.BO.pbsschoolprofile)
            Dim oRequest As New URDALRequest
            Dim oFactory As URDALAbsDBFactory
            Dim oNonQuery As URDALNonQuery
            oFactory = New URDALSQLFactory

            With oRequest
                .Command = "dbo.flpbsis_school_profile_update"
                .CommandType = CommandType.StoredProcedure
            End With

            oRequest.AddParameter("@p_SchoolID", objschoolprofile.SchoolId, URDALRequest.myDataType.dtChar, 6, ParameterDirection.Input)
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
    End Class
#End Region
#Region "PIC_BOQ_COACHES"
    Public Class pbslPIC_BOQSchool
        '-------------------------------------------------------------------------------------------------------------------
        ' Function Name : fngetPIC_BOQGetCoaches  
        ' Created By : Aditi Deodhar
        ' Created Dt : Feb 17,2010
        ' Last Updated Dt : Feb 17,2010
        ' Description : This function is used to get all the BOQ Coaches for a particular school.
        '-------------------------------------------------------------------------------------------------------------------
        Shared Function fngetPIC_BOQGetCoaches(ByVal schoolID As String) As DataSet
            Dim oRequest As New URDALRequest
            Dim oFactory As URDALAbsDBFactory
            Dim myDataset As New DataSet
            oFactory = New URDALSQLFactory

            With oRequest
                .Command = "dbo.flpbsis_school_receivecoach"
                .CommandType = CommandType.StoredProcedure
            End With
            oRequest.AddParameter("@p_schoolid", schoolID, URDALRequest.myDataType.dtChar, 6, ParameterDirection.Input)
            Try
                myDataset = oFactory.ExecuteDataSet(oRequest).ReturnedDataSet

                If Not IsNothing(oRequest.Exception) Then
                    Throw New ApplicationException("sqlexception", oRequest.Exception)
                End If
            Catch ex As Exception
                Dim objerrLog As New MITErrorHandling.MITErrorHandling("Exception: " & "in getRatingMasterdata - " & ex.ToString())
                objerrLog.logError()
                System.Web.HttpContext.Current.Response.Redirect("~/users/smessages.aspx?qModule=TechErr", False)
            Finally
                oFactory.ConDispose()

            End Try
            Return myDataset
        End Function
    End Class
#End Region
#Region "PIC Mid Year School"
    Public Class pbslpicMidYearSchool
        '-------------------------------------------------------------------------------------------------------------------
        ' Function Name : fngetPICMidYearSchool  
        ' Created By : Aditi Deodhar
        ' Created Dt : Feb 08,2010
        ' Last Updated Dt : Feb 10,2010
        ' Description : This function is used to get all the PIC Mid Year question values for a particular school.
        '-------------------------------------------------------------------------------------------------------------------
        Shared Function fngetPICMidYearSchool(ByVal schoolID As String, ByVal schoolYr As Integer, ByVal schoolInterval As Integer) As C21MIT.PBSIS.BO.pbsschoolreport
            Dim oRequest As New URDALRequest
            Dim oFactory As URDALAbsDBFactory
            Dim oNonQuery As URDALNonQuery
            oFactory = New URDALSQLFactory

            Dim myparOutput As New Hashtable

            Dim objPICMidYearSchool As New C21MIT.PBSIS.BO.pbsschoolreport

            With oRequest
                .Command = "dbo.flpbsis_school_Pic_select"
                .CommandType = CommandType.StoredProcedure
            End With

            oRequest.AddParameter("@p_PicSchoolID", schoolID, URDALRequest.myDataType.dtChar, 6, ParameterDirection.Input)
            oRequest.AddParameter("@p_PicSchoolYear", schoolYr, URDALRequest.myDataType.dtTinyInt, , ParameterDirection.Input)
            oRequest.AddParameter("@p_PicInterval", schoolInterval, URDALRequest.myDataType.dtTinyInt, , ParameterDirection.Input)

            oRequest.AddParameter("@p_PicSchoolName", , URDALRequest.myDataType.dtString, 75, ParameterDirection.Output)
            oRequest.AddParameter("@p_PicDistrictName", , URDALRequest.myDataType.dtString, 75, ParameterDirection.Output)
            oRequest.AddParameter("@p_PicCoachName", , URDALRequest.myDataType.dtString, 100, ParameterDirection.Output)

            oRequest.AddParameter("@p_PicQuestion1", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_PicQuestion2", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_PicQuestion3", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_PicQuestion4", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_PicQuestion5", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_PicQuestion6", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_PicQuestion7", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_PicQuestion8", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_PicQuestion9", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_PicQuestion10", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_PicQuestion11", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_PicQuestion12", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_PicQuestion13", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_PicQuestion14", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_PicQuestion15", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_PicQuestion16", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_PicQuestion17", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_PicQuestion18", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_PicQuestion19", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_PicQuestion20", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_PicQuestion21", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_PicQuestion22", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_PicQuestion23", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_PicQuestion24", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_PicQuestion25", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_PicQuestion26", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_PicQuestion27", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_PicQuestion28", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_PicQuestion29", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_PicQuestion30", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_PicQuestion31", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_PicQuestion32", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_PicQuestion33", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_PicQuestion34", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_PicQuestion35", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_PicQuestion36", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_PicQuestion37", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_PicQuestion38", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_PicQuestion39", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_PicQuestion40", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_PicQuestion41", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_PicQuestion42", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_PicQuestion43", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_PicQuestion44", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)

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

            'objPICMidYearSchool.SchoolName = CType(myparOutput("@p_PicSchoolName"), String)
            If myparOutput("@p_PicSchoolName") Is DBNull.Value Then
                objPICMidYearSchool.SchoolName = ""
            Else
                objPICMidYearSchool.SchoolName = C21MIT.Util.DBNullHandler.DBNullToBlank(CType(myparOutput("@p_PicSchoolName"), String))

            End If
            'objPICMidYearSchool.DistrictName = CType(myparOutput("@p_PicDistrictName"), String)
            If myparOutput("@p_PicDistrictName") Is DBNull.Value Then
                objPICMidYearSchool.DistrictName = ""
            Else
                objPICMidYearSchool.DistrictName = C21MIT.Util.DBNullHandler.DBNullToBlank(CType(myparOutput("@p_PicDistrictName"), String))

            End If
            If myparOutput("@p_PicCoachName") Is DBNull.Value Then
                objPICMidYearSchool.CoachName = ""
            Else
                objPICMidYearSchool.CoachName = C21MIT.Util.DBNullHandler.DBNullToBlank(CType(myparOutput("@p_PicCoachName"), String))

            End If

            If myparOutput("@p_PicQuestion1") Is DBNull.Value Then
                objPICMidYearSchool.Question1 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_PicQuestion1"))
            Else
                objPICMidYearSchool.Question1 = CType(myparOutput("@p_PicQuestion1"), Single)
            End If

            If myparOutput("@p_PicQuestion2") Is DBNull.Value Then
                objPICMidYearSchool.Question2 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_PicQuestion2"))
            Else
                objPICMidYearSchool.Question2 = CType(myparOutput("@p_PicQuestion2"), Single)
            End If


            If myparOutput("@p_PicQuestion3") Is DBNull.Value Then
                objPICMidYearSchool.Question3 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_PicQuestion3"))
            Else
                objPICMidYearSchool.Question3 = CType(myparOutput("@p_PicQuestion3"), Single)
            End If

            If myparOutput("@p_PicQuestion4") Is DBNull.Value Then
                objPICMidYearSchool.Question4 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_PicQuestion4"))
            Else
                objPICMidYearSchool.Question4 = CType(myparOutput("@p_PicQuestion4"), Single)
            End If

            If myparOutput("@p_PicQuestion5") Is DBNull.Value Then
                objPICMidYearSchool.Question5 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_PicQuestion5"))
            Else
                objPICMidYearSchool.Question5 = CType(myparOutput("@p_PicQuestion5"), Single)
            End If

            If myparOutput("@p_PicQuestion6") Is DBNull.Value Then
                objPICMidYearSchool.Question6 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_PicQuestion6"))
            Else
                objPICMidYearSchool.Question6 = CType(myparOutput("@p_PicQuestion6"), Single)
            End If

            If myparOutput("@p_PicQuestion7") Is DBNull.Value Then
                objPICMidYearSchool.Question7 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_PicQuestion7"))
            Else
                objPICMidYearSchool.Question7 = CType(myparOutput("@p_PicQuestion7"), Single)
            End If

            If myparOutput("@p_PicQuestion8") Is DBNull.Value Then
                objPICMidYearSchool.Question8 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_PicQuestion8"))
            Else
                objPICMidYearSchool.Question8 = CType(myparOutput("@p_PicQuestion8"), Single)
            End If

            If myparOutput("@p_PicQuestion9") Is DBNull.Value Then
                objPICMidYearSchool.Question9 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_PicQuestion9"))
            Else
                objPICMidYearSchool.Question9 = CType(myparOutput("@p_PicQuestion9"), Single)
            End If

            If myparOutput("@p_PicQuestion10") Is DBNull.Value Then
                objPICMidYearSchool.Question10 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_PicQuestion10"))
            Else
                objPICMidYearSchool.Question10 = CType(myparOutput("@p_PicQuestion10"), Single)
            End If

            If myparOutput("@p_PicQuestion11") Is DBNull.Value Then
                objPICMidYearSchool.Question11 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_PicQuestion11"))
            Else
                objPICMidYearSchool.Question11 = CType(myparOutput("@p_PicQuestion11"), Single)
            End If
            If myparOutput("@p_PicQuestion12") Is DBNull.Value Then
                objPICMidYearSchool.Question12 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_PicQuestion12"))
            Else
                objPICMidYearSchool.Question12 = CType(myparOutput("@p_PicQuestion12"), Single)
            End If
            If myparOutput("@p_PicQuestion13") Is DBNull.Value Then
                objPICMidYearSchool.Question13 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_PicQuestion13"))
            Else
                objPICMidYearSchool.Question13 = CType(myparOutput("@p_PicQuestion13"), Single)
            End If
            If myparOutput("@p_PicQuestion14") Is DBNull.Value Then
                objPICMidYearSchool.Question14 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_PicQuestion14"))
            Else
                objPICMidYearSchool.Question14 = CType(myparOutput("@p_PicQuestion14"), Single)
            End If
            If myparOutput("@p_PicQuestion15") Is DBNull.Value Then
                objPICMidYearSchool.Question15 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_PicQuestion15"))
            Else
                objPICMidYearSchool.Question15 = CType(myparOutput("@p_PicQuestion15"), Single)
            End If
            If myparOutput("@p_PicQuestion16") Is DBNull.Value Then
                objPICMidYearSchool.Question16 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_PicQuestion16"))
            Else
                objPICMidYearSchool.Question16 = CType(myparOutput("@p_PicQuestion16"), Single)
            End If
            If myparOutput("@p_PicQuestion17") Is DBNull.Value Then
                objPICMidYearSchool.Question17 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_PicQuestion17"))
            Else
                objPICMidYearSchool.Question17 = CType(myparOutput("@p_PicQuestion17"), Single)
            End If
            If myparOutput("@p_PicQuestion18") Is DBNull.Value Then
                objPICMidYearSchool.Question18 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_PicQuestion18"))
            Else
                objPICMidYearSchool.Question18 = CType(myparOutput("@p_PicQuestion18"), Single)
            End If
            If myparOutput("@p_PicQuestion19") Is DBNull.Value Then
                objPICMidYearSchool.Question19 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_PicQuestion19"))
            Else
                objPICMidYearSchool.Question19 = CType(myparOutput("@p_PicQuestion19"), Single)
            End If
            If myparOutput("@p_PicQuestion20") Is DBNull.Value Then
                objPICMidYearSchool.Question20 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_PicQuestion20"))
            Else
                objPICMidYearSchool.Question20 = CType(myparOutput("@p_PicQuestion20"), Single)
            End If

            If myparOutput("@p_PicQuestion21") Is DBNull.Value Then
                objPICMidYearSchool.Question21 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_PicQuestion21"))
            Else
                objPICMidYearSchool.Question21 = CType(myparOutput("@p_PicQuestion21"), Single)
            End If
            If myparOutput("@p_PicQuestion22") Is DBNull.Value Then
                objPICMidYearSchool.Question22 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_PicQuestion22"))
            Else
                objPICMidYearSchool.Question22 = CType(myparOutput("@p_PicQuestion22"), Single)
            End If
            If myparOutput("@p_PicQuestion23") Is DBNull.Value Then
                objPICMidYearSchool.Question23 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_PicQuestion23"))
            Else
                objPICMidYearSchool.Question23 = CType(myparOutput("@p_PicQuestion23"), Single)
            End If
            If myparOutput("@p_PicQuestion24") Is DBNull.Value Then
                objPICMidYearSchool.Question24 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_PicQuestion24"))
            Else
                objPICMidYearSchool.Question24 = CType(myparOutput("@p_PicQuestion24"), Single)
            End If
            If myparOutput("@p_PicQuestion25") Is DBNull.Value Then
                objPICMidYearSchool.Question25 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_PicQuestion25"))
            Else
                objPICMidYearSchool.Question25 = CType(myparOutput("@p_PicQuestion25"), Single)
            End If
            If myparOutput("@p_PicQuestion26") Is DBNull.Value Then
                objPICMidYearSchool.Question26 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_PicQuestion26"))
            Else
                objPICMidYearSchool.Question26 = CType(myparOutput("@p_PicQuestion26"), Single)
            End If
            If myparOutput("@p_PicQuestion27") Is DBNull.Value Then
                objPICMidYearSchool.Question27 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_PicQuestion27"))
            Else
                objPICMidYearSchool.Question27 = CType(myparOutput("@p_PicQuestion27"), Single)
            End If
            If myparOutput("@p_PicQuestion28") Is DBNull.Value Then
                objPICMidYearSchool.Question28 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_PicQuestion28"))
            Else
                objPICMidYearSchool.Question28 = CType(myparOutput("@p_PicQuestion28"), Single)
            End If
            If myparOutput("@p_PicQuestion29") Is DBNull.Value Then
                objPICMidYearSchool.Question29 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_PicQuestion29"))
            Else
                objPICMidYearSchool.Question29 = CType(myparOutput("@p_PicQuestion29"), Single)
            End If
            If myparOutput("@p_PicQuestion30") Is DBNull.Value Then
                objPICMidYearSchool.Question30 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_PicQuestion30"))
            Else
                objPICMidYearSchool.Question30 = CType(myparOutput("@p_PicQuestion30"), Single)
            End If

            If myparOutput("@p_PicQuestion31") Is DBNull.Value Then
                objPICMidYearSchool.Question31 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_PicQuestion31"))
            Else
                objPICMidYearSchool.Question31 = CType(myparOutput("@p_PicQuestion31"), Single)
            End If
            If myparOutput("@p_PicQuestion32") Is DBNull.Value Then
                objPICMidYearSchool.Question32 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_PicQuestion32"))
            Else
                objPICMidYearSchool.Question32 = CType(myparOutput("@p_PicQuestion32"), Single)
            End If
            If myparOutput("@p_PicQuestion33") Is DBNull.Value Then
                objPICMidYearSchool.Question33 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_PicQuestion33"))
            Else
                objPICMidYearSchool.Question33 = CType(myparOutput("@p_PicQuestion33"), Single)
            End If
            If myparOutput("@p_PicQuestion34") Is DBNull.Value Then
                objPICMidYearSchool.Question34 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_PicQuestion34"))
            Else
                objPICMidYearSchool.Question34 = CType(myparOutput("@p_PicQuestion34"), Single)
            End If
            If myparOutput("@p_PicQuestion35") Is DBNull.Value Then
                objPICMidYearSchool.Question35 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_PicQuestion35"))
            Else
                objPICMidYearSchool.Question35 = CType(myparOutput("@p_PicQuestion35"), Single)
            End If
            If myparOutput("@p_PicQuestion36") Is DBNull.Value Then
                objPICMidYearSchool.Question36 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_PicQuestion36"))
            Else
                objPICMidYearSchool.Question36 = CType(myparOutput("@p_PicQuestion36"), Single)
            End If
            If myparOutput("@p_PicQuestion37") Is DBNull.Value Then
                objPICMidYearSchool.Question37 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_PicQuestion37"))
            Else
                objPICMidYearSchool.Question37 = CType(myparOutput("@p_PicQuestion37"), Single)
            End If
            If myparOutput("@p_PicQuestion38") Is DBNull.Value Then
                objPICMidYearSchool.Question38 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_PicQuestion38"))
            Else
                objPICMidYearSchool.Question38 = CType(myparOutput("@p_PicQuestion38"), Single)
            End If
            If myparOutput("@p_PicQuestion39") Is DBNull.Value Then
                objPICMidYearSchool.Question39 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_PicQuestion39"))
            Else
                objPICMidYearSchool.Question39 = CType(myparOutput("@p_PicQuestion39"), Single)
            End If
            If myparOutput("@p_PicQuestion40") Is DBNull.Value Then
                objPICMidYearSchool.Question40 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_PicQuestion40"))
            Else
                objPICMidYearSchool.Question40 = CType(myparOutput("@p_PicQuestion40"), Single)
            End If

            If myparOutput("@p_PicQuestion41") Is DBNull.Value Then
                objPICMidYearSchool.Question41 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_PicQuestion41"))
            Else
                objPICMidYearSchool.Question41 = CType(myparOutput("@p_PicQuestion41"), Single)
            End If
            If myparOutput("@p_PicQuestion42") Is DBNull.Value Then
                objPICMidYearSchool.Question42 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_PicQuestion42"))
            Else
                objPICMidYearSchool.Question42 = CType(myparOutput("@p_PicQuestion42"), Single)
            End If
            If myparOutput("@p_PicQuestion43") Is DBNull.Value Then
                objPICMidYearSchool.Question43 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_PicQuestion43"))
            Else
                objPICMidYearSchool.Question43 = CType(myparOutput("@p_PicQuestion43"), Single)
            End If
            If myparOutput("@p_PicQuestion44") Is DBNull.Value Then
                objPICMidYearSchool.Question44 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_PicQuestion44"))
            Else
                objPICMidYearSchool.Question44 = CType(myparOutput("@p_PicQuestion44"), Single)
            End If

            Return objPICMidYearSchool

        End Function

        Shared Function getemptystring(ByVal myparoutput As Object) As Single
            If myparoutput Is DBNull.Value Then
                Return 0.0
            End If
        End Function

        '-------------------------------------------------------------------------------------------------------------------
        ' Function Name : addschoolPIC  
        ' Created By : Aditi Deodhar
        ' Created Dt : Feb 11,2010
        ' Last Updated Dt : Feb 11,2010
        ' Description : This function is used to add all the PIC Mid Year question values for a particular school.
        '-------------------------------------------------------------------------------------------------------------------    
        Shared Sub addschoolPIC(ByVal objPIC As C21MIT.PBSIS.BO.pbsschoolreport)
            Dim oRequest As New URDALRequest
            Dim oFactory As URDALAbsDBFactory
            Dim oNonQuery As URDALNonQuery
            oFactory = New URDALSQLFactory

            With oRequest
                .Command = "dbo.flpbsis_school_Pic_add"
                .CommandType = CommandType.StoredProcedure
            End With
            oRequest.AddParameter("@p_PicSchoolID", objPIC.SchoolID, URDALRequest.myDataType.dtChar, 6, ParameterDirection.Input)
            oRequest.AddParameter("@p_PicSchoolYear", objPIC.SchoolYear, URDALRequest.myDataType.dtTinyInt, , ParameterDirection.Input)
            oRequest.AddParameter("@p_PicCoachID", objPIC.CoachID, URDALRequest.myDataType.dtTinyInt, , ParameterDirection.Input)
            oRequest.AddParameter("@p_PicInterval", objPIC.Interval, URDALRequest.myDataType.dtTinyInt, , ParameterDirection.Input)


            oRequest.AddParameter("@p_PicQuestion1", objPIC.Question1, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_PicQuestion2", objPIC.Question2, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_PicQuestion3", objPIC.Question3, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_PicQuestion4", objPIC.Question4, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_PicQuestion5", objPIC.Question5, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_PicQuestion6", objPIC.Question6, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_PicQuestion7", objPIC.Question7, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_PicQuestion8", objPIC.Question8, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_PicQuestion9", objPIC.Question9, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_PicQuestion10", objPIC.Question10, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_PicQuestion11", objPIC.Question11, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_PicQuestion12", objPIC.Question12, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_PicQuestion13", objPIC.Question13, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_PicQuestion14", objPIC.Question14, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_PicQuestion15", objPIC.Question15, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_PicQuestion16", objPIC.Question16, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_PicQuestion17", objPIC.Question17, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_PicQuestion18", objPIC.Question18, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_PicQuestion19", objPIC.Question19, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_PicQuestion20", objPIC.Question20, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_PicQuestion21", objPIC.Question21, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_PicQuestion22", objPIC.Question22, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_PicQuestion23", objPIC.Question23, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_PicQuestion24", objPIC.Question24, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_PicQuestion25", objPIC.Question25, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_PicQuestion26", objPIC.Question26, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_PicQuestion27", objPIC.Question27, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_PicQuestion28", objPIC.Question28, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_PicQuestion29", objPIC.Question29, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_PicQuestion30", objPIC.Question30, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_PicQuestion31", objPIC.Question31, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_PicQuestion32", objPIC.Question32, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_PicQuestion33", objPIC.Question33, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_PicQuestion34", objPIC.Question34, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_PicQuestion35", objPIC.Question35, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_PicQuestion36", objPIC.Question36, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_PicQuestion37", objPIC.Question37, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_PicQuestion38", objPIC.Question38, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_PicQuestion39", objPIC.Question39, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_PicQuestion40", objPIC.Question40, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_PicQuestion41", objPIC.Question41, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_PicQuestion42", objPIC.Question42, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_PicQuestion43", objPIC.Question43, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_PicQuestion44", objPIC.Question44, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)

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
    End Class
#End Region
#Region "BOQ End Year School"
    Public Class pbslboqEndYearSchool
        '-------------------------------------------------------------------------------------------------------------------
        ' Function Name : fngetBOQEndYearSchool  
        ' Created By : Aditi Deodhar
        ' Created Dt : Feb 09,2010
        ' Last Updated Dt : Feb 09,2010
        ' Description : This function is used to get all the BOQ End Year question values for a particular school.
        '-------------------------------------------------------------------------------------------------------------------
        Shared Function fngetBOQEndYearSchool(ByVal schoolID As String, ByVal schoolYr As Integer) As C21MIT.PBSIS.BO.pbsschoolreport
            Dim oRequest As New URDALRequest
            Dim oFactory As URDALAbsDBFactory
            Dim oNonQuery As URDALNonQuery
            oFactory = New URDALSQLFactory

            Dim myparOutput As New Hashtable

            Dim objBOQEndYearSchool As New C21MIT.PBSIS.BO.pbsschoolreport

            With oRequest
                .Command = "dbo.flpbsis_school_BOQ_select"
                .CommandType = CommandType.StoredProcedure
            End With

            oRequest.AddParameter("@p_BoqSchoolID", schoolID, URDALRequest.myDataType.dtChar, 6, ParameterDirection.Input)
            oRequest.AddParameter("@p_BoqSchoolYear", schoolYr, URDALRequest.myDataType.dtTinyInt, , ParameterDirection.Input)

            oRequest.AddParameter("@p_BoqSchoolName", , URDALRequest.myDataType.dtString, 75, ParameterDirection.Output)
            oRequest.AddParameter("@p_BoqDistrictName", , URDALRequest.myDataType.dtString, 75, ParameterDirection.Output)
            oRequest.AddParameter("@p_BoqCoachName", , URDALRequest.myDataType.dtString, 100, ParameterDirection.Output)
            oRequest.AddParameter("@p_BoqScoreMethod", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)

            oRequest.AddParameter("@p_BoqQuestion1", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_BoqQuestion2", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_BoqQuestion3", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_BoqQuestion4", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_BoqQuestion5", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_BoqQuestion6", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_BoqQuestion7", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_BoqQuestion8", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_BoqQuestion9", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_BoqQuestion10", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_BoqQuestion11", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_BoqQuestion12", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_BoqQuestion13", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_BoqQuestion14", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_BoqQuestion15", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_BoqQuestion16", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_BoqQuestion17", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_BoqQuestion18", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_BoqQuestion19", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_BoqQuestion20", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_BoqQuestion21", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_BoqQuestion22", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_BoqQuestion23", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_BoqQuestion24", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_BoqQuestion25", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_BoqQuestion26", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_BoqQuestion27", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_BoqQuestion28", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_BoqQuestion29", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_BoqQuestion30", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_BoqQuestion31", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_BoqQuestion32", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_BoqQuestion33", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_BoqQuestion34", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_BoqQuestion35", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_BoqQuestion36", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_BoqQuestion37", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_BoqQuestion38", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_BoqQuestion39", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_BoqQuestion40", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_BoqQuestion41", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_BoqQuestion42", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_BoqQuestion43", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_BoqQuestion44", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_BoqQuestion45", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_BoqQuestion46", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_BoqQuestion47", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_BoqQuestion48", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_BoqQuestion49", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_BoqQuestion50", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_BoqQuestion51", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_BoqQuestion52", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_BoqQuestion53", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_BoqQuestion54", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_BoqQuestion55", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_BoqQuestion56", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_BoqQuestion57", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_BoqQuestion58", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_BoqQuestion59", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_BoqQuestion60", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)


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

            If myparOutput("@p_BoqSchoolName") Is DBNull.Value Then
                objBOQEndYearSchool.SchoolName = ""
            Else
                objBOQEndYearSchool.SchoolName = C21MIT.Util.DBNullHandler.DBNullToBlank(CType(myparOutput("@p_BoqSchoolName"), String))
            End If
            If myparOutput("@p_BoqDistrictName") Is DBNull.Value Then
                objBOQEndYearSchool.DistrictName = ""
            Else
                objBOQEndYearSchool.DistrictName = C21MIT.Util.DBNullHandler.DBNullToBlank(CType(myparOutput("@p_BoqDistrictName"), String))
            End If
            If myparOutput("@p_BoqCoachName") Is DBNull.Value Then
                objBOQEndYearSchool.CoachName = ""
            Else
                objBOQEndYearSchool.CoachName = CType(myparOutput("@p_BoqCoachName"), String)
            End If
            'objBOQEndYearSchool.CoachName = C21MIT.Util.DBNullHandler.DBNullToBlank(CType(myparOutput("@p_BoqCoachName"), String))
            '  objBOQEndYearSchool.ScoringMethod = CType(myparOutput("@p_BoqScoreMethod"), Single)
            If myparOutput("@p_BoqScoreMethod") Is DBNull.Value Then
                objBOQEndYearSchool.ScoringMethod = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_BoqScoreMethod"))
            Else
                objBOQEndYearSchool.ScoringMethod = CType(myparOutput("@p_BoqScoreMethod"), Single)
            End If
            If myparOutput("@p_BoqQuestion1") Is DBNull.Value Then
                objBOQEndYearSchool.Question1 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_BoqQuestion1"))
            Else
                objBOQEndYearSchool.Question1 = CType(myparOutput("@p_BoqQuestion1"), Single)
            End If
            If myparOutput("@p_BoqQuestion2") Is DBNull.Value Then
                objBOQEndYearSchool.Question2 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_BoqQuestion2"))
            Else
                objBOQEndYearSchool.Question2 = CType(myparOutput("@p_BoqQuestion2"), Single)
            End If
            If myparOutput("@p_BoqQuestion3") Is DBNull.Value Then
                objBOQEndYearSchool.Question3 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_BoqQuestion3"))
            Else
                objBOQEndYearSchool.Question3 = CType(myparOutput("@p_BoqQuestion3"), Single)
            End If
            If myparOutput("@p_BoqQuestion4") Is DBNull.Value Then
                objBOQEndYearSchool.Question4 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_BoqQuestion4"))
            Else
                objBOQEndYearSchool.Question4 = CType(myparOutput("@p_BoqQuestion4"), Single)
            End If
            If myparOutput("@p_BoqQuestion5") Is DBNull.Value Then
                objBOQEndYearSchool.Question5 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_BoqQuestion5"))
            Else
                objBOQEndYearSchool.Question5 = CType(myparOutput("@p_BoqQuestion5"), Single)
            End If
            If myparOutput("@p_BoqQuestion6") Is DBNull.Value Then
                objBOQEndYearSchool.Question6 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_BoqQuestion6"))
            Else
                objBOQEndYearSchool.Question6 = CType(myparOutput("@p_BoqQuestion6"), Single)
            End If
            If myparOutput("@p_BoqQuestion7") Is DBNull.Value Then
                objBOQEndYearSchool.Question7 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_BoqQuestion7"))
            Else
                objBOQEndYearSchool.Question7 = CType(myparOutput("@p_BoqQuestion7"), Single)
            End If
            If myparOutput("@p_BoqQuestion8") Is DBNull.Value Then
                objBOQEndYearSchool.Question8 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_BoqQuestion8"))
            Else
                objBOQEndYearSchool.Question8 = CType(myparOutput("@p_BoqQuestion8"), Single)
            End If
            If myparOutput("@p_BoqQuestion9") Is DBNull.Value Then
                objBOQEndYearSchool.Question9 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_BoqQuestion9"))
            Else
                objBOQEndYearSchool.Question9 = CType(myparOutput("@p_BoqQuestion9"), Single)
            End If
            If myparOutput("@p_BoqQuestion10") Is DBNull.Value Then
                objBOQEndYearSchool.Question10 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_BoqQuestion10"))
            Else
                objBOQEndYearSchool.Question10 = CType(myparOutput("@p_BoqQuestion10"), Single)
            End If
            If myparOutput("@p_BoqQuestion11") Is DBNull.Value Then
                objBOQEndYearSchool.Question11 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_BoqQuestion11"))
            Else
                objBOQEndYearSchool.Question11 = CType(myparOutput("@p_BoqQuestion11"), Single)
            End If
            If myparOutput("@p_BoqQuestion12") Is DBNull.Value Then
                objBOQEndYearSchool.Question12 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_BoqQuestion12"))
            Else
                objBOQEndYearSchool.Question12 = CType(myparOutput("@p_BoqQuestion12"), Single)
            End If
            If myparOutput("@p_BoqQuestion13") Is DBNull.Value Then
                objBOQEndYearSchool.Question13 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_BoqQuestion13"))
            Else
                objBOQEndYearSchool.Question13 = CType(myparOutput("@p_BoqQuestion13"), Single)
            End If
            If myparOutput("@p_BoqQuestion14") Is DBNull.Value Then
                objBOQEndYearSchool.Question14 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_BoqQuestion14"))
            Else
                objBOQEndYearSchool.Question14 = CType(myparOutput("@p_BoqQuestion14"), Single)
            End If
            If myparOutput("@p_BoqQuestion15") Is DBNull.Value Then
                objBOQEndYearSchool.Question15 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_BoqQuestion15"))
            Else
                objBOQEndYearSchool.Question15 = CType(myparOutput("@p_BoqQuestion15"), Single)
            End If
            If myparOutput("@p_BoqQuestion16") Is DBNull.Value Then
                objBOQEndYearSchool.Question16 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_BoqQuestion16"))
            Else
                objBOQEndYearSchool.Question16 = CType(myparOutput("@p_BoqQuestion16"), Single)
            End If
            If myparOutput("@p_BoqQuestion17") Is DBNull.Value Then
                objBOQEndYearSchool.Question17 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_BoqQuestion17"))
            Else
                objBOQEndYearSchool.Question17 = CType(myparOutput("@p_BoqQuestion17"), Single)
            End If
            If myparOutput("@p_BoqQuestion18") Is DBNull.Value Then
                objBOQEndYearSchool.Question18 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_BoqQuestion18"))
            Else
                objBOQEndYearSchool.Question18 = CType(myparOutput("@p_BoqQuestion18"), Single)
            End If
            If myparOutput("@p_BoqQuestion19") Is DBNull.Value Then
                objBOQEndYearSchool.Question19 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_BoqQuestion19"))
            Else
                objBOQEndYearSchool.Question19 = CType(myparOutput("@p_BoqQuestion19"), Single)
            End If
            If myparOutput("@p_BoqQuestion20") Is DBNull.Value Then
                objBOQEndYearSchool.Question20 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_BoqQuestion20"))
            Else
                objBOQEndYearSchool.Question20 = CType(myparOutput("@p_BoqQuestion20"), Single)
            End If

            If myparOutput("@p_BoqQuestion21") Is DBNull.Value Then
                objBOQEndYearSchool.Question21 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_BoqQuestion21"))
            Else
                objBOQEndYearSchool.Question21 = CType(myparOutput("@p_BoqQuestion21"), Single)
            End If
            If myparOutput("@p_BoqQuestion22") Is DBNull.Value Then
                objBOQEndYearSchool.Question22 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_BoqQuestion22"))
            Else
                objBOQEndYearSchool.Question22 = CType(myparOutput("@p_BoqQuestion22"), Single)
            End If
            If myparOutput("@p_BoqQuestion23") Is DBNull.Value Then
                objBOQEndYearSchool.Question23 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_BoqQuestion23"))
            Else
                objBOQEndYearSchool.Question23 = CType(myparOutput("@p_BoqQuestion23"), Single)
            End If
            If myparOutput("@p_BoqQuestion24") Is DBNull.Value Then
                objBOQEndYearSchool.Question24 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_BoqQuestion24"))
            Else
                objBOQEndYearSchool.Question24 = CType(myparOutput("@p_BoqQuestion24"), Single)
            End If
            If myparOutput("@p_BoqQuestion25") Is DBNull.Value Then
                objBOQEndYearSchool.Question25 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_BoqQuestion25"))
            Else
                objBOQEndYearSchool.Question25 = CType(myparOutput("@p_BoqQuestion25"), Single)
            End If
            If myparOutput("@p_BoqQuestion26") Is DBNull.Value Then
                objBOQEndYearSchool.Question26 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_BoqQuestion26"))
            Else
                objBOQEndYearSchool.Question26 = CType(myparOutput("@p_BoqQuestion26"), Single)
            End If
            If myparOutput("@p_BoqQuestion27") Is DBNull.Value Then
                objBOQEndYearSchool.Question27 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_BoqQuestion27"))
            Else
                objBOQEndYearSchool.Question27 = CType(myparOutput("@p_BoqQuestion27"), Single)
            End If
            If myparOutput("@p_BoqQuestion28") Is DBNull.Value Then
                objBOQEndYearSchool.Question28 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_BoqQuestion28"))
            Else
                objBOQEndYearSchool.Question28 = CType(myparOutput("@p_BoqQuestion28"), Single)
            End If
            If myparOutput("@p_BoqQuestion29") Is DBNull.Value Then
                objBOQEndYearSchool.Question29 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_BoqQuestion29"))
            Else
                objBOQEndYearSchool.Question29 = CType(myparOutput("@p_BoqQuestion29"), Single)
            End If
            If myparOutput("@p_BoqQuestion30") Is DBNull.Value Then
                objBOQEndYearSchool.Question30 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_BoqQuestion30"))
            Else
                objBOQEndYearSchool.Question30 = CType(myparOutput("@p_BoqQuestion30"), Single)
            End If
            If myparOutput("@p_BoqQuestion31") Is DBNull.Value Then
                objBOQEndYearSchool.Question31 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_BoqQuestion31"))
            Else
                objBOQEndYearSchool.Question31 = CType(myparOutput("@p_BoqQuestion31"), Single)
            End If
            If myparOutput("@p_BoqQuestion32") Is DBNull.Value Then
                objBOQEndYearSchool.Question32 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_BoqQuestion32"))
            Else
                objBOQEndYearSchool.Question32 = CType(myparOutput("@p_BoqQuestion32"), Single)
            End If
            If myparOutput("@p_BoqQuestion33") Is DBNull.Value Then
                objBOQEndYearSchool.Question33 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_BoqQuestion33"))
            Else
                objBOQEndYearSchool.Question33 = CType(myparOutput("@p_BoqQuestion33"), Single)
            End If
            If myparOutput("@p_BoqQuestion34") Is DBNull.Value Then
                objBOQEndYearSchool.Question34 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_BoqQuestion34"))
            Else
                objBOQEndYearSchool.Question34 = CType(myparOutput("@p_BoqQuestion34"), Single)
            End If
            If myparOutput("@p_BoqQuestion35") Is DBNull.Value Then
                objBOQEndYearSchool.Question35 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_BoqQuestion35"))
            Else
                objBOQEndYearSchool.Question35 = CType(myparOutput("@p_BoqQuestion35"), Single)
            End If
            If myparOutput("@p_BoqQuestion36") Is DBNull.Value Then
                objBOQEndYearSchool.Question36 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_BoqQuestion36"))
            Else
                objBOQEndYearSchool.Question36 = CType(myparOutput("@p_BoqQuestion36"), Single)
            End If
            If myparOutput("@p_BoqQuestion37") Is DBNull.Value Then
                objBOQEndYearSchool.Question37 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_BoqQuestion37"))
            Else
                objBOQEndYearSchool.Question37 = CType(myparOutput("@p_BoqQuestion37"), Single)
            End If
            If myparOutput("@p_BoqQuestion38") Is DBNull.Value Then
                objBOQEndYearSchool.Question38 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_BoqQuestion38"))
            Else
                objBOQEndYearSchool.Question38 = CType(myparOutput("@p_BoqQuestion38"), Single)
            End If
            If myparOutput("@p_BoqQuestion39") Is DBNull.Value Then
                objBOQEndYearSchool.Question39 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_BoqQuestion39"))
            Else
                objBOQEndYearSchool.Question39 = CType(myparOutput("@p_BoqQuestion39"), Single)
            End If
            If myparOutput("@p_BoqQuestion40") Is DBNull.Value Then
                objBOQEndYearSchool.Question40 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_BoqQuestion40"))
            Else
                objBOQEndYearSchool.Question40 = CType(myparOutput("@p_BoqQuestion40"), Single)
            End If

            If myparOutput("@p_BoqQuestion41") Is DBNull.Value Then
                objBOQEndYearSchool.Question41 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_BoqQuestion41"))
            Else
                objBOQEndYearSchool.Question41 = CType(myparOutput("@p_BoqQuestion41"), Single)
            End If
            If myparOutput("@p_BoqQuestion42") Is DBNull.Value Then
                objBOQEndYearSchool.Question42 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_BoqQuestion42"))
            Else
                objBOQEndYearSchool.Question42 = CType(myparOutput("@p_BoqQuestion42"), Single)
            End If
            If myparOutput("@p_BoqQuestion43") Is DBNull.Value Then
                objBOQEndYearSchool.Question43 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_BoqQuestion43"))
            Else
                objBOQEndYearSchool.Question43 = CType(myparOutput("@p_BoqQuestion43"), Single)
            End If
            If myparOutput("@p_BoqQuestion44") Is DBNull.Value Then
                objBOQEndYearSchool.Question44 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_BoqQuestion44"))
            Else
                objBOQEndYearSchool.Question44 = CType(myparOutput("@p_BoqQuestion44"), Single)
            End If
            If myparOutput("@p_BoqQuestion45") Is DBNull.Value Then
                objBOQEndYearSchool.Question45 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_BoqQuestion45"))
            Else
                objBOQEndYearSchool.Question45 = CType(myparOutput("@p_BoqQuestion45"), Single)
            End If
            If myparOutput("@p_BoqQuestion46") Is DBNull.Value Then
                objBOQEndYearSchool.Question46 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_BoqQuestion46"))
            Else
                objBOQEndYearSchool.Question46 = CType(myparOutput("@p_BoqQuestion46"), Single)
            End If
            If myparOutput("@p_BoqQuestion47") Is DBNull.Value Then
                objBOQEndYearSchool.Question47 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_BoqQuestion47"))
            Else
                objBOQEndYearSchool.Question47 = CType(myparOutput("@p_BoqQuestion47"), Single)
            End If
            If myparOutput("@p_BoqQuestion48") Is DBNull.Value Then
                objBOQEndYearSchool.Question48 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_BoqQuestion48"))
            Else
                objBOQEndYearSchool.Question48 = CType(myparOutput("@p_BoqQuestion48"), Single)
            End If
            If myparOutput("@p_BoqQuestion49") Is DBNull.Value Then
                objBOQEndYearSchool.Question49 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_BoqQuestion49"))
            Else
                objBOQEndYearSchool.Question49 = CType(myparOutput("@p_BoqQuestion49"), Single)
            End If
            If myparOutput("@p_BoqQuestion50") Is DBNull.Value Then
                objBOQEndYearSchool.Question50 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_BoqQuestion50"))
            Else
                objBOQEndYearSchool.Question50 = CType(myparOutput("@p_BoqQuestion50"), Single)
            End If

            If myparOutput("@p_BoqQuestion51") Is DBNull.Value Then
                objBOQEndYearSchool.Question51 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_BoqQuestion51"))
            Else
                objBOQEndYearSchool.Question51 = CType(myparOutput("@p_BoqQuestion51"), Single)
            End If
            If myparOutput("@p_BoqQuestion52") Is DBNull.Value Then
                objBOQEndYearSchool.Question52 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_BoqQuestion52"))
            Else
                objBOQEndYearSchool.Question52 = CType(myparOutput("@p_BoqQuestion52"), Single)
            End If
            If myparOutput("@p_BoqQuestion53") Is DBNull.Value Then
                objBOQEndYearSchool.Question53 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_BoqQuestion53"))
            Else
                objBOQEndYearSchool.Question53 = CType(myparOutput("@p_BoqQuestion53"), Single)
            End If
            If myparOutput("@p_BoqQuestion54") Is DBNull.Value Then
                objBOQEndYearSchool.Question54 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_BoqQuestion54"))
            Else
                objBOQEndYearSchool.Question54 = CType(myparOutput("@p_BoqQuestion54"), Single)
            End If
            If myparOutput("@p_BoqQuestion55") Is DBNull.Value Then
                objBOQEndYearSchool.Question55 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_BoqQuestion55"))
            Else
                objBOQEndYearSchool.Question55 = CType(myparOutput("@p_BoqQuestion55"), Single)
            End If
            If myparOutput("@p_BoqQuestion56") Is DBNull.Value Then
                objBOQEndYearSchool.Question56 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_BoqQuestion56"))
            Else
                objBOQEndYearSchool.Question56 = CType(myparOutput("@p_BoqQuestion56"), Single)
            End If
            If myparOutput("@p_BoqQuestion57") Is DBNull.Value Then
                objBOQEndYearSchool.Question57 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_BoqQuestion57"))
            Else
                objBOQEndYearSchool.Question57 = CType(myparOutput("@p_BoqQuestion57"), Single)
            End If
            If myparOutput("@p_BoqQuestion58") Is DBNull.Value Then
                objBOQEndYearSchool.Question58 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_BoqQuestion58"))
            Else
                objBOQEndYearSchool.Question58 = CType(myparOutput("@p_BoqQuestion58"), Single)
            End If
            If myparOutput("@p_BoqQuestion59") Is DBNull.Value Then
                objBOQEndYearSchool.Question59 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_BoqQuestion59"))
            Else
                objBOQEndYearSchool.Question59 = CType(myparOutput("@p_BoqQuestion59"), Single)
            End If
            If myparOutput("@p_BoqQuestion60") Is DBNull.Value Then
                objBOQEndYearSchool.Question60 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_BoqQuestion60"))
            Else
                objBOQEndYearSchool.Question60 = CType(myparOutput("@p_BoqQuestion60"), Single)
            End If

            Return objBOQEndYearSchool

        End Function
        '-------------------------------------------------------------------------------------------------------------------
        ' Function Name : addschoolBOQ  
        ' Created By : Aditi Deodhar
        ' Created Dt : Feb 17,2010
        ' Last Updated Dt : Feb 17,2010
        ' Description : This function is used to add all the BOQ End YR values for a particular school for a particular year,
        '               year, coach, and a scoremethod
        '-------------------------------------------------------------------------------------------------------------------
        Shared Sub addschoolBOQ(ByVal objBOQ As C21MIT.PBSIS.BO.pbsschoolreport)
            Dim oRequest As New URDALRequest
            Dim oFactory As URDALAbsDBFactory
            Dim oNonQuery As URDALNonQuery
            oFactory = New URDALSQLFactory

            With oRequest
                .Command = "dbo.flpbsis_school_boq_add"
                .CommandType = CommandType.StoredProcedure
            End With
            oRequest.AddParameter("@p_BoqSchoolID", objBOQ.SchoolID, URDALRequest.myDataType.dtChar, 6, ParameterDirection.Input)
            oRequest.AddParameter("@p_BoqSchoolYear", objBOQ.SchoolYear, URDALRequest.myDataType.dtTinyInt, , ParameterDirection.Input)
            ' oRequest.AddParameter("@p_BoqCoachID", objBOQ.BOQCoachID, URDALRequest.myDataType.dtString, 4, ParameterDirection.Input)
            oRequest.AddParameter("@p_BoqCoachList", objBOQ.BOQCoachID, URDALRequest.myDataType.dtString, 1000, ParameterDirection.Input)
            oRequest.AddParameter("@p_BoqScoremethod", objBOQ.ScoringMethod, URDALRequest.myDataType.dtTinyInt, , ParameterDirection.Input)

            oRequest.AddParameter("@p_BoqQuestion1", objBOQ.Question1, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_BoqQuestion2", objBOQ.Question2, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_BoqQuestion3", objBOQ.Question3, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_BoqQuestion4", objBOQ.Question4, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_BoqQuestion5", objBOQ.Question5, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_BoqQuestion6", objBOQ.Question6, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_BoqQuestion7", objBOQ.Question7, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_BoqQuestion8", objBOQ.Question8, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_BoqQuestion9", objBOQ.Question9, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_BoqQuestion10", objBOQ.Question10, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_BoqQuestion11", objBOQ.Question11, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_BoqQuestion12", objBOQ.Question12, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_BoqQuestion13", objBOQ.Question13, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_BoqQuestion14", objBOQ.Question14, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_BoqQuestion15", objBOQ.Question15, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_BoqQuestion16", objBOQ.Question16, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_BoqQuestion17", objBOQ.Question17, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_BoqQuestion18", objBOQ.Question18, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_BoqQuestion19", objBOQ.Question19, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_BoqQuestion20", objBOQ.Question20, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_BoqQuestion21", objBOQ.Question21, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_BoqQuestion22", objBOQ.Question22, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_BoqQuestion23", objBOQ.Question23, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_BoqQuestion24", objBOQ.Question24, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_BoqQuestion25", objBOQ.Question25, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_BoqQuestion26", objBOQ.Question26, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_BoqQuestion27", objBOQ.Question27, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_BoqQuestion28", objBOQ.Question28, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_BoqQuestion29", objBOQ.Question29, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_BoqQuestion30", objBOQ.Question30, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_BoqQuestion31", objBOQ.Question31, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_BoqQuestion32", objBOQ.Question32, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_BoqQuestion33", objBOQ.Question33, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_BoqQuestion34", objBOQ.Question34, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_BoqQuestion35", objBOQ.Question35, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_BoqQuestion36", objBOQ.Question36, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_BoqQuestion37", objBOQ.Question37, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_BoqQuestion38", objBOQ.Question38, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_BoqQuestion39", objBOQ.Question39, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_BoqQuestion40", objBOQ.Question40, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_BoqQuestion41", objBOQ.Question41, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_BoqQuestion42", objBOQ.Question42, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_BoqQuestion43", objBOQ.Question43, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_BoqQuestion44", objBOQ.Question44, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_BoqQuestion45", objBOQ.Question45, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_BoqQuestion46", objBOQ.Question46, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_BoqQuestion47", objBOQ.Question47, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_BoqQuestion48", objBOQ.Question48, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_BoqQuestion49", objBOQ.Question49, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_BoqQuestion50", objBOQ.Question50, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_BoqQuestion51", objBOQ.Question51, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_BoqQuestion52", objBOQ.Question52, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_BoqQuestion53", objBOQ.Question53, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            'oRequest.AddParameter("@p_BoqQuestion54", objBOQ.Question54, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            'oRequest.AddParameter("@p_BoqQuestion55", objBOQ.Question55, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            'oRequest.AddParameter("@p_BoqQuestion56", objBOQ.Question56, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            'oRequest.AddParameter("@p_BoqQuestion57", objBOQ.Question57, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            'oRequest.AddParameter("@p_BoqQuestion58", objBOQ.Question58, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            'oRequest.AddParameter("@p_BoqQuestion59", objBOQ.Question59, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            'oRequest.AddParameter("@p_BoqQuestion60", objBOQ.Question60, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_BoqQuestion54", DBNull.Value, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_BoqQuestion55", DBNull.Value, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_BoqQuestion56", DBNull.Value, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_BoqQuestion57", DBNull.Value, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_BoqQuestion58", DBNull.Value, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_BoqQuestion59", DBNull.Value, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_BoqQuestion60", DBNull.Value, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)


            Try
                oNonQuery = oFactory.ExecuteNonQuery(oRequest)

                If Not IsNothing(oRequest.Exception) Then
                    Throw New ApplicationException("sqlexception", oRequest.Exception)
                End If

            Catch ex As Exception
                Dim objerrLog As New MITErrorHandling.MITErrorHandling("Exception: " & "in addschoolBOQ - " & ex.ToString())
                objerrLog.logError()
                System.Web.HttpContext.Current.Response.Redirect("~/users/smessages.aspx?qModule=TechErr", False)
            Finally
                oFactory.ConDispose()
            End Try
        End Sub
    End Class
#End Region
#Region "BAT End Year School"
    Public Class pbslBatEndYearSchool
        '-------------------------------------------------------------------------------------------------------------------
        ' Function Name : fngetBatEndYearSchool  
        ' Created By : Satish Hanumanthu
        ' Created Dt : Feb 17,2010
        ' Last Updated Dt : Feb 17,2010
        ' Description : This function is used to get all the BAT End Year question values for a particular school.
        '-------------------------------------------------------------------------------------------------------------------
        Shared Function fngetBatEndYearSchool(ByVal schoolID As String, ByVal schoolYr As Integer) As C21MIT.PBSIS.BO.pbsschoolreport
            Dim oRequest As New URDALRequest
            Dim oFactory As URDALAbsDBFactory
            Dim oNonQuery As URDALNonQuery
            oFactory = New URDALSQLFactory

            Dim myparOutput As New Hashtable

            Dim objBatEndYearSchool As New C21MIT.PBSIS.BO.pbsschoolreport

            With oRequest
                .Command = "dbo.flpbsis_school_Bat_select"
                .CommandType = CommandType.StoredProcedure
            End With

            oRequest.AddParameter("@p_BatSchoolID", schoolID, URDALRequest.myDataType.dtString, 6, ParameterDirection.Input)
            oRequest.AddParameter("@p_BatSchoolYear", schoolYr, URDALRequest.myDataType.dtTinyInt, , ParameterDirection.Input)

            oRequest.AddParameter("@p_BatSchoolName", , URDALRequest.myDataType.dtString, 75, ParameterDirection.Output)
            oRequest.AddParameter("@p_BatDistrictName", , URDALRequest.myDataType.dtString, 75, ParameterDirection.Output)
            oRequest.AddParameter("@p_BatCoachlist", , URDALRequest.myDataType.dtString, 1000, ParameterDirection.Output)
            oRequest.AddParameter("@p_BatQuestion1", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_BatQuestion2", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_BatQuestion3", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_BatQuestion4", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_BatQuestion5", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_BatQuestion6", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_BatQuestion7", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_BatQuestion8", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_BatQuestion9", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_BatQuestion10", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_BatQuestion11", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_BatQuestion12", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_BatQuestion13", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_BatQuestion14", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_BatQuestion15", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_BatQuestion16", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_BatQuestion17", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_BatIntrvUsd", , URDALRequest.myDataType.dtString, 50, ParameterDirection.Output)
            oRequest.AddParameter("@p_BatQuestion18", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_BatQuestion19", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_BatQuestion20", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_BatQuestion21", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_BatQuestion22", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_BatQuestion23", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_BatQuestion24", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_BatQuestion25", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_BatQuestion26", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_BatQuestion27", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_BatQuestion28", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_BatQuestion29", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_BatQuestion30", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_BatQuestion31", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_BatQuestion32", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_BatQuestion33", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_BatQuestion34", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_BatQuestion35", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_BatQuestion36", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_BatQuestion37", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_BatQuestion38", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_BatQuestion39", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_BatQuestion40", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_BatQuestion41", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_BatQuestion42", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_BatQuestion43", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_BatQuestion44", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_BatQuestion45", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_BatQuestion46", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_BatQuestion47", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_BatQuestion48", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_BatQuestion49", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_BatQuestion50", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_BatQuestion51", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_BatQuestion52", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_BatQuestion53", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_BatQuestion54", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_BatQuestion55", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_BatQuestion56", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_BatTeamLeader", , URDALRequest.myDataType.dtString, 500, ParameterDirection.Output)
            oRequest.AddParameter("@p_BatTeamMember", , URDALRequest.myDataType.dtString, 1000, ParameterDirection.Output)
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

            'objBatEndYearSchool.SchoolName = CType(myparOutput("@p_BatSchoolName"), String)
            If myparOutput("@p_BatSchoolName") Is DBNull.Value Then
                objBatEndYearSchool.SchoolName = ""

            Else
                objBatEndYearSchool.SchoolName = CType(myparOutput("@p_BatSchoolName"), String)
            End If

            'If myparOutput("@p_BatDistrictName") Is DBNull.Value Then
            '    objBatEndYearSchool.DistrictName = C21MIT.Util.DBNullHandler.DBNullToBlank(CType(myparOutput("@p_BatDistrictName"), String))
            'Else
            '    objBatEndYearSchool.DistrictName = CType(myparOutput("@p_BatDistrictName"), String)
            'End If

            If myparOutput("@p_BatDistrictName") Is DBNull.Value Then
                objBatEndYearSchool.DistrictName = ""
            Else
                objBatEndYearSchool.DistrictName = C21MIT.Util.DBNullHandler.DBNullToBlank(CType(myparOutput("@p_BatDistrictName"), String))
            End If

            If myparOutput("@p_BatCoachlist") Is DBNull.Value Then
                objBatEndYearSchool.CoachName = C21MIT.Util.DBNullHandler.DBNullToBlank(myparOutput("@p_BatCoachlist"))
            Else
                objBatEndYearSchool.CoachName = CType(myparOutput("@p_BatCoachlist"), String)
            End If

            If myparOutput("@p_BatQuestion1") Is DBNull.Value Then
                objBatEndYearSchool.Question1 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_BatQuestion1"))
            Else
                objBatEndYearSchool.Question1 = CType(myparOutput("@p_BatQuestion1"), Single)
            End If

            If myparOutput("@p_BatQuestion2") Is DBNull.Value Then
                objBatEndYearSchool.Question2 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_BatQuestion2"))
            Else
                objBatEndYearSchool.Question2 = CType(myparOutput("@p_BatQuestion2"), Single)
            End If


            If myparOutput("@p_BatQuestion3") Is DBNull.Value Then
                objBatEndYearSchool.Question3 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_BatQuestion3"))
            Else
                objBatEndYearSchool.Question3 = CType(myparOutput("@p_BatQuestion3"), Single)
            End If

            If myparOutput("@p_BatQuestion4") Is DBNull.Value Then
                objBatEndYearSchool.Question4 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_BatQuestion4"))
            Else
                objBatEndYearSchool.Question4 = CType(myparOutput("@p_BatQuestion4"), Single)
            End If

            If myparOutput("@p_BatQuestion5") Is DBNull.Value Then
                objBatEndYearSchool.Question5 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_BatQuestion5"))
            Else
                objBatEndYearSchool.Question5 = CType(myparOutput("@p_BatQuestion5"), Single)
            End If

            If myparOutput("@p_BatQuestion6") Is DBNull.Value Then
                objBatEndYearSchool.Question6 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_BatQuestion6"))
            Else
                objBatEndYearSchool.Question6 = CType(myparOutput("@p_BatQuestion6"), Single)
            End If

            If myparOutput("@p_BatQuestion7") Is DBNull.Value Then
                objBatEndYearSchool.Question7 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_BatQuestion7"))
            Else
                objBatEndYearSchool.Question7 = CType(myparOutput("@p_BatQuestion7"), Single)
            End If

            If myparOutput("@p_BatQuestion8") Is DBNull.Value Then
                objBatEndYearSchool.Question8 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_BatQuestion8"))
            Else
                objBatEndYearSchool.Question8 = CType(myparOutput("@p_BatQuestion8"), Single)
            End If

            If myparOutput("@p_BatQuestion9") Is DBNull.Value Then
                objBatEndYearSchool.Question9 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_BatQuestion9"))
            Else
                objBatEndYearSchool.Question9 = CType(myparOutput("@p_BatQuestion9"), Single)
            End If

            If myparOutput("@p_BatQuestion10") Is DBNull.Value Then
                objBatEndYearSchool.Question10 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_BatQuestion10"))
            Else
                objBatEndYearSchool.Question10 = CType(myparOutput("@p_BatQuestion10"), Single)
            End If

            If myparOutput("@p_BatQuestion11") Is DBNull.Value Then
                objBatEndYearSchool.Question11 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_BatQuestion11"))
            Else
                objBatEndYearSchool.Question11 = CType(myparOutput("@p_BatQuestion11"), Single)
            End If
            If myparOutput("@p_BatQuestion12") Is DBNull.Value Then
                objBatEndYearSchool.Question12 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_BatQuestion12"))
            Else
                objBatEndYearSchool.Question12 = CType(myparOutput("@p_BatQuestion12"), Single)
            End If
            If myparOutput("@p_BatQuestion13") Is DBNull.Value Then
                objBatEndYearSchool.Question13 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_BatQuestion13"))
            Else
                objBatEndYearSchool.Question13 = CType(myparOutput("@p_BatQuestion13"), Single)
            End If
            If myparOutput("@p_BatQuestion14") Is DBNull.Value Then
                objBatEndYearSchool.Question14 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_BatQuestion14"))
            Else
                objBatEndYearSchool.Question14 = CType(myparOutput("@p_BatQuestion14"), Single)
            End If
            If myparOutput("@p_BatQuestion15") Is DBNull.Value Then
                objBatEndYearSchool.Question15 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_BatQuestion15"))
            Else
                objBatEndYearSchool.Question15 = CType(myparOutput("@p_BatQuestion15"), Single)
            End If
            If myparOutput("@p_BatQuestion16") Is DBNull.Value Then
                objBatEndYearSchool.Question16 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_BatQuestion16"))
            Else
                objBatEndYearSchool.Question16 = CType(myparOutput("@p_BatQuestion16"), Single)
            End If
            If myparOutput("@p_BatQuestion17") Is DBNull.Value Then
                objBatEndYearSchool.Question17 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_BatQuestion17"))
            Else
                objBatEndYearSchool.Question17 = CType(myparOutput("@p_BatQuestion17"), Single)
            End If
            If myparOutput("@p_BatIntrvUsd") Is DBNull.Value Then
                objBatEndYearSchool.InterviewUsed = C21MIT.Util.DBNullHandler.DBNullToBlank(myparOutput("@p_BatIntrvUsd"))
            Else
                objBatEndYearSchool.InterviewUsed = CType(myparOutput("@p_BatIntrvUsd"), String)
            End If
            If myparOutput("@p_BatQuestion18") Is DBNull.Value Then
                objBatEndYearSchool.Question18 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_BatQuestion18"))
            Else
                objBatEndYearSchool.Question18 = CType(myparOutput("@p_BatQuestion18"), Single)
            End If
            If myparOutput("@p_BatQuestion19") Is DBNull.Value Then
                objBatEndYearSchool.Question19 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_BatQuestion19"))
            Else
                objBatEndYearSchool.Question19 = CType(myparOutput("@p_BatQuestion19"), Single)
            End If
            If myparOutput("@p_BatQuestion20") Is DBNull.Value Then
                objBatEndYearSchool.Question20 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_BatQuestion20"))
            Else
                objBatEndYearSchool.Question20 = CType(myparOutput("@p_BatQuestion20"), Single)
            End If

            If myparOutput("@p_BatQuestion21") Is DBNull.Value Then
                objBatEndYearSchool.Question21 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_BatQuestion21"))
            Else
                objBatEndYearSchool.Question21 = CType(myparOutput("@p_BatQuestion21"), Single)
            End If
            If myparOutput("@p_BatQuestion22") Is DBNull.Value Then
                objBatEndYearSchool.Question22 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_BatQuestion22"))
            Else
                objBatEndYearSchool.Question22 = CType(myparOutput("@p_BatQuestion22"), Single)
            End If
            If myparOutput("@p_BatQuestion23") Is DBNull.Value Then
                objBatEndYearSchool.Question23 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_BatQuestion23"))
            Else
                objBatEndYearSchool.Question23 = CType(myparOutput("@p_BatQuestion23"), Single)
            End If
            If myparOutput("@p_BatQuestion24") Is DBNull.Value Then
                objBatEndYearSchool.Question24 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_BatQuestion24"))
            Else
                objBatEndYearSchool.Question24 = CType(myparOutput("@p_BatQuestion24"), Single)
            End If
            If myparOutput("@p_BatQuestion25") Is DBNull.Value Then
                objBatEndYearSchool.Question25 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_BatQuestion25"))
            Else
                objBatEndYearSchool.Question25 = CType(myparOutput("@p_BatQuestion25"), Single)
            End If
            If myparOutput("@p_BatQuestion26") Is DBNull.Value Then
                objBatEndYearSchool.Question26 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_BatQuestion26"))
            Else
                objBatEndYearSchool.Question26 = CType(myparOutput("@p_BatQuestion26"), Single)
            End If
            If myparOutput("@p_BatQuestion27") Is DBNull.Value Then
                objBatEndYearSchool.Question27 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_BatQuestion27"))
            Else
                objBatEndYearSchool.Question27 = CType(myparOutput("@p_BatQuestion27"), Single)
            End If
            If myparOutput("@p_BatQuestion28") Is DBNull.Value Then
                objBatEndYearSchool.Question28 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_BatQuestion28"))
            Else
                objBatEndYearSchool.Question28 = CType(myparOutput("@p_BatQuestion28"), Single)
            End If
            If myparOutput("@p_BatQuestion29") Is DBNull.Value Then
                objBatEndYearSchool.Question29 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_BatQuestion29"))
            Else
                objBatEndYearSchool.Question29 = CType(myparOutput("@p_BatQuestion29"), Single)
            End If
            If myparOutput("@p_BatQuestion30") Is DBNull.Value Then
                objBatEndYearSchool.Question30 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_BatQuestion30"))
            Else
                objBatEndYearSchool.Question30 = CType(myparOutput("@p_BatQuestion30"), Single)
            End If

            If myparOutput("@p_BatQuestion31") Is DBNull.Value Then
                objBatEndYearSchool.Question31 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_BatQuestion31"))
            Else
                objBatEndYearSchool.Question31 = CType(myparOutput("@p_BatQuestion31"), Single)
            End If
            If myparOutput("@p_BatQuestion32") Is DBNull.Value Then
                objBatEndYearSchool.Question32 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_BatQuestion32"))
            Else
                objBatEndYearSchool.Question32 = CType(myparOutput("@p_BatQuestion32"), Single)
            End If
            If myparOutput("@p_BatQuestion33") Is DBNull.Value Then
                objBatEndYearSchool.Question33 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_BatQuestion33"))
            Else
                objBatEndYearSchool.Question33 = CType(myparOutput("@p_BatQuestion33"), Single)
            End If
            If myparOutput("@p_BatQuestion34") Is DBNull.Value Then
                objBatEndYearSchool.Question34 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_BatQuestion34"))
            Else
                objBatEndYearSchool.Question34 = CType(myparOutput("@p_BatQuestion34"), Single)
            End If
            If myparOutput("@p_BatQuestion35") Is DBNull.Value Then
                objBatEndYearSchool.Question35 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_BatQuestion35"))
            Else
                objBatEndYearSchool.Question35 = CType(myparOutput("@p_BatQuestion35"), Single)
            End If
            If myparOutput("@p_BatQuestion36") Is DBNull.Value Then
                objBatEndYearSchool.Question36 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_BatQuestion36"))
            Else
                objBatEndYearSchool.Question36 = CType(myparOutput("@p_BatQuestion36"), Single)
            End If
            If myparOutput("@p_BatQuestion37") Is DBNull.Value Then
                objBatEndYearSchool.Question37 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_BatQuestion37"))
            Else
                objBatEndYearSchool.Question37 = CType(myparOutput("@p_BatQuestion37"), Single)
            End If
            If myparOutput("@p_BatQuestion38") Is DBNull.Value Then
                objBatEndYearSchool.Question38 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_BatQuestion38"))
            Else
                objBatEndYearSchool.Question38 = CType(myparOutput("@p_BatQuestion38"), Single)
            End If
            If myparOutput("@p_BatQuestion39") Is DBNull.Value Then
                objBatEndYearSchool.Question39 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_BatQuestion39"))
            Else
                objBatEndYearSchool.Question39 = CType(myparOutput("@p_BatQuestion39"), Single)
            End If
            If myparOutput("@p_BatQuestion40") Is DBNull.Value Then
                objBatEndYearSchool.Question40 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_BatQuestion40"))
            Else
                objBatEndYearSchool.Question40 = CType(myparOutput("@p_BatQuestion40"), Single)
            End If

            If myparOutput("@p_BatQuestion41") Is DBNull.Value Then
                objBatEndYearSchool.Question41 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_BatQuestion41"))
            Else
                objBatEndYearSchool.Question41 = CType(myparOutput("@p_BatQuestion41"), Single)
            End If
            If myparOutput("@p_BatQuestion42") Is DBNull.Value Then
                objBatEndYearSchool.Question42 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_BatQuestion42"))
            Else
                objBatEndYearSchool.Question42 = CType(myparOutput("@p_BatQuestion42"), Single)
            End If
            If myparOutput("@p_BatQuestion43") Is DBNull.Value Then
                objBatEndYearSchool.Question43 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_BatQuestion43"))
            Else
                objBatEndYearSchool.Question43 = CType(myparOutput("@p_BatQuestion43"), Single)
            End If
            If myparOutput("@p_BatQuestion44") Is DBNull.Value Then
                objBatEndYearSchool.Question44 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_BatQuestion44"))
            Else
                objBatEndYearSchool.Question44 = CType(myparOutput("@p_BatQuestion44"), Single)
            End If

            If myparOutput("@p_BatQuestion45") Is DBNull.Value Then
                objBatEndYearSchool.Question45 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_BatQuestion45"))
            Else
                objBatEndYearSchool.Question45 = CType(myparOutput("@p_BatQuestion45"), Single)
            End If

            If myparOutput("@p_BatQuestion46") Is DBNull.Value Then
                objBatEndYearSchool.Question46 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_BatQuestion46"))
            Else
                objBatEndYearSchool.Question46 = CType(myparOutput("@p_BatQuestion46"), Single)
            End If
            If myparOutput("@p_BatQuestion47") Is DBNull.Value Then
                objBatEndYearSchool.Question47 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_BatQuestion47"))
            Else
                objBatEndYearSchool.Question47 = CType(myparOutput("@p_BatQuestion47"), Single)
            End If
            If myparOutput("@p_BatQuestion48") Is DBNull.Value Then
                objBatEndYearSchool.Question48 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_BatQuestion48"))
            Else
                objBatEndYearSchool.Question48 = CType(myparOutput("@p_BatQuestion48"), Single)
            End If
            If myparOutput("@p_BatQuestion49") Is DBNull.Value Then
                objBatEndYearSchool.Question49 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_BatQuestion49"))
            Else
                objBatEndYearSchool.Question49 = CType(myparOutput("@p_BatQuestion49"), Single)
            End If
            If myparOutput("@p_BatQuestion50") Is DBNull.Value Then
                objBatEndYearSchool.Question50 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_BatQuestion50"))
            Else
                objBatEndYearSchool.Question50 = CType(myparOutput("@p_BatQuestion50"), Single)
            End If
            If myparOutput("@p_BatQuestion51") Is DBNull.Value Then
                objBatEndYearSchool.Question51 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_BatQuestion51"))
            Else
                objBatEndYearSchool.Question51 = CType(myparOutput("@p_BatQuestion51"), Single)
            End If
            If myparOutput("@p_BatQuestion52") Is DBNull.Value Then
                objBatEndYearSchool.Question52 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_BatQuestion52"))
            Else
                objBatEndYearSchool.Question52 = CType(myparOutput("@p_BatQuestion52"), Single)
            End If
            If myparOutput("@p_BatQuestion53") Is DBNull.Value Then
                objBatEndYearSchool.Question53 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_BatQuestion53"))
            Else
                objBatEndYearSchool.Question53 = CType(myparOutput("@p_BatQuestion53"), Single)
            End If
            If myparOutput("@p_BatQuestion54") Is DBNull.Value Then
                objBatEndYearSchool.Question54 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_BatQuestion54"))
            Else
                objBatEndYearSchool.Question54 = CType(myparOutput("@p_BatQuestion54"), Single)
            End If
            If myparOutput("@p_BatQuestion55") Is DBNull.Value Then
                objBatEndYearSchool.Question55 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_BatQuestion55"))
            Else
                objBatEndYearSchool.Question55 = CType(myparOutput("@p_BatQuestion55"), Single)
            End If

            If myparOutput("@p_BatQuestion56") Is DBNull.Value Then
                objBatEndYearSchool.Question56 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_BatQuestion56"))
            Else
                objBatEndYearSchool.Question56 = CType(myparOutput("@p_BatQuestion56"), Single)
            End If

            If myparOutput("@p_BatTeamLeader") Is DBNull.Value Then
                objBatEndYearSchool.TeamLeader = C21MIT.Util.DBNullHandler.DBNullToBlank(myparOutput("@p_BatTeamLeader"))
            Else
                objBatEndYearSchool.TeamLeader = CType(myparOutput("@p_BatTeamLeader"), String)
            End If

            If myparOutput("@p_BatTeamMember") Is DBNull.Value Then
                objBatEndYearSchool.TeamMember = C21MIT.Util.DBNullHandler.DBNullToBlank(myparOutput("@p_BatTeamMember"))
            Else
                objBatEndYearSchool.TeamMember = CType(myparOutput("@p_BatTeamMember"), String)
            End If
            Return objBatEndYearSchool

        End Function
        '-------------------------------------------------------------------------------------------------------------------
        ' Function Name : fngetBatEndYearSchool  
        ' Created By : Satish Hanumanthu
        ' Created Dt : Feb 17,2010
        ' Last Updated Dt : Feb 17,2010
        ' Description : This function is used to Insert all the BAT End Year question values for a particular school.
        '-------------------------------------------------------------------------------------------------------------------
        Shared Sub addSchoolBat(ByVal pbatrpt As C21MIT.PBSIS.BO.pbsschoolreport)
            Dim oRequest As New URDALRequest
            Dim oFactory As URDALAbsDBFactory
            Dim oNonQuery As URDALNonQuery
            oFactory = New URDALSQLFactory


            With oRequest
                .Command = "dbo.flpbsis_school_Bat_add"
                .CommandType = CommandType.StoredProcedure
            End With

            oRequest.AddParameter("@p_BatSchoolID", pbatrpt.SchoolID, URDALRequest.myDataType.dtString, 6, ParameterDirection.Input)
            oRequest.AddParameter("@p_BatSchoolYear", pbatrpt.SchoolYear, URDALRequest.myDataType.dtTinyInt, , ParameterDirection.Input)
            oRequest.AddParameter("@p_BatCoachList", pbatrpt.CoachID, URDALRequest.myDataType.dtString, 1000, ParameterDirection.Input)
            oRequest.AddParameter("@p_BatQuestion1", pbatrpt.Question1, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_BatQuestion2", pbatrpt.Question2, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_BatQuestion3", pbatrpt.Question3, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_BatQuestion4", pbatrpt.Question4, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_BatQuestion5", pbatrpt.Question5, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_BatQuestion6", pbatrpt.Question6, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_BatQuestion7", pbatrpt.Question7, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_BatQuestion8", pbatrpt.Question8, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_BatQuestion9", pbatrpt.Question9, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_BatQuestion10", pbatrpt.Question10, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_BatQuestion11", pbatrpt.Question11, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_BatQuestion12", pbatrpt.Question12, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_BatQuestion13", pbatrpt.Question13, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_BatQuestion14", pbatrpt.Question14, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_BatQuestion15", pbatrpt.Question15, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_BatQuestion16", pbatrpt.Question16, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_BatQuestion17", pbatrpt.Question17, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_BatIntrvUsd", pbatrpt.InterviewUsed, URDALRequest.myDataType.dtString, 50, ParameterDirection.Input)
            oRequest.AddParameter("@p_BatQuestion18", pbatrpt.Question18, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_BatQuestion19", pbatrpt.Question19, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_BatQuestion20", pbatrpt.Question20, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_BatQuestion21", pbatrpt.Question21, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_BatQuestion22", pbatrpt.Question22, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_BatQuestion23", pbatrpt.Question23, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_BatQuestion24", pbatrpt.Question24, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_BatQuestion25", pbatrpt.Question25, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_BatQuestion26", pbatrpt.Question26, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_BatQuestion27", pbatrpt.Question27, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_BatQuestion28", pbatrpt.Question28, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_BatQuestion29", pbatrpt.Question29, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_BatQuestion30", pbatrpt.Question30, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_BatQuestion31", pbatrpt.Question31, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_BatQuestion32", pbatrpt.Question32, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_BatQuestion33", pbatrpt.Question33, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_BatQuestion34", pbatrpt.Question34, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_BatQuestion35", pbatrpt.Question35, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_BatQuestion36", pbatrpt.Question36, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_BatQuestion37", pbatrpt.Question37, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_BatQuestion38", pbatrpt.Question38, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_BatQuestion39", pbatrpt.Question39, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_BatQuestion40", pbatrpt.Question40, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_BatQuestion41", pbatrpt.Question41, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_BatQuestion42", pbatrpt.Question42, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_BatQuestion43", pbatrpt.Question43, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_BatQuestion44", pbatrpt.Question44, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_BatQuestion45", pbatrpt.Question45, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_BatQuestion46", pbatrpt.Question46, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_BatQuestion47", pbatrpt.Question47, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_BatQuestion48", pbatrpt.Question48, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_BatQuestion49", pbatrpt.Question49, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_BatQuestion50", pbatrpt.Question50, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_BatQuestion51", pbatrpt.Question51, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_BatQuestion52", pbatrpt.Question52, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_BatQuestion53", pbatrpt.Question53, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_BatQuestion54", pbatrpt.Question54, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_BatQuestion55", pbatrpt.Question55, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_BatQuestion56", pbatrpt.Question56, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_BatTeamLeader", pbatrpt.TeamLeader, URDALRequest.myDataType.dtString, 500, ParameterDirection.Input)
            oRequest.AddParameter("@p_BatTeamMember", pbatrpt.TeamMember, URDALRequest.myDataType.dtString, 1000, ParameterDirection.Input)


            Try
                oNonQuery = oFactory.ExecuteNonQuery(oRequest)

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
    End Class
#End Region
#Region "ODS School"
    Public Class pbsODSSchool
        '-------------------------------------------------------------------------------------------------------------------
        ' Function Name : addschoolODS  
        ' Created By : Aditi Deodhar
        ' Created Dt : Feb 18,2010
        ' Last Updated Dt : Feb 18,2010
        ' Description : This function is used to add all the ODS values for a particular school for a particular year.
        '-------------------------------------------------------------------------------------------------------------------
        Shared Function addschoolODS(ByVal objODS As C21MIT.PBSIS.BO.pbsods) As C21MIT.PBSIS.BO.pbsods
            Dim oRequest As New URDALRequest
            Dim oFactory As URDALAbsDBFactory
            Dim oNonQuery As URDALNonQuery
            oFactory = New URDALSQLFactory
            Dim myparOutput As New Hashtable
            With oRequest
                .Command = "dbo.flpbsis_school_ODS_add"
                .CommandType = CommandType.StoredProcedure
            End With

            oRequest.AddParameter("@p_OdSchoolID", objODS.SchoolID, URDALRequest.myDataType.dtString, 6, ParameterDirection.Input)
            oRequest.AddParameter("@p_OdSchYr", objODS.SchoolYear, URDALRequest.myDataType.dtTinyInt, , ParameterDirection.Input)
            oRequest.AddParameter("@p_OdTotalSchoolDays", objODS.OdTotalSchoolDays, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_OdAvgDailyAttendance", objODS.OdAvgDailyAttendance, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_OdTotalOfficeReferrals", objODS.OdTotalOfficeReferrals, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_OdTotalISSDays", objODS.OdTotalISSDays, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_OdTotalOSSDays", objODS.OdTotalOSSDays, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)

            'Insert null values
            oRequest.AddParameter("@p_OdPercentReadingGains", DBNull.Value, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_OdPercentLowest25Reading", DBNull.Value, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_OdDibFallPercLowRisk", DBNull.Value, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_OdDibWtrPercLowRisk", DBNull.Value, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_OdDibSprPercLowRisk", DBNull.Value, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_OdDibFallLowRiskN", DBNull.Value, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_OdDibWtrLowRiskN", DBNull.Value, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_OdDibSprLowRiskN", DBNull.Value, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_OdDibFallPercSomeRisk", DBNull.Value, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_OdDibWtrPercSomeRisk", DBNull.Value, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_OdDibSprPercSomeRisk", DBNull.Value, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_OdDibFallSomeRiskN", DBNull.Value, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_OdDibWtrSomeRiskN", DBNull.Value, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_OdDibSprSomeRiskN", DBNull.Value, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_OdDibFallPercAtRisk", DBNull.Value, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_OdDibWtrPercAtRisk", DBNull.Value, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_OdDibSprPercAtRisk", DBNull.Value, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_OdDibFallAtRiskN", DBNull.Value, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_OdDibWtrAtRiskN", DBNull.Value, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_OdDibSprAtRiskN", DBNull.Value, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)

            oRequest.AddParameter("@p_OdProgMonTarget", objODS.OdProgMonTarget, URDALRequest.myDataType.dtTinyInt, , ParameterDirection.Input)
            oRequest.AddParameter("@p_OdProgMonTargDesc", objODS.OdProgMonTargDesc, URDALRequest.myDataType.dtString, 1900, ParameterDirection.Input)
            oRequest.AddParameter("@p_OdProgMonIndiv", objODS.OdProgMonIndiv, URDALRequest.myDataType.dtTinyInt, , ParameterDirection.Input)
            oRequest.AddParameter("@p_OdProgMonIndDesc", objODS.OdProgMonIndDesc, URDALRequest.myDataType.dtString, 1900, ParameterDirection.Input)

            'Added May 18 by Aditi
            oRequest.AddParameter("@p_OdPercLvl3FcatRead", DBNull.Value, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_OdSchoolGrade", DBNull.Value, URDALRequest.myDataType.dtString, , ParameterDirection.Input)
            oRequest.AddParameter("@p_OdTotalSchoolPoints", DBNull.Value, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)

            oRequest.AddParameter("@p_OdIdOut", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
          
            Try
                oNonQuery = oFactory.ExecuteNonQuery(oRequest)
                myparOutput = oRequest.URParOutputs

                If Not IsNothing(oRequest.Exception) Then
                    Throw New ApplicationException("sqlexception", oRequest.Exception)
                End If

            Catch ex As Exception
                Dim objerrLog As New MITErrorHandling.MITErrorHandling("Exception: " & "in addschoolODS - " & ex.ToString())
                objerrLog.logError()
                System.Web.HttpContext.Current.Response.Redirect("~/users/smessages.aspx?qModule=TechErr", False)
            Finally
                oFactory.ConDispose()
            End Try

            objODS.OdIdOut = CType(myparOutput("@p_OdIdOut"), Integer)
           
            Return objODS
        End Function

        '-------------------------------------------------------------------------------------------------------------------
        ' Function Name : addschoolBaselineODS  
        ' Created By : Satish Hanumanthu
        ' Created Dt : May 18,2010
        ' Last Updated Dt :May 18,2010
        ' Description : This function is used to add all the ODS values for a particular school for a particular year.
        '-------------------------------------------------------------------------------------------------------------------
        Shared Function addschoolBaselineODS(ByVal objODS As C21MIT.PBSIS.BO.pbsods) As C21MIT.PBSIS.BO.pbsods
            Dim oRequest As New URDALRequest
            Dim oFactory As URDALAbsDBFactory
            Dim oNonQuery As URDALNonQuery
            oFactory = New URDALSQLFactory
            Dim myparOutput As New Hashtable
            With oRequest
                .Command = "dbo.flpbsis_school_ODS_add"
                .CommandType = CommandType.StoredProcedure
            End With

            oRequest.AddParameter("@p_OdSchoolID", objODS.SchoolID, URDALRequest.myDataType.dtString, 6, ParameterDirection.Input)
            oRequest.AddParameter("@p_OdSchYr", objODS.SchoolYear, URDALRequest.myDataType.dtTinyInt, , ParameterDirection.Input)
            oRequest.AddParameter("@p_OdTotalSchoolDays", objODS.OdTotalSchoolDays, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_OdAvgDailyAttendance", objODS.OdAvgDailyAttendance, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_OdTotalOfficeReferrals", objODS.OdTotalOfficeReferrals, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_OdTotalISSDays", objODS.OdTotalISSDays, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_OdTotalOSSDays", objODS.OdTotalOSSDays, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)

            'Insert null values
            oRequest.AddParameter("@p_OdPercentReadingGains", objODS.OdPercentReadingGains, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_OdPercentLowest25Reading", objODS.OdPercentLowest25Reading, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_OdDibFallPercLowRisk", DBNull.Value, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_OdDibWtrPercLowRisk", DBNull.Value, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_OdDibSprPercLowRisk", DBNull.Value, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_OdDibFallLowRiskN", DBNull.Value, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_OdDibWtrLowRiskN", DBNull.Value, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_OdDibSprLowRiskN", DBNull.Value, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_OdDibFallPercSomeRisk", DBNull.Value, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_OdDibWtrPercSomeRisk", DBNull.Value, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_OdDibSprPercSomeRisk", DBNull.Value, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_OdDibFallSomeRiskN", DBNull.Value, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_OdDibWtrSomeRiskN", DBNull.Value, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_OdDibSprSomeRiskN", DBNull.Value, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_OdDibFallPercAtRisk", DBNull.Value, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_OdDibWtrPercAtRisk", DBNull.Value, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_OdDibSprPercAtRisk", DBNull.Value, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_OdDibFallAtRiskN", DBNull.Value, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_OdDibWtrAtRiskN", DBNull.Value, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_OdDibSprAtRiskN", DBNull.Value, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)

            oRequest.AddParameter("@p_OdProgMonTarget", objODS.OdProgMonTarget, URDALRequest.myDataType.dtTinyInt, , ParameterDirection.Input)
            oRequest.AddParameter("@p_OdProgMonTargDesc", objODS.OdProgMonTargDesc, URDALRequest.myDataType.dtString, 1900, ParameterDirection.Input)
            oRequest.AddParameter("@p_OdProgMonIndiv", objODS.OdProgMonIndiv, URDALRequest.myDataType.dtTinyInt, , ParameterDirection.Input)
            oRequest.AddParameter("@p_OdProgMonIndDesc", objODS.OdProgMonIndDesc, URDALRequest.myDataType.dtString, 1900, ParameterDirection.Input)
            oRequest.AddParameter("@p_OdPercLvl3FcatRead", objODS.OdPercLvl3FcatRead, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_OdSchoolGrade", objODS.OdSchoolGrade, URDALRequest.myDataType.dtString, , ParameterDirection.Input)
            oRequest.AddParameter("@p_OdTotalSchoolPoints", objODS.OdTotalSchoolPoints, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)

            oRequest.AddParameter("@p_OdIdOut", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)

            Try
                oNonQuery = oFactory.ExecuteNonQuery(oRequest)
                myparOutput = oRequest.URParOutputs

                If Not IsNothing(oRequest.Exception) Then
                    Throw New ApplicationException("sqlexception", oRequest.Exception)
                End If

            Catch ex As Exception
                Dim objerrLog As New MITErrorHandling.MITErrorHandling("Exception: " & "in addschoolODS - " & ex.ToString())
                objerrLog.logError()
                System.Web.HttpContext.Current.Response.Redirect("~/users/smessages.aspx?qModule=TechErr", False)
            Finally
                oFactory.ConDispose()
            End Try

            objODS.OdIdOut = CType(myparOutput("@p_OdIdOut"), Integer)

            Return objODS
        End Function
        '-------------------------------------------------------------------------------------------------------------------
        ' Function Name : getODSOutput  
        ' Created By : Aditi Deodhar
        ' Created Dt : Feb 19,2009
        ' Last Updated Dt : Feb 19,2009
        ' Description : This function gets the ODS required output data as ODS Yr and School Id
        '--------------------------------------------------------------------------------------------------------------------
        Shared Function getODSOutput(ByVal odid As Integer) As C21MIT.PBSIS.BO.pbsods
            Dim oRequest As New URDALRequest
            Dim oFactory As URDALAbsDBFactory
            Dim oNonQuery As URDALNonQuery
            oFactory = New URDALSQLFactory
            Dim myparOutput As New Hashtable
            With oRequest
                .Command = "dbo.pbsis_slr_ODS_Output"
                .CommandType = CommandType.StoredProcedure
            End With

            oRequest.AddParameter("@p_OdID", odid, URDALRequest.myDataType.dtString, 6, ParameterDirection.Input)
            oRequest.AddParameter("@p_OdSchYrOut", , URDALRequest.myDataType.dtTinyInt, , ParameterDirection.Output)
            oRequest.AddParameter("@p_OdSchoolIDOut", , URDALRequest.myDataType.dtString, 6, ParameterDirection.Output)

            'oRequest.AddParameter("@p_ODSDocName", odsdocname, URDALRequest.myDataType.dtString, 100, ParameterDirection.Input)

            Try
                oNonQuery = oFactory.ExecuteNonQuery(oRequest)
                myparOutput = oRequest.URParOutputs

                If Not IsNothing(oRequest.Exception) Then
                    Throw New ApplicationException("sqlexception", oRequest.Exception)
                End If

            Catch ex As Exception
                Dim objerrLog As New MITErrorHandling.MITErrorHandling("Exception: " & "in addODSSchoolDocument - " & ex.ToString())
                objerrLog.logError()
                System.Web.HttpContext.Current.Response.Redirect("~/users/smessages.aspx?qModule=TechErr", False)
            Finally
                oFactory.ConDispose()
            End Try

            Dim objODS As New C21MIT.PBSIS.BO.pbsods

            objODS.OdSchYrOut = CType(myparOutput("@p_OdSchYrOut"), Integer)
            objODS.OdSchoolIDOut = CType(myparOutput("@p_OdSchoolIDOut"), String)

            Return objODS
        End Function
        '-------------------------------------------------------------------------------------------------------------------
        ' Function Name : getODSDocs  
        ' Created By : Aditi Deodhar
        ' Created Dt : Feb 19,2009
        ' Last Updated Dt : Feb 19,2009
        ' Description : This function gets the ODS documents
        '--------------------------------------------------------------------------------------------------------------------
        Public Shared Function getODSDocs(ByVal odid As Integer, ByVal SchYr As Integer) As DataSet
            Dim oRequest As New URDALRequest
            Dim oFactory As URDALAbsDBFactory
            Dim myDataset As New DataSet
            oFactory = New URDALSQLFactory

            With oRequest
                .Command = "dbo.pbsis_slr_ODS_GetDocs"
                .CommandType = CommandType.StoredProcedure
            End With
            oRequest.AddParameter("@p_OdID", odid, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_SchYr", SchYr, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)

            Try
                myDataset = oFactory.ExecuteDataSet(oRequest).ReturnedDataSet

                If Not IsNothing(oRequest.Exception) Then
                    Throw New ApplicationException("sqlexception", oRequest.Exception)
                End If

            Catch ex As Exception
                Dim objerrLog As New MITErrorHandling.MITErrorHandling("Exception : " & ex.Message)
                objerrLog.logError()
                System.Web.HttpContext.Current.Response.Redirect("~/users/smessages.aspx?qModule=TechErr", False)

            Finally
                oFactory.ConDispose()
            End Try

            Return myDataset

        End Function
        '-------------------------------------------------------------------------------------------------------------------
        ' Proc Name : insertODSDocs  
        ' Created By : Aditi Deodhar
        ' Created Dt : Feb 19,2009
        ' Last Updated Dt : Feb 19,2009
        ' Description : This function inserts the ODS documents
        '--------------------------------------------------------------------------------------------------------------------
        Shared Sub insertODSDocs(ByVal objdoc As C21MIT.PBSIS.BO.pbsods)
            Dim oRequest As New URDALRequest
            Dim oFactory As URDALAbsDBFactory
            Dim oNonQuery As URDALNonQuery
            'Dim oScalar As URDALScalar
            oFactory = New URDALSQLFactory
            Dim myparOutput As New Hashtable
            With oRequest
                .Command = "dbo.pbsis_slr_ODS_InsertDocs"
                .CommandType = CommandType.StoredProcedure
            End With
            Dim str As String
            str = Convert.ToByte(0)

            oRequest.AddParameter("@p_OdID", objdoc.OdIdOut, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_ODSDocName", objdoc.OdDocName, URDALRequest.myDataType.dtString, 100, ParameterDirection.Input)
            oRequest.AddParameter("@p_ODSstatus", 1, URDALRequest.myDataType.dtTinyInt, , ParameterDirection.Input)

            Try
                oNonQuery = oFactory.ExecuteNonQuery(oRequest)

                myparOutput = oRequest.URParOutputs
                If Not IsNothing(oRequest.Exception) Then
                    Throw New ApplicationException("sqlexception", oRequest.Exception)
                End If

            Catch ex As Exception
                Dim objerrLog As New MITErrorHandling.MITErrorHandling("Invalid Log Name: " & oRequest.Exception.ToString)
                objerrLog.logError()
                System.Web.HttpContext.Current.Response.Redirect("~/users/smessages.aspx?qModule=TechErr", False)
            Finally
                oFactory.ConDispose()
            End Try

        End Sub
        '-------------------------------------------------------------------------------------------------------------------
        ' Function Name : fngetODSEndYearSchool  
        ' Created By : Aditi Deodhar
        ' Created Dt : Feb 22,2010
        ' Last Updated Dt : Feb 22,2010
        ' Description : This function is used to get all the ODS End Year question values for a particular school.
        '-------------------------------------------------------------------------------------------------------------------
        Shared Function fngetODSEndYearSchool(ByVal schoolID As String, ByVal schoolYr As Integer) As C21MIT.PBSIS.BO.pbsods
            Dim oRequest As New URDALRequest
            Dim oFactory As URDALAbsDBFactory
            Dim oNonQuery As URDALNonQuery
            oFactory = New URDALSQLFactory

            Dim myparOutput As New Hashtable

            Dim objODSEndYearSchool As New C21MIT.PBSIS.BO.pbsods

            With oRequest
                .Command = "dbo.flpbsis_school_ODS_select_new"
                .CommandType = CommandType.StoredProcedure
            End With

            oRequest.AddParameter("@p_OdSchoolID", schoolID, URDALRequest.myDataType.dtString, 6, ParameterDirection.Input)
            oRequest.AddParameter("@p_OdSchYr", schoolYr, URDALRequest.myDataType.dtTinyInt, , ParameterDirection.Input)

            oRequest.AddParameter("@p_OdId", , URDALRequest.myDataType.dtTinyInt, , ParameterDirection.Output)

            oRequest.AddParameter("@p_schoolname", , URDALRequest.myDataType.dtString, 75, ParameterDirection.Output)
            oRequest.AddParameter("@p_districtname", , URDALRequest.myDataType.dtString, 75, ParameterDirection.Output)
            oRequest.AddParameter("@p_OdTotalSchoolDays", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_OdAvgDailyAttendance", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_OdTotalOfficeReferrals", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_OdTotalISSDays", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_OdTotalOSSDays", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_OdPercentReadingGains", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_OdPercentLowest25Reading", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_OdDibFallPercLowRisk", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_OdDibWtrPercLowRisk", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_OdDibSprPercLowRisk", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_OdDibFallLowRiskN", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_OdDibWtrLowRiskN", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_OdDibSprLowRiskN", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_OdDibFallPercSomeRisk", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_OdDibWtrPercSomeRisk", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_OdDibSprPercSomeRisk", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_OdDibFallSomeRiskN", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_OdDibWtrSomeRiskN", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_OdDibSprSomeRiskN", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_OdDibFallPercAtRisk", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_OdDibWtrPercAtRisk", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_OdDibSprPercAtRisk", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_OdDibFallAtRiskN", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_OdDibWtrAtRiskN", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_OdDibSprAtRiskN", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_OdProgMonTarget", , URDALRequest.myDataType.dtTinyInt, , ParameterDirection.Output)
            oRequest.AddParameter("@p_OdProgMonTargDesc", , URDALRequest.myDataType.dtString, 1900, ParameterDirection.Output)
            oRequest.AddParameter("@p_OdProgMonIndiv", , URDALRequest.myDataType.dtTinyInt, , ParameterDirection.Output)
            oRequest.AddParameter("@p_OdProgMonIndDesc", , URDALRequest.myDataType.dtString, 1900, ParameterDirection.Output)



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




            If myparOutput("@p_OdId") Is DBNull.Value Then
                objODSEndYearSchool.OdIdOut = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_OdId"))
            Else
                objODSEndYearSchool.OdIdOut = C21MIT.Util.DBNullHandler.DBNullToBlank(CType(myparOutput("@p_OdId"), Integer))
            End If

            If myparOutput("@p_schoolname") Is DBNull.Value Then
                objODSEndYearSchool.SchoolName = ""
            Else
                objODSEndYearSchool.SchoolName = CType(myparOutput("@p_schoolname"), String)
            End If

            If myparOutput("@p_districtname") Is DBNull.Value Then
                objODSEndYearSchool.DistrictName = ""
            Else
                objODSEndYearSchool.DistrictName = CType(myparOutput("@p_districtname"), String)
            End If


            If myparOutput("@p_OdTotalSchoolDays") Is DBNull.Value Then
                objODSEndYearSchool.OdTotalSchoolDays = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_OdTotalSchoolDays"))
            Else
                objODSEndYearSchool.OdTotalSchoolDays = CType(myparOutput("@p_OdTotalSchoolDays"), Integer)
            End If



            If myparOutput("@p_OdAvgDailyAttendance") Is DBNull.Value Then
                objODSEndYearSchool.OdAvgDailyAttendance = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_OdAvgDailyAttendance"))
            Else
                objODSEndYearSchool.OdAvgDailyAttendance = CType(myparOutput("@p_OdAvgDailyAttendance"), Integer)
            End If



            If myparOutput("@p_OdTotalOfficeReferrals") Is DBNull.Value Then
                objODSEndYearSchool.OdTotalOfficeReferrals = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_OdTotalOfficeReferrals"))
            Else
                objODSEndYearSchool.OdTotalOfficeReferrals = CType(myparOutput("@p_OdTotalOfficeReferrals"), Integer)
            End If


            If myparOutput("@p_OdTotalISSDays") Is DBNull.Value Then
                objODSEndYearSchool.OdTotalISSDays = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_OdTotalISSDays"))
            Else
                objODSEndYearSchool.OdTotalISSDays = CType(myparOutput("@p_OdTotalISSDays"), Integer)
            End If

            If myparOutput("@p_OdTotalOSSDays") Is DBNull.Value Then
                objODSEndYearSchool.OdTotalOSSDays = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_OdTotalOSSDays"))
            Else
                objODSEndYearSchool.OdTotalOSSDays = CType(myparOutput("@p_OdTotalOSSDays"), Integer)
            End If


            If myparOutput("@p_OdProgMonTarget") Is DBNull.Value Then
                objODSEndYearSchool.OdProgMonTarget = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_OdProgMonTarget"))
            Else
                objODSEndYearSchool.OdProgMonTarget = CType(myparOutput("@p_OdProgMonTarget"), Integer)
            End If

            If myparOutput("@p_OdProgMonTargDesc") Is DBNull.Value Then
                objODSEndYearSchool.OdProgMonTargDesc = C21MIT.Util.DBNullHandler.DBNullToBlank(myparOutput("@p_OdProgMonTargDesc"))
            Else
                objODSEndYearSchool.OdProgMonTargDesc = CType(myparOutput("@p_OdProgMonTargDesc"), String)
            End If


            If myparOutput("@p_OdProgMonIndi") Is DBNull.Value Then
                objODSEndYearSchool.OdProgMonIndiv = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_OdProgMonIndi"))
            Else
                objODSEndYearSchool.OdProgMonIndiv = CType(myparOutput("@p_OdProgMonIndi"), Integer)
            End If

            If myparOutput("@p_OdProgMonIndDesc") Is DBNull.Value Then
                objODSEndYearSchool.OdProgMonIndDesc = C21MIT.Util.DBNullHandler.DBNullToBlank(myparOutput("@p_OdProgMonIndDesc"))
            Else
                objODSEndYearSchool.OdProgMonIndDesc = CType(myparOutput("@p_OdProgMonIndDesc"), String)
            End If


            Return objODSEndYearSchool

        End Function
        '-------------------------------------------------------------------------------------------------------------------
        ' Function Name : deleteODSDocs  
        ' Created By : Aditi Deodhar
        ' Created Dt : Feb 22,2010
        ' Last Updated Dt : Feb 22,2010
        ' Description : This function is used to delete the ODS End Year documents for a particular school.
        '-------------------------------------------------------------------------------------------------------------------
        Shared Sub deleteODSDocs(ByVal odid As Integer)
            Dim oRequest As New URDALRequest
            Dim oFactory As URDALAbsDBFactory
            Dim oNonQuery As URDALNonQuery
            oFactory = New URDALSQLFactory

            With oRequest
                .Command = "flpbs_deleteODSDocs"
                .CommandType = CommandType.StoredProcedure
            End With

            oRequest.AddParameter("@p_OdId", odid, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)

            Try
                oNonQuery = oFactory.ExecuteNonQuery(oRequest)

                If Not IsNothing(oRequest.Exception) Then
                    Throw New ApplicationException("sqlexception", oRequest.Exception)
                End If
            Catch ex As Exception
                Dim objerrLog As New MITErrorHandling.MITErrorHandling("Invalid Log Name: " & ex.Message)
                objerrLog.logError()
                System.Web.HttpContext.Current.Response.Redirect("~/users/smessages.aspx?qModule=TechErr", False)
            Finally
                oFactory.ConDispose()
            End Try
        End Sub
    End Class
#End Region
#Region "DemoData School"
    Public Class pbsDemoDataSchool
        '-------------------------------------------------------------------------------------------------------------------
        ' Function Name : addDemoDataSchool
        ' Created By : Satish
        ' Created Dt : Feb 23,2010
        ' Last Updated Dt : Feb 09,2010
        ' Description : This function is used to add all the Demodata  values for a particular school for a particular year.
        '-------------------------------------------------------------------------------------------------------------------
        Shared Sub addDemoDataschool(ByVal objDemo As C21MIT.PBSIS.BO.pbsdemodata)
            Dim oRequest As New URDALRequest
            Dim oFactory As URDALAbsDBFactory
            Dim oNonQuery As URDALNonQuery
            oFactory = New URDALSQLFactory
            Dim myparOutput As New Hashtable
            With oRequest
                .Command = "flpbsis_school_DemoData_insert"
                .CommandType = CommandType.StoredProcedure
            End With

            oRequest.AddParameter("@p_DemoTchSchoolID", objDemo.SchoolID, URDALRequest.myDataType.dtString, 6, ParameterDirection.Input)
            oRequest.AddParameter("@p_DemoTchSchYr", objDemo.SchoolYear, URDALRequest.myDataType.dtTinyInt, , ParameterDirection.Input)
            oRequest.AddParameter("@p_DemoTchAmericanIndian", objDemo.DemoTchAmericanIndian, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_DemoTchAsian", objDemo.DemoTchAsian, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_DemoTchBlack", objDemo.DemoTchBlack, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_DemoTchHispanic", objDemo.DemoTchHispanic, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_DemoTchMulticultural", objDemo.DemoTchMulticultural, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_DemoTchWhite", objDemo.DemoTchWhite, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_DemoTchOther", objDemo.DemoTchOther, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_DemoTchTotalEnrollment", objDemo.DemoTchTotalEnrollment, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_DemoTchStudentsWithIEP", objDemo.DemoTchStudentsWithIEP, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_DemoTchPercFreeRedcLunch", objDemo.DemoTchPercFreeRedcLunch, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_DemoTchTitleOne", objDemo.DemoTchTitleOne, URDALRequest.myDataType.dtTinyInt, , ParameterDirection.Input)
            oRequest.AddParameter("@p_DemoTchReadingFirst", objDemo.DemoTchReadingFirst, URDALRequest.myDataType.dtTinyInt, , ParameterDirection.Input)
            oRequest.AddParameter("@p_DemoTchProblemSolvModel", objDemo.DemoTchProblemSolvModel, URDALRequest.myDataType.dtTinyInt, , ParameterDirection.Input)
            oRequest.AddParameter("@p_DemoTchOtherInitiatives", objDemo.DemoTchOtherInitiatives, URDALRequest.myDataType.dtString, , ParameterDirection.Input)
            oRequest.AddParameter("@p_DemoTchAcademicSystems", objDemo.DemoTchAcademicSystems, URDALRequest.myDataType.dtString, , ParameterDirection.Input)
            oRequest.AddParameter("@p_DemoTchBehaviorSystems", objDemo.DemoTchBehaviorSystems, URDALRequest.myDataType.dtString, , ParameterDirection.Input)
            oRequest.AddParameter("@p_DemoTchTotalInstStaff", objDemo.DemoTchTotalInstStaff, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_DemoTchPercInstStaff", objDemo.DemoTchPercInstStaff, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_DemoTchPercAdvDegree", objDemo.DemoTchPercAdvDegree, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_DemoTchPercOOFTeacher", objDemo.DemoTchPercOOFTeacher, URDALRequest.myDataType.dtInteger, , ParameterDirection.Input)
            oRequest.AddParameter("@p_DemoTchTargBehIntv", objDemo.DemoTchTargBehIntv, URDALRequest.myDataType.dtTinyInt, , ParameterDirection.Input)
            oRequest.AddParameter("@p_DemoTchIntvBEP", objDemo.DemoTchIntvBEP, URDALRequest.myDataType.dtTinyInt, , ParameterDirection.Input)
            oRequest.AddParameter("@p_DemoTchIntvICPS", objDemo.DemoTchIntvICPS, URDALRequest.myDataType.dtTinyInt, , ParameterDirection.Input)
            oRequest.AddParameter("@p_DemoTchIntvSklStr", objDemo.DemoTchIntvSklStr, URDALRequest.myDataType.dtTinyInt, , ParameterDirection.Input)
            oRequest.AddParameter("@p_DemoTchIntvPrep", objDemo.DemoTchIntvPrep, URDALRequest.myDataType.dtTinyInt, , ParameterDirection.Input)
            oRequest.AddParameter("@p_DemoTchIntvSTR", objDemo.DemoTchIntvSTR, URDALRequest.myDataType.dtTinyInt, , ParameterDirection.Input)
            oRequest.AddParameter("@p_DemoTchIntvSecStp", objDemo.DemoTchIntvSecStp, URDALRequest.myDataType.dtTinyInt, , ParameterDirection.Input)
            oRequest.AddParameter("@p_DemoTchIntvSC", objDemo.DemoTchIntvSC, URDALRequest.myDataType.dtTinyInt, , ParameterDirection.Input)
            oRequest.AddParameter("@p_DemoTchIntvOth", objDemo.DemoTchIntvOth, URDALRequest.myDataType.dtTinyInt, , ParameterDirection.Input)
            oRequest.AddParameter("@p_DemoTchIntvOthDesc", objDemo.DemoTchIntvOthDesc, URDALRequest.myDataType.dtString, , ParameterDirection.Input)
            oRequest.AddParameter("@p_DemoTchIndLvlPbs", objDemo.DemoTchIndLvlPbs, URDALRequest.myDataType.dtTinyInt, , ParameterDirection.Input)
            oRequest.AddParameter("@p_DemoTchPbsERASE", objDemo.DemoTchPbsERASE, URDALRequest.myDataType.dtTinyInt, , ParameterDirection.Input)
            oRequest.AddParameter("@p_DemoTchPbsPTR", objDemo.DemoTchPbsPTR, URDALRequest.myDataType.dtTinyInt, , ParameterDirection.Input)
            oRequest.AddParameter("@p_DemoTchPbsOth", objDemo.DemoTchPbsOth, URDALRequest.myDataType.dtTinyInt, , ParameterDirection.Input)
            oRequest.AddParameter("@p_DemoTchPbsOthDesc", objDemo.DemoTchPbsOthDesc, URDALRequest.myDataType.dtString, , ParameterDirection.Input)

            Try
                oNonQuery = oFactory.ExecuteNonQuery(oRequest)
                myparOutput = oRequest.URParOutputs

                If Not IsNothing(oRequest.Exception) Then
                    Throw New ApplicationException("sqlexception", oRequest.Exception)
                End If

            Catch ex As Exception
                Dim objerrLog As New MITErrorHandling.MITErrorHandling("Exception: " & "in addschoolODS - " & ex.ToString())
                objerrLog.logError()
                System.Web.HttpContext.Current.Response.Redirect("~/users/smessages.aspx?qModule=TechErr", False)
            Finally
                oFactory.ConDispose()
            End Try
        End Sub

        '-------------------------------------------------------------------------------------------------------------------
        ' Function Name : fngetDemodataEndYearSchool  
        ' Created By : Aditi Deodhar
        ' Created Dt : Feb 22,2010
        ' Last Updated Dt : Feb 22,2010
        ' Description : This function is used to get all the DemoData question values for a particular school for a school year.
        '-------------------------------------------------------------------------------------------------------------------
        Shared Function fngetDemodataEndYearSchool(ByVal schoolID As String, ByVal schoolYr As Integer) As C21MIT.PBSIS.BO.pbsdemodata
            Dim oRequest As New URDALRequest
            Dim oFactory As URDALAbsDBFactory
            Dim oNonQuery As URDALNonQuery
            oFactory = New URDALSQLFactory

            Dim myparOutput As New Hashtable

            Dim objDemodataSchool As New C21MIT.PBSIS.BO.pbsdemodata

            With oRequest
                .Command = "flpbsis_school_DemoData_select"
                .CommandType = CommandType.StoredProcedure
            End With

            oRequest.AddParameter("@p_DemoTchSchoolID", schoolID, URDALRequest.myDataType.dtString, 6, ParameterDirection.Input)
            oRequest.AddParameter("@p_DemoTchSchYr", schoolYr, URDALRequest.myDataType.dtTinyInt, , ParameterDirection.Input)

            oRequest.AddParameter("@p_schoolname", , URDALRequest.myDataType.dtString, 75, ParameterDirection.Output)
            oRequest.AddParameter("@p_districtname", , URDALRequest.myDataType.dtString, 75, ParameterDirection.Output)

            oRequest.AddParameter("@p_DemoTchAmericanIndian", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_DemoTchAsian", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_DemoTchBlack", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_DemoTchHispanic", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_DemoTchMulticultural", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_DemoTchWhite", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_DemoTchOther", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_DemoTchTotalEnrollment", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_DemoTchStudentsWithIEP", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_DemoTchPercFreeRedcLunch", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)

            oRequest.AddParameter("@p_DemoTchTitleOne", , URDALRequest.myDataType.dtTinyInt, , ParameterDirection.Output)
            oRequest.AddParameter("@p_DemoTchReadingFirst", , URDALRequest.myDataType.dtTinyInt, , ParameterDirection.Output)
            oRequest.AddParameter("@p_DemoTchProblemSolvModel", , URDALRequest.myDataType.dtTinyInt, , ParameterDirection.Output)

            oRequest.AddParameter("@p_DemoTchOtherInitiatives", , URDALRequest.myDataType.dtString, 250, ParameterDirection.Output)
            oRequest.AddParameter("@p_DemoTchAcademicSystems", , URDALRequest.myDataType.dtString, 100, ParameterDirection.Output)
            oRequest.AddParameter("@p_DemoTchBehaviorSystems", , URDALRequest.myDataType.dtString, 100, ParameterDirection.Output)

            oRequest.AddParameter("@p_DemoTchTotalInstStaff", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_DemoTchPercInstStaff", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_DemoTchPercAdvDegree", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_DemoTchPercOOFTeacher", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)

            oRequest.AddParameter("@p_DemoTchTargBehIntv", , URDALRequest.myDataType.dtTinyInt, , ParameterDirection.Output)
            oRequest.AddParameter("@p_DemoTchIntvBEP", , URDALRequest.myDataType.dtTinyInt, , ParameterDirection.Output)
            oRequest.AddParameter("@p_DemoTchIntvICPS", , URDALRequest.myDataType.dtTinyInt, , ParameterDirection.Output)
            oRequest.AddParameter("@p_DemoTchIntvSklStr", , URDALRequest.myDataType.dtTinyInt, , ParameterDirection.Output)
            oRequest.AddParameter("@p_DemoTchIntvPrep", , URDALRequest.myDataType.dtTinyInt, , ParameterDirection.Output)
            oRequest.AddParameter("@p_DemoTchIntvSTR", , URDALRequest.myDataType.dtTinyInt, , ParameterDirection.Output)
            oRequest.AddParameter("@p_DemoTchIntvSecStp", , URDALRequest.myDataType.dtTinyInt, , ParameterDirection.Output)
            oRequest.AddParameter("@p_DemoTchIntvSC", , URDALRequest.myDataType.dtTinyInt, , ParameterDirection.Output)
            oRequest.AddParameter("@p_DemoTchIntvOth", , URDALRequest.myDataType.dtTinyInt, , ParameterDirection.Output)

            oRequest.AddParameter("@p_DemoTchIntvOthDesc", , URDALRequest.myDataType.dtString, 250, ParameterDirection.Output)
            oRequest.AddParameter("@p_DemoTchIndLvlPbs", , URDALRequest.myDataType.dtTinyInt, , ParameterDirection.Output)
            oRequest.AddParameter("@p_DemoTchPbsERASE", , URDALRequest.myDataType.dtTinyInt, , ParameterDirection.Output)
            oRequest.AddParameter("@p_DemoTchPbsPTR", , URDALRequest.myDataType.dtTinyInt, , ParameterDirection.Output)
            oRequest.AddParameter("@p_DemoTchPbsOth", , URDALRequest.myDataType.dtTinyInt, , ParameterDirection.Output)
            oRequest.AddParameter("@p_DemoTchPbsOthDesc", , URDALRequest.myDataType.dtString, 250, ParameterDirection.Output)

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

            If myparOutput("@p_schoolname") Is DBNull.Value Then
                objDemodataSchool.SchoolName = ""
            Else
                objDemodataSchool.SchoolName = C21MIT.Util.DBNullHandler.DBNullToBlank(CType(myparOutput("@p_schoolname"), String))
            End If

            If myparOutput("@p_districtname") Is DBNull.Value Then
                objDemodataSchool.DistrictName = C21MIT.Util.DBNullHandler.DBNullToBlank(myparOutput("@p_districtname"))
            Else
                objDemodataSchool.DistrictName = CType(myparOutput("@p_districtname"), String)
            End If

            If myparOutput("@p_DemoTchAmericanIndian") Is DBNull.Value Then
                objDemodataSchool.DemoTchAmericanIndian = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_DemoTchAmericanIndian"))
            Else
                objDemodataSchool.DemoTchAmericanIndian = CType(myparOutput("@p_DemoTchAmericanIndian"), Integer)
            End If

            If myparOutput("@p_DemoTchAsian") Is DBNull.Value Then
                objDemodataSchool.DemoTchAsian = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_DemoTchAsian"))
            Else
                objDemodataSchool.DemoTchAsian = CType(myparOutput("@p_DemoTchAsian"), Integer)
            End If

            If myparOutput("@p_DemoTchBlack") Is DBNull.Value Then
                objDemodataSchool.DemoTchBlack = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_DemoTchBlack"))
            Else
                objDemodataSchool.DemoTchBlack = CType(myparOutput("@p_DemoTchBlack"), Integer)
            End If

            If myparOutput("@p_DemoTchHispanic") Is DBNull.Value Then
                objDemodataSchool.DemoTchHispanic = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_DemoTchHispanic"))
            Else
                objDemodataSchool.DemoTchHispanic = CType(myparOutput("@p_DemoTchHispanic"), Integer)
            End If

            If myparOutput("@p_DemoTchMulticultural") Is DBNull.Value Then
                objDemodataSchool.DemoTchMulticultural = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_DemoTchMulticultural"))
            Else
                objDemodataSchool.DemoTchMulticultural = CType(myparOutput("@p_DemoTchMulticultural"), Integer)
            End If

            If myparOutput("@p_DemoTchWhite") Is DBNull.Value Then
                objDemodataSchool.DemoTchWhite = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_DemoTchWhite"))
            Else
                objDemodataSchool.DemoTchWhite = CType(myparOutput("@p_DemoTchWhite"), Integer)
            End If

            If myparOutput("@p_DemoTchOther") Is DBNull.Value Then
                objDemodataSchool.DemoTchOther = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_DemoTchOther"))
            Else
                objDemodataSchool.DemoTchOther = CType(myparOutput("@p_DemoTchOther"), Integer)
            End If

            If myparOutput("@p_DemoTchTotalEnrollment") Is DBNull.Value Then
                objDemodataSchool.DemoTchTotalEnrollment = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_DemoTchTotalEnrollment"))
            Else
                objDemodataSchool.DemoTchTotalEnrollment = CType(myparOutput("@p_DemoTchTotalEnrollment"), Integer)
            End If

            If myparOutput("@p_DemoTchStudentsWithIEP") Is DBNull.Value Then
                objDemodataSchool.DemoTchStudentsWithIEP = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_DemoTchStudentsWithIEP"))
            Else
                objDemodataSchool.DemoTchStudentsWithIEP = CType(myparOutput("@p_DemoTchStudentsWithIEP"), Integer)
            End If

            If myparOutput("@p_DemoTchPercFreeRedcLunch") Is DBNull.Value Then
                objDemodataSchool.DemoTchPercFreeRedcLunch = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_DemoTchPercFreeRedcLunch"))
            Else
                objDemodataSchool.DemoTchPercFreeRedcLunch = CType(myparOutput("@p_DemoTchPercFreeRedcLunch"), Integer)
            End If

            If myparOutput("@p_DemoTchTitleOne") Is DBNull.Value Then
                objDemodataSchool.DemoTchTitleOne = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_DemoTchTitleOne"))
            Else
                objDemodataSchool.DemoTchTitleOne = CType(myparOutput("@p_DemoTchTitleOne"), Integer)
            End If

            If myparOutput("@p_DemoTchReadingFirst") Is DBNull.Value Then
                objDemodataSchool.DemoTchReadingFirst = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_DemoTchReadingFirst"))
            Else
                objDemodataSchool.DemoTchReadingFirst = CType(myparOutput("@p_DemoTchReadingFirst"), Integer)
            End If

            If myparOutput("@p_DemoTchProblemSolvModel") Is DBNull.Value Then
                objDemodataSchool.DemoTchProblemSolvModel = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_DemoTchProblemSolvModel"))
            Else
                objDemodataSchool.DemoTchProblemSolvModel = CType(myparOutput("@p_DemoTchProblemSolvModel"), Integer)
            End If

            If myparOutput("@p_DemoTchOtherInitiatives") Is DBNull.Value Then
                objDemodataSchool.DemoTchOtherInitiatives = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_DemoTchOtherInitiatives"))
            Else
                objDemodataSchool.DemoTchOtherInitiatives = CType(myparOutput("@p_DemoTchOtherInitiatives"), String)
            End If

            If myparOutput("@p_DemoTchAcademicSystems") Is DBNull.Value Then
                objDemodataSchool.DemoTchAcademicSystems = C21MIT.Util.DBNullHandler.DBNullToBlank(myparOutput("@p_DemoTchAcademicSystems"))
            Else
                objDemodataSchool.DemoTchAcademicSystems = CType(myparOutput("@p_DemoTchAcademicSystems"), String)
            End If

            'correct for main page
            'If myparOutput("@p_DemoTchBehaviorSystems") Is "" Then
            '    objDemodataSchool.DemoTchBehaviorSystems = C21MIT.Util.DBNullHandler.DBNullToBlank(myparOutput("@p_DemoTchBehaviorSystems"))
            'Else
            '    objDemodataSchool.DemoTchBehaviorSystems = CType(myparOutput("@p_DemoTchBehaviorSystems"), String)
            'End If

            If myparOutput("@p_DemoTchBehaviorSystems") Is DBNull.Value Then
                objDemodataSchool.DemoTchBehaviorSystems = C21MIT.Util.DBNullHandler.DBNullToBlank(myparOutput("@p_DemoTchBehaviorSystems"))
            Else
                objDemodataSchool.DemoTchBehaviorSystems = CType(myparOutput("@p_DemoTchBehaviorSystems"), String)
            End If

            If myparOutput("@p_DemoTchTotalInstStaff") Is DBNull.Value Then
                objDemodataSchool.DemoTchTotalInstStaff = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_DemoTchTotalInstStaff"))
            Else
                objDemodataSchool.DemoTchTotalInstStaff = CType(myparOutput("@p_DemoTchTotalInstStaff"), Integer)
            End If

            'correct for main page
            'If myparOutput("@p_DemoTchPercInstStaff") Is "" Then
            '    objDemodataSchool.DemoTchPercInstStaff = C21MIT.Util.DBNullHandler.DBNullToBlank(myparOutput("@p_DemoTchPercInstStaff"))
            'Else
            '    objDemodataSchool.DemoTchPercInstStaff = CType(myparOutput("@p_DemoTchPercInstStaff"), String)
            'End If

            If myparOutput("@p_DemoTchPercInstStaff") Is DBNull.Value Then
                objDemodataSchool.DemoTchPercInstStaff = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_DemoTchPercInstStaff"))
            Else
                objDemodataSchool.DemoTchPercInstStaff = CType(myparOutput("@p_DemoTchPercInstStaff"), Integer)
            End If

            If myparOutput("@p_DemoTchPercAdvDegree") Is DBNull.Value Then
                objDemodataSchool.DemoTchPercAdvDegree = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_DemoTchPercAdvDegree"))
            Else
                objDemodataSchool.DemoTchPercAdvDegree = CType(myparOutput("@p_DemoTchPercAdvDegree"), Integer)
            End If

            If myparOutput("@p_DemoTchPercOOFTeacher") Is DBNull.Value Then
                objDemodataSchool.DemoTchPercOOFTeacher = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_DemoTchPercOOFTeacher"))
            Else
                objDemodataSchool.DemoTchPercOOFTeacher = CType(myparOutput("@p_DemoTchPercOOFTeacher"), Integer)
            End If

            If myparOutput("@p_DemoTchTargBehIntv") Is DBNull.Value Then
                objDemodataSchool.DemoTchTargBehIntv = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_DemoTchTargBehIntv"))
            Else
                objDemodataSchool.DemoTchTargBehIntv = CType(myparOutput("@p_DemoTchTargBehIntv"), Integer)
            End If

            If myparOutput("@p_DemoTchIntvBEP") Is DBNull.Value Then
                objDemodataSchool.DemoTchIntvBEP = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_DemoTchIntvBEP"))
            Else
                objDemodataSchool.DemoTchIntvBEP = CType(myparOutput("@p_DemoTchIntvBEP"), Integer)
            End If

            'correct in main page
            'If myparOutput("@p_DemoTchIntvICPS") Is "" Then
            '    objDemodataSchool.DemoTchIntvICPS = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_DemoTchIntvICPS"))
            'Else
            '    objDemodataSchool.DemoTchIntvICPS = CType(myparOutput("@p_DemoTchIntvICPS"), Integer)
            'End If
            If myparOutput("@p_DemoTchIntvICPS") Is DBNull.Value Then
                objDemodataSchool.DemoTchIntvICPS = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_DemoTchIntvICPS"))
            Else
                objDemodataSchool.DemoTchIntvICPS = CType(myparOutput("@p_DemoTchIntvICPS"), Integer)
            End If

            If myparOutput("@p_DemoTchIntvSklStr") Is DBNull.Value Then
                objDemodataSchool.DemoTchIntvSklStr = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_DemoTchIntvSklStr"))
            Else
                objDemodataSchool.DemoTchIntvSklStr = CType(myparOutput("@p_DemoTchIntvSklStr"), Integer)
            End If

            If myparOutput("@p_DemoTchIntvPrep") Is DBNull.Value Then
                objDemodataSchool.DemoTchIntvPrep = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_DemoTchIntvPrep"))
            Else
                objDemodataSchool.DemoTchIntvPrep = CType(myparOutput("@p_DemoTchIntvPrep"), Integer)
            End If

            If myparOutput("@p_DemoTchIntvSTR") Is DBNull.Value Then
                objDemodataSchool.DemoTchIntvSTR = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_DemoTchIntvSTR"))
            Else
                objDemodataSchool.DemoTchIntvSTR = CType(myparOutput("@p_DemoTchIntvSTR"), Integer)
            End If

            If myparOutput("@p_DemoTchIntvSecStp") Is DBNull.Value Then
                objDemodataSchool.DemoTchIntvSecStp = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_DemoTchIntvSecStp"))
            Else
                objDemodataSchool.DemoTchIntvSecStp = CType(myparOutput("@p_DemoTchIntvSecStp"), Integer)
            End If

            If myparOutput("@p_DemoTchIntvSC") Is DBNull.Value Then
                objDemodataSchool.DemoTchIntvSC = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_DemoTchIntvSC"))
            Else
                objDemodataSchool.DemoTchIntvSC = CType(myparOutput("@p_DemoTchIntvSC"), Integer)
            End If

            If myparOutput("@p_DemoTchIntvOth") Is DBNull.Value Then
                objDemodataSchool.DemoTchIntvOth = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_DemoTchIntvOth"))
            Else
                objDemodataSchool.DemoTchIntvOth = CType(myparOutput("@p_DemoTchIntvOth"), Integer)
            End If

            If myparOutput("@p_DemoTchIntvOthDesc") Is DBNull.Value Then
                objDemodataSchool.DemoTchIntvOthDesc = C21MIT.Util.DBNullHandler.DBNullToBlank(myparOutput("@p_DemoTchIntvOthDesc"))
            Else
                objDemodataSchool.DemoTchIntvOthDesc = CType(myparOutput("@p_DemoTchIntvOthDesc"), String)
            End If

            If myparOutput("@p_DemoTchIndLvlPbs") Is DBNull.Value Then
                objDemodataSchool.DemoTchIndLvlPbs = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_DemoTchIndLvlPbs"))
            Else
                objDemodataSchool.DemoTchIndLvlPbs = CType(myparOutput("@p_DemoTchIndLvlPbs"), Integer)
            End If

            If myparOutput("@p_DemoTchPbsERASE") Is DBNull.Value Then
                objDemodataSchool.DemoTchPbsERASE = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_DemoTchPbsERASE"))
            Else
                objDemodataSchool.DemoTchPbsERASE = CType(myparOutput("@p_DemoTchPbsERASE"), Integer)
            End If

            If myparOutput("@p_DemoTchPbsPTR") Is DBNull.Value Then
                objDemodataSchool.DemoTchPbsPTR = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_DemoTchPbsPTR"))
            Else
                objDemodataSchool.DemoTchPbsPTR = CType(myparOutput("@p_DemoTchPbsPTR"), Integer)
            End If

            If myparOutput("@p_DemoTchPbsOth") Is DBNull.Value Then
                objDemodataSchool.DemoTchPbsOth = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_DemoTchPbsOth"))
            Else
                objDemodataSchool.DemoTchPbsOth = CType(myparOutput("@p_DemoTchPbsOth"), Integer)
            End If

            If myparOutput("@p_DemoTchPbsOthDesc") Is DBNull.Value Then
                objDemodataSchool.DemoTchPbsOthDesc = C21MIT.Util.DBNullHandler.DBNullToBlank(myparOutput("@p_DemoTchPbsOthDesc"))
            Else
                objDemodataSchool.DemoTchPbsOthDesc = CType(myparOutput("@p_DemoTchPbsOthDesc"), String)
            End If

            Return objDemodataSchool

        End Function
    End Class
#End Region
#End Region
End Namespace