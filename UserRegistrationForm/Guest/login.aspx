<%@ Page Title="" Language="C#" MasterPageFile="~/Guest/Guest.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="UserRegistrationForm.Guest.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="login-page">
  <div class="form">
      
      <link href="css/login.css" rel="stylesheet" />
      <div>LOGIN PAGE  </div>
      <asp:TextBox ID="user" placeholder="USERNAME" runat="server"  ></asp:TextBox>
      <asp:RequiredFieldValidator  ID="RequiredFieldValidator1" runat="server" ErrorMessage="Username Please" ForeColor="Red" ControlToValidate="user"></asp:RequiredFieldValidator>
      <asp:TextBox ID="pass" placeholder="PASSWORD" runat="server" TextMode="Password"></asp:TextBox> 
      <asp:RequiredFieldValidator  ID="RequiredFieldValidator2" runat="server" ErrorMessage="Password Please" ControlToValidate="pass" ForeColor="Red"></asp:RequiredFieldValidator>
      <p class="message">Not registered? <a href="regi.aspx">Create an account</a></p>
      
      <asp:Button ID="btnlogin" runat="server" Text="Login" OnClick="btnlogin_Click"  />
      </div>
      </div>
</asp:Content>
