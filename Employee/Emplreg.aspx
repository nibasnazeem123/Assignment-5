<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Emplreg.aspx.cs" Inherits="Employee.Emplreg" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
            <tr>
                <td>
                   <asp:Label ID="Label1" runat="server" Text="Name: "> </asp:Label>
                </td>
                <td>
                   <asp:TextBox ID="name" runat="server"></asp:TextBox>
               </td>
            </tr>
               <tr>
                <td>
                   <asp:Label ID="Label2" runat="server" Text="Age:"> </asp:Label>
                </td>
                <td>
                   <asp:TextBox ID="age" runat="server"></asp:TextBox>
               </td>
            </tr>  
             <tr>
                <td>
                   <asp:Label ID="Label3" runat="server" Text="Phone :"> </asp:Label>
                </td>
                <td>
                   <asp:TextBox ID="phone" runat="server"></asp:TextBox>
               </td>
            </tr>
                 <tr>
                <td>
                   <asp:Label ID="Label4" runat="server" Text="Email: "> </asp:Label>
                </td>
                <td>
                   <asp:TextBox ID="email" runat="server"></asp:TextBox>
               </td>
            </tr>
               
            </table>
             <asp:Button ID="submit" runat="server" Text="submit" OnClick="submit_Click" />
        </div>
        <a href="EmplDisplay.aspx">View Data</a>
        <input type="reset" value="Reset" />
    </form>
</body>
</html>
