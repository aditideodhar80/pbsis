Imports Microsoft.VisualBasic
Namespace C21MIT.PBSIS.BO
    Public Class pbscoachprofile
        Dim _DistId As String
        Dim _DistName As String

        Dim _CoachId As Integer
        Dim _CoachFirstName As String
        Dim _CoachLastName As String

        Dim _CoachPostion As String
        Dim _CoachStreetAddress1 As String
        Dim _CoachStreetAddress2 As String

        Dim _CoachCity As String
        Dim _CoachState As String
        Dim _CoachZip As String
        Dim _CoachEmail As String

        Dim _CoachOfficePhone As String
        Dim _CoachCellPhone As String
        Dim _CoachFax As String

        Dim _CoachYearIniTraining As String
        Dim _CoachInactive As Integer

        Public Sub New()
            _DistId = ""
            _DistName = ""

            _CoachId = 0
            _CoachFirstName = ""
            _CoachLastName = ""

            _CoachPostion = ""
            _CoachStreetAddress1 = ""
            _CoachStreetAddress2 = ""

            _CoachCity = ""
            _CoachState = ""
            _CoachZip = ""
            _CoachEmail = ""

            _CoachOfficePhone = ""
            _CoachCellPhone = ""
            _CoachFax = ""

            _CoachYearIniTraining = ""
            _CoachInactive = 0



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

        Public Property CoachID() As String
            Get
                Return _CoachId
            End Get
            Set(ByVal value As String)
                _CoachId = value
            End Set
        End Property

        Public Property CoachFirstName() As String
            Get
                Return _CoachFirstName
            End Get
            Set(ByVal value As String)
                _CoachFirstName = value
            End Set
        End Property

        Public Property CoachLastName() As String
            Get
                Return _CoachLastName
            End Get
            Set(ByVal value As String)
                _CoachLastName = value
            End Set
        End Property

        Public Property CoachPostion() As String
            Get
                Return _CoachPostion
            End Get
            Set(ByVal value As String)
                _CoachPostion = value
            End Set
        End Property

        Public Property CoachStreetAddress1() As String
            Get
                Return _CoachStreetAddress1
            End Get
            Set(ByVal value As String)
                _CoachStreetAddress1 = value
            End Set
        End Property


        Public Property CoachStreetAddress2() As String
            Get
                Return _CoachStreetAddress2
            End Get
            Set(ByVal value As String)
                _CoachStreetAddress2 = value
            End Set
        End Property

        Public Property CoachCity() As String
            Get
                Return _CoachCity
            End Get
            Set(ByVal value As String)
                _CoachCity = value
            End Set
        End Property

        Public Property CoachState() As String
            Get
                Return _CoachState
            End Get
            Set(ByVal value As String)
                _CoachState = value
            End Set
        End Property

        Public Property CoachZip() As String
            Get
                Return _CoachZip
            End Get
            Set(ByVal value As String)
                _CoachZip = value
            End Set
        End Property

        Public Property CoachEmail() As String
            Get
                Return _CoachEmail
            End Get
            Set(ByVal value As String)
                _CoachEmail = value
            End Set
        End Property

        Public Property CoachOfficePhone() As String
            Get
                Return _CoachOfficePhone
            End Get
            Set(ByVal value As String)
                _CoachOfficePhone = value
            End Set
        End Property

        Public Property CoachCellPhone() As String
            Get
                Return _CoachCellPhone
            End Get
            Set(ByVal value As String)
                _CoachCellPhone = value
            End Set
        End Property

        Public Property CoachFax() As String
            Get
                Return _CoachFax
            End Get
            Set(ByVal value As String)
                _CoachFax = value
            End Set
        End Property

        Public Property CoachInactive() As Integer
            Get
                Return _CoachInactive
            End Get
            Set(ByVal value As Integer)
                _CoachInactive = value
            End Set
        End Property
    End Class
End Namespace