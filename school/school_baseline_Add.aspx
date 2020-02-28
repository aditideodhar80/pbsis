<%@ Page Language="VB"  MasterPageFile="~/pbsmaster/Main.master"  AutoEventWireup="false" CodeFile="school_baseline_Add.aspx.vb" Inherits="school_school_baseline_Add" %>

<asp:Content ID ="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <script language="javascript">


    function activateIntvOnLoad(formobj, varRadio) {
        //alert('in');
        var checkList = Array("ctl00_ContentPlaceHolder1_chkDemoTchIntvBEP", "ctl00_ContentPlaceHolder1_chkDemoTchIntvICPS", "ctl00_ContentPlaceHolder1_chkDemoTchIntvSklStr", "ctl00_ContentPlaceHolder1_chkDemoTchIntvPrep", "ctl00_ContentPlaceHolder1_chkDemoTchIntvSTR", "ctl00_ContentPlaceHolder1_chkDemoTchIntvSecStp", "ctl00_ContentPlaceHolder1_chkDemoTchIntvSC", "ctl00_ContentPlaceHolder1_chkDemoTchIntvOth", "ctl00_ContentPlaceHolder1_txtDemoTchIntvOthDesc");

        //var varRadio = formobj.DemoTchTargBehIntv.value;

        for (var i = 0; i < checkList.length; i++) {
            var obj = document.forms[0].elements[checkList[i]];

            if (obj) {
                //alert('in obj');
                if (varRadio == "1") //If yes, enable
                { obj.disabled = false; }
                else //If no, disable
                {
                    obj.disabled = true;
                    if (obj.type == "text")  //If this is a text field, blank it out
                    { obj.value = ""; }
                    else //else if it is a checkbox, uncheck it
                    { obj.checked = false; }
                }
            }
        }
    }
    
    
    function activateIntv(formobj, varRadio) {
        //alert('in');
        var checkList = Array("ctl00_ContentPlaceHolder1_chkDemoTchIntvBEP", "ctl00_ContentPlaceHolder1_chkDemoTchIntvICPS", "ctl00_ContentPlaceHolder1_chkDemoTchIntvSklStr", "ctl00_ContentPlaceHolder1_chkDemoTchIntvPrep", "ctl00_ContentPlaceHolder1_chkDemoTchIntvSTR", "ctl00_ContentPlaceHolder1_chkDemoTchIntvSecStp", "ctl00_ContentPlaceHolder1_chkDemoTchIntvSC", "ctl00_ContentPlaceHolder1_chkDemoTchIntvOth", "ctl00_ContentPlaceHolder1_txtDemoTchIntvOthDesc");

        //var varRadio = formobj.DemoTchTargBehIntv.value;

        for (var i = 0; i < checkList.length; i++) {
            var obj = document.forms[0].elements[checkList[i]];

            if (obj) {
                //alert('in obj');
                if (varRadio == "1") //If yes, enable
                { obj.disabled = false; }
                else //If no, disable
                {
                    obj.disabled = true;
                    if (obj.type == "text")  //If this is a text field, blank it out
                    { obj.value = ""; }
                    else //else if it is a checkbox, uncheck it
                    { obj.checked = false; }
                }
            }
        }
    }


    function activatePbs(formobj, varRadio) {

        var checkList = Array("ctl00_ContentPlaceHolder1_chkDemoTchPbsERASE", "ctl00_ContentPlaceHolder1_chkDemoTchPbsPTR", "ctl00_ContentPlaceHolder1_chkDemoTchPbsOth", "ctl00_ContentPlaceHolder1_txtDemoTchPbsOthDesc");

        for (var i = 0; i < checkList.length; i++) {
            var obj = document.forms[0].elements[checkList[i]];
            if (obj) {
                if (varRadio == "1") //If yes, enable
                { obj.disabled = false; }
                else //If no, disable
                {
                    obj.disabled = true;
                    if (obj.type == "text")
                    { obj.value = ""; }
                    else
                    { obj.checked = false; }
                }
            }
        }
    }
		

</script>
<style type="text/css">

body {
	margin-left: 0px;
	margin-top: 0px;
	margin-right: 0px;
	margin-bottom: 0px;
}

</style>

<script type="text/javascript" language="JavaScript" src="../display/mm_menu.js"></script>
<script type="text/javascript" language="JavaScript" src="../display/mm_menu2.js"></script>
<script type="text/javascript" language="JavaScript" src="../includes/validate_DemoData.js"></script>


<link href="../display/pbsStyles.css" rel="stylesheet" type="text/css"/>
<style type="text/css">
<!--
.style2 {color: #7BA400; font-weight: bold;}
body,td,th {
	font-family: Arial, Helvetica, sans-serif;
	font-size: small;
}
    .style3
    {
        width: 326px;
    }
    .style4
    {
        color: #7BA400;
        font-weight: bold;
    }
-->
</style>
    <tr>
        <td>
        <table width="100%"  border="0" align="left" cellpadding="0" cellspacing="0">
              <tr>
                <td width="10">&nbsp;</td>
                 <td width="10">&nbsp;</td>
                    <td align="left" valign="top">
                        <div align="left">
                            <table width="100%"  border="0" cellspacing="0" cellpadding="0">
                                <tr>
                                    <td>
					                    <table width="100%"  border="0" cellspacing="0" cellpadding="0">
                                            <tr>
                                                <td width="49%" align="left" valign="top">
        	                                        <table width="550"  border="0" cellspacing="0" cellpadding="0"> 
                                                        <tr>
                            		                            <td width="49%" align="left" valign="top" class="style4">
                                                                    <font face="Arial, Helvetica, sans-serif">
                                                                    SCHOOL PROFILE INFORMATION FORM (BASELINE INFORMATION)</font></td>
                        	                            </tr>
						  
				                                        <tr>
				                                          <td><span class="style2"><font face="Arial, Helvetica, sans-serif" ></font>School Name: </span><asp:Label CssClass="style2" Font-Size="Small" Font-Bold="true"  id="lblSchoolName" runat="server"></asp:Label></td>
				                                        </tr>
							                             <tr>
                                                            <td align="left" valign="top"><span class="style2">School Year: </span><asp:Label  ID="lblSchoolYr" CssClass="style2" Font-Size="Small" Font-Bold="true"  runat="server"></asp:Label></td>
                                                         </tr>
				                                         <tr>
					                                            <td>&nbsp;</td>
				                                         </tr>
				                                    </table>
					
					                                <table width="550" height="106" border="1" cellpadding="0" cellspacing="0" bordercolor="#000000">
					                                <tr bgcolor="#C8E080">	
						                                <th width="550" height="31" colspan="8" align="center" valign="center">Student Enrollment by Race/Ethnicity</th>
                   	                                  </tr>

					                                    <tr> 
						                                    <td width="12%" align="center">American Indian</td>
						                                    <td width="12%" align="center">Asian</td>
						                                    <td width="12%" align="center">Black</td>
						                                    <td width="12%" align="center">Hispanic</td>
						                                    <td width="12%" align="center">Multiracial</td>
						                                    <td width="12%" align="center">White</td>
						                                    <td width="12%" align="center">Other</td>
						                                    <td width="12%" align="center">Total Enrollment</td>
                                    					
					                                    </tr>

					                                    <tr> 
						                                    <td width="12%" align="center"><asp:TextBox ID="txtDemoTchAmericanIndian" runat="server" CssClass="border" MaxLength="8" Width="35"></asp:TextBox> </td>
						                                    <td width="12%" align="center"><asp:TextBox ID="txtDemoTchAsian" runat="server" CssClass="border" MaxLength="8" Width="35"></asp:TextBox></td>
						                                    <td width="12%" align="center"><asp:TextBox ID="txtDemoTchBlack" runat="server" CssClass="border" MaxLength="8" Width="35"></asp:TextBox></td>
						                                    <td width="12%" align="center"><asp:TextBox ID="txtDemoTchHispanic" runat="server" CssClass="border" MaxLength="8" Width="35"></asp:TextBox></td>
						                                    <td width="12%" align="center"><asp:TextBox ID="txtDemoTchMulticultural" runat="server" CssClass="border" MaxLength="8" Width="35"></asp:TextBox></td>
						                                    <td width="12%" align="center"><asp:TextBox ID="txtDemoTchWhite" runat="server" CssClass="border" MaxLength="8" Width="35"></asp:TextBox></td>
						                                    <td width="12%" align="center"><asp:TextBox ID="txtDemoTchOther" runat="server" CssClass="border" MaxLength="8" Width="35"></asp:TextBox></td>
						                                    <td width="12%" align="center"><asp:TextBox ID="txtDemoTchTotalEnrollment" runat="server" CssClass="border" MaxLength="8" Width="35"></asp:TextBox></td>
                                    					
					                                    </tr>
					                                </table>		  
				                                    <br/>

                                                    <table width="550" border="1" cellpadding="2" cellspacing="0" bordercolor="#000000">
						                                                    <tr bgcolor="#C8E080">	
						                                                    <th width="550" height="26" colspan="2" align="center" valign="center">Student Enrollment by Need</th>
                                  		                                                    </tr>
                                                    		
						                                                    <tr> 
							                                                    <td width ="50%" height="32" align="center">Number With IEP &nbsp;&nbsp;<asp:TextBox ID="txtDemoTchStudentsWithIEP" runat="server" CssClass="border" MaxLength="8" Width="35"></asp:TextBox>
							                                                      </td>
							                                                    <td width ="50%" align="center">Percentage on Free/Reduced Lunch&nbsp;&nbsp;<asp:TextBox ID="txtDemoTchPercFreeRedcLunch" runat="server" CssClass="border" MaxLength="8" Width="35"></asp:TextBox></td>						
						                                                    </tr>
                                                    						
					                                 </table>
					                                <br/>

                                                       <table width="550" border="1" cellpadding="2" cellspacing="0" bordercolor="#000000">
						                                                    <tr bgcolor="#C8E080">	
						                                                    <th width="550" height="26" colspan="4" align="center" valign="center">Behavior Incidence Data</th>
                                  		                                                    </tr>
                                                    		
						                                                    <tr> 
							                                                    <td width ="25%" height="32" align="center"># of Office Managed Discipline Referrals <asp:TextBox ID="txtbdDisciplineReferrals" runat="server" CssClass="border" MaxLength="8" Width="35"></asp:TextBox>
							                                                      </td>
							                                                    <td width ="25%" align="center"># Days In-School Suspensions&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtbdInSchoolSuspensions" runat="server" CssClass="border" MaxLength="8" Width="35"></asp:TextBox></td>	
							                                                    <td width ="25%" height="32" align="center"># Days Out-of-School Suspensions&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtbdOutSchoolSuspensions" runat="server" CssClass="border" MaxLength="8" Width="35"></asp:TextBox>
							                                                      </td>
							                                                    <td width ="25%" align="center">Average Daily Attendance (%)&nbsp; <asp:TextBox ID="txtbdDailyAttendance" runat="server" CssClass="border" MaxLength="8" Width="35"></asp:TextBox></td>						
						                                                    </tr>					
						                                                    </tr>
                                                    						
					                                 </table>
					                                <br/>
					
					                                               <table width="550" height="187" border="1" cellpadding="2" cellspacing="0" bordercolor="#000000">
					                                                        <tr bgcolor="#C8E080">	
						                                                        <th height="24" colspan="3" align="center" valign="center">Academic Data (School Accountability/ FCAT) </th>
                                  	                                                        </tr>

					                                                     <tr valign="middle"> 
						<td class="style3" >Percent of students making learning gains in reading</td>
						<td align="center" >
						<asp:TextBox ID="txtbdLearningGains" runat="server" CssClass="border" MaxLength="4" Width="70"></asp:TextBox>
						</td>					
					</tr>
<tr valign="middle"> 
						<td class="style3" >Percent of lowest 25% making learning gains in reading</td>
						<td align="center" >
						<asp:TextBox ID="txtbdLowestLearningGains" runat="server" CssClass="border" MaxLength="4" Width="70"></asp:TextBox>
						</td>					
					</tr>
					<tr valign="middle"> 
						<td class="style3" >Percent of students reaching level 3 or higher in reading</td>
						<td align="center" >
						<asp:TextBox ID="txtbdLevel3Reading" runat="server" CssClass="border" MaxLength="4" Width="70"></asp:TextBox>
						</td>					
					</tr>
					<tr valign="middle"> 
						<td class="style3" >School grade</td>
						<td align="center" >
						<asp:TextBox ID="txtbdSchoolGrade" runat="server" CssClass="border" MaxLength="4" Width="70"></asp:TextBox>
						</td>					
					</tr>
					<tr valign="middle"> 
						<td class="style3" >Total school points</td>
						<td align="center" >
						<asp:TextBox ID="txtbdTotSchoolPoints" runat="server" CssClass="border" MaxLength="4" Width="70"></asp:TextBox>
						</td>					
					</tr>
					                                                       
					                                                        </table>
					

				 </td>
				 
				 </tr>
				</table>
				<div align="center">
				  <p><br>
				      <span class="contentText"><a HREF="javascript:window.print()">CLICK HERE TO PRINT THE FORM <strong>BEFORE</strong> SUBMITTING!!</a></span>&nbsp;&nbsp;&nbsp;</p>
				  <p><asp:Button ID="btnSubmit" BackColor="Beige" BorderColor="#C8E07F" OnClientClick="return checkform('Form1');" BorderWidth="3" runat="server" Text="Submit" />
				      
                            </p>
				</div>
												</td>
                          </tr>
                          <tr>
                            <td align="left" valign="top">&nbsp;
							
							  </td>
                          </tr>
                        </table>
                        </td>
                      </tr>
                    </table>
                  </div></td>
                <td width="10">&nbsp;</td>
              </tr>
              <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
              </tr>
          </table>
        </td>
    </tr>
</asp:Content>