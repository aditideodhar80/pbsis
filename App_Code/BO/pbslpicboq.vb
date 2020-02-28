Imports Microsoft.VisualBasic
Namespace C21MIT.PBSIS.BO
    Public Class pbsschoolreport
        Dim _SchoolID As String
        Dim _SchoolYear As String
        Dim _Interval As String
        Dim _SchoolName As String
        Dim _SchoolType As String
        Dim _DistrictName As String
        Dim _CoachId As Integer
        Dim _BOQCoachId As String
        Dim _CoachName As String

        Dim _ScoringMethod As Single
        Dim _InterviewUsed As String
        Dim _Question1 As Single
        Dim _Question2 As Single
        Dim _Question3 As Single
        Dim _Question4 As Single
        Dim _Question5 As Single
        Dim _Question6 As Single
        Dim _Question7 As Single
        Dim _Question8 As Single
        Dim _Question9 As Single
        Dim _Question10 As Single
        Dim _Question11 As Single
        Dim _Question12 As Single
        Dim _Question13 As Single
        Dim _Question14 As Single
        Dim _Question15 As Single
        Dim _Question16 As Single
        Dim _Question17 As Single
        Dim _Question18 As Single
        Dim _Question19 As Single
        Dim _Question20 As Single
        Dim _Question21 As Single
        Dim _Question22 As Single
        Dim _Question23 As Single
        Dim _Question24 As Single
        Dim _Question25 As Single
        Dim _Question26 As Single
        Dim _Question27 As Single
        Dim _Question28 As Single
        Dim _Question29 As Single
        Dim _Question30 As Single
        Dim _Question31 As Single
        Dim _Question32 As Single
        Dim _Question33 As Single
        Dim _Question34 As Single
        Dim _Question35 As Single
        Dim _Question36 As Single
        Dim _Question37 As Single
        Dim _Question38 As Single
        Dim _Question39 As Single
        Dim _Question40 As Single
        Dim _Question41 As Single
        Dim _Question42 As Single
        Dim _Question43 As Single
        Dim _Question44 As Single

        Dim _Question45 As Single
        Dim _Question46 As Single
        Dim _Question47 As Single
        Dim _Question48 As Single
        Dim _Question49 As Single
        Dim _Question50 As Single
        Dim _Question51 As Single
        Dim _Question52 As Single
        Dim _Question53 As Single
        Dim _Question54 As Single
        Dim _Question55 As Single
        Dim _Question56 As Single
        Dim _Question57 As Single
        Dim _Question58 As Single
        Dim _Question59 As Single
        Dim _Question60 As Single

        Dim _TeamLeader As String
        Dim _TeamMember As String






        Public Sub New()
            _SchoolID = ""
            _SchoolYear = ""
            _Interval = ""
            _SchoolName = ""
            _SchoolType = ""
            _DistrictName = ""
            _CoachId = 0
            _BOQCoachId = ""
            _CoachName = ""
            _ScoringMethod = 0
            _InterviewUsed = ""
            _Question1 = 0
            _Question2 = 0
            _Question3 = 0
            _Question4 = 0
            _Question5 = 0
            _Question6 = 0
            _Question7 = 0
            _Question8 = 0
            _Question9 = 0
            _Question10 = 0
            _Question11 = 0
            _Question12 = 0
            _Question13 = 0
            _Question14 = 0
            _Question15 = 0
            _Question16 = 0
            _Question17 = 0
            _Question18 = 0
            _Question19 = 0
            _Question20 = 0
            _Question21 = 0
            _Question22 = 0
            _Question23 = 0
            _Question24 = 0
            _Question25 = 0
            _Question26 = 0
            _Question27 = 0
            _Question28 = 0
            _Question29 = 0
            _Question30 = 0
            _Question31 = 0
            _Question32 = 0
            _Question33 = 0
            _Question34 = 0
            _Question35 = 0
            _Question36 = 0
            _Question37 = 0
            _Question38 = 0
            _Question39 = 0
            _Question40 = 0
            _Question41 = 0
            _Question42 = 0
            _Question43 = 0
            _Question44 = 0

            _Question45 = 0
            _Question46 = 0
            _Question47 = 0
            _Question48 = 0
            _Question49 = 0
            _Question50 = 0
            _Question51 = 0
            _Question52 = 0
            _Question53 = 0
            _Question54 = 0
            _Question55 = 0
            _Question56 = 0
            _Question57 = 0
            _Question58 = 0
            _Question59 = 0
            _Question60 = 0

            _TeamLeader = ""
            _TeamMember = ""

        End Sub

        Public Property SchoolID() As String
            Get
                Return _SchoolID
            End Get
            Set(ByVal value As String)
                _SchoolID = value
            End Set
        End Property

        Public Property SchoolYear() As String
            Get
                Return _SchoolYear
            End Get
            Set(ByVal value As String)
                _SchoolYear = value
            End Set
        End Property

        Public Property Interval() As String
            Get
                Return _Interval
            End Get
            Set(ByVal value As String)
                _Interval = value
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

        Public Property SchoolType() As String
            Get
                Return _SchoolType
            End Get
            Set(ByVal value As String)
                _SchoolType = value
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


        Public Property CoachID() As Integer
            Get
                Return _CoachId
            End Get
            Set(ByVal value As Integer)
                _CoachId = value
            End Set
        End Property

        Public Property BOQCoachID() As String
            Get
                Return _BOQCoachId
            End Get
            Set(ByVal value As String)
                _BOQCoachId = value
            End Set
        End Property

        Public Property CoachName() As String
            Get
                Return _CoachName
            End Get
            Set(ByVal value As String)
                _CoachName = value
            End Set
        End Property


        Public Property ScoringMethod() As Integer
            Get
                Return _ScoringMethod
            End Get
            Set(ByVal value As Integer)
                _ScoringMethod = value
            End Set
        End Property

        Public Property InterviewUsed() As String
            Get
                Return _InterviewUsed
            End Get
            Set(ByVal value As String)
                _InterviewUsed = value
            End Set
        End Property
        Public Property Question1() As Integer
            Get
                Return _Question1
            End Get
            Set(ByVal value As Integer)
                _Question1 = value
            End Set
        End Property

        Public Property Question2() As Integer
            Get
                Return _Question2
            End Get
            Set(ByVal value As Integer)
                _Question2 = value
            End Set
        End Property

        Public Property Question3() As Integer
            Get
                Return _Question3
            End Get
            Set(ByVal value As Integer)
                _Question3 = value
            End Set
        End Property

        Public Property Question4() As Integer
            Get
                Return _Question4
            End Get
            Set(ByVal value As Integer)
                _Question4 = value
            End Set
        End Property

        Public Property Question5() As Integer
            Get
                Return _Question5
            End Get
            Set(ByVal value As Integer)
                _Question5 = value
            End Set
        End Property

        Public Property Question6() As Integer
            Get
                Return _Question6
            End Get
            Set(ByVal value As Integer)
                _Question6 = value
            End Set
        End Property


        Public Property Question7() As Integer
            Get
                Return _Question7
            End Get
            Set(ByVal value As Integer)
                _Question7 = value
            End Set
        End Property


        Public Property Question8() As Integer
            Get
                Return _Question8
            End Get
            Set(ByVal value As Integer)
                _Question8 = value
            End Set
        End Property


        Public Property Question9() As Integer
            Get
                Return _Question9
            End Get
            Set(ByVal value As Integer)
                _Question9 = value
            End Set
        End Property


        Public Property Question10() As Integer
            Get
                Return _Question10
            End Get
            Set(ByVal value As Integer)
                _Question10 = value
            End Set
        End Property

        Public Property Question11() As Integer
            Get
                Return _Question11
            End Get
            Set(ByVal value As Integer)
                _Question11 = value
            End Set
        End Property

        Public Property Question12() As Integer
            Get
                Return _Question12
            End Get
            Set(ByVal value As Integer)
                _Question12 = value
            End Set
        End Property

        Public Property Question13() As Integer
            Get
                Return _Question13
            End Get
            Set(ByVal value As Integer)
                _Question13 = value
            End Set
        End Property

        Public Property Question14() As Integer
            Get
                Return _Question14
            End Get
            Set(ByVal value As Integer)
                _Question14 = value
            End Set
        End Property


        Public Property Question15() As Integer
            Get
                Return _Question15
            End Get
            Set(ByVal value As Integer)
                _Question15 = value
            End Set
        End Property

        Public Property Question16() As Integer
            Get
                Return _Question16
            End Get
            Set(ByVal value As Integer)
                _Question16 = value
            End Set
        End Property

        Public Property Question17() As Integer
            Get
                Return _Question17
            End Get
            Set(ByVal value As Integer)
                _Question17 = value
            End Set
        End Property

        Public Property Question18() As Integer
            Get
                Return _Question18
            End Get
            Set(ByVal value As Integer)
                _Question18 = value
            End Set
        End Property

        Public Property Question19() As Integer
            Get
                Return _Question19
            End Get
            Set(ByVal value As Integer)
                _Question19 = value
            End Set
        End Property

        Public Property Question20() As Integer
            Get
                Return _Question20
            End Get
            Set(ByVal value As Integer)
                _Question20 = value
            End Set
        End Property

        Public Property Question21() As Integer
            Get
                Return _Question21
            End Get
            Set(ByVal value As Integer)
                _Question21 = value
            End Set
        End Property

        Public Property Question22() As Integer
            Get
                Return _Question22
            End Get
            Set(ByVal value As Integer)
                _Question22 = value
            End Set
        End Property

        Public Property Question23() As Integer
            Get
                Return _Question23
            End Get
            Set(ByVal value As Integer)
                _Question23 = value
            End Set
        End Property

        Public Property Question24() As Integer
            Get
                Return _Question24
            End Get
            Set(ByVal value As Integer)
                _Question24 = value
            End Set
        End Property

        Public Property Question25() As Integer
            Get
                Return _Question25
            End Get
            Set(ByVal value As Integer)
                _Question25 = value
            End Set
        End Property

        Public Property Question26() As Integer
            Get
                Return _Question26
            End Get
            Set(ByVal value As Integer)
                _Question26 = value
            End Set
        End Property

        Public Property Question27() As Integer
            Get
                Return _Question27
            End Get
            Set(ByVal value As Integer)
                _Question27 = value
            End Set
        End Property

        Public Property Question28() As Integer
            Get
                Return _Question28
            End Get
            Set(ByVal value As Integer)
                _Question28 = value
            End Set
        End Property

        Public Property Question29() As Integer
            Get
                Return _Question29
            End Get
            Set(ByVal value As Integer)
                _Question29 = value
            End Set
        End Property

        Public Property Question30() As Integer
            Get
                Return _Question30
            End Get
            Set(ByVal value As Integer)
                _Question30 = value
            End Set
        End Property

        Public Property Question31() As Integer
            Get
                Return _Question31
            End Get
            Set(ByVal value As Integer)
                _Question31 = value
            End Set
        End Property

        Public Property Question32() As Integer
            Get
                Return _Question32
            End Get
            Set(ByVal value As Integer)
                _Question32 = value
            End Set
        End Property

        Public Property Question33() As Integer
            Get
                Return _Question33
            End Get
            Set(ByVal value As Integer)
                _Question33 = value
            End Set
        End Property

        Public Property Question34() As Integer
            Get
                Return _Question34
            End Get
            Set(ByVal value As Integer)
                _Question34 = value
            End Set
        End Property

        Public Property Question35() As Integer
            Get
                Return _Question35
            End Get
            Set(ByVal value As Integer)
                _Question35 = value
            End Set
        End Property

        Public Property Question36() As Integer
            Get
                Return _Question36
            End Get
            Set(ByVal value As Integer)
                _Question36 = value
            End Set
        End Property


        Public Property Question37() As Integer
            Get
                Return _Question37
            End Get
            Set(ByVal value As Integer)
                _Question37 = value
            End Set
        End Property

        Public Property Question38() As Integer
            Get
                Return _Question38
            End Get
            Set(ByVal value As Integer)
                _Question38 = value
            End Set
        End Property


        Public Property Question39() As Integer
            Get
                Return _Question39
            End Get
            Set(ByVal value As Integer)
                _Question39 = value
            End Set
        End Property

        Public Property Question40() As Integer
            Get
                Return _Question40
            End Get
            Set(ByVal value As Integer)
                _Question40 = value
            End Set
        End Property

        Public Property Question41() As Integer
            Get
                Return _Question41
            End Get
            Set(ByVal value As Integer)
                _Question41 = value
            End Set
        End Property

        Public Property Question42() As Integer
            Get
                Return _Question42
            End Get
            Set(ByVal value As Integer)
                _Question42 = value
            End Set
        End Property

        Public Property Question43() As Integer
            Get
                Return _Question43
            End Get
            Set(ByVal value As Integer)
                _Question43 = value
            End Set
        End Property

        Public Property Question44() As Integer
            Get
                Return _Question44
            End Get
            Set(ByVal value As Integer)
                _Question44 = value
            End Set
        End Property

        Public Property Question45() As Integer
            Get
                Return _Question45
            End Get
            Set(ByVal value As Integer)
                _Question45 = value
            End Set
        End Property

        Public Property Question46() As Integer
            Get
                Return _Question46
            End Get
            Set(ByVal value As Integer)
                _Question46 = value
            End Set
        End Property

        Public Property Question47() As Integer
            Get
                Return _Question47
            End Get
            Set(ByVal value As Integer)
                _Question47 = value
            End Set
        End Property

        Public Property Question48() As Integer
            Get
                Return _Question48
            End Get
            Set(ByVal value As Integer)
                _Question48 = value
            End Set
        End Property

        Public Property Question49() As Integer
            Get
                Return _Question49
            End Get
            Set(ByVal value As Integer)
                _Question49 = value
            End Set
        End Property

        Public Property Question50() As Integer
            Get
                Return _Question50
            End Get
            Set(ByVal value As Integer)
                _Question50 = value
            End Set
        End Property

        Public Property Question51() As Integer
            Get
                Return _Question51
            End Get
            Set(ByVal value As Integer)
                _Question51 = value
            End Set
        End Property

        Public Property Question52() As Integer
            Get
                Return _Question52
            End Get
            Set(ByVal value As Integer)
                _Question52 = value
            End Set
        End Property

        Public Property Question53() As Integer
            Get
                Return _Question53
            End Get
            Set(ByVal value As Integer)
                _Question53 = value
            End Set
        End Property

        Public Property Question54() As Integer
            Get
                Return _Question54
            End Get
            Set(ByVal value As Integer)
                _Question54 = value
            End Set
        End Property

        Public Property Question55() As Integer
            Get
                Return _Question55
            End Get
            Set(ByVal value As Integer)
                _Question55 = value
            End Set
        End Property

        Public Property Question56() As Integer
            Get
                Return _Question56
            End Get
            Set(ByVal value As Integer)
                _Question56 = value
            End Set
        End Property

        Public Property Question57() As Integer
            Get
                Return _Question57
            End Get
            Set(ByVal value As Integer)
                _Question57 = value
            End Set
        End Property

        Public Property Question58() As Integer
            Get
                Return _Question58
            End Get
            Set(ByVal value As Integer)
                _Question58 = value
            End Set
        End Property

        Public Property Question59() As Integer
            Get
                Return _Question59
            End Get
            Set(ByVal value As Integer)
                _Question59 = value
            End Set
        End Property

        Public Property Question60() As Integer
            Get
                Return _Question60
            End Get
            Set(ByVal value As Integer)
                _Question60 = value
            End Set
        End Property

        Public Property TeamLeader() As String
            Get
                Return _TeamLeader
            End Get
            Set(ByVal value As String)
                _TeamLeader = value
            End Set
        End Property

        Public Property TeamMember() As String
            Get
                Return _TeamMember
            End Get
            Set(ByVal value As String)
                _TeamMember = value
            End Set
        End Property
    End Class


End Namespace