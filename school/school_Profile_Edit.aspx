<%@ Page Language="VB"  MasterPageFile="~/pbsmaster/Main.master"  AutoEventWireup="false" CodeFile="school_Profile_Edit.aspx.vb" Inherits="users_school_Profile_Edit" %>

<asp:Content ID ="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

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
<tr>
                            		<td width="49%" align="left" valign="top" 
                                        style="font-size: small; color: #7BA400; font-weight: bold">
                                        <font face="Arial, Helvetica, sans-serif"
					>SCHOOL-WIDE PBS: SCHOOL PROFILE INFORMATION FORM</font></td>
                        	</tr>
						 
				<tr>
					<td><span class="style2"><font face="Arial, Helvetica, sans-serif" size=-1>
					    <span style="font-size: small">School Name: </span> </font></span><asp:Label CssClass="style2" Font-Size="Small" Font-Bold="true" ID="lblSchoolName" runat="server"></asp:Label></td>
					
				</tr>
							  
				<tr>
                        	    	<td align="left" valign="top"><strong><font color="#FF0000">*&nbsp;Required Field</font></strong></td>
				</tr>
				
				     	<tr>
                	            	<td align="left" valign="top"></td>
                        	</tr>
    <tr>
        <td align="left" valign="top">
<table width="400" border="1" cellpadding="2" cellspacing="0" bordercolor="#000000">
					

					<tr valign="middle" bgcolor="#999999">
					  <td height="26" COLSPAN=2 align="center"><strong>CONTACT INFORMATION </strong></td>
					  </tr>
					<tr> 
						<td width="400" COLSPAN=2 bgcolor="#C8E07F"><strong>Address:</strong></td> 
					</tr>
						
					<tr>
						<td align="left" width="400"><table width="260" border="0" cellspacing="0" cellpadding="0">

							<tr valign="middle">
							<td width="250" COLSPAN=5>Street Address (line 1)<font color="#FF0000">* </font> 							
							</tr>

							<tr valign="middle">
							<td width="250" COLSPAN=5 align="left">
							  <asp:TextBox ID="txtSchoolStreetAddress1" runat="server" CssClass="border" Width="280"  MaxLength="100"></asp:TextBox></td>
                        				</tr>

							<tr valign="middle">
							  <td colspan=5>
							  &nbsp;
							  </td>
							  </tr>
							 
							<tr valign="middle"><td width="250" COLSPAN=5>Street Address (line 2)</td></tr><tr valign="middle">
							<td width="250" COLSPAN=5><asp:TextBox ID="txtSchoolStreetAddress2" runat="server" CssClass="border" Width="280"  MaxLength="100"></asp:TextBox></td></tr><tr valign="middle">
							  <td COLSPAN=1>&nbsp;</td><td COLSPAN=4>&nbsp;</td></tr><tr valign="middle">
							<td width="80" COLSPAN=1>City<font color="#FF0000">*</font> </td>
							<td width="200" COLSPAN=4 align="left">
							<asp:TextBox ID="txtSchoolCity" runat="server" CssClass="border" Width="180"  MaxLength="50"></asp:TextBox>&nbsp;
							</td></tr>
							<tr><td></td>
							    <td></td>
							</tr>
							
							<tr valign="middle">
							  <td>&nbsp;</td><td>&nbsp;</td><td>&nbsp;</td><td>&nbsp;</td><td>&nbsp;</td></tr><tr valign="middle">
							<td width="60">State<font color="#FF0000">*</font> </td>
							<td width="60">
							
							<asp:TextBox ID="txtSchoolState" runat="server" CssClass="border" Width="40"  MaxLength="2"></asp:TextBox>
                                
                            </td><td width="60">&nbsp;</td><td width="60">Zip<font color="#FF0000">*</font> </td>
							<td width="60">
							
							<asp:TextBox ID="txtSchoolZip" runat="server" CssClass="border" Width="60"  MaxLength="5"></asp:TextBox></td></tr>
							<tr><td></td>
							    <td></td>
							    <td></td> <td></td>
							    <td></td>
							</tr>
							
							</table></td><td align="left" valign="top">
						
						<table width="250" border="0" cellspacing="0" cellpadding="0">
							<tr valign="middle">
							<td width="71" align="left">Telephone<font color="#FF0000">*</font> </td>
							<td width="179" align="left">
							  (
							  
							  
							  <asp:TextBox ID="txtSchoolPhone01"  runat="server" CssClass="border" Width="30"  MaxLength="3"></asp:TextBox>)&nbsp;<asp:TextBox ID="txtSchoolPhone02" runat="server" CssClass="border" Width="30"  MaxLength="3"></asp:TextBox>-<asp:TextBox ID="txtSchoolPhone03" runat="server" CssClass="border" Width="40"  MaxLength="4"></asp:TextBox></td></tr><%--	             <tr>
                                <td colspan ="2">
                             <asp:RequiredFieldValidator ID="rqSchoolPhone1" Display="Dynamic" ErrorMessage="Enter a 3-digit numeric value." ControlToValidate="txtSchoolPhone01" runat="server"></asp:RequiredFieldValidator><br />
                                <asp:RequiredFieldValidator ID="rqSchoolPhone2" Display="Dynamic" ErrorMessage="Enter a 3-digit numeric value." ControlToValidate="txtSchoolPhone02" runat="server"></asp:RequiredFieldValidator><br />
                                <asp:RequiredFieldValidator ID="rqSchoolPhone3" Display="Dynamic" ErrorMessage="Enter a 4-digit numeric value." ControlToValidate="txtSchoolPhone03" runat="server"></asp:RequiredFieldValidator>
                             
                         
                                
                                  </td>
                               </tr>--%>
                             <%--  <tr>
                                <td colspan ="2">
                                <asp:RegularExpressionValidator ID="valSchoolPhone1" Display="Dynamic" ErrorMessage="Enter a valid 3-digit numeric value." ControlToValidate="txtSchoolPhone01" runat="server" ValidationExpression="[0-9]*"></asp:RegularExpressionValidator><br />
                                <asp:RegularExpressionValidator ID="valSchoolPhone2" Display="Dynamic" ErrorMessage="Enter a valid 3-digit numeric value." ControlToValidate="txtSchoolPhone02" runat="server" ValidationExpression="[0-9]*"></asp:RegularExpressionValidator><br />
                                <asp:RegularExpressionValidator ID="valSchoolPhone3" Display="Dynamic" ErrorMessage="Enter a valid 4-digit numeric value." ControlToValidate="txtSchoolPhone03" runat="server" ValidationExpression="[0-9]*"></asp:RegularExpressionValidator>
                                </td>
                               </tr>--%>
							<tr valign="middle">
							  <td align="left">&nbsp;</td><td align="left">&nbsp;</td></tr><tr valign="middle">
							<td width="71" align="left">Fax<font color="#FF0000">*</font> </td>
							<td width="179" align="left">
							  (
							  
							    
							    <asp:TextBox ID="txtSchoolFax01" runat="server" CssClass="border" Width="30"  MaxLength="3"></asp:TextBox>)
							   <asp:TextBox ID="txtSchoolFax02" runat="server" CssClass="border" Width="30"  MaxLength="3"></asp:TextBox>-<asp:TextBox ID="txtSchoolFax03" runat="server" CssClass="border" Width="40"  MaxLength="4"></asp:TextBox></td></tr></table></td></tr><tr bgcolor="#CCCCCC">
						<td width="400" height="6" COLSPAN=2></td>
					</tr>

					<tr>
						<td width="400" COLSPAN=2 bgcolor="#C8E07F"><strong>Administrative Contact:</strong></td></tr><tr>
						<td align="left" valign="top"><table width="250" border="0" cellspacing="0" cellpadding="0">
							<tr valign="middle">
							<td width="100" align="left">Full Name<font color="#FF0000">*</font></td><td Width="200" align="left">&nbsp;</td></tr><tr valign="middle">
							  <td colspan="2" align="left">
							 
							  <asp:TextBox ID="txtSchoolAdministratorName" runat="server" CssClass="border" Width="200"  MaxLength="75"></asp:TextBox></td></tr></table></td><td align="left" valign="top"><table width="250" border="0" cellspacing="0" cellpadding="0">

							<tr valign="middle">
							<td width="110" align="left">Telephone<font color="#FF0000">*</font></td><td width="190" align="left">&nbsp;
							
							( <asp:TextBox ID="txtSchoolAdministratorPhone01" runat="server" CssClass="border" Width="30"  MaxLength="3"></asp:TextBox>)&nbsp;<asp:TextBox ID="txtSchoolAdministratorPhone02" runat="server" CssClass="border" Width="30"  MaxLength="3"></asp:TextBox>-
							  <asp:TextBox ID="txtSchoolAdministratorPhone03" runat="server" CssClass="border" Width="40"  MaxLength="4"></asp:TextBox></td></tr><tr valign="middle">
							  <td align="left">&nbsp;</td><td align="left">&nbsp;</td></tr><tr valign="middle">
							<td width="110" align="left">Email<font color="#FF0000">*</font></td><td width="190" align="left"><asp:TextBox ID="txtSchoolAdministratorEmail" runat="server" CssClass="border" Width="180"  MaxLength="75"></asp:TextBox></td></tr><tr>
        	        <td colspan="2" align="right"></td></tr></table></td><tr bgcolor="#CCCCCC">
                      <td height="6" COLSPAN=2></td>
					  </tr>

					<tr valign="middle">
						<td width="400" COLSPAN=2 bgcolor="#C8E07F"><span class="style3"><font color="#FF0000">*</font> <strong>Type of School </strong></span>&nbsp;&nbsp;
					
						<asp:DropDownList ID="ddlSchoolType" runat="server" CssClass="border">
						    <asp:ListItem Text="Select a Type" Value="none"></asp:ListItem><asp:ListItem Text="Pre-K" Value="0"></asp:ListItem><asp:ListItem Text="Elementary" Value="1"></asp:ListItem><asp:ListItem Text="Middle" Value="2"></asp:ListItem><asp:ListItem Text="High" Value="3"></asp:ListItem><asp:ListItem Text="Alternative" Value="4"></asp:ListItem><asp:ListItem Text="Other" Value="5"></asp:ListItem></asp:DropDownList></td></tr><tr bgcolor="#CCCCCC">
                      <td height="6" COLSPAN=2>
                  <%--<table width="100%">
                    <tr>
                        <td align="justify" ><asp:RequiredFieldValidator ID="rqvaladdr1" runat="server" ControlToValidate="txtSchoolStreetAddress1" Display="Dynamic" Font-Bold="true" ErrorMessage="* Please enter Street Address (line 1)" Font-Size="Smaller"></asp:RequiredFieldValidator></td>
                      
                    </tr>
                    <tr>
                        <td align="justify" ><asp:RequiredFieldValidator ID="rqvalschoolcity" Font-Size="Smaller" Font-Bold="true"  runat="server" Display="Dynamic" ControlToValidate="txtSchoolCity"  ErrorMessage="* Please enter School City"></asp:RequiredFieldValidator></td>
                       
                    </tr>
                    
                    <tr>
                        <td align="justify"><asp:RequiredFieldValidator ID="rqvalschoolstate" runat="server" 
                                    ControlToValidate="txtSchoolState" Display="Dynamic" ErrorMessage="* Please enter School State" 
                                    Font-Bold="true" Font-Size="Smaller"></asp:RequiredFieldValidator></td>
                                   
                    </tr>
                    <tr>
                        <td align="justify"><asp:RequiredFieldValidator ID="rqvalschoolzip" Font-Size="Smaller" Font-Bold="true"  runat="server" Display="Dynamic" ControlToValidate="txtSchoolZip"  ErrorMessage="* Please enter School Zip"></asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td align="justify"><asp:RequiredFieldValidator ID="rqvaladminfullname" Font-Size="Smaller" Font-Bold="true"  runat="server" Display="Dynamic" ControlToValidate="txtSchoolAdministratorName"  ErrorMessage="* Please enter Full Name"></asp:RequiredFieldValidator></td>
                    </tr>
                     <tr>
                        <td align="justify"><asp:RequiredFieldValidator ID="rqvalemail" Font-Size="Smaller" Font-Bold="true"  runat="server" Display="Dynamic" ControlToValidate="txtSchoolAdministratorEmail"  ErrorMessage="* Please enter Email"></asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td align="justify"><asp:RegularExpressionValidator ID="valEmailAddress" Font-Size="Smaller"
                    ControlToValidate="txtSchoolAdministratorEmail"  Font-Bold="true" ErrorMessage="* Please enter a valid Email Id."  
                    Display="Dynamic" Runat="server" 
                    ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator></td>
                    </tr>
                    <tr>
                        <td align="justify"><asp:RequiredFieldValidator
        id="reqSchoolType" Font-Bold="true" Font-Size="Smaller"
        Text="* Please select a School Type"
        InitialValue="none"
        ControlToValidate="ddlSchoolType"
        Runat="server" /></td>
                    </tr>
                  </table>--%>
                      </td>
					  </tr> 
<tr>
			<td colspan="2">&nbsp;</td></tr><tr>
			<td colspan="2"><div align="center">
			  
			  <asp:Button ID="btnSubmit" runat="server" BackColor="Beige" BorderColor="#C8E07F" BorderWidth="3" Text="Submit"  OnClientClick="return checkForm('Form1');" />
			  </div></td>
		</tr>
				</table>
        </td>
    </tr>
</asp:Content>