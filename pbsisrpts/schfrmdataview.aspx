<%@ Page Language="VB" MasterPageFile="~/pbsmaster/Detail.master" AutoEventWireup="false" CodeFile="schfrmdataview.aspx.vb" Inherits="pbsisrpts_schfrmdataview" %>


<asp:Content ID ="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <style type="text/css">
<!--
body {
	margin-left: 0px;
	margin-top: 0px;
	margin-right: 0px;
	margin-bottom: 0px;
}
.footer {color: #FFFFFF}
.style5 {
	font-family: Arial, Helvetica, sans-serif;
	font-size: 12px;
	padding-top: 4px;
	padding-right: 0px;
	padding-bottom: 4px;
	padding-left: 4px;
	text-align: left;
	font-weight: normal;
}
#data {
	height: auto;
	width: 777px;
	font-family: Arial, Helvetica, sans-serif;
	font-size: 18px;
	font-weight: bold;
	color: #000000;
	border-top-width: 10px;
	border-right-width: 5px;
	border-bottom-width: 10px;
	border-left-width: 10px;
	border-top-style: solid;
	border-bottom-style: solid;
	border-left-style: none;
	border-top-color: #92BC4E;
	border-right-color: #92BC4E;
	border-bottom-color: #92BC4E;
	border-left-color: #92BC4E;
	padding-top: 0px;
	padding-right: 0px;
	padding-bottom: 0px;
	padding-left: 0px;
	float: left;
	margin-top: 0px;
	margin-right: 0px;
	margin-bottom: 0px;
	margin-left: 0px;
	border-right-style: solid;
}
.style6 {
	font-family: Arial, Helvetica, sans-serif;
	font-weight: bold;
	font-size: 14px;
}
#login {
	font-family: Arial, Helvetica, sans-serif;
	font-size: 13px;
	margin: 0px;
	padding: 10px 0px 0px;
	float: right;
	height: 24px;
	width: 420px;
	text-align: center;
}
.style8 {
	font-size: 12px;
	font-weight: normal;
}
-->
</style>
        <tr>
         
          <td height="5" align="left" valign="middle" bgcolor="">&nbsp;</td>
        </tr>
       
        <tr><td bgcolor="#92BC4E" ></td>
          <td height="19" align="left" valign="middle" bgcolor="#92BC4E"><div align="center" class="style8"></div>            
                <div align="center" class="style6">
                    <div align="center">Data History </div>
                </div>
            <div align="center" class="style8"></div></td>
        </tr>
    <tr>
     <td width="10px" bgcolor="#92BC4E">&nbsp;</td>
        <td bgcolor="#92BC4E" align="left">
<table  border="0" cellpadding="3" cellspacing="0" style="height: 304px; width: 796px">
              <tr>
                <td bgcolor="#92BC4E" class="style6">&nbsp;</td>
                <td bgcolor="#92BC4E">&nbsp;</td>
              </tr>
              <tr bgcolor="#D9D3EB">
                <td width="77%" bgcolor="#D9D3EB" class="style6">Please select the report year:</td>
                <td width="23%"><div align="center">
                                 
                  <asp:DropDownList ID="ddlorptYear" runat="server">
                  
                    <asp:ListItem Text="2004-2005" Value="8"></asp:ListItem>
                    <asp:ListItem Text="2005-2006" Value="9"></asp:ListItem>
                    <asp:ListItem Text="2006-2007" Value="10"></asp:ListItem>
                    <asp:ListItem Text="2007-2008" Value="11" Selected="True"></asp:ListItem>
                    <asp:ListItem Text="2008-2009" Value="12"></asp:ListItem>
                    <asp:ListItem Text="2009-2010" Value="13"></asp:ListItem>
                  </asp:DropDownList>
                </div></td>
                 <td width="0" align="left" valign="middle" bgcolor="#91BB4D"></td>
              </tr>
              <tr>
                <td bgcolor="#FFFFFF" class="style6">MID YEAR </td>
                <td bgcolor="#FFFFFF">&nbsp;</td>
              </tr>
              <tr bgcolor="#D9D3EB">
                <td class="style8">&nbsp;&nbsp;&nbsp;&nbsp;PBS Implementation Checklist - Fall</td>
                <td><div align="center">
                    <asp:RadioButton GroupName="radiodatahistory" ID="radioPICFall" runat="server"/>
                </div></td>
              </tr>
               <tr bgcolor="#FFFFFF">
                <td class="style8">&nbsp;&nbsp;&nbsp;&nbsp;PBS Implementation Checklist - Spring</td>
                <td><div align="center">
                  
                   <asp:RadioButton GroupName="radiodatahistory" ID="radioPICSpring" runat="server" />
                </div></td>
              </tr>
              <tr bgcolor="#D9D3EB">
                <td class="style8">&nbsp;&nbsp;&nbsp;&nbsp;Demographic Data </td>
                <td><div align="center">
                
                    <asp:RadioButton GroupName="radiodatahistory" ID="radioDemographicData" runat="server" />
                </div></td>
              </tr>
              <tr bgcolor="#FFFFFF">
                <td class="style8"><span class="style6">END YEAR</span></td>
                <td>&nbsp;</td>
              </tr>
              <tr bgcolor="#D9D3EB">
                <td class="style8">&nbsp;&nbsp;&nbsp;&nbsp;Benchmark of Quality </td>
                <td><div align="center">
                
                   <asp:RadioButton GroupName="radiodatahistory" ID="radioBOQ" runat="server" />
                </div></td>
              </tr>
              <tr>
                <td bgcolor="#FFFFFF" class="style8">&nbsp;&nbsp;&nbsp;&nbsp;Outcome Summary Data</td>
                <td bgcolor="#FFFFFF"><div align="center">
                 
                   <asp:RadioButton GroupName="radiodatahistory" ID="radioODS" runat="server" />
                </div></td>
              </tr>
               <tr>
                <td bgcolor="#FFFFFF" class="style8">&nbsp;&nbsp;&nbsp;&nbsp;Benchmark for Advanced Tiers</td>
                <td bgcolor="#FFFFFF"><div align="center">
                 
                   <asp:RadioButton GroupName="radiodatahistory" ID="radioBAT" runat="server"/>
                </div></td>
              </tr>
                <tr>
                <td bgcolor="#92BC4E" class="style8"></td>
                <td bgcolor="#92BC4E">&nbsp;</td>
              </tr>
              <tr>
                <td bgcolor="#92BC4E"></td>
                <td bgcolor="#92BC4E">
                    <div align="center">
                         <asp:Button runat="server" ID="btnSubmit" OnClientClick="return radio_button_checker_datahistory();" Text="View Data" />
                    </div>
                </td>
              </tr>
            </table>
  
            </td>
            
    </tr>
  
                   


</asp:Content>