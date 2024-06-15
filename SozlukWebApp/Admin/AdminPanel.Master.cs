using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SozlukWebApp.Admin
{
    public partial class AdminPanel : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["admin"] != null)
            {
                Admins admin = (Admins)Session["admin"];
            }
            else
            {
                Response.Redirect("AdminLogin.aspx");
            }
        }

        protected void lbtn_cikis_Click(object sender, EventArgs e)
        {
            Session["admin"] = null;
            Response.Redirect("AdminLogin.aspx");
        }
    }
}