Imports Microsoft.VisualBasic
Imports URDAL
Imports System.Data
Imports System.Data.SqlClient
Namespace C21MIT.PBSIS.DAL
#Region "District Reports"
    Public Class pbsdistreports
        '-------------------------------------------------------------------------------------------------------------------
        ' Function Name : fngetDistName  
        ' Created By : Aditi Deodhar
        ' Description : This function is used to get the district name based on a district id
        '-------------------------------------------------------------------------------------------------------------------
        Shared Function fngetDistName(ByVal distID As String) As C21MIT.PBSIS.BO.pbsschoolreport
            Dim oRequest As New URDALRequest
            Dim oFactory As URDALAbsDBFactory
            Dim oNonQuery As URDALNonQuery
            oFactory = New URDALSQLFactory

            Dim myparOutput As New Hashtable

            Dim objDistName As New C21MIT.PBSIS.BO.pbsschoolreport

            With oRequest
                .Command = "dbo.flpbs_dlr_getdistname"
                .CommandType = CommandType.StoredProcedure
            End With
            oRequest.AddParameter("@p_districtid", distID, URDALRequest.myDataType.dtString, 6, ParameterDirection.Input)
            oRequest.AddParameter("@p_districtname", , URDALRequest.myDataType.dtString, 75, ParameterDirection.Output)
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

            If myparOutput("@p_districtname") Is DBNull.Value Then
                objDistName.DistrictName = ""
            Else
                objDistName.DistrictName = C21MIT.Util.DBNullHandler.DBNullToBlank(CType(myparOutput("@p_districtname"), String))
            End If

            Return objDistName
        End Function
        '-------------------------------------------------------------------------------------------------------------------
        ' Function Name : fngetTierSuppActiSch  
        ' Created By : Aditi Deodhar
        ' Description : 
        '-------------------------------------------------------------------------------------------------------------------
        Shared Function fngetTierSuppActiSch(ByVal distId As String, ByVal SchoolYr As Integer) As C21MIT.PBSIS.BO.pbsmid_yr_dist_reports_main
            Dim oRequest As New URDALRequest
            Dim oFactory As URDALAbsDBFactory
            Dim oNonQuery As URDALNonQuery
            oFactory = New URDALSQLFactory

            Dim myparOutput As New Hashtable

            Dim objDistTerSupportActSch As New C21MIT.PBSIS.BO.pbsmid_yr_dist_reports_main

            With oRequest
                .Command = "dbo.flpbs_dlr_midyear_IndvTrgtDist"
                .CommandType = CommandType.StoredProcedure
            End With

            oRequest.AddParameter("@p_distid", distId, URDALRequest.myDataType.dtString, 6, ParameterDirection.Input)
            oRequest.AddParameter("@p_acadyear", SchoolYr, URDALRequest.myDataType.dtTinyInt, , ParameterDirection.Input)
            oRequest.AddParameter("@p_actschool", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_tgtbehaviour", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)
            oRequest.AddParameter("@p_indlevelpbs", , URDALRequest.myDataType.dtInteger, , ParameterDirection.Output)

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

            If myparOutput("@p_actschool") Is DBNull.Value Then
                objDistTerSupportActSch.SchUniPBSTier1 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_actschool"))
            Else
                objDistTerSupportActSch.SchUniPBSTier1 = CType(myparOutput("@p_actschool"), Integer)
            End If

            If myparOutput("@p_tgtbehaviour") Is DBNull.Value Then
                objDistTerSupportActSch.SchTargGroupTier2 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_tgtbehaviour"))
            Else
                objDistTerSupportActSch.SchTargGroupTier2 = CType(myparOutput("@p_tgtbehaviour"), Integer)
            End If

            If myparOutput("@p_indlevelpbs") Is DBNull.Value Then
                objDistTerSupportActSch.SchIndPBSTier3 = C21MIT.Util.DBNullHandler.DBNullToZeroSingle(myparOutput("@p_indlevelpbs"))
            Else
                objDistTerSupportActSch.SchIndPBSTier3 = CType(myparOutput("@p_indlevelpbs"), Integer)
            End If

            Return objDistTerSupportActSch
        End Function
    End Class
#End Region
#Region "District Navigation"
    Public Class pbsdisnavigate
        '-------------------------------------------------------------------------------------------------------------------
        ' Function Name : getyearmon  
        ' Created By : Aditi Deodhar
        ' Description : This function gets all the mid and end yr montoring data
        '-------------------------------------------------------------------------------------------------------------------
        Public Shared Function getyearmon(ByVal optId As String, ByVal distid As String, ByVal rptyr As Integer) As C21MIT.PBSIS.BO.pbsgridviewobj
            Dim objPBSDistrictMonResults As New BO.pbsgridviewobj
            Dim oRequest As New URDALRequest
            Dim oFactory As URDALAbsDBFactory
            Dim mydataset As New DataSet
            Dim myparOutput As New Hashtable
            oFactory = New URDALSQLFactory

            With oRequest
                If optId = "MidYearMon" Then
                    .Command = "dbo.flpbs_dist_midyrmonitor"
                ElseIf optId = "EndYearMon" Then
                    .Command = "dbo.flpbs_dist_endyrmonitor"
                End If
                .CommandType = CommandType.StoredProcedure
            End With


            oRequest.AddParameter("@p_distid", distid, URDALRequest.myDataType.dtString, 2, ParameterDirection.Input)
            oRequest.AddParameter("@p_acadyear", rptyr, URDALRequest.myDataType.dtTinyInt, , ParameterDirection.Input)
            oRequest.AddParameter("@p_districtname", , URDALRequest.myDataType.dtString, 75, ParameterDirection.Output)

            Try
                mydataset = oFactory.ExecuteDataSet(oRequest).ReturnedDataSet
                myparOutput = oRequest.URParOutputs
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
            If optId = "MidYearMon" Then
                objPBSDistrictMonResults.PBSGridviewNavObjectListobj = GetMidYrMonitoringList(mydataset)
                objPBSDistrictMonResults.PageTitle = "MID-YEAR MONITORING"
            ElseIf optId = "EndYearMon" Then
                objPBSDistrictMonResults.PBSGridviewNavObjectListobj = GetEndYrRMonitoringList(mydataset)
                objPBSDistrictMonResults.PageTitle = "END-YEAR MONITORING"
            End If

            If myparOutput("@p_districtname") Is DBNull.Value Then
                objPBSDistrictMonResults.DistrictName = C21MIT.Util.DBNullHandler.DBNullToBlank(CType(myparOutput("@p_districtname"), String))
            Else
                objPBSDistrictMonResults.DistrictName = CType(myparOutput("@p_districtname"), String)
            End If
            Return objPBSDistrictMonResults

        End Function

        '-------------------------------------------------------------------------------------------------------------------
        ' Function Name : GetEndYrRMonitoringList  
        ' Created By : Aditi Deodhar
        ' Description : This function is used to get end yr montoring list data
        '-------------------------------------------------------------------------------------------------------------------
        Public Shared Function GetEndYrRMonitoringList(ByVal myDS As DataSet) As C21MIT.PBSIS.BO.PBSNavObjectList
            Dim objdismidyrmonresultlist As New C21MIT.PBSIS.BO.PBSNavObjectList
            Dim myRow1 As DataRow
            Dim myRow2 As DataRow

            Dim I As Integer

            For Each myRow1 In myDS.Tables(0).Rows

                Dim myEndYrMonitoringobj1 As New C21MIT.PBSIS.BO.pbsnavigatelistobj
                myEndYrMonitoringobj1.SchoolId = C21MIT.Util.DBNullHandler.DBNullToBlank(myRow1.Item("SchoolId"))
                myEndYrMonitoringobj1.SchoolName = C21MIT.Util.DBNullHandler.DBNullToBlank(myRow1.Item("SchoolName"))

                If myRow1.Item("boqid").Equals(System.DBNull.Value) Then
                    myEndYrMonitoringobj1.HeaderText = "Benchmarks Of Quality"
                    myEndYrMonitoringobj1.NavigationText1 = "Pending Submission"
                    myEndYrMonitoringobj1.NavigationLink1 = ""
                    myEndYrMonitoringobj1.NavigationStatus1 = "False"
                Else : myEndYrMonitoringobj1.HeaderText = "Benchmarks Of Quality"
                    myEndYrMonitoringobj1.NavigationText1 = "Completed - View"
                    myEndYrMonitoringobj1.NavigationLink1 = C21MIT.PBSIS.BLL.pbsDistrctNavigate.lnkDistMonitor(5, myEndYrMonitoringobj1.SchoolId).NavigationLink 'C21MIT.Util.DBNullHandler.DBNullToBlank(myRow1.Item("IP_ID"))
                    myEndYrMonitoringobj1.NavigationStatus1 = "True"
                End If

                I = myDS.Tables(0).Rows.IndexOf(myRow1)

                '' For Column Two
                If myEndYrMonitoringobj1.SchoolId = myDS.Tables(1).Rows(I).Item("SchoolId") Then
                    If myDS.Tables(1).Rows(I).Item("odid").Equals(System.DBNull.Value) Then
                        myEndYrMonitoringobj1.HeaderText = "Outcome Data Summary"
                        myEndYrMonitoringobj1.NavigationText2 = "Pending Submission"
                        myEndYrMonitoringobj1.NavigationLink2 = ""
                        myEndYrMonitoringobj1.NavigationStatus2 = "False"
                    Else : myEndYrMonitoringobj1.HeaderText = "Outcome Data Summary"
                        myEndYrMonitoringobj1.NavigationText2 = "Completed - View"
                        myEndYrMonitoringobj1.NavigationLink2 = C21MIT.PBSIS.BLL.pbsDistrctNavigate.lnkDistMonitor(6, myEndYrMonitoringobj1.SchoolId).NavigationLink 'C21MIT.Util.DBNullHandler.DBNullToBlank(myRow1.Item("IP_ID"))
                        myEndYrMonitoringobj1.NavigationStatus2 = "True"
                    End If
                Else
                    For Each myRow2 In myDS.Tables(1).Rows
                        If myEndYrMonitoringobj1.SchoolId = myRow2.Item("SchoolId") Then
                            If myDS.Tables(1).Rows(I).Item("odid").Equals(System.DBNull.Value) Then
                                myEndYrMonitoringobj1.HeaderText = "Outcome Data Summary"
                                myEndYrMonitoringobj1.NavigationText2 = "Pending Submission"
                                myEndYrMonitoringobj1.NavigationLink2 = ""
                                myEndYrMonitoringobj1.NavigationStatus2 = "False"
                            Else : myEndYrMonitoringobj1.HeaderText = "Outcome Data Summary"
                                myEndYrMonitoringobj1.NavigationText2 = "Completed - View"
                                myEndYrMonitoringobj1.NavigationLink2 = C21MIT.PBSIS.BLL.pbsDistrctNavigate.lnkDistMonitor(6, myEndYrMonitoringobj1.SchoolId).NavigationLink 'C21MIT.Util.DBNullHandler.DBNullToBlank(myRow1.Item("IP_ID"))
                                myEndYrMonitoringobj1.NavigationStatus2 = "True"
                            End If
                            Exit For
                        End If
                    Next
                End If

                ''for column three
                If myEndYrMonitoringobj1.SchoolId = myDS.Tables(2).Rows(I).Item("SchoolId") Then
                    If myDS.Tables(2).Rows(I).Item("BAT_ID").Equals(System.DBNull.Value) Then
                        myEndYrMonitoringobj1.HeaderText = "BAT"
                        myEndYrMonitoringobj1.NavigationText3 = "Pending Submission"
                        myEndYrMonitoringobj1.NavigationLink3 = ""
                        myEndYrMonitoringobj1.NavigationStatus3 = "False"
                    Else : myEndYrMonitoringobj1.HeaderText = "BAT"
                        myEndYrMonitoringobj1.NavigationText3 = "Completed - View"
                        myEndYrMonitoringobj1.NavigationLink3 = C21MIT.PBSIS.BLL.pbsDistrctNavigate.lnkDistMonitor(23, myEndYrMonitoringobj1.SchoolId).NavigationLink 'C21MIT.Util.DBNullHandler.DBNullToBlank(myRow1.Item("IP_ID"))
                        myEndYrMonitoringobj1.NavigationStatus3 = "True"
                    End If
                Else
                    For Each myRow2 In myDS.Tables(2).Rows
                        If myEndYrMonitoringobj1.SchoolId = myRow2.Item("SchoolId") Then
                            If myDS.Tables(2).Rows(I).Item("BAT_ID").Equals(System.DBNull.Value) Then
                                myEndYrMonitoringobj1.HeaderText = "BAT"
                                myEndYrMonitoringobj1.NavigationText3 = "Pending Submission"
                                myEndYrMonitoringobj1.NavigationLink3 = ""
                                myEndYrMonitoringobj1.NavigationStatus3 = "False"
                            Else : myEndYrMonitoringobj1.HeaderText = "BAT"
                                myEndYrMonitoringobj1.NavigationText3 = "Completed - View"
                                myEndYrMonitoringobj1.NavigationLink3 = C21MIT.PBSIS.BLL.pbsDistrctNavigate.lnkDistMonitor(23, myEndYrMonitoringobj1.SchoolId).NavigationLink 'C21MIT.Util.DBNullHandler.DBNullToBlank(myRow1.Item("IP_ID"))
                                myEndYrMonitoringobj1.NavigationStatus3 = "True"
                            End If
                            Exit For
                        End If
                    Next
                End If

                If I = 0 Then
                Else
                    For I = 0 To 0
                        Dim myEndYrMonitoringobj2 As New C21MIT.PBSIS.BO.pbsnavigatelistobj
                        myEndYrMonitoringobj2.NavigationText2 = ""
                        myEndYrMonitoringobj2.NavigationLink2 = ""
                        myEndYrMonitoringobj2.NavigationStatus2 = ""
                        objdismidyrmonresultlist.Add(myEndYrMonitoringobj2)
                    Next
                End If
                objdismidyrmonresultlist.Add(myEndYrMonitoringobj1)
            Next ' Main Loop - Column One
            'Add row here
            'Add a row here
            Dim myEndYrMonitoringobj3 As New C21MIT.PBSIS.BO.pbsnavigatelistobj
            myEndYrMonitoringobj3.NavigationText2 = ""
            myEndYrMonitoringobj3.NavigationLink2 = ""
            myEndYrMonitoringobj3.NavigationStatus2 = ""
            objdismidyrmonresultlist.Add(myEndYrMonitoringobj3)

            Return objdismidyrmonresultlist
        End Function

        '-------------------------------------------------------------------------------------------------------------------
        ' Function Name : getmidyrmon  
        ' Created By : Aditi Deodhar
        ' Description : This function is used to get mid yr montoring data
        '-------------------------------------------------------------------------------------------------------------------
        Public Shared Function getmidyrmon(ByVal distid As String, ByVal rptyr As Integer) As C21MIT.PBSIS.BO.PBSNavObjectList

            Dim oRequest As New URDALRequest
            Dim oFactory As URDALAbsDBFactory
            Dim mydataset As New DataSet

            oFactory = New URDALSQLFactory

            With oRequest
                .Command = "dbo.flpbs_dist_midyrmonitor"
                .CommandType = CommandType.StoredProcedure
            End With
            oRequest.AddParameter("@p_distid", distid, URDALRequest.myDataType.dtString, 2, ParameterDirection.Input)
            oRequest.AddParameter("@p_acadyear", rptyr, URDALRequest.myDataType.dtTinyInt, , ParameterDirection.Input)
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
            Return GetMidYrMonitoringList(mydataset)
        End Function

        '-------------------------------------------------------------------------------------------------------------------
        ' Function Name : GetMidYrMonitoringList  
        ' Created By : Aditi Deodhar
        ' Description : This function is used to get mid yr montoring list data
        '-------------------------------------------------------------------------------------------------------------------
        Public Shared Function GetMidYrMonitoringList(ByVal myDS As DataSet) As C21MIT.PBSIS.BO.PBSNavObjectList
            Dim objdismidyrmonresultlist As New C21MIT.PBSIS.BO.PBSNavObjectList
            Dim myRow1 As DataRow
            Dim myRow2 As DataRow

            Dim I As Integer
            Dim numrows As Integer = 1
            For Each myRow1 In myDS.Tables(0).Rows

                Dim myMidYrMonitoringobj1 As New C21MIT.PBSIS.BO.pbsnavigatelistobj
                myMidYrMonitoringobj1.SchoolId = C21MIT.Util.DBNullHandler.DBNullToBlank(myRow1.Item("SchoolId"))
                myMidYrMonitoringobj1.SchoolName = C21MIT.Util.DBNullHandler.DBNullToBlank(myRow1.Item("SchoolName"))

                If myRow1.Item("IP_ID").Equals(System.DBNull.Value) Then
                    myMidYrMonitoringobj1.HeaderText1 = "PBS Implementation Checklist-Fall"
                    myMidYrMonitoringobj1.NavigationText1 = "Pending Submission"
                    myMidYrMonitoringobj1.NavigationLink1 = ""
                    myMidYrMonitoringobj1.NavigationStatus1 = "False"
                Else
                    myMidYrMonitoringobj1.HeaderText1 = "PBS Implementation Checklist-Fall"
                    myMidYrMonitoringobj1.NavigationText1 = "Completed - View"
                    myMidYrMonitoringobj1.NavigationLink1 = C21MIT.PBSIS.BLL.pbsDistrctNavigate.lnkDistMonitor(19, myMidYrMonitoringobj1.SchoolId).NavigationLink 'C21MIT.Util.DBNullHandler.DBNullToBlank(myRow1.Item("IP_ID"))
                    myMidYrMonitoringobj1.NavigationStatus1 = "True"

                End If

                I = myDS.Tables(0).Rows.IndexOf(myRow1)

                '' For Column Two ie.School Profile
                If myMidYrMonitoringobj1.SchoolId = myDS.Tables(2).Rows(I).Item("SchoolId") Then

                    If myDS.Tables(2).Rows(I).Item("DemoTchRecordID").Equals(System.DBNull.Value) Then
                        myMidYrMonitoringobj1.HeaderText2 = "School Profile"
                        myMidYrMonitoringobj1.NavigationText2 = "Pending Submission"
                        ' myresearchobj.NavigationLink2 = ""
                        myMidYrMonitoringobj1.NavigationStatus2 = "False"
                    Else
                        myMidYrMonitoringobj1.HeaderText2 = "School Profile"
                        myMidYrMonitoringobj1.NavigationText2 = "Completed - View"
                        myMidYrMonitoringobj1.NavigationLink2 = C21MIT.PBSIS.BLL.pbsDistrctNavigate.lnkDistMonitor(2, myMidYrMonitoringobj1.SchoolId).NavigationLink 'C21MIT.Util.DBNullHandler.DBNullToBlank(myRow1.Item("IP_ID"))
                        myMidYrMonitoringobj1.NavigationStatus2 = "True"
                    End If
                Else
                    For Each myRow2 In myDS.Tables(2).Rows
                        If myMidYrMonitoringobj1.SchoolId = myRow2.Item("SchoolId") Then
                            If myDS.Tables(2).Rows(I).Item("DemoTchRecordID").Equals(System.DBNull.Value) Then
                                myMidYrMonitoringobj1.HeaderText2 = "School Profile"
                                myMidYrMonitoringobj1.NavigationText2 = "Pending Submission"
                                myMidYrMonitoringobj1.NavigationLink2 = ""
                                myMidYrMonitoringobj1.NavigationStatus2 = "False"
                            Else
                                myMidYrMonitoringobj1.HeaderText2 = "School Profile"
                                myMidYrMonitoringobj1.NavigationText2 = "Completed - View"
                                myMidYrMonitoringobj1.NavigationLink2 = C21MIT.PBSIS.BLL.pbsDistrctNavigate.lnkDistMonitor(2, myMidYrMonitoringobj1.SchoolId).NavigationLink 'C21MIT.Util.DBNullHandler.DBNullToBlank(myRow1.Item("IP_ID"))
                                myMidYrMonitoringobj1.NavigationStatus2 = "True"
                            End If
                            Exit For
                        End If
                    Next
                End If
                'For Column 3 - PBS imp - Fall

                If myMidYrMonitoringobj1.SchoolId = myDS.Tables(1).Rows(I).Item("SchoolId") Then

                    If myDS.Tables(1).Rows(I).Item("IP_ID").Equals(System.DBNull.Value) Then
                        myMidYrMonitoringobj1.HeaderText3 = "MID-YEAR MONITORING "
                        myMidYrMonitoringobj1.NavigationText3 = "Pending Submission"
                        myMidYrMonitoringobj1.NavigationLink3 = ""
                        myMidYrMonitoringobj1.NavigationStatus3 = "False"
                    Else
                        myMidYrMonitoringobj1.HeaderText3 = "MID-YEAR MONITORING "
                        myMidYrMonitoringobj1.NavigationText3 = "Completed - View"
                        myMidYrMonitoringobj1.NavigationLink3 = C21MIT.PBSIS.BLL.pbsDistrctNavigate.lnkDistMonitor(20, myMidYrMonitoringobj1.SchoolId).NavigationLink 'C21MIT.Util.DBNullHandler.DBNullToBlank(myRow1.Item("IP_ID"))
                        myMidYrMonitoringobj1.NavigationStatus3 = "True"
                    End If
                Else : For Each myRow2 In myDS.Tables(1).Rows
                        If myMidYrMonitoringobj1.SchoolId = myRow2.Item("SchoolId") Then
                            If myDS.Tables(1).Rows(I).Item("IP_ID").Equals(System.DBNull.Value) Then
                                myMidYrMonitoringobj1.HeaderText3 = "MID-YEAR MONITORING "
                                myMidYrMonitoringobj1.NavigationText3 = "Pending Submission"
                                myMidYrMonitoringobj1.NavigationLink3 = ""
                                myMidYrMonitoringobj1.NavigationStatus3 = "False"
                            Else
                                myMidYrMonitoringobj1.HeaderText3 = "MID-YEAR MONITORING "
                                myMidYrMonitoringobj1.NavigationText3 = "Completed - View"
                                myMidYrMonitoringobj1.NavigationLink3 = C21MIT.PBSIS.BLL.pbsDistrctNavigate.lnkDistMonitor(20, myMidYrMonitoringobj1.SchoolId).NavigationLink 'C21MIT.Util.DBNullHandler.DBNullToBlank(myRow1.Item("IP_ID"))
                                myMidYrMonitoringobj1.NavigationStatus3 = "True"

                            End If
                            Exit For
                        End If
                    Next
                End If
                If I = 0 Then
                Else
                    For I = 0 To 0
                        Dim myMidYrMonitoringobj2 As New C21MIT.PBSIS.BO.pbsnavigatelistobj
                        myMidYrMonitoringobj2.NavigationText2 = ""
                        myMidYrMonitoringobj2.NavigationLink2 = ""
                        myMidYrMonitoringobj2.NavigationStatus2 = ""
                        objdismidyrmonresultlist.Add(myMidYrMonitoringobj2)
                    Next
                End If
                objdismidyrmonresultlist.Add(myMidYrMonitoringobj1)
            Next ' Main Loop - Column One
            'Add a row here
            Dim myMidYrMonitoringobj3 As New C21MIT.PBSIS.BO.pbsnavigatelistobj
            myMidYrMonitoringobj3.NavigationText2 = ""
            myMidYrMonitoringobj3.NavigationLink2 = ""
            myMidYrMonitoringobj3.NavigationStatus2 = ""
            objdismidyrmonresultlist.Add(myMidYrMonitoringobj3)

            Return objdismidyrmonresultlist
        End Function

        '-------------------------------------------------------------------------------------------------------------------
        ' Function Name : getschoollevelreports  
        ' Created By : Aditi Deodhar
        ' Description : This function is used to get all school level reports
        '-------------------------------------------------------------------------------------------------------------------
        Public Shared Function getschoollevelreports(ByVal optId As String, ByVal distid As String) As C21MIT.PBSIS.BO.pbsgridviewobj
            Dim objPBSSchLevelReports As New BO.pbsgridviewobj
            Dim oRequest As New URDALRequest
            Dim oFactory As URDALAbsDBFactory
            Dim mydataset As New DataSet
            Dim myparOutput As New Hashtable
            oFactory = New URDALSQLFactory

            With oRequest
                .Command = "dbo.flpbs_dist_endyrslr"
                .CommandType = CommandType.StoredProcedure
            End With

            oRequest.AddParameter("@p_distid", distid, URDALRequest.myDataType.dtString, 2, ParameterDirection.Input)
            oRequest.AddParameter("@p_districtname", , URDALRequest.myDataType.dtString, 75, ParameterDirection.Output)

            Try
                mydataset = oFactory.ExecuteDataSet(oRequest).ReturnedDataSet
                myparOutput = oRequest.URParOutputs
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

            If optId = "MidYearSLR" Then
                objPBSSchLevelReports.PBSGridviewNavObjectListobj = GetMidYrSchoolLevelList(mydataset)
                objPBSSchLevelReports.PageTitle = "MID YEAR SCHOOL-LEVEL REPORTS"
            ElseIf optId = "EndYearSLR" Then
                objPBSSchLevelReports.PBSGridviewNavObjectListobj = GetEndYrSchoolLevelList(mydataset)
                objPBSSchLevelReports.PageTitle = "END YEAR SCHOOL-LEVEL REPORTS"
            End If

            If myparOutput("@p_districtname") Is DBNull.Value Then
                objPBSSchLevelReports.DistrictName = C21MIT.Util.DBNullHandler.DBNullToBlank(CType(myparOutput("@p_districtname"), String))
            Else
                objPBSSchLevelReports.DistrictName = CType(myparOutput("@p_districtname"), String)
            End If
            Return objPBSSchLevelReports

        End Function

        '-------------------------------------------------------------------------------------------------------------------
        ' Function Name : GetMidYrSchoolLevelList  
        ' Created By : Aditi Deodhar
        ' Description : This function is used to get Mid Yr School Level List 
        '-------------------------------------------------------------------------------------------------------------------
        Public Shared Function GetMidYrSchoolLevelList(ByVal myDS As DataSet) As C21MIT.PBSIS.BO.PBSNavObjectList
            Dim objPBSSchLevelReportsList As New C21MIT.PBSIS.BO.PBSNavObjectList
            Dim myRow1 As DataRow

            Dim I As Integer

            For Each myRow1 In myDS.Tables(0).Rows
                Dim myMidYrSchoolLevelobj1 As New C21MIT.PBSIS.BO.pbsnavigatelistobj
                myMidYrSchoolLevelobj1.SchoolId = C21MIT.Util.DBNullHandler.DBNullToBlank(myRow1.Item("SchoolId"))
                myMidYrSchoolLevelobj1.SchoolName = C21MIT.Util.DBNullHandler.DBNullToBlank(myRow1.Item("SchoolName"))

                myMidYrSchoolLevelobj1.NavigationText1 = "PIC Implementation Level"
                myMidYrSchoolLevelobj1.NavigationLink1 = C21MIT.PBSIS.BLL.pbsDistrctNavigate.lnktoMidYrSLReports("14_0", C21MIT.PBSIS.BLL.pbsencryption.getEncryptedQString(myMidYrSchoolLevelobj1.SchoolId)).NavigationLink
                myMidYrSchoolLevelobj1.NavigationStatus1 = "False"

                myMidYrSchoolLevelobj1.NavigationText2 = "PIC Tier1 Critical Element"
                myMidYrSchoolLevelobj1.NavigationLink2 = C21MIT.PBSIS.BLL.pbsDistrctNavigate.lnktoMidYrSLReports("13_0", C21MIT.PBSIS.BLL.pbsencryption.getEncryptedQString(myMidYrSchoolLevelobj1.SchoolId)).NavigationLink
                myMidYrSchoolLevelobj1.NavigationStatus2 = "False"

                I = myDS.Tables(0).Rows.IndexOf(myRow1)
                If I = 0 Then
                Else
                    For I = 0 To 0
                        Dim myMidYrSchoolLevelobj2 As New C21MIT.PBSIS.BO.pbsnavigatelistobj
                        myMidYrSchoolLevelobj2.NavigationText2 = ""
                        myMidYrSchoolLevelobj2.NavigationLink2 = ""
                        myMidYrSchoolLevelobj2.NavigationStatus2 = ""
                        objPBSSchLevelReportsList.Add(myMidYrSchoolLevelobj2)
                    Next
                End If
                objPBSSchLevelReportsList.Add(myMidYrSchoolLevelobj1)
            Next ' Main Loop - Column One
            'Add row here
            Dim myMidYrSchoolLevelobj3 As New C21MIT.PBSIS.BO.pbsnavigatelistobj
            myMidYrSchoolLevelobj3.NavigationText2 = ""
            myMidYrSchoolLevelobj3.NavigationLink2 = ""
            myMidYrSchoolLevelobj3.NavigationStatus2 = ""
            objPBSSchLevelReportsList.Add(myMidYrSchoolLevelobj3)
            Return objPBSSchLevelReportsList
        End Function

        '-------------------------------------------------------------------------------------------------------------------
        ' Function Name : GetEndYrSchoolLevelList  
        ' Created By : Aditi Deodhar
        ' Description : This function is used to get End Yr School Level List 
        '-------------------------------------------------------------------------------------------------------------------
        Public Shared Function GetEndYrSchoolLevelList(ByVal myDS As DataSet) As C21MIT.PBSIS.BO.PBSNavObjectList
            Dim objPBSSchLevelReportsList As New C21MIT.PBSIS.BO.PBSNavObjectList
            Dim myRow1 As DataRow

            Dim I As Integer

            For Each myRow1 In myDS.Tables(0).Rows
                Dim myEndYrSchoolLevelobj1 As New C21MIT.PBSIS.BO.pbsnavigatelistobj
                myEndYrSchoolLevelobj1.SchoolId = C21MIT.Util.DBNullHandler.DBNullToBlank(myRow1.Item("SchoolId"))
                myEndYrSchoolLevelobj1.SchoolName = C21MIT.Util.DBNullHandler.DBNullToBlank(myRow1.Item("SchoolName"))

                myEndYrSchoolLevelobj1.NavigationText1 = "ODR"
                myEndYrSchoolLevelobj1.NavigationLink1 = C21MIT.PBSIS.BLL.pbsDistrctNavigate.lnktoCharts("7_0", C21MIT.PBSIS.BLL.pbsencryption.getEncryptedQString(myEndYrSchoolLevelobj1.SchoolId)).NavigationLink
                myEndYrSchoolLevelobj1.NavigationStatus1 = "False"

                myEndYrSchoolLevelobj1.NavigationText2 = "ODR/100"
                myEndYrSchoolLevelobj1.NavigationLink2 = C21MIT.PBSIS.BLL.pbsDistrctNavigate.lnktoCharts("8_0", C21MIT.PBSIS.BLL.pbsencryption.getEncryptedQString(myEndYrSchoolLevelobj1.SchoolId)).NavigationLink
                myEndYrSchoolLevelobj1.NavigationStatus2 = "False"

                myEndYrSchoolLevelobj1.NavigationText3 = "ISS/OSS"
                myEndYrSchoolLevelobj1.NavigationLink3 = C21MIT.PBSIS.BLL.pbsDistrctNavigate.lnktoCharts("9_0", C21MIT.PBSIS.BLL.pbsencryption.getEncryptedQString(myEndYrSchoolLevelobj1.SchoolId)).NavigationLink
                myEndYrSchoolLevelobj1.NavigationStatus3 = "False"

                myEndYrSchoolLevelobj1.NavigationText4 = "ISS/OSS/100"
                myEndYrSchoolLevelobj1.NavigationLink4 = C21MIT.PBSIS.BLL.pbsDistrctNavigate.lnktoCharts("10_0", C21MIT.PBSIS.BLL.pbsencryption.getEncryptedQString(myEndYrSchoolLevelobj1.SchoolId)).NavigationLink
                myEndYrSchoolLevelobj1.NavigationStatus4 = "False"

                myEndYrSchoolLevelobj1.NavigationText5 = "Attend."
                myEndYrSchoolLevelobj1.NavigationLink5 = C21MIT.PBSIS.BLL.pbsDistrctNavigate.lnktoCharts("11_0", C21MIT.PBSIS.BLL.pbsencryption.getEncryptedQString(myEndYrSchoolLevelobj1.SchoolId)).NavigationLink
                myEndYrSchoolLevelobj1.NavigationStatus5 = "False"

                myEndYrSchoolLevelobj1.NavigationText6 = "BoQ."
                myEndYrSchoolLevelobj1.NavigationLink6 = C21MIT.PBSIS.BLL.pbsDistrctNavigate.lnktoCharts("12_0", C21MIT.PBSIS.BLL.pbsencryption.getEncryptedQString(myEndYrSchoolLevelobj1.SchoolId)).NavigationLink
                myEndYrSchoolLevelobj1.NavigationStatus6 = "False"

                myEndYrSchoolLevelobj1.NavigationText7 = "BAT. Subsection"
                myEndYrSchoolLevelobj1.NavigationLink7 = C21MIT.PBSIS.BLL.pbsDistrctNavigate.lnktoCharts("42_0", C21MIT.PBSIS.BLL.pbsencryption.getEncryptedQString(myEndYrSchoolLevelobj1.SchoolId)).NavigationLink
                myEndYrSchoolLevelobj1.NavigationStatus7 = "False"

                myEndYrSchoolLevelobj1.NavigationText8 = "BAT. Summary"
                myEndYrSchoolLevelobj1.NavigationLink8 = C21MIT.PBSIS.BLL.pbsDistrctNavigate.lnktoCharts("43_0", C21MIT.PBSIS.BLL.pbsencryption.getEncryptedQString(myEndYrSchoolLevelobj1.SchoolId)).NavigationLink
                myEndYrSchoolLevelobj1.NavigationStatus8 = "False"

                I = myDS.Tables(0).Rows.IndexOf(myRow1)
                If I = 0 Then
                Else
                    For I = 0 To 0
                        Dim myEndYrSchoolLevelobj2 As New C21MIT.PBSIS.BO.pbsnavigatelistobj
                        myEndYrSchoolLevelobj2.NavigationText2 = ""
                        myEndYrSchoolLevelobj2.NavigationLink2 = ""
                        myEndYrSchoolLevelobj2.NavigationStatus2 = ""
                        objPBSSchLevelReportsList.Add(myEndYrSchoolLevelobj2)
                    Next
                End If
                objPBSSchLevelReportsList.Add(myEndYrSchoolLevelobj1)
            Next ' Main Loop - Column One
            'Add row here
            Dim myEndYrSchoolLevelobj3 As New C21MIT.PBSIS.BO.pbsnavigatelistobj
            myEndYrSchoolLevelobj3.NavigationText2 = ""
            myEndYrSchoolLevelobj3.NavigationLink2 = ""
            myEndYrSchoolLevelobj3.NavigationStatus2 = ""
            objPBSSchLevelReportsList.Add(myEndYrSchoolLevelobj3)

            Return objPBSSchLevelReportsList
        End Function
    End Class
#End Region
End Namespace