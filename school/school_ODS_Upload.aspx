<%@ Page Language="VB" MasterPageFile="~/pbsmaster/Main.master" AutoEventWireup="false" CodeFile="school_ODS_Upload.aspx.vb" Inherits="school_school_ODS_Upload" %>

<asp:Content ID ="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

					<tr>
                        <td>
                             <table width="550" border="0" cellpadding="2" cellspacing="0" > 
							    <tr>
                                   <td width="49%" align="left" valign="top"><span class="style2"><FONT color="red" face="Arial, Helvetica, sans-serif" size=-1><asp:Label ID="lblDataSAved" runat="server" Text="Outcome Data has been saved successfully."></asp:Label></FONT></span>							</td>
                                </tr>
                                <tr>
                                    <td align="left" valign="top"><span class="style2"><FONT face="Arial, Helvetica, sans-serif" size=-1>School Name: <asp:Label Font-Bold="true" id="lblSchoolName" runat="server"></asp:Label></FONT></span></td></tr><tr><td>&nbsp;</td></tr><tr>
                                    <td align="left" valign="top"><span class="style2"><FONT face="Arial, Helvetica, sans-serif" size=-1> School Year: <asp:Label Font-Bold="true" ID="lblSchoolYr" runat="server"></asp:Label></FONT></span></td></tr><tr>
                                    <td align="left" valign="top">&nbsp;</td>
                                </tr>
                              </table>
                                    
                            <asp:Panel ID="pnlUpl" runat="server">
                                <table id="tblUpl" width="550" border="1" cellpadding="2" cellspacing="0" bordercolor="#000000"> 

				                 <tr>	
					                <th width="550" height="41" colspan="2" align="center" valign="center" bgcolor="#C8E07F" >Upload Document</th></tr><tr valign="middle"> 
					                <td width="30%" align="center">Select document<br>
            							
					                  </td>
					                <td align="right">
				    	                <asp:FileUpload  BorderColor="#C8E07F" BorderWidth="3" ForeColor="Black" Font-Bold="true" ID="fluploadODS" runat="server" />
            				           
					                </td>					
            				    </tr>
				          
				                 <tr>
                                       <td style="width:25%"></td>
                                       <td style="width:75%" align="right" valign="bottom"><asp:RequiredFieldValidator ID="rfvfileupload" runat="server" 
            ControlToValidate="fluploadODS" ErrorMessage="File Required!">
        </asp:RequiredFieldValidator>&nbsp;
<asp:Button Font-Bold="true" BackColor="Beige" BorderColor="#C8E07F" BorderWidth="3" ID="btnUpDoc" runat="server" Text="Upload"></asp:Button></td>
                                 </tr>
				                </table>
					        </asp:Panel>        

					<table width="550" border="0" cellspacing="0" cellpadding="0">
				
					<tr><td>&nbsp;</td></tr>
					<tr><td>&nbsp;</td></tr>
					<tr><td>&nbsp;</td></tr>
					<tr>
					    <td align="center"><b>View Uploaded Documents</b></td>
					</tr>
					<tr><td>&nbsp;</td></tr><tr>
					    <td>
					        <div align="center">
					        </div>
					    </td>
					</tr>
					 <tr>
					       <td style="width:80%" colspan="2" align="center">
                
                            <asp:GridView ID="gvDocs"  EmptyDataText = "No data to display"  Width="550"
                                runat="server" DataKeyNames="OdIdPk" AutoGenerateColumns="False" BorderColor="Black" BorderWidth="2" CellPadding="2" CellSpacing="2">
                       
                            <Columns>
                              <asp:TemplateField HeaderText="hid" Visible="false"  >
                                <ItemTemplate>
                                    <asp:Label runat="server" Visible="false" ID="lblpk" Text='<%# DataBinder.Eval(Container.DataItem,"OdIdPk")%>'></asp:Label>
                                </ItemTemplate>
                              </asp:TemplateField>
                              <asp:TemplateField HeaderText="Document Name" ItemStyle-HorizontalAlign="Left" >
                                 <ItemTemplate>
                                    <asp:HyperLink ID="hylDocname" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"ODSDocName")%>' NavigateUrl='<%# DataBinder.Eval(Container.DataItem,"NavigateURL")%>'></asp:HyperLink>
                                 </ItemTemplate>
                              </asp:TemplateField>
                              <asp:TemplateField ItemStyle-HorizontalAlign="Left" >
                                <ItemTemplate>
                                    <asp:CheckBox ID="chkDocDelete" Runat="server" Enabled="true"/>
                                </ItemTemplate>
                                <ItemStyle HorizontalAlign="Center"></ItemStyle>
                               </asp:TemplateField>
                                     
                            </Columns>
                                <EmptyDataRowStyle HorizontalAlign="Center" />
                            <FooterStyle forecolor="Black" ></FooterStyle>
                            <HeaderStyle font-size="10pt"  font-names="Arial" font-bold="True" horizontalalign="Center" forecolor="Black" backcolor="#C8E07F"></HeaderStyle>
                            <PagerStyle horizontalalign="Center" forecolor="Black"></PagerStyle>
                       
                        </asp:GridView>
                        </td>
                     </tr> 
                     <tr>
                        <td align="center"><asp:Label ID="lblnodocs" runat="server" Visible="false" Text="No documents uploaded." ForeColor="Red" Font-Bold="true"></asp:Label></td></tr><tr><td>&nbsp;</td></tr><tr>
					      <td>
					          <div align="center">
					             <asp:Button id="btnback" BackColor="Beige" CausesValidation="false" BorderColor="#C8E07F" BorderWidth="3" runat="server" Text="Back to Data Entry page" />&nbsp;&nbsp;&nbsp;<asp:Button id="btnDocDelete" CausesValidation="false" BackColor="Beige" BorderColor="#C8E07F" BorderWidth="3" runat="server" Text="Delete" />
					          </div>
					      </td>
					  </tr>
					  <tr><td>&nbsp;</td></tr><%--	<tr>
					  <td>
					      <div align="center">
					        <asp:Button id="btnback" BackColor="Beige" BorderColor="#C8E07F" BorderWidth="3" runat="server" Text="Back to Data Entry page" />
					      </div>
					  </td>
					  </tr>--%>
			
                          <tr>
                            <td align="left" valign="top">&nbsp;							
                            </td>
                          </tr>
                          
                          </table>
                          </td>
                          </tr>
                      
</asp:Content>