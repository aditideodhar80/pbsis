<%@ Page Language="VB" MasterPageFile="~/pbsmaster/Detail.master"  AutoEventWireup="false" CodeFile="school_BAT_Add.aspx.vb" Inherits="school_school_BAT_Add" %>

<asp:Content ID ="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style type="text/css">
<!--
body,td,th {
	font-family: Arial, Helvetica, sans-serif;
	font-size: small;
}
        .style7
        {
            height: 20px;
        }
-->
</style>

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
        
        .style4 {color: #7BA400; font-weight: bold; font-size: 14px; }
        .style8
        {
            width: 67px;
        }
        -->
</style>
<tr>
    <td>
            <table width="750" border="0" cellpadding="2" cellspacing="0" >
             <tr>
                              <td colspan="2" align="left" valign="top"><span class="style4"><font face="Arial, Helvetica, sans-serif">&nbsp;Benchmarks for Advanced Tiers</font></span><font face="Arial, Helvetica, sans-serif" size=-1><span class="style2">&nbsp; </span></font> </td> 
                            </tr>
                            <tr>
                                <td>&nbsp</td>
                            </tr>
              
              
              
                                            <tr>
                                                <td align="left" valign="top"> &nbsp; School Name:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Label Font-Size="Small" Font-Bold="true" id="lblSchoolName" runat="server"></asp:Label></td>
                                                
                                            </tr>
                                        <tr>
                                <td align="left" valign="top">&nbsp;</td> 
                              <td align="left" valign="top">&nbsp;</td>
                            </tr>
                                 
                                  <tr>
                                    <td align="left" valign="top">&nbsp; School Year:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Label Font-Size="Small" Font-Bold="true"  ID="lblSchoolYr" runat="server"></asp:Label></td>
                                  </tr>
                                    <tr>
                                <td align="left" valign="top">&nbsp;</td> 
                              <td align="left" valign="top">&nbsp;</td>
                            </tr>
                                  <tr>
                                  <td align="left" valign="top"> &nbsp; District Name:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Label Font-Size="Small" Font-Bold="true"  id="lblDistrict" runat="server"></asp:Label></td>
                                  </tr>
                                    <tr>
                                <td align="left" valign="top">&nbsp;</td> 
                              <td align="left" valign="top">&nbsp;</td>
                            </tr>
                                  <tr>
                                    <td align="left" valign="top">&nbsp; Coach Name:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:DropDownList ID="ddlcoach" runat="server">
                                     </asp:DropDownList>
							         </td>
                                  </tr>
                                  <tr>
                                <td align="left" valign="top">&nbsp;</td> 
                              <td align="left" valign="top">&nbsp;</td>
                            </tr>
                                      <tr>
                                    <td align="left" valign="top">&nbsp; Team Leader or<br />
&nbsp; Coordinator:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:TextBox ID="txtTLeader" runat="server" MaxLength="500" Width="200" TextMode="SingleLine" Rows="4"> </asp:TextBox>
                                    </td>
                                  </tr>
                                  <tr>
                                    <td>&nbsp;</td>
                                  </tr>
                                  <tr>
                                  
                                  
                                  
                                  <td>
                                  
                                    <table>
                                        <tr>
                                            <td style="width:17%" class="style8">&nbsp; Team Members
                                        <br />
&nbsp; with school&nbsp; position</td>
                                            <td> <asp:TextBox ID="txtTMembers" runat="server" MaxLength="1000"  style="width: 502px; height: 52px" TextMode="MultiLine" Rows="4"> </asp:TextBox></td>
                                        </tr>
                                    </table>
                                    
                                  </td>
                                   
                                  </tr>
                                  <tr>
                                    <td>&nbsp;</td>
                                  </tr>
                           
            
                <%--TABLE G END--%>
                <tr>
                    <td>
                        <table width="100%" border="1" cellpadding="4" cellspacing="0" bordercolor="#000000"  >
                        
                        
                            <tr>
                                <%--<td style="width:5%">&nbsp;</td>--%>  
                                <td style="width:29%" align="left"><asp:Label Font-Bold="true" ID="lblA" Font-Size="Large" runat="server" Text="A"></asp:Label>&nbsp;&nbsp;<asp:Label Font-Bold="true" ID="lblA1" runat="server" Text="Tier 1: Implementation of School-wide PBS"></asp:Label></td>
                                <td style="width:22%" align="center"><asp:Label Font-Bold="true" ID="lblA2" runat="server" Text="2-Fully in Place"></asp:Label></td>
                                <td style="width:22%" align="center"><asp:Label Font-Bold="true" ID="lblA3" runat="server" Text="1-Partially in Place"></asp:Label></td>
                                <td style="width:22%" align="center"> <asp:Label Font-Bold="true" ID="lblA4" runat="server" Text="0-Not Yet Started"></asp:Label></td>
                            </tr>
                           
                             <tr>
                               <%-- <td bgcolor="#C8E07F">&nbsp;</td>--%>
                                <td bgcolor="#C8E07F" colspan="4">
<!--
body,td,th {
	font-family: Arial, Helvetica, sans-serif;
	font-size: small;
}
        .style5
        {
            width: 5%;
        }
        .style6
        {
            width: 25%;
        }
--><asp:Label  ID="lbl1_2" runat="server" 
                                        
                                        Text="1.	School-wide PBS, Tier 1/Universal intervention is in place as measured by scores on the SET, BoQ, TIC, or Bat."></asp:Label></td>
                            </tr>
                            
                             <tr>
                               <%-- <td bgcolor="#C8E07F">&nbsp;</td>--%>
                                <td bgcolor="#C8E07F">&nbsp;</td>
                                <td bgcolor="#C8E07F" valign="top" align="left" colspan="3">
                                    <asp:RadioButton GroupName="grp1" ID="radio1_4" runat="server" 
                                        Text="2- 80%/80% on SET 70% on BoQ 80% on TIC or Bat" /></td>
                            </tr>
                            
                             <tr>
                                <%--<td bgcolor="#C8E07F">&nbsp;</td>--%>
                                <td bgcolor="#C8E07F">&nbsp;</td>
                                <td bgcolor="#C8E07F" valign="top" align="left" colspan="3">
                                  <asp:RadioButton GroupName="grp1" ID="radio1_5" runat="server" 
                                      Text="1- Score greater than 40% on any of these measures" /></td>
                            </tr>
                            
                             <tr>
                                <%--<td bgcolor="#C8E07F">&nbsp;</td>--%>
                                <td bgcolor="#C8E07F">&nbsp;</td>
                                <td bgcolor="#C8E07F" valign="top" align="left" colspan="3">
                                    <asp:RadioButton GroupName="grp1" 
                                        ID="radio1_6" runat="server" 
                                        Text="0- Score equal to or less than 40% on any of these measures" /></td>
                            </tr>
                            
                           <tr>
                              <%--  <td>&nbsp;</td>--%>
                                <td colspan="4"><asp:Label  ID="lbl2_2" runat="server" 
                                        
                                        Text="2.	Team members agree that school-wide PBS is in place and is implemented consistently by teachers and staff."></asp:Label></td>
                            </tr>
                            
                           <tr>
                               <%-- <td>&nbsp;</td>--%>
                                <td>&nbsp;</td>
                                <td valign="top" align="left" colspan="3"><asp:RadioButton GroupName="grp2" ID="radio2_4" 
                                        runat="server" 
                                        
                                        
                                        Text="2- Team members agree that school-wide PBS is in place and is implemented consistently by over 80% of all teachers and staff." /></td>
                            </tr>
                            
                           <tr>
                              <%--  <td>&nbsp;</td>--%>
                                <td>&nbsp;</td>
                                <td valign="top" align="left" colspan="3"><asp:RadioButton GroupName="grp2" ID="radio2_5" 
                                      runat="server" 
                                      
                                      
                                        Text="1- Team members state that school-wide PBS is implemented consistently by 50-80% of teachers and staff" /></td>
                            </tr>
                            
                           <tr>
                               <%-- <td>&nbsp;</td>--%>
                                <td>&nbsp;</td>
                                <td valign="top" align="left" colspan="3"><asp:RadioButton GroupName="grp2" ID="radio2_6" 
                                        runat="server" 
                                        
                                        
                                        Text="0- Team members state that school-wide PBS is implemented consistently by less than 50% of staff." /></td>
                            </tr>
                            
                            <tr>
                               <%-- <td bgcolor="#C8E07F">&nbsp;</td>--%>
                                <td bgcolor="#C8E07F" colspan="4"><asp:Label  ID="lbl3_2" runat="server" 
                                        
                                        Text="3.	A data system is in place for documenting office discipline referrals that includes (a) problem behavior, (b) time of day, (c) location, (d) possible motivation, (e) others involved, and (f) administrative decision taken as a result of the problem behavior."></asp:Label></td>
                            </tr>
                            
                            <tr>
                               <%-- <td bgcolor="#C8E07F">&nbsp;</td>--%>
                                <td bgcolor="#C8E07F">&nbsp;</td>
                                <td bgcolor="#C8E07F" valign="top" align="left" colspan="3">
                                    <asp:RadioButton GroupName="grp3" ID="radio3_4" runat="server" 
                                        Text="2- The system includes all 6 features." /></td>
                            </tr>
                            
                            <tr>
                                <%--<td bgcolor="#C8E07F">&nbsp;</td>--%>
                                <td bgcolor="#C8E07F">&nbsp;</td>
                                <td bgcolor="#C8E07F" valign="top" align="left" colspan="3">
                                  <asp:RadioButton GroupName="grp3" ID="radio3_5" runat="server" 
                                      Text="1- The system includes 4-5 features." /></td>
                            </tr>
                            
                            <tr>
                               <%-- <td bgcolor="#C8E07F">&nbsp;</td>--%>
                                <td bgcolor="#C8E07F">&nbsp;</td>
                                <td bgcolor="#C8E07F" valign="top" align="left" colspan="3">
                                    <asp:RadioButton GroupName="grp3" ID="radio3_6" runat="server" 
                                        Text="0- The system includes 3 or fewer features or is not in place." /></td>
                            </tr>
                            
                        </table>
                    </td>
                </tr>
                <%--TABLE G START--%> <%--TABLE G END--%>
             
               <tr>
                    <td>
                        <table width="100%" border="1" cellpadding="4" cellspacing="0" bordercolor="#000000"  >
                        <tr>
                                <td colspan="2"><asp:Label Font-Size="Small" Font-Underline="true" Font-Bold="true" ID="lblTier23foundation" runat="server" Text="Tier 2-3 : Foundation"></asp:Label></td>
                                <td style="width:28%" align="center"></td>
                                <td></td>
                                <%--<td></td>--%>
                            </tr>
                            <tr>
   <%--                             <td style="width:5%">&nbsp;</td> --%> 
                                <td style="width:29%" align="left"><asp:Label Font-Bold="true" ID="lblB" Font-Size="Large" runat="server" Text="B"></asp:Label>&nbsp;&nbsp;<asp:Label Font-Bold="true" ID="lblB1" runat="server" Text="Commitment"></asp:Label></td>
                                <td style="width:22%" align="center"><asp:Label Font-Bold="true" ID="lblB2" runat="server" Text="2-Fully in Place"></asp:Label></td>
                                <td style="width:22%" align="center"><asp:Label Font-Bold="true" ID="lblB3" runat="server" Text="1-Partially in Place"></asp:Label></td>
                                <td style="width:22%" align="center"> <asp:Label Font-Bold="true" ID="lblB4" runat="server" Text="0-Not Yet Started"></asp:Label></td>
                            </tr>
                           
                             <tr>
                               <%-- <td bgcolor="#C8E07F">&nbsp;</td>--%>
                                <td bgcolor="#C8E07F" colspan="4"><asp:Label  ID="lbl4_2" runat="server" 
                                        
                                        Text="4.	There is crossover membership and/or communication that informs the Tier 1 team of the status of Tier 2 and Tier 3 supports"></asp:Label></td>
                            </tr>
                            
                             <tr>
                                <%--<td bgcolor="#C8E07F">&nbsp;</td>--%>
                                <td bgcolor="#C8E07F">&nbsp;</td>
                                <td bgcolor="#C8E07F" valign="top" align="left" colspan="3">
                                    <asp:RadioButton GroupName="grp4" ID="radio4_4" runat="server" 
                                        
                                        
                                        
                                        Text="2- Tier 1 team is aware of the number of students, fidelity, and progress of students receiving Tier 2 and Tier 3 supports." /></td>
                            </tr>
                            
                             <tr>
                                <%--<td bgcolor="#C8E07F">&nbsp;</td>--%>
                                <td bgcolor="#C8E07F">&nbsp;</td>
                                <td bgcolor="#C8E07F" valign="top" align="left" colspan="3">
                                  <asp:RadioButton GroupName="grp4" ID="radio4_5" runat="server" 
                                      Text="1- Tier 1 team is aware of one or two components, but not all three." /></td>
                            </tr>
                            
                             <tr>
                                <%--<td bgcolor="#C8E07F">&nbsp;</td>--%>
                                <td bgcolor="#C8E07F">&nbsp;</td>
                                <td bgcolor="#C8E07F" valign="top" align="left" colspan="3">
                                    <asp:RadioButton GroupName="grp4" 
                                        ID="radio4_6" runat="server" 
                                        
                                        
                                        
                                        Text="0- Tier 1 team is unaware of the number of students, fidelity, and progress of students receiving Tier 2 and Tier 3 supports.  " /></td>
                            </tr>
                            
                           <tr>
                                <%--<td>&nbsp;</td>--%>
                                <td colspan="4"><asp:Label  ID="lbl5_2" runat="server" 
                                        
                                        
                                        Text="5.	 A team/individual makes decisions about students receiving Tier 2 and Tier 3 supports."></asp:Label></td>
                            </tr>
                            
                           <tr>
                                <%--<td>&nbsp;</td>--%>
                                <td>&nbsp;</td>
                                <td valign="top" align="left" colspan="3"><asp:RadioButton GroupName="grp5" ID="radio5_4" 
                                        runat="server" 
                                        
                                        
                                        
                                        Text="2- A team/individual makes decisions about students receiving Tier 2 and Tier 3 supports (who should receive what support)." /></td>
                            </tr>
                            
                           <tr>
                               <%-- <td>&nbsp;</td>--%>
                                <td>&nbsp;</td>
                                <td valign="top" align="left" colspan="3"><asp:RadioButton GroupName="grp5" ID="radio5_5" 
                                      runat="server" 
                                      
                                      
                                      
                                        Text="1- Decisions are made regarding Tier 2 and 3 supports but not formally or consistently." /></td>
                            </tr>
                            
                           <tr>
                                <%--<td>&nbsp;</td>--%>
                                <td>&nbsp;</td>
                                <td valign="top" align="left" colspan="3"><asp:RadioButton GroupName="grp5" ID="radio5_6" 
                                        runat="server" 
                                        
                                        
                                        
                                        Text="0- No team/individual is established to determine Tier 2 and Tier 3 support for students." /></td>
                            </tr>
                            <tr>
                               <%-- <td bgcolor="#C8E07F">&nbsp;</td>--%>
                                <td bgcolor="#C8E07F" colspan="4"><asp:Label  ID="lbl6_2" runat="server" 
                                        
                                        
                                        Text="6.	The number of students, program fidelity, and progress of students receiving Tier 2 and Tier 3 supports is reported to faculty."></asp:Label></td>
                            </tr>
                            
                            <tr>
                                <%--<td bgcolor="#C8E07F">&nbsp;</td>--%>
                                <td bgcolor="#C8E07F">&nbsp;</td>
                                <td bgcolor="#C8E07F" valign="top" align="left" colspan="3">
                                    <asp:RadioButton GroupName="grp6" ID="radio6_4" runat="server" 
                                        
                                        
                                        
                                        Text="2- The number of students, program fidelity, and progress of students is reported to faculty at least quarterly." /></td>
                            </tr>
                            
                            <tr>
                                <%--<td bgcolor="#C8E07F">&nbsp;</td>--%>
                                <td bgcolor="#C8E07F">&nbsp;</td>
                                <td bgcolor="#C8E07F" valign="top" align="left" colspan="3">
                                  <asp:RadioButton GroupName="grp6" ID="radio6_5" runat="server" 
                                      Text="1- The system includes 4-5 features." /></td>
                            </tr>
                            
                            <tr>
                               <%-- <td bgcolor="#C8E07F">&nbsp;</td>--%>
                                <td bgcolor="#C8E07F">&nbsp;</td>
                                <td bgcolor="#C8E07F" valign="top" align="left" colspan="3">
                                    <asp:RadioButton GroupName="grp6" ID="radio6_6" runat="server" 
                                        Text="0- The system includes 3 or fewer features or is not in place." /></td>
                            </tr>
                            
                        </table>
                    </td>
                </tr>
             
                <%--TABLE G START--%> <%--TABLE G END--%>
                          
                         <tr>
                    <td>
                        <table width="100%" border="1" cellpadding="4" cellspacing="0" bordercolor="#000000"  >
                            <tr>
                               <%-- <td style="width:5%"><asp:Label Font-Bold="True" ID="lblC" Font-Size="Large" 
                                        runat="server" Text="C"></asp:Label></td>  --%>
                                <td style="width:29%" align="left"><asp:Label Font-Bold="True" ID="lblC" Font-Size="Large" 
                                        runat="server" Text="C"></asp:Label>&nbsp;&nbsp;<asp:Label Font-Bold="True" ID="lblC1" 
                                        runat="server" Text="Student Identification"></asp:Label></td>
                                <td style="width:22%" align="center"><asp:Label Font-Bold="True" ID="lblC2" 
                                        runat="server" Text="2-Fully in Place"></asp:Label></td>
                                <td style="width:22%" align="center"><asp:Label Font-Bold="True" ID="lblC3" 
                                        runat="server" Text="1-Partially in Place"></asp:Label></td>
                                <td style="width:22%" align="center"> <asp:Label Font-Bold="True" ID="lblC4" 
                                        runat="server" Text="0-Not Yet Started"></asp:Label></td>
                                
                            </tr>
                            <tr>
                                <%--<td>&nbsp;</td>--%>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            
                             <tr>
                                <%--<td bgcolor="#C8E07F">&nbsp;</td>--%>
                                <td bgcolor="#C8E07F" colspan="4"><asp:Label  ID="lbl7_2" runat="server" 
                                        
                                        
                                        Text="7.	The school uses a data-based process for identifying students who may need Tier 2 and Tier 3 supports. &#61690; Screening        &#61690; ODRs      &#61690; Request for Assistance"></asp:Label></td>
                               
                            </tr>
                            
                             <tr>
                                <%--<td bgcolor="#C8E07F">&nbsp;</td>--%>
                                <td bgcolor="#C8E07F">&nbsp;</td>
                                <td bgcolor="#C8E07F" valign="top" align="left" colspan="3">
                                    <asp:RadioButton GroupName="grp7" ID="radio7_4" runat="server" 
                                        
                                        
                                        
                                        
                                        Text="2- At least 2 data sources are used to identify students for Tier 2 and Tier 3 supports at least twice a year." /></td>
                               
                            </tr>
                            
                             <tr>
                                <%--<td bgcolor="#C8E07F">&nbsp;</td>--%>
                                <td bgcolor="#C8E07F">&nbsp;</td>
                                <td bgcolor="#C8E07F" valign="top" align="left" colspan="3">
                                  <asp:RadioButton GroupName="grp7" ID="radio7_5" runat="server" 
                                      
                                      
                                      
                                      
                                        Text="1- 1 data source is used to identify students for Tier 2 and Tier 3 supports and/or data are used less than twice a year." /></td>
                               
                            </tr>
                            
                             <tr>
                                <%--<td bgcolor="#C8E07F">&nbsp;</td>--%>
                                <td bgcolor="#C8E07F">&nbsp;</td>
                                <td bgcolor="#C8E07F" valign="top" align="left" colspan="3">
                                    <asp:RadioButton GroupName="grp7" 
                                        ID="radio7_6" runat="server" 
                                        
                                        
                                        
                                        
                                        Text="0- Data sources are rarely used to identify students for Tier 2 and Tier 3 supports." /></td>
                               
                            </tr>
                            
                           <tr>
                               <%-- <td>&nbsp;</td>--%>
                                <td colspan="4"><asp:Label  ID="lbl8_2" runat="server" 
                                        
                                        
                                        
                                        Text="8. All school staff have been trained in and know the process for requesting Tier 2 and Tier 3 support for students"></asp:Label></td>
                                
                            </tr>
                            
                           <tr>
                                <%--<td>&nbsp;</td>--%>
                                <td>&nbsp;</td>
                                <td valign="top" align="left" colspan="3">
                                    <asp:RadioButton GroupName="grp8" ID="radio8_4" 
                                        runat="server" 
                                        Text="2- A documented process exists and staff are trained." /></td>
                                
                            </tr>
                            
                           <tr>
                               <%-- <td>&nbsp;</td>--%>
                                <td>&nbsp;</td>
                                <td valign="top" align="left" colspan="3">
                                  <asp:RadioButton GroupName="grp8" ID="radio8_5" 
                                      runat="server" 
                                      Text="1- A documented process exists but staff are not trained." /></td>
                                
                            </tr>
                            
                           <tr>
                               <%-- <td>&nbsp;</td>--%>
                                <td>&nbsp;</td>
                                <td valign="top" align="left" colspan="3">
                                    <asp:RadioButton GroupName="grp8" ID="radio8_6" 
                                        runat="server" 
                                        Text="0- The process is informal or does not exist." /></td>
                                
                            </tr>
                            <tr>
                               <%-- <td bgcolor="#C8E07F">&nbsp;</td>--%>
                                <td bgcolor="#C8E07F" colspan="4"><asp:Label  ID="lb9_2" runat="server" 
                                        
                                        
                                        
                                        Text="9.	Decisions about whether students get additional behavior support are made in a timely manner and staff are notified of decisions."></asp:Label></td>
                                
                            </tr>
                            <tr>
                              <%--  <td bgcolor="#C8E07F" class="style7"></td>--%>
                                <td bgcolor="#C8E07F" class="style7"></td>
                                <td bgcolor="#C8E07F" valign="top" align="left" class="style7" colspan="3">
                                    <asp:RadioButton GroupName="grp9" ID="radio9_4" runat="server" 
                                        
                                        
                                        
                                        
                                        Text="2- Staff are notified of a decision within 10 days of making a referral." /></td>
                                
                            </tr>
                            <tr>
                               <%-- <td bgcolor="#C8E07F">&nbsp;</td>--%>
                                <td bgcolor="#C8E07F">&nbsp;</td>
                                <td bgcolor="#C8E07F" valign="top" align="left" colspan="3">
                                  <asp:RadioButton GroupName="grp9" ID="radio9_5" runat="server" 
                                      Text="1- Staff are notified of a decision, but not within 10 days." /></td>
                                
                            </tr>
                            <tr>
                                <%--<td bgcolor="#C8E07F">&nbsp;</td>--%>
                                <td bgcolor="#C8E07F">&nbsp;</td>
                                <td bgcolor="#C8E07F" valign="top" align="left" colspan="3">
                                    <asp:RadioButton GroupName="grp9" ID="radio9_6" runat="server" 
                                        Text="0- Staff do not receive notification or receive it inconsistently." /></td>
                                
                            </tr>
                             <tr>
                               <%-- <td>&nbsp;</td>--%>
                                <td colspan="4">
                                    <asp:Label  ID="lbl10_2" runat="server" 
                                        
                                        Text="10.	Students receive support in a timely manner."></asp:Label></td>
                                
                            </tr>
                             <tr>
                               <%-- <td>&nbsp;</td>--%>
                                <td>&nbsp;</td>
                                <td align="left" colspan="3">
                                    <asp:RadioButton GroupName="grp10" ID="radio10_4" runat="server" 
                                        
                                        Text="2- Students begin receiving supports within 30 days of referral." /></td>
                                
                            </tr>
                             <tr>
                              <%--  <td>&nbsp;</td>--%>
                                <td>&nbsp;</td>
                                <td align="left" colspan="3">
                                  <asp:RadioButton GroupName="grp10" ID="radio10_5" runat="server" 
                                      Text="1- Students begin receiving supports, but not within 30 days." /></td>
                                
                            </tr>
                             <tr>
                               <%-- <td>&nbsp;</td>--%>
                                <td>&nbsp;</td>
                                <td align="left" colspan="3">
                                    <asp:RadioButton GroupName="grp10" ID="radio10_6" runat="server" 
                                        Text="0- Students do not receive support or receive it inconsistently." /></td>
                                
                            </tr>
                        </table>
                    </td>
                </tr>   
                <%--TABLE G START--%> <%--TABLE G END--%>
                    <tr>
                    <td>
                        <table width="100%" border="1" cellpadding="4" cellspacing="0" bordercolor="#000000"  >
                            <tr>
                              <%--  <td bgcolor="#C8E07F" class="style5"><asp:Label Font-Bold="True" ID="lblD" Font-Size="Large" 
                                        runat="server" Text="D"></asp:Label></td>  --%>
                                <td bgcolor="#C8E07F" style="width:29%" align="left"><asp:Label Font-Bold="True" ID="lblD" Font-Size="Large" 
                                        runat="server" Text="D"></asp:Label>&nbsp;&nbsp;
                                    <asp:Label Font-Bold="True" ID="lblD1" 
                                        runat="server" Text="Monitoring and Evaluation"></asp:Label></td>
                                <td bgcolor="#C8E07F" style="width:22%" align="center">
                                    <asp:Label Font-Bold="True" ID="lblD2" 
                                        runat="server" Text="2-Fully in Place"></asp:Label></td>
                                <td bgcolor="#C8E07F" style="width:22%" align="center">
                                    <asp:Label Font-Bold="True" ID="lblD3" 
                                        runat="server" Text="1-Partially in Place"></asp:Label></td>
                                <td bgcolor="#C8E07F" style="width:22%" align="center"> 
                                    <asp:Label Font-Bold="True" ID="lblD4" 
                                        runat="server" Text="0-Not Yet Started"></asp:Label></td>
                            </tr>
                            <tr>
                                <%--<td bgcolor="#C8E07F" class="style5">&nbsp;</td>--%>
                                <td bgcolor="#C8E07F">&nbsp;</td>
                                <td bgcolor="#C8E07F">&nbsp;</td>
                                <td bgcolor="#C8E07F">&nbsp;</td>
                                <td bgcolor="#C8E07F">&nbsp;</td>
                            </tr>
                            
                             <tr>
                               <%-- <td class="style5" >&nbsp;</td>--%>
                                <td colspan="4" ><asp:Label  ID="lbl11_2" runat="server" 
                                        
                                        
                                        
                                        Text="11.	The teacher(s) directly involved with students receiving Tier 2 and Tier 3 supports are notified about impact and changes to strategies."></asp:Label></td>
                            </tr>
                            
                             <tr>
                              <%--  <td class="style5" >&nbsp;</td>--%>
                                <td >&nbsp;</td>
                                <td  valign="top" align="left" colspan="3">
                                    <asp:RadioButton GroupName="grp11" ID="radio11_6" runat="server" 
                                        
                                        
                                        
                                        
                                        
                                        Text="2- Teachers directly involved with Tier 2 and 3 supports are notified about changes to strategies immediately and the impact, weekly." /></td>
                            </tr>
                            
                             <tr>
                                <%--<td class="style5" >&nbsp;</td>--%>
                                <td >&nbsp;</td>
                                <td  valign="top" align="left" colspan="3">
                                  <asp:RadioButton GroupName="grp11" ID="radio11_5" runat="server" 
                                      
                                      
                                      
                                      
                                      
                                        Text="1- Teachers directly involved with Tier 2 and 3 supports are notified about changes to strategies and impact less than weekly. " /></td>
                            </tr>
                            
                             <tr>
<%--                                <td class="style5" >&nbsp;</td>
--%>                                <td >&nbsp;</td>
                                <td  valign="top" align="left" colspan="3">
                                    <asp:RadioButton GroupName="grp11" 
                                        ID="radio11_4" runat="server" 
                                        
                                        
                                        
                                        
                                        
                                        Text="0- Teachers directly involved with Tier 2 and 3 supports do not receive notification about impact and changes to strategies." /></td>
                            </tr>
                            
                           <tr>
                                <%--<td bgcolor="#C8E07F" class="style5">&nbsp;</td>--%>
                                <td bgcolor="#C8E07F" colspan="4">
                                    <asp:Label  ID="lbl12_2" runat="server" 
                                        
                                        
                                        
                                        
                                        Text="12.	The primary family members of students receiving Tier 2 and 3 supports are notified about impact and changes to strategies"></asp:Label></td>
                            </tr>
                          
                           <tr>
                               <%-- <td bgcolor="#C8E07F" class="style5">&nbsp;</td>--%>
                                <td bgcolor="#C8E07F">
                                    &nbsp;</td>
                                <td bgcolor="#C8E07F" valign="top" align="left" colspan="3">
                                    <asp:RadioButton GroupName="grp12" ID="radio12_4" 
                                        runat="server" 
                                        
                                        
                                        
                                        Text="2- Family members are notified about changes to strategies immediately and the impact, weekly." /></td>
                            </tr>
                          
                           <tr>
                                <%--<td bgcolor="#C8E07F" class="style5">&nbsp;</td>--%>
                                <td bgcolor="#C8E07F">
                                    &nbsp;</td>
                                <td bgcolor="#C8E07F" valign="top" align="left" colspan="3">
                                  <asp:RadioButton GroupName="grp12" ID="radio12_5" 
                                      runat="server" 
                                      
                                      
                                      
                                        Text="1- Family members are notified about changes to strategies and impact less than weekly. " /></td>
                            </tr>
                          
                           <tr>
                              <%--  <td bgcolor="#C8E07F" class="style5">&nbsp;</td>--%>
                                <td bgcolor="#C8E07F">
                                    &nbsp;</td>
                                <td bgcolor="#C8E07F" valign="top" align="left" colspan="3">
                                    <asp:RadioButton GroupName="grp12" ID="radio12_6" 
                                        runat="server" 
                                        
                                        
                                        Text="0- Family members do not receive notification about impact and changes to strategies." /></td>
                            </tr>
                          
                        </table>
                    </td>
                </tr>   
             
                <%--TABLE G START--%>               <%--TABLE G END--%>
                 
                   <tr>
                    <td title="17.	Tier 2 strategies are evaluated and updated regularly.">
                        <table width="100%" border="1" cellpadding="4" cellspacing="0" bordercolor="#000000">
                        
                                   <tr>
                                <td colspan="2"><asp:Label Font-Size="Small" Font-Underline="true" Font-Bold="true" ID="lblTier2TarInt" runat="server" Text="Tier 2: Targeted Interventions"></asp:Label></td>
                                <td style="width:28%" align="center"></td>
                                <td></td>
                                <%--<td></td>--%>
                            </tr>
                            
                            
                            <tr>
                                <%--<td  style="width:5%"><asp:Label Font-Bold="True" ID="lblE" Font-Size="Large" 
                                        runat="server" Text="E"></asp:Label></td>  --%>
                                <td  style="width:29%" align="left"><asp:Label Font-Bold="True" ID="lblE" Font-Size="Large" 
                                        runat="server" Text="E"></asp:Label>&nbsp;&nbsp;
                                    <asp:Label Font-Bold="True" ID="lblE1" 
                                        runat="server" Text="Tier 2: Support Systems"></asp:Label></td>
                                <td  style="width:22%" align="center">
                                    <asp:Label Font-Bold="True" ID="lblE2" 
                                        runat="server" Text="2-Fully in Place"></asp:Label></td>
                                <td  style="width:22%" align="center">
                                    <asp:Label Font-Bold="True" ID="lblE3" 
                                        runat="server" Text="1-Partially in Place"></asp:Label></td>
                                <td  style="width:22%" align="center"> 
                                    <asp:Label Font-Bold="True" ID="lblE4" 
                                        runat="server" Text="0-Not Yet Started"></asp:Label></td>
                            </tr>
                            <tr>
                               <%-- <td >&nbsp;</td>--%>
                                <td >&nbsp;</td>
                                <td >&nbsp;</td>
                                <td >&nbsp;</td>
                                <td >&nbsp;</td>
                            </tr>
                            
                             <tr>
                               <%-- <td bgcolor="#C8E07F" >&nbsp;</td>--%>
                                <td bgcolor="#C8E07F" colspan="4"><asp:Label  ID="lbl13_2" runat="server" 
                                        
                                        
                                        
                                        
                                        Text="13.	The administrator is updated about which students receive Tier 2 supports."></asp:Label></td>
                            </tr>
                            
                             <tr>
                               <%-- <td bgcolor="#C8E07F" >&nbsp;</td>--%>
                                <td bgcolor="#C8E07F">&nbsp;</td>
                                <td bgcolor="#C8E07F" valign="top" align="left" colspan="3">
                                    <asp:RadioButton GroupName="grp13" ID="radio13_6" runat="server" 
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        Text="2- The administrator is informed at least monthly about which students are receiving Tier 2 supports." /></td>
                            </tr>
                            
                             <tr>
                              <%--  <td bgcolor="#C8E07F" >&nbsp;</td>--%>
                                <td bgcolor="#C8E07F">&nbsp;</td>
                                <td bgcolor="#C8E07F" valign="top" align="left" colspan="3">
                                  <asp:RadioButton GroupName="grp13" ID="radio13_5" runat="server" 
                                      
                                      
                                      
                                      
                                      
                                      
                                      
                                      
                                        Text="1- There is not a consistent way to provide this information, even if she/he is aware of the students on Tier 2 interventions." /></td>
                            </tr>
                            
                             <tr>
                               <%-- <td bgcolor="#C8E07F" >&nbsp;</td>--%>
                                <td bgcolor="#C8E07F">&nbsp;</td>
                                <td bgcolor="#C8E07F" valign="top" align="left" colspan="3">
                                    <asp:RadioButton GroupName="grp13" 
                                        ID="radio13_4" runat="server" 
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        Text="0- The administrator is not informed about which students are receiving Tier 2 supports." /></td>
                            </tr>
                            
                           <tr>
                               <%-- <td >&nbsp;</td>--%>
                                <td colspan="4" >
                                    <asp:Label  ID="lbl14_2" runat="server" 
                                        
                                        
                                        
                                        Text="14.	The Tier 2 team meets frequently."></asp:Label></td>
                            </tr>
                            
                           <tr>
                              <%--  <td >&nbsp;</td>--%>
                                <td >
                                    &nbsp;</td>
                                <td valign="top" align="left" colspan="3">
                                    <asp:RadioButton GroupName="grp14" ID="radio14_6" 
                                        runat="server" 
                                        
                                        
                                        Text="2- A team meets at least every 2 weeks." /></td>
                            </tr>
                            
                           <tr>
                               <%-- <td >&nbsp;</td>--%>
                                <td >
                                    &nbsp;</td>
                                <td valign="top" align="left" colspan="3">
                                  <asp:RadioButton GroupName="grp14" ID="radio14_5" 
                                      runat="server" 
                                      
                                      
                                      Text="1- A team meets at least monthly." /></td>
                            </tr>
                            
                           <tr>
                              <%--  <td >&nbsp;</td>--%>
                                <td >
                                    &nbsp;</td>
                                <td valign="top" align="left" colspan="3">
                                    <asp:RadioButton GroupName="grp14" ID="radio14_4" 
                                        runat="server" 
                                        
                                        Text="0- A team meets, but less than monthly, or a team does not meet." /></td>
                            </tr>
                            
                              <tr>
                               <%-- <td bgcolor="#C8E07F" >&nbsp;</td>--%>
                                <td bgcolor="#C8E07F" colspan="4"><asp:Label  ID="lbl15_2" runat="server" 
                                        
                                        
                                        
                                        
                                        
                                        
                                        Text="15.	The Tier 2 team is formally trained on practices and systems required for implementation of Tier 2 support."></asp:Label></td>
                            </tr>
                            
                              <tr>
                               <%-- <td bgcolor="#C8E07F" >&nbsp;</td>--%>
                                <td bgcolor="#C8E07F">&nbsp;</td>
                                <td bgcolor="#C8E07F" valign="top" align="left" colspan="3">
                                    <asp:RadioButton GroupName="grp15" ID="radio15_6" runat="server" 
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        Text="2- 50% or more of members on Tier 2 team have received training on the interventions, the systems needed for implementation, and progress monitoring tools." /></td>
                            </tr>
                            
                              <tr>
                               <%-- <td bgcolor="#C8E07F" >&nbsp;</td>--%>
                                <td bgcolor="#C8E07F">&nbsp;</td>
                                <td bgcolor="#C8E07F" valign="top" align="left" colspan="3">
                                  <asp:RadioButton GroupName="grp15" ID="radio15_5" runat="server" 
                                      
                                      
                                      
                                      
                                      
                                      
                                      
                                      
                                      
                                        Text="1- Some, but less than 50%, of members on the Tier 2 team received training on the interventions, the systems needed for implementation, and progress monitoring tools." /></td>
                            </tr>
                            
                              <tr>
                                <%--<td bgcolor="#C8E07F" >&nbsp;</td>--%>
                                <td bgcolor="#C8E07F">&nbsp;</td>
                                <td bgcolor="#C8E07F" valign="top" align="left" colspan="3">
                                    <asp:RadioButton GroupName="grp15" 
                                        ID="radio15_4" runat="server" 
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        Text="0- Members on the Tier 2 team do not receive training on the interventions, the systems needed for implementation, and progress monitoring tools." /></td>
                            </tr>
                            
                            <tr>
                                <%--<td >&nbsp;</td>--%>
                                <td colspan="4" >
                                    <asp:Label  ID="lbl16_2" runat="server" 
                                        
                                        
                                        
                                        
                                        
                                        
                                        Text="16.	Students receiving a Tier 2 strategy have full access to Tier 1 supports."></asp:Label></td>
                            </tr>
                          
                            <tr>
                               <%-- <td >&nbsp;</td>--%>
                                <td >
                                    &nbsp;</td>
                                <td valign="top" align="left" colspan="3">
                                    <asp:RadioButton GroupName="grp16" ID="radio16_4" 
                                        runat="server" 
                                        
                                        
                                        
                                        
                                        
                                        
                                        Text="2- Students have been taught expectations and rules and have opportunities to receive acknowledgements through a Tier 1 system that is in place throughout the entire school." /></td>
                            </tr>
                          
                            <tr>
                                <%--<td >&nbsp;</td>--%>
                                <td >
                                    &nbsp;</td>
                                <td valign="top" align="left" colspan="3">
                                  <asp:RadioButton GroupName="grp16" ID="radio16_5" 
                                      runat="server" 
                                      
                                      
                                      
                                      
                                      
                                      
                                        Text="1- Students are taught expectations and rules or have had opportunity to receive acknowledgements or Tier I is not available in all settings." /></td>
                            </tr>
                          
                            <tr>
                                <%--<td >&nbsp;</td>--%>
                                <td >
                                    &nbsp;</td>
                                <td valign="top" align="left" colspan="3">
                                    <asp:RadioButton GroupName="grp16" ID="radio16_6" 
                                        runat="server" 
                                        
                                        
                                        
                                        
                                        
                                        Text="0- Students have not been taught expectations and rules or received acknowledgements." /></td>
                            </tr>
                          
                           <tr>
                                <%--<td bgcolor="#C8E07F" >&nbsp;</td>--%>
                                <td bgcolor="#C8E07F" colspan="4">
                                    <asp:Label  ID="lbl17_2" runat="server" 
                                        
                                        
                                        
                                        
                                        Text="17.	Tier 2 strategies are evaluated and updated regularly."></asp:Label></td>
                            </tr>
                          
                           <tr>
                               <%-- <td bgcolor="#C8E07F" >&nbsp;</td>--%>
                                <td bgcolor="#C8E07F">
                                    &nbsp;</td>
                                <td bgcolor="#C8E07F" valign="top" align="left" colspan="3">
                                    <asp:RadioButton GroupName="grp17" ID="radio17_4" runat="server" 
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        Text="2- Strategies are evaluated at least once each year, reviewed, and updated or modified as needed, based on team discussion. " /></td>
                            </tr>
                          
                           <tr>
                                <%--<td bgcolor="#C8E07F" >&nbsp;</td>--%>
                                <td bgcolor="#C8E07F">
                                    &nbsp;</td>
                                <td bgcolor="#C8E07F" valign="top" align="left" colspan="3">
                                  <asp:RadioButton GroupName="grp17" ID="radio17_5" runat="server" 
                                      
                                      
                                      
                                      
                                      
                                      
                                      
                                      
                                      
                                      
                                        Text="1- Strategies are evaluated, but less than annually, or they are not reviewed and/or updated." /></td>
                            </tr>
                          
                           <tr>
                                <%--<td bgcolor="#C8E07F" >&nbsp;</td>--%>
                                <td bgcolor="#C8E07F">
                                    &nbsp;</td>
                                <td bgcolor="#C8E07F" valign="top" align="left" colspan="3">
                                    <asp:RadioButton GroupName="grp17" 
                                        ID="radio17_6" runat="server" 
                                        
                                        
                                        
                                        
                                        
                                        
                                        Text="0- Strategies are not reviewed or evaluated." /></td>
                            </tr>
                        </table>
                    </td>
                </tr>   
             
               
               <%--TABLE F START--%>               
                 <%--TABLE G END--%>
                
                   <tr>
                    <td>
                        <table width="100%" border="1" cellpadding="4" cellspacing="0" bordercolor="#000000"  >
                                 <tr>
                                <%-- <td class="style5">
                                    <asp:Label Font-Bold="True" ID="Label7" Font-Size="Large" 
                                        runat="server" Text="F"></asp:Label></td>--%> 
                                <td colspan="3"><asp:Label Font-Bold="True" ID="Label7" Font-Size="Large" 
                                        runat="server" Text="F"></asp:Label>&nbsp;&nbsp;<asp:Label Font-Size="Small" Font-Underline="true" Font-Bold="true" ID="lblFMain" runat="server" Text="Main Tier 2 Strategy Implementation"></asp:Label></td>
                                <td colspan="2" style="width:28%" align="center"><asp:Label Font-Size="Small" Font-Underline="true" Font-Bold="true" ID="Label1" runat="server" Text="Items 18-31 (gray shading) are to be completed for the most common Tier 2 strategy in use in your school."></asp:Label></td>
                                     <%--TABLE G START--%>
                            </tr>
                            <tr>
                                <%--<td style="width:5%" >
                                    </td>--%> 
                                <td style="width:29%" align="center">
                                    
                                    <asp:Label Font-Bold="True" ID="Label2" 
                                        runat="server" Text="**The Tier 2/Targeted Intervention most often used in my school is (fill in line)"></asp:Label><asp:Label ID="IntrvUsd" runat="server" Text=""></asp:Label>.
</td>
                                <td style="width:22%" align="center" >
                                    <asp:Label Font-Bold="True" ID="Label3" 
                                        runat="server" Text="2-Fully in Place"></asp:Label></td>
                                <td  style="width:22%" align="center">
                                    <asp:Label Font-Bold="True" ID="Label4" 
                                        runat="server" Text="1-Partially in Place"></asp:Label></td>
                                <td  style="width:22%" align="center" colspan="2"> 
                                    <asp:Label Font-Bold="True" ID="Label5" 
                                        runat="server" Text="0-Not Yet Started"></asp:Label></td>
                            </tr>
                            <tr>
                                <%--<td bgcolor="#C8E07F" >&nbsp;</td>--%>
                                <td bgcolor="#C8E07F" valign="top" colspan="5"><asp:Label  ID="lbl18_2" runat="server" 
                                        
                                        
                                        
                                        
                                        
                                        Text="18.	There are personnel identified to coordinate and deliver the Tier 2 strategy."></asp:Label></td>
                            </tr>
                            <tr>
                                <%--<td bgcolor="#C8E07F" >&nbsp;</td>--%>
                                <td bgcolor="#C8E07F" valign="top">&nbsp;</td>
                                <td bgcolor="#C8E07F" valign="top" align="left" colspan="4">
                                    <asp:RadioButton GroupName="grp18" ID="radio18_4" runat="server" 
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        Text="2- There is an adequate number of staff and those staff members have sufficient time to coordinate and deliver this intervention with fidelity." /></td>
                            </tr>
                            <tr>
                               <%-- <td bgcolor="#C8E07F" >&nbsp;</td>--%>
                                <td bgcolor="#C8E07F" valign="top">&nbsp;</td>
                                <td bgcolor="#C8E07F" valign="top" align="left" colspan="4">
                                  <asp:RadioButton GroupName="grp18" ID="radio18_5" runat="server" 
                                      
                                      
                                      
                                      
                                      
                                      
                                      
                                      
                                        Text="1- The level of staffing and time available interferes with our ability to coordinate and deliver this intervention with fidelity and to all students who would benefit." /></td>
                            </tr>
                            <tr>
                                <%--<td bgcolor="#C8E07F" >&nbsp;</td>--%>
                                <td bgcolor="#C8E07F" valign="top">&nbsp;</td>
                                <td bgcolor="#C8E07F" valign="top" align="left" colspan="4">
                                    <asp:RadioButton GroupName="grp18" 
                                        ID="radio18_6" runat="server" 
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        Text="0- There is not adequate staff or sufficient time to coordinate and deliver this intervention with fidelity." /></td>
                            </tr>
                            <tr>
                               <%-- <td>&nbsp;</td>--%>
                                <td  valign="top" colspan="5"><asp:Label  ID="lbl19_2" runat="server" 
                                        
                                        
                                        
                                        
                                        
                                        
                                        Text="19.	The Tier 2 strategy is consistent with school-wide expectations."></asp:Label></td>
                            </tr>
                            <tr>
                               <%-- <td>&nbsp;</td>--%>
                                <td  valign="top">&nbsp;</td>
                                <td  valign="top" align="left" colspan="5">
                                    <asp:RadioButton GroupName="grp19" ID="radio19_5" runat="server" 
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        Text="2- The Tier 2 strategy includes or references the school-wide expectations." /></td>
                            </tr>
                            <tr>
                               <%-- <td>&nbsp;</td>--%>
                                <td  valign="top">&nbsp;</td>
                                <td  valign="top" align="left" colspan="5">
                                    <asp:RadioButton GroupName="grp19" ID="radio19_4" runat="server" 
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                      
                                        Text="1- The Tier 2 strategy does not specifically include or reference the school-wide expectations but they are not inconsistent." /></td>
                            </tr>
                            <tr>
                              <%--  <td>&nbsp;</td>--%>
                                <td  valign="top">&nbsp;</td>
                                <td  valign="top" align="left" colspan="5">
                                    <asp:RadioButton GroupName="grp19" ID="radio19_6" runat="server" 
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        Text="0- The Tier 2 strategy is inconsistent with school-wide expectations." /></td>
                            </tr>
                            
                            <tr>
                               <%-- <td bgcolor="#C8E07F">&nbsp;</td>--%>
                                <td bgcolor="#C8E07F" valign="top" colspan="5"><asp:Label  ID="lbl20_2" runat="server" 
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        Text="20.	The Tier 2 strategy is established within the school and does not need unique development for each participating student."></asp:Label></td>
                            </tr>
                            
                            <tr>
                               <%-- <td bgcolor="#C8E07F">&nbsp;</td>--%>
                                <td bgcolor="#C8E07F" valign="top">&nbsp;</td>
                                <td bgcolor="#C8E07F" valign="top" align="left" colspan="5">
                                    <asp:RadioButton GroupName="grp20" ID="radio20_4" runat="server" 
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        Text="2- The Tier 2 strategy is in place and can be applied to groups of students consistently." /></td>
                            </tr>
                            
                            <tr>
                               <%-- <td bgcolor="#C8E07F">&nbsp;</td>--%>
                                <td bgcolor="#C8E07F" valign="top">&nbsp;</td>
                                <td bgcolor="#C8E07F" valign="top" align="left" colspan="5">
                                    <asp:RadioButton GroupName="grp20" ID="radio20_5" runat="server" 
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        Text="1- Parts of the Tier 2 strategy are in place OR it requires significant &#8220;start-up&#8221; time for each student." /></td>
                            </tr>
                            
                            <tr>
                                <%--<td bgcolor="#C8E07F">&nbsp;</td>--%>
                                <td bgcolor="#C8E07F" valign="top">&nbsp;</td>
                                <td bgcolor="#C8E07F" valign="top" align="left" colspan="5">
                                    <asp:RadioButton GroupName="grp20" ID="radio20_6" runat="server" 
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        Text="0- The Tier 2 strategy is not established within the school or is unique for most students receiving the intervention." /></td>
                            </tr>
                            
                            
                             <tr>
                               <%-- <td >&nbsp;</td>--%>
                                <td  valign="top" colspan="5"><asp:Label  ID="lbl21_2" runat="server" 
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        Text="21.	The Tier 2 strategy includes a formal process for teaching appropriate behaviors."></asp:Label></td>
                            </tr>
                            
                            
                             <tr>
                               <%-- <td >&nbsp;</td>--%>
                                <td  valign="top">&nbsp;</td>
                                <td  valign="top" align="left" colspan="5">
                                    <asp:RadioButton GroupName="grp21" ID="radio21_4" runat="server" 
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        Text="2- In this strategy, there is a documented formal process for teaching appropriate behaviors." /></td>
                            </tr>
                            
                            
                             <tr>
                               <%-- <td >&nbsp;</td>--%>
                                <td  valign="top">&nbsp;</td>
                                <td  valign="top" align="left" colspan="5">
                                    <asp:RadioButton GroupName="grp21" ID="radio21_5" runat="server" 
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        Text="1- In this strategy, a formal process for teaching appropriate behaviors is not uniformly applied to all students." /></td>
                            </tr>
                            
                            
                             <tr>
                               <%-- <td >&nbsp;</td>--%>
                                <td  valign="top">&nbsp;</td>
                                <td  valign="top" align="left" colspan="5">
                                    <asp:RadioButton GroupName="grp21" ID="radio21_6" runat="server" 
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        Text="0- In this strategy, there is no formal process for teaching appropriate behaviors." /></td>
                            </tr>
                            
                            
                            
                              <tr>
                                <%--<td bgcolor="#C8E07F">&nbsp;</td>--%>
                                <td bgcolor="#C8E07F" valign="top" colspan="5"><asp:Label  ID="lbl22_2" runat="server" 
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        Text="22.	The Tier 2 strategy includes regular opportunities for students to perform appropriate behaviors."></asp:Label></td>
                            </tr>
                            
                            
                            
                              <tr>
                               <%-- <td bgcolor="#C8E07F">&nbsp;</td>--%>
                                <td bgcolor="#C8E07F" valign="top">&nbsp;</td>
                                <td bgcolor="#C8E07F" valign="top" align="left" colspan="5">
                                    <asp:RadioButton GroupName="grp22" ID="radio22_6" runat="server" 
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        Text="2- The strategy provides regular opportunities for students to perform appropriate behaviors." /></td>
                            </tr>
                            
                            
                            
                              <tr>
                               <%-- <td bgcolor="#C8E07F">&nbsp;</td>--%>
                                <td bgcolor="#C8E07F" valign="top">&nbsp;</td>
                                <td bgcolor="#C8E07F" valign="top" align="left" colspan="5">
                                    <asp:RadioButton GroupName="grp22" ID="radio22_5" runat="server" 
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        Text="1- The strategy provides limited opportunities for students to perform appropriate behaviors." /></td>
                            </tr>
                            
                            
                            
                              <tr>
                               <%-- <td bgcolor="#C8E07F">&nbsp;</td>--%>
                                <td bgcolor="#C8E07F" valign="top">&nbsp;</td>
                                <td bgcolor="#C8E07F" valign="top" align="left" colspan="5">
                                    <asp:RadioButton GroupName="grp22" ID="radio22_4" runat="server" 
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        Text="0- The strategy provides no opportunities for students to perform appropriate behaviors." /></td>
                            </tr>
                            
                            
                            
                             <tr>
                               <%-- <td >&nbsp;</td>--%>
                                <td  valign="top" colspan="5"><asp:Label  ID="lbl23_2" runat="server" 
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        Text="23.	The Tier 2 strategy uses accurate and objective data to adapt, modify, and improve support."></asp:Label></td>
                            </tr>
                            <tr>
                              <%--  <td >&nbsp;</td>--%>
                                <td  valign="top">&nbsp;</td>
                                <td  valign="top" align="left" colspan="5">
                                    <asp:RadioButton GroupName="grp23" ID="radio23_4" runat="server" 
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        Text="2- The strategy uses accurate and objective data to adapt, modify, and improve support." /></td>
                            </tr>
                            <tr>
                               <%-- <td >&nbsp;</td>--%>
                                <td  valign="top">&nbsp;</td>
                                <td  valign="top" align="left" colspan="5">
                                    <asp:RadioButton GroupName="grp23" ID="radio23_5" runat="server" 
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        Text="1- The strategy uses data, even if less than adequate, to adapt, modify, and improve support." /></td>
                            </tr>
                            <tr>
                                <%--<td >&nbsp;</td>--%>
                                <td  valign="top">&nbsp;</td>
                                <td  valign="top" align="left" colspan="5">
                                    <asp:RadioButton GroupName="grp23" ID="radio23_6" runat="server" 
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        Text="0- The strategy does not use any data to adapt, modify, and improve support." /></td>
                            </tr>
                            
                            
                            
                              <tr>
                                <%--<td bgcolor="#C8E07F">&nbsp;</td>--%>
                                <td bgcolor="#C8E07F" valign="top" colspan="5"><asp:Label  ID="lbl24_2" runat="server" 
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        Text="24.	The Tier 2 strategy includes frequent communication with the family."></asp:Label></td>
                            </tr>
                            
                            
                            
                              <tr>
                                <%--<td bgcolor="#C8E07F">&nbsp;</td>--%>
                                <td bgcolor="#C8E07F" valign="top">&nbsp;</td>
                                <td bgcolor="#C8E07F" valign="top" align="left" colspan="5">
                                    <asp:RadioButton GroupName="grp24" ID="radio24_7" runat="server" 
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        Text="2- The strategy includes weekly communication with the family." /></td>
                            </tr>
                            
                            
                            
                              <tr>
                                <%--<td bgcolor="#C8E07F">&nbsp;</td>--%>
                                <td bgcolor="#C8E07F" valign="top">&nbsp;</td>
                                <td bgcolor="#C8E07F" valign="top" align="left" colspan="5">
                                    <asp:RadioButton GroupName="grp24" ID="radio24_6" runat="server" 
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        Text="1- The strategy includes less than weekly communication with the family" /></td>
                            </tr>
                            
                            
                            
                              <tr>
                                <%--<td bgcolor="#C8E07F">&nbsp;</td>--%>
                                <td bgcolor="#C8E07F" valign="top">&nbsp;</td>
                                <td bgcolor="#C8E07F" valign="top" align="left" colspan="5">
                                    <asp:RadioButton GroupName="grp24" ID="radio24_5" runat="server" 
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        Text="0- The strategy includes no process for communication with the family." /></td>
                            </tr>
                            
                            
                            
                                 <tr>
                               <%-- <td >&nbsp;</td>--%>
                                <td valign="top" colspan="5"><asp:Label  ID="lbl25_2" runat="server" 
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        Text="25.	The Tier 2 strategy has written materials that describe the core features, functions, and systems of the strategy."></asp:Label></td>
                                    
                                    
                            </tr>
                            <tr>
                              <%--  <td >&nbsp;</td>--%>
                                <td  valign="top">&nbsp;</td>
                                <td  valign="top" align="left" colspan="5">
                                    <asp:RadioButton GroupName="grp25" ID="radio25_5" runat="server" 
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        Text="2- Written materials exist to describe the core features, functions, and systems of the strategy." /></td>
              
                            </tr>
                            <tr>
                               <%-- <td >&nbsp;</td>--%>
                                <td  valign="top">&nbsp;</td>
                                <td  valign="top" align="left" colspan="5">
                                    <asp:RadioButton GroupName="grp25" ID="radio25_4" runat="server" 
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        Text="1- Written materials exist but do not describe all of the core features, functions, and systems of the strategy." /></td>
                            </tr>
                            <tr>
                                <%--<td >&nbsp;</td>--%>
                                <td  valign="top">&nbsp;</td>
                                <td  valign="top" align="left" colspan="5">
                                    <asp:RadioButton GroupName="grp24" ID="radio25_6" runat="server" 
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        Text="0- The strategy includes no process for communication with the family." /></td>
                            </tr>
                            
                            
                                 <tr>
                                <%--<td bgcolor="#C8E07F">&nbsp;</td>--%>
                                <td bgcolor="#C8E07F" valign="top" colspan="5"><asp:Label  ID="lbl26_2" runat="server" 
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        Text="26.	The Tier 2 strategy includes orientation material and procedures for the staff, substitutes, families and volunteers."></asp:Label></td>
                            </tr>
                            
                            
                                 <tr>
                               <%-- <td bgcolor="#C8E07F">&nbsp;</td>--%>
                                <td bgcolor="#C8E07F" valign="top">&nbsp;</td>
                                <td bgcolor="#C8E07F" valign="top" align="left" colspan="5">
                                    <asp:RadioButton GroupName="grp26" ID="radio26_4" runat="server" 
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        Text="2- Orientation materials and procedures exist for the staff, substitutes, families and volunteers." /></td>
                            </tr>
                            
                            
                                 <tr>
                               <%-- <td bgcolor="#C8E07F">&nbsp;</td>--%>
                                <td bgcolor="#C8E07F" valign="top">&nbsp;</td>
                                <td bgcolor="#C8E07F" valign="top" align="left" colspan="5">
                                    <asp:RadioButton GroupName="grp26" ID="radio26_5" runat="server" 
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        Text="1- Orientation materials and procedures exist, but not for all four groups." /></td>
                            </tr>
                            
                            
                                 <tr>
                                <%--<td bgcolor="#C8E07F">&nbsp;</td>--%>
                                <td bgcolor="#C8E07F" valign="top">&nbsp;</td>
                                <td bgcolor="#C8E07F" valign="top" align="left" colspan="5">
                                    <asp:RadioButton GroupName="grp26" ID="radio26_6" runat="server" 
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        Text="0- Orientation materials and procedures do not exist." /></td>
                            </tr>
                            
                                 <tr>
                                <%--<td >&nbsp;</td>--%>
                                <td valign="top" colspan="5">
                                    <asp:Label  ID="lbl27_2" runat="server" 
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        Text="27.	The Tier 2 strategy is efficient."></asp:Label></td>
                            </tr>
                            <tr>
                                <%--<td >&nbsp;</td>--%>
                                <td  valign="top">&nbsp;</td>
                                <td  valign="top" align="left" colspan="5">
                                    <asp:RadioButton GroupName="grp27" ID="radio27_5" runat="server" 
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        Text="2- Requires no more than 10 minutes per instructional staff person, per day." /></td>
                            </tr>
                            <tr>
                                <%--<td >&nbsp;</td>--%>
                                <td  valign="top">&nbsp;</td>
                                <td  valign="top" align="left" colspan="5">
                                    <asp:RadioButton GroupName="grp27" ID="radio27_4" runat="server" 
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        Text="1- Requires more than 10 minutes per instructional staff person, per day." /></td>
                            </tr>
                            <tr>
                               <%-- <td >&nbsp;</td>--%>
                                <td  valign="top">&nbsp;</td>
                                <td  valign="top" align="left" colspan="4">
                                    <asp:RadioButton GroupName="grp27" ID="radio27_6" runat="server" 
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        Text="0- There are no data indicating how long the strategy takes per instructional staff person, per day." /></td>
                            </tr>
                            </table>
                         </td>
                      </tr>
                      
                            
                   <%--TABLE G END--%>
                   
                   
                       <%--TABLE G START--%>
                
                 <tr>
                    <td>
                        <table width="100%" border="1" cellpadding="4" cellspacing="0" bordercolor="#000000" >
                            <tr>
                                <%--<td bgcolor="#C8E07F" class="style5"><asp:Label Font-Bold="True" ID="Label8" Font-Size="Large" 
                                        runat="server" Text="G"></asp:Label></td> --%> 
                                <td bgcolor="#C8E07F" style="width:29%" align="left"><asp:Label Font-Bold="True" ID="Label8" Font-Size="Large" 
                                        runat="server" Text="G"></asp:Label>&nbsp;&nbsp;
                                    <asp:Label Font-Bold="True" ID="Label9" 
                                        runat="server" Text="Main Tier 2: Strategy Monitoring and Evaluation"></asp:Label></td>
                                <td bgcolor="#C8E07F" style="width:22%" align="center">
                                    <asp:Label Font-Bold="True" ID="Label10" 
                                        runat="server" Text="2-Fully in Place"></asp:Label></td>
                                <td bgcolor="#C8E07F" style="width:22%" align="center">
                                    <asp:Label Font-Bold="True" ID="Label11" 
                                        runat="server" Text="1-Partially in Place"></asp:Label></td>
                                <td bgcolor="#C8E07F" style="width:22%" align="center" colspan="2"> 
                                    <asp:Label Font-Bold="True" ID="Label12" 
                                        runat="server" Text="0-Not Yet Started"></asp:Label></td>
                            </tr>
                            <tr>
                                <%--<td bgcolor="#C8E07F" class="style5">&nbsp;</td>--%>
                                <td bgcolor="#C8E07F">&nbsp;</td>
                                <td bgcolor="#C8E07F">&nbsp;</td>
                                <td bgcolor="#C8E07F">&nbsp;</td>
                                <td bgcolor="#C8E07F" colspan="2">&nbsp;</td>
                            </tr>
                             <tr>
                                <%--<td class="style5" >&nbsp;</td>--%>
                                <td colspan="5" ><asp:Label  ID="lbl28_2" runat="server" 
                                        
                                        
                                        
                                        Text="28.	An information system is used to monitor the impact of the Tier 2 strategy."></asp:Label></td>
                            </tr>
                            
                             <tr>
                                <%--<td class="style5" >&nbsp;</td>--%>
                                <td >&nbsp;</td>
                                <td  valign="top" align="left" colspan="4">
                                    <asp:RadioButton GroupName="grp28" ID="radio28_6" runat="server" 
                                        
                                        
                                        
                                        
                                        
                                        Text="2- Teachers directly involved with Tier 2 and 3 supports are notified about changes to strategies immediately and the impact, weekly." /></td>
                            </tr>
                            
                             <tr>
                               <%-- <td class="style5" >&nbsp;</td>--%>
                                <td >&nbsp;</td>
                                <td  valign="top" align="left" colspan="4">
                                  <asp:RadioButton GroupName="grp28" ID="radio28_5" runat="server" 
                                      
                                      
                                      
                                      
                                      
                                        Text="1- Teachers directly involved with Tier 2 and 3 supports are notified about changes to strategies and impact less than weekly. " /></td>
                            </tr>
                            
                             <tr>
                                <%--<td class="style5" >&nbsp;</td>--%>
                                <td >&nbsp;</td>
                                <td  valign="top" align="left" colspan="4">
                                    <asp:RadioButton GroupName="grp28" 
                                        ID="radio28_4" runat="server" 
                                        
                                        
                                        
                                        
                                        
                                        Text="0- Teachers directly involved with Tier 2 and 3 supports do not receive notification about impact and changes to strategies." /></td>
                            </tr>
                            
                           <tr>
                                <%--<td bgcolor="#C8E07F" class="style5">&nbsp;</td>--%>
                                <td bgcolor="#C8E07F" colspan="5">
                                    <asp:Label  ID="lbl29_2" runat="server" 
                                        
                                        
                                        
                                        
                                        
                                        Text="29.	There are documented decision rules to decide which students access the strategy and the process is implemented consistently."></asp:Label></td>
                            </tr>
                          
                          
                          
                           <tr>
                               <%-- <td bgcolor="#C8E07F" class="style5">&nbsp;</td>--%>
                                <td bgcolor="#C8E07F">
                                    &nbsp;</td>
                                <td bgcolor="#C8E07F" valign="top" align="left" colspan="4">
                                    <asp:RadioButton GroupName="grp29" ID="radio29_4" 
                                        runat="server" 
                                        
                                        
                                        
                                        
                                        Text="2- There are documented decision rules to decide which students access the strategy and the process is implemented consistently." /></td>
                            </tr>
                          
                          
                          
                           <tr>
                               <%-- <td bgcolor="#C8E07F" class="style5">&nbsp;</td>--%>
                                <td bgcolor="#C8E07F">
                                    &nbsp;</td>
                                <td bgcolor="#C8E07F" valign="top" align="left" colspan="4">
                                  <asp:RadioButton GroupName="grp29" ID="radio29_5" 
                                      runat="server" 
                                      
                                      
                                      
                                      
                                        Text="1- There are documented decision rules to decide which students access the strategy, but they are not used or are used inconsistently." /></td>
                            </tr>
                          
                          
                          
                           <tr>
                               <%-- <td bgcolor="#C8E07F" class="style5">&nbsp;</td>--%>
                                <td bgcolor="#C8E07F">
                                    &nbsp;</td>
                                <td bgcolor="#C8E07F" valign="top" align="left" colspan="4">
                                    <asp:RadioButton GroupName="grp29" ID="radio29_6" 
                                        runat="server" 
                                        
                                        
                                        
                                        Text="0- There are no decision rules to determine how students access the Tier 2 strategy" /></td>
                            </tr>
                          
                          
                          
                           <tr>
                               <%-- <td class="style5" >&nbsp;</td>--%>
                                <td colspan="5"><asp:Label  ID="lbl30_2" runat="server" 
                                        
                                        
                                        Text="30.	Documented decision rules are used to monitor, modify, or discontinue student involvement in the Tier 2 strategy."></asp:Label></td>
                            </tr>
                            
                            
                          
                           <tr>
                             <%--   <td class="style5" >&nbsp;</td>--%>
                                <td>&nbsp;</td>
                                <td  valign="top" align="left" colspan="4">
                                    <asp:RadioButton GroupName="grp30" ID="radio30_6" runat="server" 
                                        
                                        
                                        
                                        
                                        
                                        
                                        Text="2- Documented decision rules determine how the strategy affects a student and include (a) monitoring, (b) modifying, and (c) ending a strategy." /></td>
                            </tr>
                            
                            
                          
                           <tr>
                               <%-- <td class="style5" >&nbsp;</td>--%>
                                <td>&nbsp;</td>
                                <td  valign="top" align="left" colspan="4">
                                  <asp:RadioButton GroupName="grp30" ID="radio30_5" runat="server" 
                                      
                                      
                                      
                                      
                                      
                                      
                                        Text="1- Documented decision rules may include (a) monitoring, (b) modifying, and (c) ending a strategy, but not all three." /></td>
                            </tr>
                            
                            
                          
                           <tr>
<%--                                <td class="style5" >&nbsp;</td>
--%>                                <td>&nbsp;</td>
                                <td  valign="top" align="left" colspan="4">
                                    <asp:RadioButton GroupName="grp30" 
                                        ID="radio30_4" runat="server" 
                                        
                                        
                                        
                                        
                                        
                                        
                                        Text="0- There are no decision rules to determine how a strategy affects a student or decision rules include exist for two or fewer of (a) monitoring, (b) modifying, and (c) ending a strategy." /></td>
                            </tr>
                            
                            
                                  <tr>
                                <%--<td bgcolor="#C8E07F" class="style5">&nbsp;</td>--%>
                                <td bgcolor="#C8E07F" colspan="5">
                                    <asp:Label  ID="Label31" runat="server" 
                                        
                                        
                                        
                                        
                                        Text="31.	Fidelity of the Tier 2 strategy is assessed.."></asp:Label></td>
                            </tr>
                          
                          
                                  <tr>
                                <%--<td bgcolor="#C8E07F" class="style5">&nbsp;</td>--%>
                                <td bgcolor="#C8E07F">
                                    &nbsp;</td>
                                <td bgcolor="#C8E07F" valign="top" align="left" colspan="4">
                                    <asp:RadioButton GroupName="grp31" ID="radio31_6" 
                                        runat="server" 
                                        
                                        
                                        
                                        
                                        
                                        Text="2- The Tier 2 strategy is evaluated at least once a year to ensure it is implemented as designed" /></td>
                            </tr>
                          
                          
                                  <tr>
                                <%--<td bgcolor="#C8E07F" class="style5">&nbsp;</td>--%>
                                <td bgcolor="#C8E07F">
                                    &nbsp;</td>
                                <td bgcolor="#C8E07F" valign="top" align="left" colspan="4">
                                  <asp:RadioButton GroupName="grp31" ID="radio31_5" 
                                      runat="server" 
                                      
                                      
                                      
                                      Text="1- The Tier 2 strategy is evaluated, but less than annually." /></td>
                            </tr>
                          
                          
                                  <tr>
                                <%--<td bgcolor="#C8E07F" class="style5">&nbsp;</td>--%>
                                <td bgcolor="#C8E07F">
                                    &nbsp;</td>
                                <td bgcolor="#C8E07F" valign="top" align="left" colspan="4">
                                    <asp:RadioButton GroupName="grp31" ID="radio31_4" 
                                        runat="server" 
                                        
                                        
                                        
                                        
                                        Text="0- The Tier 2 strategy is not evaluated to confirm that it is implemented as designed." /></td>
                            </tr>
                          
                          
                        </table>
                    </td>
                </tr>   
                
                        <%--TABLE G END--%>
                        
                        <%--TABLE H START--%>
                      <tr>
                      <td>
                        <table width="100%" border="1" cellpadding="4" cellspacing="0" bordercolor="#000000" >
                                 
                            <tr>
                               <%-- <td style="width:5%" valign="top"><asp:Label Font-Bold="True" ID="lblH" Font-Size="Large" 
                                        runat="server" Text="H"></asp:Label></td> --%>  
                                <td  style="width:29%" align="left">
                                <asp:Label Font-Bold="True" ID="lblH" Font-Size="Large" 
                                        runat="server" Text="H"></asp:Label>
                                        &nbsp;&nbsp;
                                    <asp:Label Font-Bold="True" ID="Label18" 
                                        runat="server" Text="Tier 3: Intensive Support Systems"></asp:Label></td>
                                <td align="center" style="width:22%">
                                    <asp:Label Font-Bold="True" ID="Label19" 
                                        runat="server" Text="2-Fully in Place"></asp:Label></td>
                                <td  style="width:22%" align="center">
                                    <asp:Label Font-Bold="True" ID="Label20" 
                                        runat="server" Text="1-Partially in Place"></asp:Label></td>
                                <td  style="width:22%" align="center" colspan="3"> 
                                    <asp:Label Font-Bold="True" ID="Label21" 
                                        runat="server" Text="0-Not Yet Started"></asp:Label></td>
                            </tr>
                            <tr>
                                <%--<td bgcolor="#C8E07F" >&nbsp;</td>--%>
                                <td bgcolor="#C8E07F" valign="top" colspan="6">
                                    <asp:Label  ID="Label32" runat="server" 
                                        
                                        
                                        
                                        
                                        Text="32.	A team builds and implements Tier 3 behavior support plans."></asp:Label></td>
                            </tr>
                            <tr>
                                <td bgcolor="#C8E07F" valign="top">&nbsp;</td>
                                <td bgcolor="#C8E07F" valign="top" align="left" colspan="5">
                                    <asp:RadioButton GroupName="grp32" ID="radio32_6" runat="server" 
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        Text="2- There is a formal team that is responsible for building and implementing Tier 3 behavior support plans." /></td>
                            </tr>
                            <tr>
                                <td bgcolor="#C8E07F" valign="top">&nbsp;</td>
                                <td bgcolor="#C8E07F" valign="top" align="left" colspan="5">
                                  <asp:RadioButton GroupName="grp32" ID="radio32_5" runat="server" 
                                      
                                      
                                      
                                      
                                      
                                      
                                      
                                      
                                        Text="1- A group of staff get together informally or inconsistently to build and implement Tier 3 behavior support plans." /></td>
                            </tr>
                            <tr>
                                <td bgcolor="#C8E07F" valign="top">&nbsp;</td>
                                <td bgcolor="#C8E07F" valign="top" align="left" colspan="5">
                                    <asp:RadioButton GroupName="grp32" 
                                        ID="radio32_4" runat="server" 
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        Text="0- There is not adequate staff or sufficient time to coordinate and deliver this intervention with fidelity." /></td>
                            </tr>
                            <tr>
                                <%--<td>&nbsp;</td>--%>
                                <td  valign="top" colspan="6"><asp:Label  ID="lbl57" runat="server" 
                                        Text="33.	The Tier 3 support team includes individuals with knowledge about the school systems, the student, and behavioral theory (e.g., student, teacher, family member, administrator, behavior specialist, advocates)."></asp:Label></td>
                            </tr>
                            <tr>
                                <%--<td>&nbsp;</td>--%>
                                <td  valign="top">&nbsp;</td>
                                <td  valign="top" align="left" colspan="5" dir="ltr">
                                    <asp:RadioButton GroupName="grp33" ID="radio33_4" runat="server" 
                                        Text="2- Support team includes members that represent expertise in all 3 areas: school systems, student, and behavioral theory." /></td>
                            </tr>
                            <tr>
                               <%-- <td>&nbsp;</td>--%>
                                <td  valign="top">&nbsp;</td>
                                <td  valign="top" align="left"colspan="5">
                                    <asp:RadioButton GroupName="grp33" ID="radio33_5" runat="server" 
                                        Text="1- Support team includes members that represent expertise in only 2 of the 3 areas: school systems, student, and behavioral theory." /></td>
                            </tr>
                            <tr>
                                <%--<td>&nbsp;</td>--%>
                                <td  valign="top">&nbsp;</td>
                                <td  valign="top" align="left"colspan="5" dir="ltr">
                                    <asp:RadioButton GroupName="grp33" ID="radio33_6" runat="server" 
                                        Text="0- Support team does not include members that represent any of these areas; OR, the team includes representation from only 1 area." /></td>
                            </tr>
                            <tr>
                                <%--<td bgcolor="#C8E07F">&nbsp;</td>--%>
                                <td bgcolor="#C8E07F" valign="top"colspan="6">
                                    <asp:Label  ID="lbl58" runat="server" 
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        Text="34.	A person is identified to coordinate Tier 3 supports."></asp:Label></td>
                            </tr>
                            
                            <tr>
                               <%-- <td bgcolor="#C8E07F">&nbsp;</td>--%>
                                <td bgcolor="#C8E07F" valign="top">&nbsp;</td>
                                <td bgcolor="#C8E07F" valign="top" align="left"colspan="5">
                                    <asp:RadioButton GroupName="grp34" ID="radio34_6" runat="server" 
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        Text="2- A coordinator with behavioral expertise and adequate FTE is identified." /></td>
                            </tr>
                            
                            <tr>
                                <%--<td bgcolor="#C8E07F">&nbsp;</td>--%>
                                <td bgcolor="#C8E07F" valign="top">&nbsp;</td>
                                <td bgcolor="#C8E07F" valign="top" align="left"colspan="5">
                                    <asp:RadioButton GroupName="grp34" ID="radio34_5" runat="server" 
                                        Text="1- A coordinator is identified, but does not have behavioral expertise or is lacking dedicated FTE." /></td>
                            </tr>
                            
                            <tr>
                                <%--<td bgcolor="#C8E07F">&nbsp;</td>--%>
                                <td bgcolor="#C8E07F" valign="top">&nbsp;</td>
                                <td bgcolor="#C8E07F" valign="top" align="left"colspan="5">
                                    <asp:RadioButton GroupName="grp34" ID="radio34_4" runat="server" 
                                        Text="0- No coordinator is identified." /></td>
                            </tr>
                            
                             <tr>
                                <%--<td >&nbsp;</td>--%>
                                <td  valign="top"colspan="6"><asp:Label  ID="lbl59" runat="server" 
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        Text="35.	The administrator is a member of the Tier 3 implementation team."></asp:Label></td>
                            </tr>
                            
                            
                             <tr>
                               <%-- <td >&nbsp;</td>--%>
                                <td  valign="top">&nbsp;</td>
                                <td  valign="top" align="left"colspan="5">
                                    <asp:RadioButton GroupName="grp35" ID="radio35_4" runat="server" 
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        Text="2- The administrator participates in most activities of the Tier 3 team." /></td>
                            </tr>
                            
                            
                             <tr>
                                <%--<td >&nbsp;</td>--%>
                                <td  valign="top">&nbsp;</td>
                                <td  valign="top" align="left"colspan="5">
                                    <asp:RadioButton GroupName="grp35" ID="radio35_5" runat="server" 
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        Text="1- The administrator participates in Tier 3 team activities occasionally or inconsistently." /></td>
                            </tr>
                            
                            
                             <tr>
                               <%-- <td >&nbsp;</td>--%>
                                <td  valign="top">&nbsp;</td>
                                <td  valign="top" align="left"colspan="5">
                                    <asp:RadioButton GroupName="grp35" ID="radio35_6" runat="server" 
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        Text="0- The administrator does not participate in Tier 3 team activities." /></td>
                            </tr>
                            
                            
                              <tr>
                                <%--<td bgcolor="#C8E07F">&nbsp;</td>--%>
                                <td bgcolor="#C8E07F" valign="top"colspan="6"><asp:Label  ID="lbl60" runat="server" 
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        Text="36.	Tier 3 team members have sufficient formal training in implementation of the Tier 3 support system."></asp:Label></td>
                            </tr>
                            
                            
                            
                              <tr>
                                <%--<td bgcolor="#C8E07F">&nbsp;</td>--%>
                                <td bgcolor="#C8E07F" valign="top">&nbsp;</td>
                                <td bgcolor="#C8E07F" valign="top" align="left"colspan="5">
                                    <asp:RadioButton GroupName="grp36" ID="radio36_4" runat="server" 
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        Text="2- Tier 3 team members have sufficient training and support to implement Tier 3 supports with fidelity." /></td>
                            </tr>
                            
                            
                            
                              <tr>
                                <%--<td bgcolor="#C8E07F">&nbsp;</td>--%>
                                <td bgcolor="#C8E07F" valign="top">&nbsp;</td>
                                <td bgcolor="#C8E07F" valign="top" align="left"colspan="5">
                                    <asp:RadioButton GroupName="grp36" ID="radio36_5" runat="server" 
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        Text="1- Tier 3 team members have limited training and support to implement Tier 3 supports with fidelity." /></td>
                            </tr>
                            
                            
                            
                              <tr>
                                <%--<td bgcolor="#C8E07F">&nbsp;</td>--%>
                                <td bgcolor="#C8E07F" valign="top">&nbsp;</td>
                                <td bgcolor="#C8E07F" valign="top" align="left"colspan="5" dir="ltr">
                                    <asp:RadioButton GroupName="grp36" ID="radio36_6" runat="server" 
                                        
                                         
                                        
                                        Text="0- Tier 3 team members have little to no training and support to implement Tier 3 supports with fidelity." /></td>
                            </tr>
                            
                            
                            
                             <tr>
                                <%--<td >&nbsp;</td>--%>
                                <td  valign="top"colspan="6"><asp:Label  ID="lbl61" runat="server" 
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        Text="37.	The Tier 3 team receives annual staff development in Tier 3 procedures."></asp:Label></td>
                            </tr>
                            
                            
                            
                             <tr>
                               <%-- <td >&nbsp;</td>--%>
                                <td  valign="top">&nbsp;</td>
                                <td  valign="top" align="left"colspan="5">
                                    <asp:RadioButton GroupName="grp37" ID="radio37_4" runat="server" 
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        Text="2- At least 50% of the team receives staff development related to Tier 3 procedures every year." /></td>
                            </tr>
                            
                            
                            
                             <tr>
                               <%-- <td >&nbsp;</td>--%>
                                <td  valign="top">&nbsp;</td>
                                <td  valign="top" align="left"colspan="5">
                                    <asp:RadioButton GroupName="grp37" ID="radio37_5" runat="server" 
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        Text="1- Fewer than 50% of team receives staff development related to Tier 3 procedures, or not every year, or there is not a formal plan to provide annual training.." /></td>
                            </tr>
                            
                            
                            
                             <tr>
                               <%-- <td >&nbsp;</td>--%>
                                <td  valign="top">&nbsp;</td>
                                <td  valign="top" align="left"colspan="5">
                                    <asp:RadioButton GroupName="grp37" ID="radio37_6" runat="server" 
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        Text="0- The team does not receive any staff development related to Tier 3 procedures." /></td>
                            </tr>
                            
                            
                            
                              <tr>
                                <%--<td bgcolor="#C8E07F">&nbsp;</td>--%>
                                <td bgcolor="#C8E07F" valign="top"colspan="6"><asp:Label  ID="lbl62" runat="server" 
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        Text="38.	The team has an efficient and accurate data system for monitoring Tier 3 impact."></asp:Label></td>
                            </tr>
                            
                            
                            
                              <tr>
                               <%-- <td bgcolor="#C8E07F">&nbsp;</td>--%>
                                <td bgcolor="#C8E07F" valign="top">&nbsp;</td>
                                <td bgcolor="#C8E07F" valign="top" align="left"colspan="5">
                                    <asp:RadioButton GroupName="grp38" ID="radio38_4" runat="server" 
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        Text="2- There is a system to collect data daily and graphically monitor/analyze (at least bi-monthly) student behaviors for each student receiving Tier 3 support." /></td>
                            </tr>
                            
                            
                            
                              <tr>
                              <%--  <td bgcolor="#C8E07F">&nbsp;</td>--%>
                                <td bgcolor="#C8E07F" valign="top">&nbsp;</td>
                                <td bgcolor="#C8E07F" valign="top" align="left"colspan="5">
                                    <asp:RadioButton GroupName="grp38" ID="radio38_5" runat="server" 
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        Text="1- There is no system to collect student-behavior data daily for graphical analysis, but there are forms and other tools available." /></td>
                            </tr>
                            
                            
                            
                              <tr>
                                <%--<td bgcolor="#C8E07F">&nbsp;</td>--%>
                                <td bgcolor="#C8E07F" valign="top">&nbsp;</td>
                                <td bgcolor="#C8E07F" valign="top" align="left"colspan="5" dir="ltr">
                                    <asp:RadioButton GroupName="grp38" ID="radio38_6" runat="server" 
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        Text="0- A data-based system is not available, and there are no forms or tools available to collect student behavior data." /></td>
                            </tr>
                            
                            
                            
                                 <tr>
                              <%--  <td >&nbsp;</td>--%>
                                <td valign="top"colspan="6"><asp:Label  ID="lbl64" runat="server" 
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        Text="39.	The team reviews the Tier 3 process and considers modifications, as needed."></asp:Label></td>
                            </tr>
                            
                            
                            
                                 <tr>
                               <%-- <td >&nbsp;</td>--%>
                                <td valign="top">&nbsp;</td>
                                <td valign="top" align="left"colspan="5">
                                    <asp:RadioButton GroupName="grp39" ID="radio39_4" runat="server" 
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        Text="2- The team reviews the impact of Tier 3 process each year, and modifies the process as needed." /></td>
                            </tr>
                            
                            
                            
                                 <tr>
                               <%-- <td >&nbsp;</td>--%>
                                <td valign="top">&nbsp;</td>
                                <td valign="top" align="left"colspan="5">
                                    <asp:RadioButton GroupName="grp39" ID="radio39_5" runat="server" 
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        Text="1- The team reviews the impact of Tier 3, but not each year OR the team does not evaluate the process for needed modifications." /></td>
                            </tr>
                            
                            
                            
                                 <tr>
                               <%-- <td >&nbsp;</td>--%>
                                <td valign="top">&nbsp;</td>
                                <td valign="top" align="left"colspan="5">
                                    <asp:RadioButton GroupName="grp39" ID="radio39_6" runat="server" 
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        Text="0- The team does not review the Tier 3 process." /></td>
                            </tr>
                            
                            
                                 <tr>
                               <%-- <td bgcolor="#C8E07F">&nbsp;</td>--%>
                                <td bgcolor="#C8E07F" valign="top"colspan="6">
                                    <asp:Label  ID="lbl63" runat="server" 
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        Text="40.	The school has personnel to implement Tier 3 supports."></asp:Label></td>
                            </tr>
                            
                            
                                 <tr>
                                <%--<td bgcolor="#C8E07F">&nbsp;</td>--%>
                                <td bgcolor="#C8E07F" valign="top">&nbsp;</td>
                                <td bgcolor="#C8E07F" valign="top" align="left"colspan="5">
                                    <asp:RadioButton GroupName="grp39" ID="radio40_4" runat="server" 
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        Text="2- The team reviews the impact of Tier 3 process each year, and modifies the process as needed." /></td>
                            </tr>
                            
                            
                                 <tr>
                                <%--<td bgcolor="#C8E07F">&nbsp;</td>--%>
                                <td bgcolor="#C8E07F" valign="top">&nbsp;</td>
                                <td bgcolor="#C8E07F" valign="top" align="left"colspan="5">
                                    <asp:RadioButton GroupName="grp39" ID="radio40_5" runat="server" 
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        Text="1- The team reviews the impact of Tier 3, but not each year OR the team does not evaluate the process for needed modifications." /></td>
                            </tr>
                            
                            
                                 <tr>
                               <%-- <td bgcolor="#C8E07F">&nbsp;</td>--%>
                                <td bgcolor="#C8E07F" valign="top">&nbsp;</td>
                                <td bgcolor="#C8E07F" valign="top" align="left"colspan="5">
                                    <asp:RadioButton GroupName="grp40" ID="radio40_6" runat="server" 
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        Text="0- Our ability to provide Tier 3 support is compromised due to inadequate personnel levels." /></td>
                            </tr>
                            
                                 <tr>
                                <%--<td >&nbsp;</td>--%>
                                <td valign="top"colspan="6">
                                    <asp:Label  ID="lbl65" runat="server" 
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        Text="41.	The school facilitates involvement of family members of students receiving Tier 3 supports."></asp:Label></td>
                            </tr>
                            
                            
                                 <tr>
                                <%--<td >&nbsp;</td>--%>
                                <td valign="top">
                                    &nbsp;</td>
                                <td valign="top" align="left"colspan="5">
                                    <asp:RadioButton GroupName="grp41" ID="radio41_4" runat="server" 
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        Text="2- The school makes considerable efforts to encourage family participation in assessment, intervention development and implementation, and progress monitoring." /></td>
                            </tr>
                            
                            
                                 <tr>
                               <%-- <td >&nbsp;</td>--%>
                                <td valign="top">
                                    &nbsp;</td>
                                <td valign="top" align="left"colspan="5">
                                    <asp:RadioButton GroupName="grp41" ID="radio41_5" runat="server" 
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        Text="1- The school makes some efforts to encourage family participation in assessment, intervention development and implementation, and progress monitoring." /></td>
                            </tr>
                            
                            
                                 <tr>
                               <%-- <td >&nbsp;</td>--%>
                                <td valign="top">
                                    &nbsp;</td>
                                <td valign="top" align="left"colspan="5">
                                    <asp:RadioButton GroupName="grp41" ID="radio41_6" runat="server" 
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        Text="0- The school makes minimal efforts to encourage family participation in assessment, intervention development and implementation, and progress monitoring." /></td>
                            </tr>
                            
                            
                                 <tr>
                               <%-- <td bgcolor="#C8E07F">&nbsp;</td>--%>
                                <td bgcolor="#C8E07F" valign="top"colspan="6"><asp:Label  ID="lbl66" runat="server" 
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        Text="42.	All faculty and staff are oriented to Tier 3 support implementation."></asp:Label></td>
                            </tr>
                            
                            
                                 <tr>
                                <%--<td bgcolor="#C8E07F">&nbsp;</td>--%>
                                <td bgcolor="#C8E07F" valign="top">&nbsp;</td>
                                <td bgcolor="#C8E07F" valign="top" align="left"colspan="5">
                                    <asp:RadioButton GroupName="grp42" ID="radio42_4" runat="server" 
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        Text="2- There is a specific process for providing all faculty and staff with orientation to Tier 3 support process, and all staff are aware of their roles in Tier 3 supports." /></td>
                            </tr>
                            
                            
                                 <tr>
                               <%-- <td bgcolor="#C8E07F">&nbsp;</td>--%>
                                <td bgcolor="#C8E07F" valign="top">&nbsp;</td>
                                <td bgcolor="#C8E07F" valign="top" align="left"colspan="5">
                                    <asp:RadioButton GroupName="grp42" ID="radio42_5" runat="server" 
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        Text="1- The process for providing all faculty and staff with Tier 3 orientation is unclear or not all staff are aware of their roles in Tier 3 supports." /></td>
                            </tr>
                            
                            
                                 <tr>
                                <%--<td bgcolor="#C8E07F">&nbsp;</td>--%>
                                <td bgcolor="#C8E07F" valign="top">&nbsp;</td>
                                <td bgcolor="#C8E07F" valign="top" align="left"colspan="5">
                                    <asp:RadioButton GroupName="grp42" ID="radio42_6" runat="server" 
                                        
                                        
                                        
                                        
                                        Text="0- There is not a process for providing all faculty and staff with orientation to Tier 3 support process." /></td>
                            </tr>
                            
                               <tr>
                               <%-- <td >&nbsp;</td>--%>
                                <td valign="top"colspan="6">
                                    <asp:Label  ID="lbl67" runat="server" 
                                        
                                        
                                        
                                        Text="43.	Students receiving Tier 3 support also have access to Tier 1 and/or Tier 2 supports."></asp:Label></td>
                            </tr>
                            
                            
                               <tr>
                               <%-- <td >&nbsp;</td>--%>
                                <td valign="top">
                                    &nbsp;</td>
                                <td valign="top" align="left"colspan="5">
                                    <asp:RadioButton GroupName="grp43" ID="radio43_5" runat="server" 
                                        
                                        
                                        Text="2- All students accessing Tier 3 have received ongoing lessons on expectations, have had access to the reward system, and have had Tier 2 supports when appropriate." /></td>
                            </tr>
                            
                            
                               <tr>
                               <%-- <td >&nbsp;</td>--%>
                                <td valign="top">
                                    &nbsp;</td>
                                <td valign="top" align="left"colspan="5" dir="ltr">
                                    <asp:RadioButton GroupName="grp43" ID="radio43_4" runat="server" 
                                        
                                        
                                        Text="1- Some students accessing Tier 3 have received ongoing lessons on expectations, have had access to the reward system, and have had Tier 2 supports when appropriate." /></td>
                            </tr>
                            
                            
                               <tr>
                               <%-- <td >&nbsp;</td>--%>
                                <td valign="top">
                                    &nbsp;</td>
                                <td valign="top" align="left"colspan="5">
                                    <asp:RadioButton GroupName="grp43" ID="radio43_6" runat="server" 
                                        
                                        
                                        Text="0- Most students accessing Tier 3 have not accessed Tier 1 or Tier 2 supports." /></td>
                            </tr>
                            
                            
                            </table>
                      </td>
                      </tr>
                        <%--TABLE H END--%>
                        
                        
                        
                              <%--TABLE I START--%>
                
                 <tr>
                    <td>
                        <table width="100%" border="1" cellpadding="4" cellspacing="0" bordercolor="#000000"  >
                            <tr>
                                <%--<td bgcolor="#C8E07F" style="width:5%"><asp:Label Font-Bold="True" ID="lblI" Font-Size="Large" 
                                        runat="server" Text="I"></asp:Label></td> --%> 
                                <td bgcolor="#C8E07F" style="width:29%" align="left" colspan="2">
                                <asp:Label Font-Bold="True" ID="lblI" Font-Size="Large" 
                                        runat="server" Text="I"></asp:Label>&nbsp;&nbsp;
                                    <asp:Label Font-Bold="True" ID="Label16" 
                                        runat="server" Text="Tier 3: Assessment and Plan Development"></asp:Label></td>
                                <td bgcolor="#C8E07F" style="width:22%" align="center">
                                    <asp:Label Font-Bold="True" ID="Label17" 
                                        runat="server" Text="2-Fully in Place"></asp:Label></td>
                                <td bgcolor="#C8E07F" style="width:22%" align="center">
                                    <asp:Label Font-Bold="True" ID="Label24" 
                                        runat="server" Text="1-Partially in Place"></asp:Label></td>
                                <td bgcolor="#C8E07F" style="width:22%" align="center"> 
                                    <asp:Label Font-Bold="True" ID="Label25" 
                                        runat="server" Text="0-Not Yet Started"></asp:Label></td>
                            </tr>
                            <tr>
                                <td >&nbsp;</td>
                                <td >&nbsp;</td>
                                <td >&nbsp;</td>
                                <td >&nbsp;</td>
                                <td >&nbsp;</td>
                            </tr>
                             <tr>
                                <%--<td  class="style5" >&nbsp;</td>--%>
                                <td colspan="5" >
                                    <asp:Label  ID="lbl68" runat="server" 
                                        
                                        
                                        Text="44.	The problem behaviors are operationally defined."></asp:Label></td>
                            </tr>
                            
                             <tr>
                                <%--<td  class="style5" >&nbsp;</td>--%>
                                <td >&nbsp;</td>
                                <td valign="top" align="left" colspan="4">
                                    <asp:RadioButton GroupName="grp44" ID="radio44_4" runat="server" 
                                        
                                        
                                        
                                        
                                        
                                        Text="2- The problem behaviors for all FBAs are measureable and observable." /></td>
                            </tr>
                            
                             <tr>
                                <%--<td  class="style5" >&nbsp;</td>--%>
                                <td >&nbsp;</td>
                                <td valign="top" align="left" colspan="4">
                                  <asp:RadioButton GroupName="grp44" ID="radio44_5" runat="server" 
                                      
                                      
                                      
                                      
                                      Text="1- The problem behaviors for some FBAs are measureable and observable." /></td>
                            </tr>
                            
                             <tr>
                               <%-- <td  class="style5" >&nbsp;</td>--%>
                                <td >&nbsp;</td>
                                <td valign="top" align="left" colspan="4">
                                    <asp:RadioButton GroupName="grp44" ID="radio44_6" runat="server" 
                                        
                                        
                                        
                                        
                                        
                                        Text="0- The problem behaviors for FBAs are neither measureable nor observable." /></td>
                            </tr>
                            
                           <tr>
                               <%-- <td  bgcolor="#C8E07F"class="style5">&nbsp;</td>--%>
                                <td bgcolor="#C8E07F" colspan="5">
                                    <asp:Label  ID="lbl69" runat="server" 
                                        
                                        
                                        
                                        
                                        
                                        Text="45.	The problem statements (summary statement) define three components: antecedent(s), behavior(s), and consequence(s)."></asp:Label></td>
                            </tr>
                          
                          
                          
                           <tr>
                               <%-- <td  bgcolor="#C8E07F"class="style5">&nbsp;</td>--%>
                                <td bgcolor="#C8E07F">
                                    &nbsp;</td>
                                <td bgcolor="#C8E07F" valign="top" align="left" colspan="4">
                                    <asp:RadioButton GroupName="grp45" ID="radio45_4" 
                                        runat="server" 
                                        
                                        
                                        
                                        Text="2- Summary statements from the FBAs include all three components." /></td>
                            </tr>
                          
                          
                          
                           <tr>
                             <%--   <td  bgcolor="#C8E07F"class="style5">&nbsp;</td>--%>
                                <td bgcolor="#C8E07F">
                                    &nbsp;</td>
                                <td bgcolor="#C8E07F" valign="top" align="left" colspan="4">
                                  <asp:RadioButton GroupName="grp45" ID="radio45_5" 
                                      runat="server" 
                                      
                                      
                                      
                                      
                                        Text="1- Summary statements from the FBAs include 2 but not all 3 components; OR, the components are included inconsistently." /></td>
                            </tr>
                          
                          
                          
                           <tr>
                               <%-- <td  bgcolor="#C8E07F"class="style5">&nbsp;</td>--%>
                                <td bgcolor="#C8E07F">
                                    &nbsp;</td>
                                <td bgcolor="#C8E07F" valign="top" align="left" colspan="6">
                                    <asp:RadioButton GroupName="grp45" ID="radio45_6" 
                                        runat="server" 
                                        
                                        
                                        Text="0- Summary statements from the FBAs are not developed." /></td>
                            </tr>
                          
                          
                          
                           <tr>
                              <%--  <td  class="style5" >&nbsp;</td>--%>
                                <td colspan="5" ><asp:Label  ID="lbl70" runat="server" 
                                        
                                        
                                        Text="46.	Behavior intervention plans (BIPs) are developed by a team of individuals with documented knowledge about (a) the school context, (b) the student, and (c) behavioral theory."></asp:Label></td>
                            </tr>
                            
                            
                          
                           <tr>
                                <%--<td  class="style5" >&nbsp;</td>--%>
                                <td >&nbsp;</td>
                                <td valign="top" align="left" colspan="4">
                                    <asp:RadioButton GroupName="grp46" ID="radio46_5" runat="server" 
                                        
                                        
                                        
                                        
                                        
                                        
                                        Text="2- All BIPs are developed by teams with expertise in all 3 areas: school systems, student, and behavioral theory." /></td>
                            </tr>
                            
                            
                          
                           <tr>
                                <%--<td  class="style5" >&nbsp;</td>--%>
                                <td >&nbsp;</td>
                                <td valign="top" align="left" colspan="4">
                                  <asp:RadioButton GroupName="grp46" ID="radio46_4" runat="server" 
                                      
                                      
                                      
                                      
                                      
                                      
                                        Text="1- Some BIPs are developed by teams with expertise in all 3 areas; OR, BIPs are developed by teams with expertise in 2 of the 3 areas: school systems, student, and behavioral theory." /></td>
                            </tr>
                            
                            
                          
                           <tr>
                              <%--  <td  class="style5" >&nbsp;</td>--%>
                                <td >&nbsp;</td>
                                <td valign="top" align="left" colspan="4">
                                    <asp:RadioButton GroupName="grp46" 
                                        ID="radio46_6" runat="server" 
                                        
                                        
                                        
                                        
                                        
                                        
                                        Text="0- BIPs are developed by teams without expertise in these areas OR with expertise only 1 area." /></td>
                            </tr>
                            
                            
                                  <tr>
                                <%--<td bgcolor="#C8E07F" class="style5">&nbsp;</td>--%>
                                <td bgcolor="#C8E07F" colspan="5">
                                    <asp:Label  ID="lbl71" runat="server" 
                                        Text="47.	The Tier 3 approach includes procedures that allow a continuum of strategies to match student needs (e.g. single-element interventions, multi-component interventions, wrap around, life-style enhancement, medical supports)."></asp:Label></td>
                            </tr>
                          
                            
                                  <tr>
                               <%-- <td bgcolor="#C8E07F" class="style5">&nbsp;</td>--%>
                                <td bgcolor="#C8E07F">
                                    &nbsp;</td>
                                <td bgcolor="#C8E07F" valign="top" align="left" colspan="4">
                                    <asp:RadioButton GroupName="grp47" ID="radio47_4" 
                                        runat="server" 
                                        Text="2- A range of Tier 3 supports are available for students, ranging from simple to complex." /></td>
                            </tr>
                          
                            
                                  <tr>
                                <%--<td bgcolor="#C8E07F" class="style5">&nbsp;</td>--%>
                                <td bgcolor="#C8E07F">
                                    &nbsp;</td>
                                <td bgcolor="#C8E07F" valign="top" align="left" colspan="4">
                                  <asp:RadioButton GroupName="grp47" ID="radio47_5" 
                                      runat="server" 
                                      
                                      
                                      
                                      
                                        Text="1- The school has one Tier 3 process that is applied to all students receiving Tier 3 supports." /></td>
                            </tr>
                          
                            
                                  <tr>
                                <%--<td bgcolor="#C8E07F" class="style5">&nbsp;</td>--%>
                                <td bgcolor="#C8E07F">
                                    &nbsp;</td>
                                <td bgcolor="#C8E07F" valign="top" align="left" colspan="4">
                                    <asp:RadioButton GroupName="grp47" ID="radio47_6" 
                                        runat="server" 
                                        
                                        
                                        
                                        
                                        Text="0- The school lacks any adequate system of support for students needing Tier 3 supports." /></td>
                            </tr>
                          
                               <tr>
                               <%-- <td  class="style5" >&nbsp;</td>--%>
                                <td colspan="5" ><asp:Label  ID="lbl72" runat="server" 
                                        
                                        
                                        Text="48.	Behavior intervention plans (BIPs) include a problem statement (summary statement) with (a) operational definition of problem behavior(s), (b) antecedent events, and (c) consequences that maintain the problem behavior."></asp:Label></td>
                            </tr>
                          
                               <tr>
                                <%--<td  class="style5" >&nbsp;</td>--%>
                                <td >&nbsp;</td>
                                <td  valign="top" align="left" colspan="4">
                                    <asp:RadioButton GroupName="grp48" ID="radio48_4" runat="server" 
                                        Text="2- Summary statements from the FBAs include all three components for all behavior support plans." /></td>
                            </tr>
                          
                               <tr>
                                <%--<td  class="style5" >&nbsp;</td>--%>
                                <td >&nbsp;</td>
                                <td  valign="top" align="left" colspan="4">
                                  <asp:RadioButton GroupName="grp48" ID="radio48_6" runat="server" 
                                        Text="1- Summary statements from the FBAs include 2 but not all 3 components; OR, the components are included inconsistently in behavior support plans." /></td>
                            </tr>
                          
                               <tr>
                                <%--<td  class="style5" >&nbsp;</td>--%>
                                <td >&nbsp;</td>
                                <td  valign="top" align="left" colspan="4">
                                    <asp:RadioButton GroupName="grp48" 
                                        ID="radio48_5" runat="server" 
                                        Text="0- Summary statements from the FBAs are not developed for behavior support plans." /></td>
                            </tr>
                                            <tr>
                                <%--<td bgcolor="#C8E07F" class="style5">&nbsp;</td>--%>
                                <td bgcolor="#C8E07F" colspan="5">
                                    <asp:Label  ID="lbl74" runat="server" 
                                        Text="49.	Based on an FBA, the BIPs include strategies for preventing problem behavior, if appropriate."></asp:Label></td>
                            </tr>
                          
                                            <tr>
                                <%--<td bgcolor="#C8E07F" class="style5">&nbsp;</td>--%>
                                <td bgcolor="#C8E07F">
                                    &nbsp;</td>
                                <td bgcolor="#C8E07F" valign="top" align="left" colspan="4" dir="ltr">
                                    <asp:RadioButton GroupName="grp49" ID="radio49_4" 
                                        runat="server" Text="2- Over 80% of BIPs include prevention strategies." /></td>
                            </tr>
                          
                                            <tr>
                                <%--<td bgcolor="#C8E07F" class="style5">&nbsp;</td>--%>
                                <td bgcolor="#C8E07F">
                                    &nbsp;</td>
                                <td bgcolor="#C8E07F" valign="top" align="left" colspan="4">
                                  <asp:RadioButton GroupName="grp49" ID="radio49_5" 
                                      runat="server" Text="1- Over 50% of BIPs include prevention strategies." /></td>
                            </tr>
                          
                                            <tr>
                                <%--<td bgcolor="#C8E07F" class="style5">&nbsp;</td>--%>
                                <td bgcolor="#C8E07F">
                                    &nbsp;</td>
                                <td bgcolor="#C8E07F" valign="top" align="left" colspan="4">
                                    <asp:RadioButton GroupName="grp49" ID="radio49_6" 
                                        runat="server" 
                                        
                                        
                                        
                                        Text="0- Less than 50% of BIPs include prevention strategies." /></td>
                            </tr>
                          
                             <tr>
                              <%--  <td  class="style5" >&nbsp;</td>--%>
                                <td colspan="5" ><asp:Label  ID="lbl73" runat="server" 
                                        
                                        
                                        Text="50.	Based on an FBA, the BIPs include strategies for minimizing reward of problem behavior, if appropriate."></asp:Label></td>
                            </tr>
                            
                             <tr>
                              <%--  <td  class="style5" >&nbsp;</td>--%>
                                <td >&nbsp;</td>
                                <td  valign="top" align="left" colspan="4">
                                    <asp:RadioButton GroupName="grp49" ID="radio50_4" 
                                        runat="server" Text="2- Over 80% of BIPs include prevention strategies." /></td>
                            </tr>
                            
                             <tr>
                                <%--<td  class="style5" >&nbsp;</td>--%>
                                <td >&nbsp;</td>
                                <td  valign="top" align="left" colspan="4">
                                  <asp:RadioButton GroupName="grp50" ID="radio50_5" runat="server" 
                                        Text="1- Over 50% of BIPs include strategies to minimize rewards for problem behavior." /></td>
                            </tr>
                            
                             <tr>
                                <%--<td  class="style5" >&nbsp;</td>--%>
                                <td >&nbsp;</td>
                                <td  valign="top" align="left" colspan="4">
                                    <asp:RadioButton GroupName="grp50" 
                                        ID="radio50_6" runat="server" 
                                        Text="0- Less than 50% of BIPs include strategies to minimize rewards for problem behavior." /></td>
                            </tr>
                            
                              <tr>
                              <%--  <td bgcolor="#C8E07F" class="style5">&nbsp;</td>--%>
                                <td bgcolor="#C8E07F" colspan="5">
                                    <asp:Label  ID="lbl75" runat="server" 
                                        Text="51.	Based on an FBA, the BIPs include strategies for rewarding appropriate behavior, if appropriate."></asp:Label></td>
                            </tr>
                          
                          
                              <tr>
                              <%--  <td bgcolor="#C8E07F" class="style5">&nbsp;</td>--%>
                                <td bgcolor="#C8E07F">
                                    &nbsp;</td>
                                <td bgcolor="#C8E07F" valign="top" align="left" colspan="4">
                                    <asp:RadioButton GroupName="grp51" ID="radio51_4" 
                                        runat="server" Text="2- Over 80% of BIPs include reward strategies." /></td>
                            </tr>
                          
                          
                              <tr>
                               <%-- <td bgcolor="#C8E07F" class="style5">&nbsp;</td>--%>
                                <td bgcolor="#C8E07F">
                                    &nbsp;</td>
                                <td bgcolor="#C8E07F" valign="top" align="left" colspan="4">
                                  <asp:RadioButton GroupName="grp51" ID="radio51_5" 
                                      runat="server" Text="1- Over 50% of BIPs include reward strategies" /></td>
                            </tr>
                          
                          
                              <tr>
                               <%-- <td bgcolor="#C8E07F" class="style5">&nbsp;</td>--%>
                                <td bgcolor="#C8E07F">
                                    &nbsp;</td>
                                <td bgcolor="#C8E07F" valign="top" align="left" colspan="4">
                                    <asp:RadioButton GroupName="grp51" ID="radio51_6" 
                                        runat="server" 
                                        
                                        
                                        
                                        Text="0- Less than 50% of BIPs include reward strategies." /></td>
                            </tr>
                          
                          
                           <tr>
                                <%--<td  class="style5" >&nbsp;</td>--%>
                                <td colspan="5" ><asp:Label  ID="LBL76" runat="server" 
                                        
                                        
                                        Text="52.	Based on an FBA, the BIPs include strategies for ensuring physical safety, if appropriate."></asp:Label></td>
                            </tr>
                          
                          
                           <tr>
                              <%--  <td  class="style5" >&nbsp;</td>--%>
                                <td >&nbsp;</td>
                                <td  valign="top" align="left" colspan="4">
                                    <asp:RadioButton GroupName="grp52" ID="radio52_4" runat="server" 
                                        Text="2- Over 80% of BIPs include strategies for ensuring safety." /></td>
                            </tr>
                          
                          
                           <tr>
                             <%--   <td  class="style5" >&nbsp;</td>--%>
                                <td >&nbsp;</td>
                                <td  valign="top" align="left" colspan="4">
                                  <asp:RadioButton GroupName="grp52" ID="radio52_5" runat="server" 
                                        Text="1- Over 50% of BIPs include strategies for ensuring safety." /></td>
                            </tr>
                          
                          
                           <tr>
                                <%--<td  class="style5" >&nbsp;</td>--%>
                                <td >&nbsp;</td>
                                <td  valign="top" align="left" colspan="4">
                                    <asp:RadioButton GroupName="grp52" 
                                        ID="radio52_6" runat="server" 
                                        Text="0- Less than 50% of BIPs include strategies for ensuring safety." /></td>
                            </tr>
                              <tr>
                               <%-- <td bgcolor="#C8E07F" class="style5">&nbsp;</td>--%>
                                <td bgcolor="#C8E07F" colspan="5">
                                    <asp:Label  ID="lbl77" runat="server" 
                                        Text="53.	BIPs include a formal action plan for developing,   teaching, coaching, and supporting the core elements of the Tier 3 strategies."></asp:Label></td>
                            </tr>
                          
                              <tr>
                               <%-- <td bgcolor="#C8E07F" class="style5">&nbsp;</td>--%>
                                <td bgcolor="#C8E07F">
                                    &nbsp;</td>
                                <td bgcolor="#C8E07F" valign="top" align="left" colspan="4">
                                    <asp:RadioButton GroupName="grp53" ID="radio53_6" 
                                        runat="server" Text="2- Over 80% of BIPs include a documented action plan." /></td>
                            </tr>
                          
                              <tr>
                                <%--<td bgcolor="#C8E07F" class="style5">&nbsp;</td>--%>
                                <td bgcolor="#C8E07F">
                                    &nbsp;</td>
                                <td bgcolor="#C8E07F" valign="top" align="left" colspan="4">
                                  <asp:RadioButton GroupName="grp53" ID="radio53_5" 
                                      runat="server" Text="1- Over 50% of BIPs include a documented action plan." /></td>
                            </tr>
                          
                              <tr>
                               <%-- <td bgcolor="#C8E07F" class="style5">&nbsp;</td>--%>
                                <td bgcolor="#C8E07F">
                                    &nbsp;</td>
                                <td bgcolor="#C8E07F" valign="top" align="left" colspan="4">
                                    <asp:RadioButton GroupName="grp53" ID="radio53_4" 
                                        runat="server" 
                                        
                                        
                                        
                                        Text="0- Less than 50% of BIPs include documented action plans" /></td>
                            </tr>
                          
                        </table>
                    </td>
                </tr>   
                
                        <%--TABLE I END--%>
                        
                      <%--  TABLE J START--%>
                        
                        
                                           
                
                 <tr>
                    <td>
                        <table width="100%" border="1" cellpadding="4" cellspacing="0" bordercolor="#000000"  >
                            <tr>
                               <%-- <td  style="width:5%"><asp:Label Font-Bold="True" ID="lblJ" Font-Size="Large" 
                                        runat="server" Text="J"></asp:Label></td>  --%>
                                <td style="width:29%" align="center">
                                <asp:Label Font-Bold="True" ID="lblJ" Font-Size="Large" 
                                        runat="server" Text="J"></asp:Label>&nbsp;&nbsp;
                                    <asp:Label Font-Bold="True" ID="Label27" 
                                        runat="server" Text="Tier 3: Assessment and Plan Development"></asp:Label></td>
                                <td style="width:22%" align="center">
                                    <asp:Label Font-Bold="True" ID="Label28" 
                                        runat="server" Text="2-Fully in Place"></asp:Label></td>
                                <td style="width:22%" align="center">
                                    <asp:Label Font-Bold="True" ID="Label29" 
                                        runat="server" Text="1-Partially in Place"></asp:Label></td>
                                <td style="width:22%" align="center" colspan="2"> 
                                    <asp:Label Font-Bold="True" ID="Label30" 
                                        runat="server" Text="0-Not Yet Started"></asp:Label></td>
                            </tr>
                            <tr>
                                <td >&nbsp;</td>
                                <td >&nbsp;</td>
                                <td >&nbsp;</td>
                                <td >&nbsp;</td>
                                <td >&nbsp;</td>
                            </tr>
                             <tr>
                                <%--<td  bgcolor="#C8E07F" >&nbsp;</td>--%>
                                <td bgcolor="#C8E07F" colspan="5"><asp:Label  ID="lbl78" runat="server" 
                                        
                                        
                                        
                                        Text="54.	The team formally progress monitors impact of each Tier 3 support plan."></asp:Label></td>
                            </tr>
                            
                             <tr>
                                <%--<td  bgcolor="#C8E07F" >&nbsp;</td>--%>
                                <td bgcolor="#C8E07F">&nbsp;</td>
                                <td bgcolor="#C8E07F" valign="top" align="left" colspan="4">
                                    <asp:RadioButton GroupName="grp54" ID="radio54_6" runat="server" 
                                        
                                        
                                        
                                        
                                        
                                        Text="2- Data are collected daily and graphed for analysis (at least twice per month) for each student receiving Tier 3 support." /></td>
                            </tr>
                            
                             <tr>
                                <%--<td  bgcolor="#C8E07F" >&nbsp;</td>--%>
                                <td bgcolor="#C8E07F">&nbsp;</td>
                                <td bgcolor="#C8E07F" valign="top" align="left" colspan="4">
                                  <asp:RadioButton GroupName="grp54" ID="radio54_5" runat="server" 
                                      
                                      
                                      
                                      
                                      
                                        Text="1- Data are collected and analyzed twice per month for some students or data are collected and analyzed but less than twice per month." /></td>
                            </tr>
                            
                             <tr>
                               <%-- <td  bgcolor="#C8E07F" >&nbsp;</td>--%>
                                <td bgcolor="#C8E07F">&nbsp;</td>
                                <td bgcolor="#C8E07F" valign="top" align="left" colspan="4">
                                    <asp:RadioButton GroupName="grp54" ID="radio54_4" runat="server" 
                                        
                                        
                                        
                                        
                                        
                                        Text="0- A data-based system is not used to collect student behavior data or student behavior data are collected/monitored infrequently (once per month or less)." /></td>
                            </tr>
                            
                           <tr>
                                <%--<td>&nbsp;</td>--%>
                                <td colspan="5">
                                    <asp:Label  ID="lbl79" runat="server" 
                                        
                                        
                                        
                                        
                                        
                                        Text="55.	Data collected on student behavior is used to assess intervention effects and make modifications as needed."></asp:Label></td>
                            </tr>
                          
                          
                          
                           <tr>
                                <%--<td>&nbsp;</td>--%>
                                <td>
                                    &nbsp;</td>
                                <td  valign="top" align="left" colspan="4">
                                    <asp:RadioButton GroupName="grp55" ID="radio55_6" 
                                        runat="server" 
                                        
                                        
                                        
                                        
                                        Text="2- Data collected on student behavior is used to assess intervention effects and make modifications as needed and this occurs at least every other week." /></td>
                            </tr>
                          
                          
                          
                           <tr>
                               <%-- <td>&nbsp;</td>--%>
                                <td>
                                    &nbsp;</td>
                                <td  valign="top" align="left" colspan="4">
                                  <asp:RadioButton GroupName="grp55" ID="radio55_5" 
                                      runat="server" 
                                      
                                      
                                      
                                      
                                        Text="1- Data are used to monitor intervention effects and modify interventions but this occurs less often than every two weeks for some or all students" /></td>
                            </tr>
                          
                          
                          
                           <tr>
                               <%-- <td>&nbsp;</td>--%>
                                <td>
                                    &nbsp;</td>
                                <td  valign="top" align="left" colspan="4">
                                    <asp:RadioButton GroupName="grp55" ID="radio55_4" 
                                        runat="server" Text="0- Data are not used to assess intervention effects." /></td>
                            </tr>
                          
                          
                          
                           <tr>
                               <%-- <td bgcolor="#C8E07F" class="style5" >&nbsp;</td>--%>
                                <td bgcolor="#C8E07F" colspan="5"><asp:Label  ID="lbl80" runat="server" 
                                        
                                        
                                        Text="56.	Intervention plans include a process for monitoring fidelity of implementation."></asp:Label></td>
                            </tr>
                          
                          
                          
                           <tr>
                                <%--<td bgcolor="#C8E07F" class="style5" >&nbsp;</td>--%>
                                <td bgcolor="#C8E07F">&nbsp;</td>
                                <td bgcolor="#C8E07F" valign="top" align="left" colspan="4">
                                    <asp:RadioButton GroupName="grp56" ID="radio56_6" runat="server" 
                                        
                                        
                                        
                                        
                                        
                                        
                                        Text="2- Intervention plans contain a process for monitoring how well an intervention is implemented at least every 2 weeks." /></td>
                            </tr>
                          
                          
                          
                           <tr>
                                <%--<td bgcolor="#C8E07F" class="style5" >&nbsp;</td>--%>
                                <td bgcolor="#C8E07F">&nbsp;</td>
                                <td bgcolor="#C8E07F" valign="top" align="left" colspan="4">
                                  <asp:RadioButton GroupName="grp56" ID="radio56_5" runat="server" 
                                      
                                      
                                      
                                      
                                      
                                      
                                        Text="1- Intervention plans contain a process for monitoring how well an intervention is implemented, but at intervals greater than every 2 weeks, OR the process is inconsistent." /></td>
                            </tr>
                          
                          
                          
                           <tr>
                                <%--<td bgcolor="#C8E07F" class="style5" >&nbsp;</td>--%>
                                <td bgcolor="#C8E07F">&nbsp;</td>
                                <td bgcolor="#C8E07F" valign="top" align="left" colspan="7">
                                    <asp:RadioButton GroupName="grp56" 
                                        ID="radio56_4" runat="server" 
                                        
                                        
                                        
                                        
                                        
                                        
                                        Text="0- There is no process in the intervention plan for monitoring how well the intervention is implemented." /></td>
                            </tr>
                          
                        </table>
                    </td>
                </tr>   
                        <%--TABLE J END--%>
            </table>
            <br />
              <P align="center"><span class="contentText"><a HREF="javascript:window.print()">CLICK HERE TO PRINT THE FORM <strong>BEFORE</strong> SUBMITTING!!</a></span><a HREF="javascript:window.print()"></a>
                  <p align="center">
                  
                  <asp:Button ID="btnsubmit" runat="server" Text="Submit" BackColor="Beige" BorderColor="#C8E07F" BorderWidth="3" OnClientClick="return checkBATForm('Form1');" />
              
    </td>
    
</tr>
</asp:Content>