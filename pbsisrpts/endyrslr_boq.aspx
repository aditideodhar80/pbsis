<%@ Page Language="VB" MasterPageFile="~/pbsmaster/Detail.master" AutoEventWireup="false" CodeFile="endyrslr_boq.aspx.vb" Inherits="pbsisrpts_endyrslr_boq" %>

<asp:Content ID ="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <tr>
        <td>
<table width="100%"  border="0" cellspacing="0" cellpadding="0">
        <tr>
          <td colspan="7"><img src="../images/box-top.gif" width="800" height="1"></td>
        </tr>
       
        <tr>
          <td height="30" colspan="5" align="left" valign="middle" bgcolor="#91BB4D">
              <div align="center" class="style6" style="font-weight: bold">
            <div align="center" style="font-size: small">SCHOOL-WIDE BENCHMARKS OF QUALITY: SCORING RESULTS </div>
             <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
          </div></td>
        </tr>
        
		<tr>
          <td width="9" rowspan="78" align="left" valign="top" bgcolor="#91BB4D">&nbsp;</td>
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
          <td height="24" align="left" valign="middle" bgcolor="#91BB4D"><span class="style6">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<b>Coach Name</b> </span></td>
          <td height="24" align="left" valign="middle" bgcolor="#FFFFFF" class="style17">&nbsp;<asp:Label ID="lblCoachName" runat="server"></asp:Label></td>
          <td colspan="2" align="left" valign="top" bgcolor="#91BB4D">&nbsp;</td>
           <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        </tr>
        
        <tr>
          <td height="24" align="left" valign="middle" bgcolor="#91BB4D"><span class="style6"><b>Method Of Scoring</b>
          </span></td>
          <td height="24" align="left" valign="middle" bgcolor="#FFFFFF" class="style17">&nbsp;<asp:Label ID="lblScoringMethod" runat="server"></asp:Label></td>
          <td colspan="2" align="left" valign="top" bgcolor="#91BB4D">&nbsp;</td>
           <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        </tr>
        
		<tr>
		  <td height="18" align="left" valign="top" bgcolor="#91BB4D">&nbsp;</td>
		  <td height="18" colspan="2" align="left" valign="top" bgcolor="#91BB4D">&nbsp;</td>
		  <td height="18" align="left" valign="top" bgcolor="#91BB4D">&nbsp;</td>
		   <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
	    </tr>
		<tr>
          <td height="18" align="left" valign="top" bgcolor="#91BB4D"><span class="style6">&nbsp;<b>Critical Elements</b></span></td>
		  <td height="18" colspan="2" align="left" valign="top" bgcolor="#91BB4D"><span class="style6">&nbsp;<b>Benchmarks of Quality</b></span></td>
          <td height="18" align="left" valign="top" bgcolor="#91BB4D"><strong class="style6">Response </strong></td>
           <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        </tr>
        
	
		
		<tr>
		  <td height="36" align="left" valign="top" bgcolor="#D9D3EB">&nbsp;</td>
          <td height="36" colspan="2" align="left" valign="middle" bgcolor="#D9D3EB" class="style17">1. Team has administrative support.</td>
          <td align="left" valign="middle" bgcolor="#D9D3EB" class="style17"><div align="center" class="style16">
          
              <asp:Label Font-Bold="True" ID="lblBOQQuestion1" runat="server"></asp:Label></div></td>     
               <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>     
        </tr>
        
		<tr>
		  <td height="36" align="left" valign="top" bgcolor="#D9D3EB">&nbsp;</td>
          <td height="36" colspan="2" align="left" valign="middle" bgcolor="#FFFFFF" class="style17">2. Team has regular meetings (at least monthly).</td>
          <td align="left" valign="middle" bgcolor="#FFFFFF" class="style17"><div align="center" class="style16">
              <asp:Label Font-Bold="True" ID="lblBOQQuestion2" runat="server"></asp:Label></div></td>       
               <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>   
        </tr>
        
		<tr>
		  <td height="36" align="left" valign="top" bgcolor="#D9D3EB">&nbsp;</td>
          <td height="36" colspan="2" align="left" valign="middle" bgcolor="#D9D3EB" class="style17">3. Team has established a clear mission/purpose.</td>
          <td align="left" valign="middle" bgcolor="#D9D3EB" class="style17"><div align="center">
              <asp:Label Font-Bold="True" ID="lblBOQQuestion3" runat="server"></asp:Label></div></td>     
               <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>    
        </tr>

        <tr>
          <td height="10" colspan="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
           <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        </tr>
        <tr>
          <td height="36" align="left" valign="middle" bgcolor="#D9D3EB"><span class="style17">FACULTY<br>
COMMITMENT</span></td>
		  <td height="36" colspan="2" align="left" valign="middle" bgcolor="#FFFFFF" class="style17">4.	Faculty are aware of behavior problems across campus through 
              (regular data sharing)</td>
          <td align="left" valign="middle" bgcolor="#FFFFFF" class="style17"><div align="center">
              <asp:Label Font-Bold="True" ID="lblBOQQuestion4" runat="server"></asp:Label></div></td>
               <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        </tr>
		
        <tr>
          <td height="36" align="left" valign="top" bgcolor="#D9D3EB">&nbsp;</td>
          <td height="36" colspan="2" align="left" valign="middle" bgcolor="#D9D3EB" class="style17">5.	Faculty involved in establishing and reviewing goals</td>
          <td align="left" valign="middle" bgcolor="#D9D3EB" class="style17"><div align="center">
              <asp:Label Font-Bold="True" ID="lblBOQQuestion5" runat="server"></asp:Label></div></td>
               <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        </tr>
        
		<tr>
		  <td height="36" align="left" valign="top" bgcolor="#D9D3EB">&nbsp;</td>
          <td height="36" colspan="2" align="left" valign="middle" bgcolor="#FFFFFF" class="style17">6.	Faculty feedback is obtained throughout the year</td>
          <td align="left" valign="middle" bgcolor="#FFFFFF" class="style17"><div align="center">
              <asp:Label Font-Bold="True" ID="lblBOQQuestion6" runat="server"></asp:Label></div></td>
               <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        </tr>
		<tr>
		  <td height="10" colspan="4" align="left" valign="top" bgcolor="#91BB4D">&nbsp;</td>
		   <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
	    </tr>
        
		<tr>
          <td rowspan="2" align="left" valign="middle" bgcolor="#D9D3EB"><span class="style17">EFFECTIVE<br>
          &nbsp;PROCEDURES FOR<br>&nbsp;DEALING WITH<br>&nbsp;DISCIPLINE </span></td>
		  <td height="36" colspan="2" align="left" valign="middle" bgcolor="#D9D3EB"><span class="style17">7.	Discipline process described in narrative format or depicted in graphic format</span></td>
          <td align="left" valign="middle" bgcolor="#D9D3EB" class="style17"><div align="center">
              <asp:Label Font-Bold="True" ID="lblBOQQuestion7" runat="server"></asp:Label></div></td>          
               <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        </tr>
        <tr>
		  <td height="36" colspan="2" align="left" valign="middle" bgcolor="#FFFFFF" class="style17">8.	Discipline process includes documentation procedures.</td>
          <td align="left" valign="middle" bgcolor="#FFFFFF" class="style17"><div align="center">
              <asp:Label Font-Bold="True" ID="lblBOQQuestion8" runat="server"></asp:Label></div></td>    
               <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>      
        </tr>
		
        <tr>
          <td height="36" align="left" valign="top" bgcolor="#D9D3EB">&nbsp;</td>
          <td height="36" colspan="2" align="left" valign="middle" bgcolor="#D9D3EB" class="style17">9.	Discipline referral form includes information useful in decision making</td>
          <td align="left" valign="middle" bgcolor="#D9D3EB" class="style17"><div align="center">
              <asp:Label Font-Bold="True" ID="lblBOQQuestion9" runat="server"></asp:Label></div></td>
               <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        </tr>
        
		<tr>
		  <td height="36" align="left" valign="top" bgcolor="#D9D3EB">&nbsp;</td>
          <td height="36" colspan="2" align="left" valign="middle" bgcolor="#FFFFFF" class="style17">10.	Problem behaviors are defined.</td>
          <td align="left" valign="middle" bgcolor="#FFFFFF" class="style17"><div align="center">
              <asp:Label Font-Bold="True" ID="lblBOQQuestion10" runat="server"></asp:Label></div></td>
         
           <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        </tr>
        <tr>
          <td height="36" align="left" valign="top" bgcolor="#D9D3EB">&nbsp;</td>
          <td height="36" colspan="2" align="left" valign="middle" bgcolor="#D9D3EB" class="style17">11.	Major/minor behaviors are clearly differentiated.</td>
          <td align="left" valign="middle" bgcolor="#D9D3EB" class="style17"><div align="center">
              <asp:Label Font-Bold="True" ID="lblBOQQuestion11" runat="server"></asp:Label></div></td>
               <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        </tr>
        
		<tr>
		  <td height="36" align="left" valign="top" bgcolor="#D9D3EB">&nbsp;</td>
          <td height="36" colspan="2" align="left" valign="middle" bgcolor="#FFFFFF" class="style17">12.	Suggested array of appropriate responses to major (office-managed) problem behaviors.</td>
          <td align="left" valign="middle" bgcolor="#FFFFFF" class="style17"><div align="center">
              <asp:Label Font-Bold="True" ID="lblBOQQuestion12" runat="server"></asp:Label></div></td>
               <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        </tr>
        
		
		<tr>
		  <td height="10" colspan="4" align="left" valign="top" bgcolor="#91BB4D">&nbsp;</td>
	 <td height="10" colspan="4" align="left" valign="top" bgcolor="#91BB4D">&nbsp;</td>
	    </tr>
        
		<tr>
          <td rowspan="2" align="left" valign="middle" bgcolor="#D9D3EB"><span class="style17">DATA ENTRY AND<br>
          &nbsp;ANALYSIS PLAN<br>&nbsp;ESTABLISHED </span></td>
		  <td height="36" colspan="2" align="left" valign="middle" bgcolor="#FFFFFF" class="style17">13.	Data system is used to collect and analyze ODR data..</td>
          <td align="left" valign="middle" bgcolor="#FFFFFF" class="style17"><div align="center">
              <asp:Label Font-Bold="True" ID="lblBOQQuestion13" runat="server"></asp:Label></div></td>   
               <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
               </tr>
        
        
       <tr>
		 
          <td height="36" colspan="2" align="left" valign="middle" bgcolor="#D9D3EB" class="style17">14.	Additional data are collected (attendance, grades, faculty attendance, surveys) and used by SWPBS team.</td>
          <td align="left" valign="middle" bgcolor="#D9D3EB" class="style17">
              <div align="center"><asp:Label Font-Bold="True" ID="lblBOQQuestion14" runat="server"></asp:Label></div></td>
               <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        </tr>
        
      
        
		<tr>
		  <td height="36" align="left" valign="top" bgcolor="#D9D3EB">&nbsp;</td>
          <td height="36" colspan="2" align="left" valign="middle" bgcolor="#FFFFFF" class="style17">15.	Data analyzed by team at least monthly.</td>
          <td align="left" valign="middle" bgcolor="#FFFFFF" class="style17"><div align="center">
              <asp:Label Font-Bold="True" ID="lblBOQQuestion15" runat="server"></asp:Label></div></td>
               <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        </tr>
        
		<tr>
		  <td height="36" align="left" valign="top" bgcolor="#D9D3EB">&nbsp;</td>
          <td height="36" colspan="2" align="left" valign="middle" bgcolor="#D9D3EB" class="style17">16.	Data shared with team and faculty monthly (minimum).</td>
          <td align="left" valign="middle" bgcolor="#D9D3EB" class="style18">
              <div align="center"><asp:Label Font-Bold="True" ID="lblBOQQuestion16" runat="server"></asp:Label></div></td>
               <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        </tr>
        
	
		<tr>
		  <td height="10" colspan="4" align="left" valign="top" bgcolor="#91BB4D">&nbsp;</td>
		   <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
	    </tr>
        
		<tr>
          <td rowspan="2" align="left" valign="middle" bgcolor="#D9D3EB"><span class="style17">EXPECTATIONS<br>
          &nbsp;AND RULES<br>&nbsp;DEVELOPED </span></td>
		  <td height="36" colspan="2" align="left" valign="middle" bgcolor="#D9D3EB" class="style17">17. 3-5 positively stated school-wide expectations posted around school. </td>
          <td align="left" valign="middle" bgcolor="#D9D3EB" class="style17"><div align="center">
              <asp:Label Font-Bold="True" ID="lblBOQQuestion17" runat="server"></asp:Label></div></td> 
               <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        </tr>
		
		<tr>
		  <td height="36" colspan="2" align="left" valign="middle" bgcolor="#FFFFFF" class="style17">18. Expectations apply to both students and staff.</td>
          <td align="left" valign="middle" bgcolor="#FFFFFF" class="style17"><div align="center">
              <asp:Label Font-Bold="True" ID="lblBOQQuestion18" runat="server"></asp:Label></div></td>
               <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        </tr>
        
		<tr>
		  <td height="36" align="left" valign="top" bgcolor="#D9D3EB">&nbsp;</td>
          <td height="36" colspan="2" align="left" valign="middle" bgcolor="#D9D3EB" class="style17">19.	Rules are developed and posted for specific settings (settings where data suggest rules are needed).</td>
          <td align="left" valign="middle" bgcolor="#D9D3EB" class="style17"><div align="center">
              <asp:Label Font-Bold="True" ID="lblBOQQuestion19" runat="server"></asp:Label></div></td>
               <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        </tr>
        
		<tr>
		  <td height="36" align="left" valign="top" bgcolor="#D9D3EB">&nbsp;</td>
          <td height="36" colspan="2" align="left" valign="middle" bgcolor="#FFFFFF" class="style17">20.	Rules are linked to expectations.</td>
          <td align="left" valign="middle" bgcolor="#FFFFFF" class="style17"><div align="center">
              <asp:Label Font-Bold="True" ID="lblBOQQuestion20" runat="server"></asp:Label></div></td>
               <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        </tr>
		
		<tr>
		  <td height="36" align="left" valign="top" bgcolor="#D9D3EB">&nbsp;</td>
          <td height="36" colspan="2" align="left" valign="middle" bgcolor="#D9D3EB" class="style17">21.	Staff are involved in development of expectations and rules.</td>
          <td align="left" valign="middle" bgcolor="#D9D3EB" class="style17"><div align="center">
              <asp:Label Font-Bold="True" ID="lblBOQQuestion21" runat="server"></asp:Label></div></td>
               <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        </tr>
		<tr>
		  <td height="10" colspan="4" align="left" valign="top" bgcolor="#91BB4D">&nbsp;</td>
		   <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
	    </tr>
        
		<tr>
          <td rowspan="2" align="left" valign="middle" bgcolor="#D9D3EB"><span class="style17">REWARD/<br>
&nbsp;RECOGNITION<br>
&nbsp;PROGRAM<br>
&nbsp;ESTABLISHED </span></td>
		  <td height="36" colspan="2" align="left" valign="middle" bgcolor="#FFFFFF" class="style17">22.	A system of rewards has elements that are implemented consistently across campus.</td>
          <td align="left" valign="middle" bgcolor="#FFFFFF" class="style17"><div align="center">
              <asp:Label Font-Bold="True" ID="lblBOQQuestion22" runat="server"></asp:Label></div></td>
               <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        </tr>
        
		<tr>
		  <td height="36" colspan="2" align="left" valign="middle" bgcolor="#D9D3EB" class="style17">23.	A variety of methods are used to reward students.</td>
          <td align="left" valign="middle" bgcolor="#D9D3EB" class="style17"><div align="center">
              <asp:Label Font-Bold="True" ID="lblBOQQuestion23" runat="server"></asp:Label></div></td>
               <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        </tr>
		
		<tr>
		  <td height="36" align="left" valign="top" bgcolor="#D9D3EB">&nbsp;</td>
          <td height="36" colspan="2" align="left" valign="middle" bgcolor="#FFFFFF" class="style17">24.	Rewards are linked to expectations and rules.</td>
          <td align="left" valign="middle" bgcolor="#FFFFFF" class="style17"><div align="center">
              <asp:Label Font-Bold="True" ID="lblBOQQuestion24" runat="server"></asp:Label></div></td>
               <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        </tr>
        
		<tr>
		  <td height="36" align="left" valign="top" bgcolor="#D9D3EB">&nbsp;</td>
          <td height="36" colspan="2" align="left" valign="middle" bgcolor="#D9D3EB" class="style17">25.	Rewards are varied to maintain student interest.</td>
          <td align="left" valign="middle" bgcolor="#D9D3EB" class="style17"><div align="center">
              <asp:Label Font-Bold="True" ID="lblBOQQuestion25" runat="server"></asp:Label></div></td>
               <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        </tr>
        
		<tr>
		  <td height="36" align="left" valign="top" bgcolor="#D9D3EB">&nbsp;</td>
          <td height="36" colspan="2" align="left" valign="middle" bgcolor="#FFFFFF" class="style17">26.	Ratios of acknowledgement to corrections are high.</td>
          <td align="left" valign="middle" bgcolor="#FFFFFF" class="style17"><div align="center">
              <asp:Label Font-Bold="True" ID="lblBOQQuestion26" runat="server"></asp:Label></div></td>
               <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        </tr>
		
		<tr>
		  <td height="36" align="left" valign="top" bgcolor="#D9D3EB">&nbsp;</td>
          <td height="36" colspan="2" align="left" valign="middle" bgcolor="#D9D3EB" class="style17">27.	Students are involved in identifying/developing incentives.</td>
          <td align="left" valign="middle" bgcolor="#D9D3EB" class="style17"><div align="center">
              <asp:Label Font-Bold="True" ID="lblBOQQuestion27" runat="server"></asp:Label></div></td>
               <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        </tr>
        
		<tr>
		  <td height="36" align="left" valign="top" bgcolor="#D9D3EB">&nbsp;</td>
          <td height="36" colspan="2" align="left" valign="middle" bgcolor="#FFFFFF" class="style17">28.	The system includes incentives for staff/faculty.</td>
          <td align="left" valign="middle" bgcolor="#FFFFFF" class="style17"><div align="center">
              <asp:Label Font-Bold="True" ID="lblBOQQuestion28" runat="server"></asp:Label></div></td>
               <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        </tr>
        
		
		<tr>
		  <td height="10" colspan="4" align="left" valign="top" bgcolor="#91BB4D">&nbsp;</td>
		   <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
	    </tr>
		
		<tr>
          <td rowspan="2" align="left" valign="middle" bgcolor="#D9D3EB"><span class="style17">LESSON PLANS<br>
          FOR TEACHING<br>
            EXPECTATIONS/<br>
            RULES </span></td>
		  <td height="36" colspan="2" align="left" valign="middle" bgcolor="#FFFFFF" class="style17">29.	A behavioral curriculum includes teaching expectations and rules.</td>
          <td align="left" valign="middle" bgcolor="#FFFFFF" class="style17"><div align="center">
              <asp:Label Font-Bold="True" ID="lblBOQQuestion29" runat="server"></asp:Label></div></td>
               <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        </tr>
        
		<tr>
		  <td height="36" colspan="2" align="left" valign="middle" bgcolor="#D9D3EB" class="style17">30.	Lessons include examples and non-examples.</td>
          <td align="left" valign="middle" bgcolor="#D9D3EB" class="style17"><div align="center">
              <asp:Label Font-Bold="True" ID="lblBOQQuestion30" runat="server"></asp:Label></div></td>
               <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        </tr>
        
		<tr>
		  <td height="36" align="left" valign="top" bgcolor="#D9D3EB">&nbsp;</td>
          <td height="36" colspan="2" align="left" valign="middle" bgcolor="#FFFFFF" class="style17">31.	Lessons use a variety of teaching strategies.</td>
          <td align="left" valign="middle" bgcolor="#FFFFFF" class="style17"><div align="center">
              <asp:Label Font-Bold="True" ID="lblBOQQuestion31" runat="server"></asp:Label></div></td>
               <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        </tr>
		
		<tr>
		  <td height="36" align="left" valign="top" bgcolor="#D9D3EB">&nbsp;</td>
          <td height="36" colspan="2" align="left" valign="middle" bgcolor="#D9D3EB" class="style17">32.	Lessons are embedded into subject area curriculum.</td>
          <td align="left" valign="middle" bgcolor="#D9D3EB" class="style17"><div align="center">
              <asp:Label Font-Bold="True" ID="lblBOQQuestion32" runat="server"></asp:Label></div></td>
               <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        </tr>
        
		<tr>
		  <td height="36" align="left" valign="top" bgcolor="#D9D3EB">&nbsp;</td>
          <td height="36" colspan="2" align="left" valign="middle" bgcolor="#FFFFFF" class="style17">33.	Faculty/staff and students are involved in development &
delivery of behavioral curriculum
.</td>
          <td align="left" valign="middle" bgcolor="#FFFFFF" class="style17"><div align="center">
              <asp:Label Font-Bold="True" ID="lblBOQQuestion33" runat="server"></asp:Label></div></td>
               <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        </tr>
        
		<tr>
		  <td height="36" align="left" valign="top" bgcolor="#D9D3EB">&nbsp;</td>
          <td height="36" colspan="2" align="left" valign="middle" bgcolor="#D9D3EB" class="style17">34.	Strategies to share key features of SWPBS program with families/community are developed and implemented.</td>
          <td align="left" valign="middle" bgcolor="#D9D3EB" class="style17"><div align="center">
              <asp:Label Font-Bold="True" ID="lblBOQQuestion34" runat="server"></asp:Label></div></td>
               <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        </tr>
		<tr>
		  <td height="10" colspan="4" align="left" valign="top" bgcolor="#91BB4D">&nbsp;</td>
		   <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
	    </tr>
		
		<tr>
          <td rowspan="2" align="left" valign="middle" bgcolor="#D9D3EB"><span class="style17">IMPLEMENTATION<br>
&nbsp;PLAN </span></td>
		  <td height="36" colspan="2" align="left" valign="middle" bgcolor="#FFFFFF" class="style17">35.	A curriculum to teach the components of the discipline system to all staff is developed and used.</td>
          <td align="left" valign="middle" bgcolor="#FFFFFF" class="style17"><div align="center">
              <asp:Label Font-Bold="True" ID="lblBOQQuestion35" runat="server"></asp:Label></div></td>
               <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        </tr>
        
		<tr>
		  <td height="36" colspan="2" align="left" valign="middle" bgcolor="#D9D3EB" class="style17">36.	Plans for training staff how to teach expectations/rules/rewards are developed, scheduled and delivered .</td>
          <td align="left" valign="middle" bgcolor="#D9D3EB" class="style17"><div align="center">
              <asp:Label Font-Bold="True" ID="lblBOQQuestion36" runat="server"></asp:Label></div></td>
               <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        </tr>
        
		<tr>
		  <td height="36" align="left" valign="top" bgcolor="#D9D3EB">&nbsp;</td>
          <td height="36" colspan="2" align="left" valign="middle" bgcolor="#FFFFFF" class="style17">37.	A plan for teaching students expectations/rules/rewards is developed, scheduled and delivered.</td>
          <td align="left" valign="middle" bgcolor="#FFFFFF" class="style17"><div align="center">
              <asp:Label Font-Bold="True" ID="lblBOQQuestion37" runat="server"></asp:Label></div></td>
               <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        </tr>
		
		<tr>
		  <td height="36" align="left" valign="top" bgcolor="#D9D3EB">&nbsp;</td>
          <td height="36" colspan="2" align="left" valign="middle" bgcolor="#D9D3EB" class="style17">38.	Booster sessions for students and staff are planned, scheduled, and delivered.</td>
          <td align="left" valign="middle" bgcolor="#D9D3EB" class="style17"><div align="center">
              <asp:Label Font-Bold="True" ID="lblBOQQuestion38" runat="server"></asp:Label></div></td>
               <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        </tr>
        
		<tr>
		  <td height="36" align="left" valign="top" bgcolor="#D9D3EB">&nbsp;</td>
          <td height="36" colspan="2" align="left" valign="middle" bgcolor="#FFFFFF" class="style17">39.	Schedule for rewards/incentives for the year is planned.</td>
          <td align="left" valign="middle" bgcolor="#FFFFFF" class="style17"><div align="center">
              <asp:Label Font-Bold="True" ID="lblBOQQuestion39" runat="server"></asp:Label></div></td>
               <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        </tr>
        
		<tr>
		  <td height="36" align="left" valign="top" bgcolor="#D9D3EB">&nbsp;</td>
          <td height="36" colspan="2" align="left" valign="middle" bgcolor="#D9D3EB" class="style17">40.	Plans for orienting incoming staff and students are developed and implemented.</td>
          <td align="left" valign="middle" bgcolor="#D9D3EB" class="style17"><div align="center">
              <asp:Label Font-Bold="True" ID="lblBOQQuestion40" runat="server"></asp:Label></div></td>
               <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        </tr>
		
		<tr>
		  <td height="36" align="left" valign="top" bgcolor="#D9D3EB">&nbsp;</td>
          <td height="36" colspan="2" align="left" valign="middle" bgcolor="#FFFFFF" class="style17">41.	Plans for involving families/community are developed 
              and implemented.</td>
          <td align="left" valign="middle" bgcolor="#FFFFFF" class="style17"><div align="center">
              <asp:Label Font-Bold="True" ID="lblBOQQuestion41" runat="server"></asp:Label></div></td>
               <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        </tr>
		<tr>
		  <td height="10" colspan="4" align="left" valign="top" bordercolor="#91BB4D" bgcolor="#91BB4D">&nbsp;</td>
		   <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
	    </tr>
        
        
		<tr>
          <td height="36" rowspan="7" align="left" valign="top" bgcolor="#D9D3EB"><span class="style17"><br>
          CLASSROOM </span></td>
		  <td height="36" colspan="2" align="left" valign="middle" bgcolor="#D9D3EB" class="style17">42.	Classroom rules are defined for each of the school-wide expectations and are posted in classrooms..</td>
          <td align="left" valign="middle" bgcolor="#D9D3EB" class="style17"><div align="center">
              <asp:Label Font-Bold="True" ID="lblBOQQuestion42" runat="server"></asp:Label></div></td>
                <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        </tr>
        <tr>
          <td height="36" colspan="2" align="left" valign="middle" bgcolor="#FFFFFF" class="style17">43.	Classroom routines and procedures are explicitly identified for activities where problems often occur (e.g. entering class, asking questions, sharpening pencil, using restroom, dismissal).</td>
          <td align="left" valign="middle" bgcolor="#FFFFFF" class="style17"><div align="center">
              <asp:Label Font-Bold="True" ID="lblBOQQuestion43" runat="server"></asp:Label></div></td>
                <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        </tr>
        
		<tr>
          <td height="36" colspan="2" align="left" valign="middle" bgcolor="#D9D3EB" class="style17">44.	Expected behavior routines in classroom are taught.</td>
          <td align="left" valign="middle" bgcolor="#D9D3EB" class="style17"><div align="center">
              <asp:Label Font-Bold="True" ID="lblBOQQuestion44" runat="server"></asp:Label></div></td>
                <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        </tr>
        
		<tr>
          <td height="36" colspan="2" align="left" valign="middle"  bgcolor="#FFFFFF" class="style17">45.	Classroom  teachers use immediate and specific praise.</td>
          <td align="left" valign="middle" bgcolor="#FFFFFF"  class="style17"><div align="center">
              <asp:Label Font-Bold="True" ID="lblBOQQuestion45" runat="server"></asp:Label></div></td>
                <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        </tr>
		
		<tr>
          <td height="36" colspan="2" align="left" valign="middle" bgcolor="#D9D3EB" class="style17">46.	Acknowledgement of students demonstrating adherence to classroom rules and routines occurs more frequently than acknowledgement of inappropriate behaviors.</td>
          <td align="left" valign="middle" bgcolor="#D9D3EB" class="style17"><div align="center">
              <asp:Label Font-Bold="True" ID="lblBOQQuestion46" runat="server"></asp:Label></div></td>
                <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        </tr>
        
		<tr>
          <td height="36" colspan="2" align="left" valign="middle" bgcolor="#FFFFFF" class="style17">47.	Procedures exist for tracking classroom behavior problems.</td>
          <td align="left" valign="middle" bgcolor="#FFFFFF" class="style17"><div align="center">
              <asp:Label Font-Bold="True" ID="lblBOQQuestion47" runat="server"></asp:Label></div></td>
                <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        </tr>
        
		<tr>
          <td height="36" colspan="2" align="left" valign="middle" bgcolor="#D9D3EB" class="style17">48.	Classrooms have a range of consequences/interventions for problem behavior that are documented and consistently delivered.</td>
          <td align="left" valign="middle" bgcolor="#D9D3EB" class="style17"><div align="center">
              <asp:Label Font-Bold="True" ID="lblBOQQuestion48" runat="server"></asp:Label></div></td>
                <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        </tr>  
                
		<tr>
		  <td height="10" colspan="4" align="left" valign="top" bgcolor="#91BB4D">&nbsp;</td>
		    <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
	    </tr>
	    
		
		
	
        
		<tr>
          <td height="36" rowspan="5" align="left" valign="top" bgcolor="#D9D3EB"><span class="style17"><br>
          EVALUATION </span></td>
		  <td height="36" colspan="2" align="left" valign="middle" bgcolor="#FFFFFF" class="style17">49.	Students and staff are surveyed about PBS.</td>
          <td align="left" valign="middle" bgcolor="#FFFFFF" class="style17"><div align="center">
              <asp:Label Font-Bold="True" ID="lblBOQQuestion49" runat="server"></asp:Label></div></td>
                <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        </tr>
        
		<tr>
          <td height="36" colspan="2" align="left" valign="middle" bgcolor="#D9D3EB" class="style17">50.	Students and staff can identify expectations and rules.</td>
          <td align="left" valign="middle" bgcolor="#D9D3EB" class="style17"><div align="center">
              <asp:Label Font-Bold="True" ID="lblBOQQuestion50" runat="server"></asp:Label></div></td>
                <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        </tr>
		
		<tr>
          <td height="36" colspan="2" align="left" valign="middle" bgcolor="#FFFFFF" class="style17">51.	Staff use referral process (including which behaviors are office managed vs. teacher managed) and forms appropriately.</td>
          <td align="left" valign="middle" bgcolor="#FFFFFF" class="style17"><div align="center">
              <asp:Label Font-Bold="True" ID="lblBOQQuestion51" runat="server"></asp:Label></div></td>
                <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        </tr>
        
		<tr>
          <td height="36" colspan="2" align="left" valign="middle" bgcolor="#D9D3EB" class="style17">52.	Staff use reward system appropriately.</td>
          <td align="left" valign="middle" bgcolor="#D9D3EB" class="style17"><div align="center">
              <asp:Label Font-Bold="True" ID="lblBOQQuestion52" runat="server"></asp:Label></div></td>
                <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        </tr>
        
		<tr>
          <td height="36" colspan="2" align="left" valign="middle" bgcolor="#FFFFFF" class="style17">53.	Outcomes (behavior problems, attendance, morale) are documented and used to evaluate PBS plan.</td>
          <td align="left" valign="middle" bgcolor="#FFFFFF" class="style17"><div align="center">
              <asp:Label Font-Bold="True" ID="lblBOQQuestion53" runat="server"></asp:Label></div></td>
                <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        </tr>
         </tr>
			<tr>
		  <td height="10" colspan="4" align="left" valign="top" bgcolor="#91BB4D">&nbsp;</td>
		   <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
		
	    </tr>
        <tr>
          <td height="36" align="left" valign="middle" bgcolor="#FFFFFF"><span class="style17 footer style18">TOTAL SCORE </span></td>
		  <td height="36" colspan="2" align="left" valign="middle" bgcolor="#FFFFFF" class="style17"></td>
          <td align="left" valign="middle" bgcolor="#FFFFFF" class="style17"><div align="center">
              <asp:Label Font-Bold="True" ID="lblBOQTotalScore" runat="server"></asp:Label></div></td>
                <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        </tr>
	  
	    <tr>
		  <td height="10" colspan="4" align="left" valign="top" bgcolor="#91BB4D">&nbsp;</td>
		   <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
		
	    </tr>

		
        
            </table>
        </td>
    </tr>
</asp:Content>