Imports Microsoft.VisualBasic
Namespace C21MIT.PBSIS.Util
    Public Class pbsmessagemanager
        Public Shared Function EPageMessage(ByVal pPageIdentifier As String) As  _
           C21MIT.PBSIS.BO.pbsemessageobj
            Dim myEMessageObj As New C21MIT.PBSIS.BO.pbsemessageobj
            Dim pXMLFilePath As String = System.AppDomain.CurrentDomain.BaseDirectory() & "pbsisresources\pbsmessages.xml"
            Dim xpath As String

            Dim Doc As New System.Xml.XmlDocument()

            If Not pPageIdentifier.Equals("") Then
                xpath = "/ROOT/" & pPageIdentifier.ToString
            Else
                xpath = "/ROOT/NoNode"
            End If

            Dim myNode As System.Xml.XmlNode = C21MIT.PBSIS.Util.parsingoperations.GetXMLNode(xpath, pXMLFilePath)

            myEMessageObj.EPageHeader = myNode.ChildNodes(0).InnerXml
            myEMessageObj.EPageMessage = myNode.ChildNodes(1).InnerXml
            myEMessageObj.LinkVisible = CType(myNode.ChildNodes(2).InnerXml, Boolean)
            myEMessageObj.LinkText = myNode.ChildNodes(3).InnerXml
            myEMessageObj.LinkPath = myNode.ChildNodes(4).InnerXml

            Return myEMessageObj
        End Function
    End Class
End Namespace