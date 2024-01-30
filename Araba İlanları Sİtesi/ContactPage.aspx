<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="ContactPage.aspx.cs" Inherits="Araba_İlanları_Sİtesi.ContactPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
        <asp:TextBox ID="txt_name" runat="server" ToolTip="İsim" Width="128px"></asp:TextBox>
        <asp:TextBox ID="txtMail" runat="server" ToolTip="Mail"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnmesajigonder" runat="server" OnClick="btnmesajigonder_Click" Text="Gönder " />
        <asp:TextBox ID="txtMesaj" runat="server" Height="191px" Width="964px" ToolTip="Mesaj"></asp:TextBox>
    </form>
</asp:Content>
