<%@ Page Language="VB" MasterPageFile="~/pbsmaster/Detail.master"  AutoEventWireup="false" CodeFile="fmhi_mainmenu.aspx.vb" Inherits="fmhiadmin_fmhi_mainmenu" %>

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
                            <td height="40" colspan="6" align="center" valign="middle" bgcolor="#92BC4E">
                            </td>
                        </tr>
                   </table>
                   <table width="98%"  border="0" cellpadding="0" cellspacing="0">
                    <tr>
                        <td width="3" rowspan="2" align="left" valign="top" bgcolor="#92BC4E">&nbsp;</td>
                        <td align="left">
                            <asp:DataGrid ID="gvDynamicFMHI" runat="server" Width="792px" BorderColor="#92BC4E" GridLines="None" CellPadding="0" CellSpacing="0" 
                            BorderStyle="None" >
                            <HeaderStyle BackColor="#92BC4E" Font-Bold="true" Font-Size="Larger" />
                            <AlternatingItemStyle BackColor = "#D9D3EB"  Height="21" />
                            <ItemStyle Height="21px"  />
                                
                            </asp:DataGrid>
                        </td>
                        <td width="13" rowspan="4" bgcolor="#91BB4D">&nbsp;</td>
                    </tr>
                   </table>
                </td>
            </tr>
        </table>
     </td>
 </tr>

</asp:Content>