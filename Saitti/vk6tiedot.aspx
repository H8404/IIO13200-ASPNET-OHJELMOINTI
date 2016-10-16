<%@ Page Title="Levykauppa x" Language="C#" MasterPageFile="~/lrvykauppax.master" AutoEventWireup="true" CodeFile="vk6tiedot.aspx.cs" Inherits="vk6tiedot" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:XmlDataSource ID="myDataSource" runat="server"></asp:XmlDataSource>
    <div class="cdList">
        <div id="myDiv" runat="server">
        </div>
        <a href="vk6.aspx">Takaisin</a>
    </div>
</asp:Content>

