<%@ Page Title="" Language="C#" MasterPageFile="~/Guest/Guest.Master" AutoEventWireup="true" CodeBehind="registration.aspx.cs" Inherits="UserRegistrationForm.Guest.registration" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
        <link href="css/reg.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <table class="auto-style1" align="center" > 
                <tr>  
                    <td>UserName:</td>  
                    <td>  
                        <asp:TextBox ID="name" runat="server"></asp:TextBox> 
                         </td> 
                    <td>   
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Name can't be blank" ControlToValidate="name" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>  
  
               </tr> 

         <tr>  
                    <td>Password :</td>  
                    <td>  
                        <asp:TextBox ID="pass" runat="server" TextMode="Password"></asp:TextBox>  
                        </td><td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Pass can't be blank" ControlToValidate="pass" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>  
  
               </tr> 

         <tr>  
                    <td>Phone :</td>  
                    <td>  
                        <asp:TextBox ID="phone" runat="server"></asp:TextBox> 
                        </td><td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Phone can't be blank" ControlToValidate="phone" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>  
  
               </tr> 

         <tr>  
                    <td>Email</td>  
                    <td>  
                        <asp:TextBox ID="email" runat="server"></asp:TextBox>  
                        </td><td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Email can't be blank" ControlToValidate="email" ForeColor="Red"></asp:RequiredFieldValidator>
                        </td>
                       
                              
               </tr> 
           <tr>
                   <td><asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click"  /></td> 
                                </tr>
      </table>
    
</asp:Content>
