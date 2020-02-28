<%@ Page Language="VB" MasterPageFile="~/pbsmaster/Detail.master" AutoEventWireup="false" CodeFile="endyrslr_bat.aspx.vb" Inherits="pbsisrpts_endyrslr_bat" %>

<asp:Content ID ="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <tr>
        <td>
<table width="100%"  border="0" cellspacing="0" cellpadding="0">
        <tr>
          <td colspan="7"><img src="../images/box-top.gif" width="800" height="1"></td>
        </tr>
       
        <tr>
          <td height="30" colspan="5" align="left" valign="middle" bgcolor="#91BB4D"><div align="center" class="style6">
            <div align="center">SCHOOL-WIDE BENCHMARKS OF ADVANCE TIERS: SCORING RESULTS </div>
             <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
          </div></td>
        </tr>
        
		<tr>
          <td width="9" rowspan="80" align="left" valign="top" bgcolor="#91BB4D">&nbsp;</td>
          <td width="142" height="27" align="left" valign="middle" bgcolor="#91BB4D"><span class="style6">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<b>School Name</b></span></td>
          <td width="449" align="left" valign="middle" bgcolor="#FFFFFF" class="style17">&nbsp;<asp:Label ID="lblSchoolName" runat="server"></asp:Label></td>
          <td width="74" align="left" valign="middle" bgcolor="#91BB4D" class="style6"><div align="right"><b>Year</b>&nbsp; </div></td>
          <td width="115" align="left" valign="middle" bgcolor="#91BB4D" class="style17"><div align="center">&nbsp;<%--<asp:Label ID="lblYear" runat="server"></asp:Label>--%>
          
                    
                <asp:DropDownList ID="ddlYear" runat="server" AutoPostBack="true">
                   <%-- <asp:ListItem Text="2004-2005" Value="8"></asp:ListItem>
                    <asp:ListItem Text="2005-2006" Value="9"></asp:ListItem>
                    <asp:ListItem Text="2006-2007" Value="10"></asp:ListItem>
                    <asp:ListItem Text="2007-2008" Value="11"></asp:ListItem>
                    <asp:ListItem Text="2008-2009" Value="12"></asp:ListItem>
                    <asp:ListItem Text="2009-2010" Value="13"></asp:ListItem>--%>
                  </asp:DropDownList>
          
          
          </div></td>
           <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        </tr>
        
		<tr>
          <td height="24" align="left" valign="middle" bgcolor="#91BB4D"><span class="style6">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<b>District Name</b> </span></td>
          <td height="24" align="left" valign="middle" bgcolor="#FFFFFF" class="style17">&nbsp;<asp:Label ID="lblDistrictName" runat="server"></asp:Label></td>
          <td colspan="2" align="left" valign="top" bgcolor="#91BB4D">&nbsp;</td>
           <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        </tr>
		
		<tr>
          <td height="24" align="left" valign="middle" bgcolor="#91BB4D"><span class="style6">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<b> Coach Name</b> </span></td>
          <td height="24" align="left" valign="middle" bgcolor="#FFFFFF" class="style17">&nbsp;<asp:Label ID="lblCoachName" runat="server"></asp:Label></td>
          <td colspan="2" align="left" valign="top" bgcolor="#91BB4D">&nbsp;</td>
           <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        </tr>
        
        <tr>
          <td height="24" align="left" valign="middle" bgcolor="#91BB4D"><b>&nbsp;&nbsp;&nbsp;&nbsp; Team Leader</b>
          </td>
          <td height="24" align="left" valign="middle" bgcolor="#FFFFFF" class="style17">&nbsp;<asp:Label ID="lblTeamleader" runat="server"></asp:Label></td>
          <td colspan="2" align="left" valign="top" bgcolor="#91BB4D">&nbsp;</td>
           <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        </tr>
            <tr>
          <td height="24" align="left" valign="middle" bgcolor="#91BB4D"><b>&nbsp; Team Members</b>
          </td>
          <td height="24" align="left" valign="middle" bgcolor="#FFFFFF" class="style17">&nbsp;<asp:Label ID="lblTeammember" runat="server"></asp:Label></td>
          <td colspan="2" align="left" valign="top" bgcolor="#91BB4D">&nbsp;</td>
           <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        </tr>
		<tr>
		  <td height="18" align="left" valign="top" bgcolor="#91BB4D">&nbsp;</td>
		  <td height="18" colspan="2" align="left" valign="top" bgcolor="#91BB4D">&nbsp;</td>
		  <td height="18" align="left" valign="top" bgcolor="#91BB4D">&nbsp;</td>
		   <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
	    </tr>
		
          </tr>
	     
        <tr>
		  <td align="left" valign="top" bgcolor="#FFFFFF" colspan="4" style="height: 18px">
              <strong>Tier 1: Implementation of School-wide PBS</strong>&nbsp;&nbsp;</td>
		  <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
	    </tr>
	     <tr><td colspan="4" bgcolor="#91BB4D" style="height: 19px">
           &nbsp;</td>
           <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
           
           </tr>
        <tr>
          <td height="18" align="left" valign="top" bgcolor="#91BB4D"><span class="style6">&nbsp;<b>Critical Elements</b></span></td>
		  <td height="18" colspan="2" align="left" valign="top" bgcolor="#91BB4D"><span class="style6">&nbsp;<b>Benchmarks of Advanced Tiers</b></span></td>
          <td height="18" align="left" valign="top" bgcolor="#91BB4D" 
                style="text-align: center"><strong class="style6">Response </strong></td>
           <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        </tr>
	
		
		<tr>
		  <td height="36" align="left" valign="top" bgcolor="#D9D3EB">&nbsp;</td>
          <td height="36" colspan="2" align="left" valign="middle" bgcolor="#D9D3EB" class="style17">1.	School-wide PBS, Tier 1/Universal intervention is in place as measured by scores on the SET, BoQ, TIC, or Bat.</td>
          <td align="left" valign="middle" bgcolor="#D9D3EB" class="style17"><div align="center" class="style16">
          
              <asp:Label Font-Bold="True" ID="lblBATQuestion1" runat="server"></asp:Label></div></td>     
               <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>     
        </tr>
        
		<tr>
		  <td height="36" align="left" valign="top" bgcolor="#D9D3EB">&nbsp;</td>
          <td height="36" colspan="2" align="left" valign="middle" bgcolor="#FFFFFF" class="style17">2.	Team members agree that school-wide PBS is in place and is implemented consistently by teachers and staff.</td>
          <td align="left" valign="middle" bgcolor="#FFFFFF" class="style17"><div align="center" class="style16">
              <asp:Label Font-Bold="True" ID="lblBATQuestion2" runat="server"></asp:Label></div></td>       
               <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>   
        </tr>
        
		<tr>
		  <td height="36" align="left" valign="top" bgcolor="#D9D3EB">&nbsp;</td>
          <td height="36" colspan="2" align="left" valign="middle" bgcolor="#D9D3EB" class="style17">3.	A data system is in place for documenting office discipline referrals that includes (a) problem behavior, (b) time of day, (c) location, (d) possible motivation, (e) others involved, and (f) administrative decision taken as a result of the problem behavior.</td>
          <td align="left" valign="middle" bgcolor="#D9D3EB" class="style17"><div align="center">
              <asp:Label Font-Bold="True" ID="lblBATQuestion3" runat="server"></asp:Label></div></td>     
               <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>    
        </tr>

 <tr>
		  <td height="10" colspan="4" align="left" valign="top" bgcolor="#91BB4D"><strong>Tier 2 - 3: Foundations</strong> </td>
		  <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
	    </tr>
        <tr>
          <td height="36" align="left" valign="middle" bgcolor="#D9D3EB">
              <p style="text-indent: 1px; text-align: center">
              <span class="style17"><br>
COMMITMENT</span></p>
            </td>
		  <td height="36" colspan="2" align="left" valign="middle" bgcolor="#FFFFFF" class="style17">4.	There is crossover membership and/or communication that informs the Tier 1 team of the status of Tier 2 and Tier 3 supports</td>
          <td align="left" valign="middle" bgcolor="#FFFFFF" class="style17"><div align="center">
              <asp:Label Font-Bold="True" ID="lblBATQuestion4" runat="server"></asp:Label></div></td>
               <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        </tr>
		
        <tr>
          <td height="36" align="left" valign="top" bgcolor="#D9D3EB">&nbsp;</td>
          <td height="36" colspan="2" align="left" valign="middle" bgcolor="#D9D3EB" class="style17">5.	 A team/individual makes decisions about students receiving Tier 2 and Tier 3 supports.</td>
          <td align="left" valign="middle" bgcolor="#D9D3EB" class="style17"><div align="center">
              <asp:Label Font-Bold="True" ID="lblBATQuestion5" runat="server"></asp:Label></div></td>
               <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        </tr>
        
		<tr>
		  <td height="36" align="left" valign="top" bgcolor="#D9D3EB">&nbsp;</td>
          <td height="36" colspan="2" align="left" valign="middle" bgcolor="#FFFFFF" class="style17">6.	The number of students, program fidelity, and progress of students receiving Tier 2 and Tier 3 supports is reported to faculty.</td>
          <td align="left" valign="middle" bgcolor="#FFFFFF" class="style17"><div align="center">
              <asp:Label Font-Bold="True" ID="lblBATQuestion6" runat="server"></asp:Label></div></td>
               <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        </tr>
		<tr>
		  <td height="10" colspan="4" align="left" valign="top" bgcolor="#91BB4D">&nbsp;</td>
		   <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
	    </tr>
        
		<tr>
          <td rowspan="2" align="left" valign="middle" bgcolor="#D9D3EB">
              <p style="text-align: center">
                  <span class="style17">STUDENT 
              <br />
              IDENTIFICATION </span>
              </p>
            </td>
		  <td colspan="2" align="left" valign="middle" bgcolor="#D9D3EB" style="height: 5px"><span class="style17">7.	The school uses a data-based process for identifying students who may need Tier 2 and Tier 3 supports. &#61690; Screening        &#61690; ODRs      &#61690; Request for Assistance</span></td>
          <td align="left" valign="middle" bgcolor="#D9D3EB" class="style17" style="height: 5px"><div align="center">
              <asp:Label Font-Bold="True" ID="lblBATQuestion7" runat="server"></asp:Label></div></td>          
               <td width="4" align="left" valign="middle" bgcolor="#91BB4D" style="height: 5px"></td>
        </tr>
        <tr>
		  <td height="36" colspan="2" align="left" valign="middle" bgcolor="#FFFFFF" class="style17">8. All school staff have been trained in and know the process for requesting Tier 2 and Tier 3 support for students</td>
          <td align="left" valign="middle" bgcolor="#FFFFFF" class="style17"><div align="center">
              <asp:Label Font-Bold="True" ID="lblBATQuestion8" runat="server"></asp:Label></div></td>    
               <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>      
        </tr>
		
        <tr>
          <td height="36" align="left" valign="top" bgcolor="#D9D3EB">&nbsp;</td>
          <td height="36" colspan="2" align="left" valign="middle" bgcolor="#D9D3EB" class="style17">9.	Decisions about whether students get additional behavior support are made in a timely manner and staff are notified of decisions.</td>
          <td align="left" valign="middle" bgcolor="#D9D3EB" class="style17"><div align="center">
              <asp:Label Font-Bold="True" ID="lblBATQuestion9" runat="server"></asp:Label></div></td>
               <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        </tr>
        
		<tr>
		  <td height="36" align="left" valign="top" bgcolor="#D9D3EB">
              <p style="text-align: center">
                  MONITORING
              <br />
              AND EVALUATION</p>
            </td>
          <td height="36" colspan="2" align="left" valign="middle" bgcolor="#FFFFFF" class="style17">10.	Students receive support in a timely manner.</td>
          <td align="left" valign="middle" bgcolor="#FFFFFF" class="style17"><div align="center">
              <asp:Label Font-Bold="True" ID="lblBATQuestion10" runat="server"></asp:Label></div></td>
         
           <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        </tr>
        <tr>
		  <td height="10" colspan="4" align="left" valign="top" bgcolor="#91BB4D">&nbsp;</td>
	 <td height="10" colspan="4" align="left" valign="top" bgcolor="#91BB4D">&nbsp;</td>
	    </tr>
        <tr>
          <td height="36" align="left" valign="top" bgcolor="#D9D3EB">&nbsp;</td>
          <td height="36" colspan="2" align="left" valign="middle" bgcolor="#D9D3EB" class="style17">11.	The teacher(s) directly involved with students receiving Tier 2 and Tier 3 supports are notified about impact and changes to strategies.</td>
          <td align="left" valign="middle" bgcolor="#D9D3EB" class="style17"><div align="center">
              <asp:Label Font-Bold="True" ID="lblBATQuestion11" runat="server"></asp:Label></div></td>
               <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        </tr>
        
		<tr>
		  <td height="36" align="left" valign="top" bgcolor="#D9D3EB">&nbsp;</td>
          <td height="36" colspan="2" align="left" valign="middle" bgcolor="#FFFFFF" class="style17">12.	The primary family members of students receiving Tier 2 and 3 supports are notified about impact and changes to strategies</td>
          <td align="left" valign="middle" bgcolor="#FFFFFF" class="style17"><div align="center">
              <asp:Label Font-Bold="True" ID="lblBATQuestion12" runat="server"></asp:Label></div></td>
               <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        </tr>
        
		
		<tr>
		  <td height="10" colspan="4" align="left" valign="top" bgcolor="#91BB4D">&nbsp;</td>
	 <td height="10" colspan="4" align="left" valign="top" bgcolor="#91BB4D">&nbsp;</td>
	   
	    </tr>
	    
	    
        <tr>
		  <td align="left" valign="top" bgcolor="#FFFFFF" colspan="4" style="height: 18px">
              <strong>Tier 2: Targeted Interventions</strong></td>
		  <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
	    </tr>
        
        
		<tr>
		  <td height="10" colspan="4" align="left" valign="top" bgcolor="#91BB4D">&nbsp;</td>
		    <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
	    </tr>
        
		<tr>
          <td rowspan="2" align="left" valign="middle" bgcolor="#D9D3EB">&nbsp;</td>
		  <td height="36" colspan="2" align="left" valign="middle" bgcolor="#FFFFFF" class="style17">13.	The administrator is updated about which students receive Tier 2 supports.</td>
          <td align="left" valign="middle" bgcolor="#FFFFFF" class="style17"><div align="center">
              <asp:Label Font-Bold="True" ID="lblBATQuestion13" runat="server"></asp:Label></div></td>   
               <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
               </tr>
        
        
       <tr>
		 
          <td height="36" colspan="2" align="left" valign="middle" bgcolor="#D9D3EB" class="style17">14.	The Tier 2 team meets frequently.</td>
          <td align="left" valign="middle" bgcolor="#D9D3EB" class="style17">
              <div align="center"><asp:Label Font-Bold="True" ID="lblBATQuestion14" runat="server"></asp:Label></div></td>
               <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        </tr>
        
      
        
		<tr>
		  <td height="36" align="left" valign="top" bgcolor="#D9D3EB">
              <p style="text-align: center">
                  TIER 2 SUPPORT<br />
              SYSTEMS</p>
            </td>
          <td height="36" colspan="2" align="left" valign="middle" bgcolor="#FFFFFF" class="style17">15.	The Tier 2 team is formally trained on practices and systems required for implementation of Tier 2 support.</td>
          <td align="left" valign="middle" bgcolor="#FFFFFF" class="style17"><div align="center">
              <asp:Label Font-Bold="True" ID="lblBATQuestion15" runat="server"></asp:Label></div></td>
               <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        </tr>
        
		<tr>
		  <td height="36" align="left" valign="top" bgcolor="#D9D3EB">&nbsp;</td>
          <td height="36" colspan="2" align="left" valign="middle" bgcolor="#D9D3EB" class="style17">16.	Students receiving a Tier 2 strategy have full access to Tier 1 supports.</td>
          <td align="left" valign="middle" bgcolor="#D9D3EB" class="style18">
              <div align="center"><asp:Label Font-Bold="True" ID="lblBATQuestion16" runat="server"></asp:Label></div></td>
               <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        </tr>
        		        
		<tr>
          <td align="left" valign="middle" bgcolor="#D9D3EB">
              <span class="style17">&nbsp;</span></td>
		  <td height="36" colspan="2" align="left" valign="middle" bgcolor="#FFFFFF" class="style17">17.	Tier 2 strategies are evaluated and updated regularly. </td>
          <td align="left" valign="middle" bgcolor="#FFFFFF" class="style17"><div align="center">
              <asp:Label Font-Bold="True" ID="lblBATQuestion17" runat="server"></asp:Label></div></td> 
               <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        </tr>
		
		 <tr>
		  <td height="10" colspan="4" align="left" valign="top" bgcolor="#91BB4D">&nbsp;</td>
		    <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
	    </tr>
        <tr>
		  <td align="left" valign="top" bgcolor="#FFFFFF" colspan="4" style="height: 18px">
              <strong>Main Tier 2: Strategy Information</strong></td>
		  <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
	    </tr>
        
        
		<tr>
		  <td height="10" colspan="4" align="left" valign="top" bgcolor="#91BB4D">&nbsp;</td>
		    <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
	    </tr>
	    
	    <tr>
		<td align="left" valign="middle" bgcolor="#D9D3EB">
              <span class="style17">&nbsp;</span></td>
		  <td height="36" colspan="2" align="left" valign="middle" bgcolor="#FFFFFF" 
                class="style17" style="font-style: italic">The Tier 2/Targeted Intervention most often used:  Sample 8</td>
          <td align="left" valign="middle" bgcolor="#FFFFFF" class="style17"><div align="center">
              </div></td>
               <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        </tr>
        
        
		<tr>
		<td align="left" valign="middle" bgcolor="#D9D3EB">
              <span class="style17">&nbsp;</span></td>
		  <td height="36" colspan="2" align="left" valign="middle" bgcolor="#D9D3EB" class="style17">18.	There are personnel identified to coordinate and deliver the Tier 2 strategy.</td>
          <td align="left" valign="middle" bgcolor="#D9D3EB" class="style17"><div align="center">
              <asp:Label Font-Bold="True" ID="lblBATQuestion18" runat="server"></asp:Label></div></td>
               <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        </tr>
        
		<tr>
		  <td height="36" align="left" valign="top" bgcolor="#D9D3EB">&nbsp;</td>
          <td height="36" colspan="2" align="left" valign="middle" bgcolor="#FFFFFF" class="style17">19.	The Tier 2 strategy is consistent with school-wide expectations.</td>
          <td align="left" valign="middle" bgcolor="#FFFFFF" class="style17"><div align="center">
              <asp:Label Font-Bold="True" ID="lblBATQuestion19" runat="server"></asp:Label></div></td>
               <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        </tr>
        
		<tr>
		  <td height="36" align="left" valign="top" bgcolor="#D9D3EB">&nbsp;</td>
          <td height="36" colspan="2" align="left" valign="middle" bgcolor="#D9D3EB" class="style17">20.	The Tier 2 strategy is established within the school and does not need unique development for each participating student.</td>
          <td align="left" valign="middle" bgcolor="#D9D3EB" class="style17"><div align="center">
              <asp:Label Font-Bold="True" ID="lblBATQuestion20" runat="server"></asp:Label></div></td>
               <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        </tr>
		
		<tr>
		  <td height="36" align="left" valign="top" bgcolor="#D9D3EB">&nbsp;</td>
          <td height="36" colspan="2" align="left" valign="middle" bgcolor="#FFFFFF" class="style17">21.	The Tier 2 strategy includes a formal process for teaching appropriate behaviors.</td>
          <td align="left" valign="middle" bgcolor="#FFFFFF" class="style17"><div align="center">
              <asp:Label Font-Bold="True" ID="lblBATQuestion21" runat="server"></asp:Label></div></td>
               <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        </tr>
	
        
		<tr>
          <td  align="left" valign="middle" bgcolor="#D9D3EB">
              <p style="text-align: center">
                  MAIN TIER 2:<br />
              &nbsp;
              STRATEGY
              <br />
              IMPLEMENTATION</p>
            </td>
		  <td colspan="2" align="left" valign="middle" bgcolor="#D9D3EB" class="style17" 
                style="height: 34px">22.	The Tier 2 strategy includes regular opportunities for students to perform appropriate behaviors.</td>
          <td align="left" valign="middle" bgcolor="#D9D3EB" class="style17" style="height: 34px"><div align="center">
              <asp:Label Font-Bold="True" ID="lblBATQuestion22" runat="server"></asp:Label></div></td>
               <td width="4" align="left" valign="middle" bgcolor="#91BB4D" style="height: 34px"></td>
        </tr>
        
		<tr>
		<td  align="left" valign="middle" bgcolor="#D9D3EB">&nbsp;</td>
		  <td height="36" colspan="2" align="left" valign="middle" bgcolor="#FFFFFF" class="style17">23.	The Tier 2 strategy uses accurate and objective data to adapt, modify, and improve support.</td>
          <td align="left" valign="middle" bgcolor="#FFFFFF" class="style17"><div align="center">
              <asp:Label Font-Bold="True" ID="lblBATQuestion23" runat="server"></asp:Label></div></td>
               <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        </tr>
		
		<tr>
		  <td height="36" align="left" valign="top" bgcolor="#D9D3EB">&nbsp;</td>
          <td height="36" colspan="2" align="left" valign="middle" bgcolor="#D9D3EB" class="style17">24.	The Tier 2 strategy includes frequent communication with the family.</td>
          <td align="left" valign="middle" bgcolor="#D9D3EB" class="style17"><div align="center">
              <asp:Label Font-Bold="True" ID="lblBATQuestion24" runat="server"></asp:Label></div></td>
               <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        </tr>
        
		<tr>
		  <td height="36" align="left" valign="top" bgcolor="#D9D3EB">&nbsp;</td>
          <td height="36" colspan="2" align="left" valign="middle" bgcolor="#FFFFFF" class="style17">25.	The Tier 2 strategy has written materials that describe the core features, functions, and systems of the strategy.</td>
          <td align="left" valign="middle" bgcolor="#FFFFFF" class="style17"><div align="center">
              <asp:Label Font-Bold="True" ID="lblBATQuestion25" runat="server"></asp:Label></div></td>
               <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        </tr>
        
		<tr>
		  <td height="36" align="left" valign="top" bgcolor="#D9D3EB">&nbsp;</td>
          <td height="36" colspan="2" align="left" valign="middle" bgcolor="#D9D3EB" class="style17">26.	The Tier 2 strategy includes orientation material and procedures for the staff, substitutes, families and volunteers.</td>
          <td align="left" valign="middle" bgcolor="#D9D3EB" class="style17"><div align="center">
              <asp:Label Font-Bold="True" ID="lblBATQuestion26" runat="server"></asp:Label></div></td>
               <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        </tr>
		
		<tr>
		  <td height="36" align="left" valign="top" bgcolor="#D9D3EB">&nbsp;</td>
          <td height="36" colspan="2" align="left" valign="middle" bgcolor="#FFFFFF" class="style17">27.	The Tier 2 strategy is efficient.</td>
          <td align="left" valign="middle" bgcolor="#FFFFFF" class="style17"><div align="center">
              <asp:Label Font-Bold="True" ID="lblBATQuestion27" runat="server"></asp:Label></div></td>
               <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        </tr>
        
        <tr>
		  <td height="10" colspan="4" align="left" valign="top" bgcolor="#91BB4D">&nbsp;</td>
		   <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
	    </tr>
        
		<tr>
		  <td height="36" align="left" valign="top" bgcolor="#D9D3EB">&nbsp;</td>
          <td height="36" colspan="2" align="left" valign="middle" bgcolor="#D9D3EB" class="style17">28.	An information system is used to monitor the impact of the Tier 2 strategy.</td>
          <td align="left" valign="middle" bgcolor="#D9D3EB" class="style17"><div align="center">
              <asp:Label Font-Bold="True" ID="lblBATQuestion28" runat="server"></asp:Label></div></td>
               <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        </tr>
        
		
		
		
		<tr>
          <td rowspan="2" align="left" valign="middle" bgcolor="#D9D3EB">
              <p style="text-align: center">
              <span class="style17">MAIN TIER 2:<br />
              STRATEGY MONITORING
              <br />
              AND EVALUATION </span>
              </p>
            </td>
		  <td height="36" colspan="2" align="left" valign="middle" bgcolor="#FFFFFF" class="style17">29.	There are documented decision rules to decide which students access the strategy and the process is implemented consistently.</td>
          <td align="left" valign="middle" bgcolor="#FFFFFF" class="style17"><div align="center">
              <asp:Label Font-Bold="True" ID="lblBATQuestion29" runat="server"></asp:Label></div></td>
               <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        </tr>
        
		<tr>
		  <td height="36" colspan="2" align="left" valign="middle" bgcolor="#D9D3EB" class="style17">30.	Documented decision rules are used to monitor, modify, or discontinue student involvement in the Tier 2 strategy.</td>
          <td align="left" valign="middle" bgcolor="#D9D3EB" class="style17"><div align="center">
              <asp:Label Font-Bold="True" ID="lblBATQuestion30" runat="server"></asp:Label></div></td>
               <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        </tr>
        
		<tr>
		  <td height="36" align="left" valign="top" bgcolor="#D9D3EB">&nbsp;</td>
          <td height="36" colspan="2" align="left" valign="middle" bgcolor="#FFFFFF" class="style17">31.	Fidelity of the Tier 2 strategy is assessed..</td>
          <td align="left" valign="middle" bgcolor="#FFFFFF" class="style17"><div align="center">
              <asp:Label Font-Bold="True" ID="lblBATQuestion31" runat="server"></asp:Label></div></td>
               <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        </tr>
		<tr>
		  <td height="10" colspan="4" align="left" valign="top" bgcolor="#91BB4D">&nbsp;</td>
		   <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
	    </tr>
		<tr>
		  <td height="36" align="left" valign="top" bgcolor="#D9D3EB">&nbsp;</td>
          <td height="36" colspan="2" align="left" valign="middle" bgcolor="#D9D3EB" class="style17">32.	A team builds and implements Tier 3 behavior support plans.</td>
          <td align="left" valign="middle" bgcolor="#D9D3EB" class="style17"><div align="center">
              <asp:Label Font-Bold="True" ID="lblBATQuestion32" runat="server"></asp:Label></div></td>
               <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        </tr>
        
		<tr>
		  <td height="36" align="left" valign="top" bgcolor="#D9D3EB">&nbsp;</td>
          <td height="36" colspan="2" align="left" valign="middle" bgcolor="#FFFFFF" class="style17">33.	The Tier 3 support team includes individuals with knowledge about the school systems, the student, and behavioral theory (e.g., student, teacher, family member, administrator, behavior specialist, advocates).</td>
          <td align="left" valign="middle" bgcolor="#FFFFFF" class="style17"><div align="center">
              <asp:Label Font-Bold="True" ID="lblBATQuestion33" runat="server"></asp:Label></div></td>
               <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        </tr>
        
		<tr>
		  <td height="36" align="left" valign="top" bgcolor="#D9D3EB">&nbsp;</td>
          <td height="36" colspan="2" align="left" valign="middle" bgcolor="#D9D3EB" class="style17">34.	A person is identified to coordinate Tier 3 supports.</td>
          <td align="left" valign="middle" bgcolor="#D9D3EB" class="style17"><div align="center">
              <asp:Label Font-Bold="True" ID="lblBATQuestion34" runat="server"></asp:Label></div></td>
               <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        </tr>
	
		
		<tr>
          <td align="left" valign="middle" bgcolor="#D9D3EB">
              <span class="style17">&nbsp;</span></td>
		  <td height="36" colspan="2" align="left" valign="middle" bgcolor="#FFFFFF" class="style17">35.	The administrator is a member of the Tier 3 implementation team.</td>
          <td align="left" valign="middle" bgcolor="#FFFFFF" class="style17"><div align="center">
              <asp:Label Font-Bold="True" ID="lblBATQuestion35" runat="server"></asp:Label></div></td>
               <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        </tr>
        
		<tr>
		<td align="left" valign="middle" bgcolor="#D9D3EB">
              <span class="style17">&nbsp;</span></td>
		  <td height="36" colspan="2" align="left" valign="middle" bgcolor="#D9D3EB" class="style17">36.	Tier 3 team members have sufficient formal training in implementation of the Tier 3 support system.</td>
          <td align="left" valign="middle" bgcolor="#D9D3EB" class="style17"><div align="center">
              <asp:Label Font-Bold="True" ID="lblBATQuestion36" runat="server"></asp:Label></div></td>
               <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        </tr>
        
		<tr>
		  <td height="36" align="left" valign="top" bgcolor="#D9D3EB" 
                style="text-align: center">
              <span style="FONT-SIZE: 9pt; FONT-FAMILY: Arial">TIER 3: INTENSIVE
              <br />
              SUPPORT SYSTEMS</span></td>
          <td height="36" colspan="2" align="left" valign="middle" bgcolor="#FFFFFF" class="style17">37.	The Tier 3 team receives annual staff development in Tier 3 procedures.</td>
          <td align="left" valign="middle" bgcolor="#FFFFFF" class="style17"><div align="center">
              <asp:Label Font-Bold="True" ID="lblBATQuestion37" runat="server"></asp:Label></div></td>
               <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        </tr>
		
		<tr>
		  <td height="36" align="left" valign="top" bgcolor="#D9D3EB">&nbsp;</td>
          <td height="36" colspan="2" align="left" valign="middle" bgcolor="#D9D3EB" class="style17">38.	The team has an efficient and accurate data system for monitoring Tier 3 impact.</td>
          <td align="left" valign="middle" bgcolor="#D9D3EB" class="style17"><div align="center">
              <asp:Label Font-Bold="True" ID="lblBATQuestion38" runat="server"></asp:Label></div></td>
               <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        </tr>
        
		<tr>
		  <td height="36" align="left" valign="top" bgcolor="#D9D3EB">&nbsp;</td>
          <td height="36" colspan="2" align="left" valign="middle" bgcolor="#FFFFFF" class="style17">39.	The team reviews the Tier 3 process and considers modifications, as needed.</td>
          <td align="left" valign="middle" bgcolor="#FFFFFF" class="style17"><div align="center">
              <asp:Label Font-Bold="True" ID="lblBATQuestion39" runat="server"></asp:Label></div></td>
               <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        </tr>
        
		<tr>
		  <td height="36" align="left" valign="top" bgcolor="#D9D3EB">&nbsp;</td>
          <td height="36" colspan="2" align="left" valign="middle" bgcolor="#D9D3EB" class="style17">40.	The school has personnel to implement Tier 3 supports.</td>
          <td align="left" valign="middle" bgcolor="#D9D3EB" class="style17"><div align="center">
              <asp:Label Font-Bold="True" ID="lblBATQuestion40" runat="server"></asp:Label></div></td>
               <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        </tr>
		
		<tr>
		  <td height="36" align="left" valign="top" bgcolor="#D9D3EB">&nbsp;</td>
          <td height="36" colspan="2" align="left" valign="middle" bgcolor="#FFFFFF" class="style17">41.	The school facilitates involvement of family members of students receiving Tier 3 supports.</td>
          <td align="left" valign="middle" bgcolor="#FFFFFF" class="style17"><div align="center">
              <asp:Label Font-Bold="True" ID="lblBATQuestion41" runat="server"></asp:Label></div></td>
               <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        </tr>
		
        
        
		<tr>
          <td height="36" align="left" valign="top" bgcolor="#D9D3EB">
              <span class="style17">&nbsp;</span></td>
		  <td height="36" colspan="2" align="left" valign="middle" bgcolor="#D9D3EB" class="style17">42.	All faculty and staff are oriented to Tier 3 support implementation.</td>
          <td align="left" valign="middle" bgcolor="#D9D3EB" class="style17"><div align="center">
              <asp:Label Font-Bold="True" ID="lblBATQuestion42" runat="server"></asp:Label></div></td>
                <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        </tr>
        <tr>
        <td align="left" valign="middle" bgcolor="#D9D3EB">
              <span class="style17">&nbsp;</span></td>
          <td height="36" colspan="2" align="left" valign="middle" bgcolor="#FFFFFF" class="style17">43.	Students receiving Tier 3 support also have access to Tier 1 and/or Tier 2 supports.</td>
          <td align="left" valign="middle" bgcolor="#FFFFFF" class="style17"><div align="center">
              <asp:Label Font-Bold="True" ID="lblBATQuestion43" runat="server"></asp:Label></div></td>
                <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        </tr>
        <tr>
		  <td height="10" colspan="4" align="left" valign="top" bordercolor="#91BB4D" bgcolor="#91BB4D">&nbsp;</td>
		   <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
	    </tr>
		<tr>
		<td align="left" valign="middle" bgcolor="#D9D3EB">
              <span class="style17">&nbsp;</span></td>
          <td height="36" colspan="2" align="left" valign="middle" bgcolor="#D9D3EB" class="style17">44.	The problem behaviors are operationally defined.</td>
          <td align="left" valign="middle" bgcolor="#D9D3EB" class="style17"><div align="center">
              <asp:Label Font-Bold="True" ID="lblBATQuestion44" runat="server"></asp:Label></div></td>
                <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        </tr>
        
		<tr>
		<td align="left" valign="middle" bgcolor="#D9D3EB">
              <span class="style17">&nbsp;</span></td>
          <td height="36" colspan="2" align="left" valign="middle"  bgcolor="#FFFFFF" class="style17">45.	The problem statements (summary statement) define three components: antecedent(s), behavior(s), and consequence(s).</td>
          <td align="left" valign="middle" bgcolor="#FFFFFF"  class="style17"><div align="center">
              <asp:Label Font-Bold="True" ID="lblBATQuestion45" runat="server"></asp:Label></div></td>
                <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        </tr>
		
		<tr>
		<td align="left" valign="middle" bgcolor="#D9D3EB">
              <span class="style17">&nbsp;</span></td>
          <td height="36" colspan="2" align="left" valign="middle" bgcolor="#D9D3EB" class="style17">46.	Behavior intervention plans (BIPs) are developed by a team of individuals with documented knowledge about (a) the school context, (b) the student, and (c) behavioral theory.</td>
          <td align="left" valign="middle" bgcolor="#D9D3EB" class="style17"><div align="center">
              <asp:Label Font-Bold="True" ID="lblBATQuestion46" runat="server"></asp:Label></div></td>
                <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        </tr>
        
		<tr>
		<td align="left" valign="middle" bgcolor="#D9D3EB">
              <span class="style17">&nbsp;</span></td>
          <td height="36" colspan="2" align="left" valign="middle" bgcolor="#FFFFFF" class="style17">47.	The Tier 3 approach includes procedures that allow a continuum of strategies to match student needs (e.g. single-element interventions, multi-component interventions, wrap around, life-style enhancement, medical supports).</td>
          <td align="left" valign="middle" bgcolor="#FFFFFF" class="style17"><div align="center">
              <asp:Label Font-Bold="True" ID="lblBATQuestion47" runat="server"></asp:Label></div></td>
                <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        </tr>
        
		<tr>
		<td align="left" valign="middle" bgcolor="#D9D3EB" style="text-align: center">
              <span class="style17">&nbsp;TIER 3: ASSESSMENT AND<br />
              PLAN DEVELOPMENT</span></td>
          <td height="36" colspan="2" align="left" valign="middle" bgcolor="#D9D3EB" class="style17">48.	Behavior intervention plans (BIPs) include a problem statement (summary statement) with (a) operational definition of problem behavior(s), (b) antecedent events, and (c) consequences that maintain the problem behavior.</td>
          <td align="left" valign="middle" bgcolor="#D9D3EB" class="style17"><div align="center">
              <asp:Label Font-Bold="True" ID="lblBATQuestion48" runat="server"></asp:Label></div></td>
                <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        </tr>  
                
	       
		<tr>
          <td height="36" align="left" valign="top" bgcolor="#D9D3EB"><span class="style17"><br>
              &nbsp;</span></td>
		  <td height="36" colspan="2" align="left" valign="middle" bgcolor="#FFFFFF" class="style17">49.	Based on an FBA, the BIPs include strategies for preventing problem behavior, if appropriate.</td>
          <td align="left" valign="middle" bgcolor="#FFFFFF" class="style17"><div align="center">
              <asp:Label Font-Bold="True" ID="lblBATQuestion49" runat="server"></asp:Label></div></td>
                <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        </tr>
        
		<tr>
		<td align="left" valign="middle" bgcolor="#D9D3EB">
              <span class="style17">&nbsp;</span></td>
          <td height="36" colspan="2" align="left" valign="middle" bgcolor="#D9D3EB" class="style17">50.	Based on an FBA, the BIPs include strategies for minimizing reward of problem behavior, if appropriate.</td>
          <td align="left" valign="middle" bgcolor="#D9D3EB" class="style17"><div align="center">
              <asp:Label Font-Bold="True" ID="lblBATQuestion50" runat="server"></asp:Label></div></td>
                <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        </tr>
		
		<tr>
		<td align="left" valign="middle" bgcolor="#D9D3EB">
              <span class="style17">&nbsp;</span></td>
          <td height="36" colspan="2" align="left" valign="middle" bgcolor="#FFFFFF" class="style17">51.	Based on an FBA, the BIPs include strategies for rewarding appropriate behavior, if appropriate.</td>
          <td align="left" valign="middle" bgcolor="#FFFFFF" class="style17"><div align="center">
              <asp:Label Font-Bold="True" ID="lblBATQuestion51" runat="server"></asp:Label></div></td>
                <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        </tr>
        
		<tr>
		<td align="left" valign="middle" bgcolor="#D9D3EB">
              <span class="style17">&nbsp;</span></td>
          <td height="36" colspan="2" align="left" valign="middle" bgcolor="#D9D3EB" class="style17">52.	Based on an FBA, the BIPs include strategies for ensuring physical safety, if appropriate.</td>
          <td align="left" valign="middle" bgcolor="#D9D3EB" class="style17"><div align="center">
              <asp:Label Font-Bold="True" ID="lblBATQuestion52" runat="server"></asp:Label></div></td>
                <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        </tr>
        
		<tr>
		<td align="left" valign="middle" bgcolor="#D9D3EB">
              <span class="style17">&nbsp;</span></td>
          <td height="36" colspan="2" align="left" valign="middle" bgcolor="#FFFFFF" class="style17">53.	BIPs include a formal action plan for developing,   teaching, coaching, and supporting the core elements of the Tier 3 strategies.</td>
          <td align="left" valign="middle" bgcolor="#FFFFFF" class="style17"><div align="center">
              <asp:Label Font-Bold="True" ID="lblBATQuestion53" runat="server"></asp:Label></div></td>
                <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        </tr>
         </tr>
			<tr>
		  <td height="10" colspan="4" align="left" valign="top" bordercolor="#91BB4D" bgcolor="#91BB4D">&nbsp;</td>
		   <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
	    </tr>
	    
	    		<tr>
	    		<td align="left" valign="middle" bgcolor="#D9D3EB">
              <span class="style17">&nbsp;</span></td>
          <td height="36" colspan="2" align="left" valign="middle" bgcolor="#D9D3EB" class="style17">54.	The team formally progress monitors impact of each Tier 3 support plan.</td>
          <td align="left" valign="middle" bgcolor="#D9D3EB" class="style17"><div align="center">
              <asp:Label Font-Bold="True" ID="lblBATQuestion54" runat="server"></asp:Label></div></td>
                <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        </tr>
         </tr>
			
	    		<tr>
	    		<td align="left" valign="middle" bgcolor="#D9D3EB" style="text-align: center">
              <span class="style17">&nbsp;TIER 3: ASSESSMENT AND<br />
              PLAN DEVELOPMENT</span></td>
          <td height="36" colspan="2" align="left" valign="middle" bgcolor="#FFFFFF" class="style17">55.	Data collected on student behavior is used to assess intervention effects and make modifications as needed.</td>
          <td align="left" valign="middle" bgcolor="#FFFFFF" class="style17"><div align="center">
              <asp:Label Font-Bold="True" ID="lblBATQuestion55" runat="server"></asp:Label></div></td>
                <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        </tr>
         </tr>
		
	    		<tr>
	    		<td align="left" valign="middle" bgcolor="#D9D3EB">
              <span class="style17">&nbsp;</span></td>
          <td height="36" colspan="2" align="left" valign="middle" bgcolor="#D9D3EB" class="style17"> 56.	Intervention plans include a process for monitoring fidelity of implementation.</td>
          <td align="left" valign="middle" bgcolor="#D9D3EB"class="style17"><div align="center">
              <asp:Label Font-Bold="True" ID="lblBATQuestion56" runat="server"></asp:Label></div></td>
                <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        </tr>
         </tr>
			<tr>
		  <td height="10" colspan="4" align="left" valign="top" bgcolor="#91BB4D">&nbsp;</td>
		   <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
		
	    </tr>
        <tr>
          <td height="36" align="left" valign="middle" bgcolor="#91BB4D"></td>
		  <td height="36" colspan="2" align="left" valign="middle" bgcolor="#FFFFFF" class="style17"><span class="style17 footer style18">TOTAL SCORE </span></td>
          <td align="left" valign="middle" bgcolor="#FFFFFF" class="style17"></td>
                <td width="4" align="left" valign="middle" bgcolor="#FFFFFF" 
                style="text-align: center">
              <asp:Label Font-Bold="True" ID="lblBATTotalScore" runat="server"></asp:Label></td>
              <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        </tr>
	  
	<tr>
		  <td height="10" colspan="4" align="left" valign="top" bgcolor="#91BB4D">&nbsp;</td>
		   <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
		<td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
	    </tr>

		
        
    </table>
        </td>
    </tr>
</asp:Content>