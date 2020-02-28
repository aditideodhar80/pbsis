<%@ Page Language="VB" MasterPageFile="~/pbsmaster/Main.master"  AutoEventWireup="false" CodeFile="district_mainmenu.aspx.vb" Inherits="district_district_mainmenu" %>



<asp:Content ID ="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <tr>
        <td>
            <table width="100%" border="0" cellspacing="0" cellpadding="0">
                <tr>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>
                    <table width="100%"  border="0" cellspacing="0" cellpadding="0">
                        <tr>
                            <td width="49%" align="left" valign="top">&nbsp;</td>
                        </tr>
                        <tr>
                            <td align="left" valign="top">
					            <table width="550" border="1" cellspacing="0" cellpadding="0">
					                <tr>	
						                <th width="550" align="center" valign="center" bgcolor="#C8E07F"><a href="schoolaccess_monitoring.aspx?qOptID=MidYearMon">Mid Year Monitoring</a></th>
                   	                </tr>
					            </table>
					          <br />
					          <br />
          
					            <table width="550" border="1" cellspacing="0" cellpadding="0">
					              <tr>	
						              <th width="550" align="center" valign="center" bgcolor="#C8E07F"><a href="schoolaccess_monitoring.aspx?qOptID=EndYearMon">End Year Monitoring</a></th>
                   	                </tr>
					            </table>
					            <br />
					            <br />
            					  
    			            </td>
    		            </tr>
                        <tr>
                            <td align="left" valign="top">
                            <table width="550" border="1" cellspacing="0" cellpadding="0">
					            <tr>	
						            <th width="550" align="center" valign="center" bgcolor="#C8E07F"><a href="schoolaccess_monitoring.aspx?qOptID=MidYearSLR">Mid Year School Level Reports </a></th>
                   	            </tr>
			                </table>
			                <br />
			                <br />
	                    </td>
	                 </tr>
     
                     <tr>
                        <td align="left" valign="top">
                            <table width="550" border="1" cellspacing="0" cellpadding="0">
		                        <tr>	
			                        <th width="550" align="center" valign="center" bgcolor="#C8E07F"><a href="schoolaccess_monitoring.aspx?qOptID=EndYearSLR">End Year School Level Reports </a></th>
                                </tr>
	                        </table>
	                        <br />
		                <br />
	                    </td>
                    </tr>
                    <tr>
                        <td align="left" valign="top">
                        <table width="550" border="1" cellspacing="0" cellpadding="0">
                            <tr>
                                <th width="550" align="center" valign="center" bgcolor="#C8E07F"><a href="../pbsisrpts/midyr_district_dlr.aspx">Mid-Year District Level Reports </a></th>
                            </tr>
                        </table>
                        </td>
                    </tr>
                    
                    <tr>
                        <td align="left" valign="top">
                            <br />
                            <br />
                        </td>
                    </tr>
	
	                <tr>
                        <td align="left" valign="top">
                            <table width="550" border="1" cellspacing="0" cellpadding="0">
                                <tr>
                                    <th width="550" align="center" valign="center" bgcolor="#C8E07F"><a href="../pbsisrpts/endyr_district_dlr.aspx">End-Year District Level Reports </a></th>
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