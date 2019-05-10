<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.Master" AutoEventWireup="true" CodeBehind="ilanozellikekle.aspx.cs" Inherits="emlakcim.admin.ilanozellikekle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style3 {
            width: 100%;
        }
        .auto-style4 {
            height: 18px;
        }
        .auto-style5 {
            width: 25%;
        }
        .auto-style6 {
            width: 25%;
            height: 23px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style3">
        <tr>
            <td class="auto-style4" colspan="4">
                <asp:DropDownList ID="ddl_ilan" runat="server" CssClass="ddl">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td colspan="4" style="color: #800000">İÇ ÖZELLİKLER</td>
        </tr>
        <tr>
            <td class="auto-style6">
                <asp:CheckBox ID="cbox_kuvet" runat="server" Text="Küvet" />
            </td>
            <td class="auto-style6">
                <asp:CheckBox ID="cbox_asansör" runat="server" Text="Asansör" />
            </td>
            <td class="auto-style6">
                <asp:CheckBox ID="cbox_sömine" runat="server" Text="Şömine" />
            </td>
            <td class="auto-style6">
                <asp:CheckBox ID="cbox_kapici" runat="server" Text="Kapıcı" />
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style5">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td colspan="4">&nbsp;</td>
        </tr>
        <tr>
            <td colspan="4" style="color: #800000">DIŞ ÖZELLİKLER</td>
        </tr>
        <tr>
            <td>
                <asp:CheckBox ID="cbox_alarm" runat="server" Text="Alarm" />
            </td>
            <td class="auto-style5">
                <asp:CheckBox ID="cbox_park" runat="server" Text="Park" />
            </td>
            <td>
                <asp:CheckBox ID="cbox_oyun" runat="server" Text="Oyun" />
            </td>
            <td>
                <asp:CheckBox ID="cbox_yuruyus" runat="server" Text="Yürüyüş" />
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style5">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style5">
                <asp:Button ID="btn_ekle" runat="server" CssClass="btn" Text="Özellik Ekle" OnClick="btn_ekle_Click" />
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
&nbsp;
</asp:Content>
