<%@ Page Language="VB" MasterPageFile="~/pbsmaster/Main.master" AutoEventWireup="false" CodeFile="school_PIC_Splash.aspx.vb" Inherits="school_school_PIC_Splash" %>
<asp:Content ID ="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<tr>
    <td>
        <asp:Label Font-Bold="true" Font-Size="Small" ID="lblCaption" runat="server"></asp:Label>
    </td>
</tr>
    <tr>
        <td>
  <table width="500" border="0" cellpadding="0" cellspacing="0">
                      <tr>
                        <td width="27" align="right" valign="bottom">
						<img src="../images/green-box-top-left.gif" alt="green box top left corner"></td>
                        <td colspan="2" bgcolor="#C8E080">&nbsp;</td>
                        <td width="25">
						<img src="../images/green-box-top-right.gif" alt="green box top right corner" width="25" height="23"></td>
                      </tr>
					  <tr>
					    <td align="right"  bgcolor="#C8E080">&nbsp;</td>
					    <td colspan="2" align="left" valign="top" bgcolor="#C8E080"></td>
					    <td  bgcolor="#C8E080">&nbsp;</td>
					    </tr>
					  <tr>
					    <td align="right"  bgcolor="#C8E080" style="height: 16px">&nbsp;</td>
					    <td width="47" align="left" valign="top" bgcolor="#C8E080" style="height: 16px">&nbsp;</td>
					    <td width="401" align="left" valign="top" bgcolor="#C8E080" style="height: 16px; text-align: justify">
                            The PBS Implementation Checklist for Schools is a "snapshot" of the level of PBS
                            Implementation during the school year. It is intended to give teams a sense of <strong>
                                what has been done</strong> and <strong>what needs to be done</strong> to implement
                            PBS with fidelity. Using your knowledge and experience as coach of the PBS team,
                            determine the most appropriate rating for each item on the following scale: "0"
                            (No), "1" (Somewhat), "2" (Yes). Two reports will be generated for use in providing
                            feedback and guidance to your team.
					      </td>
					    <td  bgcolor="#C8E080" style="height: 16px">&nbsp;</td>
					    </tr>
					  <tr>
					    <td align="right"  bgcolor="#C8E080">&nbsp;</td>
					    <td colspan="2" bgcolor="#C8E080"></td>
					    <td  bgcolor="#C8E080">&nbsp;</td>
					    </tr>
					  <tr>
					    <td align="right"  bgcolor="#C8E080">&nbsp;</td>
					    <td colspan="2" bgcolor="#C8E080">&nbsp;</td>
					    <td  bgcolor="#C8E080"></td>
					    </tr>
					   <tr>
					    <td align="right"  bgcolor="#C8E080" style="height: 16px">&nbsp;</td>
					    <td colspan="3" bgcolor="#C8E080" style="height: 16px" align="center">
					    <asp:HyperLink ID="hylTutorial"  NavigateUrl="../tutorials/Tutorial_Implementation_Checklist/player.html" runat="server" Text="Tutorial"></asp:HyperLink>
					   </td>
					    <td  style="height: 16px">&nbsp;</td>
					    </tr>
					    <tr>
					        <td colspan="4" bgcolor="#C8E080">&nbsp;</td>
					    </tr>
					  <tr>
					    <td align="right"  bgcolor="#C8E080" style="height: 16px">&nbsp;</td>
					    <td colspan="3" bgcolor="#C8E080" style="height: 16px" align="center">
					    <asp:HyperLink ID="hylGotoAddPIC" runat="server" Text="Proceed"></asp:HyperLink>
					   </td>
					    <td   style="height: 16px">&nbsp;</td>
					    </tr>
						<tr>
                        <td align="right" valign="top"><img src="../images/green-box-bottom-left.gif" alt="green box bottom left corner" width="27" height="24"></td>
                        <td bgcolor="#C8E080">&nbsp;</td>
                        <td bgcolor="#C8E080">&nbsp;</td>
                        <td bgcolor="#C8E080"><img src="../images/green-box-bottom-right.gif" alt="green box bottom right corner" width="25" height="24"></td>
                       </tr>
					  </table>
        </td>
    </tr>
</asp:Content>