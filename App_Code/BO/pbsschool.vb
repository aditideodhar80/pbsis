Imports Microsoft.VisualBasic
Namespace C21MIT.PBSIS.BO
    Public Class pbsschoolprofile
        Dim _SchoolId As String
        Dim _SchoolName As String
        Dim _SchoolDistrict As String
        Dim _SchoolStreetAddress1 As String
        Dim _SchoolStreetAddress2 As String
        Dim _SchoolCity As String
        Dim _SchoolState As String
        Dim _SchoolZip As String
        Dim _SchoolPhone As String
        Dim _SchoolFax As String
        Dim _SchoolAdministratorName As String
        Dim _SchoolAdministratorPhone As String
        Dim _SchoolAdministratorEmail As String
        Dim _SchoolType As String
        Dim _SchoolInactive As Integer
        Dim _Baseline_Available As Integer
        Dim _Baseline_Completed As Integer

        Public Sub New()
            _SchoolId = ""
            _SchoolName = ""
            _SchoolDistrict = ""
            _SchoolStreetAddress1 = ""
            _SchoolStreetAddress2 = ""
            _SchoolCity = ""
            _SchoolState = ""
            _SchoolZip = ""
            _SchoolPhone = ""
            _SchoolFax = ""
            _SchoolAdministratorName = ""
            _SchoolAdministratorPhone = ""
            _SchoolAdministratorEmail = ""
            _SchoolType = ""
            _SchoolInactive = 0
            _Baseline_Available = 0
            _Baseline_Completed = 0
        End Sub

        Public Property SchoolId() As String
            Get
                Return _SchoolId
            End Get
            Set(ByVal value As String)
                _SchoolId = value
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

        Public Property SchoolDistrict() As String
            Get
                Return _SchoolDistrict
            End Get
            Set(ByVal value As String)
                _SchoolDistrict = value
            End Set
        End Property

        Public Property SchoolStreetAddress1() As String
            Get
                Return _SchoolStreetAddress1
            End Get
            Set(ByVal value As String)
                _SchoolStreetAddress1 = value
            End Set
        End Property

        Public Property SchoolStreetAddress2() As String
            Get
                Return _SchoolStreetAddress2
            End Get
            Set(ByVal value As String)
                _SchoolStreetAddress2 = value
            End Set
        End Property

        Public Property SchoolCity() As String
            Get
                Return _SchoolCity
            End Get
            Set(ByVal value As String)
                _SchoolCity = value
            End Set
        End Property

        Public Property SchoolState() As String
            Get
                Return _SchoolState
            End Get
            Set(ByVal value As String)
                _SchoolState = value
            End Set
        End Property

        Public Property SchoolZip() As String
            Get
                Return _SchoolZip
            End Get
            Set(ByVal value As String)
                _SchoolZip = value
            End Set
        End Property

        Public Property SchoolPhone() As String
            Get
                Return _SchoolPhone
            End Get
            Set(ByVal value As String)
                _SchoolPhone = value
            End Set
        End Property

        Public Property SchoolFax() As String
            Get
                Return _SchoolFax
            End Get
            Set(ByVal value As String)
                _SchoolFax = value
            End Set
        End Property

        Public Property SchoolAdministratorName() As String
            Get
                Return _SchoolAdministratorName
            End Get
            Set(ByVal value As String)
                _SchoolAdministratorName = value
            End Set
        End Property


        Public Property SchoolAdministratorPhone() As String
            Get
                Return _SchoolAdministratorPhone
            End Get
            Set(ByVal value As String)
                _SchoolAdministratorPhone = value
            End Set
        End Property


        Public Property SchoolAdministratorEmail() As String
            Get
                Return _SchoolAdministratorEmail
            End Get
            Set(ByVal value As String)
                _SchoolAdministratorEmail = value
            End Set
        End Property

        Public Property SchoolType() As String
            Get
                Return _SchoolType
            End Get
            Set(ByVal value As String)
                _SchoolType = value
            End Set
        End Property


        Public Property SchoolInactive() As Integer
            Get
                Return _SchoolInactive
            End Get
            Set(ByVal value As Integer)
                _SchoolInactive = value
            End Set
        End Property

        Public Property Baseline_Available() As Integer
            Get
                Return _Baseline_Available
            End Get
            Set(ByVal value As Integer)
                _Baseline_Available = value
            End Set
        End Property

        Public Property Baseline_Completed() As Integer
            Get
                Return _Baseline_Completed
            End Get
            Set(ByVal value As Integer)
                _Baseline_Completed = value
            End Set
        End Property
    End Class

    Public Class pbsschooldataentrylinks
        Dim _v_schoolid As String
        Dim _v_acadyear As Integer
        Dim _v_schoolname As String
        Dim _v_distname As String

        Dim _v_FinBI As Integer
        Dim _v_FinSchoolProfile As Integer
        Dim _v_FinSchoolDemoData As Integer
        Dim _v_FinSchoolTeamUpdate As Integer
        Dim _v_FinPEVALTAR As Integer
        Dim _v_FinPICFall As Integer
        Dim _v_FinPICSpring As Integer
        Dim _v_FinBOQ As Integer
        Dim _v_FinOutcomeDataSum As Integer
        Dim _v_FinBAT As Integer

        'extra for form activation/deactivation for FMHI

        Dim _v_FinTeamProcessEval As Integer
        ''
        Dim _v_AvailBI As Integer
        Dim _v_AvailSchoolProfile As Integer
        Dim _v_AvailSchoolDemoData As Integer
        Dim _v_AvailSchoolTeamUpdate As Integer
        Dim _v_AvailPEVALTAR As Integer
        Dim _v_AvailPICFall As Integer
        Dim _v_AvailPICSpring As Integer
        Dim _v_AvailBOQ As Integer
        Dim _v_AvailOutcomeDataSum As Integer
        Dim _v_AvailBAT As Integer


        Public Sub New()
            _v_schoolid = ""
            _v_acadyear = 0

            _v_schoolname = ""
            _v_distname = ""

            _v_FinBI = 0
            _v_FinSchoolProfile = 0
            _v_FinSchoolDemoData = 0
            _v_FinSchoolTeamUpdate = 0
            _v_FinPEVALTAR = 0
            _v_FinPICFall = 0
            _v_FinPICSpring = 0
            _v_FinBOQ = 0
            _v_FinOutcomeDataSum = 0
            _v_FinBAT = 0

            '

            _v_FinTeamProcessEval = 0
            ''

            _v_AvailBI = 0
            _v_AvailSchoolProfile = 0
            _v_AvailSchoolDemoData = 0
            _v_AvailSchoolTeamUpdate = 0
            _v_AvailPEVALTAR = 0
            _v_AvailPICFall = 0
            _v_AvailPICSpring = 0
            _v_AvailBOQ = 0
            _v_AvailOutcomeDataSum = 0
            _v_AvailBAT = 0
        End Sub


        Public Property SchoolId() As String
            Get
                Return _v_schoolid
            End Get
            Set(ByVal value As String)
                _v_schoolid = value
            End Set
        End Property


        Public Property AcadYear() As Integer
            Get
                Return _v_acadyear
            End Get
            Set(ByVal value As Integer)
                _v_acadyear = value
            End Set
        End Property

        Public Property SchoolName() As String
            Get
                Return _v_schoolname
            End Get
            Set(ByVal value As String)
                _v_schoolname = value
            End Set
        End Property

        Public Property DistName() As String
            Get
                Return _v_distname
            End Get
            Set(ByVal value As String)
                _v_distname = value
            End Set
        End Property

        Public Property FinBI() As Integer
            Get
                Return _v_FinBI
            End Get
            Set(ByVal value As Integer)
                _v_FinBI = value
            End Set
        End Property

        Public Property FinSchoolProfile() As Integer
            Get
                Return _v_FinSchoolProfile
            End Get
            Set(ByVal value As Integer)
                _v_FinSchoolProfile = value
            End Set
        End Property

        Public Property FinSchoolDemoData() As Integer
            Get
                Return _v_FinSchoolDemoData
            End Get
            Set(ByVal value As Integer)
                _v_FinSchoolDemoData = value
            End Set
        End Property

        Public Property FinSchoolTeamUpdate() As Integer
            Get
                Return _v_FinSchoolTeamUpdate
            End Get
            Set(ByVal value As Integer)
                _v_FinSchoolTeamUpdate = value
            End Set
        End Property

        Public Property FinPEVALTAR() As Integer
            Get
                Return _v_FinPEVALTAR
            End Get
            Set(ByVal value As Integer)
                _v_FinPEVALTAR = value
            End Set
        End Property

        Public Property FinPICFall() As Integer
            Get
                Return _v_FinPICFall
            End Get
            Set(ByVal value As Integer)
                _v_FinPICFall = value
            End Set
        End Property

        Public Property FinPICSpring() As Integer
            Get
                Return _v_FinPICSpring
            End Get
            Set(ByVal value As Integer)
                _v_FinPICSpring = value
            End Set
        End Property

        Public Property FinBOQ() As Integer
            Get
                Return _v_FinBOQ
            End Get
            Set(ByVal value As Integer)
                _v_FinBOQ = value
            End Set
        End Property

        Public Property FinOutcomeDataSum() As Integer
            Get
                Return _v_FinOutcomeDataSum
            End Get
            Set(ByVal value As Integer)
                _v_FinOutcomeDataSum = value
            End Set
        End Property


        Public Property FinBAT() As Integer
            Get
                Return _v_FinBAT
            End Get
            Set(ByVal value As Integer)
                _v_FinBAT = value
            End Set
        End Property


        Public Property FinTeamProcessEval() As Integer
            Get
                Return _v_FinTeamProcessEval
            End Get
            Set(ByVal value As Integer)
                _v_FinTeamProcessEval = value
            End Set
        End Property

        Public Property AvailBI() As Integer
            Get
                Return _v_AvailBI
            End Get
            Set(ByVal value As Integer)
                _v_AvailBI = value
            End Set
        End Property

        Public Property AvailSchoolProfile() As Integer
            Get
                Return _v_AvailSchoolProfile
            End Get
            Set(ByVal value As Integer)
                _v_AvailSchoolProfile = value
            End Set
        End Property

        Public Property AvailSchoolDemoData() As Integer
            Get
                Return _v_AvailSchoolDemoData
            End Get
            Set(ByVal value As Integer)
                _v_AvailSchoolDemoData = value
            End Set
        End Property

        Public Property AvailSchoolTeamUpdate() As Integer
            Get
                Return _v_AvailSchoolTeamUpdate
            End Get
            Set(ByVal value As Integer)
                _v_AvailSchoolTeamUpdate = value
            End Set
        End Property

        Public Property AvailPEVALTAR() As Integer
            Get
                Return _v_AvailPEVALTAR
            End Get
            Set(ByVal value As Integer)
                _v_AvailPEVALTAR = value
            End Set
        End Property

        Public Property AvailPICFall() As Integer
            Get
                Return _v_AvailPICFall
            End Get
            Set(ByVal value As Integer)
                _v_AvailPICFall = value
            End Set
        End Property

        Public Property AvailPICSpring() As Integer
            Get
                Return _v_AvailPICSpring
            End Get
            Set(ByVal value As Integer)
                _v_AvailPICSpring = value
            End Set
        End Property

        Public Property AvailBOQ() As Integer
            Get
                Return _v_AvailBOQ
            End Get
            Set(ByVal value As Integer)
                _v_AvailBOQ = value
            End Set
        End Property

        Public Property AvailOutcomeDataSum() As Integer
            Get
                Return _v_AvailOutcomeDataSum
            End Get
            Set(ByVal value As Integer)
                _v_AvailOutcomeDataSum = value
            End Set
        End Property

        Public Property AvailBAT() As Integer
            Get
                Return _v_AvailBAT
            End Get
            Set(ByVal value As Integer)
                _v_AvailBAT = value
            End Set
        End Property
    End Class
End Namespace