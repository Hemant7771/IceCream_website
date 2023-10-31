<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="cart.aspx.cs" Inherits="Ice_cream_project.cart" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Shopping Cart</h2>
            <asp:GridView ID="CartGridView" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="ProductId" HeaderText="Product ID" />
                    <asp:BoundField DataField="ProductName" HeaderText="Product Name" />
                    <asp:BoundField DataField="Price" HeaderText="Price" DataFormatString="{0:C}" />
                    <asp:BoundField DataField="Quantity" HeaderText="Quantity" />
                    <asp:ButtonField Text="Increase" ButtonType="Button" CommandName="Increase" />
                    <asp:ButtonField Text="Delete" ButtonType="Button" CommandName="Delete" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
