Imports Microsoft.VisualBasic
Namespace C21MIT.PBSIS.BO
    Public Class pbsdemodata
        Dim _SchoolID As String
        Dim _SchoolYear As String
        Dim _SchoolName As String
        Dim _DistName As String
        Dim _DemoTchAmericanIndian As Integer
        Dim _DemoTchAsian As Integer
        Dim _DemoTchBlack As Integer
        Dim _DemoTchHispanic As Integer
        Dim _DemoTchMulticultural As Integer
        Dim _DemoTchWhite As Integer
        Dim _DemoTchOther As Integer
        Dim _DemoTchTotalEnrollment As Integer
        Dim _DemoTchStudentsWithIEP As Integer
        Dim _DemoTchPercFreeRedcLunch As Integer

        Dim _DemoTchReadingFirst As Integer
        Dim _DemoTchTitleOne As Integer
        Dim _DemoTchProblemSolvModel As Integer

        Dim _DemoTchOtherInitiatives As String
        Dim _DemoTchTargBehIntv As Integer
        Dim _DemoTchIndLvlPbs As Integer

        Dim _DemoTchIntvBEP As Integer
        Dim _DemoTchIntvICPS As Integer
        Dim _DemoTchIntvSklStr As Integer
        Dim _DemoTchIntvPrep As Integer

        Dim _DemoTchIntvSTR As Integer
        Dim _DemoTchIntvSecStp As Integer
        Dim _DemoTchIntvSC As Integer
        Dim _DemoTchIntvOth As Integer
        Dim _DemoTchIntvOthDesc As String

        Dim _DemoTchPbsERASE As Integer
        Dim _DemoTchPbsPTR As Integer
        Dim _DemoTchPbsOth As Integer
        Dim _DemoTchPbsOthDesc As String

        Dim _DemoTchAcademicSystems As String
        Dim _DemoTchBehaviorSystems As String

        Dim _DemoTchTotalInstStaff As Integer
        Dim _DemoTchPercInstStaff As Integer
        Dim _DemoTchPercAdvDegree As Integer
        Dim _DemoTchPercOOFTeacher As Integer



        Public Sub New()
            _SchoolID = ""
            _SchoolYear = ""

            _SchoolName = ""
            _DistName = ""

            _DemoTchAmericanIndian = 0
            _DemoTchAsian = 0
            _DemoTchBlack = 0
            _DemoTchHispanic = 0
            _DemoTchMulticultural = 0
            _DemoTchWhite = 0
            _DemoTchOther = 0
            _DemoTchTotalEnrollment = 0
            _DemoTchStudentsWithIEP = 0
            _DemoTchPercFreeRedcLunch = 0


            _DemoTchReadingFirst = 0
            _DemoTchTitleOne = 0
            _DemoTchProblemSolvModel = 0

            _DemoTchOtherInitiatives = ""
            _DemoTchTargBehIntv = 0
            _DemoTchIndLvlPbs = 0

            _DemoTchIntvBEP = 0
            _DemoTchIntvICPS = 0
            _DemoTchIntvSklStr = 0
            _DemoTchIntvPrep = 0

            _DemoTchIntvSTR = 0
            _DemoTchIntvSecStp = 0
            _DemoTchIntvSC = 0
            _DemoTchIntvOth = 0
            _DemoTchIntvOthDesc = ""

            _DemoTchPbsERASE = 0
            _DemoTchPbsPTR = 0
            _DemoTchPbsOth = 0
            _DemoTchPbsOthDesc = ""

            _DemoTchAcademicSystems = ""
            _DemoTchBehaviorSystems = ""

            _DemoTchTotalInstStaff = 0
            _DemoTchPercInstStaff = 0
            _DemoTchPercAdvDegree = 0
            _DemoTchPercOOFTeacher = 0

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

        Public Property SchoolName() As String
            Get
                Return _SchoolName
            End Get
            Set(ByVal value As String)
                _SchoolName = value
            End Set
        End Property

        Public Property DistrictName() As String
            Get
                Return _DistName
            End Get
            Set(ByVal value As String)
                _DistName = value
            End Set
        End Property

        Public Property DemoTchAmericanIndian() As Integer
            Get
                Return _DemoTchAmericanIndian
            End Get
            Set(ByVal value As Integer)
                _DemoTchAmericanIndian = value
            End Set
        End Property

        Public Property DemoTchAsian() As Integer
            Get
                Return _DemoTchAsian
            End Get
            Set(ByVal value As Integer)
                _DemoTchAsian = value
            End Set
        End Property

        Public Property DemoTchBlack() As Integer
            Get
                Return _DemoTchBlack
            End Get
            Set(ByVal value As Integer)
                _DemoTchBlack = value
            End Set
        End Property

        Public Property DemoTchHispanic() As Integer
            Get
                Return _DemoTchHispanic
            End Get
            Set(ByVal value As Integer)
                _DemoTchHispanic = value
            End Set
        End Property

        Public Property DemoTchMulticultural() As Integer
            Get
                Return _DemoTchMulticultural
            End Get
            Set(ByVal value As Integer)
                _DemoTchMulticultural = value
            End Set
        End Property

        Public Property DemoTchWhite() As Integer
            Get
                Return _DemoTchWhite
            End Get
            Set(ByVal value As Integer)
                _DemoTchWhite = value
            End Set
        End Property

        Public Property DemoTchOther() As Integer
            Get
                Return _DemoTchOther
            End Get
            Set(ByVal value As Integer)
                _DemoTchOther = value
            End Set
        End Property

        Public Property DemoTchTotalEnrollment() As Integer
            Get
                Return _DemoTchTotalEnrollment
            End Get
            Set(ByVal value As Integer)
                _DemoTchTotalEnrollment = value
            End Set
        End Property

        Public Property DemoTchStudentsWithIEP() As Integer
            Get
                Return _DemoTchStudentsWithIEP
            End Get
            Set(ByVal value As Integer)
                _DemoTchStudentsWithIEP = value
            End Set
        End Property

        Public Property DemoTchPercFreeRedcLunch() As Integer
            Get
                Return _DemoTchPercFreeRedcLunch
            End Get
            Set(ByVal value As Integer)
                _DemoTchPercFreeRedcLunch = value
            End Set
        End Property



        Public Property DemoTchReadingFirst() As Integer
            Get
                Return _DemoTchReadingFirst
            End Get
            Set(ByVal value As Integer)
                _DemoTchReadingFirst = value
            End Set
        End Property

        Public Property DemoTchTitleOne() As Integer
            Get
                Return _DemoTchTitleOne
            End Get
            Set(ByVal value As Integer)
                _DemoTchTitleOne = value
            End Set
        End Property

        Public Property DemoTchProblemSolvModel() As Integer
            Get
                Return _DemoTchProblemSolvModel
            End Get
            Set(ByVal value As Integer)
                _DemoTchProblemSolvModel = value
            End Set
        End Property



        Public Property DemoTchOtherInitiatives() As String
            Get
                Return _DemoTchOtherInitiatives
            End Get
            Set(ByVal value As String)
                _DemoTchOtherInitiatives = value
            End Set
        End Property

        Public Property DemoTchTargBehIntv() As Integer
            Get
                Return _DemoTchTargBehIntv
            End Get
            Set(ByVal value As Integer)
                _DemoTchTargBehIntv = value
            End Set
        End Property

        Public Property DemoTchIndLvlPbs() As Integer
            Get
                Return _DemoTchIndLvlPbs
            End Get
            Set(ByVal value As Integer)
                _DemoTchIndLvlPbs = value
            End Set
        End Property




        Public Property DemoTchIntvBEP() As Integer
            Get
                Return _DemoTchIntvBEP
            End Get
            Set(ByVal value As Integer)
                _DemoTchIntvBEP = value
            End Set
        End Property

        Public Property DemoTchIntvICPS() As Integer
            Get
                Return _DemoTchIntvICPS
            End Get
            Set(ByVal value As Integer)
                _DemoTchIntvICPS = value
            End Set
        End Property

        Public Property DemoTchIntvSklStr() As Integer
            Get
                Return _DemoTchIntvSklStr
            End Get
            Set(ByVal value As Integer)
                _DemoTchIntvSklStr = value
            End Set
        End Property

        Public Property DemoTchIntvPrep() As Integer
            Get
                Return _DemoTchIntvPrep
            End Get
            Set(ByVal value As Integer)
                _DemoTchIntvPrep = value
            End Set
        End Property



        Public Property DemoTchIntvSTR() As Integer
            Get
                Return _DemoTchIntvSTR
            End Get
            Set(ByVal value As Integer)
                _DemoTchIntvSTR = value
            End Set
        End Property

        Public Property DemoTchIntvSecStp() As Integer
            Get
                Return _DemoTchIntvSecStp
            End Get
            Set(ByVal value As Integer)
                _DemoTchIntvSecStp = value
            End Set
        End Property

        Public Property DemoTchIntvSC() As Integer
            Get
                Return _DemoTchIntvSC
            End Get
            Set(ByVal value As Integer)
                _DemoTchIntvSC = value
            End Set
        End Property

        Public Property DemoTchIntvOth() As Integer
            Get
                Return _DemoTchIntvOth
            End Get
            Set(ByVal value As Integer)
                _DemoTchIntvOth = value
            End Set
        End Property

        Public Property DemoTchIntvOthDesc() As String
            Get
                Return _DemoTchIntvOthDesc
            End Get
            Set(ByVal value As String)
                _DemoTchIntvOthDesc = value
            End Set
        End Property



        Public Property DemoTchPbsERASE() As Integer
            Get
                Return _DemoTchPbsERASE
            End Get
            Set(ByVal value As Integer)
                _DemoTchPbsERASE = value
            End Set
        End Property

        Public Property DemoTchPbsPTR() As Integer
            Get
                Return _DemoTchPbsPTR
            End Get
            Set(ByVal value As Integer)
                _DemoTchPbsPTR = value
            End Set
        End Property

        Public Property DemoTchPbsOth() As Integer
            Get
                Return _DemoTchPbsOth
            End Get
            Set(ByVal value As Integer)
                _DemoTchPbsOth = value
            End Set
        End Property

        Public Property DemoTchPbsOthDesc() As String
            Get
                Return _DemoTchPbsOthDesc
            End Get
            Set(ByVal value As String)
                _DemoTchPbsOthDesc = value
            End Set
        End Property



        Public Property DemoTchAcademicSystems() As String
            Get
                Return _DemoTchAcademicSystems
            End Get
            Set(ByVal value As String)
                _DemoTchAcademicSystems = value
            End Set
        End Property

        Public Property DemoTchBehaviorSystems() As String
            Get
                Return _DemoTchBehaviorSystems
            End Get
            Set(ByVal value As String)
                _DemoTchBehaviorSystems = value
            End Set
        End Property



        Public Property DemoTchTotalInstStaff() As Integer
            Get
                Return _DemoTchTotalInstStaff
            End Get
            Set(ByVal value As Integer)
                _DemoTchTotalInstStaff = value
            End Set
        End Property

        Public Property DemoTchPercInstStaff() As Integer
            Get
                Return _DemoTchPercInstStaff
            End Get
            Set(ByVal value As Integer)
                _DemoTchPercInstStaff = value
            End Set
        End Property

        Public Property DemoTchPercAdvDegree() As Integer
            Get
                Return _DemoTchPercAdvDegree
            End Get
            Set(ByVal value As Integer)
                _DemoTchPercAdvDegree = value
            End Set
        End Property

        Public Property DemoTchPercOOFTeacher() As Integer
            Get
                Return _DemoTchPercOOFTeacher
            End Get
            Set(ByVal value As Integer)
                _DemoTchPercOOFTeacher = value
            End Set
        End Property

    End Class
End Namespace