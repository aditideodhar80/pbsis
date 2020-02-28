Imports Microsoft.VisualBasic

Namespace C21MIT.PBSIS.BO

    Public Class ChartInfoset
        'Properties to define the Chart
        Dim _chartHt As Integer
        Dim _chartWd As Integer

        Dim _SingleMulti As String
        Dim _isLegendPresent As String

        Dim _LegendText1 As String
        Dim _LegendText2 As String
        Dim _LegendText3 As String

        'Properties to define the plot area
        Dim _plotXPos As Integer
        Dim _plotYPos As Integer
        Dim _plotH As Integer
        Dim _plotW As Integer

        'Properties to define the title
        Dim _Title As String
        'Aditi
        Dim _SubTitle As String
        Dim _GroupBy As String

        Dim _TitleFont As String
        Dim _TitleFontSize As Integer
        Dim _TitleColor As String

        Dim _BarWidth As Integer

        Dim _barStyle As String

        Dim _DataStyle As String
        ''Define Axis Label Text
        Dim _labelStyleFont As String
        Dim _labelStyleFontSize As Integer
        Dim _labelStyleColor As Integer

        'Properties to define the x-axis
        Dim _xTitle As String

        Dim _xlabelStyleAngle As Integer

        'Properties to define the y-axis
        Dim _yTitle As String

        Dim _yLowerLimit As Integer
        Dim _yUpperLimit As Integer
        Dim _yMaxTic As Integer

        Dim _ySetTopMargin As Integer
        Dim _yMinTic As Integer

        'Properties to define Legend
        Dim _legendXPos As Integer
        Dim _legendYPos As Integer
        Dim _IsVertical As Boolean
        Dim _legendFont As String
        Dim _legendFontSize As Integer

        Dim _legendKeySizeWidth As Integer
        Dim _legendKeySizeheight As Integer
        Dim _legendKeySizeGap As Integer


        'labels for the x-axis
        Dim _xLabels() As String

        'labels for the legend
        Dim _LegendLabels() As String

        ''Data for the charts
        Dim _chartData() As String

        'Aditi
        'Data for the legend labels if from db
        Dim _chartLegendLabels() As String
        Dim _chartlegendType As String

        'Data for X-Axis labels if from db
        Dim _chartXAxisLabelType As String
        Dim _chartXAxisLabels() As String

        'generic font attribute properties
        Dim _fontsize As Integer
        Dim _fontface As String
        Dim _fontcolor As String
        Dim _fontbold As Boolean
        'Dim _fonttalic As Boolean
        'Dim _fontunderline As Boolean

        Public Sub New()
            _chartHt = 0
            _chartWd = 0

            _SingleMulti = ""
            _isLegendPresent = ""

            _LegendText1 = ""
            _LegendText2 = ""
            _LegendText3 = ""

            'Properties to define the plot area
            _plotXPos = 0
            _plotYPos = 0
            _plotH = 0
            _plotW = 0

            'Properties to define the title
            _Title = ""
            'Aditi
            _SubTitle = ""
            _GroupBy = ""

            _TitleFont = ""
            _TitleFontSize = 0
            _TitleColor = ""

            _BarWidth = 0

            ''Define Axis Label Text
            _labelStyleFont = ""
            _labelStyleFontSize = 0
            _labelStyleColor = 0

            'Properties to define the x-axis
            _xTitle = ""

            _xlabelStyleAngle = 0

            'Properties to define the y-axis
            _yTitle = ""

            _yLowerLimit = 0
            _yUpperLimit = 0
            _yMaxTic = 0

            _ySetTopMargin = 0
            _yMinTic = 0

            'Properties to define Legend
            _legendXPos = 0
            _legendYPos = 0
            '  _IsVertical As Boolean
            _legendFont = ""
            _legendFontSize = 0

            _legendKeySizeWidth = 0
            _legendKeySizeheight = 0
            _legendKeySizeGap = 0


            'labels for the x-axis
            '_xLabels() = ""

            'labels for the legend
            '_LegendLabels() = ""

            ''Data for the charts
            ' _chartData() = ""

            'Aditi
            'Data for the legend labels if from db
            '    _chartLegendLabels() = ""
            _chartlegendType = ""

            'Data for X-Axis labels if from db
            _chartXAxisLabelType = ""
            '  _chartXAxisLabels() = ""

            'generic font attribute properties
            _fontsize = 0
            _fontface = ""
            _fontcolor = ""
            '   _fontbold As Boolean
            'Dim _fonttalic As Boolean
            'Dim _fontunderline As Boolean
        End Sub



        Public Property ChartHeight() As Integer
            Get
                Return _chartHt
            End Get
            Set(ByVal value As Integer)
                _chartHt = value
            End Set
        End Property

        Property ChartWidth() As Integer
            Get
                Return _chartWd
            End Get
            Set(ByVal value As Integer)
                _chartWd = value
            End Set
        End Property

        Public Property IsMultiBar() As String
            Get
                Return _SingleMulti
            End Get
            Set(ByVal value As String)
                _SingleMulti = value
            End Set
        End Property

        Public Property BarStyle() As String
            Get
                Return _barStyle
            End Get
            Set(ByVal value As String)
                _barStyle = value
            End Set
        End Property

        Public Property IsLegendPresent() As String
            Get
                Return _isLegendPresent
            End Get
            Set(ByVal value As String)
                _isLegendPresent = value
            End Set
        End Property


        Public Property LegendType() As String
            Get
                Return _chartlegendType
            End Get
            Set(ByVal value As String)
                _chartlegendType = value
            End Set
        End Property

        Public Property LegendText1() As String
            Get
                Return _LegendText1
            End Get
            Set(ByVal value As String)
                _LegendText1 = value
            End Set
        End Property

        Public Property LegendText2() As String
            Get
                Return _LegendText2
            End Get
            Set(ByVal value As String)
                _LegendText2 = value
            End Set
        End Property

        Public Property LegendText3() As String
            Get
                Return _LegendText3
            End Get
            Set(ByVal value As String)
                _LegendText3 = value
            End Set
        End Property


        Public Property ChartPlotXPosition() As Integer
            Get
                Return _plotXPos
            End Get
            Set(ByVal value As Integer)
                _plotXPos = value
            End Set
        End Property

        Public Property ChartPlotYPosition() As Integer
            Get
                Return _plotXPos
            End Get
            Set(ByVal value As Integer)
                _plotYPos = value
            End Set
        End Property

        Public Property ChartPlotHeight() As Integer
            Get
                Return _plotH
            End Get
            Set(ByVal value As Integer)
                _plotH = value
            End Set
        End Property

        Public Property ChartPlotWidth() As Integer
            Get
                Return _plotW
            End Get
            Set(ByVal value As Integer)
                _plotW = value
            End Set
        End Property


        Public Property ChartTitle() As String
            Get
                Return _Title
            End Get
            Set(ByVal value As String)
                _Title = value
            End Set
        End Property

        Public Property ChartSubTitle() As String
            Get
                Return _SubTitle
            End Get
            Set(ByVal value As String)
                _SubTitle = value
            End Set
        End Property

        Public Property ChartGroupBy() As String
            Get
                Return _GroupBy
            End Get
            Set(ByVal value As String)
                _GroupBy = value
            End Set
        End Property



        Public Property ChartTitleFont() As String
            Get
                Return _TitleFont
            End Get
            Set(ByVal value As String)
                _TitleFont = value
            End Set
        End Property

        Public Property ChartTitleFontSize() As Integer
            Get
                Return _TitleFontSize
            End Get
            Set(ByVal value As Integer)
                _TitleFontSize = value
            End Set
        End Property


        Public Property ChartTitleColor() As String
            Get
                Return _TitleColor
            End Get
            Set(ByVal value As String)
                _TitleColor = value
            End Set
        End Property


        Public Property BarWidth() As Integer
            Get
                Return _BarWidth
            End Get
            Set(ByVal value As Integer)
                _BarWidth = value
            End Set
        End Property


        Public Property LabelFontSize() As Integer
            Get
                Return _labelStyleFontSize
            End Get
            Set(ByVal value As Integer)
                _labelStyleFontSize = value
            End Set
        End Property

        Public Property LabelFontColor() As Integer
            Get
                Return _labelStyleColor
            End Get
            Set(ByVal value As Integer)
                _labelStyleColor = value
            End Set
        End Property


        'Properties to define the x-axis
        Public Property XAxisTitle() As String
            Get
                Return _xTitle
            End Get
            Set(ByVal value As String)
                _xTitle = value
            End Set
        End Property


        Public Property LabelFontStyle() As String
            Get
                Return _labelStyleFont
            End Get
            Set(ByVal value As String)
                _labelStyleFont = value
            End Set
        End Property





        Public Property XLabelFontAngle() As Integer
            Get
                Return _xlabelStyleAngle
            End Get
            Set(ByVal value As Integer)
                _xlabelStyleAngle = value
            End Set
        End Property



        'Properties to define the y-axis
        Public Property YAxisTitle() As String
            Get
                Return _yTitle
            End Get
            Set(ByVal value As String)
                _yTitle = value
            End Set
        End Property

        Public Property YAxisLowerLimit() As Integer
            Get
                Return _yLowerLimit
            End Get
            Set(ByVal value As Integer)
                _yLowerLimit = value
            End Set
        End Property

        Public Property YAxisUpperLimit() As Integer
            Get
                Return _yUpperLimit
            End Get
            Set(ByVal value As Integer)
                _yUpperLimit = value
            End Set
        End Property

        Public Property YAxisMaxTic() As Integer
            Get
                Return _yMaxTic
            End Get
            Set(ByVal value As Integer)
                _yMaxTic = value
            End Set
        End Property

        Public Property YAxisMinTic() As Integer
            Get
                Return _yMinTic
            End Get
            Set(ByVal value As Integer)
                _yMinTic = value
            End Set
        End Property

        Public Property YAxisSetTopmargin() As Integer
            Get
                Return _ySetTopMargin
            End Get
            Set(ByVal value As Integer)
                _ySetTopMargin = value
            End Set
        End Property

        'Properties to define Legend

        Public Property LegendXPos() As Integer
            Get
                Return _legendXPos
            End Get
            Set(ByVal value As Integer)
                _legendXPos = value
            End Set
        End Property
        Public Property LegendYPos() As Integer
            Get
                Return _legendYPos
            End Get
            Set(ByVal value As Integer)
                _legendYPos = value
            End Set
        End Property
        Public Property LegendIsVertical() As Boolean
            Get
                Return _IsVertical
            End Get
            Set(ByVal value As Boolean)
                _IsVertical = value
            End Set
        End Property

        Public Property LegendFont() As String
            Get
                Return _legendFont
            End Get
            Set(ByVal value As String)
                _legendFont = value
            End Set
        End Property
        Public Property LegendFontSize() As Integer
            Get
                Return _legendFontSize
            End Get
            Set(ByVal value As Integer)
                _legendFontSize = value
            End Set
        End Property
        Public Property LegendkeySizeWidth() As Integer
            Get
                Return _legendKeySizeWidth
            End Get
            Set(ByVal value As Integer)
                _legendKeySizeWidth = value
            End Set
        End Property

        Public Property LegendkeySizeheight() As Integer
            Get
                Return _legendKeySizeheight
            End Get
            Set(ByVal value As Integer)
                _legendKeySizeheight = value
            End Set
        End Property
        Public Property LegendkeySizeGap() As Integer
            Get
                Return _legendKeySizeGap
            End Get
            Set(ByVal value As Integer)
                _legendKeySizeGap = value
            End Set
        End Property


        'labels for the x-axis
        Public Property XAxisLabel() As String()
            Get
                Return _xLabels
            End Get
            Set(ByVal value As String())
                _xLabels = value
            End Set
        End Property

        'labels for the legend
        Public Property LegendLabels() As String()
            Get
                Return _LegendLabels
            End Get
            Set(ByVal value As String())
                _LegendLabels = value
            End Set
        End Property

        ''ChartData always from db
        Public Property ChartData() As String()
            Get
                Return _chartData
            End Get

            Set(ByVal value As String())
                _chartData = value
            End Set
        End Property

        ''Legend Labels if from db
        Public Property ChartLegendLabels() As String()
            Get
                Return _chartLegendLabels
            End Get

            Set(ByVal value As String())
                _chartLegendLabels = value
            End Set
        End Property

        'XAxixLabels if from db
        Public Property ChartXAxixLabels() As String()
            Get
                Return _chartXAxisLabels
            End Get

            Set(ByVal value As String())
                _chartXAxisLabels = value
            End Set
        End Property


        Public Property XAxisLabelType() As String
            Get
                Return _chartXAxisLabelType
            End Get
            Set(ByVal value As String)
                _chartXAxisLabelType = value
            End Set
        End Property


        'Font properties
        Public Property FontSize() As Integer
            Get
                Return _fontsize
            End Get

            Set(ByVal value As Integer)
                _fontsize = value
            End Set
        End Property

        Public Property FontFace() As String
            Get
                Return _fontface
            End Get

            Set(ByVal value As String)
                _fontface = value
            End Set
        End Property

        Public Property FontColor() As String
            Get
                Return _fontcolor
            End Get

            Set(ByVal value As String)
                _fontcolor = value
            End Set
        End Property

        Public Property FontBold() As Boolean
            Get
                Return _fontbold
            End Get

            Set(ByVal value As Boolean)
                _fontbold = value
            End Set
        End Property

        Public Property DataStyle() As String
            Get
                Return _DataStyle

            End Get
            Set(ByVal value As String)
                _DataStyle = value
            End Set
        End Property
       
        'Public Property FontItalic() As Boolean
        '    Get
        '        Return _fonttalic
        '    End Get

        '    Set(ByVal value As Boolean)
        '        _fonttalic = value
        '    End Set
        'End Property

        'Public Property FontUnderline() As Boolean
        '    Get
        '        Return _fontunderline
        '    End Get

        '    Set(ByVal value As Boolean)
        '        _fontunderline = value
        '    End Set
        'End Property

    End Class


End Namespace

