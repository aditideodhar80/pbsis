<%@ Page Language="VB" MasterPageFile="~/pbsmaster/login.master"  AutoEventWireup="false" CodeFile="forgotpassword.aspx.vb" Inherits="users_forgotyourpassword" %>


<asp:Content ID ="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
                            <tr>
                                <td colspan="4" ><table width="100%"  border="0" cellspacing="0" cellpadding="0">
                                  <tr>
                                    <td colspan="4" align="left" valign="top" style="width: 96px"><p><span class="style2"><FONT face="Arial, Helvetica, sans-serif" size=-1>FORGOT YOUR PASSWORD</FONT></span><FONT face="Arial, Helvetica, sans-serif" size=-1> 
                                    </FONT></p>
							          <p><font face="Arial, Helvetica, sans-serif" size="-1">Enter your email address and Access type (Password will be emailed to your address) .</FONT></p>
							          <p><font size="-1" face="Arial, Helvetica, sans-serif">School coordinators, please contact FLPBS staff to reset your password </font> </p></td>

                             </tr>
                             <tr>
                                    <td colspan="4"  align="left" valign="top" style="width: 96px">&nbsp;
        							
							        </td>
                             </tr>
                             </table>
                             </td>
                             </tr>
                                <tr>
                                  <td width="27" align="right" valign="bottom"><img src="../images/green-box-top-left.gif" alt="green box top left corner"></td>
                                  <td width="96" bgcolor="#C8E080">&nbsp;</td>
                                  <td width="144" bgcolor="#C8E080">&nbsp;</td>
                                  <td width="25"><img src="../images/green-box-top-right.gif" alt="green box top right corner" width="25" height="23"></td>
                                </tr>
                               
                             
                                <tr>
                                  <td align="right"  bgcolor="#C8E080">&nbsp;</td>
                                  <td bgcolor="#C8E080">Email Address </td>
                                  <td bgcolor="#C8E080"><asp:textbox ID="txtemailadd" runat="server"></asp:textbox></td>
                                  <td  bgcolor="#C8E080">&nbsp;</td>
                                </tr>
                                <tr>
                                  <td align="right"  bgcolor="#C8E080">&nbsp;</td>
                                  <td bgcolor="#C8E080">&nbsp;</td>
                                  <td bgcolor="#C8E080">&nbsp;</td>
                                  <td  bgcolor="#C8E080">&nbsp;</td>
                                </tr>
                                <tr>
                                  <td align="right"  bgcolor="#C8E080">&nbsp;</td>
                                  <td bgcolor="#C8E080">Access Type </td>
                                  <td bgcolor="#C8E080">
                                  <asp:DropDownList ID="ddlAccessLevel" runat="server">
                                    <asp:ListItem Value="District" Selected="True"></asp:ListItem>
                                  </asp:DropDownList>
                                 </td>
                                  <td  bgcolor="#C8E080">&nbsp;</td>
                                </tr>
                                <tr>
                                  <td align="right"  bgcolor="#C8E080">&nbsp;</td>
                                  <td bgcolor="#C8E080">&nbsp;</td>
                                  <td bgcolor="#C8E080">&nbsp;</td>
                                  <td  bgcolor="#C8E080">&nbsp;</td>
                                </tr>
                                <tr>
                                  <td align="right"  bgcolor="#C8E080">&nbsp;</td>
                                  <td bgcolor="#C8E080">&nbsp;</td>
                                  <td bgcolor="#C8E080"><asp:Label ID="lblmess" ForeColor="Red" runat="server"></asp:Label></td>
                                  <td  bgcolor="#C8E080">&nbsp;</td>
                                </tr>
                                <tr>
                                  <td align="right"  bgcolor="#C8E080">&nbsp;</td>
                                  <td colspan="2" bgcolor="#C8E080"><div align="center">
                                  <asp:Button id="btnSubmit" runat="server" Text="Reset Password" />
                                   
                                  </div></td>
                                  <td  bgcolor="#C8E080">&nbsp;</td>
                                </tr>
                                <tr>
                                  <td align="right" valign="top"><img src="../images/green-box-bottom-left.gif" alt="green box bottom left corner" width="27" height="24"></td>
                                  <td bgcolor="#C8E080">&nbsp;</td>
                                  <td bgcolor="#C8E080">&nbsp;</td>
                                  <td bgcolor="#C8E080"><img src="../images/green-box-bottom-right.gif" alt="green box bottom right corner" width="25" height="24"></td>
                                  <td width="8"></td>
                                </tr>
</asp:Content>

