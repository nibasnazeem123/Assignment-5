<%@ Page Title="" Language="C#" MasterPageFile="~/UserSide/UserMaster.Master" AutoEventWireup="true" CodeBehind="profile.aspx.cs" Inherits="UserRegistrationForm.UserSide.profile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <link href="css/pro.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  
    <div>  
    <asp:Label ID="lb1" runat="server" Text="Label"></asp:Label>  
     <h1><font color="olive">User Details</font></h1>  
    <table border="1" style="border-collapse: collapse"  cellspacing="1">  
    <tr>  
      <td width="100" height="30" align="left" ><b><font size="4" color="red">Name:</font></b></td>  
      <td width="77" height="16" align="left" ><b><font size="4"> <asp:Label  
              ID="lbl_UserName" runat="server" Font-Bold="True"></asp:Label><br /></font></b></td>  
    </tr>  
    
    <tr>  
      <td width="77" height="16" align="left" ><b><font size="4" color="red">Email:</font></b></td>  
      <td width="77" height="16" align="left" ><b><font size="4"> <asp:Label  
              ID="lbl_email" runat="server" Font-Bold="True"></asp:Label><br /></font></b></td>  
    </tr>  
    <tr>  
      <td width="77" height="16" align="left" ><b><font size="4" color="red">Phone:</font></b></td>  
      <td width="77" height="16" align="left" ><b><font size="4"> <asp:Label  
              ID="lbl_phone" runat="server" Font-Bold="True"></asp:Label><br /></font></b></td>  
    </tr>  
    </table>  
    </div>  
   
 
</asp:Content>
