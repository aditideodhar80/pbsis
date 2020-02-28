<%@ Page Language="VB" MasterPageFile="~/pbsmaster/Detail.master" AutoEventWireup="false" CodeFile="school_BOQ_Add.aspx.vb" Inherits="school_school_BOQ_Add" %>

<asp:Content ID ="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <tr>
        <td>
    <tr>
        <td>
    <style type="text/css">
<!--
.cursor {  cursor: pointer}
        .style2
        {   
        	color: #7BA400;
            font-weight: bold;
            height: 19px;
            width: 48%;
        }
        .style3
        {
            height: 19px;
            width: 32%;
        }
-->
</style>
<style type="text/css">

body {
	margin-left: 0px;
	margin-top: 0px;
	margin-right: 0px;
	margin-bottom: 0px;
}

</style>
<style type="text/css">

body,td,th {
	font-family: Arial, Helvetica, sans-serif;
	font-size: small;
}
    .style3
    {
        width: 124px;
    }
    .style4
    {
        height: 86px;
    }

    .style5
    {
        width: 157px;
    }
    .style6
    {
        width: 400px;
    }

</style>
<SCRIPT  type="text/javascript" LANGUAGE="JavaScript">
<!-- Begin
function disableForm(theform) {
if (document.all || document.getElementById) {
for (i = 0; i < theform.length; i++) {
var tempobj = theform.elements[i];
if (tempobj.type.toLowerCase() == "submit" || tempobj.type.toLowerCase() == "reset")
tempobj.disabled = true;
}
setTimeout('alert("Your form has been submitted.")', 2000);
return true;
}
else {
alert("The form has been submitted.");
return false;
   }
}
//  End -->
</script>
 
<link href="../display/pbsStyles.css" rel="stylesheet" type="text/css">
    <tr>
                <td width="15">&nbsp;</td>
                <td align="left" valign="top">
                </td>
                <td width="10">&nbsp;</td>
                <td align="left" valign="top">
                    <table  border="0" cellpadding="0" cellspacing="0" >
                        <tr>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td> 
                                <table width="100%" border="0" cellpadding="2" cellspacing="0" bordercolor="#000000">
                                    <tr>
                                        <td width="49%" align="left" valign="top"><span class="style2">&nbsp;SCHOOL-WIDE
                                  BENCHMARKS OF QUALITY: SCORING FORM</span>
                                        </td>
                                    </tr>
						  
					              
                                  <tr>
                                    <td align="left" valign="top">
                                        <table width="100%">
                                            <tr>
                                                <td align="left" valign="top"><span class="style2"> School Name: </span><asp:Label CssClass="style2" Font-Size="Small" Font-Bold="true"  id="lblSchoolName" runat="server"></asp:Label></td>
                                                <td align="left" valign="top"><span class="style2"> District Name: </span><asp:Label CssClass="style2" Font-Size="Small" Font-Bold="true"  id="lblDistrict" runat="server"></asp:Label></td>
                                            </tr>
                                        </table>
                                        </td>
                                   </tr>
                                  
                                  <tr>
                                    <td align="left" valign="top"><span class="style2">&nbsp;School Year:</span> <asp:Label CssClass="style2" Font-Size="Small" Font-Bold="true"  ID="lblSchoolYr" runat="server"></asp:Label></td>
                                  </tr>
                                  <tr>
                                    <td>&nbsp;</td>
                                  </tr>
                                  <tr>
                                    <td align="left" valign="top">&nbsp;Coach Name:&nbsp;
                                     <asp:DropDownList ID="ddlcoach" runat="server">
                                     </asp:DropDownList>
							         </td>
                                  </tr>
                                  <tr><td>
                                      &nbsp;</td></tr>
                         
                                 <tr>
                                    <td>
                                        <table width="790" border="1" cellpadding="2" cellspacing="0" bordercolor="#000000">
                                               <tr>
                                                    <td width="154" height="105" align="left" rowspan="2"><div align="center"><strong>METHOD OF SCORING</strong></div></td>
                                                              <td bgcolor="#C8E07F">
                                                  (Method on Instructions) Coach uses Scoring Guide to select score, team members use Rating Form, coach addresses discrepancies with the team.
                                                    </td>
                                                    <td width="40" bgcolor="#C8E07F" >
                                                        <asp:RadioButton CssClass="cursor" ID="rdboqscmethod1" runat="server" GroupName ="grpBoqScoreMethod" />
                                                    </td>
                                              </tr>
                                              <tr>
                                                    <td>
                                                      (Any variation of the Method on the Instructions) I.e. team and coach use the Scoring Guide, team and coach meet to reach consensus on each item.
                                                    </td>
                                                  <td width="40" >
                                                    <asp:RadioButton ID="rdboqscmethod2" CssClass="cursor" runat="server" GroupName ="grpBoqScoreMethod" />
                                                  </td>
                                              </tr>
                            
                                             <br />
                                        </table>
                                    </td>
                                  </tr>
                                  
                                  
                                  <tr>
                                    <td>&nbsp;</td>
                                  </tr>
           <tr>
                            <td>
                                <%--<table width="790" border="1" cellpadding="2" cellspacing="0" bordercolor="#000000">
                                    <tr>
                                        <td style="width:20%"><strong>STEP 1</strong></td>
                                        <td style="width:80%">Coach uses the Scoring Guide to determine appropriate point value. Circle ONLY ONE response.</td>
                                        
                                    </tr>
                                     <tr>
                                        <td style="width:20%"><strong>STEP 2</strong></td>
                                        <td style="width:80%">Indicate your team&#8217;s most frequent response.  Write the response in column 2.
                             (in place ++, needs improvement +, or not in place - ). If there is a tie, report the higher score.
            </td>
                                      
                                        
                                    </tr>
                                     <tr>
                                 <td style="width:20%"><strong>STEP 3</strong></td>
                                        <td style="width:80%">Place a check next to any item where there is a discrepancy between your rating and the team&#8217;s rating. 
                               Document the discrepancies on page 3
            .</td>
                                      
                                    </tr>
                                </table
                                --%>
                                <table width="790" border="1" cellpadding="2" cellspacing="0" bordercolor="#000000">
                                <tr valign="top">
                                  <td height="105" align="left" class="style5"><div align="center"><strong>CRITICAL
                                      ELEMENTS</strong></div></td>
                                  <td align="left" class="style6"><div align="center"><strong>BENCHMARKS
                                      OF QUALITY</strong></div></td>
                                  <td width="240"><strong>Directions:</strong><br>
                                    Use Scoring Guide to Determine appropriate point value.
                                   
                                      <p>Click on Value:</p></td>
                                </tr>
                                
                            </table>
                            
                              <br />
                            </td></tr>
                        
                      <%--<table width="790" border="1" cellpadding="2" cellspacing="0" bordercolor="#000000">
                   <tr>
                     <td width="155"  align="left" valign="top" bgcolor="#CCCCCC"><strong>Critical Elements
                                    TEAM </strong></td>
                        <td align="center" width="285" colspan="5"><strong>STEP 1</strong></td>
                       
                    </tr></table>--%><br />
                    <table width="790" border="1" cellpadding="2" cellspacing="0" bordercolor="#000000">
                    
                    
                  
                                <tr>
                                  <td width="120" rowspan="5" align="left" valign="top" bgcolor="#CCCCCC"><strong>PBS
                                    TEAM </strong></td>
                          
                                </tr>
                                <tr>
                                  <td width="300">1. Team has administrative
                                    support. </td>
                                 
                                  <td width="40"><asp:RadioButton runat="server" CssClass="cursor" Text="3" ID="BoqQuestion1_3" GroupName ="BoqQuestion1" />
                                    </td>
                                  <td width="40"><asp:RadioButton runat="server" CssClass="cursor" Text="2" ID="BoqQuestion1_2" GroupName="BoqQuestion1" />
                                    </td>
                                  <td width="40"><asp:RadioButton runat="server" CssClass="cursor" Text="1" ID="BoqQuestion1_1" GroupName="BoqQuestion1" />
                                    </td>
                                  <td width="40"><asp:RadioButton runat="server" CssClass="cursor" Text="0" ID="BoqQuestion1_0" GroupName="BoqQuestion1" />
                                    </td>
                                    
                                    
                                </tr>
                                <tr>
                                  <td width="300" bgcolor="#C8E07F">2. Team has
                                    regular meetings (at least monthly). </td>
                                  
                                  <td width="40" bgcolor="#C8E07F">&nbsp;</td>
                                  <td width="40" bgcolor="#C8E07F"><asp:RadioButton runat="server" CssClass="cursor" Text="2" ID="BoqQuestion2_2" GroupName ="BoqQuestion2" />
                                    </td>
                                  <td width="40" bgcolor="#C8E07F"><asp:RadioButton runat="server" CssClass="cursor" Text="1" ID="BoqQuestion2_1" GroupName ="BoqQuestion2" />
                                    </td>
                                  <td width="40" bgcolor="#C8E07F"><asp:RadioButton runat="server" CssClass="cursor" Text="0" ID="BoqQuestion2_0" GroupName ="BoqQuestion2" />
                                    </td>
                                     
                                    
                                </tr>
                                <tr>
                                  <td width="300">3. Team has established a clear
                                    mission/purpose. </td>
                                  
                                  <td width="40">&nbsp;</td>
                                  <td width="40">&nbsp;</td>
                                  <td width="40"><asp:RadioButton runat="server" CssClass="cursor" Text="1" ID="BoqQuestion3_1" GroupName ="BoqQuestion3" />
                                    </td>
                                  <td width="40"><asp:RadioButton runat="server" CssClass="cursor" Text="0" ID="BoqQuestion3_0" GroupName ="BoqQuestion3" />
                                     </td>
                                      
                                    
                                </tr>
                                
                            </table><br />
                    <table width="790" border="1" cellpadding="2" cellspacing="0" bordercolor="#000000">
                      <tr>
                        <td width="120" rowspan="4" align="left" valign="top"><strong>FACULTY <br>
                        COMMITMENT </strong></td>
                        <td width="300" align="left" valign="top" bgcolor="#C8E07F">
                            4.	Faculty are aware of behavior problems across campus through regular data sharing</span></td>
                  
                        <td width="40" align="left" valign="top" bgcolor="#C8E07F">&nbsp;</td>
                        <td width="40" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton runat="server" CssClass="cursor" Text="2" ID="BoqQuestion4_2" GroupName ="BoqQuestion4" />
                          </td>
                        <td width="40" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton runat="server" CssClass="cursor" Text="1" ID="BoqQuestion4_1" GroupName ="BoqQuestion4" />
                          </td>
                        <td width="40" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton runat="server" CssClass="cursor" Text="0" ID="BoqQuestion4_0" GroupName ="BoqQuestion4" />
                          </td>
                           
                                    
                      </tr>
                      <tr>
                        <td width="300" align="left" valign="top">5. Faculty involved in
                          establishing and reviewing goals.</td>
                         <td width="40" align="left" valign="top" >&nbsp;</td>
                      
                        <td width="40" align="left" valign="top"><asp:RadioButton runat="server" CssClass="cursor" Text="2" ID="BoqQuestion5_2" GroupName ="BoqQuestion5" />
                          </td>
                        <td width="40" align="left" valign="top"><asp:RadioButton runat="server" CssClass="cursor" Text="1" ID="BoqQuestion5_1" GroupName ="BoqQuestion5" />
                          </td>
                        <td width="40" align="left" valign="top"><asp:RadioButton runat="server" CssClass="cursor" Text="0" ID="BoqQuestion5_0" GroupName ="BoqQuestion5" />
                           </td>
                            
                                    
                      </tr>
                      <tr>
                        <td width="300" align="left" valign="top" bgcolor="#C8E07F">6. Faculty feedback is obtained
                          throughout year. </td>
                     
                        <td width="40" align="left" valign="top" bgcolor="#C8E07F">&nbsp;</td>
                        <td width="40" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton runat="server" CssClass="cursor" Text="2" ID="BoqQuestion6_2" GroupName ="BoqQuestion6" />
                          </td>
                        <td width="40" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton runat="server" CssClass="cursor" Text="1" ID="BoqQuestion6_1" GroupName ="BoqQuestion6" />
                          </td>
                        <td width="40" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton runat="server" CssClass="cursor" Text="0" ID="BoqQuestion6_0" GroupName ="BoqQuestion6" />
                          </td>
                           
                                    
                      </tr>
                  
                    </table>
                     <br>
                    <table width="790" border="1" cellpadding="2" cellspacing="0" bordercolor="#000000">
                      <tr>
                        <td width="120" rowspan="8" align="left" valign="top" bgcolor="#CCCCCC"><strong>EFFECTIVE
                          PROCEDURES FOR DEALING WITH DISCIPLINE </strong></td>
                        <td width="300" align="left" valign="top">7. Discipline process described in narrative format or depicted in graphic format. </td>
                     
                        <td width="40" align="left" valign="top">&nbsp;</td>
                        <td width="40" align="left" valign="top"><asp:RadioButton runat="server" CssClass="cursor" Text="2" ID="BoqQuestion7_2" GroupName ="BoqQuestion7" />
                          </td>
                        <td width="40" align="left" valign="top"><asp:RadioButton runat="server" CssClass="cursor" Text="1" ID="BoqQuestion7_1" GroupName ="BoqQuestion7" />
                          </td>
                        <td width="40" align="left" valign="top"><asp:RadioButton runat="server" CssClass="cursor" Text="0" ID="BoqQuestion7_0" GroupName ="BoqQuestion7" />
                          </td>
                          
                                    
                      </tr>
                      <tr>
                        <td width="300" align="left" valign="top" bgcolor="#C8E07F">8.	Discipline process includes documentation procedures. </td>
                   
                        <td width="40" align="left" valign="top" bgcolor="#C8E07F">&nbsp;</td>
                        <td width="40" align="left" valign="top" bgcolor="#C8E07F">&nbsp;</td>
                        <td width="40" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton runat="server" CssClass="cursor" Text="1" ID="BoqQuestion8_1" GroupName ="BoqQuestion8" />
                          </td>
                        <td width="40" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton runat="server" CssClass="cursor" Text="0" ID="BoqQuestion8_0" GroupName ="BoqQuestion8" />
                          </td>
                          
                                    
                      </tr>
                      <tr>
                        <td width="300" align="left" valign="top">9.	Discipline referral form includes information useful in decision making </td>
                     
                        <td width="40" align="left" valign="top">&nbsp;</td>
                        <td width="40" align="left" valign="top"><asp:RadioButton runat="server" CssClass="cursor" Text="2" ID="BoqQuestion9_2" GroupName ="BoqQuestion9" />
                           </td>
                        <td width="40" align="left" valign="top"><asp:RadioButton runat="server" CssClass="cursor" Text="1" ID="BoqQuestion9_1" GroupName ="BoqQuestion9" />
                          </td>
                        <td width="40" align="left" valign="top"><asp:RadioButton runat="server" CssClass="cursor" Text="0" ID="BoqQuestion9_0" GroupName ="BoqQuestion9" />
                          </td>
                          
                                    
                      </tr>
                      <tr>
                        <td width="300" align="left" valign="top" bgcolor="#C8E07F">10.	Problem behaviors are defined </td>
                        
                        <td width="40" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton runat="server" CssClass="cursor" Text="3" ID="BoqQuestion10_3" GroupName ="BoqQuestion10" />
                          </td>
                        <td width="40" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton runat="server" CssClass="cursor" Text="2" ID="BoqQuestion10_2" GroupName ="BoqQuestion10" />
                           </td>
                        <td width="40" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton runat="server" CssClass="cursor" Text="1" ID="BoqQuestion10_1" GroupName ="BoqQuestion10" />
                          </td>
                        <td width="40" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton runat="server" CssClass="cursor" Text="0" ID="BoqQuestion10_0" GroupName ="BoqQuestion10" />
                          </td>
                          
                                    
                      </tr>
                      <tr>
                        <td width="300" align="left" valign="top">11.	Major/minor behaviors are clearly differentiated</td>
                       
                        <td width="40" align="left" valign="top">&nbsp;</td>
                        <td width="40" align="left" valign="top"><asp:RadioButton runat="server" CssClass="cursor" Text="2" ID="BoqQuestion11_2" GroupName ="BoqQuestion11" />
                          </td>
                        <td width="40" align="left" valign="top"><asp:RadioButton runat="server" CssClass="cursor" Text="1" ID="BoqQuestion11_1" GroupName ="BoqQuestion11" />
                          </td>
                        <td width="40" align="left" valign="top"><asp:RadioButton runat="server" CssClass="cursor" Text="0" ID="BoqQuestion11_0" GroupName ="BoqQuestion11" />
                          </td>
                          
                                    
                      </tr>
                      <tr>
                        <td width="300" align="left" valign="top" bgcolor="#C8E07F">12.	Suggested array of appropriate responses to major (office-managed) problem behaviors</td>
                       
                        <td width="40" align="left" valign="top" bgcolor="#C8E07F">&nbsp;</td>
                        <td width="40" align="left" valign="top" bgcolor="#C8E07F">&nbsp;</td>
                        <td width="40" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton runat="server" CssClass="cursor" Text="1" ID="BoqQuestion12_1" GroupName ="BoqQuestion12" />
                          </td>
                        <td width="40" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton runat="server" CssClass="cursor" Text="0" ID="BoqQuestion12_0" GroupName ="BoqQuestion12" />
                          </td>
                          
                                    
                      </tr>

                   
                    </table>
                    <br>
                    <table width="790" border="1" cellpadding="2" cellspacing="0" bordercolor="#000000">
                      <tr>
                        <td width="120" rowspan="6" align="left" valign="top"><strong>DATA
                          ENTRY AND ANALYSIS PLAN ESTABLISHED</strong></td>
                        <td width="300" align="left" valign="top" bgcolor="#C8E07F">13.	Data system is used to collect and analyze ODR data</td>
                   
                        <td width="40" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton runat="server" CssClass="cursor" Text="3" ID="BoqQuestion13_3" GroupName ="BoqQuestion13" />
                          </td>
                        <td width="40" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton runat="server" CssClass="cursor" Text="2" ID="BoqQuestion13_2" GroupName ="BoqQuestion13" />
                          </td>
                        <td width="40" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton runat="server" CssClass="cursor" Text="1" ID="BoqQuestion13_1" GroupName ="BoqQuestion13" />
                          </td>
                        <td width="40" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton runat="server" CssClass="cursor" Text="0" ID="BoqQuestion13_0" GroupName ="BoqQuestion13" />
                          </td>
                            
                                    
                      </tr>
                      <tr>
                        <td width="300" align="left" valign="top">14.	Additional data are collected (attendance, grades, faculty attendance, surveys) and used by SWPBS team </td>
                        
                        <td width="40" align="left" valign="top">&nbsp;</td>
                        <td width="40" align="left" valign="top">&nbsp;</td>
                        <td width="40" align="left" valign="top"><asp:RadioButton runat="server" CssClass="cursor" Text="1" ID="BoqQuestion14_1" GroupName ="BoqQuestion14" />
                          </td>
                        <td width="40" align="left" valign="top"><asp:RadioButton runat="server" CssClass="cursor" Text="0" ID="BoqQuestion14_0" GroupName ="BoqQuestion14" />
                          </td>
                            
                                    
                      </tr>
                      <tr>
                        <td width="300" align="left" valign="top" bgcolor="#C8E07F"><span style="width:255.65pt;height:18.25pt">15.	Data analyzed by team at least monthly</span></td>
                        
                        <td width="40" align="left" valign="top" bgcolor="#C8E07F">&nbsp;</td>
                        <td width="40" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton runat="server" CssClass="cursor" Text="2" ID="BoqQuestion15_2" GroupName ="BoqQuestion15" />
                           </td>
                        <td width="40" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton runat="server" CssClass="cursor" Text="1" ID="BoqQuestion15_1" GroupName ="BoqQuestion15" />
                          </td>
                        <td width="40" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton runat="server" CssClass="cursor" Text="0" ID="BoqQuestion15_0" GroupName ="BoqQuestion15" />
                          </td>
                          
                            
                                    
                     
                      </tr>
                      <tr>
                        <td width="300" align="left" valign="top">16.	Data shared with team and faculty monthly (minimum)</td>
                     
                        <td width="40" align="left" valign="top">&nbsp;</td>
                        <td width="40" align="left" valign="top"><asp:RadioButton runat="server" CssClass="cursor" Text="2" ID="BoqQuestion16_2" GroupName ="BoqQuestion16" />
                           </td>
                        <td width="40" align="left" valign="top"><asp:RadioButton runat="server" CssClass="cursor" Text="1" ID="BoqQuestion16_1" GroupName ="BoqQuestion16" />
                          </td>
                        <td width="40" align="left" valign="top"><asp:RadioButton runat="server" CssClass="cursor" Text="0" ID="BoqQuestion16_0" GroupName ="BoqQuestion16" />
                          </td>
                            
                                    
                      </tr>
                     
                  
                    </table>
                    <br>
                    <table width="790" border="1" cellpadding="2" cellspacing="0" bordercolor="#000000">
                      <tr>
                        <td width="120" rowspan="6" align="left" valign="top" bgcolor="#CCCCCC"><strong>EXPECTATIONS
                          AND RULES DEVELOPED</strong></td>
                        <td width="300" align="left" valign="top">17.	3-5 positively stated school-wide expectations are posted around school </td>
                       
                        <td width="40" align="left" valign="top"><asp:RadioButton runat="server" CssClass="cursor" Text="3" ID="BoqQuestion17_3" GroupName ="BoqQuestion17" />
                          </td>
                        <td width="40" align="left" valign="top"><asp:RadioButton runat="server" CssClass="cursor" Text="2" ID="BoqQuestion17_2" GroupName ="BoqQuestion17" />
                          </td>
                        <td width="40" align="left" valign="top"><asp:RadioButton runat="server" CssClass="cursor" Text="1" ID="BoqQuestion17_1" GroupName ="BoqQuestion17" />
                          </td>
                        <td width="40" align="left" valign="top"><asp:RadioButton runat="server" CssClass="cursor" Text="0" ID="BoqQuestion17_0" GroupName ="BoqQuestion17" />
                          </td>
                            
                                    
                      </tr>
                      <tr>
                        <td width="300" align="left" valign="top" bgcolor="#C8E07F">18.	Expectations apply to both students and staff </td>
                      
                        <td width="40" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton runat="server" CssClass="cursor" Text="3" ID="BoqQuestion18_3" GroupName ="BoqQuestion18" />
                          </td>
                        <td width="40" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton runat="server" CssClass="cursor" Text="2" ID="BoqQuestion18_2" GroupName ="BoqQuestion18" />
                          </td>
                        <td width="40" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton runat="server" CssClass="cursor" Text="1" ID="BoqQuestion18_1" GroupName ="BoqQuestion18" />
                          </td>
                        <td width="40" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton runat="server" CssClass="cursor" Text="0" ID="BoqQuestion18_0" GroupName ="BoqQuestion18" />
                           </td>
                             
                                    
                      </tr>
                      <tr>
                        <td width="300" align="left" valign="top">19.	Rules are developed and posted for specific settings (settings where data suggest rules are needed)</td>
                     
                        <td width="40" align="left" valign="top">&nbsp;</td>
                        <td width="40" align="left" valign="top"><asp:RadioButton runat="server" CssClass="cursor" Text="2" ID="BoqQuestion19_2" GroupName ="BoqQuestion19" />
                          </td>
                        <td width="40" align="left" valign="top"><asp:RadioButton runat="server" CssClass="cursor" Text="1" ID="BoqQuestion19_1" GroupName ="BoqQuestion19" />
                          </td>
                        <td width="40" align="left" valign="top"><asp:RadioButton runat="server" CssClass="cursor" Text="0" ID="BoqQuestion19_0" GroupName ="BoqQuestion19" />
                          </td>
                            
                                    
                      </tr>
                      <tr>
                        <td width="300" align="left" valign="top" bgcolor="#C8E07F">20.	Rules are linked to expectations</td>
                      
                        <td width="40" align="left" valign="top" bgcolor="#C8E07F">&nbsp;</td>
                        <td width="40" align="left" valign="top" bgcolor="#C8E07F">&nbsp;</td>
                        <td width="40" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton runat="server" CssClass="cursor" Text="1" ID="BoqQuestion20_1" GroupName ="BoqQuestion20" />
                          </td>
                        <td width="40" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton runat="server" CssClass="cursor" Text="0" ID="BoqQuestion20_0" GroupName ="BoqQuestion20" />
                          </td>
                            
                                    
                      </tr>
                      <tr>
                        <td width="300" align="left" valign="top">21.	Staff are involved in development of expectations and rules</td>
                      
                     <td width="40" align="left" valign="top">&nbsp;</td>
                        <td width="40" align="left" valign="top"><asp:RadioButton runat="server" CssClass="cursor" Text="2" ID="BoqQuestion21_2" GroupName ="BoqQuestion21" />
                           </td>
                        <td width="40" align="left" valign="top"><asp:RadioButton runat="server" CssClass="cursor" Text="1" ID="BoqQuestion21_1" GroupName ="BoqQuestion21" />
                          </td>
                        <td width="40" align="left" valign="top"><asp:RadioButton runat="server" CssClass="cursor" Text="0" ID="BoqQuestion21_0" GroupName ="BoqQuestion21" />
                          </td>
                             
                                    
                      </tr>
                 
                    </table>
                    <br>
                    <table width="790" border="1" cellpadding="2" cellspacing="0" bordercolor="#000000">
                      <tr>
                        <td width="120" rowspan="9" align="left" valign="top"><strong>REWARD/
                          RECOGNITION PROGRAM ESTABLISHED</strong></td>
                        <td width="300" align="left" valign="top" bgcolor="#C8E07F">22.	A system of rewards has elements that are implemented consistently across campus</td>
                       
                        <td width="40" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton runat="server" CssClass="cursor" Text="3" ID="BoqQuestion22_3" GroupName ="BoqQuestion22" />
                          </td>
                        <td width="40" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton runat="server" CssClass="cursor" Text="2" ID="BoqQuestion22_2" GroupName ="BoqQuestion22" />
                          </td>
                        <td width="40" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton runat="server" CssClass="cursor" Text="1" ID="BoqQuestion22_1" GroupName ="BoqQuestion22" />
                          </td>
                        <td width="40" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton runat="server" CssClass="cursor" Text="0" ID="BoqQuestion22_0" GroupName ="BoqQuestion22" />
                          </td>
                           
                                    
                      </tr>
                      <tr>
                        <td width="300" align="left" valign="top">23.	A variety of methods are used to reward students </td>
                       
                        <td width="40" align="left" valign="top">&nbsp;</td>
                        <td width="40" align="left" valign="top"><asp:RadioButton runat="server" CssClass="cursor" Text="2" ID="BoqQuestion23_2" GroupName ="BoqQuestion23" />
                          </td>
                        <td width="40" align="left" valign="top"><asp:RadioButton runat="server" CssClass="cursor" Text="1" ID="BoqQuestion23_1" GroupName ="BoqQuestion23" />
                          </td>
                        <td width="40" align="left" valign="top"><asp:RadioButton runat="server" CssClass="cursor" Text="0" ID="BoqQuestion23_0" GroupName ="BoqQuestion23" />
                           </td>
                           
                                    
                      </tr>
                      <tr>
                        <td width="300" align="left" valign="top" bgcolor="#C8E07F">24.	Rewards are linked to expectations and rules</td>
                       
                        <td width="40" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton runat="server" CssClass="cursor" Text="3" ID="BoqQuestion24_3" GroupName ="BoqQuestion24" />
                          </td>
                        <td width="40" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton runat="server" CssClass="cursor" Text="2" ID="BoqQuestion24_2" GroupName ="BoqQuestion24" />
                          </td>
                        <td width="40" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton runat="server" CssClass="cursor" Text="1" ID="BoqQuestion24_1" GroupName ="BoqQuestion24" />
                          </td>
                        <td width="40" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton runat="server" CssClass="cursor" Text="0" ID="BoqQuestion24_0" GroupName ="BoqQuestion24" />
                         </td>
                         
                                    
                      </tr>
                      
                      <tr>
                        <td width="300" align="left" valign="top">25.	Rewards are varied to maintain student interest </td>
                        
                        <td width="40" align="left" valign="top">&nbsp;</td>
                        <td width="40" align="left" valign="top"><asp:RadioButton runat="server" CssClass="cursor" Text="2" ID="BoqQuestion25_2" GroupName ="BoqQuestion25" />
                          </td>
                        <td width="40" align="left" valign="top"><asp:RadioButton runat="server" CssClass="cursor" Text="1" ID="BoqQuestion25_1" GroupName ="BoqQuestion25" />
                          </td>
                        <td width="40" align="left" valign="top"><asp:RadioButton runat="server" CssClass="cursor" Text="0" ID="BoqQuestion25_0" GroupName ="BoqQuestion25" />
                          </td>
                          
                                    
                      </tr>
                    <tr>
                        <td width="300" align="left" valign="top" bgcolor="#C8E07F">26.	Ratios of acknowledgement to corrections are high </td>
                       
                        <td width="40" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton runat="server" CssClass="cursor" Text="3" ID="BoqQuestion26_3" GroupName ="BoqQuestion26" />
                          </td>
                        <td width="40" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton runat="server" CssClass="cursor" Text="2" ID="BoqQuestion26_2" GroupName ="BoqQuestion26" />
                          </td>
                        <td width="40" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton runat="server" CssClass="cursor" Text="1" ID="BoqQuestion26_1" GroupName ="BoqQuestion26" />
                          </td>
                        <td width="40" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton runat="server" CssClass="cursor" Text="0" ID="BoqQuestion26_0" GroupName ="BoqQuestion26" />
                          </td>
                        
                                    
                      </tr>
                      <tr>
                        <td width="300" align="left" valign="top">27.	Students are involved in identifying/developing incentives </td>
                      
                         <td width="40" align="left" valign="top" >
                          </td>
                        <td width="40" align="left" valign="top" >
                          </td>
                        <td width="40" align="left" valign="top" ><asp:RadioButton runat="server" CssClass="cursor" Text="1" ID="BoqQuestion27_1" GroupName ="BoqQuestion27" />
                          </td>
                        <td width="40" align="left" valign="top" ><asp:RadioButton runat="server" CssClass="cursor" Text="0" ID="BoqQuestion27_0" GroupName ="BoqQuestion27" />
                          </td>
                           
                                    
                      </tr>
                      <tr>
                        <td width="300" align="left" valign="top" bgcolor="#C8E07F">28.	The system includes incentives for staff/faculty</td>
                       
                        <td width="40" align="left" valign="top" bgcolor="#C8E07F">&nbsp;</td>
                         <td width="40" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton runat="server" CssClass="cursor" Text="2" ID="BoqQuestion28_2" GroupName ="BoqQuestion28" />
                          </td>
                        <td width="40" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton runat="server" CssClass="cursor" Text="1" ID="BoqQuestion28_1" GroupName ="BoqQuestion28" />
                          </td>
                        <td width="40" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton runat="server" CssClass="cursor" Text="0" ID="BoqQuestion28_0" GroupName ="BoqQuestion28" />
                          </td>
                         
                                    
                      </tr>
                      
                   
                    </table>
                    <br>
                    <table width="790" border="1" cellpadding="2" cellspacing="0" bordercolor="#000000">
                      <tr>
                        <td width="120" rowspan="6" align="left" valign="top" bgcolor="#CCCCCC"><strong>LESSON
                          PLANS FOR TEACHING EXPECTATIONS/ RULES</strong></td>
                        <td width="300" align="left" valign="top" bgcolor="#C8E07F">29.	A behavioral curriculum includes teaching expectations and rules</td>
                       
                        <td width="40" align="left" valign="top" bgcolor="#C8E07F">&nbsp;</td>
                        <td width="40" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton runat="server" CssClass="cursor" Text="2" ID="BoqQuestion29_2" GroupName ="BoqQuestion29" />
                          </td>
                        <td width="40" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton runat="server" CssClass="cursor" Text="1" ID="BoqQuestion29_1" GroupName ="BoqQuestion29" />
                          </td>
                        <td width="40" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton runat="server" CssClass="cursor" Text="0" ID="BoqQuestion29_0" GroupName ="BoqQuestion29" />
                          </td>
                             
                                    
                      </tr>
                      <tr>
                        <td width="300" align="left" valign="top">30.	Lessons include examples and non-examples</td>
  
                        <td width="40" align="left" valign="top">&nbsp;</td>
                        <td width="40" align="left" valign="top">&nbsp;</td>
                        <td width="40" align="left" valign="top"><asp:RadioButton runat="server" CssClass="cursor" Text="1" ID="BoqQuestion30_1" GroupName ="BoqQuestion30" />
                          </td>
                        <td width="40" align="left" valign="top"><asp:RadioButton runat="server" CssClass="cursor" Text="0" ID="BoqQuestion30_0" GroupName ="BoqQuestion30" />
                          </td>
                            
                                    
                      </tr>
                      <tr>
                        <td width="300" align="left" valign="top" bgcolor="#C8E07F">31.	Lessons use a variety of teaching strategies </td>
                       
                        <td width="40" align="left" valign="top" bgcolor="#C8E07F">&nbsp;</td>
                        <td width="40" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton runat="server" CssClass="cursor" Text="2" ID="BoqQuestion31_2" GroupName ="BoqQuestion31" />
                          </td>
                        <td width="40" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton runat="server" CssClass="cursor" Text="1" ID="BoqQuestion31_1" GroupName ="BoqQuestion31" />
                          </td>
                        <td width="40" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton runat="server" CssClass="cursor" Text="0" ID="BoqQuestion31_0" GroupName ="BoqQuestion31" />
                          </td>
                            
                                    
                      </tr>
                      <tr>
                        <td width="300" align="left" valign="top">32.	Lessons are embedded into subject area curriculum </td>
                      
                        <td width="40" align="left" valign="top">&nbsp;</td>
                        <td width="40" align="left" valign="top"><asp:RadioButton runat="server" CssClass="cursor" Text="2" ID="BoqQuestion32_2" GroupName ="BoqQuestion32" />
                          </td>
                        <td width="40" align="left" valign="top"><asp:RadioButton runat="server" CssClass="cursor" Text="1" ID="BoqQuestion32_1" GroupName ="BoqQuestion32" />
                          </td>
                        <td width="40" align="left" valign="top"><asp:RadioButton runat="server" CssClass="cursor" Text="0" ID="BoqQuestion32_0" GroupName ="BoqQuestion32" />
                          </td>
                            
                                    
                      </tr>
                      
                      <tr>
                        <td width="300" align="left" valign="top" bgcolor="#C8E07F">33.	Faculty/staff and students are involved in development &
delivery of behavioral curriculum </td>
                       
                        <td width="40" align="left" valign="top" bgcolor="#C8E07F">&nbsp;</td>
                        <td width="40" align="left" valign="top" bgcolor="#C8E07F">&nbsp;</td>
                        <td width="40" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton runat="server" CssClass="cursor" Text="1" ID="BoqQuestion33_1" GroupName ="BoqQuestion33" />
                          </td>
                        <td width="40" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton runat="server" CssClass="cursor" Text="0" ID="BoqQuestion33_0" GroupName ="BoqQuestion33" />
                          </td>
                            
                                    
                      </tr>
					  <tr>
                        <td width="300" align="left" valign="top" >34.	Strategies to share key features of SWPBS program with families/community are developed and implemented </td>
                       
                        <td width="40" align="left" valign="top" >&nbsp;</td>
                        <td width="40" align="left" valign="top" >&nbsp;</td>
                        <td width="40" align="left" valign="top"><asp:RadioButton runat="server" CssClass="cursor" Text="1" ID="BoqQuestion34_1" GroupName ="BoqQuestion34" />
                          </td>
                        <td width="40" align="left" valign="top" ><asp:RadioButton runat="server" CssClass="cursor" Text="0" ID="BoqQuestion34_0" GroupName ="BoqQuestion34" />
                          </td>
                            
                                    
                      </tr>
                    </table>
                    <br>
                  </div></td>
                <td width="10">&nbsp;</td>
              </tr>
              
                             
                <table width="790" border="1" cellpadding="2" cellspacing="0" bordercolor="#000000">
                  <tr>
                    <td width="120" rowspan="8" align="left" valign="top"><strong>IMPLEMENTATION
                      PLAN</strong></td>
                    <td width="300" align="left" valign="top" bgcolor="#C8E07F">35.	A curriculum to teach the components of the discipline system to all staff is developed and used </td>
                    
                    <td width="40" align="left" valign="top" bgcolor="#C8E07F">&nbsp;</td>
                    <td width="40" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton runat="server" CssClass="cursor" Text="2" ID="BoqQuestion35_2" GroupName ="BoqQuestion35" />
                      </td>
                    <td width="40" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton runat="server" CssClass="cursor" Text="1" ID="BoqQuestion35_1" GroupName ="BoqQuestion35" />
                      </td>
                    <td width="40" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton runat="server" CssClass="cursor" Text="0" ID="BoqQuestion35_0" GroupName ="BoqQuestion35" />
                      </td>
                        
                                    
                  </tr>
                  <tr>
                    <td width="300" align="left" valign="top">36.	Plans for training staff how to teach expectations/rules/rewards are developed, scheduled and delivered </td>
                    
                    <td width="40" align="left" valign="top">&nbsp;</td>
                    <td width="40" align="left" valign="top"><asp:RadioButton runat="server" CssClass="cursor" Text="2" ID="BoqQuestion36_2" GroupName ="BoqQuestion36" />
                      </td>
                    <td width="40" align="left" valign="top"><asp:RadioButton runat="server" CssClass="cursor" Text="1" ID="BoqQuestion36_1" GroupName ="BoqQuestion36" />
                      </td>
                    <td width="40" align="left" valign="top"><asp:RadioButton runat="server" CssClass="cursor" Text="0" ID="BoqQuestion36_0" GroupName ="BoqQuestion36" />
                       </td>
                         
                                    
                  </tr>
                  <tr>
                    <td width="300" align="left" valign="top" bgcolor="#C8E07F">37.	A plan for teaching students expectations/rules/rewards is developed scheduled and delivered</td>
                   
                    <td width="40" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton runat="server" Text="3" ID="BoqQuestion37_3" GroupName ="BoqQuestion37" />
                       </td>
                    <td width="40" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton runat="server" Text="2" ID="BoqQuestion37_2" GroupName ="BoqQuestion37" />
                      </td>
                    <td width="40" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton runat="server" Text="1" ID="BoqQuestion37_1" GroupName ="BoqQuestion37" />
                      </td>
                    <td width="40" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton runat="server" Text="0" ID="BoqQuestion37_0" GroupName ="BoqQuestion37" />
                      </td>
                        
                                    
                  </tr>
                  <tr>
                    <td width="300" align="left" valign="top">38.	Booster sessions for students and staff are planned, scheduled, and delivered </td>
                  
                    <td width="40" align="left" valign="top">&nbsp;</td>
                    <td width="40" align="left" valign="top"><asp:RadioButton runat="server" CssClass="cursor" Text="2" ID="BoqQuestion38_2" GroupName ="BoqQuestion38" />
                      </td>
                     
                    <td width="40" align="left" valign="top"><asp:RadioButton runat="server" CssClass="cursor" Text="1" ID="BoqQuestion38_1" GroupName ="BoqQuestion38" />
                      </td>
                     
                    <td width="40" align="left" valign="top"><asp:RadioButton runat="server" CssClass="cursor" Text="0" ID="BoqQuestion38_0" GroupName ="BoqQuestion38" />
                      </td>
                     
                        
                                    
                  </tr>
                  <tr>
                    <td width="300" align="left" valign="top" bgcolor="#C8E07F">39.	Schedule for rewards/incentives for the year is planned</td>
                 
                    <td width="40" align="left" valign="top" bgcolor="#C8E07F">&nbsp;</td>
                    <td width="40" align="left" valign="top" bgcolor="#C8E07F">&nbsp;</td>
                    <td width="40" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton runat="server" CssClass="cursor" Text="1" ID="BoqQuestion39_1" GroupName ="BoqQuestion39" />
                      </td>
                    <td width="40" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton runat="server" CssClass="cursor" Text="0" ID="BoqQuestion39_0" GroupName ="BoqQuestion39" />
                      </td>
                            
                                    
                  </tr>
                  <tr>
                    <td width="300" align="left" valign="top">40.	Plans for orienting incoming staff and students are developed and implemented </td>
                    
                    <td width="40" align="left" valign="top">&nbsp;</td>
                    <td width="40" align="left" valign="top"><asp:RadioButton runat="server" CssClass="cursor" Text="2" ID="BoqQuestion40_2" GroupName ="BoqQuestion40" />
                      </td>
                    <td width="40" align="left" valign="top"><asp:RadioButton runat="server" CssClass="cursor" Text="1" ID="BoqQuestion40_1" GroupName ="BoqQuestion40" />
                      </td>
                    <td width="40" align="left" valign="top"><asp:RadioButton runat="server" CssClass="cursor" Text="0" ID="BoqQuestion40_0" GroupName ="BoqQuestion40" />
                      </td>
                            
                                    
                  </tr>
                  <tr>
                    <td width="300" align="left" valign="top" bgcolor="#C8E07F">41.	Plans for involving families/community are developed & implemented</td>
                   
                    <td width="40" align="left" valign="top" bgcolor="#C8E07F">&nbsp;</td>
                    <td width="40" align="left" valign="top" bgcolor="#C8E07F">&nbsp;</td>
             &nbsp;</td>
                    <td width="40" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton runat="server" CssClass="cursor" Text="1" ID="BoqQuestion41_1" GroupName ="BoqQuestion41" />
                      </td>
                    <td width="40" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton runat="server" CssClass="cursor" Text="0" ID="BoqQuestion41_0" GroupName ="BoqQuestion41" />
                      </td>
                            
                                    
                  </tr>
                    
                </table>
                
                  <br/>
                  <table width="790" border="1" cellpadding="2" cellspacing="0" bordercolor="#000000">
                    <tr>
                      <td width="105" rowspan="7" align="left" valign="top" bgcolor="#CCCCCC" class="style3"><strong>CLASSROOM SYSTEMS
                        </strong></td>
                      <td width="300" align="left" valign="top">42.	Classroom rules are defined for each of the school-wide expectations and are posted in classrooms.</td>
                    
                      <td width="40" align="left" valign="top">&nbsp;</td>
                       <td width="40" align="left" valign="top"><asp:RadioButton runat="server" CssClass="cursor" Text="2" ID="BoqQuestion42_2" GroupName ="BoqQuestion42" />
                      </td>
                    <td width="40" align="left" valign="top"><asp:RadioButton runat="server" CssClass="cursor" Text="1" ID="BoqQuestion42_1" GroupName ="BoqQuestion42" />
                      </td>
                    <td width="40" align="left" valign="top"><asp:RadioButton runat="server" CssClass="cursor" Text="0" ID="BoqQuestion42_0" GroupName ="BoqQuestion42" />
                      </td>
                            
                                    
                    </tr>
                    <tr>
                      <td width="300" align="left" valign="top" bgcolor="#C8E07F"><span style="width:255.65pt;;
    	  height:18.25pt">43.	Classroom routines and procedures are explicitly identified for activities where problems often occur (e.g. entering class, asking questions, sharpening pencil, using restroom, dismissal)</span></td>
                    
                      <td width="40" align="left" valign="top" bgcolor="#C8E07F">&nbsp;</td>
                     
                       <td width="40" align="left" valign="top"  bgcolor="#C8E07F"><asp:RadioButton runat="server" CssClass="cursor" Text="2" ID="BoqQuestion43_2" GroupName ="BoqQuestion43" />
                      </td>
                    <td width="40" align="left" valign="top"  bgcolor="#C8E07F"><asp:RadioButton runat="server" CssClass="cursor" Text="1" ID="BoqQuestion43_1" GroupName ="BoqQuestion43" />
                      </td>
                    <td width="40" align="left" valign="top"  bgcolor="#C8E07F"><asp:RadioButton runat="server" CssClass="cursor" Text="0" ID="BoqQuestion43_0" GroupName ="BoqQuestion43" />
                      </td>
                            
                                    
                    </tr>
                    <tr>
                      <td width="300" align="left" valign="top">44.	Expected behavior routines in classroom are taught</td>
                   
                      <td width="40" align="left" valign="top">&nbsp;</td>
                       <td width="40" align="left" valign="top" ><asp:RadioButton runat="server" CssClass="cursor" Text="2" ID="BoqQuestion44_2" GroupName ="BoqQuestion44" />
                      </td>
                    <td width="40" align="left" valign="top"  ><asp:RadioButton runat="server" CssClass="cursor" Text="1" ID="BoqQuestion44_1" GroupName ="BoqQuestion44" />
                      </td>
                    <td width="40" align="left" valign="top"  ><asp:RadioButton runat="server" CssClass="cursor" Text="0" ID="BoqQuestion44_0" GroupName ="BoqQuestion44" />
                      </td>
                            
                                    
                    </tr>
                    
                   
                    
       
                    
                    <tr>
                     
                      <td width="300" align="left" valign="top" bgcolor="#C8E07F">45.	Classroom  teachers use immediate and specific praise</td>
                    
                      <td width="40" align="left" valign="top" bgcolor="#C8E07F">&nbsp;</td>
                      <td width="40" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton runat="server" CssClass="cursor" Text="2" ID="BoqQuestion45_2" GroupName ="BoqQuestion45" />
                      </td>
                      <td width="40" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton runat="server" CssClass="cursor" Text="1" ID="BoqQuestion45_1" GroupName ="BoqQuestion45" />
                      </td>
                      <td width="40" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton runat="server" CssClass="cursor" Text="0" ID="BoqQuestion45_0" GroupName ="BoqQuestion45" />
                      </td>
                            
                                    
                    </tr>
                    
                   
                    <tr>
                     
                      <td width="300" align="left" valign="top" >46.	Acknowledgement of students demonstrating adherence to classroom rules and routines occurs more frequently than acknowledgement of inappropriate behaviors</td>
                    
                      <td width="40" align="left" valign="top" >&nbsp;</td>
                      <td width="40" align="left" valign="top" ><asp:RadioButton runat="server" CssClass="cursor" Text="2" ID="BoqQuestion46_2" GroupName ="BoqQuestion46" /></td>
                      <td width="40" align="left" valign="top" ><asp:RadioButton runat="server" CssClass="cursor" Text="1" ID="BoqQuestion46_1" GroupName ="BoqQuestion46" /></td>
                      <td width="40" align="left" valign="top" ><asp:RadioButton runat="server" CssClass="cursor" Text="0" ID="BoqQuestion46_0" GroupName ="BoqQuestion46" /></td>
                            
                                    
                    </tr>
       
                    
                    <tr>
                     
                      <td width="300" align="left" valign="top" bgcolor="#C8E07F" class="style4">47.	Procedures exist for tracking classroom behavior problems</td>
                     
                      <td width="40" align="left" valign="top" bgcolor="#C8E07F" class="style4"></td>
                      <td width="40" align="left" valign="top" bgcolor="#C8E07F" class="style4"><asp:RadioButton runat="server" CssClass="cursor" Text="2" ID="BoqQuestion47_2" GroupName ="BoqQuestion47" /></td>
                      <td width="40" align="left" valign="top" bgcolor="#C8E07F" class="style4"><asp:RadioButton runat="server" CssClass="cursor" Text="1" ID="BoqQuestion47_1" GroupName ="BoqQuestion47" /></td>
                      <td width="40" align="left" valign="top" bgcolor="#C8E07F" class="style4"><asp:RadioButton runat="server" CssClass="cursor" Text="0" ID="BoqQuestion47_0" GroupName ="BoqQuestion47" /></td>
                      
                                    
                    </tr>
                    
                   
                    
       
                    
                    <tr>
                     
                      <td width="300" align="left" valign="top"  class="style4">48.	Classrooms have a range of consequences/interventions for problem behavior that are documented and consistently delivered</td>
                    
                      <td width="40" align="left" valign="top"  class="style4">&nbsp;</td>
                      <td width="40" align="left" valign="top"  class="style4"><asp:RadioButton runat="server" CssClass="cursor" Text="2" ID="BoqQuestion48_2" GroupName ="BoqQuestion48" /></td>
                      <td width="40" align="left" valign="top"  class="style4"><asp:RadioButton runat="server" CssClass="cursor" Text="1" ID="BoqQuestion48_1" GroupName ="BoqQuestion48" /></td>
                      <td width="40" align="left" valign="top"  class="style4"><asp:RadioButton runat="server" CssClass="cursor" Text="0" ID="BoqQuestion48_0" GroupName ="BoqQuestion48" /></td>
                      
                                    
                    </tr>
                    
                   
                    
       
                    
                    </table>
                 <br />
                  
                  
                  <table width="790" border="1" cellpadding="2" cellspacing="0" bordercolor="#000000">
                     <tr>
                      <td width="126" rowspan="6" align="left" valign="top"><strong>EVALUATION</strong></td>
                      <td width="300" align="left" valign="top" bgcolor="#C8E07F">49.	Students and staff are surveyed about PBS</td>
                     
                      <td width="40" align="left" valign="top" bgcolor="#C8E07F">&nbsp;</td>
                      <td width="40" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton runat="server" CssClass="cursor" Text="2" ID="BoqQuestion49_2" GroupName ="BoqQuestion49" />
                      </td>
                      <td width="40" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton runat="server" CssClass="cursor" Text="1" ID="BoqQuestion49_1" GroupName ="BoqQuestion49" />
                      </td>
                      <td width="40" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton runat="server" CssClass="cursor" Text="0" ID="BoqQuestion49_0" GroupName ="BoqQuestion49" />
                      </td>
                      
                                    
                    </tr>
                    <tr>
                      <td width="300" align="left" valign="top">50.	Students and staff can identify expectations and rules    <td width="39" align="left" valign="top">&nbsp;</td>
                    
                      <td width="40" align="left" valign="top"><asp:RadioButton runat="server" CssClass="cursor" Text="2" ID="BoqQuestion50_2" GroupName ="BoqQuestion50" />
                      </td>
                      <td width="40" align="left" valign="top"><asp:RadioButton runat="server" CssClass="cursor" Text="1" ID="BoqQuestion50_1" GroupName ="BoqQuestion50" />
                      </td>
                      <td width="40" align="left" valign="top"><asp:RadioButton runat="server" CssClass="cursor" Text="0" ID="BoqQuestion50_0" GroupName ="BoqQuestion50" />
                       </td>
                       
                                    
                    </tr>
                    <tr>
                      <td width="300" align="left" valign="top" bgcolor="#C8E07F"><span style="width:255.65pt;;
  	    height:18.25pt">51.	Staff use referral process (including which behaviors are office managed vs. teacher managed) and forms appropriately </span></td>
                     
                      <td width="40" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton runat="server" CssClass="cursor" Text="3" ID="BoqQuestion51_3" GroupName ="BoqQuestion51" />
                        </td>
                      <td width="40" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton runat="server" CssClass="cursor" Text="2" ID="BoqQuestion51_2" GroupName ="BoqQuestion51" />
                      </td>
                      <td width="40" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton runat="server" CssClass="cursor" Text="1" ID="BoqQuestion51_1" GroupName ="BoqQuestion51" />
                      </td>
                      <td width="40" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton runat="server" CssClass="cursor" Text="0" ID="BoqQuestion51_0" GroupName ="BoqQuestion51" />
                      </td>
                      
                                    
                    </tr>
                    <tr>
                      <td width="300" align="left" valign="top"><span style="tab-stops:right 244.85pt">52.	Staff use reward system appropriately</span></td>
                     
                      <td width="40" align="left" valign="top"><asp:RadioButton runat="server" CssClass="cursor" Text="3" ID="BoqQuestion52_3" GroupName ="BoqQuestion52" />
                      </td>
                      <td width="40" align="left" valign="top"><asp:RadioButton runat="server" CssClass="cursor" Text="2" ID="BoqQuestion52_2" GroupName ="BoqQuestion52" />
                      </td>
                      <td width="40" align="left" valign="top"><asp:RadioButton runat="server" CssClass="cursor" Text="1" ID="BoqQuestion52_1" GroupName ="BoqQuestion52" />
                      </td>
                      <td width="40" align="left" valign="top"><asp:RadioButton runat="server" CssClass="cursor" Text="0" ID="BoqQuestion52_0" GroupName ="BoqQuestion52" />
                     </td>
                      
                                    
                    </tr>
                    <tr>
                      <td width="300" align="left" valign="top" bgcolor="#C8E07F">53.	Outcomes (behavior problems, attendance, morale) are documented and used to evaluate PBS plan </td>
                      
                      <td width="40" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton runat="server" CssClass="cursor" Text="3" ID="BoqQuestion53_3" GroupName ="BoqQuestion53" />
                      </td>
                      <td width="40" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton runat="server" CssClass="cursor" Text="2" ID="BoqQuestion53_2" GroupName ="BoqQuestion53" />
                      </td>
                      <td width="40" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton runat="server" CssClass="cursor" Text="1" ID="BoqQuestion53_1" GroupName ="BoqQuestion53" />
                      </td>
                      <td width="40" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton runat="server" CssClass="cursor" Text="0" ID="BoqQuestion53_0" GroupName ="BoqQuestion53" />
                      </td>
                      
                                    
                    </tr>
                      &nbsp;</table>
                  
                 
                      <br />
                      
                     
                   <%-- <table width="790" border="1" cellpadding="2" cellspacing="0" bordercolor="#000000">
                  <tr>
                  <td width="700" colspan="7"><strong>The following are ?pilot? items and will not be included in the overall scoring of the BoQ.</strong></td> 
                  </tr>
                    <tr>
                      <td rowspan="8" align="left" valign="top" ><strong>CLASSROOM</strong></td>
                      <td width="300" align="left" valign="top" >54. Classroom rules are defined for each of the school-wide expectations and are
                          posted in classroms.</td>
                        <td width="40" align="left" valign="top" >&nbsp;</td>
                      <td width="40" align="left" valign="top" >&nbsp;</td>
                      <td width="40" align="left" valign="top" >
                      <asp:RadioButton ID="BoqQuestion54_2" CssClass="cursor" Text="2" runat="server" GroupName = "BoqQuestion54" />
                     
                      </td>
                      <td width="40" align="left" valign="top" >
                       <asp:RadioButton ID="BoqQuestion54_1" CssClass="cursor" Text="1" runat="server" GroupName = "BoqQuestion54" />
                     </td>
                      <td width="40" align="left" valign="top" >
                         <asp:RadioButton ID="BoqQuestion54_0" CssClass="cursor" Text="0" runat="server" GroupName = "BoqQuestion54" />
                     
                      </td>
                    </tr>
                    <tr>
                      <td width="323" align="left" valign="top" bgcolor="#C8E07F">55. Classroom routines and procedures are explicitly identified for activities (e.g.
                          entering class, asking question, sharpening pencil, using restroom,dismissal). </td>
                      <td width="39" align="left" valign="top" bgcolor="#C8E07F">&nbsp;</td>
                      <td width="41" align="left" valign="top" bgcolor="#C8E07F">
                          &nbsp;</td>
                      <td width="41" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton ID="BoqQuestion55_2" CssClass="cursor" Text="2" runat="server" GroupName = "BoqQuestion55" />
                      </td>
                      <td width="41" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton ID="BoqQuestion55_1" CssClass="cursor" Text="1" runat="server" GroupName = "BoqQuestion55" />
                      </td>
                      <td width="45" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton ID="BoqQuestion55_0" CssClass="cursor" Text="0" runat="server" GroupName = "BoqQuestion55" />
                      </td>
                    </tr>
                    <tr>
                      <td width="323" align="left" valign="top">56. Expected behavior routines in clasrooms
                          are taught.</td>
                      <td width="39" align="left" valign="top">&nbsp;</td>
                      <td width="41" align="left" valign="top">
                          &nbsp;</td>
                      <td width="41" align="left" valign="top"><asp:RadioButton ID="BoqQuestion56_2" CssClass="cursor" Text="2" runat="server" GroupName = "BoqQuestion56" />
                      </td>
                      <td width="41" align="left" valign="top"><asp:RadioButton ID="BoqQuestion56_1" CssClass="cursor" Text="1" runat="server" GroupName = "BoqQuestion56" />
                      </td>
                      <td width="45" align="left" valign="top"><asp:RadioButton ID="BoqQuestion56_0" CssClass="cursor" Text="0" runat="server" GroupName = "BoqQuestion56" />
                      </td>
                    </tr>
                    <tr>
                      <td width="323" align="left" valign="top" bgcolor="#C8E07F">
                          57.Classroom teachers use immediate and behavior specific praise. </td>
                      <td width="39" align="left" valign="top" bgcolor="#C8E07F">&nbsp;</td>
                      <td width="41" align="left" valign="top" bgcolor="#C8E07F">&nbsp;</td>
                      <td width="41" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton ID="BoqQuestion57_2" CssClass="cursor" Text="2" runat="server" GroupName = "BoqQuestion57" />
                      </td>
                      <td width="41" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton ID="BoqQuestion57_1" CssClass="cursor" Text="1" runat="server" GroupName = "BoqQuestion57" />
                      </td>
                      <td width="45" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton ID="BoqQuestion57_0" CssClass="cursor" Text="0" runat="server" GroupName = "BoqQuestion57" />
                       </td>
                    </tr>
                    <tr>
                      <td width="323" align="left" valign="top" >58. Acknowledgement of students demonstrating
                          adherence to classroom rules and routines occurs more frequently than acknowledgement
                          of inappropraite behaviors.</td>
                      <td width="39" align="left" valign="top" >&nbsp;</td>
                      <td width="41" align="left" valign="top" >
                          &nbsp;</td>
                      <td width="41" align="left" valign="top" ><asp:RadioButton ID="BoqQuestion58_2" CssClass="cursor" Text="2" runat="server" GroupName = "BoqQuestion58" />
                      </td>
                      <td width="41" align="left" valign="top" ><asp:RadioButton ID="BoqQuestion58_1" CssClass="cursor" Text="1" runat="server" GroupName = "BoqQuestion58" />
                      </td>
                      <td width="45" align="left" valign="top" ><asp:RadioButton ID="BoqQuestion58_0" CssClass="cursor" Text="0" runat="server" GroupName = "BoqQuestion58" />
                      </td>
                    </tr>
                    <tr>
                      <td width="323" align="left" valign="top" bgcolor="#C8E07F">59. Procedure exist for tracking classroom behavior problems.</td>
                      <td width="39" align="left" valign="top" bgcolor="#C8E07F">&nbsp;</td>
                      <td width="41" align="left" valign="top" bgcolor="#C8E07F">
                          &nbsp;</td>
                      <td width="41" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton ID="BoqQuestion59_2" CssClass="cursor" Text="2" runat="server" GroupName = "BoqQuestion59" />
                      </td>
                      <td width="41" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton ID="BoqQuestion59_1" CssClass="cursor" Text="1" runat="server" GroupName = "BoqQuestion59" />
                      </td>
                      <td width="45" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton ID="BoqQuestion59_0" CssClass="cursor" Text="0" runat="server" GroupName = "BoqQuestion59" />
                      </td>
                    </tr>
                    <tr>
                      <td width="323" align="left" valign="top" >60. Classrooms have a range of consequences/interventions
                          for problem behavior that are documented and consistently delivered.
                      </td>
                      <td width="39" align="left" valign="top" >&nbsp;</td>
                      <td width="41" align="left" valign="top" >
                          &nbsp;</td>
                      <td width="41" align="left" valign="top" ><asp:RadioButton ID="BoqQuestion60_2" CssClass="cursor" Text="2" runat="server" GroupName = "BoqQuestion60" />
                      </td>
                      <td width="41" align="left" valign="top" ><asp:RadioButton ID="BoqQuestion60_1" CssClass="cursor" Text="1" runat="server" GroupName = "BoqQuestion60" />
                      </td>
                      <td width="45" align="left" valign="top" ><asp:RadioButton ID="BoqQuestion60_0" CssClass="cursor" Text="0" runat="server" GroupName = "BoqQuestion60" />
                      </td>
                    </tr>
                       
                      &nbsp;</table>--%> 
                    <%--End of Commented(before) --%>
                  <P align="center"><span class="contentText"><a href="javascript:window.print()">CLICK HERE TO PRINT THE FORM <strong>BEFORE</strong> SUBMITTING!!</a></span><a HREF="javascript:window.print()"></a>
                  <p align="center">
                  
                  <asp:Button ID="btnsubmit" runat="server" Text="Submit" BackColor="Beige" BorderColor="#C8E07F" BorderWidth="3" OnClientClick="return checkformBOQ('Form1');" />
              
                    <br />
                    <br />                  
                  </td>
                  </tr>
    </td>
</td>
</table>

</td>
</tr>
        </td>
    </tr>
        </td>
    </tr>
</asp:Content>
