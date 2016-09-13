<%@ Page Language="C#" AutoEventWireup="true" CodeFile="windowCount.aspx.cs" Inherits="windowCount" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Tarjoushinnan laskenta</title>
    <link rel="stylesheet" href="http://www.w3schools.com/lib/w3.css" />
</head>
<body>
    <form id="form1" runat="server" class="w3-light-grey">
        <div class="w3-container w3-teal w3-center">
            <h1>Oy K-S Ikkuna ja Aukko Ab</h1>
        </div>
        <div id="countData" class="w3-container w3-center">
            <div class="w3-margin-bottom w3-margin-top">
                <asp:Label ID="lbWidth" runat="server" Text="Ikkunan leveys: "></asp:Label>
                <asp:TextBox ID="txtWidth" runat="server"></asp:TextBox>
                <asp:Label ID="mmWidth" runat="server" Text="mm"></asp:Label>
            </div>
            <div class="w3-margin-bottom">
                <asp:Label ID="lbHeight" runat="server" Text="Ikkunan korkeus: "></asp:Label>
                <asp:TextBox ID="txtHeight" runat="server"></asp:TextBox>
                <asp:Label ID="mmHeight" runat="server" Text="mm"></asp:Label>
            </div>
            <div class="w3-margin-bottom">
                <asp:Label ID="lbFrame" runat="server" Text="Karmipuun leveys: "></asp:Label>
                <asp:TextBox ID="txtFrame" runat="server" Text="45"></asp:TextBox>
                <asp:Label ID="Label1" runat="server" Text="mm"></asp:Label>
            </div>
            <asp:Button ID="btnCount" Text="Laske tarjoushinta" runat="server" OnClick="btnCount_Click" class="w3-btn w3-teal"/>
        </div>
        <div id="finalData" class="w3-center">
            <asp:Label runat="server" ID="lbMessage" CssClass="w3-red" ></asp:Label>
            <br />
            <asp:Label ID="lbArea" runat="server"  Text="Ikkunan pinta-ala :"></asp:Label>
            <br />
            <asp:Label ID="lbPerimeter" runat="server"  Text="Karmipuun piiri: "></asp:Label>
            <br />
            <asp:Label ID="lbFinalPrice" runat="server"  Text="Tarjoushinta (Ilman ALV): "></asp:Label>
        </div>
    </form>
</body>
</html>
