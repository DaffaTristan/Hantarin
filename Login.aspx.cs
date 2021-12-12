using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Odbc;
using Hantarin.Classes;

namespace Hantarin
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void BtnLogin_Click(object sender, EventArgs e)
        {
            DataTable DtLogin = new DataTable();
            DtLogin = ClsLogin.DtLogin(TxtEmail.Text, TxtPassword.Text);

            if (DtLogin.Rows.Count != 0)
            {
                Response.Redirect("~/WebForm1.aspx");
            }
            else
            {
                LblWarning.Text = "Email atau Password Anda Salah ...";
                LblWarning.Visible = true;
            }
        }

        protected void BtnSignup_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Signup.aspx");
        }

        protected void BtnResetPass_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Signup.aspx");
        }

        protected void BtnHubungi_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Signup.aspx");
        }
    }
}