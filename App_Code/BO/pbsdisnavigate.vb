Imports Microsoft.VisualBasic
Namespace C21MIT.PBSIS.BO
    Public Class pbsnavigatelistobj
        Dim _Id As String
        Dim _Name As String

        Dim _CoachInactive As Boolean

        Dim _SchoolId As String
        Dim _SchoolName As String
        
        Dim _DistrictId As String
        Dim _DistrictName As String

        Dim _DistrictCoordId As String
        Dim _DistrictCoordName As String

        Dim _headerText As String
        Dim _navText As String
        Dim _navStatus As String
        Dim _navLink As String


        Dim _headerText1 As String
        Dim _navText1 As String
        Dim _navStatus1 As String
        Dim _navLink1 As String

        Dim _headerText2 As String
        Dim _navText2 As String
        Dim _navStatus2 As String
        Dim _navLink2 As String

        Dim _headerText3 As String
        Dim _navText3 As String
        Dim _navStatus3 As String
        Dim _navLink3 As String

        Dim _headerText4 As String
        Dim _navText4 As String
        Dim _navStatus4 As String
        Dim _navLink4 As String

        Dim _headerText5 As String
        Dim _navText5 As String
        Dim _navStatus5 As String
        Dim _navLink5 As String

        Dim _headerText6 As String
        Dim _navText6 As String
        Dim _navStatus6 As String
        Dim _navLink6 As String

        Dim _headerText7 As String
        Dim _navText7 As String
        Dim _navStatus7 As String
        Dim _navLink7 As String

        Dim _headerText8 As String
        Dim _navText8 As String
        Dim _navStatus8 As String
        Dim _navLink8 As String

        Dim _itemtemplate As New DynamicItemTemplate
        Public Sub New()
            ' _itemtemplate = New DynamicItemTemplate

            _Id = ""
            _Name = ""

            _CoachInactive = False

            _SchoolId = ""
            _SchoolName = ""

            _DistrictId = ""
            _DistrictName = ""

            _DistrictCoordId = ""
            _DistrictCoordName = ""

            _headerText = ""
            _navText = ""
            _navStatus = ""
            _navLink = ""

            _headerText1 = ""
            _navText1 = ""
            _navStatus1 = ""
            _navLink1 = ""

            _headerText2 = ""
            _navText2 = ""
            _navStatus2 = ""
            _navLink2 = ""

            _headerText3 = ""
            _navText3 = ""
            _navStatus3 = ""
            _navLink3 = ""

            _headerText4 = ""
            _navText4 = ""
            _navStatus4 = ""
            _navLink4 = ""

            _headerText5 = ""
            _navText5 = ""
            _navStatus5 = ""
            _navLink5 = ""

            _headerText6 = ""
            _navText6 = ""
            _navStatus6 = ""
            _navLink6 = ""

            _headerText7 = ""
            _navText7 = ""
            _navStatus7 = ""
            _navLink7 = ""

            _headerText8 = ""
            _navText8 = ""
            _navStatus8 = ""
            _navLink8 = ""


        End Sub

        'Public Sub New()

        'End Sub

        'Public Sub New(ByVal pNavDet As String)

        '    Dim urDetCol() As String

        '    urDetCol = pNavDet.Split(",")

        '    _SchoolId = CType(urDetCol(0), String)
        '    _SchoolName = CType(urDetCol(1), String)
        '    _headerText = CType(urDetCol(2), String)
        '    _navText = CType(urDetCol(3), String)
        '    _navStatus = CType(urDetCol(4), String)
        '    _navLink = CType(urDetCol(5), String)
        '    _headerText1 = CType(urDetCol(6), String)
        '    _navText1 = CType(urDetCol(6), String)
        '    _navStatus1 = CType(urDetCol(7), String)
        '    _navLink1 = CType(urDetCol(8), String)
        '    _headerText2 = CType(urDetCol(6), String)
        '    _navText2 = CType(urDetCol(9), String)
        '    _navStatus2 = CType(urDetCol(10), String)
        '    _navLink2 = CType(urDetCol(11), String)
        '    _headerText3 = CType(urDetCol(6), String)
        '    _navText3 = CType(urDetCol(12), String)
        '    _navStatus3 = CType(urDetCol(13), String)
        '    _navLink3 = CType(urDetCol(14), String)
        '    _headerText4 = CType(urDetCol(6), String)
        '    _navText4 = CType(urDetCol(15), String)
        '    _navStatus4 = CType(urDetCol(16), String)
        '    _navLink4 = CType(urDetCol(17), String)
        '    _headerText5 = CType(urDetCol(6), String)
        '    _navText5 = CType(urDetCol(18), String)
        '    _navStatus5 = CType(urDetCol(19), String)
        '    _navLink5 = CType(urDetCol(20), String)
        '    _headerText6 = CType(urDetCol(6), String)
        '    _navText6 = CType(urDetCol(21), String)
        '    _navStatus6 = CType(urDetCol(22), String)
        '    _navLink6 = CType(urDetCol(23), String)
        '    _headerText7 = CType(urDetCol(6), String)
        '    _navText7 = CType(urDetCol(24), String)
        '    _navStatus7 = CType(urDetCol(25), String)
        '    _navLink7 = CType(urDetCol(26), String)
        '    _headerText8 = CType(urDetCol(6), String)
        '    _navText8 = CType(urDetCol(27), String)
        '    _navStatus8 = CType(urDetCol(28), String)
        '    _navLink8 = CType(urDetCol(29), String)
        'End Sub

        'Public Sub New(ByVal schid As String, ByVal schname As String, ByVal headerText As String, ByVal navText As String, _
        '        ByVal navStatus As String, ByVal navLink As String, ByVal navText1 As String, ByVal navStatus1 As String, ByVal navLink1 As String, _
        '        ByVal navText2 As String, ByVal navStatus2 As String, ByVal navLink2 As String, ByVal navText3 As String, ByVal navStatus3 As String, _
        '        ByVal navLink3 As String, ByVal navText4 As String, ByVal navStatus4 As String, ByVal navLink4 As String, ByVal navText5 As String, _
        '        ByVal navStatus5 As String, ByVal navLink5 As String, ByVal navText6 As String, ByVal navStatus6 As String, ByVal navLink6 As String, _
        '        ByVal navText7 As String, ByVal navStatus7 As String, ByVal navLink7 As String, ByVal navText8 As String, ByVal navStatus8 As String, ByVal navLink8 As String)

        '    _SchoolId = schid
        '    _SchoolName = schname
        '    _headerText = headerText
        '    _navText = navText
        '    _navStatus = navStatus
        '    _navLink = navLink
        '    _navText1 = navText1
        '    _navStatus1 = navStatus1
        '    _navLink1 = navLink1
        '    _navText2 = navText2
        '    _navStatus2 = navStatus2
        '    _navLink2 = navLink2
        '    _navText3 = navText3
        '    _navStatus3 = navStatus3
        '    _navLink3 = navLink3
        '    _navText4 = navText4
        '    _navStatus4 = navStatus4
        '    _navLink4 = navLink4
        '    _navText5 = navText5
        '    _navStatus5 = navStatus5
        '    _navLink5 = navLink5
        '    _navText6 = navText6
        '    _navStatus6 = navStatus6
        '    _navLink6 = navLink6
        '    _navText7 = navText7
        '    _navStatus7 = navStatus7
        '    _navLink7 = navLink7
        '    _navText8 = navText8
        '    _navStatus8 = navStatus8
        '    _navLink8 = navLink8
        'End Sub

        Public Property itemtemplate() As DynamicItemTemplate
            Get
                Return _itemtemplate

            End Get
            Set(ByVal value As DynamicItemTemplate)
                _itemtemplate = value
            End Set
        End Property
        Public Property Id() As String
            Get
                Return _Id
            End Get
            Set(ByVal value As String)
                _Id = value
            End Set
        End Property

        Public Property Name() As String
            Get
                Return _Name
            End Get
            Set(ByVal value As String)
                _Name = value
            End Set
        End Property

        Public Property CoachInactive() As Boolean
            Get
                Return _CoachInactive
            End Get
            Set(ByVal value As Boolean)
                _CoachInactive = value
            End Set
        End Property


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

        Public Property DistrictId() As String
            Get
                Return _DistrictId
            End Get
            Set(ByVal value As String)
                _DistrictId = value
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

        Public Property DistrictCoordId() As String
            Get
                Return _DistrictCoordId
            End Get
            Set(ByVal value As String)
                _DistrictCoordId = value
            End Set
        End Property

        Public Property DistrictCoordName() As String
            Get
                Return _DistrictCoordName
            End Get
            Set(ByVal value As String)
                _DistrictCoordName = value
            End Set
        End Property

        Public Property HeaderText() As String
            Get
                Return _headerText
            End Get
            Set(ByVal value As String)
                _headerText = value
            End Set
        End Property


        Public Property NavigationText() As String
            Get
                Return _navText1
            End Get
            Set(ByVal value As String)
                _navText1 = value
            End Set
        End Property

        Public Property NavigationStatus() As String
            Get
                Return _navStatus1
            End Get
            Set(ByVal value As String)
                _navStatus1 = value
            End Set
        End Property

        Public Property NavigationLink() As String
            Get
                Return _navLink1
            End Get
            Set(ByVal value As String)
                _navLink1 = value
            End Set
        End Property


        Public Property HeaderText1() As String
            Get
                Return _headerText1
            End Get
            Set(ByVal value As String)
                _headerText1 = value
            End Set
        End Property
        Public Property NavigationText1() As String
            Get
                Return _navText1
            End Get
            Set(ByVal value As String)
                _navText1 = value
            End Set
        End Property

        Public Property NavigationStatus1() As String
            Get
                Return _navStatus1
            End Get
            Set(ByVal value As String)
                _navStatus1 = value
            End Set
        End Property

        Public Property NavigationLink1() As String
            Get
                Return _navLink1
            End Get
            Set(ByVal value As String)
                _navLink1 = value
            End Set
        End Property



        ''' <summary>
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>

        Public Property HeaderText2() As String
            Get
                Return _headerText2
            End Get
            Set(ByVal value As String)
                _headerText2 = value
            End Set
        End Property
        Public Property NavigationText2() As String
            Get
                Return _navText2
            End Get
            Set(ByVal value As String)
                _navText2 = value
            End Set
        End Property

        Public Property NavigationStatus2() As String
            Get
                Return _navStatus2
            End Get
            Set(ByVal value As String)
                _navStatus2 = value
            End Set
        End Property

        Public Property NavigationLink2() As String
            Get
                Return _navLink2
            End Get
            Set(ByVal value As String)
                _navLink2 = value
            End Set
        End Property


        '''''

        Public Property HeaderText3() As String
            Get
                Return _headerText3
            End Get
            Set(ByVal value As String)
                _headerText3 = value
            End Set
        End Property
        Public Property NavigationText3() As String
            Get
                Return _navText3
            End Get
            Set(ByVal value As String)
                _navText3 = value
            End Set
        End Property

        Public Property NavigationStatus3() As String
            Get
                Return _navStatus3
            End Get
            Set(ByVal value As String)
                _navStatus3 = value
            End Set
        End Property

        Public Property NavigationLink3() As String
            Get
                Return _navLink3
            End Get
            Set(ByVal value As String)
                _navLink3 = value
            End Set
        End Property
        ''

        Public Property HeaderText4() As String
            Get
                Return _headerText4
            End Get
            Set(ByVal value As String)
                _headerText4 = value
            End Set
        End Property
        Public Property NavigationText4() As String
            Get
                Return _navText4
            End Get
            Set(ByVal value As String)
                _navText4 = value
            End Set
        End Property

        Public Property NavigationStatus4() As String
            Get
                Return _navStatus4
            End Get
            Set(ByVal value As String)
                _navStatus4 = value
            End Set
        End Property

        Public Property NavigationLink4() As String
            Get
                Return _navLink4
            End Get
            Set(ByVal value As String)
                _navLink4 = value
            End Set
        End Property

        ''

        Public Property HeaderText5() As String
            Get
                Return _headerText5
            End Get
            Set(ByVal value As String)
                _headerText5 = value
            End Set
        End Property
        Public Property NavigationText5() As String
            Get
                Return _navText5
            End Get
            Set(ByVal value As String)
                _navText5 = value
            End Set
        End Property

        Public Property NavigationStatus5() As String
            Get
                Return _navStatus5
            End Get
            Set(ByVal value As String)
                _navStatus5 = value
            End Set
        End Property

        Public Property NavigationLink5() As String
            Get
                Return _navLink5
            End Get
            Set(ByVal value As String)
                _navLink5 = value
            End Set
        End Property

        ''

        Public Property HeaderText6() As String
            Get
                Return _headerText6
            End Get
            Set(ByVal value As String)
                _headerText6 = value
            End Set
        End Property
        Public Property NavigationText6() As String
            Get
                Return _navText6
            End Get
            Set(ByVal value As String)
                _navText6 = value
            End Set
        End Property

        Public Property NavigationStatus6() As String
            Get
                Return _navStatus6
            End Get
            Set(ByVal value As String)
                _navStatus6 = value
            End Set
        End Property

        Public Property NavigationLink6() As String
            Get
                Return _navLink6
            End Get
            Set(ByVal value As String)
                _navLink6 = value
            End Set
        End Property

        ''''

        Public Property HeaderText7() As String
            Get
                Return _headerText7
            End Get
            Set(ByVal value As String)
                _headerText7 = value
            End Set
        End Property
        Public Property NavigationText7() As String
            Get
                Return _navText7
            End Get
            Set(ByVal value As String)
                _navText7 = value
            End Set
        End Property

        Public Property NavigationStatus7() As String
            Get
                Return _navStatus7
            End Get
            Set(ByVal value As String)
                _navStatus7 = value
            End Set
        End Property

        Public Property NavigationLink7() As String
            Get
                Return _navLink7
            End Get
            Set(ByVal value As String)
                _navLink7 = value
            End Set
        End Property


        Public Property HeaderText8() As String
            Get
                Return _headerText8
            End Get
            Set(ByVal value As String)
                _headerText8 = value
            End Set
        End Property
        Public Property NavigationText8() As String
            Get
                Return _navText8
            End Get
            Set(ByVal value As String)
                _navText8 = value
            End Set
        End Property

        Public Property NavigationStatus8() As String
            Get
                Return _navStatus8
            End Get
            Set(ByVal value As String)
                _navStatus8 = value
            End Set
        End Property

        Public Property NavigationLink8() As String
            Get
                Return _navLink8
            End Get
            Set(ByVal value As String)
                _navLink8 = value
            End Set
        End Property
    End Class

    '' Provides a structure for the Navigation Links
    Public Class PBSNavObjectList
        Inherits System.Collections.Generic.List(Of pbsnavigatelistobj)

        Public Sub New()

        End Sub
    End Class

    Public Class DynamicItemTemplate
        ' ITemplate - When implemented by a class, defines the Control object
        ' to which child controls and templates belong. These child controls 
        ' are in turn defined within an inline template.
        Implements ITemplate

        Public Overridable Overloads Sub InstantiateIn(ByVal container As Control) Implements ITemplate.InstantiateIn
            ' InstantiateIn - When implemented by a class, defines the Control 
            ' object to which child controls and templates belong. These child 
            ' controls are, in turn, defined within an inline template.
            ' 
            ' Create an instance of a CheckBox object.
            Dim oCheckBox As CheckBox = New CheckBox()
            oCheckBox.AutoPostBack = True

            ' When the DataBinding event of the CheckBox fires, call the sub 
            ' BindCheckBox to properly bind.  
            AddHandler oCheckBox.DataBinding, AddressOf BindCheckBox
            AddHandler oCheckBox.CheckedChanged, AddressOf onCheckChanged

            'Add the CheckBox to the controls collection.
            container.Controls.Add(oCheckBox)
            ' oCheckBox.Attributes.Add("onclick", "return confirm('Are you sure you want to do this?');")
            oCheckBox.Attributes.Add("onclick", "if (!confirm('Are you sure you want to inactivate?')){return false;}")

        End Sub


        Public Sub BindCheckBox(ByVal sender As Object, ByVal e As EventArgs)
            'Create a new instance of a CheckBox. 
            Dim oCheckBox As CheckBox = CType(sender, CheckBox)
            Dim container As DataGridItem = CType(oCheckBox.NamingContainer, DataGridItem)
            'Evaluate the data from the Grid item and set the Checked property 
            ' appropriatly

            'If C21MIT.PBSIS.BLL.pbsfmhinavigate.gefmhidistcoachlist(C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(HttpContext.Current.Request.QueryString("DistID")), "DCoachAM").PBSGridviewNavObjectListobj.Item(0) Is Nothing Then
            '    oCheckBox.Checked = False
            '    oCheckBox.ID = container.DataItem("Id")
            'Else
            '    oCheckBox.Checked = True
            '    oCheckBox.ID = container.DataItem("Id")
            'End If



        End Sub


        Public Sub onCheckChanged(ByVal Sender As Object, ByVal e As System.EventArgs)

            Dim box As CheckBox = DirectCast(Sender, CheckBox)

            Dim container As DataGridItem = DirectCast(box.NamingContainer, DataGridItem)

            Dim objFMHIAddDistrictCoachProfile As New C21MIT.PBSIS.BO.pbscoachprofile


            If Integer.Parse(container.Cells(0).Text) = Nothing Then
                Exit Sub
            Else
                objFMHIAddDistrictCoachProfile.CoachID = Integer.Parse(container.Cells(0).Text)
                objFMHIAddDistrictCoachProfile.CoachInactive = 1
                C21MIT.PBSIS.BLL.pbsfmhi.updfmhidistcoachinactive(objFMHIAddDistrictCoachProfile)

            End If


        End Sub


    End Class
 
End Namespace