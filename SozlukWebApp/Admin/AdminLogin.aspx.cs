using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SozlukWebApp.Admin
{
    public partial class AdminLogin : System.Web.UI.Page
    {
        DataModal dm = new DataModal();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void lb_login_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_username.Text) && !string.IsNullOrEmpty(tb_password.Text))
            {
                Admins admin = dm.AdminGiris(tb_username.Text, tb_password.Text);
                if (admin != null)
                {
                    Session["admin"] = admin;
                    Response.Redirect("PanelAnasayfa.aspx");
                }
                else
                {
                    pnl_error.Visible = true;
                    lbl_message.Text = "Kullanıcı adı veya şifre yanlış.";
                }
            }
            else
            {
                pnl_error.Visible = true;
                lbl_message.Text = "Kullanıcı adı veya şifre boş bırakılamaz.";
            }
        }
    }
}