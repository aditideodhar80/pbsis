'-------------------------------------------------------------------------------------------------------------------
' Created By : Aditi Deodhar
' Created Dt : Feb 08,2010
' Last Updated Dt : March 03,2010
'-------------------------------------------------------------------------------------------------------------------
Partial Class pbsisrpts_schfrmdataview
    Inherits System.Web.UI.Page

    Protected Sub btnSubmit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSubmit.Click
        Dim valRadio As Integer

        If radioPICFall.Checked = True Then
            valRadio = "19"
        ElseIf radioPICSpring.Checked = True Then
            valRadio = "20"
        ElseIf radioDemographicData.Checked = True Then
            valRadio = "2"
        ElseIf radioBOQ.Checked = True Then
            valRadio = "5"
        ElseIf radioODS.Checked = True Then
            valRadio = "6"
        ElseIf radioBAT.Checked = True Then
            valRadio = "7"
        End If

        redirecttoreports(valRadio)

    End Sub

    Sub redirecttoreports(ByVal valRadio As Integer)
        Dim objSchoolData As New C21MIT.PBSIS.BO.pbsschoolreport
        Dim rpttype As Integer

        If Session("MM_UserName") = "" Then
            System.Web.HttpContext.Current.Response.Redirect("~/users/smessages.aspx?qModule=InvalidSession", False)
        Else
            If Session("sRptAuth") = "aD" Or Session("sRptAuth") = "aF" Then '' added authentication for FMHI administrators
                Session("sRptSchID") = Request.QueryString("qSchID")

            ElseIf Session("sRptAuth") = "aS" Then
                Session("sRptSchID") = Session("MM_Username")

            End If
        End If

        If ddlorptYear.SelectedItem.Value > 0 Then

            objSchoolData.SchoolYear = ddlorptYear.SelectedItem.Value
            rpttype = valRadio
        Else

            objSchoolData.SchoolYear = ddlorptYear.SelectedItem.Value
            rpttype = Request.QueryString("selectrpt")
        End If

        Session("SchYrId") = objSchoolData.SchoolYear


        If valRadio = 4 Then
            ' Team Process Evalation
            Response.Redirect("midyrslr_avgteamresp.aspx")

        ElseIf valRadio = 3 Then
            ' School Team Update
            Response.Redirect("midyrslr_schoolteamupdate.aspx")


        ElseIf valRadio = 5 Then
            ' Benchmark of Quality
            Response.Redirect("endyrslr_boq.aspx")

        ElseIf valRadio = 6 Then
            'Outcome Data Summary
            Response.Redirect("endyrslr_ods.aspx")


        ElseIf valRadio = 2 Then
            ' Demograhic Data
            Response.Redirect("slr_demodata.aspx")

        ElseIf valRadio = 7 Then
            ' ODRs (1) 
            Response.Redirect("endyrslr_bat.aspx")

        ElseIf valRadio = 8 Then
            ' ODRs per 100 students (2)
            Response.Redirect("endyrslr_schodrper100.aspx")

        ElseIf valRadio = 9 Then
            ' ISS & OSS(3)
            Response.Redirect("endyrslr_issossoverimplem.aspx")

        ElseIf valRadio = 10 Then
            ' ISS & OSS per 100 students (4) 
            Response.Redirect("endyrslr_schissossper100.aspx")

        ElseIf valRadio = 11 Then
            ' Average Daily Attendance (5)
            Response.Redirect("endyrslr_schavgattnd.aspx")

        ElseIf valRadio = 12 Then
            ' Benchmark of Quality Score (6)
            Response.Redirect("endyrslr_schboqscore.aspx")


        ElseIf valRadio = 19 Then

            'Session("picterm") = "1"
            Response.Redirect("midyrslr_avgpic.aspx?PICTerm=" & C21MIT.PBSIS.BLL.pbsencryption.getEncryptedQString(1) & "")

        ElseIf valRadio = 20 Then
            Session("picterm") = "2"
            Response.Redirect("midyrslr_avgpic.aspx?PICTerm=" & C21MIT.PBSIS.BLL.pbsencryption.getEncryptedQString(2) & "")

        ElseIf valRadio = 21 Then
            ' TIC-Fall (6)
            'Session("picterm") = "1"
            Response.Redirect("midyrslr_schpicscore.aspx?PICTerm=" & C21MIT.PBSIS.BLL.pbsencryption.getEncryptedQString(1) & "")
        ElseIf valRadio = 22 Then
            ' TIC-Spring (6)
            'Session("picterm") = "0"
            Response.Redirect("midyrslr_schpiccritical.aspx?PICTerm=" & C21MIT.PBSIS.BLL.pbsencryption.getEncryptedQString(0) & "")

        Else
            System.Web.HttpContext.Current.Response.Redirect("~/users/smessages.aspx?qModule=InvalidSession", False)
        End If
    End Sub
End Class
