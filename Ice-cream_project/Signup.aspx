<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Signup.aspx.cs" Inherits="Ice_cream_project.Signup" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Sign Up</h2>
            <asp:Label ID="UsernameLabel" runat="server" Text="Username :"></asp:Label><asp:TextBox ID="UsernameTextBox" runat="server" placeholder="Username" /><br />
            <asp:Label ID="EmailLabel" runat="server" Text="Email"></asp:Label><asp:TextBox ID="EmailTextBox" runat="server"></asp:TextBox><br />
            <asp:Label ID="PasswordLabel" runat="server" Text="Password"></asp:Label><asp:TextBox ID="PasswordTextBox" runat="server" TextMode="Password" placeholder="Password" /><br />
            <asp:Button ID="SignUpButton" runat="server" Text="Sign Up" OnClick="SignUpButton_Click" />
        </div>
    </form>
</body>
</html>
