<%@ Page Language="VB" AutoEventWireup="false" MasterPageFile="~/pbsmaster/Detail.master" CodeFile="schoolaccess_monitoring.aspx.vb" Inherits="district_district_monitoring" %>

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
        
        
          
        </tr>
     
        <tr>
          <td height="30" colspan="6" align="center" valign="middle" bgcolor="#92BC4E">
              <b><asp:Label Font-Bold="true" Font-Size="Medium" ID="lblMonHeading" runat="server"></asp:Label></b>
          </td>
     <td width="4" rowspan="3" bgcolor="#91BB4D" style="width: 7px">&nbsp;</td>
        </tr>
        <tr>
          <td width="8" rowspan="2" align="left" valign="top" bgcolor="#92BC4E">&nbsp;</td>
          <td width="90" height="28" align="left" valign="middle" bgcolor="#92BC4E"><span class="style6"><asp:label ID="lblDis" runat="server" Font-Size="Small" Font-Bold="true" Text="District Name"></asp:label></span></td>
           <td width="400" align="left" valign="middle" bgcolor="#FFFFFF" class="style17">&nbsp;<asp:Label ID="lblDistName" runat="server"></asp:Label></td>
          <td width="40" align="left" valign="middle" bgcolor="#92BC4E" class="style6"><div align="right"><b>Year</b>&nbsp;</div></td>
          <td width="65" align="left" valign="middle" bgcolor="#FFFFFF" class="style17">&nbsp<asp:Label ID="lblYear" runat="server"></asp:Label></td>
        
        </tr>
 <tr>
          <td height="40" colspan="6" align="right" valign="middle" bgcolor="#92BC4E" 
              style="color: #FF0000">
            <asp:Label ID="lblsheetdetails" Visible="false" runat="server" Text=" * For schools engaged in Tier 2 and/or Tier 3 supports. See end year procedure sheet for details."></asp:Label>
             &nbsp;&nbsp;&nbsp;</td>
        </tr>

</table>
<table width="98%"  border="0" cellpadding="0" cellspacing="0">
<tr> <td width="3" rowspan="2" align="left" valign="top" bgcolor="#92BC4E">&nbsp;</td>
<td align="left">

    
    <asp:DataGrid ID="gvDynamic" runat="server" Width="792px" BorderColor="#92BC4E" GridLines="None" CellPadding="0" CellSpacing="0" 
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
<%--</table>
</td>
</tr>--%>
</asp:Content>