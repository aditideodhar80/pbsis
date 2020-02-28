<%@ Page Language="VB" MasterPageFile="~/pbsmaster/Detail.master" AutoEventWireup="false" CodeFile="midyrslr_avgpic.aspx.vb" Inherits="pbsisrpts_midyrslr_avgpic" %>

<asp:Content ID ="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <tr>
        <td>
<table width="690" border="0" cellspacing="0" cellpadding="0">
  <tr>
    <td align="left" valign="top"></td>
  </tr>
    <tr>
        <td>

    <table width="100%"  border="0" cellspacing="0" cellpadding="0">
        <tr>
          <td colspan="7"><img src="../images/box-top.gif" width="800" height="1"></td>
        </tr>
        <tr>
          <td rowspan="72" align="left" valign="top"  bgcolor="#91BB4D">&nbsp;</td>
            <%--<td rowspan="70" align="left" valign="top" bgcolor="#91BB4D" style="width: 9px">&nbsp;</td>--%>
          <%--<td rowspan="72" background="../images/bounding-box-line-right-sid.gif" bgcolor="#91BB4D">&nbsp;</td>--%>
        </tr>
        <tr>
          <td colspan="5" align="left" valign="middle" bgcolor="#91BB4D" 
                style="height: 30px"><div align="center" class="style6" 
                  style="font-weight: bold">
            <div align="center">
                PBS IMPLEMENTATION CHECKLIST: SCORING RESULTS </div>
          </div></td>
        
        </tr>
        
		<tr>
          <%--<td rowspan="70" align="left" valign="top" bgcolor="#91BB4D" style="width: 9px">&nbsp;</td>--%>
          <td width="142" height="27" align="left" valign="middle" bgcolor="#91BB4D"><span class="style6">&nbsp;&nbsp;&nbsp;&nbsp;<b>&nbsp;School Name</b></span></td>
          <td width="449" align="left" valign="middle" bgcolor="#FFFFFF" class="style17">&nbsp;<asp:Label ID="lblSchoolName" runat="server"></asp:Label></td>
          <td width="74" align="left" valign="middle" bgcolor="#91BB4D" class="style6"><div align="right">
              <b>Year </b>&nbsp; </div></td>
          <td width="115" align="left" valign="middle" bgcolor="#91BB4D" class="style17"><div align="center">&nbsp;<%--<asp:Label ID="lblYear" runat="server"></asp:Label>--%>
          
          <asp:DropDownList ID="ddlYear" runat="server" AutoPostBack="true">
                    <asp:ListItem Text="2004-2005" Value="8"></asp:ListItem>
                    <asp:ListItem Text="2005-2006" Value="9"></asp:ListItem>
                    <asp:ListItem Text="2006-2007" Value="10"></asp:ListItem>
                    <asp:ListItem Text="2007-2008" Value="11"></asp:ListItem>
                    <asp:ListItem Text="2008-2009" Value="12"></asp:ListItem>
                    <asp:ListItem Text="2009-2010" Value="13"></asp:ListItem>
                  </asp:DropDownList>
          </div></td>
          <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
       
        </tr>
        
		<tr>
          <td height="24" align="left" valign="middle" bgcolor="#91BB4D"><span class="style6">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<b>District Name
              </b> </span></td>
          <td height="24" align="left" valign="middle" bgcolor="#FFFFFF" class="style17">&nbsp;<asp:Label ID="lblDistrictName" runat="server"></asp:Label></td>
          <td colspan="2" align="left" valign="top" bgcolor="#91BB4D">&nbsp;</td>
          <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
      
        </tr>
		
		<tr>
          <td height="24" align="left" valign="middle" bgcolor="#91BB4D"><span class="style6">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<b>Coach Name</b> </span></td>
          <td height="24" align="left" valign="middle" bgcolor="#FFFFFF" class="style17">&nbsp;<asp:Label ID="lblCoachName" runat="server"></asp:Label></td>
          <td colspan="2" align="left" valign="top" bgcolor="#91BB4D">&nbsp;</td>
          <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        
        </tr>
       
        <tr><td colspan="4" bgcolor="#91BB4D">
            &nbsp;</td>
            <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
          
            </tr>
		<tr>
		  <td height="18" align="left" valign="top" bgcolor="#FFFFFF" colspan="4">
              <strong>Tier 1 Universal PBS</strong>&nbsp;&nbsp;&nbsp;</td>
		  <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
		 
	    </tr>
	   <tr><td colspan="4" bgcolor="#91BB4D">
           &nbsp;</td>
           <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
          
           </tr>
		<tr>
          <td height="18" align="left" valign="top" bgcolor="#91BB4D" 
                style="font-weight: bold">&nbsp;Critical Elements</td>
		  <td height="18" colspan="2" align="left" valign="top" bgcolor="#91BB4D" 
                style="font-weight: bold">&nbsp;PBS Implementation Checklist</td>
          <td height="18" align="left" valign="top" bgcolor="#91BB4D"><strong class="style6">Response </strong></td>
          <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
          
        </tr>
        
		<tr>
          <td align="left" valign="middle" bgcolor="#D9D3EB"><span class="style17">&nbsp;PREPARATION</span></td>
		  <td height="36" colspan="2" align="left" valign="middle" bgcolor="#FFFFFF" class="style17">
              1.School-level administrators support PBS -active involvement, funding allocated,
              etc.</td>
          <td align="left" valign="middle" bgcolor="#FFFFFF" class="style17"><div align="center" class="style16"><asp:Label Font-Bold="true" ID="lblPicQuestion1" runat="server"></asp:Label></div></td>          
           <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
          
        </tr>
        
		
		<tr>
		  <td height="36" align="left" valign="top" bgcolor="#D9D3EB">&nbsp;</td>
          <td height="36" colspan="2" align="left" valign="middle" bgcolor="#D9D3EB" class="style17">2. Staff support PBS -staff provided overview and reached 80% agreement to implement PBS.</td>
          <td align="left" valign="middle" bgcolor="#D9D3EB" class="style17"><div align="center" class="style16"><asp:Label Font-Bold="true" ID="lblPicQuestion2" runat="server"></asp:Label></div></td>          
          <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        
        </tr>
        
		<tr>
		  <td height="36" align="left" valign="top" bgcolor="#D9D3EB">&nbsp;</td>
          <td height="36" colspan="2" align="left" valign="middle" bgcolor="#FFFFFF" class="style17">3. PBS Team has been established and trained -full staff representation, team meeting
              schedule established; attended FLPBS trainings, has a current action plan.</td>
          <td align="left" valign="middle" bgcolor="#FFFFFF" class="style17"><div align="center" class="style16"><asp:Label Font-Bold="true" ID="lblPicQuestion3" runat="server"></asp:Label></div></td>          
          <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        
        </tr>
        
		<tr>
		  <td height="36" align="left" valign="top" bgcolor="#D9D3EB">&nbsp;</td>
          <td height="36" colspan="2" align="left" valign="middle" bgcolor="#D9D3EB" class="style17">4. PBS Coach has been trained -attends summer trainings, attends coaches and regional
              meetings; knowledgeable about PBS, Behavioral Theory, and data-based decision making;
              skilled in facilitation, problem solving process, and public speaking.</td>
          <td align="left" valign="middle" bgcolor="#D9D3EB" class="style17"><div align="center"><asp:Label Font-Bold="true" ID="lblPicQuestion4" runat="server"></asp:Label></div></td>         
          <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
          
        </tr>

        <tr>
          <td height="10" colspan="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
            <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        
        </tr>
        <tr>
          <td height="36" align="left" valign="middle" bgcolor="#D9D3EB"><span class="style17">&nbsp;INITIATION</span></td>
		  <td height="36" colspan="2" align="left" valign="middle" bgcolor="#FFFFFF" class="style17">5. PBS Team meets at least once a month.</td>
          <td align="left" valign="middle" bgcolor="#FFFFFF" class="style17"><div align="center"><asp:Label Font-Bold="true" ID="lblPicQuestion5" runat="server"></asp:Label></div></td>
           <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
         
        </tr>
		
        <tr>
          <td height="36" align="left" valign="top" bgcolor="#D9D3EB">&nbsp;</td>
          <td height="36" colspan="2" align="left" valign="middle" bgcolor="#D9D3EB" class="style17">
              6.PBS Coach attends those meetings.</td>
          <td align="left" valign="middle" bgcolor="#D9D3EB" class="style17"><div align="center"><asp:Label Font-Bold="true" ID="lblPicQuestion6" runat="server"></asp:Label></div></td>
           <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
         
        </tr>
        
		<tr>
		  <td height="36" align="left" valign="top" bgcolor="#D9D3EB">&nbsp;</td>
          <td height="36" colspan="2" align="left" valign="middle" bgcolor="#FFFFFF" class="style17">7. PBS Team shows a good working relationship with the Coach.
          </td>
          <td align="left" valign="middle" bgcolor="#FFFFFF" class="style17"><div align="center"><asp:Label Font-Bold="true" ID="lblPicQuestion7" runat="server"></asp:Label></div></td>
           <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
         
        </tr>
        <tr>
          <td height="36" align="left" valign="top" bgcolor="#D9D3EB">&nbsp;</td>
          <td height="36" colspan="2" align="left" valign="middle" bgcolor="#D9D3EB" class="style17">
              8. 3-5 expectations have been clearly defined and teaching plans have been described to staff.</td>
          <td align="left" valign="middle" bgcolor="#D9D3EB" class="style17"><div align="center">
              <asp:Label Font-Bold="True" ID="lblPicQuestion8" runat="server"></asp:Label></div></td>
               <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
       
        </tr>
        <tr>
		  <td height="36" align="left" valign="top" bgcolor="#D9D3EB">&nbsp;</td>
          <td height="36" colspan="2" align="left" valign="middle" bgcolor="#FFFFFF" class="style17">
              9. System for rewarding students has been developed - written documentation required
              for full score.</td>
          <td align="left" valign="middle" bgcolor="#FFFFFF" class="style17"><div align="center">
              <asp:Label Font-Bold="True" ID="lblPicQuestion9" runat="server"></asp:Label></div></td>
               <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
         
        </tr>
        <tr>
          <td height="36" align="left" valign="top" bgcolor="#D9D3EB">&nbsp;</td>
          <td height="36" colspan="2" align="left" valign="middle" bgcolor="#D9D3EB" class="style17">
              10. Strategy for collecting and using discipline data has been established.</td>
          <td align="left" valign="middle" bgcolor="#D9D3EB" class="style17"><div align="center">
              <asp:Label Font-Bold="True" ID="lblPicQuestion10" runat="server"></asp:Label></div></td>
               <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
     
        </tr>
        <tr>
		  <td height="36" align="left" valign="top" bgcolor="#D9D3EB">&nbsp;</td>
          <td height="36" colspan="2" align="left" valign="middle" bgcolor="#FFFFFF" class="style17">11. A plan has been developed to provide training and support to staff and teachers
              -including substitutes, student/intern teachers, and new staff;
          </td>
          <td align="left" valign="middle" bgcolor="#FFFFFF" class="style17"><div align="center">
              <asp:Label Font-Bold="True" ID="lblPicQuestion11" runat="server"></asp:Label></div></td>
               <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
         
        </tr>
        <tr>
          <td height="36" align="left" valign="top" bgcolor="#D9D3EB">&nbsp;</td>
          <td height="36" colspan="2" align="left" valign="middle" bgcolor="#D9D3EB" class="style17">12. New and returning staff have been oriented and trained in PBS processes- rationale,
              reward system, office vs classroom managed behaviors, formalized procedure for handling
              behavior problems, flowchart developed, problem behaviors clearly defined etc.</td>
          <td align="left" valign="middle" bgcolor="#D9D3EB" class="style17"><div align="center">
              <asp:Label Font-Bold="True" ID="lblPicQuestion12" runat="server"></asp:Label></div></td>
               <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
          
        </tr>
         <tr>
		  <td height="36" align="left" valign="top" bgcolor="#D9D3EB">&nbsp;</td>
          <td height="36" colspan="2" align="left" valign="middle" bgcolor="#FFFFFF" class="style17">13. Parents have been oriented to PBS.</td>
          <td align="left" valign="middle" bgcolor="#FFFFFF" class="style17"><div align="center">
              <asp:Label Font-Bold="True" ID="lblPicQuestion13" runat="server"></asp:Label></div></td>
                    <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        
        </tr>
        
		<tr>
		  <td height="10" colspan="4" align="left" valign="top" bgcolor="#91BB4D">&nbsp;</td>
		   <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
		 
	    </tr>
	    
        
		<tr>
          <td align="left" valign="middle" bgcolor="#D9D3EB"><span class="style17">&nbsp;IMPLEMENTATION</span></td>
		  <td height="36" colspan="2" align="left" valign="middle" bgcolor="#D9D3EB" class="style17">14. Behavior expectations and reward
                  systems are taught formally and informally to students -Occurs multiple times during
                  the year to include transferring students, integrated into curriculums, common language
                  used by staff and students across settings; dates for reward activities have been
                  set and placed on school calendars.</td>
          <td align="left" valign="middle" bgcolor="#D9D3EB" class="style17" ><div align="center">
              <asp:Label Font-Bold="True" ID="lblPicQuestion14" runat="server"></asp:Label></div></td>    
                     <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
          
        </tr>
        
		<tr>
		<td height="36" align="left" valign="top" bgcolor="#D9D3EB">&nbsp;</td>
		  <td height="36" colspan="2" align="left" valign="middle" bgcolor="#FFFFFF" class="style17">
              15. Behavior expectations have been posted throughout the school-including hallways,
              cafeteria, playground, special rooms, restrooms, offices, and classrooms.</td>
          <td align="left" valign="middle" bgcolor="#FFFFFF" class="style17"><div align="center">
              <asp:Label Font-Bold="True" ID="lblPicQuestion15" runat="server"></asp:Label></div></td>   
              <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>       
             
        </tr>
		
        <tr>
          <td align="left" valign="top" bgcolor="#D9D3EB"></td>
          <td colspan="2" align="left" valign="middle" bgcolor="#D9D3EB" class="style17">
              16. Positive behaviors are rewarded consistently across staff and settings.</td>
          <td align="left" valign="middle" bgcolor="#D9D3EB" class="style17"><div align="center">
              <asp:Label Font-Bold="True" ID="lblPicQuestion16" runat="server"></asp:Label></div></td>
              <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
              
          
        </tr>
        
		<tr>
		  <td height="36" align="left" valign="top" bgcolor="#D9D3EB">&nbsp;</td>
          <td height="36" colspan="2" align="left" valign="middle" bgcolor="#FFFFFF" class="style17">
              17. Procedures for handling inappropriate behaviors are implemented consistently
              across staff and settings.</td>
          <td align="left" valign="middle" bgcolor="#FFFFFF" class="style17"><div align="center">
              <asp:Label Font-Bold="True" ID="lblPicQuestion17" runat="server"></asp:Label></div></td>
          <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>

        </tr>
        <tr>
          <td height="36" align="left" valign="top" bgcolor="#D9D3EB">&nbsp;</td>
          <td height="36" colspan="2" align="left" valign="middle" bgcolor="#D9D3EB" class="style17">
              18. Office discipline forms are completed consistently and accurately across staff</td>
          <td align="left" valign="middle" bgcolor="#D9D3EB" class="style17"><div align="center">
              <asp:Label Font-Bold="True" ID="lblPicQuestion18" runat="server"></asp:Label></div></td>
               <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        
        </tr>
        
		<tr>
		  <td height="36" align="left" valign="top" bgcolor="#D9D3EB">&nbsp;</td>
          <td height="36" colspan="2" align="left" valign="middle" bgcolor="#FFFFFF" class="style17">
              19. Discipline data are gathered and entered into the data base consistently and
              in a timely manner.</td>
          <td align="left" valign="middle" bgcolor="#FFFFFF" class="style17"><div align="center">
              <asp:Label Font-Bold="True" ID="lblPicQuestion19" runat="server"></asp:Label></div></td>
               <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        
        </tr>
        
		<tr>
		  <td height="36" align="left" valign="top" bgcolor="#D9D3EB">&nbsp;</td>
          <td height="36" colspan="2" align="left" valign="middle" bgcolor="#D9D3EB" class="style17">
              20. Discipline data are used in PBS Team meetings to identify problems and guide
              school decisions.</td>
          <td align="left" valign="middle" bgcolor="#D9D3EB" class="style17"><div align="center">
              <asp:Label Font-Bold="True" ID="lblPicQuestion20" runat="server"></asp:Label></div></td>
               <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
      
        </tr>
        <tr>
		  <td height="36" align="left" valign="top" bgcolor="#D9D3EB">&nbsp;</td>
          <td height="36" colspan="2" align="left" valign="middle" bgcolor="#FFFFFF" class="style17">
              21. Discipline data are summarized and reported to staff on a regular basis.</td>
          <td align="left" valign="middle" bgcolor="#FFFFFF" class="style17"><div align="center">
              <asp:Label Font-Bold="True" ID="lblPicQuestion21" runat="server"></asp:Label></div></td>
               <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
          
        </tr>
        
		<tr>
		  <td height="36" align="left" valign="top" bgcolor="#D9D3EB">&nbsp;</td>
          <td height="36" colspan="2" align="left" valign="middle" bgcolor="#D9D3EB" class="style17">
              22. Parents and community members are actively involved in PBS related activities,
              programs, and/or services.</td>
          <td align="left" valign="middle" bgcolor="#D9D3EB" class="style17"><div align="center">
              <asp:Label Font-Bold="True" ID="lblPicQuestion22" runat="server"></asp:Label></div></td>
               <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
          
        </tr>
		<tr>
		  <td height="10" colspan="4" align="left" valign="top" bgcolor="#91BB4D">&nbsp;</td>
		   <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        
	    </tr>
        
		<tr>
          <td  align="left" valign="middle" bgcolor="#D9D3EB"><span class="style17">&nbsp;MAINTENANCE </span></td>
		  <td height="36" colspan="2" align="left" valign="middle" bgcolor="#FFFFFF" class="style17">
              23. Data and staff feedback are used to make decisions regarding additional training and professional staff development.</td>
          <td align="left" valign="middle" bgcolor="#FFFFFF" class="style17"><div align="center">
              <asp:Label Font-Bold="True" ID="lblPicQuestion23" runat="server"></asp:Label></div></td>   
               <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
         
               </tr>
        
		<tr>
		 <td height="36" align="left" valign="top" bgcolor="#D9D3EB">&nbsp;</td>
		  <td height="36" colspan="2" align="left" valign="middle" bgcolor="#D9D3EB" class="style17">
              24. A plan is in place for training new PBS team members -including new administrators,
              staff, and district personnel.</td>
          <td align="left" valign="middle" bgcolor="#D9D3EB" class="style17"><div align="center" class="style16">
              <asp:Label Font-Bold="True" ID="lblPicQuestion24" runat="server"></asp:Label></div></td>
               <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        
        </tr>
        
		<tr>
		  <td height="36" align="left" valign="top" bgcolor="#D9D3EB">&nbsp;</td>
          <td height="36" colspan="2" align="left" valign="middle" bgcolor="#FFFFFF" class="style17">
              25. Data and staff feedback are used to revise and update the PBS action plan for the school and district - reviewed and revised as needed.</td>
          <td align="left" valign="middle" bgcolor="#FFFFFF" class="style17"><div align="center">
              <asp:Label Font-Bold="True" ID="lblPicQuestion25" runat="server"></asp:Label></div></td>
               <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
         
        </tr>
        
		<tr>
		  <td height="36" align="left" valign="top" bgcolor="#D9D3EB">&nbsp;</td>
          <td height="36" colspan="2" align="left" valign="middle" bgcolor="#D9D3EB" class="style17">
              26. Links with the community and other resources have been established to assist
              with funding and incentives.</td>
          <td align="left" valign="middle" bgcolor="#D9D3EB" class="style17"><div align="center">
              <asp:Label Font-Bold="True" ID="lblPicQuestion26" runat="server"></asp:Label></div></td>
               <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
          
        </tr>
        
		<tr>
		  <td height="36" align="left" valign="top" bgcolor="#D9D3EB">&nbsp;</td>
          <td height="36" colspan="2" align="left" valign="middle" bgcolor="#FFFFFF" class="style17">
              27. Morale is sustained among staff and students -staff and student attendance and participation in PBS efforts is high, system in place to recognize staff (and parent)contributions.
          </td>
          <td align="left" valign="middle" bgcolor="#FFFFFF" class="style17"><div align="center">
              <asp:Label Font-Bold="True" ID="lblPicQuestion27" runat="server"></asp:Label></div></td>
               <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        
        </tr>
		       

		<tr>
		  <td height="10" colspan="4" align="left" valign="top" bgcolor="#91BB4D">&nbsp;</td>
		   <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
           
	    </tr>
	    <tr>
		  <td height="18" align="left" valign="top" bgcolor="#FFFFFF" colspan="4">
              <strong>&nbsp;Tier 2 Supplemental PBS</strong>&nbsp;&nbsp;&nbsp;</td>
               <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
          
	    </tr>
	    <tr>
		  <td height="10" colspan="4" align="left" valign="top" bgcolor="#91BB4D">&nbsp;</td>
		   <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        
	    </tr>
        
		<tr>
          <td  align="left" valign="middle" bgcolor="#D9D3EB"><span class="style17">&nbsp; 
           </span></td>
		  <td height="36" colspan="2" align="left" valign="middle" bgcolor="#D9D3EB" class="style17">
              28. The school has a data-based process for identifying students in need of Tier
              2 supports.</td>
          <td align="left" valign="middle" bgcolor="#D9D3EB" class="style17"><div align="center">
              <asp:Label Font-Bold="True" ID="lblPicQuestion28" runat="server"></asp:Label></div></td> 
               <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
      
        </tr>
		
		<tr>
		 <td height="36" align="left" valign="top" bgcolor="#D9D3EB">&nbsp;</td>
		  <td height="36" colspan="2" align="left" valign="middle" bgcolor="#FFFFFF" class="style17">
              29. Student's needs are prioritized to assure that students with the greater
              needs are supported.</td>
          <td align="left" valign="middle" bgcolor="#FFFFFF" class="style17"><div align="center">
              <asp:Label Font-Bold="True" ID="lblPicQuestion29" runat="server"></asp:Label></div></td>
               <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
         
        </tr>
        
		<tr>
		  <td height="36" align="left" valign="top" bgcolor="#D9D3EB">&nbsp;</td>
          <td height="36" colspan="2" align="left" valign="middle" bgcolor="#D9D3EB" class="style17">
              30. Tier 2 interventions are matched to the function of the behavior.</td>
          <td align="left" valign="middle" bgcolor="#D9D3EB" class="style17"><div align="center">
              <asp:Label Font-Bold="True" ID="lblPicQuestion30" runat="server"></asp:Label></div></td>
               <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
         
        </tr>
        
		<tr>
		  <td height="36" align="left" valign="top" bgcolor="#D9D3EB">&nbsp;</td>
          <td height="36" colspan="2" align="left" valign="middle" bgcolor="#FFFFFF" class="style17">
              31. The school has 0 (score 0), 1-2 (score 1), more than 2 (score 2) Tier 2 programs
              in place.</td>
          <td align="left" valign="middle" bgcolor="#FFFFFF" class="style17"><div align="center">
              <asp:Label Font-Bold="True" ID="lblPicQuestion31" runat="server"></asp:Label></div></td>
               <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
          
        </tr>
		
		<tr>
		  <td height="36" align="left" valign="top" bgcolor="#D9D3EB">&nbsp;</td>
          <td height="36" colspan="2" align="left" valign="middle" bgcolor="#D9D3EB" class="style17">
              32. The school is checking to make sure that Tier 2 programs are implemented with
              fidelity.
          </td>
          <td align="left" valign="middle" bgcolor="#D9D3EB" class="style17"><div align="center">
              <asp:Label Font-Bold="True" ID="lblPicQuestion32" runat="server"></asp:Label></div></td>
               <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        
        </tr>
        <tr>
		  <td height="36" align="left" valign="top" bgcolor="#D9D3EB">&nbsp;</td>
          <td height="36" colspan="2" align="left" valign="middle" bgcolor="#FFFFFF" class="style17">
              33. A progress monitoring system is in place for all students receiving Tier 2 interventions.
          </td>
          <td align="left" valign="middle" bgcolor="#FFFFFF" class="style17"><div align="center">
              <asp:Label Font-Bold="True" ID="lblPicQuestion33" runat="server"></asp:Label></div></td>
               <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
          
        </tr>
		
		<tr>
		  <td height="36" align="left" valign="top" bgcolor="#D9D3EB">&nbsp;</td>
          <td height="36" colspan="2" align="left" valign="middle" bgcolor="#D9D3EB" class="style17">
              34. The school team makes decisions on student's response to intervention from the
              progress monitoring system.</td>
          <td align="left" valign="middle" bgcolor="#D9D3EB" class="style17"><div align="center">
              <asp:Label Font-Bold="True" ID="lblPicQuestion34" runat="server"></asp:Label></div></td>
               <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        
        </tr>
		<tr>
		  <td height="10" colspan="4" align="left" valign="top" bgcolor="#91BB4D">&nbsp;</td>
		   <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        
	    </tr>
	     <tr>
		  <td height="18" align="left" valign="top" bgcolor="#FFFFFF" colspan="4">
              <strong>&nbsp;Tier 3 Intensive PBS</strong>&nbsp;&nbsp;&nbsp;</td>
               <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        
		  
	    </tr>
	    <tr>
		  <td height="10" colspan="4" align="left" valign="top" bgcolor="#91BB4D">&nbsp;</td>
		   <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
     
	    </tr>
        
		<tr>
          <td align="left" valign="middle" bgcolor="#D9D3EB"><span class="style17">&nbsp; &nbsp; &nbsp; &nbsp; 
 </span></td>
		  <td height="36" colspan="2" align="left" valign="middle" bgcolor="#FFFFFF" class="style17">
              35. Data-based decision-making is used to identify students in need of Tier 3 supports.</td>
          <td align="left" valign="middle" bgcolor="#FFFFFF" class="style17"><div align="center">
              <asp:Label Font-Bold="True" ID="lblPicQuestion35" runat="server"></asp:Label></div></td>
               <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        
        </tr>
        
		<tr>
		 <td height="36" align="left" valign="top" bgcolor="#D9D3EB">&nbsp;</td>
		  <td height="36" colspan="2" align="left" valign="middle" bgcolor="#D9D3EB" class="style17">
              36. Student's needs are prioritized to assure that students with the most intensive
              needs are supported.</td>
          <td align="left" valign="middle" bgcolor="#D9D3EB" class="style17"><div align="center">
              <asp:Label Font-Bold="True" ID="lblPicQuestion36" runat="server"></asp:Label></div></td>
               <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
       
        </tr>
		
		<tr>
		  <td height="36" align="left" valign="top" bgcolor="#D9D3EB">&nbsp;</td>
          <td height="36" colspan="2" align="left" valign="middle" bgcolor="#FFFFFF" class="style17">
              37. An FBA is conducted that identifies the problem, the events that reliably predict
              the problem behavior and the consequences that maintain the problem behavior.
          </td>
          <td align="left" valign="middle" bgcolor="#FFFFFF" class="style17"><div align="center">
              <asp:Label Font-Bold="True" ID="lblPicQuestion37" runat="server"></asp:Label></div></td>
               <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
         
        </tr>
        
		<tr>
		  <td height="36" align="left" valign="top" bgcolor="#D9D3EB">&nbsp;</td>
          <td height="36" colspan="2" align="left" valign="middle" bgcolor="#D9D3EB" class="style17">
              38. At least 1 hypothesis is developed from the FBA to explain the student's problem
              behavior.</td>
          <td align="left" valign="middle" bgcolor="#D9D3EB" class="style17"><div align="center">
              <asp:Label Font-Bold="True" ID="lblPicQuestion38" runat="server"></asp:Label></div></td>
               <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
          
        </tr>
        
		<tr>
		  <td height="36" align="left" valign="top" bgcolor="#D9D3EB">&nbsp;</td>
          <td height="36" colspan="2" align="left" valign="middle" bgcolor="#FFFFFF" class="style17">
              39. Tier 3 interventions are matched to the function of the behavior.</td>
          <td align="left" valign="middle" bgcolor="#FFFFFF" class="style17"><div align="center">
              <asp:Label Font-Bold="True" ID="lblPicQuestion39" runat="server"></asp:Label></div></td>
               <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
         
        </tr>
		
		<tr>
		  <td height="36" align="left" valign="top" bgcolor="#D9D3EB">&nbsp;</td>
          <td height="36" colspan="2" align="left" valign="middle" bgcolor="#D9D3EB" class="style17">
              40. A BIP is developed that includes procedures to prevent problem behaviors, teach
              appropriate behavior, and reinforce/reward appropriate behavior .
          </td>
          <td align="left" valign="middle" bgcolor="#D9D3EB" class="style17"><div align="center">
              <asp:Label Font-Bold="True" ID="lblPicQuestion40" runat="server"></asp:Label></div></td>
               <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        
        </tr>
        
		<tr>
		  <td height="36" align="left" valign="top" bgcolor="#D9D3EB">&nbsp;</td>
          <td height="36" colspan="2" align="left" valign="middle" bgcolor="#FFFFFF" class="style17">
              41. Teachers are "coached" &nbsp;in how to implement the BIP accurately and effectively.</td>
          <td align="left" valign="middle" bgcolor="#FFFFFF" class="style17"><div align="center">
              <asp:Label Font-Bold="True" ID="lblPicQuestion41" runat="server"></asp:Label></div></td>
               <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        
        </tr>
        
		<tr>
		  <td height="36" align="left" valign="top" bgcolor="#D9D3EB">&nbsp;</td>
          <td height="36" colspan="2" align="left" valign="middle" bgcolor="#D9D3EB" class="style17">
              42. The school is checking to make sure that Tier 3 programs are implemented with
              fidelity.
          </td>
          <td align="left" valign="middle" bgcolor="#D9D3EB" class="style17"><div align="center">
              <asp:Label Font-Bold="True" ID="lblPicQuestion42" runat="server"></asp:Label></div></td>
               <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
          
        </tr>
        <tr>
		  <td height="36" align="left" valign="top" bgcolor="#D9D3EB">&nbsp;</td>
          <td height="36" colspan="2" align="left" valign="middle" bgcolor="#FFFFFF" class="style17">
              43. A progress monitoring system is in place for all students receiving Tier 3 interventions.</td>
          <td align="left" valign="middle" bgcolor="#FFFFFF" class="style17"><div align="center">
              <asp:Label Font-Bold="True" ID="lblPicQuestion43" runat="server"></asp:Label></div></td>
               <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        
        </tr>
        
		<tr>
		  <td height="36" align="left" valign="top" bgcolor="#D9D3EB">&nbsp;</td>
          <td height="36" colspan="2" align="left" valign="middle" bgcolor="#D9D3EB" class="style17">
              44. The school team makes decisions on student's response to intervention from the
              progress monitoring system.
          </td>
          <td align="left" valign="middle" bgcolor="#D9D3EB" class="style17"><div align="center">
              <asp:Label Font-Bold="True" ID="lblPicQuestion44" runat="server"></asp:Label></div></td>
               <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
          
        </tr>
			<tr>
		  <td height="10" colspan="4" align="left" valign="top" bgcolor="#91BB4D">&nbsp;</td>
		   <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
		
	    </tr>
		<tr>
          <td height="36" align="left" valign="middle" bgcolor="#FFFFFF"><span class="style17 footer style18">&nbsp;&nbsp;TOTAL SCORE </span></td>
		  <td height="36" colspan="2" align="left" valign="middle" bgcolor="#FFFFFF" class="style17"></td>
          <td align="left" valign="middle" bgcolor="#FFFFFF" class="style17"><div align="center">
              <asp:Label Font-Bold="True" ID="lblPicQuestionTotalScore" runat="server"></asp:Label></div></td>
               <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        
        </tr>
			<tr>
		  <td height="10" colspan="4" align="left" valign="top" bgcolor="#91BB4D">&nbsp;</td>
		   <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
		
	    </tr>
	    
    </table>
    
        </td>
    </tr>
    
    </table>
    </td>
    </tr>
</asp:Content>