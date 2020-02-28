<%@ Page Language="VB" MasterPageFile="~/pbsmaster/Main.master" AutoEventWireup="false" CodeFile="endyrslr_ods.aspx.vb" Inherits="pbsisrpts_endyrslr_ods" %>

<asp:Content ID ="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <tr><td style="width:5px"></tdf>
        <td>
<table width="100%"  border="0" cellspacing="0" cellpadding="0">
                          <tr>
                            <td width="49%" align="left" valign="top"><p><span class="style2"><FONT face="Arial, Helvetica, sans-serif" size=-1>OUTCOME DATA SUMMARY FORM</FONT></span><FONT face="Arial, Helvetica, sans-serif" size=-1> 
                            </FONT></p>							</td>
                            </tr>
                              <tr>
                            <td align="left" valign="top">
								<span class="style2"><FONT face="Arial, Helvetica, sans-serif" size=-1> District : <asp:Label Font-Bold="true" id="lblSchDistrict" runat="server"></asp:Label></FONT></span>
							</td>
                          </tr>
                          <tr>
                            <td align="left" valign="top">
								<span class="style2"><FONT face="Arial, Helvetica, sans-serif" size=-1> School: <asp:Label Font-Bold="true" id="lblSchoolName" runat="server"></asp:Label></FONT></span>
							</td>
                          </tr>
                          <tr>
                            <td align="left" valign="top">
								<span class="style2"><FONT face="Arial, Helvetica, sans-serif" size=-1> School Year: <%--<asp:Label Font-Bold="true" id="lblSchoolYr" runat="server"></asp:Label>--%>
								 <asp:DropDownList ID="ddlYear" runat="server" AutoPostBack="true">
                    <asp:ListItem Text="2004-2005" Value="8"></asp:ListItem>
                    <asp:ListItem Text="2005-2006" Value="9"></asp:ListItem>
                    <asp:ListItem Text="2006-2007" Value="10"></asp:ListItem>
                    <asp:ListItem Text="2007-2008" Value="11"></asp:ListItem>
                    <asp:ListItem Text="2008-2009" Value="12"></asp:ListItem>
                    <asp:ListItem Text="2009-2010" Value="13"></asp:ListItem>
                  </asp:DropDownList>
								</FONT></span>
							</td>
                          </tr>
                          <tr>
                            <td align="left" valign="top">&nbsp;</td>
                          </tr>
                          <tr>
                            <td align="left" valign="top">
							
							

					<table width="550" border="1" cellspacing="0" cellpadding="0">
					<tr>	
						<th width="550" colspan="2" align="center" valign="center" bgcolor="#C8E07F">ATTENDANCE DATA<br>(Current Year)</th>
                   	  </tr>

					<tr> 
						<td width="300" >Total number of school days</td>
						<td align="center" ><asp:Label ID="lblOdTotalSchoolDays" runat="server"></asp:Label></td>					
					</tr>

					<tr>
						<td width="300">Average daily lblOdTotalSchoolDays (%)</td>
						<td align="center"><asp:Label ID="lblOdAvgDailyAttendance" runat="server"></asp:Label></td>
					</tr> 
					</table><br>
									
					<table width="550" border="1" cellspacing="0" cellpadding="0">
					<tr>	
						<th width="550" colspan="2" align="center" valign="center" bgcolor="#C8E07F">BEHAVIORAL DATA<br>						  (Current Year Through Last Day)</th>
                   	  </tr>

					<tr> 
						<td width="300" >Total Number of office discipline referrals</td>
						<td align="center" ><asp:Label ID="lblOdTotalOfficeReferrals" runat="server"></asp:Label></td>					
					</tr>

					<tr>
						<td width="300">Total number of days of in-school suspensions</td>
						<td align="center"><asp:Label ID="lblOdTotalISSDays" runat="server"></asp:Label></td>
					</tr>

					<tr> 
						<td width="300" >Total number of days of out-of-school suspensions</td>
						<td align="center" ><asp:Label ID="lblOdTotalOSSDays" runat="server"></asp:Label></td>
					</tr>
					</table><br>

					<!--<table width="550" border="1" cellspacing="0" cellpadding="0">
					<tr>	
						<th width="550" colspan="2" align="center" valign="center" bgcolor="#C8E07F">ACADEMIC DATA - FCAT<br>(if available before evaluation deadline)</th>
                   	  </tr>

					<tr> 
						<td width="300" >Percent of students making learning gains in reading</td>
						<td align="center" ></td>					
					</tr>

					<tr>
						<td width="300">Percent of lowest 25% making learning gains in reading</td>
						<td align="center"></td>
					</tr>
					</table><br>-->

					
					<table width="550" border="1" cellpadding="2" cellspacing="0">
					<tr>	
						<th width="550" height="41" colspan="2" align="center" valign="center" bgcolor="#C8E07F"> Progress Monitoring Tools in Use at Your School<br>						  </th>
                   	  </tr> 

					<tr valign="middle"> 
						<td width="30%" align="center"><div align="left">
                            Tier 2 Supplemental: <asp:Label ID="lblOdProgMonTarg" runat="server"></asp:Label></div></td>
						<td align="left" ><asp:Label ID="lblOdProgMonTargDesc" runat="server"></asp:Label></td>
					</tr>

					<tr valign="middle">
						<td width="30%" align="center"><div align="left">
                            Tier 3 Intensive:  <asp:Label ID="lblOdProgMonInd" runat="server"></asp:Label>
                            <br>
						  </div></td>
						<td align="left"><asp:Label ID="lblOdProgMonIndDesc" runat="server"></asp:Label></td>
					</tr> 
					
					</table>
					
					
                  
                   		</td>
                          </tr>
                          <tr>
                            <td align="left" valign="top">&nbsp;							</td>
                          </tr>
                          
                          <tr>
                            <td><asp:LinkButton ID="hylViewDocs" runat="server" Text="View / Upload Documents" ></asp:LinkButton></td>
                          </tr> <tr>
                            <td align="left" valign="top">&nbsp;							</td>
                          </tr>
                        </table>
        </td>
    </tr>
</asp:Content>