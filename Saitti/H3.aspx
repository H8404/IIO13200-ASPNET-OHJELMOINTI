<%@ Page Language="C#" AutoEventWireup="true" CodeFile="H3.aspx.cs" Inherits="H3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Data transfer demo</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Source page</h1>
        Message to send: <asp:TextBox ID="txtMessage" runat="server"></asp:TextBox>
        <br />

        Valmiit lauseet: <asp:DropDownList runat="server" ID="ddlMessages" OnSelectedIndexChanged="ddlMessages_SelectedIndexChanged" AutoPostBack="True">

                         </asp:DropDownList>
        <br />
        <asp:Button ID="btnQuery" runat="server" Text="Use Query String" onclick="btnQuery_Click"/>
        <br />
        <asp:Button runat="server" ID="btnSession" Text="Use Session State" OnClick="btnSession_Click"/>
        <br />
        <asp:Button runat="server" ID="btnCookie" OnClick="btnCookie_Click" Text="Use Cookie"/>
        <br />
        <asp:Button runat="server" ID="btnPublicProperty" Text="Use Public Properties" onclick="btnPublicProperty_Click"/>
    </div>
    </form>
</body>
</html>
