<%@ Page Language="VB" MasterPageFile="~/pbsmaster/login.master" AutoEventWireup="false" CodeFile="pbsis_login.aspx.vb" Inherits="users_pbsis_login" %>

<asp:Content ID ="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

                              <tr>
                                <td width="27" align="right" valign="bottom"><img src="../images/green-box-top-left.gif" alt="green box top left corner" /></td>
                                <td width="96" bgcolor="#C8E080">&nbsp;</td>
                                <td width="144" bgcolor="#C8E080">&nbsp;</td>
                                <td width="25"><img src="../images/green-box-top-right.gif" alt="green box top right corner" width="25" height="23" /></td>
                              </tr>
                              <tr>
                                <td align="right"  bgcolor="#C8E080">&nbsp;</td>
                                <td bgcolor="#C8E080">Username:</td>
                                <td bgcolor="#C8E080"><asp:TextBox ID="txtUser" runat="server" Width="140px"></asp:TextBox></td>
                                <td  bgcolor="#C8E080">&nbsp;</td>
                              </tr>
                              <tr>
                                <td align="right"  bgcolor="#C8E080">&nbsp;</td>
                                <td bgcolor="#C8E080"></td>
                                <td bgcolor="#C8E080"><asp:RequiredFieldValidator SetFocusOnError="True" ID="txtReqUser" ControlToValidate="txtUser" ErrorMessage="Please enter username." runat="server" Width="140px"></asp:RequiredFieldValidator></td>
                                <td  bgcolor="#C8E080">&nbsp;</td>
                              </tr>
                              <tr>
                                <td height="25" align="right"  bgcolor="#C8E080">&nbsp;</td>
                                <td bgcolor="#C8E080">Password:</td>
                                <td bgcolor="#C8E080"><asp:TextBox ID="txtPass" TextMode="Password" runat="server" Width="140px"></asp:TextBox></td>
                                <td  bgcolor="#C8E080">&nbsp;</td>
                              </tr>
                               <tr>
                                <td align="right"  bgcolor="#C8E080">&nbsp;</td>
                                <td bgcolor="#C8E080"></td>
                                <td bgcolor="#C8E080"><asp:RequiredFieldValidator SetFocusOnError="True" ID="txtReqPass" ControlToValidate="txtPass" ErrorMessage="Please enter password." runat="server" Width="140px"></asp:RequiredFieldValidator></td>
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
                                <asp:DropDownList runat="server" ID="ddlAccessLevel">
                                    <asp:ListItem Text="School" Value = "School" Selected="True"></asp:ListItem>
                                    <asp:ListItem Text="District" Value = "District"></asp:ListItem>
                                    <asp:ListItem Text="FMHI" Value = "FMHI"></asp:ListItem>
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
                                <td bgcolor="#C8E080">&nbsp;</td>
                                <td  bgcolor="#C8E080">&nbsp;</td>
                              </tr>
                              <tr>
                                <td align="right"  bgcolor="#C8E080">&nbsp;</td>
                                <td colspan="2" bgcolor="#C8E080"><div align="center">
                                
                                <asp:Button ID="Submit" CausesValidation="true" runat="server" Text="Login" />
                                  
                                </div></td>
                                <td  bgcolor="#C8E080">&nbsp;</td>
                              </tr>
                              <tr>
                                <td align="right"  bgcolor="#C8E080">&nbsp;</td>
                                <td colspan="2" bgcolor="#C8E080">&nbsp;</td>
                                <td  bgcolor="#C8E080">&nbsp;</td>
                              </tr>
                              <tr>
                                <td align="right"  bgcolor="#C8E080">&nbsp;</td>
                                <td colspan="2" bgcolor="#C8E080"><div align="center"><asp:LinkButton CausesValidation="false" ID="hylFPass" runat="server" Text="Forgot your password?"></asp:LinkButton></div></td>
                                <td  bgcolor="#C8E080">&nbsp;</td>
                              </tr>
                              <tr>
                                <td align="right" valign="top"><img src="../images/green-box-bottom-left.gif" alt="green box bottom left corner" width="27" height="24" /></td>
                                <td bgcolor="#C8E080">&nbsp;</td>
                                <td bgcolor="#C8E080">&nbsp;</td>
                                <td bgcolor="#C8E080"><img src="../images/green-box-bottom-right.gif" alt="green box bottom right corner" width="25" height="24" /></td>
                                <td width="8"></td>
                              </tr>
</asp:Content>