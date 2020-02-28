Imports Microsoft.VisualBasic
Imports URDAL
Imports System.Data
Imports System.Data.SqlClient
Imports C21MIT
Namespace C21MIT.PBSIS.DAL
#Region "MID YEAR DISTRICT LEVEL REPORTS"
    Public Class midyrdistlevelreports
#Region "PIC - Tier 1 Critical Elements (Chart id - 20_0)"
        '-------------------------------------------------------------------------------------------------------------------
        ' Function Name : fngtTier1ImplForAllSch  
        ' Created By : Aditi Deodhar
        ' Created Dt : Apr 29,2010
        ' Last Updated Dt : Apr 29,2010
        ' Description : PIC - Tier 1 Critical Elements
        '-------------------------------------------------------------------------------------------------------------------
        Shared Function fngtTier1ImplForAllSch(ByVal schYr As Integer, ByVal distid As String, ByVal type As String) As String()
            Dim oRequest As New URDALRequest
            Dim oFactory As URDALAbsDBFactory
            Dim myDataset As New DataSet

            Dim myChart As New C21MIT.PBSIS.BO.ChartInfoset

            oFactory = New URDALSQLFactory

            With oRequest
                .Command = "dbo.flpbs_midyear_picDistImplChklistTr1"
                .CommandType = CommandType.StoredProcedure
            End With

            'Input data
            oRequest.AddParameter("@p_schoolYear", schYr, URDALRequest.myDataType.dtTinyInt, , ParameterDirection.Input)
            oRequest.AddParameter("@p_schooldistrictID", distid, URDALRequest.myDataType.dtChar, 2, ParameterDirection.Input)


            Try
                myDataset = oFactory.ExecuteDataSet(oRequest).ReturnedDataSet

                If Not IsNothing(oRequest.Exception) Then
                    Throw New ApplicationException("sqlexception", oRequest.Exception)
                End If

            Catch ex As Exception
                Dim objerrLog As New MITErrorHandling.MITErrorHandling("Exception in fngtImplLevelCat : " & ex.Message)
                objerrLog.logError()
                System.Web.HttpContext.Current.Response.Redirect("~/users/smessages.aspx?qModule=TechErr", False)

            Finally
                oFactory.ConDispose()
            End Try

            Dim I As Integer
            Dim arrChartData1(5) As String
            If type = "data" Then
                If myDataset.Tables(0).Rows.Count = 0 Then
                Else
                    For I = 0 To myDataset.Tables(0).Rows.Count - 1
                        arrChartData1(I) = Int(myDataset.Tables(0).Rows(I)(3).ToString) & _
                              "," & Int(Val(myDataset.Tables(0).Rows(I)(4).ToString)) & "," & Int(Val(myDataset.Tables(0).Rows(I)(5).ToString)) & _
                                  "," & Int(Val(myDataset.Tables(0).Rows(I)(6).ToString)) & "," & Int(Val(myDataset.Tables(0).Rows(I)(7).ToString)) & _
                                  "," & Int(Val(myDataset.Tables(0).Rows(I)(8).ToString)) & "," & Int(Val(myDataset.Tables(0).Rows(I)(9).ToString)) & _
                                  "," & Int(Val(myDataset.Tables(0).Rows(I)(10).ToString))

                        myChart.ChartData = arrChartData1
                    Next
                End If
            ElseIf type = "legend" Then
                If myDataset.Tables(0).Rows.Count = 0 Then
                Else
                    For I = 0 To myDataset.Tables(0).Rows.Count - 1

                        If Not IsDBNull(myDataset.Tables(0).Rows(I)(2).ToString) Then
                            arrChartData1(I) = myDataset.Tables(0).Rows(I)(2).ToString
                            myChart.ChartData = arrChartData1
                        End If

                    Next
                End If

            End If
            Return myChart.ChartData
        End Function
#End Region
#Region "PIC - Implementation Level (Chart id - 19_0)"
        '-------------------------------------------------------------------------------------------------------------------
        ' Function Name : fngtImplLevelCat  
        ' Created By : Aditi Deodhar
        ' Created Dt : Apr 28,2010
        ' Last Updated Dt : Apr 28,2010
        ' Description : PIC - Implementation Level
        '-------------------------------------------------------------------------------------------------------------------
        Shared Function fngtImplLevelCat(ByVal schYr As Integer, ByVal distid As String, ByVal type As String) As String()
            Dim oRequest As New URDALRequest
            Dim oFactory As URDALAbsDBFactory
            Dim myDataset As New DataSet

            Dim myChart As New C21MIT.PBSIS.BO.ChartInfoset

            oFactory = New URDALSQLFactory

            With oRequest
                .Command = "dbo.flpbs_midyear_picDistImplChklistTr1to3"
                .CommandType = CommandType.StoredProcedure
            End With

            'Input data
            oRequest.AddParameter("@p_schoolYear", schYr, URDALRequest.myDataType.dtTinyInt, , ParameterDirection.Input)
            oRequest.AddParameter("@p_schooldistrictID", distid, URDALRequest.myDataType.dtChar, 2, ParameterDirection.Input)


            Try
                myDataset = oFactory.ExecuteDataSet(oRequest).ReturnedDataSet

                If Not IsNothing(oRequest.Exception) Then
                    Throw New ApplicationException("sqlexception", oRequest.Exception)
                End If

            Catch ex As Exception
                Dim objerrLog As New MITErrorHandling.MITErrorHandling("Exception in fngtImplLevelCat : " & ex.Message)
                objerrLog.logError()
                System.Web.HttpContext.Current.Response.Redirect("~/users/smessages.aspx?qModule=TechErr", False)

            Finally
                oFactory.ConDispose()
            End Try

            Dim I As Integer
            Dim arrChartData1(5) As String
            If type = "data" Then
                If myDataset.Tables(0).Rows.Count = 0 Then
                Else
                    For I = 0 To myDataset.Tables(0).Rows.Count - 1
                        arrChartData1(I) = Int(myDataset.Tables(0).Rows(I)(3).ToString) & _
                              "," & Int(Val(myDataset.Tables(0).Rows(I)(4).ToString)) & "," & Int(Val(myDataset.Tables(0).Rows(I)(5).ToString)) & _
                                  "," & Int(Val(myDataset.Tables(0).Rows(I)(6).ToString)) & "," & Int(Val(myDataset.Tables(0).Rows(I)(7).ToString)) & _
                                  "," & Int(Val(myDataset.Tables(0).Rows(I)(8).ToString))

                        myChart.ChartData = arrChartData1
                    Next
                End If
            ElseIf type = "legend" Then
                If myDataset.Tables(0).Rows.Count = 0 Then
                Else
                    For I = 0 To myDataset.Tables(0).Rows.Count - 1
                        If Not IsDBNull(myDataset.Tables(0).Rows(I)(2).ToString) Then
                            arrChartData1(I) = myDataset.Tables(0).Rows(I)(2).ToString
                            myChart.ChartData = arrChartData1
                        End If

                    Next
                End If

            End If

            Return myChart.ChartData
        End Function
#End Region
#Region "PIC - Implementation Level (Grouped by School Type) (Chart id - 21_0 - 21_5)"
        '-------------------------------------------------------------------------------------------------------------------
        ' Function Name : fngtImplLevelCat  
        ' Created By : Aditi Deodhar
        ' Created Dt : Apr 29,2010
        ' Last Updated Dt : Apr 29,2010
        ' Description : PIC - Implementation Level (Grouped by School Type)
        '-------------------------------------------------------------------------------------------------------------------
        Shared Function fngtAvgPICImplLeCat(ByVal schYr As Integer, ByVal distid As String, ByVal schType As Integer, ByVal type As String) As String()
            Dim oRequest As New URDALRequest
            Dim oFactory As URDALAbsDBFactory
            Dim myDataset As New DataSet

            Dim myChart As New C21MIT.PBSIS.BO.ChartInfoset

            oFactory = New URDALSQLFactory

            With oRequest
                .Command = "dbo.flpbs_midyear_picDistImplChklistTr1to3byType"
                .CommandType = CommandType.StoredProcedure
            End With

            'Input data
            oRequest.AddParameter("@p_schoolYear", schYr, URDALRequest.myDataType.dtTinyInt, , ParameterDirection.Input)
            oRequest.AddParameter("@p_schooldistrictID", distid, URDALRequest.myDataType.dtChar, 2, ParameterDirection.Input)
            oRequest.AddParameter("@p_schooltype", schType, URDALRequest.myDataType.dtChar, 2, ParameterDirection.Input)

            Try
                myDataset = oFactory.ExecuteDataSet(oRequest).ReturnedDataSet

                If Not IsNothing(oRequest.Exception) Then
                    Throw New ApplicationException("sqlexception", oRequest.Exception)
                End If

            Catch ex As Exception
                Dim objerrLog As New MITErrorHandling.MITErrorHandling("Exception in fngtImplLevelCat : " & ex.Message)
                objerrLog.logError()
                System.Web.HttpContext.Current.Response.Redirect("~/users/smessages.aspx?qModule=TechErr", False)

            Finally
                oFactory.ConDispose()
            End Try

            Dim I As Integer
            Dim arrChartData1(5) As String
            If type = "data" Then
                If myDataset.Tables(0).Rows.Count = 0 Then
                Else
                    For I = 0 To myDataset.Tables(0).Rows.Count - 1
                        arrChartData1(I) = Int(Val(myDataset.Tables(0).Rows(I)(4).ToString)) & "," & Int(Val(myDataset.Tables(0).Rows(I)(5).ToString)) & _
                                  "," & Int(Val(myDataset.Tables(0).Rows(I)(6).ToString)) & "," & Int(Val(myDataset.Tables(0).Rows(I)(7).ToString)) & _
                                  "," & Int(Val(myDataset.Tables(0).Rows(I)(8).ToString)) & "," & Int(Val(myDataset.Tables(0).Rows(I)(9).ToString))

                        myChart.ChartData = arrChartData1
                    Next
                End If
            ElseIf type = "legend" Then
                If myDataset.Tables(0).Rows.Count = 0 Then
                Else
                    For I = 0 To myDataset.Tables(0).Rows.Count - 1
                        arrChartData1(I) = C21MIT.PBSIS.BLL.pbsschoolyeardesc.getschoolyeardesc(Int(Val(myDataset.Tables(0).Rows(I)(3).ToString)))

                        myChart.ChartData = arrChartData1
                    Next
                End If

            End If
            Return myChart.ChartData
        End Function
#End Region
#Region "Tier 1 Critical Elements (Grouped by School Type) (Chart id - 22_0 - 22_5)"
        '-------------------------------------------------------------------------------------------------------------------
        ' Function Name : fngtpicDistImplChklistTr1byType  
        ' Created By : Aditi Deodhar
        ' Created Dt : Apr 26,2010
        ' Last Updated Dt : Apr 26,2010
        ' Description : Tier 1 Critical Elements (Grouped by School Type)
        '-------------------------------------------------------------------------------------------------------------------
        Shared Function fngtpicDistImplChklistTr1byType(ByVal schYr As Integer, ByVal distid As String, ByVal schType As Integer, ByVal type As String) As String()
            Dim oRequest As New URDALRequest
            Dim oFactory As URDALAbsDBFactory
            Dim myDataset As New DataSet

            Dim myChart As New C21MIT.PBSIS.BO.ChartInfoset
            oFactory = New URDALSQLFactory

            With oRequest
                .Command = "dbo.flpbs_midyear_picDistImplChklistTr1byType"
                .CommandType = CommandType.StoredProcedure
            End With

            'Input data
            oRequest.AddParameter("@p_schoolYear", schYr, URDALRequest.myDataType.dtTinyInt, , ParameterDirection.Input)
            oRequest.AddParameter("@p_schooldistrictID", distid, URDALRequest.myDataType.dtChar, 2, ParameterDirection.Input)
            oRequest.AddParameter("@p_schooltype", schType, URDALRequest.myDataType.dtChar, 2, ParameterDirection.Input)

            Try
                myDataset = oFactory.ExecuteDataSet(oRequest).ReturnedDataSet

                If Not IsNothing(oRequest.Exception) Then
                    Throw New ApplicationException("sqlexception", oRequest.Exception)
                End If
            Catch ex As Exception
                Dim objerrLog As New MITErrorHandling.MITErrorHandling("Exception in fngtpicDistImplChklistTr1byType: " & ex.Message)
                objerrLog.logError()
                System.Web.HttpContext.Current.Response.Redirect("~/users/smessages.aspx?qModule=TechErr", False)

            Finally
                oFactory.ConDispose()
            End Try

            Dim I As Integer
            Dim arrChartData1(5) As String
            If type = "data" Then
                If myDataset.Tables(0).Rows.Count = 0 Then
                Else
                    For I = 0 To myDataset.Tables(0).Rows.Count - 1
                        arrChartData1(I) = Int(Val(myDataset.Tables(0).Rows(I)(3).ToString)) & "," & Int(Val(myDataset.Tables(0).Rows(I)(4).ToString)) & _
                              "," & Int(Val(myDataset.Tables(0).Rows(I)(5).ToString)) & "," & Int(Val(myDataset.Tables(0).Rows(I)(6).ToString)) & _
                                  "," & Int(Val(myDataset.Tables(0).Rows(I)(7).ToString)) & "," & Int(Val(myDataset.Tables(0).Rows(I)(8).ToString)) & _
                                  "," & Int(Val(myDataset.Tables(0).Rows(I)(9).ToString)) & "," & Int(Val(myDataset.Tables(0).Rows(I)(10).ToString))

                        myChart.ChartData = arrChartData1

                    Next
                End If
            ElseIf type = "legend" Then
                If myDataset.Tables(0).Rows.Count = 0 Then
                Else
                    For I = 0 To myDataset.Tables(0).Rows.Count - 1
                        arrChartData1(I) = C21MIT.PBSIS.BLL.pbsschoolyeardesc.getschoolyeardesc(Int(Val(myDataset.Tables(0).Rows(I)(2).ToString)))

                        myChart.ChartData = arrChartData1
                    Next
                End If

            End If
            Return myChart.ChartData
        End Function
#End Region
    End Class
#End Region
#Region "MID YEAR SCHOOL LOGIN REPORTS"
    Public Class midyrschloginreports
#Region "School Login - MID YEAR REPORTS"
#Region "PIC -  Implementation Level (Chart id - 14_0)"
        ''-------------------------------------------------------------------------------------------------------------------
        '' Function Name : fngtMidYrPICImplLevel  
        '' Created By : Aditi Deodhar
        '' Created Dt : May 05,2010
        '' Last Updated Dt : May 05,2010
        '' Description : PIC -  Implementation Level 
        '-------------------------------------------------------------------------------------------------------------------
        Shared Function fngtMidYrPICImplLevel(ByVal schid As String, ByVal schYr As Integer, ByVal type As String) As String()
            Dim oRequest As New URDALRequest
            Dim oFactory As URDALAbsDBFactory
            Dim myDataset As New DataSet

            Dim myChart As New C21MIT.PBSIS.BO.ChartInfoset

            oFactory = New URDALSQLFactory

            With oRequest
                .Command = "dbo.flpbs_slr_midyear_schpicscore"
                .CommandType = CommandType.StoredProcedure
            End With

            'Input data
            oRequest.AddParameter("@p_schoolid", schid, URDALRequest.myDataType.dtChar, 6, ParameterDirection.Input)
            oRequest.AddParameter("@p_SchoolYear", schYr, URDALRequest.myDataType.dtTinyInt, , ParameterDirection.Input)

            Try
                myDataset = oFactory.ExecuteDataSet(oRequest).ReturnedDataSet

                If Not IsNothing(oRequest.Exception) Then
                    Throw New ApplicationException("sqlexception", oRequest.Exception)
                End If

            Catch ex As Exception
                Dim objerrLog As New MITErrorHandling.MITErrorHandling("Exception in fngtEndYrSchRep : " & ex.Message)
                objerrLog.logError()
                System.Web.HttpContext.Current.Response.Redirect("~/users/smessages.aspx?qModule=TechErr", False)

            Finally
                oFactory.ConDispose()
            End Try

            Dim I As Integer
            Dim arrChartData1(5) As String


            If type = "data" Then
                If myDataset.Tables(0).Rows.Count = 0 Then
                Else

                    If myDataset.Tables(0).Rows.Count = 3 Then
                        For I = 0 To myDataset.Tables(0).Rows.Count - 2
                            arrChartData1(I) = Int(Val(myDataset.Tables(0).Rows(I + 1)(2).ToString)) & "," & Int(Val(myDataset.Tables(0).Rows(I + 1)(3).ToString)) & "," & Int(myDataset.Tables(0).Rows(I + 1)(4).ToString) & _
                          "," & Int(Val(myDataset.Tables(0).Rows(I + 1)(5).ToString)) & "," & Int(Val(myDataset.Tables(0).Rows(I + 1)(6).ToString)) & _
                              "," & Int(Val(myDataset.Tables(0).Rows(I + 1)(7).ToString))


                            myChart.ChartData = arrChartData1
                        Next
                    ElseIf myDataset.Tables(0).Rows.Count = 2 Then
                        For I = 0 To myDataset.Tables(0).Rows.Count - 1
                            arrChartData1(I) = Int(Val(myDataset.Tables(0).Rows(I)(2).ToString)) & "," & Int(Val(myDataset.Tables(0).Rows(I)(3).ToString)) & "," & Int(myDataset.Tables(0).Rows(I)(4).ToString) & _
                          "," & Int(Val(myDataset.Tables(0).Rows(I)(5).ToString)) & "," & Int(Val(myDataset.Tables(0).Rows(I)(6).ToString)) & _
                              "," & Int(Val(myDataset.Tables(0).Rows(I)(7).ToString))


                            myChart.ChartData = arrChartData1
                        Next
                    End If
                   
                End If
                'NOT X-AXIS TITLE FROM THE DB.

            ElseIf type = "legend" Then
                If myDataset.Tables(0).Rows.Count = 0 Then
                Else
                    If myDataset.Tables(0).Rows.Count = 3 Then
                        For I = 0 To myDataset.Tables(0).Rows.Count - 2
                            arrChartData1(I) = myDataset.Tables(0).Rows(I + 1)(1).ToString

                            myChart.ChartData = arrChartData1
                        Next
                    ElseIf myDataset.Tables(0).Rows.Count = 2 Then
                        For I = 0 To myDataset.Tables(0).Rows.Count - 1
                            arrChartData1(I) = myDataset.Tables(0).Rows(I)(1).ToString

                            myChart.ChartData = arrChartData1
                        Next
                    End If
                    End If

            End If
            Return myChart.ChartData
        End Function
#End Region
#Region "PIC - Tier 1 Critical Element (Chart id - 13_0)"
        ''-------------------------------------------------------------------------------------------------------------------
        '' Function Name : fngtMidYrPICImplLevel  
        '' Created By : Aditi Deodhar
        '' Created Dt : May 05,2010
        '' Last Updated Dt : May 05,2010
        '' Description : PIC - Tier 1 Critical Element
        '-------------------------------------------------------------------------------------------------------------------
        Shared Function fngtMidYrPICTier1CriElem(ByVal schid As String, ByVal schYr As Integer, ByVal type As String) As String()
            Dim oRequest As New URDALRequest
            Dim oFactory As URDALAbsDBFactory
            Dim myDataset As New DataSet

            Dim myChart As New C21MIT.PBSIS.BO.ChartInfoset

            oFactory = New URDALSQLFactory

            With oRequest
                .Command = "dbo.flpbs_slr_midyear_schpiccritical"
                .CommandType = CommandType.StoredProcedure
            End With

            'Input data
            oRequest.AddParameter("@p_schoolid", schid, URDALRequest.myDataType.dtChar, 6, ParameterDirection.Input)
            oRequest.AddParameter("@p_SchoolYear", schYr, URDALRequest.myDataType.dtTinyInt, , ParameterDirection.Input)

            Try
                myDataset = oFactory.ExecuteDataSet(oRequest).ReturnedDataSet

                If Not IsNothing(oRequest.Exception) Then
                    Throw New ApplicationException("sqlexception", oRequest.Exception)
                End If

            Catch ex As Exception
                Dim objerrLog As New MITErrorHandling.MITErrorHandling("Exception in fngtEndYrSchRep : " & ex.Message)
                objerrLog.logError()
                System.Web.HttpContext.Current.Response.Redirect("~/users/smessages.aspx?qModule=TechErr", False)

            Finally
                oFactory.ConDispose()
            End Try

            Dim I As Integer
            Dim arrChartData1(5) As String


            If type = "data" Then
                If myDataset.Tables(0).Rows.Count = 0 Then
                Else
                    If myDataset.Tables(0).Rows.Count = 3 Then
                        For I = 0 To myDataset.Tables(0).Rows.Count - 2
                            arrChartData1(I) = Int(Val(myDataset.Tables(0).Rows(I + 1)(2).ToString)) & "," & Int(Val(myDataset.Tables(0).Rows(I + 1)(3).ToString)) & "," & Int(myDataset.Tables(0).Rows(I + 1)(4).ToString) & _
                          "," & Int(Val(myDataset.Tables(0).Rows(I + 1)(5).ToString)) & "," & Int(Val(myDataset.Tables(0).Rows(I + 1)(6).ToString)) & _
                              "," & Int(Val(myDataset.Tables(0).Rows(I + 1)(7).ToString)) & "," & Int(Val(myDataset.Tables(0).Rows(I + 1)(8).ToString)) & _
                              "," & Int(Val(myDataset.Tables(0).Rows(I + 1)(9).ToString))

                            myChart.ChartData = arrChartData1
                        Next
                    ElseIf myDataset.Tables(0).Rows.Count = 2 Then
                        For I = 0 To myDataset.Tables(0).Rows.Count - 1
                            arrChartData1(I) = Int(Val(myDataset.Tables(0).Rows(I)(2).ToString)) & "," & Int(Val(myDataset.Tables(0).Rows(I)(3).ToString)) & "," & Int(myDataset.Tables(0).Rows(I)(4).ToString) & _
                          "," & Int(Val(myDataset.Tables(0).Rows(I)(5).ToString)) & "," & Int(Val(myDataset.Tables(0).Rows(I)(6).ToString)) & _
                              "," & Int(Val(myDataset.Tables(0).Rows(I)(7).ToString)) & "," & Int(Val(myDataset.Tables(0).Rows(I)(8).ToString)) & _
                              "," & Int(Val(myDataset.Tables(0).Rows(I)(9).ToString))

                            myChart.ChartData = arrChartData1
                        Next
                    End If
                End If

            ElseIf type = "XAxisTitle" Then
                If myDataset.Tables(0).Rows.Count = 0 Then
                Else
                    If myDataset.Tables(0).Rows.Count = 3 Then
                        For I = 0 To myDataset.Tables(0).Rows.Count - 2
                            arrChartData1(I) = Int(myDataset.Tables(0).Rows(I + 1)(1).ToString)

                            myChart.ChartData = arrChartData1
                        Next
                    ElseIf myDataset.Tables(0).Rows.Count = 2 Then
                        For I = 0 To myDataset.Tables(0).Rows.Count - 1
                            arrChartData1(I) = Int(myDataset.Tables(0).Rows(I)(1).ToString)

                            myChart.ChartData = arrChartData1
                        Next
                    End If

                End If

            ElseIf type = "legend" Then
                    If myDataset.Tables(0).Rows.Count = 0 Then
                Else
                    If myDataset.Tables(0).Rows.Count = 3 Then
                        For I = 0 To myDataset.Tables(0).Rows.Count - 2
                            arrChartData1(I) = myDataset.Tables(0).Rows(I + 1)(1).ToString

                            myChart.ChartData = arrChartData1
                        Next
                    ElseIf myDataset.Tables(0).Rows.Count = 2 Then
                        For I = 0 To myDataset.Tables(0).Rows.Count - 1
                            arrChartData1(I) = myDataset.Tables(0).Rows(I)(1).ToString

                            myChart.ChartData = arrChartData1
                        Next
                    End If
                End If

            End If
            Return myChart.ChartData
        End Function
#End Region
#End Region
    End Class
#End Region
#Region "END YEAR SCHOOL LOGIN REPORTS"
    Public Class endyrschloginreports
#Region "School Login - END YEAR REPORTS"
#Region "ODR's over Years of Implementation (Chart id - 7_0)"
        ''-------------------------------------------------------------------------------------------------------------------
        '' Function Name : fngtEndYrSchRep  
        '' Created By : Aditi Deodhar
        '' Created Dt : May 03,2010
        '' Last Updated Dt : May 03,2010
        '' Description : ODR's over Years of Implementation 
        ''-------------------------------------------------------------------------------------------------------------------
        Shared Function fngtEndYrODR(ByVal schid As String, ByVal type As String) As String()
            Dim oRequest As New URDALRequest
            Dim oFactory As URDALAbsDBFactory
            Dim myDataset As New DataSet

            Dim myChart As New C21MIT.PBSIS.BO.ChartInfoset

            oFactory = New URDALSQLFactory

            With oRequest
                .Command = "dbo.flpbs_slr_endyear_odroverimplem"
                .CommandType = CommandType.StoredProcedure
            End With

            'Input data
            oRequest.AddParameter("@p_schoolid", schid, URDALRequest.myDataType.dtChar, 6, ParameterDirection.Input)

            Try
                myDataset = oFactory.ExecuteDataSet(oRequest).ReturnedDataSet

                If Not IsNothing(oRequest.Exception) Then
                    Throw New ApplicationException("sqlexception", oRequest.Exception)
                End If

            Catch ex As Exception
                Dim objerrLog As New MITErrorHandling.MITErrorHandling("Exception in fngtEndYrSchRep : " & ex.Message)
                objerrLog.logError()
                System.Web.HttpContext.Current.Response.Redirect("~/users/smessages.aspx?qModule=TechErr", False)

            Finally
                oFactory.ConDispose()
            End Try

            Dim I As Integer
            Dim arrChartData1(5) As String
            If type = "data" Then
                If myDataset.Tables(0).Rows.Count = 0 Then
                Else
                    For I = 0 To myDataset.Tables(0).Rows.Count - 1
                        arrChartData1(I) = Int(Val(myDataset.Tables(0).Rows(I)(3).ToString))

                        myChart.ChartData = arrChartData1
                    Next
                End If
                Return myChart.ChartData
            ElseIf type = "XAxisTitle" Then
                If myDataset.Tables(0).Rows.Count = 0 Then
                Else
                    For I = 0 To myDataset.Tables(0).Rows.Count - 1
                        arrChartData1(I) = C21MIT.PBSIS.BLL.pbsschoolyeardesc.getschoolyeardesc(Int(Val(myDataset.Tables(0).Rows(I)(1).ToString)))

                        myChart.ChartData = arrChartData1
                    Next
                End If
                Return myChart.ChartData
            ElseIf type = "legend" Then
                If myDataset.Tables(0).Rows.Count = 0 Then
                Else
                    For I = 0 To myDataset.Tables(0).Rows.Count - 1
                        arrChartData1(I) = C21MIT.PBSIS.BLL.pbsschoolyeardesc.getschoolyeardesc(Int(Val(myDataset.Tables(0).Rows(I)(1).ToString)))

                        myChart.ChartData = arrChartData1
                    Next
                End If

            End If
            Return myChart.ChartData

        End Function
#End Region
#Region "ODR Referrals per 100 Students (Chart id - 8_0)"
        ''-------------------------------------------------------------------------------------------------------------------
        '' Function Name : fngtEndYrODR_100  
        '' Created By : Aditi Deodhar
        '' Created Dt : May 05,2010
        '' Last Updated Dt : May 05,2010
        '' Description : ODR Referrals per 100 Students
        '-------------------------------------------------------------------------------------------------------------------
        Shared Function fngtEndYrODR_100(ByVal schid As String, ByVal type As String) As String()
            Dim oRequest As New URDALRequest
            Dim oFactory As URDALAbsDBFactory
            Dim myDataset As New DataSet

            Dim myChart As New C21MIT.PBSIS.BO.ChartInfoset

            oFactory = New URDALSQLFactory

            With oRequest
                .Command = "dbo.flpbs_slr_endyear_schodrper100"
                .CommandType = CommandType.StoredProcedure
            End With

            'Input data
            oRequest.AddParameter("@p_schoolid", schid, URDALRequest.myDataType.dtChar, 6, ParameterDirection.Input)

            Try
                myDataset = oFactory.ExecuteDataSet(oRequest).ReturnedDataSet

                If Not IsNothing(oRequest.Exception) Then
                    Throw New ApplicationException("sqlexception", oRequest.Exception)
                End If

            Catch ex As Exception
                Dim objerrLog As New MITErrorHandling.MITErrorHandling("Exception in fngtEndYrSchRep : " & ex.Message)
                objerrLog.logError()
                System.Web.HttpContext.Current.Response.Redirect("~/users/smessages.aspx?qModule=TechErr", False)

            Finally
                oFactory.ConDispose()
            End Try

            Dim I As Integer
            Dim arrChartData1(5) As String


            If type = "data" Then
                If myDataset.Tables(0).Rows.Count = 0 Then
                Else
                    For I = 0 To myDataset.Tables(0).Rows.Count - 1
                        arrChartData1(I) = Int(Val(myDataset.Tables(0).Rows(I)(3).ToString))

                        myChart.ChartData = arrChartData1
                    Next
                End If

            ElseIf type = "XAxisTitle" Then
                If myDataset.Tables(0).Rows.Count = 0 Then
                Else
                    For I = 0 To myDataset.Tables(0).Rows.Count - 1
                        arrChartData1(I) = C21MIT.PBSIS.BLL.pbsschoolyeardesc.getschoolyeardesc(Int(Val(myDataset.Tables(0).Rows(I)(2).ToString)))

                        myChart.ChartData = arrChartData1
                    Next
                End If

            ElseIf type = "legend" Then
                If myDataset.Tables(0).Rows.Count = 0 Then
                Else
                    For I = 0 To myDataset.Tables(0).Rows.Count - 1
                        arrChartData1(I) = C21MIT.PBSIS.BLL.pbsschoolyeardesc.getschoolyeardesc(Int(Val(myDataset.Tables(0).Rows(I)(2).ToString)))

                        myChart.ChartData = arrChartData1
                    Next
                End If

            End If
            Return myChart.ChartData
        End Function
#End Region
#Region "ISS & OSS Over Years of Implementation (Chart id - 9_0)"
        ''-------------------------------------------------------------------------------------------------------------------
        '' Function Name : fngtEndYrISS_OSS  
        '' Created By : Aditi Deodhar
        '' Created Dt : May 05,2010
        '' Last Updated Dt : May 05,2010
        '' Description : ISS & OSS Over Years of Implementation
        '-------------------------------------------------------------------------------------------------------------------
        Shared Function fngtEndYrISS_OSS(ByVal schid As String, ByVal type As String) As String()
            Dim oRequest As New URDALRequest
            Dim oFactory As URDALAbsDBFactory
            Dim myDataset As New DataSet

            Dim myChart As New C21MIT.PBSIS.BO.ChartInfoset

            oFactory = New URDALSQLFactory

            With oRequest
                .Command = "dbo.flpbs_slr_endyear_issossoverimplem"
                .CommandType = CommandType.StoredProcedure
            End With

            'Input data
            oRequest.AddParameter("@p_schoolid", schid, URDALRequest.myDataType.dtChar, 6, ParameterDirection.Input)

            Try
                myDataset = oFactory.ExecuteDataSet(oRequest).ReturnedDataSet

                If Not IsNothing(oRequest.Exception) Then
                    Throw New ApplicationException("sqlexception", oRequest.Exception)
                End If

            Catch ex As Exception
                Dim objerrLog As New MITErrorHandling.MITErrorHandling("Exception in fngtEndYrSchRep : " & ex.Message)
                objerrLog.logError()
                System.Web.HttpContext.Current.Response.Redirect("~/users/smessages.aspx?qModule=TechErr", False)

            Finally
                oFactory.ConDispose()
            End Try

            Dim I As Integer
            Dim arrChartData1(5) As String


            If type = "data" Then
                If myDataset.Tables(0).Rows.Count = 0 Then
                Else
                    For I = 0 To myDataset.Tables(0).Rows.Count - 1
                        arrChartData1(I) = Int(Val(myDataset.Tables(0).Rows(I)(3).ToString)) & "," & Int(Val(myDataset.Tables(0).Rows(I)(4).ToString))


                        myChart.ChartData = arrChartData1
                    Next
                End If
                Return myChart.ChartData
            ElseIf type = "legend" Then
                If myDataset.Tables(0).Rows.Count = 0 Then
                Else
                    For I = 0 To myDataset.Tables(0).Rows.Count - 1
                        arrChartData1(I) = C21MIT.PBSIS.BLL.pbsschoolyeardesc.getschoolyeardesc(Int(Val(myDataset.Tables(0).Rows(I)(2).ToString)))

                        myChart.ChartData = arrChartData1
                    Next
                End If

            End If
            Return myChart.ChartData
        End Function
#End Region
#Region "ISS & OSS per 100 Students (Chart id - 10_0)"
        ''-------------------------------------------------------------------------------------------------------------------
        '' Function Name : fngtEndYrISS_OSS  
        '' Created By : Aditi Deodhar
        '' Created Dt : May 05,2010
        '' Last Updated Dt : May 05,2010
        '' Description : ISS & OSS per 100 Students
        '-------------------------------------------------------------------------------------------------------------------
        Shared Function fngtEndYrISS_OSS_100(ByVal schid As String, ByVal type As String) As String()
            Dim oRequest As New URDALRequest
            Dim oFactory As URDALAbsDBFactory
            Dim myDataset As New DataSet

            Dim myChart As New C21MIT.PBSIS.BO.ChartInfoset

            oFactory = New URDALSQLFactory

            With oRequest
                .Command = "dbo.flpbs_slr_endyear_schissossper100"
                .CommandType = CommandType.StoredProcedure
            End With

            'Input data
            oRequest.AddParameter("@p_schoolid", schid, URDALRequest.myDataType.dtChar, 6, ParameterDirection.Input)

            Try
                myDataset = oFactory.ExecuteDataSet(oRequest).ReturnedDataSet

                If Not IsNothing(oRequest.Exception) Then
                    Throw New ApplicationException("sqlexception", oRequest.Exception)
                End If

            Catch ex As Exception
                Dim objerrLog As New MITErrorHandling.MITErrorHandling("Exception in fngtEndYrSchRep : " & ex.Message)
                objerrLog.logError()
                System.Web.HttpContext.Current.Response.Redirect("~/users/smessages.aspx?qModule=TechErr", False)

            Finally
                oFactory.ConDispose()
            End Try

            Dim I As Integer
            Dim arrChartData1(5) As String


            If type = "data" Then
                If myDataset.Tables(0).Rows.Count = 0 Then
                Else
                    For I = 0 To myDataset.Tables(0).Rows.Count - 1
                        arrChartData1(I) = Int(Val(myDataset.Tables(0).Rows(I)(3).ToString)) & ", " & Int(Val(myDataset.Tables(0).Rows(I)(4).ToString))


                        myChart.ChartData = arrChartData1
                    Next
                End If

            ElseIf type = "XAxisTitle" Then
                If myDataset.Tables(0).Rows.Count = 0 Then
                Else
                    For I = 0 To myDataset.Tables(0).Rows.Count - 1
                        arrChartData1(I) = C21MIT.PBSIS.BLL.pbsschoolyeardesc.getschoolyeardesc(Int(Val(myDataset.Tables(0).Rows(I)(1).ToString)))

                        myChart.ChartData = arrChartData1
                    Next
                End If


            ElseIf type = "legend" Then
                If myDataset.Tables(0).Rows.Count = 0 Then
                Else
                    For I = 0 To myDataset.Tables(0).Rows.Count - 1
                        arrChartData1(I) = C21MIT.PBSIS.BLL.pbsschoolyeardesc.getschoolyeardesc(Int(Val(myDataset.Tables(0).Rows(I)(1).ToString)))

                        myChart.ChartData = arrChartData1
                    Next
                End If

            End If
            Return myChart.ChartData
        End Function
#End Region
#Region "Average Daily Attendance (Chart id - 11_0)"
        ''-------------------------------------------------------------------------------------------------------------------
        '' Function Name : fngtEndYrISS_OSS  
        '' Created By : Aditi Deodhar
        '' Created Dt : May 05,2010
        '' Last Updated Dt : May 05,2010
        '' Description : Average Daily Attendance
        '-------------------------------------------------------------------------------------------------------------------
        Shared Function fngtEndYrAttend(ByVal schid As String, ByVal type As String) As String()
            Dim oRequest As New URDALRequest
            Dim oFactory As URDALAbsDBFactory
            Dim myDataset As New DataSet

            Dim myChart As New C21MIT.PBSIS.BO.ChartInfoset

            oFactory = New URDALSQLFactory

            With oRequest
                .Command = "dbo.flpbs_slr_endyear_schavgattnd"
                .CommandType = CommandType.StoredProcedure
            End With

            'Input data
            oRequest.AddParameter("@p_schoolid", schid, URDALRequest.myDataType.dtChar, 6, ParameterDirection.Input)

            Try
                myDataset = oFactory.ExecuteDataSet(oRequest).ReturnedDataSet

                If Not IsNothing(oRequest.Exception) Then
                    Throw New ApplicationException("sqlexception", oRequest.Exception)
                End If

            Catch ex As Exception
                Dim objerrLog As New MITErrorHandling.MITErrorHandling("Exception in fngtEndYrSchRep : " & ex.Message)
                objerrLog.logError()
                System.Web.HttpContext.Current.Response.Redirect("~/users/smessages.aspx?qModule=TechErr", False)

            Finally
                oFactory.ConDispose()
            End Try

            Dim I As Integer
            Dim arrChartData1(5) As String


            If type = "data" Then
                If myDataset.Tables(0).Rows.Count = 0 Then
                Else
                    For I = 0 To myDataset.Tables(0).Rows.Count - 1
                        arrChartData1(I) = Int(Val(myDataset.Tables(0).Rows(I)(3).ToString))

                        myChart.ChartData = arrChartData1
                    Next
                End If
                Return myChart.ChartData
            ElseIf type = "XAxisTitle" Then
                If myDataset.Tables(0).Rows.Count = 0 Then
                Else
                    For I = 0 To myDataset.Tables(0).Rows.Count - 1
                        arrChartData1(I) = C21MIT.PBSIS.BLL.pbsschoolyeardesc.getschoolyeardesc(Int(Val(myDataset.Tables(0).Rows(I)(1).ToString)))

                        myChart.ChartData = arrChartData1
                    Next
                End If
                Return myChart.XAxisLabel
            ElseIf type = "legend" Then
                If myDataset.Tables(0).Rows.Count = 0 Then
                Else
                    For I = 0 To myDataset.Tables(0).Rows.Count - 1
                        arrChartData1(I) = C21MIT.PBSIS.BLL.pbsschoolyeardesc.getschoolyeardesc(Int(Val(myDataset.Tables(0).Rows(I)(1).ToString)))

                        myChart.ChartData = arrChartData1
                    Next
                End If

            End If
            Return myChart.ChartData
        End Function

#End Region
#Region "Benchmark of Quality Score per Critical Element (Chart id - 12_0)"
        ''-------------------------------------------------------------------------------------------------------------------
        '' Function Name : fngtEndYrISS_OSS  
        '' Created By : Aditi Deodhar
        '' Created Dt : May 05,2010
        '' Last Updated Dt : May 05,2010
        '' Description : Benchmark of Quality Score per Critical Element
        '-------------------------------------------------------------------------------------------------------------------
        Shared Function fngtEndYrBOQ(ByVal schid As String, ByVal type As String) As String()
            Dim oRequest As New URDALRequest
            Dim oFactory As URDALAbsDBFactory
            Dim myDataset As New DataSet

            Dim myChart As New C21MIT.PBSIS.BO.ChartInfoset

            oFactory = New URDALSQLFactory

            With oRequest
                .Command = "dbo.flpbs_slr_endyear_schboqscore"
                .CommandType = CommandType.StoredProcedure
            End With

            'Input data
            oRequest.AddParameter("@p_schoolid", schid, URDALRequest.myDataType.dtChar, 6, ParameterDirection.Input)

            Try
                myDataset = oFactory.ExecuteDataSet(oRequest).ReturnedDataSet

                If Not IsNothing(oRequest.Exception) Then
                    Throw New ApplicationException("sqlexception", oRequest.Exception)
                End If

            Catch ex As Exception
                Dim objerrLog As New MITErrorHandling.MITErrorHandling("Exception in fngtEndYrSchRep : " & ex.Message)
                objerrLog.logError()
                System.Web.HttpContext.Current.Response.Redirect("~/users/smessages.aspx?qModule=TechErr", False)

            Finally
                oFactory.ConDispose()
            End Try

            Dim I As Integer
            Dim arrChartData1(5) As String


            If type = "data" Then
                If myDataset.Tables(0).Rows.Count = 0 Then
                Else
                    For I = 0 To myDataset.Tables(0).Rows.Count - 1
                        arrChartData1(I) = Int(Val(myDataset.Tables(0).Rows(I)(2).ToString)) & "," & Int(Val(myDataset.Tables(0).Rows(I)(3).ToString)) & "," & Int(myDataset.Tables(0).Rows(I)(4).ToString) & _
                      "," & Int(Val(myDataset.Tables(0).Rows(I)(5).ToString)) & "," & Int(Val(myDataset.Tables(0).Rows(I)(6).ToString)) & _
                          "," & Int(Val(myDataset.Tables(0).Rows(I)(7).ToString)) & "," & Int(Val(myDataset.Tables(0).Rows(I)(8).ToString)) & _
                          "," & Int(Val(myDataset.Tables(0).Rows(I)(9).ToString)) & "," & Int(Val(myDataset.Tables(0).Rows(I)(10).ToString)) & _
                           "," & Int(Val(myDataset.Tables(0).Rows(I)(11).ToString)) & "," & Int(Val(myDataset.Tables(0).Rows(I)(12).ToString)) & _
                           "," & Int(Val(myDataset.Tables(0).Rows(I)(13).ToString))


                        myChart.ChartData = arrChartData1
                    Next
                End If

            ElseIf type = "XAxisTitle" Then
                If myDataset.Tables(0).Rows.Count = 0 Then
                Else
                    For I = 0 To myDataset.Tables(0).Rows.Count - 1
                        arrChartData1(I) = Int(myDataset.Tables(0).Rows(I)(1).ToString)

                        myChart.ChartData = arrChartData1
                    Next
                End If

            ElseIf type = "legend" Then
                If myDataset.Tables(0).Rows.Count = 0 Then
                Else
                    For I = 0 To myDataset.Tables(0).Rows.Count - 1
                        arrChartData1(I) = C21MIT.PBSIS.BLL.pbsschoolyeardesc.getschoolyeardesc(Int(myDataset.Tables(0).Rows(I)(1).ToString))

                        myChart.ChartData = arrChartData1
                    Next
                End If

            End If
            Return myChart.ChartData
        End Function
#End Region
#Region "Annual B.A.T. Subsection Report (Chart id - 42_0)"
        ''-------------------------------------------------------------------------------------------------------------------
        '' Function Name : fngtBATSubsectionRep  
        '' Created By : Aditi Deodhar
        '' Created Dt : May 24,2010
        '' Last Updated Dt : May 24,2010
        '' Description : Annual B.A.T. Subsection Report
        '-------------------------------------------------------------------------------------------------------------------
        Shared Function fngtBATSubsectionRep(ByVal schid As String, ByVal schYr As Integer, ByVal type As String) As String()
            Dim oRequest As New URDALRequest
            Dim oFactory As URDALAbsDBFactory
            Dim myDataset As New DataSet

            Dim myChart As New C21MIT.PBSIS.BO.ChartInfoset

            oFactory = New URDALSQLFactory

            With oRequest
                .Command = "dbo.flpbs_slr_endyear_batcescr"
                .CommandType = CommandType.StoredProcedure
            End With

            'Input data
            oRequest.AddParameter("@p_schoolid", schid, URDALRequest.myDataType.dtChar, 6, ParameterDirection.Input)
            oRequest.AddParameter("@p_SchoolYear", schYr, URDALRequest.myDataType.dtTinyInt, , ParameterDirection.Input)

            Try
                myDataset = oFactory.ExecuteDataSet(oRequest).ReturnedDataSet

                If Not IsNothing(oRequest.Exception) Then
                    Throw New ApplicationException("sqlexception", oRequest.Exception)
                End If

            Catch ex As Exception
                Dim objerrLog As New MITErrorHandling.MITErrorHandling("Exception in fngtBATSubsectionRep : " & ex.Message)
                objerrLog.logError()
                System.Web.HttpContext.Current.Response.Redirect("~/users/smessages.aspx?qModule=TechErr", False)

            Finally
                oFactory.ConDispose()
            End Try

            Dim I As Integer
            Dim arrChartData1(5) As String

            If type = "data" Then
                If myDataset.Tables(0).Rows.Count = 0 Then
                Else

                    Dim strzero As Integer = 0
                    Dim strList1(3) As String
                    Dim strList2 As String = ""
                    Dim strList3 As String = ""
                    For I = 0 To myDataset.Tables(0).Rows.Count - 1
                        strList1(0) = Int(Math.Round(myDataset.Tables(0).Rows(I)(2))) & _
                                  "," & Int(Math.Round(myDataset.Tables(0).Rows(I)(3))) & "," & Int(Math.Round(myDataset.Tables(0).Rows(I)(4))) & _
                                      "," & Int(Math.Round(myDataset.Tables(0).Rows(I)(5))) & "," & strzero.ToString & "," & strzero.ToString & "," & strzero.ToString & "," & strzero.ToString & "," & strzero.ToString & "," & strzero.ToString
                        strList1(1) = strzero.ToString & "," & strzero.ToString & "," & strzero.ToString & "," & strzero.ToString & "," & Int(Math.Round(myDataset.Tables(0).Rows(I)(6))) & "," & Int(Math.Round(myDataset.Tables(0).Rows(I)(7))) & "," & Int(Math.Round(myDataset.Tables(0).Rows(I)(8))) & "," & strzero.ToString & "," & strzero.ToString & "," & strzero.ToString
                        strList1(2) = strzero.ToString & "," & strzero.ToString & "," & strzero.ToString & "," & strzero.ToString & "," & strzero.ToString & "," & strzero.ToString & "," & strzero.ToString & "," & Int(Math.Round(myDataset.Tables(0).Rows(I)(9))) & "," & Int(Math.Round(myDataset.Tables(0).Rows(I)(10))) & _
                                  "," & Int(Math.Round(myDataset.Tables(0).Rows(I)(11)))

                        arrChartData1(0) = strList1(0)
                        arrChartData1(1) = strList1(1)
                        arrChartData1(2) = strList1(2)
                        myChart.ChartData = arrChartData1
                    Next


                    'For I = 0 To myDataset.Tables(0).Rows.Count - 1
                    '    arrChartData1(I) = Int(Val(myDataset.Tables(0).Rows(I)(2).ToString)) & _
                    '              "," & Int(Val(myDataset.Tables(0).Rows(I)(3).ToString)) & "," & Int(Val(myDataset.Tables(0).Rows(I)(4).ToString)) & _
                    '              "," & Int(Val(myDataset.Tables(0).Rows(I)(5).ToString)) & "," & Int(Val(myDataset.Tables(0).Rows(I)(6).ToString)) & _
                    '              "," & Int(Val(myDataset.Tables(0).Rows(I)(7).ToString)) & "," & Int(Val(myDataset.Tables(0).Rows(I)(8).ToString)) & _
                    '              "," & Int(Val(myDataset.Tables(0).Rows(I)(9).ToString)) & "," & Int(Val(myDataset.Tables(0).Rows(I)(10).ToString)) & _
                    '              "," & Int(Val(myDataset.Tables(0).Rows(I)(11).ToString))


                    '    myChart.ChartData = arrChartData1
                    ' Next
                End If
            End If

            Return myChart.ChartData
        End Function
#End Region
#Region "Multi-Year B.A.T. Report (Chart id - 43_0)"
        ''-------------------------------------------------------------------------------------------------------------------
        '' Function Name : fngtMultiYrBATreport  
        '' Created By : Aditi Deodhar
        '' Created Dt : May 24,2010
        '' Last Updated Dt : May 24,2010
        '' Description : Multi-Year B.A.T. Report
        '-------------------------------------------------------------------------------------------------------------------
        Shared Function fngtMultiYrBATreport(ByVal schID As String, ByVal type As String) As String()
            Dim oRequest As New URDALRequest
            Dim oFactory As URDALAbsDBFactory
            Dim myDataset As New DataSet

            Dim myChart As New C21MIT.PBSIS.BO.ChartInfoset

            oFactory = New URDALSQLFactory

            With oRequest
                .Command = "dbo.flpbs_slr_endyear_batsumscr"
                .CommandType = CommandType.StoredProcedure
            End With

            'Input data
            oRequest.AddParameter("@p_schoolid", schID, URDALRequest.myDataType.dtChar, 6, ParameterDirection.Input)

            Try
                myDataset = oFactory.ExecuteDataSet(oRequest).ReturnedDataSet

                If Not IsNothing(oRequest.Exception) Then
                    Throw New ApplicationException("sqlexception", oRequest.Exception)
                End If

            Catch ex As Exception
                Dim objerrLog As New MITErrorHandling.MITErrorHandling("Exception in fngtEndYrDlrPerMGInReadingBySchImp : " & ex.Message)
                objerrLog.logError()
                System.Web.HttpContext.Current.Response.Redirect("~/users/smessages.aspx?qModule=TechErr", False)

            Finally
                oFactory.ConDispose()
            End Try

            Dim I As Integer
            Dim arrChartData1(5) As String

            If type = "data" Then
                If myDataset.Tables(0).Rows.Count = 0 Then
                Else
                    Dim strList1 As String = ""
                    Dim strList2 As String = ""
                    Dim strList3 As String = ""

                    For I = 0 To myDataset.Tables(0).Rows.Count - 1
                        strList1 = strList1 & "," & Int(Math.Round(myDataset.Tables(0).Rows(I)(2)))
                        strList2 = strList2 & "," & Int(Math.Round(myDataset.Tables(0).Rows(I)(3)))
                        strList3 = strList3 & "," & Int(Math.Round(myDataset.Tables(0).Rows(I)(4)))
                    Next

                    strList1 = strList1.Remove(0, 1)
                    strList2 = strList2.Remove(0, 1)
                    strList3 = strList3.Remove(0, 1)

                    arrChartData1(0) = strList1
                    arrChartData1(1) = strList2
                    arrChartData1(2) = strList3

                    myChart.ChartData = arrChartData1
                End If
            ElseIf type = "legend" Then
                If myDataset.Tables(0).Rows.Count = 0 Then
                Else
                    For I = 0 To myDataset.Tables(0).Rows.Count - 1
                        arrChartData1(I) = myDataset.Tables(0).Rows(I)(2).ToString
                        myChart.ChartData = arrChartData1
                    Next
                End If
            ElseIf type = "XAxisTitle" Then
                If myDataset.Tables(0).Rows.Count = 0 Then
                Else
                    For I = 0 To myDataset.Tables(0).Rows.Count - 1
                        arrChartData1(I) = myDataset.Tables(0).Rows(I)(1).ToString
                        myChart.ChartData = arrChartData1
                    Next
                End If
            End If
            Return myChart.ChartData
        End Function
#End Region
#End Region
    End Class
#End Region
#Region "END YEAR DISTRICT LEVEL REPORTS"
    Public Class endyrdlrreports
#Region "Average ODR per 100 Students by Implementation level (Chart id - 31_0)"
        ''-------------------------------------------------------------------------------------------------------------------
        '' Function Name : fngtEndYrDlrODRper100  
        '' Created By : Aditi Deodhar
        '' Created Dt : May 06,2010
        '' Last Updated Dt : May 06,2010
        '' Description : Average ODR per 100 Students by Implementation level
        '-------------------------------------------------------------------------------------------------------------------
        Shared Function fngtEndYrDlrODRper100(ByVal distid As String, ByVal type As String) As String()
            Dim oRequest As New URDALRequest
            Dim oFactory As URDALAbsDBFactory
            Dim myDataset As New DataSet

            Dim myChart As New C21MIT.PBSIS.BO.ChartInfoset

            oFactory = New URDALSQLFactory

            With oRequest
                .Command = "dbo.flpbs_dlr_endyear_distavgodrper100"
                .CommandType = CommandType.StoredProcedure
            End With

            'Input data
            oRequest.AddParameter("@p_districtid", distid, URDALRequest.myDataType.dtChar, 2, ParameterDirection.Input)

            Try
                myDataset = oFactory.ExecuteDataSet(oRequest).ReturnedDataSet

                If Not IsNothing(oRequest.Exception) Then
                    Throw New ApplicationException("sqlexception", oRequest.Exception)
                End If

            Catch ex As Exception
                Dim objerrLog As New MITErrorHandling.MITErrorHandling("Exception in fngtEndYrSchRep : " & ex.Message)
                objerrLog.logError()
                System.Web.HttpContext.Current.Response.Redirect("~/users/smessages.aspx?qModule=TechErr", False)

            Finally
                oFactory.ConDispose()
            End Try

            Dim I As Integer
            Dim arrChartData1(5) As String


            If type = "data" Then
                If myDataset.Tables(0).Rows.Count = 0 Then
                Else
                    For I = 0 To myDataset.Tables(0).Rows.Count - 1
                        arrChartData1(I) = Int(Val(myDataset.Tables(0).Rows(I)(3).ToString)) & "," & Int(Val(myDataset.Tables(0).Rows(I)(5).ToString))
                        myChart.ChartData = arrChartData1
                    Next
                End If

            ElseIf type = "legend" Then
                If myDataset.Tables(0).Rows.Count = 0 Then
                Else
                    For I = 0 To myDataset.Tables(0).Rows.Count - 1
                        arrChartData1(I) = myDataset.Tables(0).Rows(I)(2).ToString

                        myChart.ChartData = arrChartData1
                    Next
                End If

            End If
            Return myChart.ChartData
        End Function
#End Region
#Region "Average ISS Days per 100 Students by Implementation level (Chart id - 32_0)"
        ''-------------------------------------------------------------------------------------------------------------------
        '' Function Name : fngtEndYrDlrODRper100  
        '' Created By : Aditi Deodhar
        '' Created Dt : May 06,2010
        '' Last Updated Dt : May 06,2010
        '' Description : Average ISS Days per 100 Students by Implementation level
        '-------------------------------------------------------------------------------------------------------------------
        Shared Function fngtEndYrDlrISSPer100Stu(ByVal distid As String, ByVal type As String) As String()
            Dim oRequest As New URDALRequest
            Dim oFactory As URDALAbsDBFactory
            Dim myDataset As New DataSet

            Dim myChart As New C21MIT.PBSIS.BO.ChartInfoset

            oFactory = New URDALSQLFactory

            With oRequest
                .Command = "dbo.flpbs_dlr_endyear_distavgissper100"
                .CommandType = CommandType.StoredProcedure
            End With

            'Input data
            oRequest.AddParameter("@p_districtid", distid, URDALRequest.myDataType.dtChar, 2, ParameterDirection.Input)

            Try
                myDataset = oFactory.ExecuteDataSet(oRequest).ReturnedDataSet

                If Not IsNothing(oRequest.Exception) Then
                    Throw New ApplicationException("sqlexception", oRequest.Exception)
                End If

            Catch ex As Exception
                Dim objerrLog As New MITErrorHandling.MITErrorHandling("Exception in fngtEndYrSchRep : " & ex.Message)
                objerrLog.logError()
                System.Web.HttpContext.Current.Response.Redirect("~/users/smessages.aspx?qModule=TechErr", False)

            Finally
                oFactory.ConDispose()
            End Try

            Dim I As Integer
            Dim arrChartData1(5) As String


            If type = "data" Then
                If myDataset.Tables(0).Rows.Count = 0 Then
                Else
                    For I = 0 To myDataset.Tables(0).Rows.Count - 1
                        arrChartData1(I) = Int(Val(myDataset.Tables(0).Rows(I)(3).ToString)) & "," & Int(Val(myDataset.Tables(0).Rows(I)(5).ToString))
                        myChart.ChartData = arrChartData1
                    Next
                End If

            ElseIf type = "legend" Then
                If myDataset.Tables(0).Rows.Count = 0 Then
                Else
                    For I = 0 To myDataset.Tables(0).Rows.Count - 1
                        arrChartData1(I) = myDataset.Tables(0).Rows(I)(2).ToString

                        myChart.ChartData = arrChartData1
                    Next
                End If

            End If
            Return myChart.ChartData
        End Function
#End Region
#Region "Average OSS Days per 100 Students by Implementation level (Chart id - 33_0)"
        ''-------------------------------------------------------------------------------------------------------------------
        '' Function Name : fngtEndYrDlrOSSPer100Stu  
        '' Created By : Aditi Deodhar
        '' Created Dt : May 06,2010
        '' Last Updated Dt : May 06,2010
        '' Description : Average OSS Days per 100 Students by Implementation level 
        '-------------------------------------------------------------------------------------------------------------------
        Shared Function fngtEndYrDlrOSSPer100Stu(ByVal distid As String, ByVal type As String) As String()
            Dim oRequest As New URDALRequest
            Dim oFactory As URDALAbsDBFactory
            Dim myDataset As New DataSet

            Dim myChart As New C21MIT.PBSIS.BO.ChartInfoset

            oFactory = New URDALSQLFactory

            With oRequest
                .Command = "dbo.flpbs_dlr_endyear_distavgossper100"
                .CommandType = CommandType.StoredProcedure
            End With

            'Input data
            oRequest.AddParameter("@p_districtid", distid, URDALRequest.myDataType.dtChar, 2, ParameterDirection.Input)

            Try
                myDataset = oFactory.ExecuteDataSet(oRequest).ReturnedDataSet

                If Not IsNothing(oRequest.Exception) Then
                    Throw New ApplicationException("sqlexception", oRequest.Exception)
                End If

            Catch ex As Exception
                Dim objerrLog As New MITErrorHandling.MITErrorHandling("Exception in fngtEndYrDlrOSSPer100Stu : " & ex.Message)
                objerrLog.logError()
                System.Web.HttpContext.Current.Response.Redirect("~/users/smessages.aspx?qModule=TechErr", False)

            Finally
                oFactory.ConDispose()
            End Try

            Dim I As Integer
            Dim arrChartData1(5) As String


            If type = "data" Then
                If myDataset.Tables(0).Rows.Count = 0 Then
                Else
                    For I = 0 To myDataset.Tables(0).Rows.Count - 1
                        arrChartData1(I) = Int(Val(myDataset.Tables(0).Rows(I)(3).ToString)) & "," & Int(Val(myDataset.Tables(0).Rows(I)(5).ToString))
                        myChart.ChartData = arrChartData1
                    Next
                End If

            ElseIf type = "legend" Then
                If myDataset.Tables(0).Rows.Count = 0 Then
                Else
                    For I = 0 To myDataset.Tables(0).Rows.Count - 1
                        arrChartData1(I) = myDataset.Tables(0).Rows(I)(2).ToString

                        myChart.ChartData = arrChartData1
                    Next
                End If

            End If
            Return myChart.ChartData
        End Function
#End Region
#Region "Percentage making gains in reading by School Implementation level (Chart id - 34_0)"
        ''-------------------------------------------------------------------------------------------------------------------
        '' Function Name : fngtEndYrDlrPerMGInReadingBySchImp  
        '' Created By : Aditi Deodhar
        '' Created Dt : May 06,2010
        '' Last Updated Dt : May 06,2010
        '' Description : Percentage making gains in reading by School Implementation level
        '-------------------------------------------------------------------------------------------------------------------
        Shared Function fngtEndYrDlrPerMGInReadingBySchImp(ByVal distid As String, ByVal type As String) As String()
            Dim oRequest As New URDALRequest
            Dim oFactory As URDALAbsDBFactory
            Dim myDataset As New DataSet

            Dim myChart As New C21MIT.PBSIS.BO.ChartInfoset

            oFactory = New URDALSQLFactory

            With oRequest
                .Command = "dbo.flpbs_dlr_endyear_distavgpercrg"
                .CommandType = CommandType.StoredProcedure
            End With

            'Input data
            oRequest.AddParameter("@p_districtid", distid, URDALRequest.myDataType.dtChar, 2, ParameterDirection.Input)

            Try
                myDataset = oFactory.ExecuteDataSet(oRequest).ReturnedDataSet

                If Not IsNothing(oRequest.Exception) Then
                    Throw New ApplicationException("sqlexception", oRequest.Exception)
                End If

            Catch ex As Exception
                Dim objerrLog As New MITErrorHandling.MITErrorHandling("Exception in fngtEndYrDlrPerMGInReadingBySchImp : " & ex.Message)
                objerrLog.logError()
                System.Web.HttpContext.Current.Response.Redirect("~/users/smessages.aspx?qModule=TechErr", False)

            Finally
                oFactory.ConDispose()
            End Try

            Dim I As Integer
            Dim arrChartData1(5) As String

            If type = "data" Then
                If myDataset.Tables(0).Rows.Count = 0 Then
                Else
                    For I = 0 To myDataset.Tables(0).Rows.Count - 1
                        arrChartData1(I) = Int(Val(myDataset.Tables(0).Rows(I)(3).ToString)) & "," & Int(Val(myDataset.Tables(0).Rows(I)(5).ToString))
                        myChart.ChartData = arrChartData1
                    Next
                End If

            ElseIf type = "legend" Then
                If myDataset.Tables(0).Rows.Count = 0 Then
                Else
                    For I = 0 To myDataset.Tables(0).Rows.Count - 1
                        arrChartData1(I) = myDataset.Tables(0).Rows(I)(2).ToString

                        myChart.ChartData = arrChartData1
                    Next
                End If

            End If
            Return myChart.ChartData
        End Function
#End Region
#Region "Percentage of Lowest 25% Making Gains in Reading By School Implementation Level (Chart id - 35_0)"

        ''-------------------------------------------------------------------------------------------------------------------
        '' Function Name : fngtEndYrDlrPerofLow25MGiReadBySchImpl  
        '' Created By : Aditi Deodhar
        '' Created Dt : May 06,2010
        '' Last Updated Dt : May 06,2010
        '' Description : Percentage of Lowest 25% Making Gains in Reading By School Implementation Level
        '-------------------------------------------------------------------------------------------------------------------
        Shared Function fngtEndYrDlrPerofLow25MGiReadBySchImpl(ByVal distid As String, ByVal type As String) As String()
            Dim oRequest As New URDALRequest
            Dim oFactory As URDALAbsDBFactory
            Dim myDataset As New DataSet

            Dim myChart As New C21MIT.PBSIS.BO.ChartInfoset

            oFactory = New URDALSQLFactory

            With oRequest
                .Command = "dbo.flpbs_dlr_endyear_distavgpercrglow"
                .CommandType = CommandType.StoredProcedure
            End With

            'Input data
            oRequest.AddParameter("@p_districtid", distid, URDALRequest.myDataType.dtChar, 2, ParameterDirection.Input)

            Try
                myDataset = oFactory.ExecuteDataSet(oRequest).ReturnedDataSet

                If Not IsNothing(oRequest.Exception) Then
                    Throw New ApplicationException("sqlexception", oRequest.Exception)
                End If

            Catch ex As Exception
                Dim objerrLog As New MITErrorHandling.MITErrorHandling("Exception in fngtEndYrDlrPerMGInReadingBySchImp : " & ex.Message)
                objerrLog.logError()
                System.Web.HttpContext.Current.Response.Redirect("~/users/smessages.aspx?qModule=TechErr", False)

            Finally
                oFactory.ConDispose()
            End Try

            Dim I As Integer
            Dim arrChartData1(5) As String

            If type = "data" Then
                If myDataset.Tables(0).Rows.Count = 0 Then
                Else
                    For I = 0 To myDataset.Tables(0).Rows.Count - 1
                        arrChartData1(I) = Int(Val(myDataset.Tables(0).Rows(I)(3).ToString)) & "," & Int(Val(myDataset.Tables(0).Rows(I)(5).ToString))
                        myChart.ChartData = arrChartData1
                    Next
                End If

            ElseIf type = "legend" Then
                If myDataset.Tables(0).Rows.Count = 0 Then
                Else
                    For I = 0 To myDataset.Tables(0).Rows.Count - 1
                        arrChartData1(I) = myDataset.Tables(0).Rows(I)(2).ToString

                        myChart.ChartData = arrChartData1
                    Next
                End If

            End If
            Return myChart.ChartData
        End Function
#End Region
#Region "Average Daily attendance for Higher and Lower implementing schools (Chart id - 36_0)"
        ''-------------------------------------------------------------------------------------------------------------------
        '' Function Name : fngtAvgDAttendforHiALoImpl  
        '' Created By : Aditi Deodhar
        '' Created Dt : May 07,2010
        '' Last Updated Dt : May 07,2010
        '' Description : Average Daily attendance for Higher and Lower implementing schools 
        '-------------------------------------------------------------------------------------------------------------------
        Shared Function fngtAvgDAttendforHiALoImpl(ByVal distid As String, ByVal type As String) As String()
            Dim oRequest As New URDALRequest
            Dim oFactory As URDALAbsDBFactory
            Dim myDataset As New DataSet

            Dim myChart As New C21MIT.PBSIS.BO.ChartInfoset

            oFactory = New URDALSQLFactory

            With oRequest
                .Command = "dbo.flpbs_dlr_endyear_distavgdailyattbySchYr"
                .CommandType = CommandType.StoredProcedure
            End With

            'Input data
            oRequest.AddParameter("@p_districtid", distid, URDALRequest.myDataType.dtChar, 2, ParameterDirection.Input)

            Try
                myDataset = oFactory.ExecuteDataSet(oRequest).ReturnedDataSet

                If Not IsNothing(oRequest.Exception) Then
                    Throw New ApplicationException("sqlexception", oRequest.Exception)
                End If

            Catch ex As Exception
                Dim objerrLog As New MITErrorHandling.MITErrorHandling("Exception in fngtEndYrDlrPerMGInReadingBySchImp : " & ex.Message)
                objerrLog.logError()
                System.Web.HttpContext.Current.Response.Redirect("~/users/smessages.aspx?qModule=TechErr", False)

            Finally
                oFactory.ConDispose()
            End Try

            Dim I As Integer
            Dim arrChartData1(5) As String

            If type = "data" Then
                If myDataset.Tables(0).Rows.Count = 0 Then
                Else
                    For I = 0 To myDataset.Tables(0).Rows.Count - 1
                        arrChartData1(I) = Int(Val(myDataset.Tables(0).Rows(I)(3).ToString)) & "," & Int(Val(myDataset.Tables(0).Rows(I)(4).ToString))
                        myChart.ChartData = arrChartData1
                    Next
                End If

            ElseIf type = "legend" Then
                If myDataset.Tables(0).Rows.Count = 0 Then
                Else
                    For I = 0 To myDataset.Tables(0).Rows.Count - 1
                        arrChartData1(I) = myDataset.Tables(0).Rows(I)(2).ToString

                        myChart.ChartData = arrChartData1
                    Next
                End If

            End If
            Return myChart.ChartData
        End Function

#End Region
#Region "District percentage of Students at FCAT reading Level 3 by PBS Implementation Level (Chart id - 37_0)"
        ''-------------------------------------------------------------------------------------------------------------------
        '' Function Name : fngtPerFCATREadLvl3  
        '' Created By : Aditi Deodhar
        '' Created Dt : May 07,2010
        '' Last Updated Dt : May 07,2010
        '' Description : District percentage of Students at FCAT reading Level 3 by PBS Implementation Level 
        '-------------------------------------------------------------------------------------------------------------------
        Shared Function fngtPerFCATREadLvl3(ByVal distid As String, ByVal type As String) As String()
            Dim oRequest As New URDALRequest
            Dim oFactory As URDALAbsDBFactory
            Dim myDataset As New DataSet

            Dim myChart As New C21MIT.PBSIS.BO.ChartInfoset

            oFactory = New URDALSQLFactory

            With oRequest
                .Command = "dbo.flpbs_dlr_endyear_perfcatreadingl3bySchyr"
                .CommandType = CommandType.StoredProcedure
            End With

            'Input data
            oRequest.AddParameter("@p_districtid", distid, URDALRequest.myDataType.dtChar, 2, ParameterDirection.Input)

            Try
                myDataset = oFactory.ExecuteDataSet(oRequest).ReturnedDataSet

                If Not IsNothing(oRequest.Exception) Then
                    Throw New ApplicationException("sqlexception", oRequest.Exception)
                End If

            Catch ex As Exception
                Dim objerrLog As New MITErrorHandling.MITErrorHandling("Exception in fngtEndYrDlrPerMGInReadingBySchImp : " & ex.Message)
                objerrLog.logError()
                System.Web.HttpContext.Current.Response.Redirect("~/users/smessages.aspx?qModule=TechErr", False)

            Finally
                oFactory.ConDispose()
            End Try

            Dim I As Integer
            Dim arrChartData1(5) As String

            If type = "data" Then
                If myDataset.Tables(0).Rows.Count = 0 Then
                Else
                    For I = 0 To myDataset.Tables(0).Rows.Count - 1
                        arrChartData1(I) = Int(Val(myDataset.Tables(0).Rows(I)(3).ToString)) & "," & Int(Val(myDataset.Tables(0).Rows(I)(4).ToString))
                        myChart.ChartData = arrChartData1
                    Next
                End If

            ElseIf type = "legend" Then
                If myDataset.Tables(0).Rows.Count = 0 Then
                Else
                    For I = 0 To myDataset.Tables(0).Rows.Count - 1
                        arrChartData1(I) = myDataset.Tables(0).Rows(I)(2).ToString

                        myChart.ChartData = arrChartData1
                    Next
                End If

            End If
            Return myChart.ChartData
        End Function
#End Region
#Region "Average Benchmark Score Per Critical Element Category (All School Types) (Chart id - 38_0)"
        ''-------------------------------------------------------------------------------------------------------------------
        '' Function Name : fngtAvgBScPerCritEleAllSchType  
        '' Created By : Aditi Deodhar
        '' Created Dt : May 07,2010
        '' Last Updated Dt : May 07,2010
        '' Description : Average Benchmark Score Per Critical Element Category (All School Types)
        '-------------------------------------------------------------------------------------------------------------------
        Shared Function fngtAvgBScPerCritEleAllSchType(ByVal distid As String, ByVal type As String) As String()
            Dim oRequest As New URDALRequest
            Dim oFactory As URDALAbsDBFactory
            Dim myDataset As New DataSet

            Dim myChart As New C21MIT.PBSIS.BO.ChartInfoset

            oFactory = New URDALSQLFactory

            With oRequest
                .Command = "dbo.flpbs_dlr_endyear_distavgboqperce_all"
                .CommandType = CommandType.StoredProcedure
            End With

            'Input data
            oRequest.AddParameter("@p_districtid", distid, URDALRequest.myDataType.dtChar, 2, ParameterDirection.Input)

            Try
                myDataset = oFactory.ExecuteDataSet(oRequest).ReturnedDataSet

                If Not IsNothing(oRequest.Exception) Then
                    Throw New ApplicationException("sqlexception", oRequest.Exception)
                End If

            Catch ex As Exception
                Dim objerrLog As New MITErrorHandling.MITErrorHandling("Exception in fngtEndYrDlrPerMGInReadingBySchImp : " & ex.Message)
                objerrLog.logError()
                System.Web.HttpContext.Current.Response.Redirect("~/users/smessages.aspx?qModule=TechErr", False)

            Finally
                oFactory.ConDispose()
            End Try

            Dim I As Integer

            Dim J As Integer = 0
            Dim arrChartData1(5) As String

            If type = "data" Then
                If myDataset.Tables(0).Rows.Count = 0 Then
                Else
                    For I = myDataset.Tables(0).Rows.Count - 3 To myDataset.Tables(0).Rows.Count - 1
                        If I = -1 Then

                            arrChartData1(J) = Int(Val(myDataset.Tables(0).Rows(I + 1)(4).ToString)) & "," & Int(Val(myDataset.Tables(0).Rows(I + 1)(5).ToString)) & _
                                  "," & Int(Val(myDataset.Tables(0).Rows(I + 1)(6).ToString)) & "," & Int(Val(myDataset.Tables(0).Rows(I + 1)(7).ToString)) & _
                                  "," & Int(Val(myDataset.Tables(0).Rows(I + 1)(8).ToString)) & "," & Int(Val(myDataset.Tables(0).Rows(I + 1)(9).ToString)) & _
                                  "," & Int(Val(myDataset.Tables(0).Rows(I + 1)(10).ToString)) & "," & Int(Val(myDataset.Tables(0).Rows(I + 1)(11).ToString)) & _
                                  "," & Int(Val(myDataset.Tables(0).Rows(I + 1)(12).ToString)) & "," & Int(Val(myDataset.Tables(0).Rows(I + 1)(13).ToString)) & _
                                  "," & Int(Val(myDataset.Tables(0).Rows(I + 1)(14).ToString)) & "," & Int(Val(myDataset.Tables(0).Rows(I + 1)(15).ToString))


                        Else
                            arrChartData1(J) = Int(Val(myDataset.Tables(0).Rows(I)(4).ToString)) & "," & Int(Val(myDataset.Tables(0).Rows(I)(5).ToString)) & _
                               "," & Int(Val(myDataset.Tables(0).Rows(I)(6).ToString)) & "," & Int(Val(myDataset.Tables(0).Rows(I)(7).ToString)) & _
                               "," & Int(Val(myDataset.Tables(0).Rows(I)(8).ToString)) & "," & Int(Val(myDataset.Tables(0).Rows(I)(9).ToString)) & _
                               "," & Int(Val(myDataset.Tables(0).Rows(I)(10).ToString)) & "," & Int(Val(myDataset.Tables(0).Rows(I)(11).ToString)) & _
                               "," & Int(Val(myDataset.Tables(0).Rows(I)(12).ToString)) & "," & Int(Val(myDataset.Tables(0).Rows(I)(13).ToString)) & _
                               "," & Int(Val(myDataset.Tables(0).Rows(I)(14).ToString)) & "," & Int(Val(myDataset.Tables(0).Rows(I)(15).ToString))

                        End If
                        myChart.ChartData = arrChartData1
                        J = J + 1
                    Next

                End If

            ElseIf type = "legend" Then
                If myDataset.Tables(0).Rows.Count = 0 Then
                Else
                    For I = myDataset.Tables(0).Rows.Count - 3 To myDataset.Tables(0).Rows.Count - 1
                        arrChartData1(J) = myDataset.Tables(0).Rows(I)(2).ToString

                        myChart.ChartData = arrChartData1

                        J = J + 1
                    Next
                End If

            End If
            Return myChart.ChartData
        End Function
#End Region
#Region "Schools Trained in PBS : Inactive/Active (Chart id - 39_0)"
        ''-------------------------------------------------------------------------------------------------------------------
        '' Function Name : fngtSchTrInPBSAcInact  
        '' Created By : Aditi Deodhar
        '' Created Dt : May 07,2010
        '' Last Updated Dt : May 07,2010
        '' Description : Schools Trained in PBS : Inactive/Active
        '-------------------------------------------------------------------------------------------------------------------
        Shared Function fngtSchTrInPBSAcInact(ByVal distid As String, ByVal type As String) As String()
            Dim oRequest As New URDALRequest
            Dim oFactory As URDALAbsDBFactory
            Dim myDataset As New DataSet
            Dim myChart As New C21MIT.PBSIS.BO.ChartInfoset

            oFactory = New URDALSQLFactory

            With oRequest
                .Command = "dbo.flpbs_dlr_endyear_distactinact"
                .CommandType = CommandType.StoredProcedure
            End With

            'Input data
            oRequest.AddParameter("@p_districtid", distid, URDALRequest.myDataType.dtChar, 2, ParameterDirection.Input)
            Try
                myDataset = oFactory.ExecuteDataSet(oRequest).ReturnedDataSet

                If Not IsNothing(oRequest.Exception) Then
                    Throw New ApplicationException("sqlexception", oRequest.Exception)
                End If

            Catch ex As Exception
                Dim objerrLog As New MITErrorHandling.MITErrorHandling("Exception in fngtEndYrDlrPerMGInReadingBySchImp : " & ex.Message)
                objerrLog.logError()
                System.Web.HttpContext.Current.Response.Redirect("~/users/smessages.aspx?qModule=TechErr", False)

            Finally
                oFactory.ConDispose()
            End Try

            Dim I As Integer

            Dim arrChartData1(5) As String

            If type = "data" Then
                If myDataset.Tables(0).Rows.Count = 0 Then
                Else
                    arrChartData1(0) = Int(Val(myDataset.Tables(0).Rows(I)(2).ToString))
                    arrChartData1(1) = Int(Val(myDataset.Tables(0).Rows(I)(3).ToString))

                    myChart.ChartData = arrChartData1
                End If
            ElseIf type = "XAxisTitle" Then
                If myDataset.Tables(0).Rows.Count = 0 Then
                Else
                    For I = 0 To myDataset.Tables(0).Rows.Count - 1
                        arrChartData1(I) = myDataset.Tables(0).Rows(I)(1).ToString

                        myChart.ChartData = arrChartData1
                    Next
                End If
            End If
            Return myChart.ChartData
        End Function
#End Region
#Region "Average ODR per 100 Students for Lower and Higher Implementing Schools (Grouped by School Type) (Chart id - 40_0)"
        ''-------------------------------------------------------------------------------------------------------------------
        '' Function Name : fngtAvgODRP100StuImplLev  
        '' Created By : Aditi Deodhar
        '' Created Dt : May 10,2010
        '' Last Updated Dt : May 10,2010
        '' Description : Average ODR per 100 Students for Lower and Higher Implementing Schools (Grouped by School Type)
        '-------------------------------------------------------------------------------------------------------------------
        Shared Function fngtAvgODRP100StuImplLev(ByVal distid As String, ByVal schtype As Integer, ByVal type As String) As String()
            Dim oRequest As New URDALRequest
            Dim oFactory As URDALAbsDBFactory
            Dim myDataset As New DataSet

            Dim myChart As New C21MIT.PBSIS.BO.ChartInfoset

            oFactory = New URDALSQLFactory

            With oRequest
                .Command = "dbo.flpbs_dlr_endyear_distavgodrper100byschtype"
                .CommandType = CommandType.StoredProcedure
            End With

            'Input data
            oRequest.AddParameter("@p_districtid", distid, URDALRequest.myDataType.dtChar, 2, ParameterDirection.Input)
            oRequest.AddParameter("@p_schooltype", schtype, URDALRequest.myDataType.dtChar, 2, ParameterDirection.Input)

            Try
                myDataset = oFactory.ExecuteDataSet(oRequest).ReturnedDataSet

                If Not IsNothing(oRequest.Exception) Then
                    Throw New ApplicationException("sqlexception", oRequest.Exception)
                End If

            Catch ex As Exception
                Dim objerrLog As New MITErrorHandling.MITErrorHandling("Exception in fngtEndYrDlrPerMGInReadingBySchImp : " & ex.Message)
                objerrLog.logError()
                System.Web.HttpContext.Current.Response.Redirect("~/users/smessages.aspx?qModule=TechErr", False)

            Finally
                oFactory.ConDispose()
            End Try

            Dim I As Integer
            Dim arrChartData1(5) As String

            If type = "data" Then
                If myDataset.Tables(0).Rows.Count = 0 Then
                Else
                    For I = 0 To myDataset.Tables(0).Rows.Count - 1
                        arrChartData1(I) = Int(Val(myDataset.Tables(0).Rows(I)(4).ToString)) & "," & Int(Val(myDataset.Tables(0).Rows(I)(6).ToString))

                        myChart.ChartData = arrChartData1
                    Next
                End If

            ElseIf type = "legend" Then
                If myDataset.Tables(0).Rows.Count = 0 Then
                Else
                    For I = 0 To myDataset.Tables(0).Rows.Count - 1
                        arrChartData1(I) = myDataset.Tables(0).Rows(I)(2).ToString

                        myChart.ChartData = arrChartData1
                    Next
                End If

            End If
            Return myChart.ChartData
        End Function
#End Region
#Region "Average Benchmark Score Per Critical Element Category (Grouped by School Type) (Chart id - 41_0)"
        ''-------------------------------------------------------------------------------------------------------------------
        '' Function Name : fngtAvgBScPCEleCat  
        '' Created By : Aditi Deodhar
        '' Created Dt : May 10,2010
        '' Last Updated Dt : May 10,2010
        '' Description : Average Benchmark Score Per Critical Element Category (Grouped by School Type)
        '-------------------------------------------------------------------------------------------------------------------
        Shared Function fngtAvgBScPCEleCat(ByVal distid As String, ByVal schtype As Integer, ByVal type As String) As String()
            Dim oRequest As New URDALRequest
            Dim oFactory As URDALAbsDBFactory
            Dim myDataset As New DataSet

            Dim myChart As New C21MIT.PBSIS.BO.ChartInfoset

            oFactory = New URDALSQLFactory

            With oRequest
                .Command = "dbo.flpbs_dlr_endyear_distavgboqperce_schtype"
                .CommandType = CommandType.StoredProcedure
            End With

            'Input data
            oRequest.AddParameter("@p_districtid", distid, URDALRequest.myDataType.dtChar, 2, ParameterDirection.Input)
            oRequest.AddParameter("@p_schooltype", schtype, URDALRequest.myDataType.dtChar, 2, ParameterDirection.Input)

            Try
                myDataset = oFactory.ExecuteDataSet(oRequest).ReturnedDataSet

                If Not IsNothing(oRequest.Exception) Then
                    Throw New ApplicationException("sqlexception", oRequest.Exception)
                End If

            Catch ex As Exception
                Dim objerrLog As New MITErrorHandling.MITErrorHandling("Exception in fngtEndYrDlrPerMGInReadingBySchImp : " & ex.Message)
                objerrLog.logError()
                System.Web.HttpContext.Current.Response.Redirect("~/users/smessages.aspx?qModule=TechErr", False)

            Finally
                oFactory.ConDispose()
            End Try

            Dim I As Integer
            Dim J As Integer = 0
            Dim arrChartData1(5) As String

            If type = "data" Then
                If myDataset.Tables(0).Rows.Count = 0 Then
                Else
                    For I = myDataset.Tables(0).Rows.Count - 3 To myDataset.Tables(0).Rows.Count - 1


                        If I = -1 Then
                            arrChartData1(J) = Int(Val(myDataset.Tables(0).Rows(I + 1)(5).ToString)) & _
                              "," & Int(Val(myDataset.Tables(0).Rows(I + 1)(6).ToString)) & "," & Int(Val(myDataset.Tables(0).Rows(I + 1)(7).ToString)) & _
                              "," & Int(Val(myDataset.Tables(0).Rows(I + 1)(8).ToString)) & "," & Int(Val(myDataset.Tables(0).Rows(I + 1)(9).ToString)) & _
                              "," & Int(Val(myDataset.Tables(0).Rows(I + 1)(10).ToString)) & "," & Int(Val(myDataset.Tables(0).Rows(I + 1)(11).ToString)) & _
                              "," & Int(Val(myDataset.Tables(0).Rows(I + 1)(12).ToString)) & "," & Int(Val(myDataset.Tables(0).Rows(I + 1)(13).ToString)) & _
                              "," & Int(Val(myDataset.Tables(0).Rows(I + 1)(14).ToString)) & "," & Int(Val(myDataset.Tables(0).Rows(I + 1)(15).ToString)) & _
                              "," & Int(Val(myDataset.Tables(0).Rows(I + 1)(16).ToString))

                        Else
                            arrChartData1(J) = Int(Val(myDataset.Tables(0).Rows(I)(5).ToString)) & _
                                      "," & Int(Val(myDataset.Tables(0).Rows(I)(6).ToString)) & "," & Int(Val(myDataset.Tables(0).Rows(I)(7).ToString)) & _
                                      "," & Int(Val(myDataset.Tables(0).Rows(I)(8).ToString)) & "," & Int(Val(myDataset.Tables(0).Rows(I)(9).ToString)) & _
                                      "," & Int(Val(myDataset.Tables(0).Rows(I)(10).ToString)) & "," & Int(Val(myDataset.Tables(0).Rows(I)(11).ToString)) & _
                                      "," & Int(Val(myDataset.Tables(0).Rows(I)(12).ToString)) & "," & Int(Val(myDataset.Tables(0).Rows(I)(13).ToString)) & _
                                      "," & Int(Val(myDataset.Tables(0).Rows(I)(14).ToString)) & "," & Int(Val(myDataset.Tables(0).Rows(I)(15).ToString)) & _
                                      "," & Int(Val(myDataset.Tables(0).Rows(I)(16).ToString))


                            myChart.ChartData = arrChartData1
                            J = J + 1
                        End If
                    Next
                End If

            ElseIf type = "legend" Then
                If myDataset.Tables(0).Rows.Count = 0 Then
                Else

                    For I = myDataset.Tables(0).Rows.Count - 3 To myDataset.Tables(0).Rows.Count - 1


                        If I = -1 Then
                            arrChartData1(J) = myDataset.Tables(0).Rows(I + 1)(2).ToString

                        Else
                         arrChartData1(J) = myDataset.Tables(0).Rows(I)(2).ToString


                            myChart.ChartData = arrChartData1
                            J = J + 1
                        End If
                    Next
                    
                   
                End If

               
            End If


            Return myChart.ChartData
        End Function
#End Region
#Region "Annual B.A.T. Subsection Report (Chart id - 44_0)"
        ''-------------------------------------------------------------------------------------------------------------------
        '' Function Name : fngtAllSchBATSubsectionRep  
        '' Created By : Aditi Deodhar
        '' Created Dt : May 24,2010
        '' Last Updated Dt : May 24,2010
        '' Description : Annual B.A.T. Subsection Report
        '-------------------------------------------------------------------------------------------------------------------
        Shared Function fngtAllSchBATSubsectionRep(ByVal distid As String, ByVal schyr As Integer, ByVal type As String) As String()
            Dim oRequest As New URDALRequest
            Dim oFactory As URDALAbsDBFactory
            Dim myDataset As New DataSet

            Dim myChart As New C21MIT.PBSIS.BO.ChartInfoset

            oFactory = New URDALSQLFactory

            With oRequest
                .Command = "dbo.flpbs_dlr_endyear_AvgBatCEScr"
                .CommandType = CommandType.StoredProcedure
            End With

            'Input data
            oRequest.AddParameter("@p_districtid", distid, URDALRequest.myDataType.dtChar, 2, ParameterDirection.Input)
            oRequest.AddParameter("@p_schoolyear", schyr, URDALRequest.myDataType.dtTinyInt, , ParameterDirection.Input)
            Try
                myDataset = oFactory.ExecuteDataSet(oRequest).ReturnedDataSet

                If Not IsNothing(oRequest.Exception) Then
                    Throw New ApplicationException("sqlexception", oRequest.Exception)
                End If

            Catch ex As Exception
                Dim objerrLog As New MITErrorHandling.MITErrorHandling("Exception in fngtEndYrDlrPerMGInReadingBySchImp : " & ex.Message)
                objerrLog.logError()
                System.Web.HttpContext.Current.Response.Redirect("~/users/smessages.aspx?qModule=TechErr", False)

            Finally
                oFactory.ConDispose()
            End Try

            Dim I As Integer
            Dim arrChartData1(5) As String

            If type = "data" Then
                If myDataset.Tables(0).Rows.Count = 0 Then
                Else

                    Dim strzero As Integer = 0
                    Dim strList1(3) As String
                   
                    For I = 0 To myDataset.Tables(0).Rows.Count - 1
                        strList1(0) = Int(Math.Round(myDataset.Tables(0).Rows(I)(2))) & _
                                  "," & Int(Math.Round(myDataset.Tables(0).Rows(I)(3))) & "," & Int(Math.Round(myDataset.Tables(0).Rows(I)(4))) & _
                                      "," & Int(Math.Round(myDataset.Tables(0).Rows(I)(5))) & "," & strzero.ToString & "," & strzero.ToString & "," & strzero.ToString & "," & strzero.ToString & "," & strzero.ToString & "," & strzero.ToString
                        strList1(1) = strzero.ToString & "," & strzero.ToString & "," & strzero.ToString & "," & strzero.ToString & "," & Int(Math.Round(myDataset.Tables(0).Rows(I)(6))) & "," & Int(Math.Round(myDataset.Tables(0).Rows(I)(7))) & "," & Int(Math.Round(myDataset.Tables(0).Rows(I)(8))) & "," & strzero.ToString & "," & strzero.ToString & "," & strzero.ToString
                        strList1(2) = strzero.ToString & "," & strzero.ToString & "," & strzero.ToString & "," & strzero.ToString & "," & strzero.ToString & "," & strzero.ToString & "," & strzero.ToString & "," & Int(Math.Round(myDataset.Tables(0).Rows(I)(9))) & "," & Int(Math.Round(myDataset.Tables(0).Rows(I)(10))) & _
                                  "," & Int(Math.Round(myDataset.Tables(0).Rows(I)(11)))

                        arrChartData1(0) = strList1(0)
                        arrChartData1(1) = strList1(1)
                        arrChartData1(2) = strList1(2)
                        myChart.ChartData = arrChartData1

                    Next

                    'For I = 0 To myDataset.Tables(0).Rows.Count - 1
                    '    arrChartData1(I) = Int(Val(myDataset.Tables(0).Rows(I)(2).ToString)) & _
                    '              "," & Int(Val(myDataset.Tables(0).Rows(I)(3).ToString)) & "," & Int(Val(myDataset.Tables(0).Rows(I)(4).ToString)) & _
                    '              "," & Int(Val(myDataset.Tables(0).Rows(I)(5).ToString)) & "," & Int(Val(myDataset.Tables(0).Rows(I)(6).ToString)) & _
                    '              "," & Int(Val(myDataset.Tables(0).Rows(I)(7).ToString)) & "," & Int(Val(myDataset.Tables(0).Rows(I)(8).ToString)) & _
                    '              "," & Int(Val(myDataset.Tables(0).Rows(I)(9).ToString)) & "," & Int(Val(myDataset.Tables(0).Rows(I)(10).ToString)) & _
                    '              "," & Int(Val(myDataset.Tables(0).Rows(I)(11).ToString))


                    '    myChart.ChartData = arrChartData1
                    ' Next
                End If
            End If

            Return myChart.ChartData
        End Function
#End Region
#Region "Multi-Year B.A.T. Report (Chart id - 45_0)"
        ''-------------------------------------------------------------------------------------------------------------------
        '' Function Name : fngtAllSchMultiBATRep  
        '' Created By : Aditi Deodhar
        '' Created Dt : May 24,2010
        '' Last Updated Dt : May 24,2010
        '' Description : Multi-Year B.A.T. Report
        '-------------------------------------------------------------------------------------------------------------------
        Shared Function fngtAllSchMultiBATRep(ByVal distid As String, ByVal type As String) As String()
            Dim oRequest As New URDALRequest
            Dim oFactory As URDALAbsDBFactory
            Dim myDataset As New DataSet

            Dim myChart As New C21MIT.PBSIS.BO.ChartInfoset

            oFactory = New URDALSQLFactory

            With oRequest
                .Command = "dbo.flpbs_dlr_endyear_avgbatsummscr"
                .CommandType = CommandType.StoredProcedure
            End With

            'Input data
            oRequest.AddParameter("@p_districtid", distid, URDALRequest.myDataType.dtChar, 2, ParameterDirection.Input)

            Try
                myDataset = oFactory.ExecuteDataSet(oRequest).ReturnedDataSet

                If Not IsNothing(oRequest.Exception) Then
                    Throw New ApplicationException("sqlexception", oRequest.Exception)
                End If

            Catch ex As Exception
                Dim objerrLog As New MITErrorHandling.MITErrorHandling("Exception in fngtEndYrDlrPerMGInReadingBySchImp : " & ex.Message)
                objerrLog.logError()
                System.Web.HttpContext.Current.Response.Redirect("~/users/smessages.aspx?qModule=TechErr", False)

            Finally
                oFactory.ConDispose()
            End Try

            Dim I As Integer
            Dim arrChartData1(5) As String

            If type = "data" Then
                If myDataset.Tables(0).Rows.Count = 0 Then
                Else

                    Dim strList1 As String = ""
                    Dim strList2 As String = ""
                    Dim strList3 As String = ""
                    For I = 0 To myDataset.Tables(0).Rows.Count - 1
                        strList1 = strList1 & "," & Int(Math.Round(myDataset.Tables(0).Rows(I)(2)))
                        strList2 = strList2 & "," & Int(Math.Round(myDataset.Tables(0).Rows(I)(3)))
                        strList3 = strList3 & "," & Int(Math.Round(myDataset.Tables(0).Rows(I)(4)))
                    Next

                    strList1 = strList1.Remove(0, 1)
                    strList2 = strList2.Remove(0, 1)
                    strList3 = strList3.Remove(0, 1)

                    arrChartData1(0) = strList1
                    arrChartData1(1) = strList2
                    arrChartData1(2) = strList3

                    myChart.ChartData = arrChartData1
                End If

            ElseIf type = "legend" Then
                If myDataset.Tables(0).Rows.Count = 0 Then
                Else
                    For I = 0 To myDataset.Tables(0).Rows.Count - 1
                        arrChartData1(I) = myDataset.Tables(0).Rows(I)(2).ToString

                        myChart.ChartData = arrChartData1
                    Next
                End If
            ElseIf type = "XAxisTitle" Then
                If myDataset.Tables(0).Rows.Count = 0 Then
                Else
                    For I = 0 To myDataset.Tables(0).Rows.Count - 1
                        arrChartData1(I) = myDataset.Tables(0).Rows(I)(1).ToString

                        myChart.ChartData = arrChartData1
                    Next
                End If
            End If

            Return myChart.ChartData
        End Function
#End Region
#Region "Annual B.A.T. Subsection Report (Grouped by School Type) (Chart id - 46_0)"
        ''-------------------------------------------------------------------------------------------------------------------
        '' Function Name : fngtSchBATBySchTypeSubsectionRep  
        '' Created By : Aditi Deodhar
        '' Created Dt : May 24,2010
        '' Last Updated Dt : May 24,2010
        '' Description : Annual B.A.T. Subsection Report (Grouped by School Type)
        '-------------------------------------------------------------------------------------------------------------------
        Shared Function fngtSchBATBySchTypeSubsectionRep(ByVal distid As String, ByVal schyr As Integer, ByVal schType As Integer, ByVal type As String) As String()
            Dim oRequest As New URDALRequest
            Dim oFactory As URDALAbsDBFactory
            Dim myDataset As New DataSet

            Dim myChart As New C21MIT.PBSIS.BO.ChartInfoset

            oFactory = New URDALSQLFactory

            With oRequest
                .Command = "dbo.flpbs_dlr_endyear_AvgBatCEScrSchooltype"
                .CommandType = CommandType.StoredProcedure
            End With

            'Input data
            oRequest.AddParameter("@p_districtid", distid, URDALRequest.myDataType.dtChar, 2, ParameterDirection.Input)
            oRequest.AddParameter("@p_schooltype", schType, URDALRequest.myDataType.dtChar, 2, ParameterDirection.Input)
            oRequest.AddParameter("@p_schoolyear", schyr, URDALRequest.myDataType.dtTinyInt, , ParameterDirection.Input)

            Try
                myDataset = oFactory.ExecuteDataSet(oRequest).ReturnedDataSet

                If Not IsNothing(oRequest.Exception) Then
                    Throw New ApplicationException("sqlexception", oRequest.Exception)
                End If

            Catch ex As Exception
                Dim objerrLog As New MITErrorHandling.MITErrorHandling("Exception in fngtEndYrDlrPerMGInReadingBySchImp : " & ex.Message)
                objerrLog.logError()
                System.Web.HttpContext.Current.Response.Redirect("~/users/smessages.aspx?qModule=TechErr", False)

            Finally
                oFactory.ConDispose()
            End Try

            Dim I As Integer
            Dim arrChartData1(5) As String

            If type = "data" Then
                If myDataset.Tables(0).Rows.Count = 0 Then
                Else

                    Dim strzero As Integer = 0
                    Dim strList1(3) As String
                   
                    For I = 0 To myDataset.Tables(0).Rows.Count - 1
                        strList1(0) = Int(Math.Round(myDataset.Tables(0).Rows(I)(2))) & _
                                  "," & Int(Math.Round(myDataset.Tables(0).Rows(I)(3))) & "," & Int(Math.Round(myDataset.Tables(0).Rows(I)(4))) & _
                                      "," & Int(Math.Round(myDataset.Tables(0).Rows(I)(5))) & "," & strzero.ToString & "," & strzero.ToString & "," & strzero.ToString & "," & strzero.ToString & "," & strzero.ToString & "," & strzero.ToString
                        strList1(1) = strzero.ToString & "," & strzero.ToString & "," & strzero.ToString & "," & strzero.ToString & "," & Int(Math.Round(myDataset.Tables(0).Rows(I)(6))) & "," & Int(Math.Round(myDataset.Tables(0).Rows(I)(7))) & "," & Int(Math.Round(myDataset.Tables(0).Rows(I)(8))) & "," & strzero.ToString & "," & strzero.ToString & "," & strzero.ToString
                        strList1(2) = strzero.ToString & "," & strzero.ToString & "," & strzero.ToString & "," & strzero.ToString & "," & strzero.ToString & "," & strzero.ToString & "," & strzero.ToString & "," & Int(Math.Round(myDataset.Tables(0).Rows(I)(9))) & "," & Int(Math.Round(myDataset.Tables(0).Rows(I)(10))) & _
                                  "," & Int(Math.Round(myDataset.Tables(0).Rows(I)(11)))

                        arrChartData1(0) = strList1(0)
                        arrChartData1(1) = strList1(1)
                        arrChartData1(2) = strList1(2)
                        myChart.ChartData = arrChartData1

                    Next

                End If
            End If

            Return myChart.ChartData
        End Function
#End Region
#Region "Multi-Year B.A.T. Report (Grouped by School Type) (Chart id - 47_0)"
        ''-------------------------------------------------------------------------------------------------------------------
        '' Function Name : fngtSchMultiBATBySchTypeRep  
        '' Created By : Aditi Deodhar
        '' Created Dt : May 24,2010
        '' Last Updated Dt : May 24,2010
        '' Description : Multi-Year B.A.T. Report (Grouped by School Type)
        '-------------------------------------------------------------------------------------------------------------------
        Shared Function fngtSchMultiBATBySchTypeRep(ByVal distid As String, ByVal schType As Integer, ByVal type As String) As String()
            Dim oRequest As New URDALRequest
            Dim oFactory As URDALAbsDBFactory
            Dim myDataset As New DataSet

            Dim myChart As New C21MIT.PBSIS.BO.ChartInfoset

            oFactory = New URDALSQLFactory

            With oRequest
                .Command = "dbo.flpbs_dlr_endyear_avgbatsummscrSchooltype"
                .CommandType = CommandType.StoredProcedure
            End With

            oRequest.AddParameter("@p_districtid", distid, URDALRequest.myDataType.dtChar, 2, ParameterDirection.Input)
            oRequest.AddParameter("@p_schooltype", schType, URDALRequest.myDataType.dtChar, 2, ParameterDirection.Input)

            Try
                myDataset = oFactory.ExecuteDataSet(oRequest).ReturnedDataSet

                If Not IsNothing(oRequest.Exception) Then
                    Throw New ApplicationException("sqlexception", oRequest.Exception)
                End If

            Catch ex As Exception
                Dim objerrLog As New MITErrorHandling.MITErrorHandling("Exception in fngtEndYrDlrPerMGInReadingBySchImp : " & ex.Message)
                objerrLog.logError()
                System.Web.HttpContext.Current.Response.Redirect("~/users/smessages.aspx?qModule=TechErr", False)

            Finally
                oFactory.ConDispose()
            End Try

            Dim I As Integer
            Dim arrChartData1(5) As String

            If type = "data" Then
                If myDataset.Tables(0).Rows.Count = 0 Then
                Else

                    Dim strList1 As String = ""
                    Dim strList2 As String = ""
                    Dim strList3 As String = ""
                    For I = 0 To myDataset.Tables(0).Rows.Count - 1
                        strList1 = strList1 & "," & Int(Math.Round(myDataset.Tables(0).Rows(I)(2)))
                        strList2 = strList2 & "," & Int(Math.Round(myDataset.Tables(0).Rows(I)(3)))
                        strList3 = strList3 & "," & Int(Math.Round(myDataset.Tables(0).Rows(I)(4)))
                    Next

                    strList1 = strList1.Remove(0, 1)
                    strList2 = strList2.Remove(0, 1)
                    strList3 = strList3.Remove(0, 1)

                    arrChartData1(0) = strList1
                    arrChartData1(1) = strList2
                    arrChartData1(2) = strList3

                    myChart.ChartData = arrChartData1
                End If
            ElseIf type = "legend" Then
                If myDataset.Tables(0).Rows.Count = 0 Then
                Else
                    For I = 0 To myDataset.Tables(0).Rows.Count - 1
                        arrChartData1(I) = myDataset.Tables(0).Rows(I)(2).ToString

                        myChart.ChartData = arrChartData1
                    Next
                End If
            ElseIf type = "XAxisTitle" Then
                If myDataset.Tables(0).Rows.Count = 0 Then
                Else
                    For I = 0 To myDataset.Tables(0).Rows.Count - 1
                        arrChartData1(I) = myDataset.Tables(0).Rows(I)(1).ToString

                        myChart.ChartData = arrChartData1
                    Next
                End If
            End If

            Return myChart.ChartData
        End Function
#End Region
    End Class
#End Region
End Namespace