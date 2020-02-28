<%@ Page Language="VB" MasterPageFile="~/pbsmaster/Main.master"  AutoEventWireup="false" CodeFile="fmhi_distcoaches_addupdate.aspx.vb" Inherits="fmhiadmin_fmhi_distcoaches_addupdate" %>

<asp:Content ID ="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<script type="text/javascript" language="JavaScript" src="../includes/validate_fmhidistcoachprofile.js"></script>
    <tr>
      <td>
        <table width="400" border="0" cellpadding="2" cellspacing="0" bordercolor="white">
            <tr>
                <td width="49%" align="left" valign="top" colspan="2"><span class="style2"><asp:Label Font-Size="Medium" ID="lblCaption" runat="server"></asp:Label></span></td>
            </tr>
		    <tr>
                <td align="left" valign="top" colspan="2"><strong><font color="#FF0000">*&nbsp;Required Field</font></strong></td>
	        </tr>
	    </table>
        <table width="400" border="1" cellpadding="2" cellspacing="0" bordercolor="black">
            <tr bordercolor="#000000" bgcolor="#CCCCCC">
                <td height="6" colspan=2 align="center">DISTRICT COACH<span class="style3"> INFORMATION </span></td>
            </tr>
           
              
              
              <tr bgcolor="#C8E080">
                <td width="400" height="24" colspan="2"><strong>District Coach:</strong></td>
              </tr>
              <tr>
                <td align="left" valign="top">
                <table width="250" border="0" cellspacing="0" cellpadding="0">
                    <tr>
                      <td align="left" valign="middle">First Name<font color="#FF0000">*</font> </td>
                    </tr>
                    <tr>
                      <td width="250" valign="middle">
                       <asp:TextBox ID="txtCoachFirstName" runat="server" CssClass="border" MaxLength="50" Width="160"></asp:TextBox>
                      </td>
                    </tr>
                    <tr>
                      <td valign="middle">&nbsp;</td>
                    </tr>
                    <tr>
                      <td valign="middle">Last Name<font color="#FF0000">*</font> </td>
                    </tr>
                    <tr>
                      <td align="left" valign="middle">
                       <asp:TextBox ID="txtCoachLastName" runat="server" CssClass="border" MaxLength="50" Width="160"></asp:TextBox>
                      </td>
                    </tr>
                    <tr>
                      <td valign="middle">&nbsp;</td>
                    </tr>
                    
                    
                     <tr valign="middle">
								    <td width="250" COLSPAN=5>Coach District<font color="#FF0000">*</font> </td>					
							    </tr>
    							
							    <tr valign="middle">
								    <td width="250" COLSPAN=5 align="left">
								   <asp:DropDownList ID="ddlSchoolDistrict" runat="server" AutoPostBack="false"></asp:DropDownList>
															    </td>
                        	    </tr>
                        	    
                        	    
                        	    
                    
                  </table>
                </td>
                <td align="left" valign="top">
                    <table width="250" border="0" cellspacing="0" cellpadding="0">
                            <tr valign="middle">
                              <td width="110" align="left">Email<font color="#FF0000">*</font> </td>
                              <td width="190" align="left">
                                <asp:TextBox ID="txtDistrictCoachEmail" runat="server" CssClass="border" MaxLength="75" Width="160"></asp:TextBox>
                              </td>
                            </tr>
                             <tr>
                      <td valign="middle">&nbsp;</td>
                    </tr>
                              <tr valign="middle">
                              <td width="110" align="left">Position </td>
                              <td width="190" align="left">
                                <asp:TextBox ID="txtCoachposition" runat="server" CssClass="border" MaxLength="75" Width="160"></asp:TextBox>
                              </td>
                            </tr>
                    </table>
               </td>
       
                                      <tr>
                                        <td align="left"><table width="250" border="0" cellspacing="0" cellpadding="0">
                                          
                                          
                                         
                                          <tr valign="middle">
                                            <td width="250" colspan=5> Street Address (line 1)							                                    
                                                </tr>
                                          <tr valign="middle">
                                            <td width="250" colspan=5 align="left">
                                            
                                             <asp:TextBox ID="txtStreetAddress1_2" runat="server" CssClass="border" MaxLength="100" Width="250"></asp:TextBox>
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
                                             <asp:TextBox ID="txtStreetAddress2_2" runat="server" CssClass="border" MaxLength="100" Width="250"></asp:TextBox>
                                            </td>
                                          </tr>
                                          <tr valign="middle">
                                            <td colspan=1>&nbsp;</td>
                                            <td colspan=4>&nbsp;</td>
                                          </tr>
                                          <tr valign="middle">
                                            <td width="250" colspan=1> City </td>
                                            <td width="250" colspan=4>
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
                                            <td width="250"> State</td>
                                            <td width="250">
                                             <asp:TextBox ID="txtDistrictState" runat="server" CssClass="border" MaxLength="2" Width="25"></asp:TextBox>
                                            </td>
                                            <td width="250">&nbsp;</td>
                                            <td width="250"> Zip</td>
                                            <td width="250">
                                                <asp:TextBox ID="txtDistrictZip" runat="server" CssClass="border" MaxLength="5" Width="50"></asp:TextBox>
                                            </td>
                                          </tr>
                                          <tr>
                                            <td colspan="5">&nbsp;</td>
                                          </tr>
                                          
                                        </table></td>
                  <td align="left" valign="top"><table width="250" border="0" cellspacing="0" cellpadding="0">
                                          <tr valign="middle">
                                            <td width="68" align="left"> Telephone</td>
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
                                            <td width="68" align="left"> Fax</td>
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
                                            <td width="68" align="left"> Cell</td>
                                            <td width="182" align="left"> 
                                            
                                            
                                                          
                                                  ( <asp:TextBox ID="txtDistrictCell01" runat="server" CssClass="border" MaxLength="3" Width="30"></asp:TextBox> )&nbsp;
							      <asp:TextBox ID="txtDistrictCell02" runat="server" CssClass="border" MaxLength="3" Width="30"></asp:TextBox>
    						      &nbsp;-
    						      <asp:TextBox ID="txtDistrictCell03" runat="server" CssClass="border" MaxLength="4" Width="40"></asp:TextBox>
                                                    </td>
                                          </tr>
                                          <tr valign="middle">
                                            <td align="left">&nbsp;</td>
                                            <td align="left">&nbsp;</td>
                                          </tr>
                                          <tr valign="middle">
                                            <td width="68" align="left">&nbsp;</td>
                                            <td width="182" align="left">
                                                &nbsp;</td>
                                          </tr>
                                        </table></td>
                                      </tr>
                                     <tr valign="middle" bgcolor="#C8E080">
					  <td height="6" colspan=5><strong>Coach Inactive</strong> &nbsp;&nbsp;
					  <asp:CheckBox ID="chkInactive" runat="server" />
					  </td>
					  </tr>
                                      <%--<tr bgcolor="#C8E080">
                                        <td height="6" colspan=2><strong>District Coordinator Inactive:&nbsp;</strong>&nbsp;
                                        
                                        <asp:CheckBox ID="chkInactive" runat="server" />
                                  </td>
                                      </tr>--%>
                                      
                                    </table></td>
				
		</tr>
                          	
		
					

		
		<tr>
		    <td>&nbsp;</td>
		</tr>
		<tr>
			<td align="center"><asp:Label id="lblstatus" runat="server" ForeColor="Red"></asp:Label></td>
		</tr>
		
		

		<tr>
			<td><div align="center"><asp:Button runat="server" ID="btnsubmit" BackColor="Beige" BorderColor="#C8E07F" BorderWidth="3" Text="Submit" OnClientClick="return checkFMHIDistCoordForm('Form1');" /></div></td>
		</tr>
		
		<tr>
			<td>&nbsp;</td>
		</tr>

</asp:Content>