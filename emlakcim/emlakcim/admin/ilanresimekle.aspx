<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.Master" AutoEventWireup="true" CodeBehind="ilanresimekle.aspx.cs" Inherits="emlakcim.admin.ilanresimekle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style3 {
            width: 100%;
        }
        .auto-style4 {
            width: 191px;
        }
        .auto-style5 {
            width: 191px;
            height: 21px;
        }
        .auto-style6 {
            height: 21px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style3">
        <tr>
            <td class="auto-style4" style="text-align: right">&nbsp;</td>
            <td>
                <asp:DropDownList ID="ddl_ilan" runat="server" CssClass="ddl" OnSelectedIndexChanged="ddl_ilan_SelectedIndexChanged">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style4" style="text-align: right">Resim Adı:</td>
            <td>
                <asp:TextBox ID="txt_rAd" runat="server" CssClass="txt" Width="265px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style5" style="text-align: right">Resim:</td>
            <td class="auto-style6">
                <asp:FileUpload ID="fu_iresim" runat="server" CssClass="txt" Width="265px" />
            </td>
        </tr>
        <tr>
            <td class="auto-style4" style="text-align: right">&nbsp;</td>
            <td>
                <asp:Button ID="btn_rEkle" runat="server" CssClass="btn" OnClick="btn_rEkle_Click" Text="Resim Ekle" />
                <asp:Button ID="btn_bitir" runat="server" CssClass="btn" OnClick="btn_bitir_Click" Text="Bitir" />
            </td>
        </tr>
        <tr>
            <td class="auto-style4" style="text-align: right">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
&nbsp;
</asp:Content>
