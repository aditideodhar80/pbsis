<%@ Page Language="VB" MasterPageFile="~/pbsmaster/Main.master"  AutoEventWireup="false" CodeFile="fmhi_sch_addupdate.aspx.vb" Inherits="fmhiadmin_fmhi_sch_addupdate" %>

<asp:Content ID ="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<script type="text/javascript" language="JavaScript" src="../includes/validate_fmhischprofile.js"></script>
    <tr>
        <td>

    <tr>
        <td>

<script language="JavaScript">
<!--

/***********************************************
* Required field(s) validation v1.10- By NavSurf
* Visit Nav Surf at http://navsurf.com
* Visit http://www.dynamicdrive.com/ for full source code
***********************************************/

function formCheck(formobj){
	// Enter name of mandatory fields
	var fieldRequired = Array("Street Address (line 1)", "LastName");
	// Enter field description to appear in the dialog box
	var fieldDescription = Array("First Name", "Last Name");
	// dialog message
	var alertMsg = "Please complete the following fields:\n";
	
	var l_Msg = alertMsg.length;
	
	for (var i = 0; i < fieldRequired.length; i++){
		var obj = formobj.elements[fieldRequired[i]];
		if (obj){
			switch(obj.type){
			case "select-one":
				if (obj.selectedIndex == -1 || obj.options[obj.selectedIndex].text == ""){
					alertMsg += " - " + fieldDescription[i] + "\n";
				}
				break;
			case "select-multiple":
				if (obj.selectedIndex == -1){
					alertMsg += " - " + fieldDescription[i] + "\n";
				}
				break;
			case "text":
			case "textarea":
				if (obj.value == "" || obj.value == null){
					alertMsg += " - " + fieldDescription[i] + "\n";
				}
				break;
			default:
			}
			if (obj.type == undefined){
				var blnchecked = false;
				for (var j = 0; j < obj.length; j++){
					if (obj[j].checked){
						blnchecked = true;
					}
				}
				if (!blnchecked){
					alertMsg += " - " + fieldDescription[i] + "\n";
				}
			}
		}
	}

	if (alertMsg.length == l_Msg){
		return true;
	}else{
		alert(alertMsg);
		return false;
	}
}
// -->
</script>

<table width="400" border="0" cellpadding="2" cellspacing="0" bordercolor="white">
        <tr>
            <td width="49%" align="left" valign="top"><span class="style2"><asp:Label Font-Size="Medium" ID="lblCaption" runat="server"></asp:Label></span></td>
        </tr>
		<tr>
            <td align="left" valign="top"><strong><font color="#FF0000">*&nbsp;Required Field</font></strong></td>
	    </tr>

</table>
<table width="400" border="1" cellpadding="2" cellspacing="0" bordercolor="#000000">
			
					<tr valign="middle" bgcolor="#999999">
					  <td height="29" COLSPAN=2 align="center"><strong>CONTACT INFORMATION</strong></td>
					  </tr>
					<tr bgcolor="#C8E080"> 
						<td width="400" height="27" COLSPAN=2><strong>Address:</strong></td> 
					</tr>
						
										
					<tr>
						<td align="left" width="400">
						    <table width="250" border="0" cellspacing="0" cellpadding="0">
							    <tr valign="middle">
								    <td width="250" COLSPAN="5">School Name<font color="#FF0000">*</font> </td>					
							    </tr>
    							
							    <tr valign="middle">
								    <td width="250" COLSPAN="5" align="left">
								        <asp:TextBox ID="txtSchoolName" runat="server" CssClass="border" MaxLength="75" Width="250"></asp:TextBox>
							  	    </td>
                        	    </tr>
    							
							    <tr valign="middle">
							      <td COLSPAN="5">&nbsp;</td>
							      </tr>
							  
							  
							     <tr valign="middle">
								    <td width="250" COLSPAN=5>School ID<font color="#FF0000">*</font> </td>					
							    </tr>
							
							    <tr valign="middle">
								    <td width="250" COLSPAN=5 align="left">
								        <asp:TextBox ID="txtSchoolID" runat="server" CssClass="border" MaxLength="75" Width="250"></asp:TextBox>
							  	    </td>
                        	    </tr>
							
							    <tr valign="middle">
							      <td COLSPAN=5>&nbsp;</td>
							      </tr>
							  
							    <tr valign="middle">
								    <td width="250" COLSPAN=5>School District<font color="#FF0000">*</font> </td>					
							    </tr>
    							
							    <tr valign="middle">
								    <td width="250" COLSPAN=5 align="left">
								    <asp:DropDownList ID="ddlSchoolDistrict" runat="server" AutoPostBack="false"></asp:DropDownList>
															    </td>
                        	    </tr>
							
							    <tr valign="middle">
							      <td COLSPAN=5>&nbsp;</td>
							      </tr>
							
							    <tr valign="middle">
							    <td width="250" COLSPAN=5>Street Address (line 1)<font color="#FF0000">*</font></td>
							    </tr>

							    <tr valign="middle">
							    <td width="250" COLSPAN=5 align="left">
							      <asp:TextBox ID="txtSchoolStreetAddress1" runat="server" CssClass="border" MaxLength="100" Width="250"></asp:TextBox></td>
    							
                        				    </tr>

							    <tr valign="middle">
							      <td COLSPAN=5>&nbsp;</td>
							      </tr>
							      
							      
							    <tr valign="middle">
							    <td width="250" COLSPAN=5>Street Address (line 2)</td> 
							    </tr>

							    <tr valign="middle">
							    <td width="250" COLSPAN=5>
                                    <asp:TextBox ID="txtSchoolStreetAddress2" runat="server" CssClass="border" MaxLength="100" Width="250"></asp:TextBox>

							    </td>
                        		</tr>
	
							    <tr valign="middle">
							      <td COLSPAN="1">&nbsp;</td>
							      <td COLSPAN="4">&nbsp;</td>
							      </tr>
							      
							    <tr valign="middle">
							    <td width="100" COLSPAN=1>City<font color="#FF0000">*</font> </td>
							    <td width="200" COLSPAN=4>
							      <asp:TextBox ID="txtSchoolCity" runat="server" CssClass="border" MaxLength="50" Width="175"></asp:TextBox>
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
							        <asp:TextBox ID="txtSchoolState" runat="server" CssClass="border" MaxLength="2" Width="25"></asp:TextBox>
	                            </td>
							    <td width="60">&nbsp;</td>
							    <td width="60"><font color="#FF0000">*</font>  Zip</td>
							    <td width="60">
							        <asp:TextBox ID="txtSchoolZip" runat="server" CssClass="border" MaxLength="5" Width="50"></asp:TextBox>
							        </td>
							    </tr>

							</table>
					</td>
	            
						<td align="left" valign="top">
						
						<table width="250" border="0" cellspacing="0" cellpadding="0">
							<tr valign="middle">
							    <td width="65" align="left">Telephone<font color="#FF0000">*</font> </td>
							    <td width="185" align="left">
							      ( <asp:TextBox ID="txtSchoolPhone01" runat="server" CssClass="border" MaxLength="3" Width="30"></asp:TextBox> )&nbsp;
							      <asp:TextBox ID="txtSchoolPhone02" runat="server" CssClass="border" MaxLength="3" Width="30"></asp:TextBox>
    						      &nbsp;-
    						      <asp:TextBox ID="txtSchoolPhone03" runat="server" CssClass="border" MaxLength="4" Width="50"></asp:TextBox>
							      </td>
							  </tr>						

							    <tr valign="middle">
							      <td align="left">&nbsp;</td>
							      <td align="left">&nbsp;</td>
							      </tr>
							    <tr valign="middle">
							    <td width="65" align="left">Fax<font color="#FF0000">*</font> </td>
							    <td width="185" align="left">
							    ( <asp:TextBox ID="txtSchoolFax01" runat="server" CssClass="border" MaxLength="3" Width="30"></asp:TextBox> )&nbsp;
							      <asp:TextBox ID="txtSchoolFax02" runat="server" CssClass="border" MaxLength="3" Width="30"></asp:TextBox>
    						      &nbsp;-
    						      <asp:TextBox ID="txtSchoolFax03" runat="server" CssClass="border" MaxLength="4" Width="50"></asp:TextBox>
							      </td></tr>		
							 
							 
							</table>							
							</td>
							
							
					    </tr>
					<tr bgcolor="#CCCCCC">
                      <td height="6" colspan=2></td>
					  </tr>

					<tr bgcolor="#C8E080">
						<td width="400" height="27" COLSPAN=2><strong>Administrative Contact:</strong></td>
					</tr>

					<tr>
						<td align="left" valign="top"><table width="250" border="0" cellspacing="0" cellpadding="0">
							<tr valign="middle">
							<td width="100" align="left">Full Name<font color="#FF0000">*</font> </td> 
							<td Width="200" align="left">
							
							<asp:TextBox ID="txtSchoolAdministratorName" runat="server" CssClass="border" MaxLength="75" Width="160"></asp:TextBox>
						</td>
                        				</tr>
							</table></td>
		
						<td align="left" valign="top"><table width="250" border="0" cellspacing="0" cellpadding="0">

							<tr valign="middle">
							<td width="110" align="left">Telephone<font color="#FF0000">*</font> </td>
							<td width="190" align="left">
							  ( <asp:TextBox ID="txtSchoolAdministratorPhone01" runat="server" CssClass="border" MaxLength="3" Width="30"></asp:TextBox> &nbsp;)&nbsp;
							  <asp:TextBox ID="txtSchoolAdministratorPhone02" runat="server" CssClass="border" MaxLength="3" Width="30"></asp:TextBox>
    						  &nbsp;-
    						  <asp:TextBox ID="txtSchoolAdministratorPhone03" runat="server" CssClass="border" MaxLength="4" Width="50"></asp:TextBox>
						
												</td>
							</tr>						

							<tr valign="middle">
							  <td align="left">&nbsp;</td>
							  <td align="left">&nbsp;</td>
							  </tr>
							<tr valign="middle">
							<td width="110" align="left">Email<font color="#FF0000">*</font> </td>
							<td width="190" align="left">
							 <asp:TextBox ID="txtSchoolAdministratorEmail" runat="server" CssClass="border" MaxLength="75" Width="160"></asp:TextBox>
							</td>
        	                			</tr>
							</table></td>
					<tr bgcolor="#CCCCCC">
                      <td height="6" colspan=2></td>
					  </tr>

					<tr valign="middle" bgcolor="#C8E080">
						<td width="400" COLSPAN=2><strong>Type of Schoo</strong>l<font color="#FF0000">*</font>  &nbsp;&nbsp;
						    <asp:DropDownList ID="ddlSchoolType" runat="server">
						        <asp:ListItem Text="Select a Type" Value="none"></asp:ListItem><asp:ListItem Text="Pre-K" Value="0"></asp:ListItem><asp:ListItem Text="Elementary" Value="1"></asp:ListItem><asp:ListItem Text="Middle" Value="2"></asp:ListItem><asp:ListItem Text="High" Value="3"></asp:ListItem><asp:ListItem Text="Alternative" Value="4"></asp:ListItem><asp:ListItem Text="Other" Value="5"></asp:ListItem>
						    </asp:DropDownList>
						</td>
					</tr>
					<%--<tr bgcolor="#CCCCCC">
                      <td height="6" colspan=2></td>
					  </tr>--%>
					   <tr bgcolor="#C8E080">
                                        <td height="6" colspan=2><strong>Make Baseline Form available:&nbsp;</strong>&nbsp;
                                        
                                        <asp:RadioButton Checked="true" GroupName="grpBaseline" ID="rbbaseline0" runat="server" Text="No" />
                                        <asp:RadioButton GroupName="grpBaseline" ID="rbbaseline1" runat="server" text="Yes"/>
                                  </td>
                                      </tr>
					<tr valign="middle" bgcolor="#C8E080">
					  <td height="6" colspan=2><strong>Inactive School</strong> &nbsp;&nbsp;
					  <asp:CheckBox ID="chkInactive" runat="server" />
					  </td>
					  </tr>
					<tr bgcolor="#CCCCCC">
                      <td height="6" colspan=2></td>
					  </tr>
					  
    
				</table>
				
				<table width="100%">
				<tr>
			<td align="center">&nbsp;</td>
		</tr>
				<tr>
			<td align="center"><asp:Label id="lblstatus" runat="server" ForeColor="Red"></asp:Label></td>
		</tr>
				<tr>
        <td align="center" colspan="2"><asp:Button runat="server" ID="btnsubmit" BackColor="Beige" BorderColor="#C8E07F" BorderWidth="3" Text="Submit" OnClientClick="return checkFormfmhischprf('Form1');" /></td>
    </tr>
				</table>
        </td>
    </tr>
    
 
    
    
 
</asp:Content>