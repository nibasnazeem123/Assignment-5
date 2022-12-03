<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmplDisplay.aspx.cs" Inherits="Employee.EmplDisplay" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <asp:GridView ID="GridView1" runat="server" DataKeyNames="EmployeeId" AutoGenerateColumns="False" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating" OnRowDeleting="GridView1_RowDeleting"  OnRowCancelingEdit="GridView1_RowCancelingEdit">
               <Columns>  
               
                <asp:TemplateField HeaderText="Employee Id">  
                    <ItemTemplate>  
                        <asp:Label ID="lbl_ID" runat="server" Text='<%#Eval("EmployeeId") %>'></asp:Label>  
                    </ItemTemplate>  
                </asp:TemplateField>  
                <asp:TemplateField HeaderText="Name">  
                    <ItemTemplate>  
                        <asp:Label ID="lbl_Name" runat="server" Text='<%#Eval("Name") %>'></asp:Label>  
                    </ItemTemplate>  
                    <EditItemTemplate>  
                        <asp:TextBox ID="txt_Name" runat="server" Text='<%#Eval("Name") %>'></asp:TextBox>  
                    </EditItemTemplate>  
                </asp:TemplateField>  
               

                   <asp:TemplateField HeaderText="Email">  
                    <ItemTemplate>  
                        <asp:Label ID="lbl_email" runat="server" Text='<%#Eval("Email") %>'></asp:Label>  
                    </ItemTemplate>  
                    <EditItemTemplate>  
                        <asp:TextBox ID="txt_email" runat="server" Text='<%#Eval("Email") %>'></asp:TextBox>  
                    </EditItemTemplate>  
                </asp:TemplateField> 

                   <asp:TemplateField HeaderText="Phone">  
                    <ItemTemplate>  
                        <asp:Label ID="lbl_phone" runat="server" Text='<%#Eval("Phone") %>'></asp:Label>  
                    </ItemTemplate>  
                    <EditItemTemplate>  
                        <asp:TextBox ID="txt_phone" runat="server" Text='<%#Eval("Phone") %>'></asp:TextBox>  
                    </EditItemTemplate>  
                </asp:TemplateField> 

                   <asp:TemplateField HeaderText="Age">  
                    <ItemTemplate>  
                        <asp:Label ID="lbl_age" runat="server" Text='<%#Eval("Age") %>'></asp:Label>  
                    </ItemTemplate>  
                    <EditItemTemplate>  
                        <asp:TextBox ID="txt_age" runat="server" Text='<%#Eval("Age") %>'></asp:TextBox>  
                    </EditItemTemplate>  
                </asp:TemplateField> 

                   <asp:ButtonField ButtonType="Button" CommandName="Delete" Text="Remove" />
                    <asp:TemplateField>  
                    <ItemTemplate>  
                        <asp:Button ID="btn_Edit" runat="server" Text="Edit" CommandName="Edit" />  
                    </ItemTemplate>  
                    <EditItemTemplate>  
                        <asp:Button ID="btn_Update" runat="server" Text="Update" CommandName="Update"/>  
                        <asp:Button ID="btn_Cancel" runat="server" Text="Cancel" CommandName="Cancel"/>  
                    </EditItemTemplate>  
                </asp:TemplateField>  
            </Columns>  
             

  
            </asp:GridView>
            <a href="Emplreg.aspx">Add New Data</a>
        </div>
    </form>
</body>
</html>
