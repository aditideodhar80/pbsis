'-------------------------------------------------------------------------------------------------------------------
' Created By : Aditi Deodhar
' Created Dt : March 24,2010
' Last Updated Dt : March 24,2010
'-------------------------------------------------------------------------------------------------------------------
Partial Class fmhiadmin_fmhi_mainmenu
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        C21MIT.PBSIS.BLL.pbsloginsession.chkloginsession("fmhiadm")
        lblMonHeading.Text = C21MIT.PBSIS.BLL.pbsfmhinavigate.gefmhidistlist("AH").PageTitle
        getpbsadminhome()
    End Sub

    Sub getpbsadminhome()

        Dim nameColumn1 As New BoundColumn
        nameColumn1.DataField = "Name"
        nameColumn1.DataFormatString = "{0}"
        nameColumn1.HeaderText = "District"
        gvDynamicFMHI.Columns.Add(nameColumn1)
        nameColumn1.HeaderStyle.Wrap = False
        With nameColumn1
            .ItemStyle.Width = "250"
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


        Dim nameColumn3 As New HyperLinkColumn
        nameColumn3.DataTextField = "NavigationText2"
        nameColumn3.DataNavigateUrlField = "NavigationLink2"
        gvDynamicFMHI.Columns.Add(nameColumn3)
        nameColumn3.HeaderStyle.Wrap = False
        With nameColumn3
            .ItemStyle.Width = "100"
            .HeaderStyle.HorizontalAlign = HorizontalAlign.Left
            .HeaderStyle.Font.Bold = True
            .HeaderStyle.Font.Size = 11
        End With



        Dim nameColumn4 As New HyperLinkColumn
        nameColumn4.DataTextField = "NavigationText3"
        nameColumn4.DataNavigateUrlField = "NavigationLink3"
        gvDynamicFMHI.Columns.Add(nameColumn4)
        nameColumn4.HeaderStyle.Wrap = False
        With nameColumn4
            .ItemStyle.Width = "100"
            .HeaderStyle.HorizontalAlign = HorizontalAlign.Left
            .HeaderStyle.Font.Bold = True
            .HeaderStyle.Font.Size = 11
        End With


        Dim nameColumn5 As New HyperLinkColumn
        nameColumn5.DataTextField = "NavigationText4"
        nameColumn5.DataNavigateUrlField = "NavigationLink4"
        gvDynamicFMHI.Columns.Add(nameColumn5)
        nameColumn5.HeaderStyle.Wrap = False
        With nameColumn5
            .ItemStyle.Width = "100"
            .HeaderStyle.HorizontalAlign = HorizontalAlign.Left
            .HeaderStyle.Font.Bold = True
            .HeaderStyle.Font.Size = 11
        End With


        Dim nameColumn6 As New HyperLinkColumn
        nameColumn6.DataTextField = "NavigationText5"
        nameColumn6.DataNavigateUrlField = "NavigationLink5"
        gvDynamicFMHI.Columns.Add(nameColumn6)
        nameColumn6.HeaderStyle.Wrap = False
        With nameColumn5
            .ItemStyle.Width = "100"
            .HeaderStyle.HorizontalAlign = HorizontalAlign.Left
            .HeaderStyle.Font.Bold = True
            .HeaderStyle.Font.Size = 11
        End With


        Dim nameColumn7 As New HyperLinkColumn
        nameColumn7.DataTextField = "NavigationText6"
        nameColumn7.DataNavigateUrlField = "NavigationLink6"
        gvDynamicFMHI.Columns.Add(nameColumn7)
        nameColumn7.HeaderStyle.Wrap = False
        With nameColumn5
            .ItemStyle.Width = "100"
            .HeaderStyle.HorizontalAlign = HorizontalAlign.Left
            .HeaderStyle.Font.Bold = True
            .HeaderStyle.Font.Size = 11
        End With

        gvDynamicFMHI.AutoGenerateColumns = False

        gvDynamicFMHI.DataSource = C21MIT.PBSIS.BLL.pbsfmhinavigate.gefmhidistlist("AH").PBSGridviewNavObjectListobj
        gvDynamicFMHI.DataBind()
    End Sub
End Class
