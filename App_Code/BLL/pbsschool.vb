Imports Microsoft.VisualBasic

Namespace C21MIT.PBSIS.BLL
#Region "School Data Entry Links"
    Public Class pbsschooldataentrylinks
        Shared Function getschooldataentrylinks(ByVal schoolid As String, ByVal acadyear As Integer) As C21MIT.PBSIS.BO.pbsschooldataentrylinks
            Return C21MIT.PBSIS.DAL.pbsschooldataentrylinks.getschooldataentrylinks(schoolid, acadyear)
        End Function
    End Class
#End Region
#Region "School Forms"
#Region "School Profile"
    Public Class pbsschoolprofile
        Shared Function getschoolprofile(ByVal schoolid As String) As C21MIT.PBSIS.BO.pbsschoolprofile
            Return C21MIT.PBSIS.DAL.pbsschoolprofile.fngetschoolprofile(schoolid)
        End Function

        Shared Sub updschoolprofile(ByVal objschoolprofile As C21MIT.PBSIS.BO.pbsschoolprofile)
            C21MIT.PBSIS.DAL.pbsschoolprofile.updschoolprofile(objschoolprofile)
        End Sub
    End Class
#End Region
#Region "PIC / BOQ"
    Public Class pbsschoolpicboq
        Shared Function getSchoolPICBOQCoaches(ByVal schoolID As String) As System.Data.DataSet
            Return C21MIT.PBSIS.DAL.pbslPIC_BOQSchool.fngetPIC_BOQGetCoaches(schoolID)
        End Function
    End Class
    Public Class pbsschoolpicmidyrreport
        Shared Function fngetPICMidYearSchool(ByVal schoolID As String, ByVal schoolyR As Integer, ByVal schoolInterval As Integer) As C21MIT.PBSIS.BO.pbsschoolreport
            Return C21MIT.PBSIS.DAL.pbslpicMidYearSchool.fngetPICMidYearSchool(schoolID, schoolyR, schoolInterval)
        End Function

        Shared Sub addSchoolPIC(ByVal objPIC As C21MIT.PBSIS.BO.pbsschoolreport)
            C21MIT.PBSIS.DAL.pbslpicMidYearSchool.addschoolPIC(objPIC)
        End Sub
    End Class
#End Region
#Region "BOQ END YR"
    Public Class pbsschoolboqendyrreport
        Shared Function fngetBOQEndYearSchool(ByVal schoolID As String, ByVal schoolyR As Integer) As C21MIT.PBSIS.BO.pbsschoolreport
            Return C21MIT.PBSIS.DAL.pbslboqEndYearSchool.fngetBOQEndYearSchool(schoolID, schoolyR)
        End Function

        Shared Sub addSchoolBOQ(ByVal objBOQ As C21MIT.PBSIS.BO.pbsschoolreport)
            C21MIT.PBSIS.DAL.pbslboqEndYearSchool.addschoolBOQ(objBOQ)
        End Sub
    End Class
#End Region
#Region "ODS"
    Public Class pbsods
        Shared Function addSchoolODS(ByVal objODS As C21MIT.PBSIS.BO.pbsods) As C21MIT.PBSIS.BO.pbsods
            Return C21MIT.PBSIS.DAL.pbsODSSchool.addschoolODS(objODS)
        End Function

        Shared Function addSchoolBaselineODS(ByVal objODS As C21MIT.PBSIS.BO.pbsods) As C21MIT.PBSIS.BO.pbsods
            Return C21MIT.PBSIS.DAL.pbsODSSchool.addschoolBaselineODS(objODS)
        End Function

        Shared Function getODSOutput(ByVal odid As Integer) As C21MIT.PBSIS.BO.pbsods
            Return C21MIT.PBSIS.DAL.pbsODSSchool.getODSOutput(odid)
        End Function

        Shared Function getODSDocList(ByVal odid As Integer, ByVal SchYr As Integer) As C21MIT.PBSIS.BO.pbsods.ODSDocObjList
            Return C21MIT.PBSIS.DAM.pbsods.getODSDocList(odid, SchYr)
        End Function

        Shared Sub addODSSchoolDocuments(ByVal objODS As C21MIT.PBSIS.BO.pbsods)
            C21MIT.PBSIS.DAL.pbsODSSchool.insertODSDocs(objODS)
        End Sub

        Shared Function fngetODSEndYearSchool(ByVal schoolID As String, ByVal schoolyR As Integer) As C21MIT.PBSIS.BO.pbsods
            Return C21MIT.PBSIS.DAL.pbsODSSchool.fngetODSEndYearSchool(schoolID, schoolyR)
        End Function

        Shared Sub deleteODSDocuments(ByVal odid As Integer)
            C21MIT.PBSIS.DAL.pbsODSSchool.deleteODSDocs(odid)
        End Sub
    End Class
#End Region
#Region "BAT END YR"
    Public Class pbslbat
        Public Class pbsschoolbatendyrreport
            Shared Function fngetBatEndYearSchool(ByVal schoolID As String, ByVal schoolyR As Integer) As C21MIT.PBSIS.BO.pbsschoolreport
                Return C21MIT.PBSIS.DAL.pbslBatEndYearSchool.fngetBatEndYearSchool(schoolID, schoolyR)
            End Function
            Shared Sub addSchoolBAT(ByVal objBAT As C21MIT.PBSIS.BO.pbsschoolreport)
                C21MIT.PBSIS.DAL.pbslBatEndYearSchool.addSchoolBat(objBAT)
            End Sub
        End Class
    End Class
#End Region
#Region "DEMO DATA END YR"
    Public Class pbsdemodata
        Shared Function fngetdemodataEndYearSchool(ByVal schoolID As String, ByVal schoolyR As Integer) As C21MIT.PBSIS.BO.pbsdemodata
            Return C21MIT.PBSIS.DAL.pbsDemoDataSchool.fngetDemodataEndYearSchool(schoolID, schoolyR)
        End Function
        Shared Sub addSchooldemodata(ByVal objdemodata As C21MIT.PBSIS.BO.pbsdemodata)
            C21MIT.PBSIS.DAL.pbsDemoDataSchool.addDemoDataschool(objdemodata)
        End Sub
    End Class
#End Region
#End Region
End Namespace