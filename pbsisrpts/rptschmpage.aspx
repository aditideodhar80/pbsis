<%@ Page Language="VB" MasterPageFile="~/pbsmaster/Detail.master" AutoEventWireup="false" CodeFile="rptschmpage.aspx.vb" Inherits="pbsisrpts_rptschmpage" %>
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
        <tr> 
            <td width="10px" bgcolor="#92BC4E">&nbsp;</td>
            <td>
               
                <table border="0" cellpadding="3" cellspacing="0" style="width: 792px">
                    <tr bgcolor="#92BC4E">
                        <td height="27" class="style6"><div align="center">MID YEAR</div></td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr bgcolor="#D9D3EB">
                      <td  class="style8"> &nbsp;&nbsp;&nbsp;PIC - &nbsp;Implementation Level   </td>
                      <td align="center">
                      
                          <asp:RadioButton runat="server" ID="radioPICImpLevel" GroupName="selectrpt" />
                      </td>
                      
                    </tr>
                    <tr bgcolor="#FFFFFF">
                      <td  class="style8"> &nbsp;&nbsp;&nbsp;PIC - &nbsp;Tier 1 Critical Element</td>
                      <td ><div align="center">
                       <asp:RadioButton runat="server" ID="radioPICTier1CrtEle" GroupName="selectrpt" />
                      </div></td>
                    </tr>
                    <tr bgcolor="#92BC4E">
                      <td height="27" class="style6"><div align="center">END YEAR</div></td>
                      <td>&nbsp;</td>
                    </tr>
                    <tr bgcolor="#FFFFFF">
                        <td class="style8">&nbsp;&nbsp;&nbsp;&nbsp;ODRs</td>
                        <td><div align="center">
                          
                          <asp:RadioButton runat="server" ID="radioODRs" GroupName="selectrpt" />
                        </div></td>
                    </tr>
                      <tr bgcolor="#D9D3EB">
                        <td bgcolor="#D9D3EB" class="style8">&nbsp;&nbsp;&nbsp;&nbsp;ODR Referrals per 100 Students</td>
                        <td><div align="center">
                          
                          <asp:RadioButton runat="server" ID="radioODRRefP100Stu" GroupName="selectrpt" />
                        </div></td>
                      </tr>
                      <tr bgcolor="#FFFFFF">
                        <td class="style8">&nbsp;&nbsp;&nbsp;&nbsp;ISS & OSS Over Years of Implementation</td>
                        <td><div align="center">
                         
                           <asp:RadioButton runat="server" ID="radioISSOSSYOfImpl" GroupName="selectrpt" />
                        </div></td>
                      </tr>
                      <tr bgcolor="#D9D3EB">
                        <td class="style8">&nbsp;&nbsp;&nbsp;&nbsp;ISS & OSS per 100 Students</td>
                        <td><div align="center">
                          
                          <asp:RadioButton runat="server" ID="radioISSOSSP100Stu" GroupName="selectrpt" />
                        </div></td>
                      </tr>
                      <tr bgcolor="#FFFFFF">
                        <td class="style8">&nbsp;&nbsp; &nbsp;Average Daily Attendance</td>
                        <td><div align="center">
                         
                           <asp:RadioButton runat="server" ID="radioAvgDaiAtt" GroupName="selectrpt" />
                        </div></td>
                      </tr>
                      <tr bgcolor="#D9D3EB">
                        <td bgcolor="#D9D3EB" class="style8">&nbsp;&nbsp;&nbsp;&nbsp;Benchmark of Quality Score per Critical Element</td>
                        <td><div align="center">
                         
                          <asp:RadioButton runat="server" ID="radioBOQPerCritElem" GroupName="selectrpt" />
                        </div></td>
                      </tr>
                       <tr bgcolor="#FFFFFF">
                        <td class="style8">&nbsp;&nbsp; &nbsp;B.A.T. Subsection Report</td>
                        <td><div align="center">
                         
                           <asp:RadioButton runat="server" ID="radioAnnBATSubrep" GroupName="selectrpt" />
                        </div></td>
                      </tr>
                      <tr bgcolor="#D9D3EB">
                        <td bgcolor="#D9D3EB" class="style8">&nbsp;&nbsp;&nbsp;&nbsp;B.A.T. Summary Report</td>
                        <td><div align="center">
                         
                          <asp:RadioButton runat="server" ID="radioMultiYrBATRep" GroupName="selectrpt" />
                        </div></td>
                      </tr>
                     
                      <tr>
                        <td bgcolor="#92BC4E"></td>
                        <td bgcolor="#92BC4E"><div align="center">
                        <asp:Button ID="btnSubmit" runat="server" OnClientClick="return radio_button_checker_schReports();" BackColor="Beige"  BorderColor="#C8E07F" BorderWidth="3" Text="Get Report"/>
                        </div></td>
                      </tr>
            </table>
         
       </td>
       <td width="10px" bgcolor="#92BC4E">&nbsp;</td>
    </tr>
</asp:Content>