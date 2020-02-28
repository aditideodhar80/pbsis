<%@ Page Language="VB" AutoEventWireup="false" MasterPageFile="~/pbsmaster/Detail.master"  CodeFile="midyr_district_dlr.aspx.vb" Inherits="pbsisrpts_rptdistmpage_midyr" %>

<asp:Content ID ="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<tr>
          <td width="8" rowspan="3" align="left" valign="top" bgcolor="#92BC4E">&nbsp;</td>
          <td height="5" align="left" valign="middle" bgcolor="#92BC4E"></td>
        </tr>
        <tr>
          <td height="19" align="left" valign="middle" bgcolor="#92BC4E"><div align="center" class="style8"></div>            <div align="center" class="style6">
              <div align="center"><asp:label ID="lblhead" runat="server" Text="Mid-Year District Reports" Font-Bold="true" Font-Size="Medium"></asp:label></div>
            </div>
            <div align="center" class="style8"></div></td>
        </tr>
        
        <tr>
          <td align="left" valign="top" bgcolor="#92BC4E"><div id="data">
  <table  border="0" cellpadding="3" cellspacing="0" style="width: 796px">
    <tr>
      <td bgcolor="#92BC4E" class="style6">&nbsp;</td>
      <td bgcolor="#92BC4E">&nbsp;</td>
    </tr>
    
       
    
    <tr bgcolor="#D9D3EB">
      <td  bgcolor="#D9D3EB" class="style8"> &nbsp;&nbsp;&nbsp; Tiers of Support in Active Schools (Table)</td>
      <td bgcolor="#D9D3EB">
      <asp:RadioButton ID="radioTier" GroupName="grpMidYDistRep" runat="server"  />
      </td>
      <td width="0" align="left" valign="middle" bgcolor="#91BB4D"></td>
    </tr>
    
   <tr bgcolor="#FFFFFF">
      <td class="style8"> &nbsp;Average PIC - &nbsp;Tier 1 Critical Element Category - (All School Types) </td>
      <td>
      <asp:RadioButton ID="radioAvgPIC11" GroupName="grpMidYDistRep" runat="server"  />
      </td>
    </tr>
    <tr bgcolor="#D9D3EB">
      <td bgcolor="#D9D3EB" class="style8">&nbsp;Average PIC - &nbsp;Implementation Level - (All School Types)
      </td>
      <td>
        <asp:RadioButton ID="radioAgPIC12" GroupName="grpMidYDistRep" runat="server"  />
    </td>
    </tr>
    <tr>
      <td bgcolor="#92BC4E"><span class="style6">Please select the school type for the following mid-year reports:</span></td>
      <td bgcolor="#92BC4E">
      <asp:DropDownList ID="ddlSchType" runat="server">
        <asp:ListItem Value="0" Selected="True" Text="PreK"></asp:ListItem>
        <asp:ListItem Value="1" Text="Elementary"></asp:ListItem>
        <asp:ListItem Value="2" Text="Middle"></asp:ListItem>
        <asp:ListItem Value="3" Text="High"></asp:ListItem>
        <asp:ListItem Value="4" Text="Alt/Center"></asp:ListItem>
         <asp:ListItem Value="5" Text="Other"></asp:ListItem>
        
      </asp:DropDownList>
      
     </td>
    </tr>
    <tr bgcolor="#FFFFFF">
      <td><span class="style8">&nbsp;&nbsp;Average PIC -&nbsp; Tier 1 Critical Element Category </span></td>
      <td>
         <asp:RadioButton ID="radioAvgPIC21" GroupName="grpMidYDistRep" runat="server" />
      </td>
    </tr>
    <tr bgcolor="#D9D3EB">
      <td><span class="style8">&nbsp;&nbsp;Average PIC - &nbsp;Implementation Level Category</span></td>
      <td>
      <asp:RadioButton ID="radioAvgPIC22" GroupName="grpMidYDistRep" runat="server"/>
     </td>
    </tr>
    <tr>
      <td bgcolor="#92BC4E"></td>
      <td bgcolor="#92BC4E"></td>
    </tr>
    <tr>
      <td bgcolor="#92BC4E"></td>
      <td bgcolor="#92BC4E">
        <asp:Button ID="btnSubmit" runat="server" BackColor="Beige"  OnClientClick="return radio_button_checker_dis_midyr_rep();" BorderColor="#C8E07F" BorderWidth="3" Text="Get Report"/>
      </td>
    </tr>
  </table>
</div>
</td>
        </tr>
</asp:Content>
