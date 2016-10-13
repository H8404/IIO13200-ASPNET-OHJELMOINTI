<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Iltasanomatfeedi.aspx.cs" Inherits="Iltasanomatfeedi" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="btnGetFeeds" runat="server" Text="Iltasanomien feedit" OnClick="btnGetFeeds_Click"/>
        <asp:Button ID="btnGetYle" runat="server" Text="Hae YLEn pääuutiset" OnClick="btnGetYle_Click" />
        <asp:XmlDataSource ID="myDataSource" runat="server"></asp:XmlDataSource>
        <div id="myDiv" runat="server">

        </div>
    </div>
    </form>
</body>
</html>
