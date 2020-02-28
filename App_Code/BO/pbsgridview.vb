Imports Microsoft.VisualBasic
Namespace C21MIT.PBSIS.BO
    Public Class pbsgridviewobj

        Dim _DistrictID As String
        Dim _DistrictName As String

        Dim _SchoolID As String
        Dim _SchoolName As String

        Dim _AcadYear As Integer
        Dim _PageTitle As String

        Dim _PBSNavObjectListobj As C21MIT.PBSIS.BO.PBSNavObjectList

        Public Sub New()
            _DistrictID = ""
            _DistrictName = ""

            _SchoolID = ""
            _SchoolName = ""

            _AcadYear = 0
            _PageTitle = ""

            _PBSNavObjectListobj = New C21MIT.PBSIS.BO.PBSNavObjectList
        End Sub

        Public Property DistrictID() As String
            Get
                Return _DistrictID
            End Get
            Set(ByVal value As String)
                _DistrictID = value
            End Set
        End Property

        Public Property DistrictName() As String
            Get
                Return _DistrictName
            End Get
            Set(ByVal value As String)
                _DistrictName = value
            End Set
        End Property

        Public Property SchoolID() As String
            Get
                Return _SchoolID
            End Get
            Set(ByVal value As String)
                _SchoolID = value
            End Set
        End Property

        Public Property SchoolName() As String
            Get
                Return _SchoolName
            End Get
            Set(ByVal value As String)
                _SchoolName = value
            End Set
        End Property

        Public Property AcadYear() As Integer
            Get
                Return _AcadYear
            End Get
            Set(ByVal value As Integer)
                _AcadYear = value
            End Set
        End Property

        Public Property PageTitle() As String
            Get
                Return _PageTitle
            End Get
            Set(ByVal value As String)
                _PageTitle = value
            End Set
        End Property

        Public Property PBSGridviewNavObjectListobj() As C21MIT.PBSIS.BO.PBSNavObjectList
            Get
                Return _PBSNavObjectListobj
            End Get
            Set(ByVal value As C21MIT.PBSIS.BO.PBSNavObjectList)
                _PBSNavObjectListobj = value
            End Set
        End Property

        Public Class pbsdistrictpageList
            Inherits System.Collections.Generic.List(Of pbsgridviewobj)

            Public Sub New()

            End Sub
        End Class
    End Class
End Namespace