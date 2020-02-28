<%@ Page Language="VB" MasterPageFile="~/pbsmaster/Main.master" AutoEventWireup="false" CodeFile="school_ODS_Add.aspx.vb" Inherits="school_school_ODS_Add" %>


<asp:Content ID ="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<script type="text/javascript" language="JavaScript" src="../includes/validate_ODS.js"></script>
    <tr>
        <td>
  <table width="100%"  border="0" cellspacing="0" cellpadding="0">
                          <tr>
                            <td width="49%" align="left" valign="top"><span class="style2"><font color="red" face="Arial, Helvetica, sans-serif" size=-1>Outcome data should not be entered until after the last day of school.</FONT></span><p 
                                    class="style2"><FONT face="Arial, Helvetica, sans-serif">OUTCOME DATA SUMMARY FORM</FONT></p>							</td>
                            </tr>
                          <tr>
                            <td align="left" valign="top">
								<span class="style2"><font face="Arial, Helvetica, sans-serif" size=-1> School Name: <asp:Label CssClass="style2" Font-Size="Small" Font-Bold="true" id="lblSchoolName" runat="server"></asp:Label></FONT></span>
							</td>
                          </tr>
							<tr>
                            <td align="left" valign="top"><span class="style2"><font face="Arial, Helvetica, sans-serif" size=-1> School Year: <asp:Label CssClass="style2" Font-Size="Small" Font-Bold="true" ID="lblSchoolYr" runat="server"></asp:Label></FONT></span></td>
                          </tr>
                          <tr>
                            <td align="left" valign="top">&nbsp;</td>
                          </tr>
                          <tr>
                            <td align="left" valign="top">
							
				
							
							

					<table width="550" border="1" cellpadding="2" cellspacing="0" bordercolor="#000000">
					<tr>	
						<th width="550" height="41" colspan="2" align="center" valign="center" bgcolor="#C8E07F">ATTENDANCE DATA<br/>
						  (Current Year)</th>
                   	  </tr>

					<tr valign="middle"> 
						<td width="300" >Total number of school days</td>
						<td align="center" >
						<asp:TextBox ID="txtOdTotalSchoolDays" runat="server" CssClass="border" MaxLength="4" Width="70"></asp:TextBox>
						</td>					
					</tr>

					<tr valign="middle">
						<td width="300">Average daily attendance (%)</td>
						<td align="center">
							<asp:TextBox ID="txtOdAvgDailyAttendance" runat="server" CssClass="border" MaxLength="4" Width="70"></asp:TextBox>
						</td>
					</tr> 
					</table><br>
									
					<table width="550" height="131" border="1" cellpadding="2" cellspacing="0" bordercolor="#000000">
					<tr>	
						<th width="550" colspan="2" align="center" valign="center" bgcolor="#C8E07F">BEHAVIORAL DATA<br>
						(Current Year Through Last Day)</th>
                   	  </tr>

					<tr valign="middle"> 
						<td width="300" >Total Number of office discipline referrals</td>
						<td align="center" >
						    <asp:TextBox ID="txtOdTotalOfficeReferrals" runat="server" CssClass="border" MaxLength="4" Width="70"></asp:TextBox>
						</td>					
					</tr>

					<tr valign="middle">
						<td width="300">Total number of days of in-school suspensions</td>
						<td align="center">
						    <asp:TextBox ID="txtOdTotalISSDays" runat="server" CssClass="border" MaxLength="4" Width="70"></asp:TextBox>
						</td>
					</tr>

					<tr valign="middle"> 
						<td width="300" >Total number of days of out-of-school suspensions</td>
						<td align="center" >
						    <asp:TextBox ID="txtOdTotalOSSDays" runat="server" CssClass="border" MaxLength="4" Width="70"></asp:TextBox>
						</td>
					</tr>
					</table><br>


									
					<table width="550" border="1" cellpadding="2" cellspacing="0" bordercolor="#000000">
					<tr>	
						<th width="550" height="41" colspan="2" align="center" valign="center" bgcolor="#C8E07F">Are Progress Monitoring Tools in Use at Your School?<br>
						  If Yes, describe briefly.</th>
                   	  </tr> 

					<tr valign="middle"> 
						<td width="30%" align="center">Tier 2 Supplemental<br>
							<asp:RadioButton runat="server" GroupName="grpTier2" ID="radioOdProgMonTargetYes" Text="Yes" />
					       	<asp:RadioButton runat="server" GroupName="grpTier2" ID="radioOdProgMonTargetNo" Text="No" />
						  </td>
						<td align="left" >
					    	<asp:TextBox TextMode="MultiLine" runat="server" ID="txtOdProgMonTargDesc" Columns="45" CssClass="border"></asp:TextBox>
				    
						</td>					
					</tr>

					<tr valign="middle">
						<td width="30%" align="center">Tier 3 Intensive<br>
						<asp:RadioButton runat="server" GroupName="grpTier3" ID="radioOdProgMonIndivYes" Text="Yes" />
					       	<asp:RadioButton runat="server" GroupName="grpTier3" ID="radioOdProgMonIndivNo" Text="No" />
						</td>
						<td align="left">
							<asp:TextBox TextMode="MultiLine" runat="server" ID="txtOdProgMonIndDesc" Columns="45" CssClass="border"></asp:TextBox>
						</td>
					</tr> 
				<tr valign="middle">
					  <td align="center">Progress Monitoring Documentation </td>
					  <td align="left"><a href="mailto:childs@fmhi.usf.edu?subject=ODS support documents for School: <%=(Session("MM_Username")) %>">Click here</a> to email support files to illustrate Progress Monitoring at you school </td>
					  </tr> 
					
					</table>
					<BR>
					<%--<table width="550" border="1" cellpadding="2" cellspacing="0" bordercolor="#000000"> 
					    <tr>	
						<th width="550" height="41" colspan="2" align="center" valign="center" bgcolor="#C8E07F" >Upload Document</th>
                   	  </tr> 
                   	  
                   	  <tr valign="middle"> 
						<td width="30%" align="center">Select document<br>
							
						  </td>
						<td align="right">
					    	<asp:FileUpload  BorderColor="#C8E07F" BorderWidth="3" ForeColor="Black" Font-Bold="true" ID="fluploadODS" runat="server" />
				           
						</td>					
					</tr>
					
					</table>
					--%>

					<table width="550" border="0" cellspacing="0" cellpadding="0">
					
					<tr><td><p align="center"><span class="contentText"><a href="javascript:window.print()">CLICK HERE TO PRINT THE FORM <strong>BEFORE</strong> SUBMITTING!!</a></span><a HREF="javascript:window.print()"></a>&nbsp;&nbsp;&nbsp;</td></tr>
					<tr>
					  <td><div align="center">
					    </div></td>
					  </tr>
					<tr>
					  <td>
					      <div align="center">
					        <asp:Button id="btnsubmit" BackColor="Beige" OnClientClick="return checkformODS('Form1');" BorderColor="#C8E07F" BorderWidth="3" runat="server" Text="Submit" />
					      </div>
					  </td>
					  </tr>
					</table>
							
							
							
                    
                          							</td>
                          </tr>
                          <tr>
                            <td align="left" valign="top">&nbsp;							</td>
                          </tr>
                        </table>
        </td>
    </tr>
</asp:Content>