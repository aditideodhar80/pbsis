Imports Microsoft.VisualBasic
Namespace C21MIT.PBSIS.BO
    Public Class pbsods
        Dim _SchoolID As String
        Dim _SchoolYear As String
        Dim _SchoolName As String

        Dim _DistrictName As String
        Dim _OdTotalSchoolDays As Integer
        Dim _OdAvgDailyAttendance As Integer
        Dim _OdTotalOfficeReferrals As Integer
        Dim _OdTotalISSDays As Integer
        Dim _OdTotalOSSDays As Integer

        Dim _OdProgMonTarget As Integer
        Dim _OdProgMonTargDesc As String

        Dim _OdProgMonIndiv As Integer
        Dim _OdProgMonIndDesc As String

        Dim _OdPercentReadingGains As Integer
        Dim _OdPercentLowest25Reading As Integer
        Dim _OdPercLvl3FcatRead As Integer
        Dim _OdSchoolGrade As String
        Dim _OdTotalSchoolPoints As Integer


        Dim _OdDocName As String
        Dim _OdDocStatus As Integer

        Dim _OdIdPk As Integer
        Dim _OdIdOut As Integer
        Dim _OdSchYrOut As Integer
        Dim _OdSchoolIDOut As String

        Dim _ODSDocName As String
        Dim _ODSDocStatus As Integer

        Dim _NavigateURL As String

        Public Sub New()
            _SchoolID = ""
            _SchoolYear = ""
            _SchoolName = ""
            _DistrictName = ""
            _OdTotalSchoolDays = 0
            _OdAvgDailyAttendance = 0
            _OdTotalOfficeReferrals = 0
            _OdTotalISSDays = 0
            _OdTotalOSSDays = 0

            _OdProgMonTarget = 0
            _OdProgMonTargDesc = ""

            _OdProgMonIndiv = 0
            _OdProgMonIndDesc = ""

            _OdPercentReadingGains = 0
            _OdPercentLowest25Reading = 0
            _OdPercLvl3FcatRead = 0
            _OdSchoolGrade = ""
            _OdTotalSchoolPoints = 0

            _OdDocName = ""
            _OdDocStatus = 0

            _OdIdPk = 0
            _OdIdOut = 0
            _OdSchYrOut = 0
            _OdSchoolIDOut = ""

            _ODSDocName = ""
            _ODSDocStatus = 0

            _NavigateURL = ""
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
                Return _DistrictName
            End Get
            Set(ByVal value As String)
                _DistrictName = value
            End Set
        End Property
        Public Property OdTotalSchoolDays() As Integer
            Get
                Return _OdTotalSchoolDays
            End Get
            Set(ByVal value As Integer)
                _OdTotalSchoolDays = value
            End Set
        End Property

        Public Property OdAvgDailyAttendance() As Integer
            Get
                Return _OdAvgDailyAttendance
            End Get
            Set(ByVal value As Integer)
                _OdAvgDailyAttendance = value
            End Set
        End Property


        Public Property OdTotalOfficeReferrals() As Integer
            Get
                Return _OdTotalOfficeReferrals
            End Get
            Set(ByVal value As Integer)
                _OdTotalOfficeReferrals = value
            End Set
        End Property


        Public Property OdTotalISSDays() As Integer
            Get
                Return _OdTotalISSDays
            End Get
            Set(ByVal value As Integer)
                _OdTotalISSDays = value
            End Set
        End Property

        Public Property OdTotalOSSDays() As Integer
            Get
                Return _OdTotalOSSDays
            End Get
            Set(ByVal value As Integer)
                _OdTotalOSSDays = value
            End Set
        End Property

        Public Property OdProgMonTarget() As Integer
            Get
                Return _OdProgMonTarget
            End Get
            Set(ByVal value As Integer)
                _OdProgMonTarget = value
            End Set
        End Property

        Public Property OdProgMonTargDesc() As String
            Get
                Return _OdProgMonTargDesc
            End Get
            Set(ByVal value As String)
                _OdProgMonTargDesc = value
            End Set
        End Property

        Public Property OdProgMonIndiv() As Integer
            Get
                Return _OdProgMonIndiv
            End Get
            Set(ByVal value As Integer)
                _OdProgMonIndiv = value
            End Set
        End Property

        Public Property OdProgMonIndDesc() As String
            Get
                Return _OdProgMonIndDesc
            End Get
            Set(ByVal value As String)
                _OdProgMonIndDesc = value
            End Set
        End Property

        Public Property OdPercentReadingGains() As Integer
            Get
                Return _OdPercentReadingGains
            End Get
            Set(ByVal value As Integer)
                _OdPercentReadingGains = value
            End Set
        End Property

        Public Property OdPercentLowest25Reading() As Integer
            Get
                Return _OdPercentLowest25Reading
            End Get
            Set(ByVal value As Integer)
                _OdPercentLowest25Reading = value
            End Set
        End Property

        Public Property OdPercLvl3FcatRead() As Integer
            Get
                Return _OdPercLvl3FcatRead
            End Get
            Set(ByVal value As Integer)
                _OdPercLvl3FcatRead = value
            End Set
        End Property

        Public Property OdSchoolGrade() As String
            Get
                Return _OdSchoolGrade
            End Get
            Set(ByVal value As String)
                _OdSchoolGrade = value
            End Set
        End Property

        Public Property OdTotalSchoolPoints() As Integer
            Get
                Return _OdTotalSchoolPoints
            End Get
            Set(ByVal value As Integer)
                _OdTotalSchoolPoints = value
            End Set
        End Property

        Public Property OdDocName() As String
            Get
                Return _OdDocName
            End Get
            Set(ByVal value As String)
                _OdDocName = value
            End Set
        End Property

        Public Property OdDocStatus() As Integer
            Get
                Return _OdDocStatus
            End Get
            Set(ByVal value As Integer)
                _OdDocStatus = value
            End Set
        End Property

        Public Property OdIdPk() As Integer
            Get
                Return _OdIdPk
            End Get
            Set(ByVal value As Integer)
                _OdIdPk = value
            End Set
        End Property


        Public Property OdIdOut() As Integer
            Get
                Return _OdIdOut
            End Get
            Set(ByVal value As Integer)
                _OdIdOut = value
            End Set
        End Property

        Public Property OdSchYrOut() As Integer
            Get
                Return _OdSchYrOut
            End Get
            Set(ByVal value As Integer)
                _OdSchYrOut = value
            End Set
        End Property

        Public Property OdSchoolIDOut() As Integer
            Get
                Return _OdSchoolIDOut
            End Get
            Set(ByVal value As Integer)
                _OdSchoolIDOut = value
            End Set
        End Property


        Public Property ODSDocName() As String
            Get
                Return _ODSDocName
            End Get
            Set(ByVal value As String)
                _ODSDocName = value
            End Set
        End Property

        Public Property ODSDocStatus() As Integer
            Get
                Return _ODSDocStatus
            End Get
            Set(ByVal value As Integer)
                _ODSDocStatus = value
            End Set
        End Property

        Public Property NavigateURL() As String
            Get
                Return _NavigateURL
            End Get
            Set(ByVal value As String)
                _NavigateURL = value
            End Set
        End Property

        'list of additional documents
        Public Class ODSDocObjList
            Inherits System.Collections.Generic.List(Of pbsods)

            Public Sub New()

            End Sub
        End Class
    End Class
End Namespace