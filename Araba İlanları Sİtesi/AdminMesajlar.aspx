<%@ Page Title="" Language="C#" MasterPageFile="~/AdminLayout.Master" AutoEventWireup="true" EnableEventValidation="false" CodeBehind="AdminMesajlar.aspx.cs" Inherits="Araba_İlanları_Sİtesi.AdminMesajlar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
        <table class="nav-justified">
            <tr>
                <td>MESAJLAR<br />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:DataList ID="DataList1" runat="server">
                        <ItemTemplate>
                            <table class="nav-justified">
                                <tr>
                                    <td>Gönderen kişi&nbsp;&nbsp;
                                        <asp:Label ID="Label3" runat="server" Text='<%# Eval("ContactName") %>'></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td>Gönderen kişinin mail adresi&nbsp;
                                        <asp:Label ID="Label4" runat="server" Text='<%# Eval("ContactMail") %>'></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td>Mesaj&nbsp;&nbsp;
                                        <asp:TextBox ID="TextBox1" runat="server" Height="34px" ReadOnly="True" Text='<%# Eval("ContactMessage") %>' Width="163px"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                    <a href="MessageDelete.aspx?id=<%# Eval("ContactID") %>">  <div class="btn btn-danger">SİL </div></a>      
                                    </td>
                                </tr>
                            </table>
                        </ItemTemplate>
                    </asp:DataList>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</asp:Content>
