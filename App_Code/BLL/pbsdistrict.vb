Imports Microsoft.VisualBasic
Namespace C21MIT.PBSIS.BLL
#Region "DISTRICT"
    Public Class pbsdistrict
        Shared Function getdistname(ByVal distID As String) As C21MIT.PBSIS.BO.pbsschoolreport
            Return C21MIT.PBSIS.DAL.pbsdistreports.fngetDistName(distID)
        End Function
        Shared Function getdisttierofsupport(ByVal distId As String, ByVal SchoolYr As Integer) As C21MIT.PBSIS.BO.pbsmid_yr_dist_reports_main
            Return C21MIT.PBSIS.DAL.pbsdistreports.fngetTierSuppActiSch(distId, SchoolYr)
        End Function
    End Class
#End Region
#Region "DISTRICT NAVIGATION"
    Public Class pbsdisnavigate
        Public Shared Function getmidyrmon(ByVal distid As String, ByVal rptyr As Integer) As C21MIT.PBSIS.BO.PBSNavObjectList
            Return C21MIT.PBSIS.DAL.pbsdisnavigate.getmidyrmon(distid, rptyr)
        End Function
        Public Shared Function getyearmon(ByVal optId As String, ByVal distid As String, ByVal rptyr As Integer) As C21MIT.PBSIS.BO.pbsgridviewobj
            Return C21MIT.PBSIS.DAL.pbsdisnavigate.getyearmon(optId, distid, rptyr)
        End Function
        Public Shared Function getschoollevelreports(ByVal optid As String, ByVal distid As String) As C21MIT.PBSIS.BO.pbsgridviewobj
            Return C21MIT.PBSIS.DAL.pbsdisnavigate.getschoollevelreports(optid, distid)
        End Function
    End Class
#End Region
End Namespace