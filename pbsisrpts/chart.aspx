<%@ Page Language="VB" MasterPageFile="~/pbsmaster/Detail.master"  AutoEventWireup="false" CodeFile="chart.aspx.vb" Inherits="pbsisrpts_chart" %>

<%@ Register
    Assembly="AjaxControlToolkit"
    Namespace="AjaxControlToolkit"
    TagPrefix="ajaxToolkit" %>
    

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
            <td>&nbsp;</td>
        </tr>
     <tr>
        <td></td>
        <td><span class="style6"><asp:Label Font-Bold="true" ID="lblschName" runat="server" Text="School Name"></asp:Label></span></td>
        <td bgcolor="#FFFFFF">&nbsp;<asp:Label ID="lblSchoolName" runat="server"></asp:Label></td>
        <td><div align="right"><b>Year</b>&nbsp;</div></td>
        <td bgcolor="#FFFFFF">&nbsp<asp:Label ID="lblYear" runat="server"></asp:Label></td>
     </tr>
        <tr><td></td>
        </tr>
        <tr>
          <td width="8" rowspan="2" align="left" valign="top" bgcolor="#92BC4E">&nbsp;</td>
          <td width="90" height="28" align="left" valign="middle" bgcolor="#92BC4E"><span class="style6"><b>District Name</b></span></td>
           <td width="400" align="left" valign="middle" bgcolor="#FFFFFF" class="style17">&nbsp;<asp:Label ID="lblDistName" runat="server"></asp:Label></td>
          <td width="40" align="left" valign="middle" bgcolor="#92BC4E" class="style6"></td>
          <td width="65" align="left" valign="middle" bgcolor="#92BC4E" class="style17"></td>
        
        </tr>
 <tr>
          <td height="40" colspan="6" align="center" valign="middle" bgcolor="#92BC4E">
            
          </td>
        </tr>

</table>
<table width="98%"  border="0" cellpadding="0" cellspacing="0">
<tr> <td width="3" rowspan="2" align="left" valign="top" bgcolor="#92BC4E">&nbsp;</td>
<td align="left">

    <asp:Image ID="Image1" ImageUrl="~/pbsisrpts/Chart.ashx" runat="server" />
    &nbsp;</td>
    <td width="13" rowspan="4" bgcolor="#91BB4D">&nbsp;</td>
</tr>

<tr>
			<td><div align='center'><a href="Chart.ashx">Download Chart</a></td></div>
</tr>
</table>
</td>
</tr>
<%--</table>
</td>
</tr>--%>
</asp:Content>