<%@ Page Language="C#" AutoEventWireup="true" CodeFile="xmlHarjoitus.aspx.cs" Inherits="xmlHarjoitus" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Xml ID="Xml1" DocumentSource="~/App_Data/Työntekijät2013.xml" TransformSource="~/App_Data/Demo.xsl" runat="server"></asp:Xml>

    </div>
    </form>
</body>
</html>
