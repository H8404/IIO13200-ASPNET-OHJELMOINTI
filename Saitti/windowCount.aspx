<%@ Page Language="C#" AutoEventWireup="true" CodeFile="windowCount.aspx.cs" Inherits="windowCount" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Tarjoushinnan laskenta</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lbWidth" runat="server" Text="Ikkunan leveys(mm): "></asp:Label>
            <asp:TextBox ID="txtWidth" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lbHeight" runat="server" Text="Ikkunan korkeus(mm): "></asp:Label>
            <asp:TextBox ID="txtHeight" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lbFrame" runat="server" Text="Karmipuun leveys(mm): "></asp:Label>
            <asp:TextBox ID="txtFrame" runat="server" Text="45"></asp:TextBox>
        </div>
        <asp:Button ID="btnCount" Text="Laske tarjoushinta" runat="server" OnClick="btnCount_Click" />
        <div id="finalData">
            <asp:Label ID="lbArea" Text="Ikkunan pinta-ala: " runat="server"></asp:Label>
            <asp:TextBox ID="txtArea" runat="server"></asp:TextBox>
            <asp:Label ID="lbPerimeter" runat="server" Text="Karmin piiri: "></asp:Label>
            <asp:TextBox ID="txtPerimeter" runat="server"></asp:TextBox>
        </div>
    </form>
</body>
</html>
