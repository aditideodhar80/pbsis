Imports Microsoft.VisualBasic
Imports System.Data
Namespace C21MIT.PBSIS.DAM
    Public Class pbsods
        Shared Function getODSDocList(ByVal odid As Integer, ByVal SchYr As Integer) As C21MIT.PBSIS.BO.pbsods.ODSDocObjList
            Dim ODSDocList As New C21MIT.PBSIS.BO.pbsods.ODSDocObjList

            Dim myDS As DataSet = C21MIT.PBSIS.DAL.pbsODSSchool.getODSDocs(odid, SchYr)

            Dim myRow As DataRow
            For Each myRow In myDS.Tables(0).Rows
                Dim ODSDocsobj As New C21MIT.PBSIS.BO.pbsods
                ODSDocsobj.OdIdPk = C21MIT.Util.DBNullHandler.DBNullToZero(myRow.Item("OdODSDocId"))
                ODSDocsobj.OdIdOut = C21MIT.Util.DBNullHandler.DBNullToZero(myRow.Item("OdId"))
                ODSDocsobj.ODSDocName = C21MIT.Util.DBNullHandler.DBNullToBlank(myRow.Item("ODSDocName"))
                ODSDocsobj.ODSDocStatus = C21MIT.Util.DBNullHandler.DBNullToZero(myRow.Item("ODSDocStatus"))
                ODSDocsobj.NavigateURL = PBSIS.BLL.ODSDocuments.getDocumentFolderPath(ODSDocsobj.ODSDocName)


                ODSDocList.Add(ODSDocsobj)
            Next
            Return ODSDocList
        End Function
    End Class
End Namespace