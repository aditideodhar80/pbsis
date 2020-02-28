
<%@ Page Language="VB" MasterPageFile="~/pbsmaster/Detail.master" AutoEventWireup="false" CodeFile="fmhi_distcoachprofilemenu.aspx.vb" Inherits="fmhiadmin_fmhi_distcoachprofilemenu" %>


<asp:Content ID ="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<script language="javascript">
    function Check(elem) {
        if (window.confirm("are you sure you want to do this?")) {
            __doPostBack('', '');
        }
        else {
            return false;
        }
    }


</script>
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
              <td width="8" rowspan="2" align="left" valign="top" bgcolor="#92BC4E">&nbsp;</td>
              <td width="90" height="28" align="left" valign="middle" bgcolor="#92BC4E"><span class="style6"><b>District Name</b></span></td>
              <td width="400" align="left" valign="middle" bgcolor="#FFFFFF" class="style17">&nbsp;<asp:Label ID="lblDistName" runat="server"></asp:Label></td>
              <td width="40" align="left" valign="middle" bgcolor="#92BC4E" class="style6"><div align="right">&nbsp;</div></td>
            </tr>
      
            <tr>
                <td height="40" colspan="6" align="left" valign="middle" bgcolor="#92BC4E">
                    <table width="60%" border="0">
                        <tr>
                            <td align="left" ><asp:LinkButton ID="hyladdDistCoord" runat="server" Text="Add Coach"></asp:LinkButton></td>
                            
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
        
        <table width="98%"  border="0" cellpadding="0" cellspacing="0">
            <tr> 
                <td width="3" rowspan="2" align="left" valign="top" bgcolor="#92BC4E">&nbsp;</td>
                <td align="left">
    
                    
                    <asp:DataGrid   ID="gvDynamicFMHI" AllowPaging="true" OnPageIndexChanged="DataGrid1_PageIndexChanged" PagerStyle-Mode="NumericPages" PageSize="15" runat="server" Width="792px" BorderColor="#92BC4E" GridLines="None" CellPadding="0" CellSpacing="0" 
                        BorderStyle="None" PagerStyle-HorizontalAlign="Center">
                    <HeaderStyle BackColor="#92BC4E" Font-Bold="true" Font-Size="Larger" />
                    <AlternatingItemStyle BackColor = "#D9D3EB"  Height="21" />
                   
                    <ItemStyle Height="21px"  />
                     <FooterStyle /> 
                         
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