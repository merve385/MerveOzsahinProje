<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="emlakcim.admin._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Emlakcım |Merve Özşahin</title>
    <style>

        *{
            margin:0;
            padding:0;
            border:0;
        }
        .txt{
            width:130px;
            height:26px;
        }
        .btn{
            width:90px;
            height:26px;
            background-color:#808080;
            color:#000000
        }

    </style>
</head>
<body style="background-color:#e1e1e1">
    <form id="form1" runat="server">
        <div style="width:500px;height:200px;margin:0 auto;margin-top:150px;background-color:#0d55e9">
            <div style="width:500px;height:30px;margin-top:20px;float:left;text-align:center;">
                <asp:TextBox ID="txt_kullanici" placeholder="Kullanıcı Adı" runat="server" CssClass="txt" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>

            </div>
            <div style="width:500px;height:30px;margin-top:20px;float:left;text-align:center;">
                <asp:TextBox ID="txt_sifre"  placeholder="Şifre" runat="server" CssClass="txt" OnTextChanged="TextBox2_TextChanged1"></asp:TextBox>

            </div>
            <div style="width:500px;height:30px;margin-top:20px;float:left;text-align:center;">
                <asp:Button ID="btn_giris" runat="server" Text="Giriş" CssClass="btn" OnClick="btn_giris_Click1" />

            </div>
        </div>
    </form>
</body>
</html>
