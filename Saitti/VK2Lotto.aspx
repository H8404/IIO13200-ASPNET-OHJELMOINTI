<%@ Page Language="C#" AutoEventWireup="true" CodeFile="VK2Lotto.aspx.cs" Inherits="VK2Lotto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Lotto numeroiden arvonta</h1>
        <div>
            <asp:Label runat="server" ID="lbType" Text="Loton tyyppi: " ></asp:Label>
            <asp:DropDownList ID="ddType" runat="server">
                <asp:ListItem Value="lotto">Lotto</asp:ListItem>
                <asp:ListItem Value="vikinglotto">Viking Lotto</asp:ListItem>
            </asp:DropDownList>
        </div>
         <div>
             <asp:Label runat="server" ID="lbRows" Text="Rivien määrä:"></asp:Label>
             <asp:TextBox runat="server" ID="txtRows"></asp:TextBox>
         </div>
        <asp:Button runat="server" ID="btnRandNumbers" Text="Arvo lottorivi" OnClick="btnRandNumbers_Click" />
        <asp:Label runat="server" ID="lbRandNumbers"></asp:Label>
    </div>
    </form>
</body>
</html>
