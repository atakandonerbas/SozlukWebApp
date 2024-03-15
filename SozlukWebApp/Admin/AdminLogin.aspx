<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminLogin.aspx.cs" Inherits="SozlukWebApp.Admin.AdminLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Admin Giriş</title>
    <link href="Css/AdminLoginStyle.css" rel="stylesheet" />
</head>
<body class="loginPanel">
    <form id="form1" runat="server">
        <div>
            <div class="sol">
                <img src="Resimler/pandagiff.gif" />
            </div>
            <div class="sag">
                <div class="satir">
                    <h1>Admin Giriş</h1>
                </div>
                <div class="satir">
                    <asp:TextBox ID="tb_username" CssClass="textBox" PlaceHolder="Kullanıcı Adı" runat="server" />
                </div>
                <div class="satir">
                    <asp:TextBox ID="tb_password" CssClass="textBox" PlaceHolder="Şifre" TextMode="Password" runat="server" />
                </div>
                <div class="satir">
                    <asp:LinkButton ID="lb_login" OnClick="lb_login_Click" Text="Giriş" CssClass="loginButton" runat="server" />
                </div>
                <asp:Panel ID="pnl_error" CssClass="errorPanel" Visible="false" runat="server">
                    <asp:Label ID="lbl_message" runat="server" />
                </asp:Panel>
            </div>
            <div style="clear: both"></div>
        </div>
    </form>
</body>
</html>
