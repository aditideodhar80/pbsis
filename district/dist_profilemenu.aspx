<%@ Page Language="VB" MasterPageFile="~/pbsmaster/Detail.master" AutoEventWireup="false" CodeFile="dist_profilemenu.aspx.vb" Inherits="district_dist_profilemenu" %>

<asp:Content ID ="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<tr>
        <td>

<table width="800" border="0" cellspacing="0" cellpadding="0">
  
  <tr>
    <td>
        <table width="98%"  border="0" cellpadding="0" cellspacing="0" bgcolor="#92BC4E">
            <tr>
              <td colspan="7"><img src="../images/box-top.gif" width="800" height="1" /></td>
            </tr>
      
            <tr>
              <td height="30" colspan="6" align="center" valign="middle" bgcolor="#92BC4E">
                  <b><asp:Label Font-Bold="true" Font-Size="Medium" ID="lblMonHeading" runat="server"></asp:Label></b>
              </td>
                <td width="4" rowspan="3" bgcolor="#91BB4D" style="width: 7px">&nbsp;</td>
            </tr>
      
            <tr>
              <td height="40" colspan="6" align="left" valign="middle" bgcolor="#92BC4E">
                <table width="100%" border="0">
                    <tr>
                        <td align="center" style="width: 25%" ><asp:LinkButton ID="hyladdSchoolCo" runat="server" Text="Add School" NavigateUrl="~/fmhiadmin/fmhi_districtprofilemenu.aspx"></asp:LinkButton></td>
                        <td align="center" style="width: 25%" ><asp:LinkButton ID="hyladdCoaches" runat="server" Text="Add Coach" NavigateUrl="~/fmhiadmin/fmhi_districtprofilemenu.aspx"></asp:LinkButton></td>
                         <td align="center" style="width: 25%"  ><asp:LinkButton ID="hylUpdateSchools" runat="server" Text="Update School" NavigateUrl="~/fmhiadmin/fmhi_districtprofilemenu.aspx"></asp:LinkButton></td>
                        <td align="center" style="width: 25%" ><asp:LinkButton ID="hylUpdateCoaches" runat="server" Text="Update Coach" NavigateUrl="~/fmhiadmin/fmhi_districtprofilemenu.aspx"></asp:LinkButton></td>
                    </tr>
                   
                </table>
              </td>
            </tr>

</table>
</td>
</tr>
</table>
</td>
</tr>
</asp:Content>