<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="Kayitol.aspx.cs" Inherits="Araba_İlanları_Sİtesi.Kayitol" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
        <asp:TextBox ID="txt_mail" runat="server"></asp:TextBox>
&nbsp;&nbsp;
        <asp:TextBox ID="txt_password" runat="server"></asp:TextBox>
&nbsp;&nbsp;
        <asp:Button ID="btn_register" runat="server" OnClick="btn_register_Click" Text="Kayıt Ol" />
    </form>
</asp:Content>
