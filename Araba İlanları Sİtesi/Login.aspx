<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Araba_İlanları_Sİtesi.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
        <asp:TextBox ID="txt_Mail" runat="server"></asp:TextBox>
&nbsp;
        <asp:TextBox ID="txt_Password" runat="server"></asp:TextBox>
&nbsp;&nbsp;
        <asp:Button ID="btn_login" runat="server" OnClick="btn_login_Click" Text="Giriş Yap" />
    </form>
</asp:Content>
