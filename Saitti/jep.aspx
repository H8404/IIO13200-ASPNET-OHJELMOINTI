<%@ Page Language="C#" AutoEventWireup="true" CodeFile="jep.aspx.cs" Inherits="jep" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h2>SqlDataSourcen avulla</h2>
        <asp:SqlDataSource ID="srcMySql" runat="server" ConnectionString="<%$ ConnectionStrings:MySQL %>" ProviderName="MySql.Data.MySqlClient" DeleteCommand="DELETE FROM users WHERE ID=@ID" SelectCommand="SELECT * FROM users" UpdateCommand="UPDATE users SET username=@username, password=@password, firstname=@firstname, lastname=@lastname, email=@email WHERE (ID=@ID)"></asp:SqlDataSource>
        <asp:GridView ID="gvUsers" runat="server" DataSourceID="srcMySql">
            <Columns>
                <asp:CommandField ShowEditButton="True" ShowDeleteButton="True" />
            </Columns>
        </asp:GridView>
        <h2>Luokan metodin avulla</h2>
        <asp:Button runat="server" ID="btnMysql" Text="Hae kaupungit" onclick="btnMysql_Click"/>
        <asp:GridView ID="gvCities" runat="server"></asp:GridView>
        <asp:Label runat="server" ID="lbmsq"></asp:Label>
    </div>
    </form>
</body>
</html>
