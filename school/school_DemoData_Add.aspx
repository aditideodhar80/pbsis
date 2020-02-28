<%@ Page Language="VB"  MasterPageFile="~/pbsmaster/Main.master"  AutoEventWireup="false" CodeFile="school_DemoData_Add.aspx.vb" Inherits="school_school_DemoData_Add" %>

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
                            		                            <td width="49%" align="left" valign="top" class="style3">
                                                                    <font face="Arial, Helvetica, sans-serif">SCHOOL PROFILE INFORMATION FORM (DEMOGRAPHIC INFORMATION)</font></td>
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
						                                                        <th width="550" colspan="4" align="center" valign="center">Initiatives in Place<br>
						                                                          (check all that apply)</th>

                                  	                                                        </tr>

					                                                        <tr>
						                                                        <td width="33%" height="39" colspan="2" align="center">Title One<br>
						                                                        <asp:CheckBox ID="chkDemoTchTitleOne" runat="server" Text="" /> 
						                                                         </td>
						                                                        <td align="center" width="33%">Reading First</br><asp:CheckBox ID="chkDemoTchReadingFirst" runat="server" Text="" /></td>
						                                                        <td align="center" width="33%">Problem-Solving Model<br><asp:CheckBox ID="chkDemoTchProblemSolvModel" runat="server" Text="" /></td>						
					                                                        </tr>

					                                                        <tr>
						                                                        <td width="25%" align="left" valign="middle"><br>
						                                                          &nbsp;Other (specify):<br>
						                                                          <br></td>
						                                                        <td width="75%" colspan="3" align="left"><br>&nbsp;
						                                                        <asp:TextBox ID="DemoTchOtherInitiatives" runat="server" CssClass="border" MaxLength="250" Width="350"></asp:TextBox>
						                                                      						                            &nbsp;
						                                                        
						                                                      						                                                          <br></td>
					                                                        </tr>

					                                                        </table>
					
					                                                        <table width="550" border="1" cellpadding="2" cellspacing="0" bordercolor="#000000">
					                                                        <tr bgcolor="#C8E080">	
						                                                        <th height="25" colspan="3" align="center" valign="middle">Targeted Group Behaviour Intervention(s)<br />
						                                                         <asp:RadioButton runat="server" GroupName="DemoTchTargBehIntv"  ID="DemoTchTargBehIntvyes" Text="Yes" onmousedown="Javascript:activateIntv('Form1', 1);" />
						                                                        <asp:RadioButton runat="server" GroupName="DemoTchTargBehIntv" ID="DemoTchTargBehIntvno" Text="No"  onmousedown="Javascript:activateIntv('Form1', 0);"/>
						                                                   </th>
						                                                        <th width="29%" height="25" align="center" valign="middle">Individual Level PBS<br>&nbsp;
						                                                         <asp:RadioButton runat="server" GroupName="DemoTchIndLvlPbs" ID="DemoTchIndLvlPbsyes" Text="Yes"  onmousedown="Javascript:activatePbs('Form1', 1);" />
						                                                        <asp:RadioButton runat="server" GroupName="DemoTchIndLvlPbs" ID="DemoTchIndLvlPbsno" Text="No"  onmousedown="Javascript:activatePbs('Form1', 0);"/>
						                                                       </th>
                                                                            </tr>

					                                                        <tr> 
						                                                        <td colspan="3">
                                                        							
							                                                        <div>
								                                                        <div style="float:left">
								                                                            <asp:CheckBox ID="chkDemoTchIntvBEP" runat="server" Text="BEP" /><br>
									                                                        <asp:CheckBox ID="chkDemoTchIntvICPS" Enabled="true" runat="server" Text="I Can Problem Solve" /><br>
									                                                        <asp:CheckBox ID="chkDemoTchIntvSklStr" Enabled="true" runat="server" Text="Skill Streaming" /><br>
									                                                        <asp:CheckBox ID="chkDemoTchIntvPrep" Enabled="true" runat="server" Text="Prepare" />
								                                                        </div>
                                                        							
								                                                        <div style="float:right">
								                                                           <asp:CheckBox ID="chkDemoTchIntvSTR" Enabled="true" runat="server" Text="Steps to Respect" /><br>
									                                                        <asp:CheckBox ID="chkDemoTchIntvSecStp" Enabled="true" runat="server" Text="Second Step" /><br>
									                                                        <asp:CheckBox ID="chkDemoTchIntvSC" Enabled="true" runat="server" Text="School Connect" /><br>
									                                                        <asp:CheckBox ID="chkDemoTchIntvOth" Enabled="true" runat="server" Text="Other" />
									                                                        <asp:TextBox ID="txtDemoTchIntvOthDesc" runat="server" CssClass="border" MaxLength="250" width="90" Enabled="false"></asp:TextBox>
                                                        									
                                                        									
								                                                        </div>						
							                                                        </div>						
                                                        						
						                                                        </td>

						                                                        <td width="35%">
                                                        						
							                                                        <div style="float:left">
                                                        							
							                                                           <asp:CheckBox ID="chkDemoTchPbsERASE" Enabled="true" runat="server" Text="ERASE" /><br>
									                                                        <asp:CheckBox ID="chkDemoTchPbsPTR" Enabled="true" runat="server" Text="PTR" /><br>
									                                                        <asp:CheckBox ID="chkDemoTchPbsOth" Enabled="true" runat="server" Text="Other" /><br>
										                                                        <asp:TextBox ID="txtDemoTchPbsOthDesc" runat="server" CssClass="border" MaxLength="250" width="150" Enabled="false"></asp:TextBox>
                                                        							
                                                        									
						  	                                                        </div>
						                                                          </td>						
					                                                        </tr>

                                                        					
					                                                        </table>
					<br/>
					
					                                                        <table width="550" height="104" border="1" cellpadding="2" cellspacing="0" bordercolor="#000000">
					                                                        <tr bgcolor="#C8E080">	
						                                                        <th width="550" height="25" colspan="2" align="center" valign="center">Data Systems</th>
                                  	                                                        </tr>

					                                                        <tr> 
						                                                        <td width="50%" align="center">Academic Data System(s)<br>(i.e., Dibels)</td>
						                                                        <td width="50%" align="center">Behavior Data System(s)<br>
						                                                          (i.e., SWIS, Genesis, Terms)</td>						
					                                                        </tr>

					                                                        <tr>
						                                                        <td height="36" align="center">
						                                                            <asp:TextBox ID="txtDemoTchAcademicSystems" runat="server" CssClass="border" MaxLength="100" width="200"></asp:TextBox>
						                                                        </td>
						                                                        <td align="center">
						                                                            <asp:TextBox ID="txtDemoTchBehaviorSystems" runat="server" CssClass="border" MaxLength="100" width="200" ></asp:TextBox>
						                                                        </td>
					                                                        </tr>
					                                                        </table>
					
					
					<br/>
					                                                        <table width="550" height="187" border="1" cellpadding="2" cellspacing="0" bordercolor="#000000">
					                                                        <tr bgcolor="#C8E080">	
						                                                        <th height="24" colspan="3" align="center" valign="center">Teacher Information for Current Year </th>
                                  	                                                        </tr>

					                                                        <tr valign="middle"> 
						                                                        <td width="380">Total Instructional Staff</td>
						                                                        <td WIDTH="33" align="center"><div align="right">#&nbsp;</div></td>
						                                                        <td WIDTH="129" align="center"><div align="left">
						                                                        <asp:TextBox ID="txtDemoTchTotalInstStaff" runat="server" CssClass="border" MaxLength="8" Width="35"></asp:TextBox>
                                                        						    
						                                                          </div></td>					
					                                                        </tr>

					                                                        <tr valign="middle"> 
						                                                        <td>% of Staff that is Instructional</td>
						                                                        <td align="center">&nbsp;</td>
						                                                        <td align="center"><div align="left">
						                                                        <asp:TextBox ID="txtDemoTchPercInstStaff" runat="server" CssClass="border" MaxLength="8" Width="35"></asp:TextBox>
                                                        						    
						                                                            &nbsp;%</div></td>					
					                                                        </tr>

					                                                        <tr valign="middle"> 
						                                                        <td >% of Teachers with advanced degree<br>
						                                                          (Masters, Doctorate, or Specialist)</td>
						                                                        <td align="center">&nbsp;</td>
						                                                        <td align="center"><div align="left">
						                                                        <asp:TextBox ID="txtDemoTchPercAdvDegree" runat="server" CssClass="border" MaxLength="8" Width="35"></asp:TextBox>
						                                                           
						                                                            &nbsp;%</div></td>					
					                                                        </tr>

					                                                        <tr valign="middle"> 
						                                                        <td>% of Out-of-field Teachers<br>
						                                                          (Reported as perecentage of core academic courses taught by teachers who are out of field)</td>
						                                                        <td align="center">&nbsp;</td>
						                                                        <td align="center"><div align="left">
						                                                        <asp:TextBox ID="txtDemoTchPercOOFTeacher" runat="server" CssClass="border" MaxLength="8" Width="35"></asp:TextBox>
                                                        						      
						                                                            &nbsp;%</div></td>					
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