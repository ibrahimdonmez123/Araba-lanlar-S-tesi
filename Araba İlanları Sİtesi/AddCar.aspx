<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="AddCar.aspx.cs" Inherits="Araba_İlanları_Sİtesi.AddCar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
        <table class="nav-justified">
            <tr>
                <td>Araba markasını seçiniz
                    <asp:DropDownList ID="Combobox" runat="server">
                    </asp:DropDownList>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>Araba modelini yazınız
                    <asp:TextBox ID="txt_CarModel" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>Araba fotoğraf linki &nbsp;
                    <asp:TextBox runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>Araba yakıt tipi
                    <asp:TextBox ID="txt_CarFuelType" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>Açıklama giriniz
                    <asp:TextBox ID="txt_CarDescription" runat="server" Height="66px" Width="243px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>Araç satıcısı&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="txt_CarSeller" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>İİletişim telefon numarası&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="txt_CarContactNumber" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>Araç fiyatı
                    <asp:TextBox ID="txt_CarPrice" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <asp:Button ID="btn_send" runat="server" Height="28px" OnClick="btn_send_Click" Text="İlanı Gönder" Width="122px" />
    </form>
</asp:Content>
