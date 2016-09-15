<%@ Page Language="C#" AutoEventWireup="true" CodeFile="oppilaat.aspx.cs" Inherits="oppilaat" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <h1>Oppilaat syksy 2016</h1>
            <div id="buttoset">
                <asp:Button runat="server" ID="btnGet3" Text="Hae 3 oppilasta" OnClick="btnGet3_Click" />
                <asp:Button runat="server" ID="btnGetAll" Text="Hae oppilaat tietokannasta" OnClick="btnGetAll_Click"/>
                <asp:Button runat="server" ID="btnGet3oppilas" Text="Hae 4 oppilasoliota" OnClick="btnGet3oppilas_Click"/>
            </div>
            <div id="data">
                <asp:GridView ID="gvStudents" runat="server"></asp:GridView>
            </div>
            <div id="footer">
                <asp:Label ID="lbMessages" runat="server"></asp:Label>
            </div>
        </div>
    </form>
</body>
</html>
