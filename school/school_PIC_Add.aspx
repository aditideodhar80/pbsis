<%@ Page Language="VB" AutoEventWireup="false" MasterPageFile="~/pbsmaster/Detail.master"  CodeFile="school_PIC_Add.aspx.vb" Inherits="school_school_PIC_Add" %>

<asp:Content ID ="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <style type="text/css">
<!--
.cursor {  cursor: pointer}
        .style1
        {
            width: 32%;
        }
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

    <tr>
        <td>
<table width="100%"  border="0" cellspacing="0" cellpadding="0">
        <tr>
          <td colspan="3"><img src="../images/box-top.gif" width="800" height="1"></td>
        </tr>
        <tr>
          <td width="5" align="left" valign="top" background="../images/bounding-box-line-left-side.gif">&nbsp;</td>
          <td width="789" align="left" valign="top">
		  
		  <table width="100%"  border="0" align="left" cellpadding="0" cellspacing="0">
              <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td align="right" valign="top">&nbsp;</td>
                <td>&nbsp;</td>
              </tr>
              <tr>
                <td width="10">&nbsp;</td>
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
                          <table width="100%"  border="0" cellspacing="0" cellpadding="0">
                          <tr> 
                              <td align="left" valign="top" class="style1">
                              
                                  &nbsp;</td>
                            </tr>
                            <tr> 
                              <td colspan="2">&nbsp;</td>
                            </tr>
                            <tr> 
                              <td align="left" colspan="3" valign="top" class="style1"><span class="style2">
                                  <font face="Arial, Helvetica, sans-serif">PBS IMPLEMENTATION CHECKLIST -</font></span> 
                              <span class="style2"><font face="Arial, Helvetica, sans-serif" size=-1><asp:Label  CssClass="style2" Font-Size="Small" Font-Bold="true"  ID="lblTermCaption" runat="server"></asp:Label></font></span></td>
                            </tr>
                           
                            <tr> 
                              <td align="left" valign="top" class="style1" colspan="2"><span class="style2">School Name: </span><asp:Label  CssClass="style2" Font-Size="Small" Font-Bold="true"  ID="lblschoolname" runat="server"></asp:Label></td>
                             
                            </tr>
                            
                            <tr> 
                              <td align="left" valign="top" class="style1" colspan="2"><span class="style2">School Year: </span> <asp:Label CssClass="style2" Font-Size="Small" Font-Bold="true"  ID="lblschoolyr" runat="server"></asp:Label>  
                              </td>
                            </tr>
                             <tr>
                                        <td>&nbsp;</td> 
                                   </tr>
                            <tr> 
                              <td align="left" valign="top" class="style1" colspan="2">Coach Name:&nbsp; 
                              
                              <asp:DropDownList  Font-Bold="true" ID="ddlcoach" runat="server" AutoPostBack="false">
                              
                              </asp:DropDownList>
                                </td>
                            </tr>

                            <tr> 
                              <td align="left" valign="top" class="style1">&nbsp;</td>
                            </tr>
                             
                            <tr> 
                              <td  align="left" valign="top" class="style3"><strong><span style="font-size: 1.1em">Tier 1 Universal 
                                PBS</span></strong></td>
                            </tr>
                            <tr> 
                              <td align="Center" class="style1"><strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                                &nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                                &nbsp;0= No,1=Somewhat,2=Yes</strong></td>
                            </tr></table>
                            <tr> 
                              <td align="left" valign="top" style="height: 239px"  > 
                              <table width="700" border="1" cellpadding="2" cellspacing="0" bordercolor="#000000">
                                  <tr> 
                                    <td width="120" rowspan="5" align="left" valign="top" bgcolor="#CCCCCC"><strong>Preparation</strong></td>
                                    <td width="300" bgcolor="#C8E07F" style="height: 26px">
                                    <asp:Label ID="lblPIC1" runat="server" Text=" 1.School-level 
                                      administrators support PBS -active involvement, 
                                      funding allocated, etc."></asp:Label>
                                   </td>
                                    <td width="50" bgcolor="#C8E07F" style="height: 26px">&nbsp;</td>
                                    <td width="50" bgcolor="#C8E07F" style="height: 26px">
                                    <asp:RadioButton CssClass="cursor" GroupName="grpPicQuestion1" ID="rdPicQuestion1_2" runat="server" Text="2" />
                              
                                      </td>
                                    <td width="50" bgcolor="#C8E07F" style="height: 26px"> <asp:RadioButton CssClass="cursor" GroupName="grpPicQuestion1"  ID="rdPicQuestion1_1" runat="server" Text="1" /></td>
                                    <td width="50" bgcolor="#C8E07F" style="height: 26px"><asp:RadioButton CssClass="cursor" GroupName="grpPicQuestion1"  ID="rdPicQuestion1_0" runat="server" Text="0" />
                                      </td>
                                  </tr>
                                  <tr> 
                                    <td width="300">
                                    
<asp:Label ID="lblPIC2" runat="server" Text="2. Staff support PBS - staff provided overview and reached 80% agreement to implement PBS."></asp:Label>
                                    
                                  </td>
                                    <td width="50">&nbsp; </td>
                                    <td width="50"> <asp:RadioButton CssClass="cursor" GroupName="grpPicQuestion2"  ID="rdPicQuestion2_2" runat="server" Text="2" /></td>
                                    <td width="50"><asp:RadioButton CssClass="cursor" GroupName="grpPicQuestion2"  ID="rdPicQuestion2_1" runat="server" Text="1" /></td>
                                    <td width="50"><asp:RadioButton CssClass="cursor" GroupName="grpPicQuestion2"  ID="rdPicQuestion2_0" runat="server" Text="0" /></td>
                                  </tr>
                                  <tr> 
                                      <td width="300" bgcolor="#C8E07F"><asp:Label ID="lblPIC3" runat="server" Text="3. PBS Team has been established and trained -full staff representation, team meeting schedule established; attended FLPBS
trainings, has a current action plan."></asp:Label></td>
                                    <td width="50" bgcolor="#C8E07F">&nbsp;</td>
                                    <td width="50" bgcolor="#C8E07F"><asp:RadioButton CssClass="cursor" GroupName="grpPicQuestion3"  ID="rdPicQuestion3_2" runat="server" Text="2" /></td>
                                    <td width="50" bgcolor="#C8E07F"><asp:RadioButton CssClass="cursor" GroupName="grpPicQuestion3"  ID="rdPicQuestion3_1" runat="server" Text="1" /></td>
                                    <td width="50" bgcolor="#C8E07F"><asp:RadioButton CssClass="cursor" GroupName="grpPicQuestion3"  ID="rdPicQuestion3_0" runat="server" Text="0" /></td>
                                  </tr>
                                  <tr> 
                                    <td width="300" style="height: 80px"><asp:Label ID="lblPIC4" runat="server" Text="4. PBS Coach has been trained -attends summer trainings, attends coaches and regional meetings; knowledgeable about PBS, Behavioral Theory, and data-based decision making; skilled in facilitation, problem solving process, and public speaking."></asp:Label></td>
                                    <td width="50" style="height: 80px">&nbsp;</td>
                                    <td width="50" style="height: 80px"><asp:RadioButton CssClass="cursor" GroupName="grpPicQuestion4"  ID="rdPicQuestion4_2" runat="server" Text="2" /></td>
                                    <td width="50" style="height: 80px"><asp:RadioButton CssClass="cursor" GroupName="grpPicQuestion4"  ID="rdPicQuestion4_1" runat="server" Text="1" /></td>
                                    <td width="50" style="height: 80px"><asp:RadioButton CssClass="cursor" GroupName="grpPicQuestion4"  ID="rdPicQuestion4_0" runat="server" Text="0" /> </td>
                                  </tr>
                                </table></td>
                            </tr>
                          </table>
					<br>
                    <table width="700" border="1" cellpadding="2" cellspacing="0" bordercolor="#000000">
                      <tr>
                          <td width="120" rowspan="10" align="left" valign="top"><strong>Initiation</strong></td>
                        <td width="300" align="left" valign="top" bgcolor="#C8E07F"><asp:Label ID="lblPIC5" runat="server" Text="5. PBS Team meets at least once a month."></asp:Label></td>
                        
                        <td width="50" align="left" valign="top" bgcolor="#C8E07F">&nbsp;</td>
                        <td width="50" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton CssClass="cursor" GroupName="grpPicQuestion5"  ID="rdPicQuestion5_2" runat="server" Text="2" /></td>
                        <td width="50" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton CssClass="cursor" GroupName="grpPicQuestion5"  ID="rdPicQuestion5_1" runat="server" Text="1" /></td>
                        <td width="50" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton CssClass="cursor" GroupName="grpPicQuestion5"  ID="rdPicQuestion5_0" runat="server" Text="0" /></td>
                      </tr>
                      <tr>
                        <td width="300" align="left" valign="top"><asp:Label ID="lblPIC6" runat="server" Text="6. PBS Coach attends those meetings."></asp:Label></td>
                        
                        <td width="50" align="left" valign="top">&nbsp;</td>
                        <td width="50" align="left" valign="top" ><asp:RadioButton CssClass="cursor" GroupName="grpPicQuestion6"  ID="rdPicQuestion6_2" runat="server" Text="2" /></td>
                        <td width="50" align="left" valign="top"><asp:RadioButton CssClass="cursor" GroupName="grpPicQuestion6"  ID="rdPicQuestion6_1" runat="server" Text="1" /></td>
                        <td width="50" align="left" valign="top" ><asp:RadioButton CssClass="cursor" GroupName="grpPicQuestion6"  ID="rdPicQuestion6_0" runat="server" Text="0" /></td>
                      </tr>
                      <tr>
                        <td width="300" align="left" valign="top" bgcolor="#C8E07F"><asp:Label ID="lblPIC7" runat="server" Text="7. PBS Team shows a good working relationship with the Coach. "></asp:Label>
                        </td>
                       
                        <td width="50" align="left" valign="top" bgcolor="#C8E07F">&nbsp;</td>
                         <td width="50" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton CssClass="cursor" GroupName="grpPicQuestion7"  ID="rdPicQuestion7_2" runat="server" Text="2" /></td>
                        <td width="50" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton CssClass="cursor" GroupName="grpPicQuestion7"  ID="rdPicQuestion7_1" runat="server" Text="1" /></td>
                        <td width="50" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton CssClass="cursor" GroupName="grpPicQuestion7"  ID="rdPicQuestion7_0" runat="server" Text="0" /></td>
                   
                      </tr>
                      <tr>
                        <td width="300" align="left" valign="top"><asp:Label ID="lblPIC8" runat="server" Text="8. 3-5 expectations have been clearly defined and teaching plans have been described to staff."></asp:Label></td>
                        
                        <td width="50" align="left" valign="top" >&nbsp;</td>
                         <td width="50" align="left" valign="top" ><asp:RadioButton CssClass="cursor" GroupName="grpPicQuestion8"  ID="rdPicQuestion8_2" runat="server" Text="2" /></td>
                        <td width="50" align="left" valign="top"><asp:RadioButton CssClass="cursor" GroupName="grpPicQuestion8"  ID="rdPicQuestion8_1" runat="server" Text="1" /></td>
                        <td width="50" align="left" valign="top" ><asp:RadioButton CssClass="cursor" GroupName="grpPicQuestion8"  ID="rdPicQuestion8_0" runat="server" Text="0" /></td>
                      </tr>
                      <tr>
                          
                        <td width="300" align="left" valign="top"  bgcolor="#C8E07F"><asp:Label ID="lblPIC9" runat="server" Text="9. System for rewarding students has been developed &#8211; written documentation required for full score."></asp:Label></td>
                        
                        <td width="50" align="left" valign="top"  bgcolor="#C8E07F">&nbsp;</td>
                         <td width="50" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton CssClass="cursor" GroupName="grpPicQuestion9"  ID="rdPicQuestion9_2" runat="server" Text="2" /></td>
                        <td width="50" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton CssClass="cursor" GroupName="grpPicQuestion9"  ID="rdPicQuestion9_1" runat="server" Text="1" /></td>
                        <td width="50" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton CssClass="cursor" GroupName="grpPicQuestion9"  ID="rdPicQuestion9_0" runat="server" Text="0" /></td>
                      </tr>
                      <tr>
                          
                        <td width="300" align="left" valign="top" ><asp:Label ID="lblPIC10" runat="server" Text="10. Strategy for collecting and using discipline data has been established."></asp:Label></td>
                       
                        <td width="50" align="left" valign="top" >&nbsp;</td>
                         <td width="50" align="left" valign="top" ><asp:RadioButton CssClass="cursor" GroupName="grpPicQuestion10"  ID="rdPicQuestion10_2" runat="server" Text="2" /></td>
                        <td width="50" align="left" valign="top" ><asp:RadioButton CssClass="cursor" GroupName="grpPicQuestion10"  ID="rdPicQuestion10_1" runat="server" Text="1" /></td>
                        <td width="50" align="left" valign="top" ><asp:RadioButton CssClass="cursor" GroupName="grpPicQuestion10"  ID="rdPicQuestion10_0" runat="server" Text="0" /></td>
                     
                      </tr>
					  <tr> 
                        <td width="300" align="left" valign="top" bgcolor="#C8E07F"><asp:Label ID="lblPIC11" runat="server" Text="11. A plan has been developed to provide training and support to staff and teachers -including substitutes, student/intern teachers, and new staff; "></asp:Label></td>
                        
                        <td width="50" align="left" valign="top" bgcolor="#C8E07F">&nbsp;</td>
                        <td width="50" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton CssClass="cursor" GroupName="grpPicQuestion11"  ID="rdPicQuestion11_2" runat="server" Text="2" /></td>
                        <td width="50" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton CssClass="cursor" GroupName="grpPicQuestion11"  ID="rdPicQuestion11_1" runat="server" Text="1" /></td>
                        <td width="50" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton CssClass="cursor" GroupName="grpPicQuestion11"  ID="rdPicQuestion11_0" runat="server" Text="0" /></td>
                 
                      </tr>
                      <tr>
                          
                        <td width="300" align="left" valign="top"><asp:Label ID="lblPIC12" runat="server" Text="12. New and returning staff have been oriented and trained in PBS processes- rationale, reward system, office vs classroom managed behaviors, formalized procedure for handling behavior problems, flowchart developed, problem behaviors clearly defined etc."></asp:Label></td>
                        
                        <td width="50" align="left" valign="top">&nbsp;</td>
                           <td width="50" align="left" valign="top" ><asp:RadioButton CssClass="cursor" GroupName="grpPicQuestion12"  ID="rdPicQuestion12_2" runat="server" Text="2" /></td>
                        <td width="50" align="left" valign="top" ><asp:RadioButton CssClass="cursor" GroupName="grpPicQuestion12"  ID="rdPicQuestion12_1" runat="server" Text="1" /></td>
                        <td width="50" align="left" valign="top"><asp:RadioButton CssClass="cursor" GroupName="grpPicQuestion12"  ID="rdPicQuestion12_0" runat="server" Text="0" /></td>
                   </tr>
                      <tr>
                          
                        <td width="300" height="42" align="left" valign="top" bgcolor="#C8E07F"><asp:Label ID="lblPIC13" runat="server" Text="13. Parents have been oriented to PBS. "></asp:Label></td>
                       
                        <td width="50" align="left" valign="top" bgcolor="#C8E07F">&nbsp;</td>
                        <td width="50" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton CssClass="cursor" GroupName="grpPicQuestion13"  ID="rdPicQuestion13_2" runat="server" Text="2" /></td>
                        <td width="50" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton CssClass="cursor" GroupName="grpPicQuestion13"  ID="rdPicQuestion13_1" runat="server" Text="1" /></td>
                        <td width="50" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton CssClass="cursor" GroupName="grpPicQuestion13"  ID="rdPicQuestion13_0" runat="server" Text="0" /></td>
                      </tr>
                    </table>
                    <br>
                    <table width="700" border="1" cellpadding="2" cellspacing="0" bordercolor="#000000">
                      <tr>
                          <td width="120" rowspan="10" align="left" valign="top" bgcolor="#CCCCCC"><strong>Implementation</strong></td>
                          
                        <td width="300" height="151" align="left" valign="top">
                        <asp:Label ID="lblPIC14" runat="server" Text="14. Behavior expectations and reward systems are taught formally and informally to students -Occurs multiple times during the year to include transferring students, integrated into curriculums, common language used by staff and students across settings; dates for reward activities have been set and placed on school calendars.  "></asp:Label></td>
                        
                        <td width="50" align="left" valign="top">&nbsp;</td>
                        <td width="50" align="left" valign="top"><asp:RadioButton CssClass="cursor" GroupName="grpPicQuestion14"  ID="rdPicQuestion14_2" runat="server" Text="2" /></td>
                        <td width="50" align="left" valign="top"><asp:RadioButton CssClass="cursor" GroupName="grpPicQuestion14"  ID="rdPicQuestion14_1" runat="server" Text="1" /></td>
                        <td width="50" align="left" valign="top"><asp:RadioButton CssClass="cursor" GroupName="grpPicQuestion14"  ID="rdPicQuestion14_0" runat="server" Text="0" /></td>
                      </tr>
                      <tr>
                          
                        <td width="300" align="left" valign="top" bgcolor="#C8E07F"><asp:Label ID="lblPIC15" runat="server" Text="15. Behavior expectations have been posted throughout the school-including hallways, cafeteria, playground, special rooms, restrooms, offices, and classrooms."></asp:Label></td>
                       
                        <td width="50" align="left" valign="top" bgcolor="#C8E07F">&nbsp;</td>
                        <td width="50" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton CssClass="cursor" GroupName="grpPicQuestion15"  ID="rdPicQuestion15_2" runat="server" Text="2" /></td>
                        <td width="50" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton CssClass="cursor" GroupName="grpPicQuestion15"  ID="rdPicQuestion15_1" runat="server" Text="1" /></td>
                        <td width="50" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton CssClass="cursor" GroupName="grpPicQuestion15"  ID="rdPicQuestion15_0" runat="server" Text="0" /></td>
                      </tr>
                      <tr>
                          
                        <td width="300" align="left" valign="top"><asp:Label ID="lblPIC16" runat="server" Text="16. Positive behaviors are rewarded consistently across staff and settings."></asp:Label></td>
                      
                        <td width="50" align="left" valign="top">&nbsp;</td>
                        <td width="50" align="left" valign="top"><asp:RadioButton CssClass="cursor" GroupName="grpPicQuestion16"  ID="rdPicQuestion16_2" runat="server" Text="2" /></td>
                        <td width="50" align="left" valign="top"><asp:RadioButton CssClass="cursor" GroupName="grpPicQuestion16"  ID="rdPicQuestion16_1" runat="server" Text="1" /></td>
                        <td width="50" align="left" valign="top"><asp:RadioButton CssClass="cursor" GroupName="grpPicQuestion16"  ID="rdPicQuestion16_0" runat="server" Text="0" /></td>
        
                      </tr>
                      <tr>
                          
                        <td width="300" align="left" valign="top" bgcolor="#C8E07F"><asp:Label ID="lblPIC17" runat="server" Text="17. Procedures for handling inappropriate behaviors are implemented consistently across staff and settings."></asp:Label></td>
                          <td width="50" align="left" valign="top" bgcolor="#C8E07F">&nbsp; 
                          </td>
                        <td width="50" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton CssClass="cursor" GroupName="grpPicQuestion17"  ID="rdPicQuestion17_2" runat="server" Text="2" /></td>
                        <td width="50" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton CssClass="cursor" GroupName="grpPicQuestion17"  ID="rdPicQuestion17_1" runat="server" Text="1" /></td>
                        <td width="50" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton CssClass="cursor" GroupName="grpPicQuestion17"  ID="rdPicQuestion17_0" runat="server" Text="0" /></td>
   
                      </tr>
                      <tr>
                          
                        <td width="300" align="left" valign="top"><asp:Label ID="lblPIC18" runat="server" Text="18. Office discipline forms are completed consistently and accurately across staff."></asp:Label></td>
                       
                        <td width="50" align="left" valign="top">&nbsp;</td>
                        <td width="50" align="left" valign="top"><asp:RadioButton CssClass="cursor" GroupName="grpPicQuestion18"  ID="rdPicQuestion18_2" runat="server" Text="2" /></td>
                        <td width="50" align="left" valign="top"><asp:RadioButton CssClass="cursor" GroupName="grpPicQuestion18"  ID="rdPicQuestion18_1" runat="server" Text="1" /></td>
                        <td width="50" align="left" valign="top"><asp:RadioButton CssClass="cursor" GroupName="grpPicQuestion18"  ID="rdPicQuestion18_0" runat="server" Text="0" /></td>
   
                      </tr>
                      <tr>
                          
                        <td width="300" align="left" valign="top" bgcolor="#C8E07F"><asp:Label ID="lblPIC19" runat="server" Text="19. Discipline data are gathered and entered into the data base consistently and in a timely manner. "></asp:Label></td>
                       
                        <td width="50" align="left" valign="top" bgcolor="#C8E07F">&nbsp;</td>
                         <td width="50" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton CssClass="cursor" GroupName="grpPicQuestion19"  ID="rdPicQuestion19_2" runat="server" Text="2" /></td>
                        <td width="50" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton CssClass="cursor" GroupName="grpPicQuestion19"  ID="rdPicQuestion19_1" runat="server" Text="1" /></td>
                        <td width="50" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton CssClass="cursor" GroupName="grpPicQuestion19"  ID="rdPicQuestion19_0" runat="server" Text="0" /></td>
   
                      </tr>
                      <tr>
                          
                        <td width="300" align="left" valign="top"><asp:Label ID="lblPIC20" runat="server" Text="20. Discipline data are used in PBS Team meetings to identify problems and guide school decisions."></asp:Label></td>
                       
                        <td width="50" align="left" valign="top">&nbsp;</td>
                        <td width="50" align="left" valign="top"><asp:RadioButton CssClass="cursor" GroupName="grpPicQuestion20"  ID="rdPicQuestion20_2" runat="server" Text="2" /></td>
                        <td width="50" align="left" valign="top"><asp:RadioButton CssClass="cursor" GroupName="grpPicQuestion20"  ID="rdPicQuestion20_1" runat="server" Text="1" /></td>
                        <td width="50" align="left" valign="top"><asp:RadioButton CssClass="cursor" GroupName="grpPicQuestion20"  ID="rdPicQuestion20_0" runat="server" Text="0" /></td>
   
                      </tr>
                      <tr>
                          
                        <td width="300" align="left" valign="top" bgcolor="#C8E07F"><asp:Label ID="lblPIC21" runat="server" Text="21. Discipline data are summarized and reported to staff on a regular basis."></asp:Label></td>
                       
                        <td width="50" align="left" valign="top" bgcolor="#C8E07F">&nbsp;</td>
                        <td width="50" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton CssClass="cursor" GroupName="grpPicQuestion21"  ID="rdPicQuestion21_2" runat="server" Text="2" /></td>
                        <td width="50" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton CssClass="cursor" GroupName="grpPicQuestion21"  ID="rdPicQuestion21_1" runat="server" Text="1" /></td>
                        <td width="50" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton CssClass="cursor" GroupName="grpPicQuestion21"  ID="rdPicQuestion21_0" runat="server" Text="0" /></td>
   
                      </tr>
                      <tr>
                          
                        <td width="300" align="left" valign="top"><asp:Label ID="lblPIC22" runat="server" Text="22. Parents and community members are actively involved in PBS related activities, programs, and/or services."></asp:Label></td>
                       
                        <td width="50" align="left" valign="top">&nbsp;</td>
                        <td width="50" align="left" valign="top"><asp:RadioButton CssClass="cursor" GroupName="grpPicQuestion22"  ID="rdPicQuestion22_2" runat="server" Text="2" /></td>
                        <td width="50" align="left" valign="top"><asp:RadioButton CssClass="cursor" GroupName="grpPicQuestion22"  ID="rdPicQuestion22_1" runat="server" Text="1" /></td>
                        <td width="50" align="left" valign="top"><asp:RadioButton CssClass="cursor" GroupName="grpPicQuestion22"  ID="rdPicQuestion22_0" runat="server" Text="0" /></td>
   
                      </tr>
                    </table>
                    <br>
                    <table width="700" border="1" cellpadding="2" cellspacing="0" bordercolor="#000000">
                      <tr>
                          <td width="127" rowspan="6" align="left" valign="top"><strong>Maintenance</strong></td>
                          
                        <td width="319" align="left" valign="top" bgcolor="#C8E07F"><asp:Label ID="lblPIC23" runat="server" Text="23.   Data and staff feedback are used to make decisions regarding additional training and professional staff development."></asp:Label></td>
                          <td width="54" align="left" valign="top" bgcolor="#C8E07F">
                          </td>
                         <td width="50" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton CssClass="cursor" GroupName="grpPicQuestion23"  ID="rdPicQuestion23_2" runat="server" Text="2" /></td>
                        <td width="50" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton CssClass="cursor" GroupName="grpPicQuestion23"  ID="rdPicQuestion23_1" runat="server" Text="1" /></td>
                        <td width="50" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton CssClass="cursor" GroupName="grpPicQuestion23"  ID="rdPicQuestion23_0" runat="server" Text="0" /></td>
   
                      </tr>
                      <tr>
                          
                        <td width="319" align="left" valign="top"><asp:Label ID="lblPIC24" runat="server" Text="24. A plan is in place for training new PBS team members -including new administrators, staff, and district personnel. "></asp:Label></td>
                        
                        <td width="54" align="left" valign="top">&nbsp;</td>
                        <td width="50" align="left" valign="top"><asp:RadioButton CssClass="cursor" GroupName="grpPicQuestion24"  ID="rdPicQuestion24_2" runat="server" Text="2" /></td>
                        <td width="50" align="left" valign="top"><asp:RadioButton CssClass="cursor" GroupName="grpPicQuestion24"  ID="rdPicQuestion24_1" runat="server" Text="1" /></td>
                        <td width="50" align="left" valign="top"><asp:RadioButton CssClass="cursor" GroupName="grpPicQuestion24"  ID="rdPicQuestion24_0" runat="server" Text="0" /></td>
   
                      </tr>
                      <tr>
                          
                        <td width="319" align="left" valign="top" bgcolor="#C8E07F"><asp:Label ID="lblPIC25" runat="server" Text="25. Data and staff feedback are used to revise and update the PBS action plan for the school and district &#8211; reviewed and revised as needed"></asp:Label></td>
                        
                        <td width="54" align="left" valign="top" bgcolor="#C8E07F">&nbsp;</td>
                        <td width="50" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton CssClass="cursor" GroupName="grpPicQuestion25"  ID="rdPicQuestion25_2" runat="server" Text="2" /></td>
                        <td width="50" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton CssClass="cursor" GroupName="grpPicQuestion25"  ID="rdPicQuestion25_1" runat="server" Text="1" /></td>
                        <td width="50" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton CssClass="cursor" GroupName="grpPicQuestion25"  ID="rdPicQuestion25_0" runat="server" Text="0" /></td>
   
                      </tr>
                      <tr>
                          
                        <td width="319" align="left" valign="top"><asp:Label ID="lblPIC26" runat="server" Text="26. Links with the community and other resources have been established to assist with funding and incentives. "></asp:Label></td>
                       
                        <td width="54" align="left" valign="top">&nbsp;</td>
                        <td width="50" align="left" valign="top"><asp:RadioButton CssClass="cursor" GroupName="grpPicQuestion26"  ID="rdPicQuestion26_2" runat="server" Text="2" /></td>
                        <td width="50" align="left" valign="top"><asp:RadioButton CssClass="cursor" GroupName="grpPicQuestion26"  ID="rdPicQuestion26_1" runat="server" Text="1" /></td>
                        <td width="50" align="left" valign="top"><asp:RadioButton CssClass="cursor" GroupName="grpPicQuestion26"  ID="rdPicQuestion26_0" runat="server" Text="0" /></td>
   
                      </tr>
                      <tr>
                          
                        <td width="319" align="left" valign="top" bgcolor="#C8E07F"><asp:Label ID="lblPIC27" runat="server" Text="27. Morale is sustained among staff and students -staff and student attendance and participation in PBS efforts is high, system in
place to recognize staff (and parent) contributions.  "></asp:Label>
                        </td>
                        
                        <td width="54" align="left" valign="top" bgcolor="#C8E07F">&nbsp;</td>
                        <td width="50" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton CssClass="cursor" GroupName="grpPicQuestion27"  ID="rdPicQuestion27_2" runat="server" Text="2" /></td>
                        <td width="50" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton CssClass="cursor" GroupName="grpPicQuestion27"  ID="rdPicQuestion27_1" runat="server" Text="1" /></td>
                        <td width="50" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton CssClass="cursor" GroupName="grpPicQuestion27"  ID="rdPicQuestion27_0" runat="server" Text="0" /></td>
   

                      </tr>
                  
                    </table>
                    <br/>
                    <span style="font-size: 1.1em">
                    <span><strong>Tier 2 Supplemental PBS</strong></span><br />
                    </span>
                    <br />
                  
                  
                    <table width="700" border="1" cellpadding="2" cellspacing="0" bordercolor="#000000">
                      <tr>
                        <td width="130" rowspan="8" align="left" valign="top" bgcolor="#CCCCCC"><Strong>&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; </Strong></td>
                          
                        <td width="315" align="left" valign="top"><asp:Label ID="lblPIC28" runat="server" Text="28. The school has a data-based process for identifying students in need of Tier 2 supports."></asp:Label></td>
                        
                        <td width="57" align="left" valign="top">&nbsp; </td>
                        <td width="50" align="left" valign="top"><asp:RadioButton CssClass="cursor" GroupName="grpPicQuestion28"  ID="rdPicQuestion28_2" runat="server" Text="2" /></td>
                        <td width="50" align="left" valign="top"><asp:RadioButton CssClass="cursor" GroupName="grpPicQuestion28"  ID="rdPicQuestion28_1" runat="server" Text="1" /></td>
                        <td width="50" align="left" valign="top"><asp:RadioButton CssClass="cursor" GroupName="grpPicQuestion28"  ID="rdPicQuestion28_0" runat="server" Text="0" /></td>
   
                      </tr>
                      <tr>
                          
                        <td width="315" align="left" valign="top" bgcolor="#C8E07F"><asp:Label ID="lblPIC29" runat="server" Text="29. Student&#8217;s needs are prioritized to assure that students with the greater needs are supported"></asp:Label></td>
                        
                        <td width="57" align="left" valign="top" bgcolor="#C8E07F">&nbsp; 
                        </td>
                        <td width="50" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton CssClass="cursor" GroupName="grpPicQuestion29"  ID="rdPicQuestion29_2" runat="server" Text="2" /></td>
                        <td width="50" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton CssClass="cursor" GroupName="grpPicQuestion29"  ID="rdPicQuestion29_1" runat="server" Text="1" /></td>
                        <td width="50" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton CssClass="cursor" GroupName="grpPicQuestion29"  ID="rdPicQuestion29_0" runat="server" Text="0" /></td>
   
                      </tr>
                      <tr>
                          
                        <td width="315" align="left" valign="top"><asp:Label ID="lblPIC30" runat="server" Text="30. Tier 2 interventions are matched to the function of the behavior."></asp:Label></td>
                        
                        <td width="57" align="left" valign="top">&nbsp;</td>
                        <td width="50" align="left" valign="top"><asp:RadioButton CssClass="cursor" GroupName="grpPicQuestion30"  ID="rdPicQuestion30_2" runat="server" Text="2" /></td>
                        <td width="50" align="left" valign="top"><asp:RadioButton CssClass="cursor" GroupName="grpPicQuestion30"  ID="rdPicQuestion30_1" runat="server" Text="1" /></td>
                        <td width="50" align="left" valign="top"><asp:RadioButton CssClass="cursor" GroupName="grpPicQuestion30"  ID="rdPicQuestion30_0" runat="server" Text="0" /></td>
   
                      </tr>
                      <tr>
                          
                        <td width="315" align="left" valign="top" bgcolor="#C8E07F"><asp:Label ID="lblPIC31" runat="server" Text="31. The school has 0 (score 0), 1-2 (score 1), more than 2 (score 2) Tier 2 programs in place. "></asp:Label></td>
                        
                        <td width="57" align="left" valign="top" bgcolor="#C8E07F">&nbsp;</td>
                        <td width="50" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton CssClass="cursor" GroupName="grpPicQuestion31"  ID="rdPicQuestion31_2" runat="server" Text="2" /></td>
                        <td width="50" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton CssClass="cursor" GroupName="grpPicQuestion31"  ID="rdPicQuestion31_1" runat="server" Text="1" /></td>
                        <td width="50" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton CssClass="cursor" GroupName="grpPicQuestion31"  ID="rdPicQuestion31_0" runat="server" Text="0" /></td>
   
                      </tr>
                      <tr>
                          
                        <td width="315" align="left" valign="top"><asp:Label ID="lblPIC32" runat="server" Text="32. The school is checking to make sure that Tier 2 programs are implemented with fidelity. "></asp:Label></td>
                        
                        <td width="57" align="left" valign="top">&nbsp;</td>
                        <td width="50" align="left" valign="top" ><asp:RadioButton CssClass="cursor" GroupName="grpPicQuestion32"  ID="rdPicQuestion32_2" runat="server" Text="2" /></td>
                        <td width="50" align="left" valign="top" ><asp:RadioButton CssClass="cursor" GroupName="grpPicQuestion32"  ID="rdPicQuestion32_1" runat="server" Text="1" /></td>
                        <td width="50" align="left" valign="top" ><asp:RadioButton CssClass="cursor" GroupName="grpPicQuestion32"  ID="rdPicQuestion32_0" runat="server" Text="0" /></td>
   
                      </tr>
                      <tr>
                          
                        <td width="315" align="left" valign="top" bgcolor="#C8E07F"><asp:Label ID="lblPIC33" runat="server" Text="33. A progress monitoring system is in place for all students receiving Tier 2 interventions. "></asp:Label></td>
                        
                        <td width="57" align="left" valign="top" bgcolor="#C8E07F">&nbsp;</td>
                        <td width="50" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton CssClass="cursor" GroupName="grpPicQuestion33"  ID="rdPicQuestion33_2" runat="server" Text="2" /></td>
                        <td width="50" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton CssClass="cursor" GroupName="grpPicQuestion33"  ID="rdPicQuestion33_1" runat="server" Text="1" /></td>
                        <td width="50" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton CssClass="cursor" GroupName="grpPicQuestion33"  ID="rdPicQuestion33_0" runat="server" Text="0" /></td>
  
                      </tr>
                      <tr>
                          
                        <td width="315" align="left" valign="top"><asp:Label ID="lblPIC34" runat="server" Text="34. The school team makes decisions on students&#8217; response to intervention from the progress monitoring system. "></asp:Label></td>
                        
                        <td width="57" align="left" valign="top">&nbsp;</td>
                        <td width="50" align="left" valign="top" ><asp:RadioButton CssClass="cursor" GroupName="grpPicQuestion34"  ID="rdPicQuestion34_2" runat="server" Text="2" /></td>
                        <td width="50" align="left" valign="top" ><asp:RadioButton CssClass="cursor" GroupName="grpPicQuestion34"  ID="rdPicQuestion34_1" runat="server" Text="1" /></td>
                        <td width="50" align="left" valign="top" ><asp:RadioButton CssClass="cursor" GroupName="grpPicQuestion34"  ID="rdPicQuestion34_0" runat="server" Text="0" /></td>
   
                      </tr>
                 
                    </table>
                    <br>
                    <span style="font-size: 1.1em"><strong>Tier 3 Intensive PBS</strong></span><br />
                    <br />
                    <table width="700" border="1" cellpadding="2" cellspacing="0" bordercolor="#000000">
                      <tr>
                        <td width="128" rowspan="11" align="left" valign="top"><strong>&nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp;&nbsp; </strong></td>
                          
                        <td width="317" align="left" valign="top" bgcolor="#C8E07F"><asp:Label ID="lblPIC35" runat="server" Text="35. Data-based decision-making is used to identify students in need of Tier 3 supports. "></asp:Label></td>
                       
                          <td width="59" align="left" valign="top" bgcolor="#C8E07F">&nbsp; 
                          </td>
                        <td width="50" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton CssClass="cursor" GroupName="grpPicQuestion35"  ID="rdPicQuestion35_2" runat="server" Text="2" /></td>
                        <td width="50" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton CssClass="cursor" GroupName="grpPicQuestion35"  ID="rdPicQuestion35_1" runat="server" Text="1" /></td>
                        <td width="50" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton CssClass="cursor" GroupName="grpPicQuestion35"  ID="rdPicQuestion35_0" runat="server" Text="0" /></td>
  
                      </tr>
                      <tr>
                          
                        <td width="317" align="left" valign="top"><asp:Label ID="lblPIC36" runat="server" Text="36. Student&#8217;s needs are prioritized to assure that students with the most intensive needs are supported. "></asp:Label></td>
                        
                        <td width="59" align="left" valign="top">&nbsp;</td>
                        <td width="50" align="left" valign="top" ><asp:RadioButton CssClass="cursor" GroupName="grpPicQuestion36"  ID="rdPicQuestion36_2" runat="server" Text="2" /></td>
                        <td width="50" align="left" valign="top" ><asp:RadioButton CssClass="cursor" GroupName="grpPicQuestion36"  ID="rdPicQuestion36_1" runat="server" Text="1" /></td>
                        <td width="50" align="left" valign="top" ><asp:RadioButton CssClass="cursor" GroupName="grpPicQuestion36"  ID="rdPicQuestion36_0" runat="server" Text="0" /></td>
   
                      </tr>
                      <tr>
                          
                        <td width="317" align="left" valign="top" bgcolor="#C8E07F"><asp:Label ID="lblPIC37" runat="server" Text="37. An FBA is conducted that identifies the problem, the events that reliably predict the problem behavior and the consequences that maintain the problem behavior.  "></asp:Label>
                        </td>
                      
                          <td width="59" align="left" valign="top" bgcolor="#C8E07F">&nbsp; 
                          </td>
                        <td width="50" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton CssClass="cursor" GroupName="grpPicQuestion37"  ID="rdPicQuestion37_2" runat="server" Text="2" /></td>
                        <td width="50" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton CssClass="cursor" GroupName="grpPicQuestion37"  ID="rdPicQuestion37_1" runat="server" Text="1" /></td>
                        <td width="50" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton CssClass="cursor" GroupName="grpPicQuestion37"  ID="rdPicQuestion37_0" runat="server" Text="0" /></td>
  
                      </tr>
                      <tr>
                          
                        <td width="317" align="left" valign="top"><asp:Label ID="lblPIC38" runat="server" Text="38. At least 1 hypothesis is developed from the FBA to explain the student&#8217;s problem behavior. "></asp:Label></td>
                        
                        <td width="59" align="left" valign="top">&nbsp;</td>
                        <td width="50" align="left" valign="top" ><asp:RadioButton CssClass="cursor" GroupName="grpPicQuestion38"  ID="rdPicQuestion38_2" runat="server" Text="2" /></td>
                        <td width="50" align="left" valign="top" ><asp:RadioButton CssClass="cursor" GroupName="grpPicQuestion38"  ID="rdPicQuestion38_1" runat="server" Text="1" /></td>
                        <td width="50" align="left" valign="top" ><asp:RadioButton CssClass="cursor" GroupName="grpPicQuestion38"  ID="rdPicQuestion38_0" runat="server" Text="0" /></td>
   
                      </tr>
                      <tr>
                          
                        <td width="317" align="left" valign="top" bgcolor="#C8E07F"><asp:Label ID="lblPIC39" runat="server" Text="39. Tier 3 interventions are matched to the function of the behavior. "></asp:Label></td>
                        
                        <td width="59" align="left" valign="top" bgcolor="#C8E07F">&nbsp;</td>
                        <td width="50" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton CssClass="cursor" GroupName="grpPicQuestion39"  ID="rdPicQuestion39_2" runat="server" Text="2" /></td>
                        <td width="50" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton CssClass="cursor" GroupName="grpPicQuestion39"  ID="rdPicQuestion39_1" runat="server" Text="1" /></td>
                        <td width="50" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton CssClass="cursor" GroupName="grpPicQuestion39"  ID="rdPicQuestion39_0" runat="server" Text="0" /></td>
  
                      </tr>
                      <tr>
                          
                        <td width="317" align="left" valign="top"><asp:Label ID="lblPIC40" runat="server" Text="40. A BIP is developed that includes procedures to prevent problem behaviors, teach appropriate behavior, and reinforce/reward appropriate behavior. "></asp:Label>
                        </td>
                       
                        <td width="59" align="left" valign="top">&nbsp; </td>
                        <td width="50" align="left" valign="top" ><asp:RadioButton CssClass="cursor" GroupName="grpPicQuestion40"  ID="rdPicQuestion40_2" runat="server" Text="2" /></td>
                        <td width="50" align="left" valign="top" ><asp:RadioButton CssClass="cursor" GroupName="grpPicQuestion40"  ID="rdPicQuestion40_1" runat="server" Text="1" /></td>
                        <td width="50" align="left" valign="top" ><asp:RadioButton CssClass="cursor" GroupName="grpPicQuestion40"  ID="rdPicQuestion40_0" runat="server" Text="0" /></td>
   
                      </tr>
                      <tr>
                          
                        <td width="317" align="left" valign="top" bgcolor="#C8E07F"><asp:Label ID="lblPIC41" runat="server" Text="41. Teachers are &#8220;coached&#8221; in how to implement the BIP accurately and effectively. "></asp:Label></td>
                        
                        <td width="59" align="left" valign="top" bgcolor="#C8E07F">&nbsp;</td>
                        <td width="50" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton CssClass="cursor" GroupName="grpPicQuestion41"  ID="rdPicQuestion41_2" runat="server" Text="2" /></td>
                        <td width="50" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton CssClass="cursor" GroupName="grpPicQuestion41"  ID="rdPicQuestion41_1" runat="server" Text="1" /></td>
                        <td width="50" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton CssClass="cursor" GroupName="grpPicQuestion41"  ID="rdPicQuestion41_0" runat="server" Text="0" /></td>
  
                      </tr>
                      <tr>
                          
                        <td width="317" align="left" valign="top"><asp:Label ID="lblPIC42" runat="server" Text="42. The school is checking to make sure that Tier 3 programs are implemented with fidelity. "></asp:Label></td>
                        
                        <td width="59" align="left" valign="top">&nbsp;</td>
                        <td width="50" align="left" valign="top" ><asp:RadioButton CssClass="cursor" GroupName="grpPicQuestion42"  ID="rdPicQuestion42_2" runat="server" Text="2" /></td>
                        <td width="50" align="left" valign="top" ><asp:RadioButton CssClass="cursor" GroupName="grpPicQuestion42"  ID="rdPicQuestion42_1" runat="server" Text="1" /></td>
                        <td width="50" align="left" valign="top" ><asp:RadioButton CssClass="cursor" GroupName="grpPicQuestion42"  ID="rdPicQuestion42_0" runat="server" Text="0" /></td>
   
                      </tr>
                      <tr>
                          
                        <td width="317" align="left" valign="top" bgcolor="#C8E07F"><asp:Label ID="lblPIC43" runat="server" Text="43. A progress monitoring system is in place for all students receiving Tier 3 interventions. "></asp:Label></td>
                        
                        <td width="59" align="left" valign="top" bgcolor="#C8E07F">&nbsp;</td>
                        <td width="50" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton CssClass="cursor" GroupName="grpPicQuestion43"  ID="rdPicQuestion43_2" runat="server" Text="2" /></td>
                        <td width="50" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton CssClass="cursor" GroupName="grpPicQuestion43"  ID="rdPicQuestion43_1" runat="server" Text="1" /></td>
                        <td width="50" align="left" valign="top" bgcolor="#C8E07F"><asp:RadioButton CssClass="cursor" GroupName="grpPicQuestion43"  ID="rdPicQuestion43_0" runat="server" Text="0" /></td>
  
                      </tr>
                      <tr>
                          
                        <td width="317" height="43" align="left" valign="top"><asp:Label ID="lblPIC44" runat="server" Text="44. The school team makes decisions on students&#8217; response to intervention from the progress monitoring system. "></asp:Label>
                        </td>
                        
                        <td width="59" align="left" valign="top">&nbsp;</td>
                        <td width="50" align="left" valign="top" ><asp:RadioButton CssClass="cursor" GroupName="grpPicQuestion44"  ID="rdPicQuestion44_2" runat="server" Text="2" /></td>
                        <td width="50" align="left" valign="top" ><asp:RadioButton CssClass="cursor" GroupName="grpPicQuestion44"  ID="rdPicQuestion44_1" runat="server" Text="1" /></td>
                        <td width="50" align="left" valign="top" ><asp:RadioButton CssClass="cursor" GroupName="grpPicQuestion44"  ID="rdPicQuestion44_0" runat="server" Text="0" /></td>
   
                      </tr>
                   
                    </table>
                  
                  <br />
               
                               
                  <P align="center"><span class="contentText"><a HREF="javascript:window.print()">CLICK HERE TO PRINT THE FORM <strong>BEFORE</strong> SUBMITTING!!</a></span><a HREF="javascript:window.print()"></a>
                  <p align="center">
                  <asp:Button ID="btnsubmit" Text="Submit" runat="server" BackColor="Beige" BorderColor="#C8E07F" BorderWidth="3" OnClientClick="return checkformPIC('Form1');" />
                   
                    <br>
                    <br>                  
                  </td>
                <td>&nbsp;</td>
              </tr>
          </table></td>
          <td width="6" background="../images/bounding-box-line-right-sid.gif">&nbsp;</td>
        </tr>
    </table>
        </td>
    </tr>
</asp:Content>