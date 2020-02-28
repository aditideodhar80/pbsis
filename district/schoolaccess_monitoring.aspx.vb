'-------------------------------------------------------------------------------------------------------------------
' Created By : Aditi Deodhar
'-------------------------------------------------------------------------------------------------------------------
Imports System.Data
Imports Microsoft.VisualBasic
Imports System.Data.SqlClient

Partial Class district_district_monitoring
    Inherits System.Web.UI.Page

    Dim distId As String

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        C21MIT.PBSIS.BLL.pbsloginsession.chkloginsession("dist")

        If Not Request.QueryString("qOptId") Is Nothing Then
            getdistid()

            If Request.QueryString("qOptId") = "MidYearMon" Then
                getmidyrmonresults(Request.QueryString("qOptId"), distId, C21MIT.PBSIS.BLL.pbslogindetails.GetCurrentPrimTracker.schoolyear)
                lblMonHeading.Text = C21MIT.PBSIS.BLL.pbsdisnavigate.getyearmon(Request.QueryString("qOptId"), distId, C21MIT.PBSIS.BLL.pbslogindetails.GetCurrentPrimTracker.schoolyear).PageTitle
                lblDistName.Text = C21MIT.PBSIS.BLL.pbsdisnavigate.getyearmon(Request.QueryString("qOptId"), distId, C21MIT.PBSIS.BLL.pbslogindetails.GetCurrentPrimTracker.schoolyear).DistrictName
                lblYear.Text = C21MIT.PBSIS.BLL.pbsschoolyeardesc.getschoolyeardesc(C21MIT.PBSIS.BLL.pbslogindetails.GetCurrentPrimTracker.schoolyear)

            ElseIf Request.QueryString("qOptId") = "EndYearMon" Then
                lblsheetdetails.Visible = True
                getendyrmonresults(Request.QueryString("qOptId"), distId, C21MIT.PBSIS.BLL.pbslogindetails.GetCurrentPrimTracker.schoolyear)
                lblMonHeading.Text = C21MIT.PBSIS.BLL.pbsdisnavigate.getyearmon(Request.QueryString("qOptId"), distId, C21MIT.PBSIS.BLL.pbslogindetails.GetCurrentPrimTracker.schoolyear).PageTitle
                lblDistName.Text = C21MIT.PBSIS.BLL.pbsdisnavigate.getyearmon(Request.QueryString("qOptId"), distId, C21MIT.PBSIS.BLL.pbslogindetails.GetCurrentPrimTracker.schoolyear).DistrictName
                lblYear.Text = C21MIT.PBSIS.BLL.pbsschoolyeardesc.getschoolyeardesc(C21MIT.PBSIS.BLL.pbslogindetails.GetCurrentPrimTracker.schoolyear)

            ElseIf Request.QueryString("qOptId") = "MidYearSLR" Then
                getmidyrslrresults(Request.QueryString("qOptId"), distId)
                lblMonHeading.Text = C21MIT.PBSIS.BLL.pbsdisnavigate.getschoollevelreports(Request.QueryString("qOptId"), distId).PageTitle
                lblDistName.Text = C21MIT.PBSIS.BLL.pbsdisnavigate.getschoollevelreports(Request.QueryString("qOptId"), distId).DistrictName
                lblYear.Text = C21MIT.PBSIS.BLL.pbsschoolyeardesc.getschoolyeardesc(C21MIT.PBSIS.BLL.pbslogindetails.GetCurrentPrimTracker.schoolyear)

            ElseIf Request.QueryString("qOptId") = "EndYearSLR" Then
                getendyrslrresults(Request.QueryString("qOptId"), distId)
                lblMonHeading.Text = C21MIT.PBSIS.BLL.pbsdisnavigate.getschoollevelreports(Request.QueryString("qOptId"), distId).PageTitle
                lblDistName.Text = C21MIT.PBSIS.BLL.pbsdisnavigate.getschoollevelreports(Request.QueryString("qOptId"), distId).DistrictName
                lblYear.Text = C21MIT.PBSIS.BLL.pbsschoolyeardesc.getschoolyeardesc(C21MIT.PBSIS.BLL.pbslogindetails.GetCurrentPrimTracker.schoolyear)
            End If
        End If
    End Sub

    Sub getdistid()
        If Not Request.QueryString("DistId") Is Nothing Then
            distId = C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("DistId"))
        Else
            distId = Session("sDistId")
        End If
    End Sub

    Sub getmidyrmonresults(ByVal optid As String, ByVal distid As String, ByVal yr As String)
        'just assign the dyanmic links here to the columns
        Dim nameColumn1 As New BoundColumn
        nameColumn1.DataField = "SchoolName"
        nameColumn1.DataFormatString = "{0}"
        nameColumn1.HeaderText = "School"
        'nameColumn1.HeaderStyle.HorizontalAlign = HorizontalAlign.Center
        gvDynamic.Columns.Add(nameColumn1)
        nameColumn1.HeaderStyle.Wrap = False
        With nameColumn1
            .ItemStyle.Width = "400"
            .HeaderStyle.HorizontalAlign = HorizontalAlign.Left
            .HeaderStyle.Font.Bold = True
            .HeaderStyle.Font.Size = 11
        End With

        Dim nameColumn2 As New HyperLinkColumn
        nameColumn2.DataTextField = "NavigationText2"
        nameColumn2.HeaderText = "School Profile"
        nameColumn2.DataNavigateUrlField = "NavigationLink2"
        gvDynamic.Columns.Add(nameColumn2)
        With nameColumn2
            .ItemStyle.Width = "200"
            .HeaderStyle.HorizontalAlign = HorizontalAlign.Left
            .HeaderStyle.Font.Bold = True
            .HeaderStyle.Font.Size = 11
        End With

        Dim nameColumn3 As New HyperLinkColumn
        nameColumn3.DataTextField = "NavigationText1"
        nameColumn3.HeaderText = "PBS Implementation Checklist-Fall"
        nameColumn3.DataNavigateUrlField = "NavigationLink1"
        gvDynamic.Columns.Add(nameColumn3)
        With nameColumn3
            .ItemStyle.Width = "200"
            .HeaderStyle.HorizontalAlign = HorizontalAlign.Left
            .HeaderStyle.Font.Bold = True
            .HeaderStyle.Font.Size = 11
        End With

        Dim nameColumn4 As New HyperLinkColumn
        nameColumn4.DataTextField = "NavigationText3"
        nameColumn4.HeaderText = "PBS Implementation Checklist-Spring"
        nameColumn4.DataNavigateUrlField = "NavigationLink3"
        gvDynamic.Columns.Add(nameColumn4)
        With nameColumn4
            .ItemStyle.Width = "200"
            .HeaderStyle.HorizontalAlign = HorizontalAlign.Left
            .HeaderStyle.Font.Bold = True
            .HeaderStyle.Font.Size = 11
        End With
        gvDynamic.AutoGenerateColumns = False

        gvDynamic.DataSource = C21MIT.PBSIS.BLL.pbsdisnavigate.getyearmon(optid, distid, yr).PBSGridviewNavObjectListobj
        gvDynamic.DataBind()
    End Sub

    Sub getendyrmonresults(ByVal optid As String, ByVal distid As String, ByVal yr As String)
        'just assign the dyanmic links here to the columns

        Dim nameColumn1 As New BoundColumn
        nameColumn1.DataField = "SchoolName"
        nameColumn1.DataFormatString = "{0}"
        nameColumn1.HeaderText = "School"
        gvDynamic.Columns.Add(nameColumn1)
        nameColumn1.HeaderStyle.Wrap = False
        With nameColumn1
            .ItemStyle.Width = "280"
            .ItemStyle.HorizontalAlign = HorizontalAlign.Left
            .HeaderStyle.HorizontalAlign = HorizontalAlign.Left
            .HeaderStyle.Font.Bold = True
            .HeaderStyle.Font.Size = 11
        End With

        Dim nameColumn2 As New HyperLinkColumn
        nameColumn2.DataTextField = "NavigationText1"
        nameColumn2.HeaderText = "Benchmarks of Quality"
        nameColumn2.DataNavigateUrlField = "NavigationLink1"
        gvDynamic.Columns.Add(nameColumn2)
        With nameColumn2
            .ItemStyle.Width = "200"
            .ItemStyle.HorizontalAlign = HorizontalAlign.Left
            .HeaderStyle.HorizontalAlign = HorizontalAlign.Left
            .HeaderStyle.Font.Bold = True
            .HeaderStyle.Font.Size = 11
        End With

        Dim nameColumn3 As New HyperLinkColumn
        nameColumn3.DataTextField = "NavigationText2"
        nameColumn3.HeaderText = "Outcome Data Summary"
        nameColumn3.DataNavigateUrlField = "NavigationLink2"
        gvDynamic.Columns.Add(nameColumn3)
        With nameColumn2
            .ItemStyle.Width = "200"
            .ItemStyle.HorizontalAlign = HorizontalAlign.Left
            .HeaderStyle.HorizontalAlign = HorizontalAlign.Left
            .HeaderStyle.Font.Bold = True
            .HeaderStyle.Font.Size = 11
        End With


        Dim nameColumn4 As New HyperLinkColumn
        nameColumn4.DataTextField = "NavigationText3"
        nameColumn4.HeaderText = "Benchmark for Advance Tier"
        nameColumn4.DataNavigateUrlField = "NavigationLink3"
        gvDynamic.Columns.Add(nameColumn4)
        With nameColumn2
            .ItemStyle.Width = "200"
            .ItemStyle.HorizontalAlign = HorizontalAlign.Left
            .HeaderStyle.HorizontalAlign = HorizontalAlign.Left
            .HeaderStyle.Font.Bold = True
            .HeaderStyle.Font.Size = 11
        End With

        gvDynamic.AutoGenerateColumns = False
        ' gvDynamic.DataSource = C21MIT.PBSIS.BLL.pbsdisnavigate.getyearmon(optid, distid, Session("ActYrId")).PBSGridviewNavObjectListobj
        gvDynamic.DataSource = C21MIT.PBSIS.BLL.pbsdisnavigate.getyearmon(optid, distid, yr).PBSGridviewNavObjectListobj
        gvDynamic.DataBind()
    End Sub

    Sub getmidyrslrresults(ByVal optid As String, ByVal distid As String)
        'just assign the dyanmic links here to the columns
        Dim nameColumn1 As New BoundColumn
        nameColumn1.DataField = "SchoolName"
        nameColumn1.DataFormatString = "{0}"
        nameColumn1.HeaderText = "School"
        'nameColumn1.HeaderStyle.HorizontalAlign = HorizontalAlign.Center
        gvDynamic.Columns.Add(nameColumn1)
        nameColumn1.HeaderStyle.Wrap = False
        With nameColumn1
            .ItemStyle.Width = "600"
            .HeaderStyle.HorizontalAlign = HorizontalAlign.Left
            .HeaderStyle.Font.Bold = True
            .HeaderStyle.Font.Size = 11
        End With

        Dim nameColumn2 As New HyperLinkColumn
        nameColumn2.DataTextField = "NavigationText1"
        'nameColumn2.HeaderText = "PIC Tier1 Critical Element"
        nameColumn2.DataNavigateUrlField = "NavigationLink1"
        gvDynamic.Columns.Add(nameColumn2)
        With nameColumn2
            .ItemStyle.Width = "200"
            .HeaderStyle.HorizontalAlign = HorizontalAlign.Left
            .HeaderStyle.Font.Bold = True
            .HeaderStyle.Font.Size = 11
        End With

        Dim nameColumn3 As New HyperLinkColumn
        nameColumn3.DataTextField = "NavigationText2"
        'nameColumn3.HeaderText = "PIC Implementation Level"
        nameColumn3.DataNavigateUrlField = "NavigationLink2"
        gvDynamic.Columns.Add(nameColumn3)
        With nameColumn3
            .ItemStyle.Width = "200"
            .HeaderStyle.HorizontalAlign = HorizontalAlign.Left
            .HeaderStyle.Font.Bold = True
            .HeaderStyle.Font.Size = 11
        End With

        gvDynamic.AutoGenerateColumns = False

        gvDynamic.DataSource = C21MIT.PBSIS.BLL.pbsdisnavigate.getschoollevelreports(optid, distid).PBSGridviewNavObjectListobj
        gvDynamic.DataBind()
    End Sub

    Sub getendyrslrresults(ByVal optid As String, ByVal distid As String)
        'just assign the dyanmic links here to the columns
        Dim nameColumn1 As New BoundColumn
        nameColumn1.DataField = "SchoolName"
        nameColumn1.DataFormatString = "{0}"
        nameColumn1.HeaderText = "School"
        'nameColumn1.HeaderStyle.HorizontalAlign = HorizontalAlign.Center
        gvDynamic.Columns.Add(nameColumn1)
        nameColumn1.HeaderStyle.Wrap = False
        With nameColumn1
            .ItemStyle.Width = "260"
            .HeaderStyle.HorizontalAlign = HorizontalAlign.Left
            .HeaderStyle.Font.Bold = True
            .HeaderStyle.Font.Size = 11
        End With

        Dim nameColumn2 As New HyperLinkColumn
        nameColumn2.DataTextField = "NavigationText1"
        ' nameColumn2.HeaderText = "ODR"
        nameColumn2.DataNavigateUrlField = "NavigationLink1"
        gvDynamic.Columns.Add(nameColumn2)
        With nameColumn2
            .ItemStyle.Width = "40"
            .HeaderStyle.HorizontalAlign = HorizontalAlign.Left
            .HeaderStyle.Font.Bold = True
            .HeaderStyle.Font.Size = 11
        End With

        Dim nameColumn3 As New HyperLinkColumn
        nameColumn3.DataTextField = "NavigationText2"
        'nameColumn3.HeaderText = "ODR/100"
        nameColumn3.DataNavigateUrlField = "NavigationLink2"
        gvDynamic.Columns.Add(nameColumn3)
        With nameColumn3
            .ItemStyle.Width = "40"
            .HeaderStyle.HorizontalAlign = HorizontalAlign.Right
            .HeaderStyle.Font.Bold = True
            .HeaderStyle.Font.Size = 11
        End With


        Dim nameColumn4 As New HyperLinkColumn
        nameColumn4.DataTextField = "NavigationText3"
        ' nameColumn4.HeaderText = "ISS/OSS"
        nameColumn4.DataNavigateUrlField = "NavigationLink3"
        gvDynamic.Columns.Add(nameColumn4)
        With nameColumn3
            .ItemStyle.Width = "50"
            .HeaderStyle.HorizontalAlign = HorizontalAlign.Left
            .HeaderStyle.Font.Bold = True
            .HeaderStyle.Font.Size = 11
        End With

        Dim nameColumn5 As New HyperLinkColumn
        nameColumn5.DataTextField = "NavigationText4"
        ' nameColumn5.HeaderText = "ISS/OSS/100"
        nameColumn5.DataNavigateUrlField = "NavigationLink4"
        gvDynamic.Columns.Add(nameColumn5)
        With nameColumn3
            .ItemStyle.Width = "60"
            .HeaderStyle.HorizontalAlign = HorizontalAlign.Left
            .HeaderStyle.Font.Bold = True
            .HeaderStyle.Font.Size = 11
        End With


        Dim nameColumn6 As New HyperLinkColumn
        nameColumn6.DataTextField = "NavigationText5"
        ' nameColumn6.HeaderText = "Attend."
        nameColumn6.DataNavigateUrlField = "NavigationLink5"
        gvDynamic.Columns.Add(nameColumn6)
        With nameColumn3
            .ItemStyle.Width = "60"
            .HeaderStyle.HorizontalAlign = HorizontalAlign.Left
            .HeaderStyle.Font.Bold = True
            .HeaderStyle.Font.Size = 11
        End With

        Dim nameColumn7 As New HyperLinkColumn
        nameColumn7.DataTextField = "NavigationText6"
        'nameColumn7.HeaderText = "BoQ."
        nameColumn7.DataNavigateUrlField = "NavigationLink6"
        gvDynamic.Columns.Add(nameColumn7)
        With nameColumn3
            .ItemStyle.Width = "60"
            .HeaderStyle.HorizontalAlign = HorizontalAlign.Left
            .HeaderStyle.Font.Bold = True
            .HeaderStyle.Font.Size = 11
        End With


        Dim nameColumn8 As New HyperLinkColumn
        nameColumn8.DataTextField = "NavigationText7"
        'nameColumn7.HeaderText = "BoQ."
        nameColumn8.DataNavigateUrlField = "NavigationLink7"
        gvDynamic.Columns.Add(nameColumn8)
        With nameColumn3
            .ItemStyle.Width = "60"
            .HeaderStyle.HorizontalAlign = HorizontalAlign.Center
            .HeaderStyle.Font.Bold = True
            .HeaderStyle.Font.Size = 11
        End With

        Dim nameColumn9 As New HyperLinkColumn
        nameColumn9.DataTextField = "NavigationText8"
        'nameColumn7.HeaderText = "BoQ."
        nameColumn9.DataNavigateUrlField = "NavigationLink8"
        gvDynamic.Columns.Add(nameColumn9)
        With nameColumn3
            .ItemStyle.Width = "80"
            .HeaderStyle.HorizontalAlign = HorizontalAlign.Right
            .HeaderStyle.Font.Bold = True
            .HeaderStyle.Font.Size = 11
        End With

        gvDynamic.AutoGenerateColumns = False

        gvDynamic.DataSource = C21MIT.PBSIS.BLL.pbsdisnavigate.getschoollevelreports(optid, distid).PBSGridviewNavObjectListobj
        gvDynamic.DataBind()
    End Sub
End Class
