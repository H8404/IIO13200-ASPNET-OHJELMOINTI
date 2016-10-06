<%@ Page Language="C#" AutoEventWireup="true" CodeFile="demoJson.aspx.cs" Inherits="demoJson" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="btnGet" runat="server" Text="Hae JSON teksti" OnClick="btnGet_Click" />
        <asp:Button ID="btnObject" runat="server" Text="Hae JSON ja muuta olioksi" OnClick="btnObject_Click"/>
        <asp:Button ID="btnObjectlist" runat="server" Text="Hae JSON ja muuta oliokokoelmaksi" OnClick="btnObjectlist_Click"/>
        <asp:Literal ID="ltResult" runat="server"></asp:Literal>

    </div>
    </form>
</body>
</html>
