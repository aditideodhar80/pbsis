<%@ Page Language="VB" MasterPageFile="~/pbsmaster/Detail.master" AutoEventWireup="false" CodeFile="midyrdlr_indvtrgtdist.aspx.vb" Inherits="pbsisrpts_midyrdlr_indvtrgtdist" %>
<asp:Content ID ="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <tr>
        <td>

<table width="800" border="0" cellspacing="0" cellpadding="0">
  
  <tr>
    <td>
        <table width="100%"  border="0" cellpadding="0" cellspacing="0" bgcolor="#92BC4E">
        <tr>
          <td colspan="7"><img src="../images/box-top.gif" width="800" height="1" /></td>
        </tr>
        
     
        <tr>
          <td height="30" colspan="5" align="left" valign="middle" bgcolor="#92BC4E"><div align="center" class="style6"> 
              <div align="center"><b>Tiers of Support in Active Schools</b></div>
          </div></td>
        </tr>
        <tr>
          <td width="8" rowspan="2" align="left" valign="top" bgcolor="#92BC4E">&nbsp;</td>
          <td width="118" height="28" align="left" valign="middle" bgcolor="#92BC4E"><span class="style6"><b>District Name</b></span></td>
          <td width="431" align="left" valign="middle" bgcolor="#FFFFFF" class="style8">&nbsp;<asp:Label ID="lblDistName" runat="server"></asp:Label></td>
          <td width="94" align="left" valign="middle" bgcolor="#92BC4E" class="style6"><div align="right"><b>Year</b>&nbsp;</div></td>
          <td width="120" align="left" valign="middle" bgcolor="#FFFFFF" class="style8">&nbsp;&nbsp;<asp:Label ID="lblYear" runat="server"></asp:Label></td>
          <td width="4" align="left" valign="middle" bgcolor="#91BB4D"></td>
        </tr>

        <tr>
          <td colspan="4" align="left" valign="top" bgcolor="#92BC4E"><div id="data">&nbsp;<br />
             <table width="777" border="0" align="left" cellpadding="0" cellspacing="0">
		 
			      <tr>
				    <td width="36" height="30" align="left" valign="middle" bgcolor="#D9D3EB">&nbsp;</td>
				    <td width="653" height="30" align="left" valign="middle" bgcolor="#D9D3EB"class="style8">Schools Using School-Wide/Universal PBS (Tier 1)</td>
				    <td width="88" height="30" align="left" valign="middle" bgcolor="#D9D3EB" class="style6"><div align="center"><asp:Label Font-Size="Small" Font-Bold="true" ID="lblSchUnivPBSITier1" runat="server"></asp:Label></div></td>
			    </tr>
 		
                  <tr>
                    <td height="30" align="left" valign="middle" bgcolor="#FFFFFF">&nbsp;</td>
                    <td height="30" align="left" valign="middle" bgcolor="#FFFFFF" class="style8">Schools Using Targeted Group PBS (Tier 2) </td>
                    <td height="30" align="left" valign="middle" bgcolor="#FFFFFF" class="style6"><div align="center" class="style6"><asp:Label Font-Size="Small" Font-Bold="true" ID="lblSchTargGrpTier2" runat="server"></asp:Label></div></td>
                    </tr>
                  <tr>
                    <td height="30" align="left" valign="middle" bgcolor="#D9D3EB">&nbsp;</td>
                    <td height="30" align="left" valign="middle" bgcolor="#D9D3EB" class="style8">Schools Using Individual PBS (Tier 3) </td>
                    <td height="30" align="left" valign="middle" bgcolor="#D9D3EB" class="style5"><div align="center" class="style6"><asp:Label Font-Size="Small" Font-Bold="true" ID="lblSchInPBSTier3" runat="server"></asp:Label></div></td>
                    </tr>
            </table>
        </td>
    </tr>
    </table>
    </td>
    </tr>
    </table>
    </td>
    </tr>
</asp:Content>