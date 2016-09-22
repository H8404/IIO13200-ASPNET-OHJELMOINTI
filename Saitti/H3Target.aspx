<%@ Page Language="C#" AutoEventWireup="true" CodeFile="H3Target.aspx.cs" Inherits="H3Target" %>
<%@ PreviousPageType VirtualPath="~/H3.aspx" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Data transfer demo</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Target Page</h1>
        The message send to this page is: <div id="myText" runat="server"></div>
        <asp:HyperLink ID="HyperLink1" NavigateUrl="~/H3.aspx" runat="server">Takaisin</asp:HyperLink>
    </div>
    </form>
</body>
</html>
