<%@ Page Language="VB" MasterPageFile="~/pbsmaster/Detail.master" AutoEventWireup="false" CodeFile="slr_DemoData.aspx.vb" Inherits="pbsisrpts_slr_DemoData" %>

<asp:Content ID ="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <tr>
        <td>
<table width="100%"  border="0" cellspacing="0" cellpadding="0">
        <tr>
          <td colspan="7"><img src="../images/box-top.gif" width="800" height="1"></td>
        </tr>
      
        <tr>
          <td colspan="5" align="center" valign="middle" bgcolor="#91BB4D" 
                style="height: 29px"><div align="center" class="style6">
            <div align="center"><B>SCHOOL PROFILE INFORMATION FORM (DEMOGRAPHIC INFORMATION)</B></div>
          </div></td>
          <td width="4" align="left" valign="middle" bgcolor="#91BB4D" style="height: 29px"></td>
        </tr>
        
		<tr>
          <td width="9" rowspan="59" align="left" valign="top" bgcolor="#91BB4D">&nbsp;</td>
          <td width="132" align="left" valign="middle" bgcolor="#91BB4D" 
                style="height: 21px"><span class="style6">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<B>School Name</B></span></td>
          <td width="440" align="left" valign="middle" bgcolor="#FFFFFF" class="style17" 
                style="height: 21px">&nbsp;<asp:Label ID="lblSchoolName" runat="server"></asp:Label></td>
          <td width="69" align="left" valign="middle" bgcolor="#91BB4D" class="style6" 
                style="height: 21px"><div align="right"><B>Year</B> &nbsp; </div></td>
          <td width="142" align="left" valign="middle" bgcolor="#91BB4D" class="style17" 
                style="height: 21px"><div align="center">
          <asp:DropDownList ID="ddlYear" runat="server" AutoPostBack="true">
                <%--    <asp:ListItem Text="2004-2005" Value="8"></asp:ListItem>
                    <asp:ListItem Text="2005-2006" Value="9"></asp:ListItem>
                    <asp:ListItem Text="2006-2007" Value="10"></asp:ListItem>
                    <asp:ListItem Text="2007-2008" Value="11"></asp:ListItem>
                    <asp:ListItem Text="2008-2009" Value="12"></asp:ListItem>
                    <asp:ListItem Text="2009-2010" Value="13"></asp:ListItem>--%>
                  </asp:DropDownList>
          </div></td>
          <td width="4" align="left" valign="middle" bgcolor="#91BB4D" style="height: 21px"></td>
        </tr>
        
		<tr>
          <td align="left" valign="middle" bgcolor="#91BB4D" style="height: 23px"><span class="style6">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<b>District Name</b> </span></td>
          <td align="left" valign="middle" bgcolor="#FFFFFF" class="style17" 
                style="height: 23px">&nbsp;<asp:Label ID="lblDisName" runat="server"></asp:Label></td>
          
          <td colspan="2" align="left" valign="top" bgcolor="#91BB4D" style="height: 23px"></td>
          <td width="4" align="left" valign="middle" bgcolor="#91BB4D" style="height: 23px"></td>
        </tr>
		
		    
		<tr>
          <td height="18" align="left" valign="top" bgcolor="#91BB4D">&nbsp;</td>
		  <td height="18" colspan="2" align="left" valign="top" bgcolor="#91BB4D"><span class="style6">&nbsp;</span></td>
          <td height="18" align="left" valign="top" bgcolor="#91BB4D"><div align="center"><strong class="style6">Response </strong></div></td>
          <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        </tr>
        
		<tr>
          <td height="18" rowspan="8" align="left" valign="top" bgcolor="#D9D3EB"><span class="style17"><br>
            STUDENT ENROLLMENT BY RACE/ETHNICITY
          </span></td>
		  <td height="36" colspan="2" align="left" valign="middle" bgcolor="#FFFFFF" class="style17">&nbsp;American Indian</td>
          <td align="left" valign="middle" bgcolor="#FFFFFF" class="style17"><div align="center" class="style16"><asp:Label ID="lblAmIndian" runat="server"></asp:Label></div></td>          
          <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        </tr>
        
		
		<tr>
          <td height="36" colspan="2" align="left" valign="middle" bgcolor="#D9D3EB" class="style17">&nbsp;Asian</td>
          <td align="left" valign="middle" bgcolor="#D9D3EB" class="style17"><div align="center" class="style16"><asp:Label ID="lblAsian" runat="server"></asp:Label></div></td>          
          <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        </tr>
        
		<tr>
          <td height="36" colspan="2" align="left" valign="middle" bgcolor="#FFFFFF" class="style17">&nbsp;Black</td>
          <td align="left" valign="middle" bgcolor="#FFFFFF" class="style17"><div align="center" class="style16"><asp:Label ID="lblBlack" runat="server"></asp:Label></div></td>          
          <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        </tr>
        
		<tr>
          <td height="36" colspan="2" align="left" valign="middle" bgcolor="#D9D3EB" class="style17">&nbsp;Hispanic</td>
          <td align="left" valign="middle" bgcolor="#D9D3EB" class="style17"><div align="center"><asp:Label ID="lblHisp" runat="server"></asp:Label></div></td>         
          <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        </tr>
		
		<tr>
          <td height="36" colspan="2" align="left" valign="middle" bgcolor="#FFFFFF" class="style17">&nbsp;Multiracial</td>
          <td align="left" valign="middle" bgcolor="#FFFFFF" class="style17"><div align="center" class="style16"><asp:Label ID="lblMultiracial" runat="server"></asp:Label></div></td>          
          <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        </tr>
        
		<tr>
          <td height="36" colspan="2" align="left" valign="middle" bgcolor="#D9D3EB" class="style17">&nbsp;White</td>
          <td align="left" valign="middle" bgcolor="#D9D3EB" class="style17"><div align="center"><asp:Label ID="lblWhite" runat="server"></asp:Label></div></td>         
          <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        </tr>
		
		<tr>
          <td height="36" colspan="2" align="left" valign="middle" bgcolor="#FFFFFF" class="style17">&nbsp;Other</td>
          <td align="left" valign="middle" bgcolor="#FFFFFF" class="style17"><div align="center" class="style16"><asp:Label ID="lblOther" runat="server"></asp:Label></div></td>          
          <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        </tr>
        
		<tr>
          <td height="36" colspan="2" align="left" valign="middle" bgcolor="#D9D3EB" class="style17">&nbsp;Total Enrollment</td>
          <td align="left" valign="middle" bgcolor="#D9D3EB" class="style17"><div align="center"><asp:Label ID="lblTotEnroll" runat="server"></asp:Label></div></td>         
          <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        </tr>
		
		 <tr>
          <td height="10" colspan="3" align="left" valign="top" bgcolor="#91BB4D">&nbsp;</td>
          <td height="10" align="left" valign="top" bgcolor="#91BB4D">&nbsp;</td>
          <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        </tr>
		
		
        <tr>
          <td height="18" rowspan="2" align="left" valign="middle" bgcolor="#D9D3EB"><span class="style17">STUDENT ENROLLMENT BY NEED</span></td>
		  <td height="36" colspan="2" align="left" valign="middle" bgcolor="#FFFFFF" class="style17">&nbsp;Number With IEP</td>
          <td align="left" valign="middle" bgcolor="#FFFFFF" class="style17"><div align="center"><asp:Label ID="lblNumwIEP" runat="server"></asp:Label></div></td>
          <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        </tr>
		
        <tr>
          <td height="36" colspan="2" align="left" valign="middle" bgcolor="#D9D3EB" class="style17">Percentage on Free/Reduced Lunch</td>
          <td align="left" valign="middle" bgcolor="#D9D3EB" class="style17"><div align="center"><asp:Label ID="lblPerFreeLunch" runat="server"></asp:Label></div></td>
          <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        </tr>
         
		 
		 <tr>
          <td height="10" colspan="3" align="left" valign="top" bgcolor="#91BB4D">&nbsp;</td>
          <td height="10" align="left" valign="top" bgcolor="#91BB4D">&nbsp;</td>
          <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        </tr>
		<tr>
          <td height="18" rowspan="4" align="left" valign="top" bgcolor="#D9D3EB"><p class="style17"><br>
            INITIATIVES IN PLACE </p>
          </td>
		  <td height="36" colspan="2" align="left" valign="middle" bgcolor="#FFFFFF" class="style17">&nbsp;Title One</td>
          <td align="left" valign="middle" bgcolor="#FFFFFF" class="style17">
		  		<div align="center"><asp:CheckBox ID="chkTitleOne" runat="server" />
		  	
				</div>
		  </td>
		  <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        </tr>
        
		<tr>          
		  <td height="36" colspan="2" align="left" valign="middle" bgcolor="#D9D3EB"><span class="style17">&nbsp;Reading First</span></td>
          <td align="left" valign="middle" bgcolor="#D9D3EB" class="style17">
		  		<div align="center">
		  		    <asp:CheckBox ID="chkReadingFirst" runat="server" />
		  		
				</div>		  
		  </td>    
		  <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>      
        </tr>
        
		<tr>
          <td height="36" colspan="2" align="left" valign="middle" bgcolor="#FFFFFF" class="style17">&nbsp;Problem-Solving Model</td>
          <td align="left" valign="middle" bgcolor="#FFFFFF" class="style17">
		  		<div align="center">
		  		  <asp:CheckBox ID="chkPSModel" runat="server" />
		
				</div>		  
		  </td>          
		  <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        </tr>
        
		
        <tr>
          <td height="36" colspan="3" align="left" valign="middle" bgcolor="#D9D3EB" class="style17">&nbsp;Other:&nbsp;</td>          
         <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        </tr>
         
		 
		 
		
		
		<tr>
          <td height="10" colspan="3" align="left" valign="top" bgcolor="#91BB4D">&nbsp;</td>
          <td height="10" align="left" valign="top" bgcolor="#91BB4D">&nbsp;</td>
          <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        </tr>
		<tr>
          <td height="18" rowspan="8" align="left" valign="top" bgcolor="#D9D3EB"><p class="style17"><br>
            TARGETED GROUP <BR> BEHAVIOR <BR> INTERVENTION(S)   <br><br>  
			
		
			
			</p>
          </td>
		  
		  
		  <td height="36" colspan="2" align="left" valign="middle" bgcolor="#FFFFFF" class="style17">&nbsp;BEP</td>
          <td align="left" valign="middle" bgcolor="#FFFFFF" class="style17">
		  		<div align="center">  <asp:CheckBox ID="chkBEP" runat="server" />
		  
				</div>
		  </td>
		  <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        </tr>
        
		<tr>          
		  <td height="36" colspan="2" align="left" valign="middle" bgcolor="#D9D3EB"><span class="style17">&nbsp;I Can Solve Problem </span></td>
          <td align="left" valign="middle" bgcolor="#D9D3EB" class="style17">
		  		<div align="center"><asp:CheckBox ID="chkIcanSProb" runat="server" />
		  
				</div>		  
		  </td> 
		  <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>         
        </tr>
        
		<tr>
          <td height="36" colspan="2" align="left" valign="middle" bgcolor="#FFFFFF" class="style17">&nbsp;Skillstreaming</td>
          <td align="left" valign="middle" bgcolor="#FFFFFF" class="style17">
		  		<div align="center"><asp:CheckBox ID="chkSkillStreaming" runat="server" />
		  
				</div>		  
		  </td> 
		  <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>         
        </tr>
		
		<tr>
          <td height="36" colspan="2" align="left" valign="middle" bgcolor="#D9D3EB" class="style17">&nbsp;Prepare</td>
          <td align="left" valign="middle" bgcolor="#D9D3EB" class="style17">
		  		<div align="center"><asp:CheckBox ID="chkPrepare" runat="server" />
		  	
				</div>		  
		  </td>  
		  <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>        
        </tr>
		
		<tr>
          <td height="36" colspan="2" align="left" valign="middle" bgcolor="#FFFFFF" class="style17">&nbsp;Steps To Respect</td>
          <td align="left" valign="middle" bgcolor="#FFFFFF" class="style17">
		  		<div align="center"><asp:CheckBox ID="chklStepstoRes" runat="server" />
		 
				</div>		  
		  </td>    
		  <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>      
        </tr>
		
		<tr>
          <td height="36" colspan="2" align="left" valign="middle" bgcolor="#D9D3EB" class="style17">&nbsp;Second Step</td>
          <td align="left" valign="middle" bgcolor="#D9D3EB" class="style17">
		  		<div align="center"><asp:CheckBox ID="chkSecondStep" runat="server" />
		 
				</div>		  
		  </td>  
		  <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>        
        </tr>
		
		<tr>
          <td height="36" colspan="2" align="left" valign="middle" bgcolor="#FFFFFF" class="style17">&nbsp;School Connect</td>
          <td align="left" valign="middle" bgcolor="#FFFFFF" class="style17">
		  		<div align="center"><asp:CheckBox ID="chkSchConnect" runat="server" />
				</div>		  
		  </td>  
		  <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>        
        </tr>
		
				
        <tr>
          <td height="36" colspan="3" align="left" valign="middle" bgcolor="#D9D3EB" class="style17">&nbsp;Other:&nbsp;</td>          
          <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        </tr>
         
		 
		 
		 <tr>
          <td height="10" colspan="3" align="left" valign="top" bgcolor="#91BB4D">&nbsp;</td>
          <td height="10" align="left" valign="top" bgcolor="#91BB4D">&nbsp;</td>
          <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        </tr>
		<tr>
          <td height="18" rowspan="3" align="left" valign="top" bgcolor="#D9D3EB"><p class="style17"><br>
            INDIVIDUAL <BR> LEVEL PBS   <br><br>  
			
		
			
			
			</p>
          </td>
		  
		  
		  <td height="36" colspan="2" align="left" valign="middle" bgcolor="#FFFFFF" class="style17">&nbsp;ERASE</td>
          <td align="left" valign="middle" bgcolor="#FFFFFF" class="style17">
		  		<div align="center"><asp:CheckBox ID="chkErase" runat="server" />

				</div>
		  </td>
		  <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        </tr>
        
		<tr>          
		  <td height="36" colspan="2" align="left" valign="middle" bgcolor="#D9D3EB"><span class="style17">&nbsp;PTR</span></td>
          <td align="left" valign="middle" bgcolor="#D9D3EB" class="style17">
		  		<div align="center">
		  	<asp:CheckBox ID="chkPTR" runat="server" /></asp:Label>
				</div>		  
		  </td>    
		  <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>      
        </tr>        
						
        <tr>
          <td height="36" colspan="3" align="left" valign="middle" bgcolor="#FFFFFF" class="style17">&nbsp;Other:&nbsp;</td>          
          <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        </tr>
         	 
		 
		 
		 
		 <tr>
          <td height="10" colspan="3" align="left" valign="top" bgcolor="#91BB4D">&nbsp;</td>
          <td height="10" align="left" valign="top" bgcolor="#91BB4D">&nbsp;</td>
          <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        </tr>		
		
		<tr>
          <td height="18" rowspan="2" align="left" valign="middle" bgcolor="#D9D3EB"><span class="style17">DATA SYSTEMS</span></td>
		  <td height="36" colspan="2" align="left" valign="middle" bgcolor="#FFFFFF" class="style17">Academic Data System(s) (i.e., Dibels)</td>
          <td align="left" valign="middle" bgcolor="#FFFFFF" class="style17"><div align="center"><asp:Label ID="lblAcDataSys" runat="server"></asp:Label></div></td>
         <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
          
        </tr>
        <tr>
          <td height="36" colspan="2" align="left" valign="middle" bgcolor="#D9D3EB" class="style17">Behavior Data System(s) (i.e., SWIS, Genesis, Terms)</td>
          <td align="left" valign="middle" bgcolor="#D9D3EB" class="style17"><div align="center"><asp:Label ID="lblBehaDatasys" runat="server"></asp:Label></div></td>
          <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        </tr>
         <tr>
          <td height="10" colspan="3" align="left" valign="top" bgcolor="#91BB4D">&nbsp;</td>
          <td height="10" align="left" valign="top" bgcolor="#91BB4D">&nbsp;</td>
          <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        </tr>
		<tr>
          <td height="18" rowspan="4" align="left" valign="top" bgcolor="#D9D3EB"><span class="style17"><br>
          TEACHER INFORMATION FOR CURRENT YEAR</span></td>
		  <td height="36" colspan="2" align="left" valign="middle" bgcolor="#FFFFFF" class="style17">Total Instructional Staff</td>
          <td align="left" valign="middle" bgcolor="#FFFFFF" class="style17"><div align="center"><asp:Label ID="lblTotInsStaff" runat="server"></asp:Label></div></td>
          <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        </tr>
        
		<tr>
          <td height="36" colspan="2" align="left" valign="middle" bgcolor="#D9D3EB" class="style17">% of Staff that is Instructional</td>
          <td align="left" valign="middle" bgcolor="#D9D3EB" class="style17"><div align="center"><asp:Label ID="lblPerStaffInst" runat="server"></asp:Label></div></td>
          <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        </tr>
        
		<tr>          
		  <td height="36" colspan="2" align="left" valign="middle" bgcolor="#FFFFFF" class="style17">% of Teachers with advanced degree<br>(Masters, Doctorate, or Specialist)</span></td>
          <td align="left" valign="middle" bgcolor="#FFFFFF" class="style17"><div align="center"><asp:Label ID="lblPerTeacherAdvDeg" runat="server"></asp:Label></div></td>      
          <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
            </tr>
          
        
		<tr>
          <td height="36" colspan="2" align="left" valign="middle" bgcolor="#D9D3EB" class="style17">% of Out-of-field Teachers<br>(Reported as perecentage of core academic courses taught by teachers who are out of field)</span></td>
          <td align="left" valign="middle" bgcolor="#D9D3EB" class="style17"><div align="center" class="style16"><asp:Label ID="lblOOFTeachers" runat="server"></asp:Label></div></td>
          <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        </tr>
        <tr>
          <td height="10" colspan="3" align="left" valign="top" bgcolor="#91BB4D">&nbsp;</td>
          <td height="10" align="left" valign="top" bgcolor="#91BB4D">&nbsp;</td>
          <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
        </tr>
		
       
    </table>
        </td>
    </tr>
</asp:Content>
