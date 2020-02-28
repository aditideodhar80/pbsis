<%@ Page Language="VB" MasterPageFile="~/pbsmaster/login.master" AutoEventWireup="false" CodeFile="smessages.aspx.vb" Inherits="users_smessages" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
    <tr>
        <td>
    
    <div align="center">
     <table style="width: 60%" >
        <tr>
            <td class="" align="center" >
                 <asp:Label Font-Bold="true" ID="lblHeader" runat="server" CssClass=""></asp:Label>
            </td>
        </tr>
        <tr>
          
          <td class="" style="text-align: center;">
           <table class="">
            <tr>
            <td class="" style="text-align: center;">
            
                <asp:Label ID="lblMessage" runat="server" CssClass="" Width="523px" 
                    BorderStyle="None"></asp:Label><br>
            </td>
        </tr>
        <tr><td>&nbsp;</td></tr>
        <tr>
            <td class="" style="text-align: center;">
                <asp:HyperLink ID="hlinkNext" runat="server">[hlinkNext]</asp:HyperLink>
    
            </td>
        </tr>
        
       </table>
      </td></tr>  
    </table>
    </div>
    <br />
    <br />
    &nbsp;<br />
        </td>
    </tr>
</asp:Content>