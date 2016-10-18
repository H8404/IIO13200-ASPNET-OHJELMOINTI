<%@ Page Title="" Language="C#" MasterPageFile="~/finkino.master" AutoEventWireup="true" CodeFile="vk8.aspx.cs" Inherits="vk8" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:XmlDataSource ID="myDataSource" runat="server"></asp:XmlDataSource>
    <div>
        <asp:ListBox ID="lbCity" runat="server" OnSelectedIndexChanged="lbCity_SelectedIndexChanged"></asp:ListBox>
    </div>
    <asp:Label runat="server" ID="lbMsg"></asp:Label>
</asp:Content>

