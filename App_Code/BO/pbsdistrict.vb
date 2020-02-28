Imports Microsoft.VisualBasic
Namespace C21MIT.PBSIS.BO
    Public Class pbsdistprofile
        Dim _DistId As String
        Dim _DistName As String

        Dim _DistCoordID As String
        Dim _DistCoordFirstName As String
        Dim _DistCoordLastName As String
        Dim _DistStreetAddress1 As String
        Dim _DistStreetAddress2 As String
        Dim _DistrictCity As String
        Dim _DistrictState As String
        Dim _DistrictZip As String
        Dim _DistrictPhone As String
        Dim _DistrictFax As String
        Dim _DistrictCell As String
        Dim _DistrictCoordEmail As String
        Dim _DistrictPass As String

        Dim _CoordFirstName_2 As String
        Dim _CoordLastName_2 As String
        Dim _StreetAddress1_2 As String
        Dim _StreetAddress2_2 As String
        Dim _DistrictCity_2 As String
        Dim _DistrictState_2 As String
        Dim _DistrictZip_2 As String
        Dim _DistrictPhone_2 As String
        Dim _DistrictFax_2 As String
        Dim _DistrictCell_2 As String
        Dim _DistrictCoordEmail_2 As String
        Dim _DistrictInactive As Integer
        Dim _DistCoordInactive As Integer

        Public Sub New()

            _DistId = ""
            _DistName = ""

            _DistCoordID = ""
            _DistCoordFirstName = ""
            _DistCoordLastName = ""
            _DistStreetAddress1 = ""
            _DistStreetAddress2 = ""
            _DistrictCity = ""
            _DistrictState = ""
            _DistrictZip = ""
            _DistrictPhone = ""
            _DistrictFax = ""
            _DistrictCell = ""
            _DistrictCoordEmail = ""
            _DistrictPass = ""

            _CoordFirstName_2 = ""
            _CoordLastName_2 = ""
            _StreetAddress1_2 = ""
            _StreetAddress2_2 = ""
            _DistrictCity_2 = ""
            _DistrictState_2 = ""
            _DistrictZip_2 = ""
            _DistrictPhone_2 = ""
            _DistrictFax_2 = ""
            _DistrictCell_2 = ""
            _DistrictCoordEmail_2 = ""
            _DistrictInactive = 0

            _DistCoordInactive = 0
        End Sub


        Public Property DistId() As String
            Get
                Return _DistId
            End Get
            Set(ByVal value As String)
                _DistId = value
            End Set
        End Property

        Public Property DistName() As String
            Get
                Return _DistName
            End Get
            Set(ByVal value As String)
                _DistName = value
            End Set
        End Property

        Public Property DistCoordID() As String
            Get
                Return _DistCoordID
            End Get
            Set(ByVal value As String)
                _DistCoordID = value
            End Set
        End Property

        Public Property DistCoordFirstName() As String
            Get
                Return _DistCoordFirstName
            End Get
            Set(ByVal value As String)
                _DistCoordFirstName = value
            End Set
        End Property

        Public Property DistCoordLastName() As String
            Get
                Return _DistCoordLastName
            End Get
            Set(ByVal value As String)
                _DistCoordLastName = value
            End Set
        End Property

        Public Property DistStreetAddress1() As String
            Get
                Return _DistStreetAddress1
            End Get
            Set(ByVal value As String)
                _DistStreetAddress1 = value
            End Set
        End Property

        Public Property DistStreetAddress2() As String
            Get
                Return _DistStreetAddress2
            End Get
            Set(ByVal value As String)
                _DistStreetAddress2 = value
            End Set
        End Property

        Public Property DistrictCity() As String
            Get
                Return _DistrictCity
            End Get
            Set(ByVal value As String)
                _DistrictCity = value
            End Set
        End Property

        Public Property DistrictState() As String
            Get
                Return _DistrictState
            End Get
            Set(ByVal value As String)
                _DistrictState = value
            End Set
        End Property

        Public Property DistrictZip() As String
            Get
                Return _DistrictZip
            End Get
            Set(ByVal value As String)
                _DistrictZip = value
            End Set
        End Property

        Public Property DistrictPhone() As String
            Get
                Return _DistrictPhone
            End Get
            Set(ByVal value As String)
                _DistrictPhone = value
            End Set
        End Property

        Public Property DistrictFax() As String
            Get
                Return _DistrictFax
            End Get
            Set(ByVal value As String)
                _DistrictFax = value
            End Set
        End Property

        Public Property DistrictCell() As String
            Get
                Return _DistrictCell
            End Get
            Set(ByVal value As String)
                _DistrictCell = value
            End Set
        End Property

        Public Property DistrictCoordEmail() As String
            Get
                Return _DistrictCoordEmail
            End Get
            Set(ByVal value As String)
                _DistrictCoordEmail = value
            End Set
        End Property

        Public Property DistrictPass() As String
            Get
                Return _DistrictPass
            End Get
            Set(ByVal value As String)
                _DistrictPass = value
            End Set
        End Property

        Public Property CoordFirstName_2() As String
            Get
                Return _CoordFirstName_2
            End Get
            Set(ByVal value As String)
                _CoordFirstName_2 = value
            End Set
        End Property

        Public Property CoordLastName_2() As String
            Get
                Return _CoordLastName_2
            End Get
            Set(ByVal value As String)
                _CoordLastName_2 = value
            End Set
        End Property

        Public Property StreetAddress1_2() As String
            Get
                Return _StreetAddress1_2
            End Get
            Set(ByVal value As String)
                _StreetAddress1_2 = value
            End Set
        End Property

        Public Property StreetAddress2_2() As String
            Get
                Return _StreetAddress2_2
            End Get
            Set(ByVal value As String)
                _StreetAddress2_2 = value
            End Set
        End Property

        Public Property DistrictCity_2() As String
            Get
                Return _DistrictCity_2
            End Get
            Set(ByVal value As String)
                _DistrictCity_2 = value
            End Set
        End Property

        Public Property DistrictState_2() As String
            Get
                Return _DistrictState_2
            End Get
            Set(ByVal value As String)
                _DistrictState_2 = value
            End Set
        End Property

        Public Property DistrictZip_2() As String
            Get
                Return _DistrictZip_2
            End Get
            Set(ByVal value As String)
                _DistrictZip_2 = value
            End Set
        End Property

        Public Property DistrictPhone_2() As String
            Get
                Return _DistrictPhone_2
            End Get
            Set(ByVal value As String)
                _DistrictPhone_2 = value
            End Set
        End Property

        Public Property DistrictFax_2() As String
            Get
                Return _DistrictFax_2
            End Get
            Set(ByVal value As String)
                _DistrictFax_2 = value
            End Set
        End Property

        Public Property DistrictCell_2() As String
            Get
                Return _DistrictCell_2
            End Get
            Set(ByVal value As String)
                _DistrictCell_2 = value
            End Set
        End Property

        Public Property DistrictCoordEmail_2() As String
            Get
                Return _DistrictCoordEmail_2
            End Get
            Set(ByVal value As String)
                _DistrictCoordEmail_2 = value
            End Set
        End Property

        Public Property DistrictInactive() As Integer
            Get
                Return _DistrictInactive
            End Get
            Set(ByVal value As Integer)
                _DistrictInactive = value
            End Set
        End Property

        Public Property DistCoordInactive() As Integer
            Get
                Return _DistCoordInactive
            End Get
            Set(ByVal value As Integer)
                _DistCoordInactive = value
            End Set
        End Property
    End Class

    Public Class pbsmid_yr_dist_reports_main
        Dim _DistrictID As String
        Dim _SchUniPBSTier1 As Integer
        Dim _SchTargGroupTier2 As Integer
        Dim _SchIndPBSTier3 As Integer

        Public Sub New()

            _DistrictID = ""
            _SchUniPBSTier1 = 0
            _SchTargGroupTier2 = 0
            _SchIndPBSTier3 = 0


        End Sub

        Public Property DistrictID() As String
            Get
                Return _DistrictID
            End Get
            Set(ByVal value As String)
                _DistrictID = value
            End Set
        End Property

        Public Property SchUniPBSTier1() As Integer
            Get
                Return _SchUniPBSTier1
            End Get
            Set(ByVal value As Integer)
                _SchUniPBSTier1 = value
            End Set
        End Property

        Public Property SchTargGroupTier2() As Integer
            Get
                Return _SchTargGroupTier2
            End Get
            Set(ByVal value As Integer)
                _SchTargGroupTier2 = value
            End Set
        End Property

        Public Property SchIndPBSTier3() As Integer
            Get
                Return _SchIndPBSTier3
            End Get
            Set(ByVal value As Integer)
                _SchIndPBSTier3 = value
            End Set
        End Property

    End Class

End Namespace