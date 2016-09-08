<%@ Page Language="C#" AutoEventWireup="true" CodeFile="HaeTyontekijat.aspx.cs" Inherits="HaeTyontekijat" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Firman nimet</title>
    <link rel="stylesheet" href="http://www.w3schools.com/lib/w3.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div id="nappulat">
            <asp:Button ID="btnHae" runat="server" CssClass="w3-btn w3-green" Text="Hae tyontekijat" OnClick="btnHae_Click" />
        </div>
        <div id="esitys" class="w3-green">
            <asp:GridView ID="gvData" runat="server"></asp:GridView>
        </div>
        <div id="footer" class="w3-container w3-teal">
            <asp:Label ID="lbMessage" runat="server" Text="..."></asp:Label>
        </div>
    </form>
</body>
</html>
