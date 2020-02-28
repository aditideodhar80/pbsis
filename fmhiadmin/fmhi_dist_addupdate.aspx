<%@ Page Language="VB" MasterPageFile="~/pbsmaster/Main.master"  AutoEventWireup="false" CodeFile="fmhi_dist_addupdate.aspx.vb" Inherits="fmhiadmin_fmhi_dist_addupdate" %>

<asp:Content ID ="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<script type="text/javascript" language="JavaScript" src="../includes/validate_fmhidistprofile.js"></script>
    <tr>
        <td>
<table width="400" border="0" cellpadding="2" cellspacing="0" bordercolor="white">
        <tr>
            <td width="49%" align="left" valign="top"><span class="style2"><asp:Label Font-Size="Medium" ID="lblCaption" runat="server"></asp:Label></span></td>
        </tr>
		<tr>
            <td align="left" valign="top"><strong><font color="#FF0000">*&nbsp;Required Field</font></strong></td>
	    </tr>

</table>

<table width="400" border="0" cellpadding="2" cellspacing="0" bordercolor="#000000">
   <tr>
       <td align="left" valign="top">
       
        <table width="400" border="1" cellpadding="2" cellspacing="0" bordercolor="#000000">
            <tr valign="middle" bgcolor="#999999">
                <td height="31" colspan=2 align="center"><span class="style3">CONTACT INFORMATION </span></td>
            </tr>
            <tr bgcolor="#C8E080">
                <td width="400" height="22" colspan=2><strong>Address:</strong></td>
            </tr>
            <tr>
                <td align="left" width="400">
                    <table width="250" border="0" cellspacing="0" cellpadding="0">
                        <tr valign="middle">
                            <td width="250" colspan=5>District Name<font color="#FF0000">*</font> </td>
                        </tr>
                        <tr valign="middle">
                            <td width="250" colspan=5 align="left">
                                <asp:TextBox ID="txtDistrictName" runat="server" CssClass="border" MaxLength="75" Width="250"></asp:TextBox>
                            </td>
                        </tr>
                        <tr valign="middle">
                            <td colspan=5>&nbsp;</td>
                        </tr>
                        <tr valign="middle">
                          <td width="250" colspan=5>District ID<font color="#FF0000">*</font> </td>
                        </tr>
                        <tr valign="middle">
                          <td width="250" colspan=5 align="left">
                         <asp:TextBox ID="txtDistrictID" runat="server" CssClass="border" MaxLength="2" Width="25"></asp:TextBox>
                         </td>
                        </tr>
                        <tr valign="middle">
                          <td colspan=5>&nbsp;</td>
                        </tr>
                        <tr valign="middle">
                          <td width="250" colspan=5>Street Address (line 1)<font color="#FF0000">*</font> 
                        </tr>
                        <tr valign="middle">
                          <td width="250" colspan=5 align="left">
                          <asp:TextBox ID="txtStreetAddress1" runat="server" CssClass="border" MaxLength="100" Width="250"></asp:TextBox>
                          </td>
                        </tr>
                        <tr valign="middle">
                          <td colspan=5>&nbsp;</td>
                        </tr>
                        <tr valign="middle">
                          <td width="250" colspan=5>Street Address (line 2)</td>
                        </tr>
                        <tr valign="middle">
                          <td width="250" colspan=5>
                            <asp:TextBox ID="txtStreetAddress2" runat="server" CssClass="border" MaxLength="100" Width="250"></asp:TextBox>
                          </td>
                        </tr>
                        <tr valign="middle">
                          <td colspan=1>&nbsp;</td>
                          <td colspan=4>&nbsp;</td>
                        </tr>
                        <tr valign="middle">
                          <td width="100" colspan=1>City<font color="#FF0000">*</font> </td>
                          <td width="200" colspan=4>
                          
                          <asp:TextBox ID="txtDistrictCity" runat="server" CssClass="border" MaxLength="50" Width="175"></asp:TextBox>
                          </td>
                        </tr>
                        <tr valign="middle">
                          <td>&nbsp;</td>
                          <td>&nbsp;</td>
                          <td>&nbsp;</td>
                          <td>&nbsp;</td>
                          <td>&nbsp;</td>
                        </tr>
                        <tr valign="middle">
                          <td width="60">State<font color="#FF0000">*</font> </td>
                          <td width="60">
                            <asp:TextBox ID="txtDistrictState" runat="server" CssClass="border" MaxLength="2" Width="25"></asp:TextBox>
                          </td>
                          <td width="60">&nbsp;</td>
                          <td width="60">Zip<font color="#FF0000">*</font> </td>
                          <td width="60">
                          <asp:TextBox ID="txtDistrictZip" runat="server" CssClass="border" MaxLength="5" Width="45"></asp:TextBox>
                         </td>
                        </tr>
                </table>
           </td>
           <td align="left" valign="top">
                <table width="250" border="0" cellspacing="0" cellpadding="0">
                    <tr valign="middle">
                        <td width="68" align="left">Telephone<font color="#FF0000">*</font> </td>
                            <td width="182" align="left"> 
                                      
                                      ( <asp:TextBox ID="txtDistrictPhone01" runat="server" CssClass="border" MaxLength="3" Width="30"></asp:TextBox> )&nbsp;
					      <asp:TextBox ID="txtDistrictPhone02" runat="server" CssClass="border" MaxLength="3" Width="30"></asp:TextBox>
					      &nbsp;-
					      <asp:TextBox ID="txtDistrictPhone03" runat="server" CssClass="border" MaxLength="4" Width="40"></asp:TextBox>
                            </td>
                   </tr>
                   <tr valign="middle">
                        <td align="left">&nbsp;</td>
                        <td align="left">&nbsp;</td>
                   </tr>
                   <tr valign="middle">
                        <td width="68" align="left">Fax<font color="#FF0000">*</font> </td>
                        <td width="182" align="left"> 
                                  
                                   ( <asp:TextBox ID="txtDistrictFax01" runat="server" CssClass="border" MaxLength="3" Width="30"></asp:TextBox> )&nbsp;
				      <asp:TextBox ID="txtDistrictFax02" runat="server" CssClass="border" MaxLength="3" Width="30"></asp:TextBox>
				      &nbsp;-
				      <asp:TextBox ID="txtDistrictFax03" runat="server" CssClass="border" MaxLength="4" Width="40"></asp:TextBox>
                        </td>
                    </tr>
                    <tr valign="middle">
                      <td align="left">&nbsp;</td>
                      <td align="left">&nbsp;</td>
                    </tr>
                    <tr valign="middle">
                          <td width="68" align="left">Cell<font color="#FF0000">*</font> </td>
                          <td width="182" align="left"> 
                          
                           ( <asp:TextBox ID="txtDistrictCell01" runat="server" CssClass="border" MaxLength="3" Width="30"></asp:TextBox> )&nbsp;
		      <asp:TextBox ID="txtDistrictCell02" runat="server" CssClass="border" MaxLength="3" Width="30"></asp:TextBox>
		      &nbsp;-
		      <asp:TextBox ID="txtDistrictCell03" runat="server" CssClass="border" MaxLength="4" Width="40"></asp:TextBox>
                         </td>
                    </tr>
            </table>
          </td>
     </tr>
             
             
                                      
                                      <tr bgcolor="#C8E080">
                                        <td height="6" colspan=2><strong>District Inactive:&nbsp;</strong>&nbsp;
                                        
                                        <asp:CheckBox ID="chkInactive" runat="server" />
                                  </td>
                                      </tr>
                                       
                                  
                                    </table></td>
				</table></td>
		</tr>
                          	
		
		<tr>
			<td align="center">&nbsp;</td>
		</tr>

		<tr>
			<td align="center"><asp:Label id="lblstatus" runat="server" ForeColor="Red"></asp:Label></td>
		</tr>
		
		
		
		
		

		<tr>
			<td><div align="center"><asp:Button runat="server" ID="btnsubmit" BackColor="Beige" BorderColor="#C8E07F" BorderWidth="3" Text="Submit" OnClientClick="return checkFMHIDistForm('Form1');" /></div></td>
		</tr>
		
		<tr>
			<td>&nbsp;</td>
		</tr>

</asp:Content>