Imports Microsoft.VisualBasic
Namespace C21MIT.PBSIS.BO
    Public Class pbslogindetails
        Dim _strUsername As String
        Dim _strPassword As String
        Dim _v_actid As String
        Dim _schoolyear As Integer
        Dim _isCorrect As Integer
        Dim _v_isInactive As Integer

        Dim _resultpforgotpass As Integer

        Public Sub New()
            _strUsername = ""
            _strPassword = ""
            _v_actid = ""
            _schoolyear = 0
            _isCorrect = 0
            _v_isInactive = 0

            _resultpforgotpass = 0
        End Sub

        Sub New(ByVal SessionTracker As String)
            Dim urDetCol() As String

            If SessionTracker = "" Then

                Return
            Else
                urDetCol = SessionTracker.Split(",")
            End If
            _strUsername = CType(urDetCol(0), String)
            _strPassword = CType(urDetCol(1), String)
            _v_actid = CType(urDetCol(2), String)
            _schoolyear = CType(urDetCol(3), Integer)
            _isCorrect = CType(urDetCol(4), Integer)
            _v_isInactive = CType(urDetCol(5), Integer)
        End Sub

#Region "Properties"

        Public Property strUsername() As String
            Get
                Return _strUsername
            End Get
            Set(ByVal value As String)
                _strUsername = value
            End Set
        End Property

        Public Property strPassword() As String
            Get
                Return _strPassword
            End Get
            Set(ByVal value As String)
                _strPassword = value
            End Set
        End Property

        Public Property v_actid() As String
            Get
                Return _v_actid
            End Get
            Set(ByVal value As String)
                _v_actid = value
            End Set
        End Property

        Public Property schoolyear() As Integer
            Get
                Return _schoolyear
            End Get
            Set(ByVal value As Integer)
                _schoolyear = value
            End Set
        End Property

        Public Property isCorrect() As Integer
            Get
                Return _isCorrect
            End Get
            Set(ByVal value As Integer)
                _isCorrect = value
            End Set
        End Property

        Public Property v_isInactive() As Integer
            Get
                Return _v_isInactive
            End Get
            Set(ByVal value As Integer)
                _v_isInactive = value
            End Set
        End Property


        Public Property resultpforgotpass() As Integer
            Get
                Return _resultpforgotpass
            End Get
            Set(ByVal value As Integer)
                _resultpforgotpass = value
            End Set
        End Property

        Public ReadOnly Property PSessionTracker() As String
            Get

                Return _strUsername + "," + _strPassword + "," + _v_actid.ToString + "," + _
                    _schoolyear.ToString + "," + _isCorrect.ToString + "," + _v_isInactive.ToString
            End Get
        End Property
#End Region
    End Class


End Namespace