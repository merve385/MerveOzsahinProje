<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.Master" AutoEventWireup="true" CodeBehind="ilanekle.aspx.cs" Inherits="emlakcim.admin.ilanekle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style3 {
        width: 100%;
    }
    .auto-style4 {
        width: 195px;
    }
    .auto-style5 {
        width: 195px;
        height: 21px;
    }
    .auto-style6 {
        height: 21px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" runat="server" contentplaceholderid="ContentPlaceHolder1">
    <table class="auto-style3">
    <tr>
        <td class="auto-style4" style="text-align: right; color: #333333; font-weight: bold;">İlanın Başlığı:</td>
        <td>
            <asp:TextBox ID="txt_baslik" runat="server" CssClass="txt" Width="400px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style4" style="text-align: right; color: #333333; font-weight: bold;">Fiyat:</td>
        <td>
            <asp:TextBox ID="txt_fiyat" runat="server" CssClass="txt"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style4" style="text-align: right; color: #333333; font-weight: bold;">Kategori:</td>
        <td>
            <asp:DropDownList ID="ddl_kategori" runat="server" CssClass="ddl" Width="150px">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td class="auto-style4" style="text-align: right; color: #333333; font-weight: bold;">İşlem:</td>
        <td>
            <asp:DropDownList ID="ddl_islem" runat="server" CssClass="ddl" Width="150px">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td class="auto-style4" style="text-align: right; color: #333333; font-weight: bold;">Kimden:</td>
        <td>
            <asp:DropDownList ID="ddl_kimden" runat="server" CssClass="ddl" Width="150px">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td class="auto-style4" style="text-align: right; color: #333333; font-weight: bold;">Vitrin Olsun Mu?</td>
        <td>
            <asp:CheckBox ID="cbox_vitrin" runat="server" ForeColor="#999999" Text="Evet" />
        </td>
    </tr>
    <tr>
        <td class="auto-style4" style="text-align: right; color: #333333; font-weight: bold;">Vitrin Resmi</td>
        <td>
            <asp:FileUpload ID="fu_vitrin" runat="server" CssClass="txt" Width="400px" />
        </td>
    </tr>
    <tr>
        <td class="auto-style4" style="text-align: right; color: #333333; font-weight: bold;">Adres:</td>
        <td>
            <asp:TextBox ID="txt_adres" runat="server" CssClass="txt" Height="60px" TextMode="MultiLine" Width="400px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style5" style="text-align: right; color: #333333; font-weight: bold;">Açıklama:</td>
        <td class="auto-style6">
            <asp:TextBox ID="txt_aciklama" runat="server" CssClass="txt" Height="60px" Width="400px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style4" style="text-align: right; color: #333333; font-weight: bold;">&nbsp;</td>
        <td>
            <asp:Button ID="btn_ekle" runat="server" CssClass="btn" Text="İlan Ekle" OnClick="btn_ekle_Click" />
        </td>
    </tr>
</table>
</asp:Content>

