<%@ Page Language="C#" AutoEventWireup="true" CodeFile="vk5.aspx.cs" Inherits="vk5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>VR</h1>
        <asp:dropdownlist runat="server" id="ddCity">

        </asp:dropdownlist>
        <asp:Button ID="btnGetTrains" runat="server" Text="Hae lähtevät Junat" OnClick="btnGetTrains_Click"/>
        <br />
        <asp:Literal ID="ltResult" runat="server"></asp:Literal>
    </div>
    </form>
</body>
</html>
