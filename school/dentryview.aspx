<%@ Page Language="VB" MasterPageFile="~/pbsmaster/Main.master" AutoEventWireup="false" CodeFile="dentryview.aspx.vb" Inherits="school_school_dentryview" %>

<asp:Content ID ="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <tr>
							<td width="49%" align="center" valign="top"><p><span class="style2">
							<asp:Label ID="lblSchoolName" runat="server" Text="School Name" Font-Size="Medium"></asp:Label></span>
							
							 </p>
							
							</td>
                            </tr>
                       
    <tr>
        <td>

<table width="100%"  border="0" cellspacing="0" cellpadding="0">
                          <tr>
                          
                          <td align="left" valign="top">
                          <br />
                          <table width="500" border="0" cellpadding="0" cellspacing="0">
                        	<tr>
                            	<td width="27" align="right" valign="bottom"><img src="../images/green-box-top-left.gif" alt="green box top left corner"></td>
                                <td width="15" bgcolor="#C8E080">&nbsp;</td>
                                <td width="260" bgcolor="#C8E080">&nbsp;</td>
								<td width="124" bgcolor="#C8E080">&nbsp;</td>
								<td width="39"  bgcolor="#C8E080">&nbsp;</td>
                                <td width="25"><img src="../images/green-box-top-right.gif" alt="green box top right corner" width="25" height="23"></td>
                         	</tr>
                              
							<tr>
                                <td align="right"  bgcolor="#C8E080">&nbsp;</td>
                                <td colspan="3" align="left" valign="top" bgcolor="#C8E080"><div align="center"><strong>EVALUATIONS</strong>&nbsp;                                    </div></td>
                                <td bgcolor="#C8E080">&nbsp;</td>
								<td  bgcolor="#C8E080">&nbsp;</td>
                            </tr>
							  
							  
                            <tr>
                                <td align="right"  bgcolor="#C8E080">&nbsp;</td>
                                <td align="left" bgcolor="#C8E080">&nbsp;</td>
                                <td align="left" bgcolor="#C8E080">&nbsp;</td>
                                <td align="center" colspan="2" bgcolor="#C8E080"><strong>Status</strong></td>
								<td  bgcolor="#C8E080">&nbsp;</td>
                            </tr>
							
													  
                            				
							
							<tr>
							  <td align="right"  bgcolor="#C8E080">&nbsp;</td>
							  <td colspan="2" align="left" bgcolor="#C8E080"><strong>School Profile</br>
							    (Part 1 - Contact Information) </strong></td>
							  <td colspan="2" align="center" bgcolor="#C8E080">
							  <asp:HyperLink ID="hylSchProfileEdit" runat="server" Text="Update Profile" NavigateUrl="~/school/school_Profile_Edit.aspx"></asp:HyperLink>
							</td>
							  <td  bgcolor="#C8E080">&nbsp;</td>
							  </tr>
							<tr>
							  <td align="right"  bgcolor="#C8E080">&nbsp;</td>
							  <td colspan="2" align="left" bgcolor="#C8E080">&nbsp;</td>
							  <td colspan="2" align="center" bgcolor="#C8E080">&nbsp;</td>
							  <td  bgcolor="#C8E080">&nbsp;</td>
							  </tr>
						
						
                              	<tr>
                                <td align="right"  bgcolor="#C8E080" style="height: 16px">&nbsp;</td>
                                    <td colspan="2" align="left" bgcolor="#C8E080" style="height: 16px"><strong>Baseline Implementation </strong></td>
                                <td colspan="2" align="center" bgcolor="#C8E080" style="height: 16px">
                                 <asp:Label ID="lblBIStatus" runat="server"></asp:Label>  <asp:HyperLink ID="hylBILink" runat="server" Text="View" NavigateUrl="~/school/school_baseline_Add.aspx"></asp:HyperLink>
													</td>
								
								<td  bgcolor="#C8E080" style="height: 16px">
								
									 
								</td>
                            </tr>

                            <tr>
                                <td align="right" valign="top"><img src="../images/green-box-bottom-left.gif" alt="green box bottom left corner" width="27" height="24"></td>
                                <td bgcolor="#C8E080">&nbsp;</td>
                                <td bgcolor="#C8E080">&nbsp;</td>
								<td bgcolor="#C8E080">&nbsp;</td>
								<td  bgcolor="#C8E080">&nbsp;</td>
                                <td bgcolor="#C8E080"><img src="../images/green-box-bottom-right.gif" alt="green box bottom right corner" width="25" height="24"></td>
                                <td width="10"></td>
                            </tr>
                        </table>
                          
                          </td>
                          </tr>
                          
                          <tr>
                            <td align="left" valign="top">&nbsp;
												
<!-- Mid Year Reports start here -->
<br>
						
						<table width="500" border="0" cellpadding="0" cellspacing="0">
                        	<tr>
                            	<td width="27" align="right" valign="bottom"><img src="../images/green-box-top-left.gif" alt="green box top left corner"></td>
                                <td width="15" bgcolor="#C8E080">&nbsp;</td>
                                <td width="260" bgcolor="#C8E080">&nbsp;</td>
								<td width="124" bgcolor="#C8E080">&nbsp;</td>
								<td width="39"  bgcolor="#C8E080">&nbsp;</td>
                                <td width="25"><img src="../images/green-box-top-right.gif" alt="green box top right corner" width="25" height="23"></td>
                         	</tr>
                              
							<tr>
                                <td align="right"  bgcolor="#C8E080">&nbsp;</td>
                                <td colspan="3" align="left" valign="top" bgcolor="#C8E080"><div align="center"><strong>MID-YEAR EVALUATIONS</strong>&nbsp;                                    </div></td>
                                <td bgcolor="#C8E080">&nbsp;</td>
								<td  bgcolor="#C8E080">&nbsp;</td>
                            </tr>
							  
							  
                            <tr>
                                <td align="right"  bgcolor="#C8E080">&nbsp;</td>
                                <td align="left" bgcolor="#C8E080">&nbsp;</td>
                                <td align="left" bgcolor="#C8E080">&nbsp;</td>
                                <td align="center" colspan="2" bgcolor="#C8E080"><strong>Status</strong></td>
								<td  bgcolor="#C8E080">&nbsp;</td>
                            </tr>
							
													  
                            				
							
							
							<tr>
							  <td align="right"  bgcolor="#C8E080">&nbsp;</td>
							  <td colspan="2" align="left" bgcolor="#C8E080">&nbsp;</td>
							  <td colspan="2" align="center" bgcolor="#C8E080">&nbsp;</td>
							  <td  bgcolor="#C8E080">&nbsp;</td>
							  </tr>
							<tr>
							  <td align="right"  bgcolor="#C8E080">&nbsp;</td>
							  <td colspan="2" align="left" bgcolor="#C8E080"><strong>School Profile</br>
(Part 2 - Demographic Data)</strong></td>
							  <td colspan="2" align="center" bgcolor="#C8E080">&nbsp;
							  <asp:Label ID="lblSProStatus" runat="server"></asp:Label>  <asp:HyperLink ID="hylSProLink" runat="server"></asp:HyperLink>
							  </td>
							  <td  bgcolor="#C8E080">&nbsp;</td>
							  </tr>
							<tr>
							  <td align="right"  bgcolor="#C8E080">&nbsp;</td>
							  <td colspan="2" align="left" bgcolor="#C8E080">&nbsp;</td>
							  <td colspan="2" align="center" bgcolor="#C8E080">&nbsp;</td>
							  <td  bgcolor="#C8E080">&nbsp;</td>
							  </tr>
											
													
							<tr>
                                <td align="right"  bgcolor="#C8E080" style="height: 16px">&nbsp;</td>
                                    <td colspan="2" align="left" bgcolor="#C8E080" style="height: 16px"><strong>PBS Implementation Checklist - Fall </strong></td>
                                <td colspan="2" align="center" bgcolor="#C8E080" style="height: 16px">
                                
                                							  <asp:Label ID="lblPBSImpFallStatus" runat="server"></asp:Label>  <asp:HyperLink ID="hylPBSChecklistFallLink" runat="server"></asp:HyperLink>

												</td>
								
								<td  bgcolor="#C8E080" style="height: 16px">&nbsp;</td>
                            </tr>
							
							  
                            <tr>
                                <td align="right"  bgcolor="#C8E080">&nbsp;</td>
                                <td align="left" bgcolor="#C8E080">&nbsp;</td>
                                <td align="left" bgcolor="#C8E080">&nbsp;</td>
                                <td  bgcolor="#C8E080">&nbsp;</td>
								<td bgcolor="#C8E080">&nbsp;</td>
								<td  bgcolor="#C8E080">&nbsp;</td>
                            </tr>
                              	<tr>
                                <td align="right"  bgcolor="#C8E080" style="height: 16px">&nbsp;</td>
                                    <td colspan="2" align="left" bgcolor="#C8E080" style="height: 16px"><strong>PBS Implementation Checklist- Spring </strong></td>
                                <td colspan="2" align="center" bgcolor="#C8E080" style="height: 16px">
                                  <asp:Label ID="lblPBSImpSpringStatus" runat="server"></asp:Label>  <asp:HyperLink ID="hylPBSChecklistSpringLink" runat="server" Text="View"></asp:HyperLink>
													</td>
								
								<td  bgcolor="#C8E080" style="height: 16px">
								
									 
								</td>
                            </tr>

                            <tr>
                                <td align="right" valign="top"><img src="../images/green-box-bottom-left.gif" alt="green box bottom left corner" width="27" height="24"></td>
                                <td bgcolor="#C8E080">&nbsp;</td>
                                <td bgcolor="#C8E080">&nbsp;</td>
								<td bgcolor="#C8E080">&nbsp;</td>
								<td  bgcolor="#C8E080">&nbsp;</td>
                                <td bgcolor="#C8E080"><img src="../images/green-box-bottom-right.gif" alt="green box bottom right corner" width="25" height="24"></td>
                                <td width="10"></td>
                            </tr>
                        </table>
												
					
<!--
'*********************************************************************************************************************************
'*** Mid-Year Evaluations Forms Ending ***
'*********************************************************************************************************************************
-->



<!-- 
'*********************************************************************************************************************************
'*** End-Year Evaluations Forms Beginning ***
'*********************************************************************************************************************************
--> 
		
						<br></br>
						
						<table width="500" border="0" cellpadding="0" cellspacing="0">
                        	<tr>
                            	<td width="27" align="right" valign="bottom"><img src="../images/green-box-top-left.gif" alt="green box top left corner" /></td>
                                <td width="15" bgcolor="#C8E080">&nbsp;</td>
                                <td width="260" bgcolor="#C8E080">&nbsp;</td>
								<td width="125" bgcolor="#C8E080">&nbsp;</td>
								<td width="38"  bgcolor="#C8E080">&nbsp;</td>
                                <td width="25"><img src="../images/green-box-top-right.gif" alt="green box top right corner" width="25" height="23"></td>
                         	</tr>
                              
							<tr>
                                <td align="right"  bgcolor="#C8E080">&nbsp;</td>
                                <td colspan="3" align="left" valign="top" bgcolor="#C8E080"><div align="center"><strong>END-YEAR EVALUATIONS</strong>&nbsp;                                    </div></td>
                                <td bgcolor="#C8E080">&nbsp;</td>
								<td  bgcolor="#C8E080">&nbsp;</td>
                            </tr>
							  
							  
                            <tr>
                                <td align="right"  bgcolor="#C8E080">&nbsp;</td>
                                <td align="left" bgcolor="#C8E080">&nbsp;</td>
                                <td align="left" bgcolor="#C8E080">&nbsp;</td>
                                <td align="center" colspan="2" bgcolor="#C8E080"><strong>Status</strong></td>
								<td  bgcolor="#C8E080">&nbsp;</td>
                            </tr>
							
													  
                            <tr>
                                <td align="right"  bgcolor="#C8E080" style="height: 14px">&nbsp;</td>
                                <td colspan="2" align="left" bgcolor="#C8E080" style="height: 14px"><strong>Benchmarks of Quality</strong>									</td>
                                <td colspan="2" align="center" bgcolor="#C8E080" style="height: 14px">
                                
                                  <asp:Label ID="lblBOQStatus" runat="server"></asp:Label>  <asp:HyperLink ID="hylBOQLink" runat="server" Text="View" NavigateUrl="~/school/school_BOQ_Add.aspx"></asp:HyperLink>
												</td>
								<td  bgcolor="#C8E080" style="height: 14px">&nbsp;</td>
                            </tr>
							
							<tr>
							  <td align="right"  bgcolor="#C8E080">&nbsp;</td>
							  <td colspan="2" align="left" bgcolor="#C8E080">&nbsp;</td>
							  <td colspan="2" align="center" bgcolor="#C8E080">&nbsp;</td>
							  <td  bgcolor="#C8E080">&nbsp;</td>
							  </tr>
							<tr>
                                <td align="right"  bgcolor="#C8E080">&nbsp;</td>
                                <td colspan="2" align="left" bgcolor="#C8E080"><strong>Outcome Data Summary</strong></td>
								<td colspan="2" align="center" bgcolor="#C8E080">
								
								<asp:Label ID="lblODSStatus" runat="server"></asp:Label>  <asp:HyperLink ID="hylODSLink" runat="server" Text="View" NavigateUrl="~/school/school_ODS_Add.aspx"></asp:HyperLink>
																</td>
								<td  bgcolor="#C8E080">&nbsp;</td>
                            </tr>
							
							
							<tr>
                                <td align="right"  bgcolor="#C8E080">&nbsp;</td>
                                <td align="left" bgcolor="#C8E080">&nbsp;</td>
                                <td align="left" bgcolor="#C8E080">&nbsp;</td>
                                <td  bgcolor="#C8E080">&nbsp;</td>
								<td bgcolor="#C8E080">&nbsp;</td>
								<td  bgcolor="#C8E080">&nbsp;</td>
                            </tr>
                              

                            <tr>
                                <td align="right"  bgcolor="#C8E080">&nbsp;</td>
                                <td colspan="2" align="left" bgcolor="#C8E080"><strong>Benchmark for Advanced Tiers</strong></td>
								<td colspan="2" align="center" bgcolor="#C8E080">
								
								<asp:Label ID="lblBATStatus" runat="server"></asp:Label>  <asp:HyperLink ID="hylBATLink" runat="server" Text="View" NavigateUrl="~/school/school_BAT_Add.aspx"></asp:HyperLink>
																</td>
								<td  bgcolor="#C8E080">&nbsp;</td>
                            </tr>
                         <%--   <tr>
                                <td align="right" valign="top"><img src="../images/green-box-bottom-left.gif" alt="green box bottom left corner" width="27" height="24" /></td>
                                <td bgcolor="#C8E080">&nbsp;</td>
                                <td bgcolor="#C8E080">&nbsp;</td>
								<td bgcolor="#C8E080">&nbsp;</td>
								<td  bgcolor="#C8E080">&nbsp;</td>
                                <td bgcolor="#C8E080"><img src="../images/green-box-bottom-right.gif" alt="green box bottom right corner" width="25" height="24" /></td>
                                <td width="10"></td>
                            </tr>--%>
                         
                         <tr>
							  <td align="right"  bgcolor="#C8E080">&nbsp;</td>
							  <td align="left" colspan="4" bgcolor="#C8E080">&nbsp;</td>

							  <td  bgcolor="#C8E080">&nbsp;</td>
							  </tr>
							<tr>
							  <td align="right"  bgcolor="#C8E080">&nbsp;</td>
							  <td align="left" colspan="4" bgcolor="#C8E080" style="color: #FF0000"><span class="style3">*  For schools engaged in Tier 2 and/or Tier 3 supports. See end year procedure sheet for details</span>.</td>
							 
							  <td  bgcolor="#C8E080">&nbsp;</td>
							  </tr>
							<tr>

                                <td align="right"  bgcolor="#C8E080">&nbsp;</td>
                                <td align="left" bgcolor="#C8E080">&nbsp;</td>
                                <td align="left" bgcolor="#C8E080">&nbsp;</td>
                                <td  bgcolor="#C8E080">&nbsp;</td>
								<td bgcolor="#C8E080">&nbsp;</td>
								<td  bgcolor="#C8E080">&nbsp;</td>
                            </tr>
                              

                            <tr>
                                <td align="right" valign="top"><img src="../images/green-box-bottom-left.gif" alt="green box bottom left corner" width="27" height="24"></td>

                                <td bgcolor="#C8E080">&nbsp;</td>
                                <td bgcolor="#C8E080">&nbsp;</td>
								<td bgcolor="#C8E080">&nbsp;</td>
								<td  bgcolor="#C8E080">&nbsp;</td>
                                <td bgcolor="#C8E080"><img src="../images/green-box-bottom-right.gif" alt="green box bottom right corner" width="25" height="24"></td>
                                <td width="10"></td>
                            </tr>

                        </table>
							
					
					
<!-- 
'*********************************************************************************************************************************
'*** End-Year Evaluations Forms Ending ***
'*********************************************************************************************************************************
-->					</td>
                    </tr>
                    
					<tr>
                    	<td align="left" valign="top"></td>
                    </tr>
                </table>
        </td>
    </tr>
</asp:Content>