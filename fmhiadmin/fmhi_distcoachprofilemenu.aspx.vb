'-------------------------------------------------------------------------------------------------------------------
' Created By : Aditi Deodhar
' Created Dt : April 02,2010
' Last Updated Dt : April 02,2010
'-------------------------------------------------------------------------------------------------------------------

Partial Class fmhiadmin_fmhi_distcoachprofilemenu
    Inherits System.Web.UI.Page

    Protected Sub Page_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init
        lblMonHeading.Text = C21MIT.PBSIS.BLL.pbsfmhinavigate.gefmhidistcoachlist("", "DCoachAM").PageTitle
        lblDistName.Text = C21MIT.PBSIS.BLL.pbsdistrict.getdistname(C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistID"))).DistrictName
        getpbsdistcoachacct()
    End Sub

 
    'Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    '    'C21MIT.PBSIS.BLL.pbsloginsession.chkloginsession("fmhiadm")

    '    lblMonHeading.Text = C21MIT.PBSIS.BLL.pbsfmhinavigate.gefmhidistcoachlist("", "DCoachAM").PageTitle
    '    lblDistName.Text = C21MIT.PBSIS.BLL.pbsdistrict.getdistname(C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistID"))).DistrictName
    '    getpbsdistcoachacct()
    'End Sub

    Sub getpbsdistcoachacct()
        Dim nameColumn4 As New BoundColumn
        nameColumn4.DataField = "Id"
        nameColumn4.Visible = False
        nameColumn4.HeaderText = "Coach Id"
        gvDynamicFMHI.Columns.Add(nameColumn4)
        nameColumn4.HeaderStyle.Wrap = False
        With nameColumn4
            .ItemStyle.Width = "100"
            .HeaderStyle.HorizontalAlign = HorizontalAlign.Left
            .HeaderStyle.Font.Bold = True
            .HeaderStyle.Font.Size = 11
        End With

        Dim nameColumn1 As New BoundColumn
        nameColumn1.DataField = "Name"
        nameColumn1.DataFormatString = "{0}"
        nameColumn1.HeaderText = "District Coaches"
        gvDynamicFMHI.Columns.Add(nameColumn1)
        nameColumn1.HeaderStyle.Wrap = False
        With nameColumn1
            .ItemStyle.Width = "180"
            .HeaderStyle.HorizontalAlign = HorizontalAlign.Left
            .HeaderStyle.Font.Bold = True
            .HeaderStyle.Font.Size = 11
        End With

        Dim nameColumn2 As New HyperLinkColumn
        nameColumn2.DataTextField = "NavigationText1"
        nameColumn2.DataNavigateUrlField = "NavigationLink1"
        gvDynamicFMHI.Columns.Add(nameColumn2)
        nameColumn2.HeaderStyle.Wrap = False
        With nameColumn2
            .ItemStyle.Width = "100"
            .HeaderStyle.HorizontalAlign = HorizontalAlign.Left
            .HeaderStyle.Font.Bold = True
            .HeaderStyle.Font.Size = 11
        End With

        Dim nameColumn3 As New TemplateColumn
        nameColumn3.HeaderText = "Inactive (Check box to inactivate)"
        nameColumn3.HeaderStyle.HorizontalAlign = HorizontalAlign.Center
        nameColumn3.ItemTemplate = New DynamicItemTemplate()
        gvDynamicFMHI.Columns.Add(nameColumn3)
        nameColumn3.HeaderStyle.Wrap = False
        With nameColumn3
            .ItemStyle.Width = "100"
            .HeaderStyle.HorizontalAlign = HorizontalAlign.Left
            .HeaderStyle.Font.Bold = True
            .HeaderStyle.Font.Size = 11
        End With

        gvDynamicFMHI.AutoGenerateColumns = False

        If Not Request.QueryString("DistID") Is Nothing Then
            If Not C21MIT.PBSIS.BLL.pbsfmhinavigate.gefmhidistcoachlist(C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistID")), "DCoachAM").PBSGridviewNavObjectListobj Is Nothing Then
                gvDynamicFMHI.DataSource = C21MIT.PBSIS.BLL.pbsfmhinavigate.gefmhidistcoachlist(C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistID")), "DCoachAM").PBSGridviewNavObjectListobj
                gvDynamicFMHI.DataBind()
            Else
                If C21MIT.PBSIS.BLL.pbsfmhinavigate.gefmhidistcoachlist(C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistID")), "DCoachAM").PBSGridviewNavObjectListobj Is Nothing Then
                    gvDynamicFMHI.Caption = "No records found"
                    gvDynamicFMHI.ShowFooter = True
                End If
            End If
        End If

    End Sub


    Protected Sub hyladdDistCoord_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles hyladdDistCoord.Click
        Response.Redirect("fmhi_distcoaches_addupdate.aspx?Status=New")
    End Sub

    Protected Sub gvDynamicFMHI_ItemDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs) Handles gvDynamicFMHI.ItemDataBound

    End Sub


    Public Sub DataGrid1_PageIndexChanged(ByVal source As Object, _
    ByVal e As System.Web.UI.WebControls.DataGridPageChangedEventArgs) _
    Handles gvDynamicFMHI.PageIndexChanged
        gvDynamicFMHI.CurrentPageIndex = e.NewPageIndex
        gvDynamicFMHI.DataBind()
    End Sub

    Public Class DynamicItemTemplate
        ' ITemplate - When implemented by a class, defines the Control object
        ' to which child controls and templates belong. These child controls 
        ' are in turn defined within an inline template.
        Implements ITemplate

        Public Overridable Overloads Sub InstantiateIn(ByVal container As Control) Implements ITemplate.InstantiateIn
            ' InstantiateIn - When implemented by a class, defines the Control 
            ' object to which child controls and templates belong. These child 
            ' controls are, in turn, defined within an inline template.

            ' Create an instance of a CheckBox object.
            Dim oCheckBox As CheckBox = New CheckBox()

            '' When the DataBinding event of the CheckBox fires, call the sub 
            '' BindCheckBox to properly bind.  
            AddHandler oCheckBox.DataBinding, AddressOf BindCheckBox
            AddHandler oCheckBox.CheckedChanged, AddressOf onCheckChanged


            oCheckBox.AutoPostBack = True
            ''Add the CheckBox to the controls collection.
            container.Controls.Add(oCheckBox)
            ''oCheckBox.Attributes.Add("onclick", "return confirm('Are you sure you want to do this?');")
            oCheckBox.Attributes.Add("onclick", "if (!confirm('Are you sure you want to inactivate?')){return false;}")
            'oCheckBox.Attributes.Add("onclick", "if (confirm('Are you sure you want to inactivate?')); __doPostBack('oCheckBox','');")


        End Sub


        Public Sub BindCheckBox(ByVal sender As Object, ByVal e As EventArgs)
            'Create a new instance of a CheckBox. 
            Dim oCheckBox As CheckBox = CType(sender, CheckBox)
            Dim container As DataGridItem = CType(oCheckBox.NamingContainer, DataGridItem)
            'Evaluate the data from the Grid item and set the Checked property 
            ' appropriatly

            If DirectCast(DirectCast(container.DataItem, System.Object), C21MIT.PBSIS.BO.pbsnavigatelistobj).CoachInactive = "True" Then
                oCheckBox.Checked = 1
            Else
                oCheckBox.Checked = 0
            End If
        End Sub

        Shared Sub onCheckChanged(ByVal Sender As Object, ByVal e As System.EventArgs)
            Dim box As CheckBox = DirectCast(Sender, CheckBox)
            Dim container As DataGridItem = DirectCast(box.NamingContainer, DataGridItem)
            Dim objFMHIAddDistrictCoachProfile As New C21MIT.PBSIS.BO.pbscoachprofile

            objFMHIAddDistrictCoachProfile.CoachID = Integer.Parse(container.Cells(0).Text)
            If box.Checked = True Then
                objFMHIAddDistrictCoachProfile.CoachInactive = 1
            ElseIf box.Checked = False Then
                objFMHIAddDistrictCoachProfile.CoachInactive = 0
            End If
            C21MIT.PBSIS.BLL.pbsfmhi.updfmhidistcoachinactive(objFMHIAddDistrictCoachProfile)

          
        End Sub


        Shared Sub bindata()

            Dim gvDynamicFMHI As New DataGrid
            If Not HttpContext.Current.Request.QueryString("DistID") Is Nothing Then
                If Not C21MIT.PBSIS.BLL.pbsfmhinavigate.gefmhidistcoachlist(C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(HttpContext.Current.Request.QueryString("DistID")), "DCoachAM").PBSGridviewNavObjectListobj Is Nothing Then
                    gvDynamicFMHI.DataSource = C21MIT.PBSIS.BLL.pbsfmhinavigate.gefmhidistcoachlist(C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(HttpContext.Current.Request.QueryString("DistID")), "DCoachAM").PBSGridviewNavObjectListobj
                    gvDynamicFMHI.DataBind()
                Else
                    If C21MIT.PBSIS.BLL.pbsfmhinavigate.gefmhidistcoachlist(C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(HttpContext.Current.Request.QueryString("DistID")), "DCoachAM").PBSGridviewNavObjectListobj Is Nothing Then
                        gvDynamicFMHI.Caption = "No records found"
                        gvDynamicFMHI.ShowFooter = True
                    End If
                End If
            End If
        End Sub
    End Class


End Class
