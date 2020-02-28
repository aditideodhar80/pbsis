<%@ Page Language="VB" AutoEventWireup="false" MasterPageFile="~/pbsmaster/Detail.master" CodeFile="endyr_district_dlr.aspx.vb" Inherits="pbsisrpts_endyr_district_dlr" %>
<asp:Content ID ="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 <tr>
 <td>

    <table width="100%"  border="0" cellpadding="0" cellspacing="0" bgcolor="#92BC4E">
            <tr>
              <td colspan="4"><img src="../images/box-top.gif" width="800" height="1"></td>
            </tr>
            
           <%-- <tr>
              <td width="4" rowspan="4" align="left" valign="top" background="../images/bounding-box-line-left-side.gif">&nbsp;</td>
              <td height="30" colspan="2" align="left" valign="top" bgcolor="#FFFFFF">
                  
             <div align="right"> </tD></div></td>
              <td rowspan="4" background="../images/bounding-box-line-right-sid.gif" bgcolor="#92BC4E">&nbsp;</td>
            </tr>--%>
            <tr>
              <td width="8" rowspan="3" align="left" valign="top" bgcolor="#92BC4E">&nbsp;</td>
              <td height="5" align="left" valign="middle" bgcolor="#92BC4E"></td>
              <td width="4" align="left" valign="middle" bgcolor="#91BB4D">&nbsp;</td>
            </tr>
            <tr>
              <td height="19" align="left" valign="middle" bgcolor="#92BC4E"><div align="center" class="style8"></div>            <div align="center" class="style6">
                  <div align="center"><asp:label ID="lblhead" runat="server" Text="District Reports" Font-Bold="true" Font-Size="Medium"></asp:label></div>
                </div>
                <div align="center" class="style8"></div></td>
            </tr>
            
            <tr>
              <td align="left" valign="top" bgcolor="#92BC4E"><div id="data">
                              <table width="100%"  border="0" cellpadding="3" cellspacing="0">
                                <tr>
                                  <td width="77%" bgcolor="#92BC4E" class="style9" style="font-weight: bold">Grouped by School year Level </td>
                                  <td width="23%" bgcolor="#92BC4E">&nbsp;</td>
                                </tr>
                                <tr bgcolor="#FFFFFF">
                                  <td> &nbsp;&nbsp;Average ODR per 100 students</td>
                                  <td>
                                  <asp:RadioButton runat="server" ID="radioavgODRper100" GroupName="selectrpt" />
                                 </td>
                                </tr>
                                <tr bgcolor="#D9D3EB">
                                  <td class="style8"> &nbsp;&nbsp;Average ISS per 100 students</td>
                                  <td>
                                  <asp:RadioButton runat="server" ID="radioAvgISSper100" GroupName="selectrpt" />
                                  </td>
                                </tr>
                                <tr bgcolor="#FFFFFF">
                                  <td class="style8"> &nbsp;&nbsp;Average OSS per 100 students</td>
                                  <td>
                                  <asp:RadioButton runat="server" ID="radioAvgOSSper100" GroupName="selectrpt" />
                                 </td>
                                </tr>
                                <tr bgcolor="#D9D3EB">
                                  <td class="style8"> &nbsp;&nbsp;Percent Making  Gains in Reading</td>
                                  <td>
                                    <asp:RadioButton runat="server" ID="radioPerMakiingGainsinReading" GroupName="selectrpt" />
                                  </td>
                                </tr>
                                <tr bgcolor="#FFFFFF">
                                  <td bgcolor="#FFFFFF" class="style8"> &nbsp;&nbsp;Percentage of Lowest 25% Making Gains in Reading</td>
                                  <td>
                                    <asp:RadioButton runat="server" ID="radioPerLowest25MGInR" GroupName="selectrpt" />
                                  </td>
                                </tr>
                              
                                <tr bgcolor="#D9D3EB">
                                  <td class="style8"> &nbsp;&nbsp;Average Daily Attendance</td>
                                  <td>
                                  <asp:RadioButton runat="server" ID="radioAbgDailyAttend" GroupName="selectrpt" />
                                  </td>
                                </tr>
	                              <tr bgcolor="#FFFFFF">
                                  <td class="style8">&nbsp;&nbsp;Percentage at FCAT Reading Level 3 </td>
                                   <td>
                                    <asp:RadioButton runat="server" ID="radioPerAtFCATRL3" GroupName="selectrpt" />
                                   </td>
                                </tr>
                                <tr bgcolor="#92BC4E">
                                  <td class="style8">&nbsp;</td>
                                  <td>&nbsp;</td>
                                </tr>
                                <tr bgcolor="#FFFFFF">
                                  <td class="style8"> &nbsp;&nbsp;Average Benchmark Score per Critical Element Category - (All School Type) </td>
                                  <td>
                                   <asp:RadioButton runat="server" ID="radioAvgBSpCrtEleCatAllSchType" GroupName="selectrpt" />
                                  </td>
                                </tr>
                                <tr bgcolor="#D9D3EB">
                                  <td bgcolor="#D9D3EB" class="style8">&nbsp;Schools Trained in PBS: Inactive/ Active </td>
                                  <td>
                                   <asp:RadioButton runat="server" ID="radioSchTrInPBS" GroupName="selectrpt" />
                                  </td>
                                </tr>
                                                                <tr bgcolor="#92BC4E">
                                  <td class="style8">&nbsp;</td>
                                  <td>&nbsp;</td>
                                </tr>
                                
                                 <tr bgcolor="#FFFFFF">
                                  <td class="style8"> &nbsp;&nbsp;B.A.T. Subsection Report - (All School Type) </td>
                                  <td>
                                   <asp:RadioButton runat="server" ID="radioBATAllSchTypes" GroupName="selectrpt" />
                                  </td>
                                </tr>
                                
                                <tr bgcolor="#D9D3EB">
                                  <td class="style8"> &nbsp;&nbsp;B.A.T. Summary Report - (All School Type) </td>
                                  <td>
                                   <asp:RadioButton runat="server" ID="radioMultiBATAllSchTypes" GroupName="selectrpt" />
                                  </td>
                                </tr>
                                <tr>
                                  <td bgcolor="#92BC4E"><div align="right"><span class="style9">Please select the school type for the following end-year reports:</span></div></td>
                                      <td bgcolor="#92BC4E">
                                        <asp:DropDownList ID="ddlSchType" runat="server">
                                        <asp:ListItem Value="0" Selected="True" Text="PreK"></asp:ListItem>
                                        <asp:ListItem Value="1" Text="Elementary"></asp:ListItem>
                                        <asp:ListItem Value="2" Text="Middle"></asp:ListItem>
                                        <asp:ListItem Value="3" Text="High"></asp:ListItem>
                                        <asp:ListItem Value="4" Text="Alt/Center"></asp:ListItem>
                                        <asp:ListItem Value="5" Text="Other"></asp:ListItem>
                                      </asp:DropDownList>
                                     </td>
                                </tr>
                                <tr bgcolor="#D9D3EB">
                                  <td><span class="style8">&nbsp;&nbsp;Average ODR per 100 students by Implementation Level</span></td>
                                  <td>
                                  <asp:RadioButton runat="server" ID="radioODRper100ByImpLev" GroupName="selectrpt" />
                                  </td>
                                </tr>
                                <tr bgcolor="#FFFFFF">
                                  <td><span class="style8">&nbsp;&nbsp;Average Benchmark Score per Critical Element Category</span></td>
                                  <td>
                                   <asp:RadioButton runat="server" ID="radioAvgBSPerCrtEleCat" GroupName="selectrpt" />
                                  </td>
                                </tr>
                                <tr bgcolor="#92BC4E">
                                  <td class="style8">&nbsp;</td>
                                  <td>&nbsp;</td>
                                </tr>
                                
                                 <tr bgcolor="#D9D3EB">
                                  <td><span class="style8">&nbsp;&nbsp;B.A.T. Subsection Report - (by School Type)</span></td>
                                  <td>
                                  <asp:RadioButton runat="server" ID="radioBATBySchTypes" GroupName="selectrpt" />
                                  </td>
                                </tr>
                                <tr bgcolor="#FFFFFF">
                                  <td><span class="style8">&nbsp;&nbsp;B.A.T. Summary Report - (by School Type)</span></td>
                                  <td>
                                   <asp:RadioButton runat="server" ID="radioMultiBATBySchTypes" GroupName="selectrpt" />
                                  </td>
                                </tr>
                                <tr bgcolor="#92BC4E">
                                  <td class="style8">&nbsp;</td>
                                  <td>&nbsp;</td>
                                </tr>
	                            <tr bgcolor="#D9D3EB">
                                  <td class="style8"> &nbsp;&nbsp;Compiled End-Year Report</td>
                                  <td>
                                   <asp:RadioButton runat="server" ID="radioCompiledEndYrRep" GroupName="selectrpt" />
                                  </td>
                                </tr>
                            	
	                            
                                <tr>
                                  <td bgcolor="#92BC4E"></td>
                                  <td bgcolor="#92BC4E"><asp:Button ID="btnSubmit" runat="server" OnClientClick="return radio_button_checker_endyrdistDLR();" BackColor="Beige"  BorderColor="#C8E07F" BorderWidth="3" Text="Get Report"/></td>
                                </tr>
                              </table>
</div>
</td>
        </tr>
        
     
    </table>
        </td>
    </tr>
    <tr>
              <td width="8" rowspan="3" align="left" valign="top" bgcolor="#92BC4E">&nbsp;</td>
              <td height="5" align="left" valign="middle" bgcolor="#92BC4E"></td>
            </tr>
</asp:Content>