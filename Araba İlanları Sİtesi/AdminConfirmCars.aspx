<%@ Page Title="" Language="C#" MasterPageFile="~/AdminLayout.Master" AutoEventWireup="true" CodeBehind="AdminConfirmCars.aspx.cs" Inherits="Araba_İlanları_Sİtesi.AdminConfirmCars" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
      
        <asp:DataList ID="DataList1" runat="server">
            <ItemTemplate>
                <table class="nav-justified">
                    <tr>
                          <a href="CarOnayla.aspx?carid=<%# Eval("CarID") %>"> <div class="btn btn-danger">Onayla</div> </a> 

                      <td>Araba markası&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:TextBox ID="txt_marka" runat="server" Text='<%# Eval("CarBrandID") %>'></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>Araba Modeli&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:TextBox ID="txt_model" runat="server" Text='<%# Eval("CarModel") %>'></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>Araba Fotoğraf&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:TextBox ID="txt_fotoğraf" runat="server" Text='<%# Eval("CarPhoto") %>'></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>Araba yakıt tipi&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:TextBox ID="txt_yakit_tipi" runat="server" Text='<%# Eval("CarFuelType") %>'></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>Açıklama&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:TextBox ID="txt_aciklama" runat="server" Text='<%# Eval("CarDescription") %>'></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>Satıcı&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:TextBox ID="txt_satici" runat="server" Text='<%# Eval("CarSeller") %>'></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>Satıcı Telefon Numarası&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:TextBox ID="txt_telefon" runat="server" Text='<%# Eval("CarContact") %>'></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>Araç fiyatı&nbsp;&nbsp;&nbsp;
                            <asp:TextBox ID="txt_price" runat="server" Height="22px" Text='<%# Eval("CarPrice") %>'></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <br />
                            <br />
                            <br />
                        </td>
                    </tr>
                </table>
            </ItemTemplate>
        </asp:DataList>
      
    </form>
</asp:Content>
