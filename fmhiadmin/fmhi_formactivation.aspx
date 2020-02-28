<%@ Page Language="VB" MasterPageFile="~/pbsmaster/Main.master"   AutoEventWireup="false" CodeFile="fmhi_formactivation.aspx.vb" Inherits="fmhiadmin_fmhi_formactivation" %>

<asp:Content ID ="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  <tr>
      <td>
      
        <table width="100%" border="0" cellpadding="0" cellspacing="0" >
            <tr bordercolor="#000000">
                <td height="6" align="left">
                
                <span class="style2"><asp:Label Font-Size="Medium" ID="lblCaption" runat="server" Text="SCHOOL FORM ACTIVATION/DEACTIVATION"></asp:Label></span>
                </td>
            </tr>
  <tr>
    <td>&nbsp;</td>
  </tr>
              <tr>
                <td><table width="100%" border="1" bordercolor = "black" cellspacing="0" cellpadding="0">
            
                     <tr>
                    
                        <td>
                      1.  Edit School Profile
                            
                        </td>
                         <td  align="center">
                        <asp:CheckBox ID="chkEditSchProfile" runat="server" />
                            
                        </td>
                    </tr>
                    
                    <tr>
                    <td width="300" bgcolor="#C8E07F">2. School Demographic Data</td>
                    <td width="300" bgcolor="#C8E07F" align="center"> <asp:CheckBox ID="chkDemoData" runat="server" /></td>
                    </tr>
                    
                    <tr>
                    <td width="300" >3. School Team Update</td>
                    <td width="300"  align="center"> <asp:CheckBox ID="chkSchTeamUp" runat="server" /></td>
                    </tr>
                    
                    <tr>
                    <td width="300" bgcolor="#C8E07F">4. Team Process Evaluation</td>
                    <td width="300" bgcolor="#C8E07F"  align="center"> <asp:CheckBox ID="chkTeamEval" runat="server" /></td>
                    </tr>
                    
                    <tr>
                    <td width="300" >5. Benchmarks of Quality</td>
                    <td width="300"  align="center" > <asp:CheckBox ID="chkBOQ" runat="server" /></td>
                    </tr>
                    
                    <tr>
                    <td width="300" bgcolor="#C8E07F">6. Output Data Summary</td>
                    <td width="300" bgcolor="#C8E07F"  align="center"> <asp:CheckBox ID="chkODS" runat="server" /></td>
                    </tr>
                    
                    <tr>
                    <td width="300" >7. PBS Implementation Checklist - Fall </td>
                    <td width="300"  align="center"> <asp:CheckBox ID="chkPICFall" runat="server" /></td>
                    </tr>
                    
                    <tr>
                    <td width="300" bgcolor="#C8E07F">8. PBS Implementation Checklist - Spring</td>
                    <td width="300" bgcolor="#C8E07F"  align="center"> <asp:CheckBox ID="chkPICSpring" runat="server" /></td>
                    </tr>
                    
                    <tr>
                    <td width="300" >9. Benchmark of Advanced Tiers </td>
                    <td width="300"  align="center" > <asp:CheckBox ID="chkBAT" runat="server" /></td>
                    </tr>
                    
                </table>
                </td>
              </tr>
              
         </table></td>
				
		</tr>
                          	
		
				

		
		<tr>
		    <td>&nbsp;</td>
		</tr>
		<tr>
			<td align="center"><asp:Label id="lblstatus" runat="server" ForeColor="Red"></asp:Label></td>
		</tr>
		
		

		<tr>
			<td><div align="center" style="height: 25px; width: 544px"><asp:Button runat="server" ID="btnsubmit" BackColor="Beige" BorderColor="#C8E07F" BorderWidth="3" Text="Submit" /></div></td>
		</tr>
		
		<tr>
			<td>&nbsp;</td>
		</tr><tr>
			<td>&nbsp;</td>
		</tr>
			  
			  
			             <tr bordercolor="#000000">
                <td height="6" align="left">
                
                <span class="style2"><asp:Label Font-Size="Medium" ID="Label1" runat="server" Text="SCHOOL YEAR ACTIVATION"></asp:Label></span>
                </td>
            </tr>
            <tr>
			<td>&nbsp;</td>
		</tr>
		
		
		<tr>
			    <td>
			    <table width="100%" border="1" bordercolor = "black" cellspacing="0" cellpadding="2">
			    <tr>
		    <td><asp:Label ID="lblSchYr" runat="server" Text="School Year"></asp:Label>&nbsp;&nbsp;&nbsp;<asp:DropDownList ID="ddlschyr" runat="server"></asp:DropDownList></td>
		    
		</tr>
			    </table>
			    </td>
			</tr>	
			
			
			
		
		<tr>
		    <td>&nbsp;</td>
		</tr>
		<tr>
			<td align="center"><asp:Label id="lblStaYr" runat="server" ForeColor="Red"></asp:Label></td>
		</tr>
		
		

		<tr>
			<td><div align="center" style="height: 25px; width: 544px"><asp:Button runat="server" ID="btnSaveYr" BackColor="Beige" BorderColor="#C8E07F" BorderWidth="3" Text="Submit" /></div></td>
		</tr>
		
</asp:Content>