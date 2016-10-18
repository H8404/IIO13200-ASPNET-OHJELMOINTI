<%@ Page Title="" Language="C#" MasterPageFile="~/finkino.master" AutoEventWireup="true" CodeFile="vk8.aspx.cs" Inherits="vk8" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:XmlDataSource ID="myDataSource" runat="server"></asp:XmlDataSource>
    <div class="main">
        <div class="list">
            <asp:ListBox ID="lbCity" runat="server" AutoPostBack="true" OnSelectedIndexChanged="lbCity_SelectedIndexChanged"  CssClass="city" ></asp:ListBox>
        </div>
        <div ID="picsdiv" runat="server" class="piclist">

        </div>
    </div>
    <asp:Label runat="server" ID="lbMsg"></asp:Label>
</asp:Content>

