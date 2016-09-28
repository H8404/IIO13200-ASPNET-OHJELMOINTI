<%@ Page Language="C#" AutoEventWireup="true" CodeFile="VK3.aspx.cs" Inherits="VK3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Valitse syntymäpäiväsi!</h2>
            <asp:DropDownList id="drpCalMonth" Runat="Server" OnSelectedIndexChanged="Set_Calendar" AutoPostBack="true"></asp:DropDownList>
            <asp:DropDownList id="drpCalYear" Runat="Server" OnSelectedIndexChanged="Set_Calendar" AutoPostBack="true"></asp:DropDownList>
            <asp:Calendar ID="cdBirthday" runat="server" SelectionMode="Day" OnSelectionChanged="cdBirthday_SelectionChanged"></asp:Calendar>
            <br />
            <asp:Label ID="lbToday" runat="server"></asp:Label>
            <br />
            <asp:Label ID="lbBirthday" runat="server"></asp:Label>
            <br />
            <asp:Label ID="lbFinal" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
