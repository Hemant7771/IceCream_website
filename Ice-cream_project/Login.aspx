<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Ice_cream_project.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <h2>Login</h2>
            <asp:TextBox ID="LoginUsernameTextBox" runat="server" placeholder="Username" /><br />
            <asp:TextBox ID="LoginPasswordTextBox" runat="server" TextMode="Password" placeholder="Password" /><br />
            <asp:Button ID="LoginButton" runat="server" Text="Log In" OnClick="LoginButton_Click" />
        </div>
    </form>
</body>
</html>
