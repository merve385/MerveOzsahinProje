<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.Master" AutoEventWireup="true" CodeBehind="ilandetayekle.aspx.cs" Inherits="emlakcim.admin.ilandetayekle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style3 {
            width: 100%;
        }
        .auto-style4 {
            width: 191px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style3">
        <tr>
            <td class="auto-style4" style="text-align: right; font-weight: bold; color: #808080;">İlanımız:</td>
            <td>
                <asp:DropDownList ID="ddl_ilan" runat="server" CssClass="ddl" Width="120px">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style4" style="text-align: right; font-weight: bold; color: #808080;">Oda Sayısı:</td>
            <td>
                <asp:TextBox ID="txt_odasayisi" runat="server" CssClass="txt"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style4" style="text-align: right; font-weight: bold; color: #808080;">Bina Yaşı:</td>
            <td>
                <asp:TextBox ID="txt_binayasi" runat="server" CssClass="txt"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style4" style="text-align: right; font-weight: bold; color: #808080;">Bina Kaç Katlı:</td>
            <td>
                <asp:TextBox ID="txt_binakat" runat="server" CssClass="txt" OnTextChanged="TextBox3_TextChanged"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style4" style="text-align: right; font-weight: bold; color: #808080;">Kaçıncı Katta:</td>
            <td>
                <asp:TextBox ID="txt_kacincikat" runat="server" CssClass="txt"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style4" style="text-align: right; font-weight: bold; color: #808080;">Isıtma:</td>
            <td>
                <asp:TextBox ID="txt_isitma" runat="server" CssClass="txt"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style4" style="text-align: right; font-weight: bold; color: #808080;">Eşyalı mı?</td>
            <td>
                <asp:CheckBox ID="cbox_esya" runat="server" Text="Evet" />
            </td>
        </tr>
        <tr>
            <td class="auto-style4" style="text-align: right; font-weight: bold; color: #808080;">&nbsp;</td>
            <td>
                <asp:Button ID="btn_dtyEkle" runat="server" CssClass="btn" OnClick="btn_dtyEkle_Click" Text="Detay Ekle" />
            </td>
        </tr>
    </table>
&nbsp;
</asp:Content>
