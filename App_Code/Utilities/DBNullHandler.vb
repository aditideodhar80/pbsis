Imports Microsoft.VisualBasic


Namespace C21MIT.Util

    Public Class DBNullHandler

        Public Shared Function ToDBNull(ByVal pMyVal As Integer) As String

            If pMyVal.Equals(-1) Then
                Return "Null"
            Else
                Return pMyVal.ToString


            End If

        End Function

        Public Shared Function ToDBNull(ByVal pMyVal As Single) As String

            If pMyVal.Equals(-1) Then
                Return "Null"
            Else
                Return pMyVal.ToString

            End If

        End Function


        Public Shared Function DBNullToZero(ByVal pMyVal As Object) As Integer
            'function returns "0" if the db value is null

            If pMyVal.Equals(System.DBNull.Value) Then
                Return 0
            Else
                Return CType(pMyVal, Integer)
            End If

        End Function

        Public Shared Function DBNullToZeroSingle(ByVal pMyVal As Object) As Single
            'function returns "0" if the db value is null

            If pMyVal.Equals(System.DBNull.Value) Then
                Return 0.0
            Else
                Return CType(pMyVal, Single)
            End If

        End Function

        Public Shared Function DBNullToNegOne(ByVal pMyVal As Object) As Single
            'function returns "-1" if the db value is null


            If pMyVal.Equals(System.DBNull.Value) Then
                Return -1
            Else
                Return CType(pMyVal, Single)
            End If

        End Function


        Public Shared Function DBNullToBlank(ByVal pMyVal As Object) As String
            'function returns an empty string if the db value is null


            If pMyVal.Equals(System.DBNull.Value) Then
                Return ""
            Else

                Return CType(pMyVal, String)
            End If

        End Function

        Public Shared Function BlankToDBSingle(ByVal pMyVal As String) As Single
            If String.IsNullOrEmpty(pMyVal) Then
                Return 0.0
            Else
                Try
                    Return CType(pMyVal, Single)
                Catch ex As Exception
                    Return 0.0
                End Try

            End If
        End Function

        Public Shared Function DBSingleToBlank(ByVal pMyVal As Object) As String
            If CType(pMyVal, Single) = 0.0 Then
                Return ""
            Else
                Return CType(pMyVal, String)
            End If
        End Function

    End Class

End Namespace
