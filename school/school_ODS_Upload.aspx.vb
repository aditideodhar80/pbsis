'-------------------------------------------------------------------------------------------------------------------
' Created By : Aditi Deodhar
' Created Dt : Feb 18,2010
' Last Updated Dt : Feb 19,2010
'-------------------------------------------------------------------------------------------------------------------
Partial Class school_school_ODS_Upload
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            C21MIT.PBSIS.BLL.pbsloginsession.chkloginsession("School")

            If Session("accttype") = "District" Or Session("accttype") = "FMHI" Then
                pnlUpl.Visible = False
                lblDataSAved.Visible = False
                btnDocDelete.Visible = False
                gvDocs.Columns(2).Visible = False
                btnback.Text = "Back to the Main Menu"
            ElseIf Session("accttype") = "School" Then
                pnlUpl.Visible = True
                lblDataSAved.Visible = True
                btnDocDelete.Visible = True
                gvDocs.Columns(2).Visible = True
            End If

            Dim objODS As New C21MIT.PBSIS.BO.pbsods

            If Not Request.QueryString("sRptSchID") Is Nothing Then
                objODS.SchoolID = C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("sRptSchID"))
            Else
                objODS.SchoolID = Session("MM_Username")
            End If

            If Not Request.QueryString("Yr") Is Nothing Then
                objODS.SchoolYear = C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("Yr"))
            Else
                objODS.SchoolYear = C21MIT.PBSIS.BLL.pbslogindetails.GetCurrentPrimTracker.schoolyear
            End If

            bindata(objODS.SchoolID, objODS.SchoolYear)

            If Not Request.QueryString("P") Is Nothing Then
                lblDataSAved.Visible = False
                binddocdridvieweditload(objODS.SchoolID)
            End If
        End If
    End Sub

    Sub bindata(ByVal schoolID As String, ByVal schoolYr As String)
        lblSchoolName.Text = C21MIT.PBSIS.BLL.pbsschoolprofile.getschoolprofile(schoolID).SchoolName
        lblSchoolYr.Text = C21MIT.PBSIS.BLL.pbsschoolyeardesc.getschoolyeardesc(schoolYr)
    End Sub

    Protected Sub btnUpDoc_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnUpDoc.Click
        If Not Request.QueryString("P") Is Nothing Then
            If Not Request.QueryString("Yr") Is Nothing Then
                If C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("Yr")) <> C21MIT.PBSIS.BLL.pbslogindetails.GetCurrentPrimTracker.schoolyear Then
                    'System.Web.HttpContext.Current.Response.Write("<SCRIPT LANGUAGE=""JavaScript"">alert('You cannot upload a document for this year.'); return false;</SCRIPT>")
                    Dim strMessage As String
                    strMessage = "You cannot upload documents for this school year"
                    'finishes server processing, returns to client.
                    Dim strScript As String = "<script language=JavaScript>"
                    strScript += "alert(""" & strMessage & """);"
                    strScript += "</script>"

                    If (Not ClientScript.IsStartupScriptRegistered("clientScript")) Then
                        ClientScript.RegisterClientScriptBlock(Me.GetType(), "clientScript", strScript)
                    End If
                Else
                    binddocdrideditview(C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("Yr")))
                End If
            End If
        Else
            binddocdridview(C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("Yr")))
        End If
    End Sub

    Sub binddocdridview(ByVal SchYR As Integer)
        Dim objODSdocs As New C21MIT.PBSIS.BO.pbsods

        If fluploadODS.PostedFile.FileName = "" Then
        ElseIf fluploadODS.PostedFile.FileName <> "" Then
            Dim v_FileExtension As String
            Dim v_destpath As String
            Dim fileSize As Integer = fluploadODS.PostedFile.ContentLength
            Dim fn As String = Session("MM_Username") & "_" & C21MIT.Util.RandomKeyString.Generate(6) & "_" & System.IO.Path.GetFileName(fluploadODS.PostedFile.FileName)

            Dim fLen As Integer = fn.Length
            v_FileExtension = System.IO.Path.GetExtension(fluploadODS.PostedFile.FileName)

            If C21MIT.PBSIS.BLL.ODSDocuments.isDocFile(v_FileExtension) Then
                v_destpath = C21MIT.PBSIS.BLL.ODSDocuments.getDocumentFolderPath(fn)
                objODSdocs.OdIdOut = Request.QueryString("ODID")
                '                objODSdocs.OdDocName = "0" & C21MIT.PBSIS.BLL.pbsods.getODSOutput(objODSdocs.OdIdOut).OdSchoolIDOut & "_" & C21MIT.Util.RandomKeyString.Generate(6) & "_" & fn.ToLower.ToString
                objODSdocs.OdDocName = fn.ToLower.ToString

                'do not insert
                'objODSdocs.OdSchoolIDOut = C21MIT.PBSIS.BLL.pbsods.getODSOutput(objODSdocs.OdIdOut).OdSchoolIDOut
                'objODSdocs.OdSchYrOut = C21MIT.PBSIS.BLL.pbsods.getODSOutput(objODSdocs.OdIdOut).OdSchYrOut

                fluploadODS.SaveAs(v_destpath)
                C21MIT.PBSIS.BLL.pbsods.addODSSchoolDocuments(objODSdocs)
                'lblDocMessage.Text = "Document was uploaded successfully!"
            End If
        End If

        If C21MIT.PBSIS.BLL.pbsods.getODSDocList(Request.QueryString("ODID"), SchYR).Count > 0 Then
            gvDocs.DataSource = C21MIT.PBSIS.BLL.pbsods.getODSDocList(Request.QueryString("ODID"), SchYR)
            gvDocs.DataBind()
            gvDocs.Visible = True
            lblnodocs.Visible = False
        ElseIf C21MIT.PBSIS.BLL.pbsods.getODSDocList(Request.QueryString("ODID"), SchYR).Count = 0 Then
            lblnodocs.Visible = True
            gvDocs.Visible = False
            gvDocs.EmptyDataText = "No documents uploaded this year for " & C21MIT.PBSIS.BLL.pbsschoolprofile.getschoolprofile(Session("MM_Username")).SchoolName
        End If
    End Sub

    Sub binddocdrideditview(ByVal SchYR As Integer)
        Dim objODSdocs As New C21MIT.PBSIS.BO.pbsods

        If fluploadODS.PostedFile.FileName = "" Then
        ElseIf fluploadODS.PostedFile.FileName <> "" Then
            Dim v_FileExtension As String
            Dim v_destpath As String
            Dim fileSize As Integer = fluploadODS.PostedFile.ContentLength
            Dim fn As String = Session("MM_Username") & "_" & C21MIT.Util.RandomKeyString.Generate(6) & "_" & System.IO.Path.GetFileName(fluploadODS.PostedFile.FileName)

            Dim fLen As Integer = fn.Length
            v_FileExtension = System.IO.Path.GetExtension(fluploadODS.PostedFile.FileName)

            If C21MIT.PBSIS.BLL.ODSDocuments.isDocFile(v_FileExtension) Then
                v_destpath = C21MIT.PBSIS.BLL.ODSDocuments.getDocumentFolderPath(fn)
                ' get the primary key from the get_ods
                objODSdocs.OdIdOut = C21MIT.PBSIS.BLL.pbsods.fngetODSEndYearSchool(Session("MM_Username"), C21MIT.PBSIS.BLL.pbslogindetails.GetCurrentPrimTracker.schoolyear).OdIdOut
                ' objODSdocs.OdDocName = Session("MM_Username") & "_" & C21MIT.Util.RandomKeyString.Generate(6) & "_" & fn.ToLower.ToString
                objODSdocs.OdDocName = fn.ToLower.ToString

                'do not insert
                'objODSdocs.OdSchoolIDOut = Session("MM_Username")
                'objODSdocs.OdSchYrOut = CInt(Session("ActYrId"))


                fluploadODS.SaveAs(v_destpath)
                C21MIT.PBSIS.BLL.pbsods.addODSSchoolDocuments(objODSdocs)
                'lblDocMessage.Text = "Document was uploaded successfully!"
            End If
        End If

        If C21MIT.PBSIS.BLL.pbsods.getODSDocList(C21MIT.PBSIS.BLL.pbsods.fngetODSEndYearSchool(Session("MM_Username"), C21MIT.PBSIS.BLL.pbslogindetails.GetCurrentPrimTracker.schoolyear).OdIdOut, SchYR).Count > 0 Then
            gvDocs.DataSource = C21MIT.PBSIS.BLL.pbsods.getODSDocList(C21MIT.PBSIS.BLL.pbsods.fngetODSEndYearSchool(Session("MM_Username"), C21MIT.PBSIS.BLL.pbslogindetails.GetCurrentPrimTracker.schoolyear).OdIdOut, SchYR)
            gvDocs.DataBind()
            gvDocs.Visible = True
            lblnodocs.Visible = False
        ElseIf C21MIT.PBSIS.BLL.pbsods.getODSDocList(C21MIT.PBSIS.BLL.pbsods.fngetODSEndYearSchool(Session("MM_Username"), C21MIT.PBSIS.BLL.pbslogindetails.GetCurrentPrimTracker.schoolyear).OdIdOut, SchYR).Count = 0 Then
            lblnodocs.Visible = True
            gvDocs.Visible = False
            gvDocs.EmptyDataText = "No documents uploaded this year for " & C21MIT.PBSIS.BLL.pbsschoolprofile.getschoolprofile(Session("MM_Username")).SchoolName
        End If
    End Sub

    Sub binddocdridviewonload()
        Dim objODSdocs As New C21MIT.PBSIS.BO.pbsods

        If Not Request.QueryString("ODID") Is Nothing Then
            objODSdocs.OdIdOut = Request.QueryString("ODID")
        End If
        '
        objODSdocs.OdSchoolIDOut = C21MIT.PBSIS.BLL.pbsods.getODSOutput(objODSdocs.OdIdOut).OdSchoolIDOut
        objODSdocs.OdSchYrOut = C21MIT.PBSIS.BLL.pbsods.getODSOutput(objODSdocs.OdIdOut).OdSchYrOut

        If C21MIT.PBSIS.BLL.pbsods.getODSDocList(objODSdocs.OdIdOut, objODSdocs.OdSchYrOut).Count > 0 Then
            gvDocs.DataSource = C21MIT.PBSIS.BLL.pbsods.getODSDocList(objODSdocs.OdIdOut, objODSdocs.OdSchYrOut)
            gvDocs.DataBind()
            gvDocs.Visible = True
            lblnodocs.Visible = False
        ElseIf C21MIT.PBSIS.BLL.pbsods.getODSDocList(objODSdocs.OdIdOut, objODSdocs.OdSchYrOut).Count = 0 Then
            lblnodocs.Visible = True
            gvDocs.EmptyDataText = "No documents uploaded this year for " & C21MIT.PBSIS.BLL.pbsschoolprofile.getschoolprofile(Session("MM_Username")).SchoolName
        End If
    End Sub


    Sub binddocdridvieweditload_original_working()
        Dim objODSdocs As New C21MIT.PBSIS.BO.pbsods

        objODSdocs.OdSchoolIDOut = Session("MM_Username")
        objODSdocs.OdSchYrOut = C21MIT.PBSIS.BLL.pbslogindetails.GetCurrentPrimTracker.schoolyear
        If C21MIT.PBSIS.BLL.pbsods.getODSDocList(C21MIT.PBSIS.BLL.pbsods.fngetODSEndYearSchool(Session("MM_Username"), objODSdocs.OdSchYrOut).OdIdOut, objODSdocs.OdSchYrOut).Count > 0 Then
            gvDocs.DataSource = C21MIT.PBSIS.BLL.pbsods.getODSDocList(C21MIT.PBSIS.BLL.pbsods.fngetODSEndYearSchool(Session("MM_Username"), objODSdocs.OdSchYrOut).OdIdOut, objODSdocs.OdSchYrOut)
            gvDocs.DataBind()
            gvDocs.Visible = True
            lblnodocs.Visible = False
        ElseIf C21MIT.PBSIS.BLL.pbsods.getODSDocList(C21MIT.PBSIS.BLL.pbsods.fngetODSEndYearSchool(Session("MM_Username"), objODSdocs.OdSchYrOut).OdIdOut, objODSdocs.OdSchYrOut).Count = 0 Then
            lblnodocs.Visible = True
            gvDocs.EmptyDataText = "No documents uploaded this year for " & C21MIT.PBSIS.BLL.pbsschoolprofile.getschoolprofile(Session("MM_Username")).SchoolName
        End If
    End Sub

    Sub binddocdridvieweditload(ByVal SchoolId As String)

        Dim objODSdocs As New C21MIT.PBSIS.BO.pbsods
        If Not Request.QueryString("sRptSchID") Is Nothing Then
            objODSdocs.OdSchoolIDOut = C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("sRptSchID"))
            objODSdocs.OdSchYrOut = C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("Yr"))
            If C21MIT.PBSIS.BLL.pbsods.getODSDocList(C21MIT.PBSIS.BLL.pbsods.fngetODSEndYearSchool(SchoolId, objODSdocs.OdSchYrOut).OdIdOut, objODSdocs.OdSchYrOut).Count > 0 Then
                gvDocs.DataSource = C21MIT.PBSIS.BLL.pbsods.getODSDocList(C21MIT.PBSIS.BLL.pbsods.fngetODSEndYearSchool(SchoolId, C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("Yr"))).OdIdOut, objODSdocs.OdSchYrOut)
                gvDocs.DataBind()
                gvDocs.Visible = True
                lblnodocs.Visible = False
            ElseIf C21MIT.PBSIS.BLL.pbsods.getODSDocList(C21MIT.PBSIS.BLL.pbsods.fngetODSEndYearSchool(SchoolId, objODSdocs.OdSchYrOut).OdIdOut, objODSdocs.OdSchYrOut).Count = 0 Then
                lblnodocs.Visible = True
                gvDocs.EmptyDataText = "No documents uploaded this year for " & C21MIT.PBSIS.BLL.pbsschoolprofile.getschoolprofile(SchoolId).SchoolName
            End If
        ElseIf Not Request.QueryString("Yr") Is Nothing Then
            objODSdocs.OdSchYrOut = C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("Yr"))
            If C21MIT.PBSIS.BLL.pbsods.getODSDocList(C21MIT.PBSIS.BLL.pbsods.fngetODSEndYearSchool(SchoolId, objODSdocs.OdSchYrOut).OdIdOut, objODSdocs.OdSchYrOut).Count > 0 Then
                gvDocs.DataSource = C21MIT.PBSIS.BLL.pbsods.getODSDocList(C21MIT.PBSIS.BLL.pbsods.fngetODSEndYearSchool(SchoolId, objODSdocs.OdSchYrOut).OdIdOut, objODSdocs.OdSchYrOut)
                gvDocs.DataBind()
                gvDocs.Visible = True
                lblnodocs.Visible = False
            ElseIf C21MIT.PBSIS.BLL.pbsods.getODSDocList(C21MIT.PBSIS.BLL.pbsods.fngetODSEndYearSchool(SchoolId, objODSdocs.OdSchYrOut).OdIdOut, objODSdocs.OdSchYrOut).Count = 0 Then
                lblnodocs.Visible = True
                gvDocs.EmptyDataText = "No documents uploaded this year for " & C21MIT.PBSIS.BLL.pbsschoolprofile.getschoolprofile(SchoolId).SchoolName
            End If
        Else

            objODSdocs.OdSchYrOut = C21MIT.PBSIS.BLL.pbslogindetails.GetCurrentPrimTracker.schoolyear
            If C21MIT.PBSIS.BLL.pbsods.getODSDocList(C21MIT.PBSIS.BLL.pbsods.fngetODSEndYearSchool(SchoolId, objODSdocs.OdSchYrOut).OdIdOut, objODSdocs.OdSchYrOut).Count > 0 Then
                gvDocs.DataSource = C21MIT.PBSIS.BLL.pbsods.getODSDocList(C21MIT.PBSIS.BLL.pbsods.fngetODSEndYearSchool(SchoolId, objODSdocs.OdSchYrOut).OdIdOut, objODSdocs.OdSchYrOut)
                gvDocs.DataBind()
                gvDocs.Visible = True
                lblnodocs.Visible = False
            ElseIf C21MIT.PBSIS.BLL.pbsods.getODSDocList(C21MIT.PBSIS.BLL.pbsods.fngetODSEndYearSchool(SchoolId, objODSdocs.OdSchYrOut).OdIdOut, objODSdocs.OdSchYrOut).Count = 0 Then
                lblnodocs.Visible = True
                gvDocs.EmptyDataText = "No documents uploaded this year for " & C21MIT.PBSIS.BLL.pbsschoolprofile.getschoolprofile(SchoolId).SchoolName
            End If
        End If
    End Sub

    Protected Sub btnback_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnback.Click
        If Session("accttype") = "District" Then
            Response.Redirect("~/district/district_mainmenu.aspx")
        ElseIf Session("accttype") = "FMHI" Then
            Response.Redirect("~/fmhiadmin/fmhi_mainmenu.aspx")
        Else
            Response.Redirect("dentryview.aspx")
        End If
    End Sub

    'Protected Sub gvDocs_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles gvDocs.RowDataBound
    '    If (e.Row.RowType = DataControlRowType.DataRow) Then
    '        Dim hyldocname As HyperLink = CType(e.Row.FindControl("hylDocname"), HyperLink)


    '        hyldocname.NavigateUrl = ResolveUrl(C21MIT.PBSIS.BLL.ODSDocuments.getDocumentFolderPath(hyldocname.Text))
    '        'hyldocname.NavigateUrl = ResolveClientUrl(C21MIT.PBSIS.BLL.ODSDocuments.getDocumentFolderPath(hyldocname.Text))
    '    End If
    'End Sub

    'Protected Sub gvDocs_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles gvDocs.RowDataBound
    '    Dim objODS As New C21MIT.PBSIS.BO.pbsods
    '    If Not Request.QueryString("sRptSchID") Is Nothing Then
    '        objODS.SchoolID = C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("sRptSchID"))
    '    Else
    '        objODS.SchoolID = Session("MM_Username")
    '    End If

    '    If (e.Row.RowType = DataControlRowType.DataRow) Then
    '        Dim hyldocname As HyperLink = CType(e.Row.FindControl("hylDocname"), HyperLink)

    '        ' Dim str As String
    '        ' str =ResolveUrl(C21MIT.PBSIS.BLL.ODSDocuments.getDocumentFolderPath(hyldocname.Text)
    '        '''''''''''hyldocname.HRef = ResolveUrl(C21MIT.PBSIS.BLL.ODSDocuments.getDocumentFolderPath(hyldocname.InnerText))


    '        'hyldocname.NavigateUrl = ResolveClientUrl(C21MIT.PBSIS.BLL.ODSDocuments.getDocumentFolderPath(hyldocname.Text))
    '    End If
    'End Sub

    'Protected Sub gvDocs_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles gvDocs.RowDataBound
    '    If (e.Row.RowType = DataControlRowType.DataRow) Then
    '        Dim hyldocname As HtmlAnchor = CType(e.Row.FindControl("hylDocname"), HtmlAnchor)

    '        ' Dim str As String
    '        '  str =ResolveUrl(C21MIT.PBSIS.BLL.ODSDocuments.getDocumentFolderPath(hyldocname.Text)
    '        hyldocname.HRef = Server.UrlDecode(Convert.ToString(C21MIT.PBSIS.BLL.ODSDocuments.getDocumentFolderPath(hyldocname.InnerText)))
    '        'hyldocname.NavigateUrl = str
    '        'hyldocname.NavigateUrl = ResolveClientUrl(C21MIT.PBSIS.BLL.ODSDocuments.getDocumentFolderPath(hyldocname.Text))
    '    End If
    'End Sub


    Protected Sub btnDocDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDocDelete.Click
        deletedocs()
        If Not Request.QueryString("P") Is Nothing Then
            binddocdrideditview(C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("Yr")))
        Else
            binddocdridview(C21MIT.PBSIS.BLL.pbsencryption.getDecryptedQString(Request.QueryString("Yr")))
        End If
    End Sub

    Sub deletedocs()
        Dim dgitem As GridViewRow
        Dim isChecked As Boolean

        For Each dgitem In gvDocs.Rows
            'Make sure this is an item and not the header or footer
            If (dgitem.RowType = DataControlRowType.DataRow) Then
                ' First, get the studentID for the selected row 
                Dim lblpk As Label = CType(dgitem.FindControl("lblpk"), Label)
                isChecked = CType(dgitem.FindControl("chkDocDelete"), CheckBox).Checked

                If isChecked Then
                    Dim intOdId As Integer
                    intOdId = Convert.ToInt32(gvDocs.DataKeys(dgitem.RowIndex).Value)
                    'gvcontacts.DeleteRow(intcert)
                    C21MIT.PBSIS.BLL.pbsods.deleteODSDocuments(lblpk.Text)
                Else

                End If
            End If
        Next
    End Sub
End Class
