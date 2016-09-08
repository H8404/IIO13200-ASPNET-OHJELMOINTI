<%@ Page Language="C#" AutoEventWireup="true" CodeFile="hello1.aspx.cs" Inherits="hello1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>Hello!</h1>
        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        <asp:Button ID="btnSayHello" runat="server" Text="Tervehdi!" OnClick="btnSayHello_Click" />
        <asp:Label ID="lbMessage" runat="server"></asp:Label>
    </div>
    </form>
</body>
</html>
