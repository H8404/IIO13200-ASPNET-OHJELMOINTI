<%@ Page Title="Levykauppax" Language="C#" MasterPageFile="~/lrvykauppax.master" AutoEventWireup="true" CodeFile="vk6.aspx.cs" Inherits="vk6" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:XmlDataSource ID="myDataSource" runat="server"></asp:XmlDataSource>
    <div class="cdList" id="myDiv" runat="server">

    </div>
</asp:Content>

