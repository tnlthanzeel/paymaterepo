using System;
using System.Configuration;

namespace test
{
    public partial class login : System.Web.UI.Page
    {
        private string conString = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            conString = ConfigurationManager.ConnectionStrings["paymatecontext"].ConnectionString;
            loginerror.Visible = false;
        }

        protected void btnlog_Click(object sender, EventArgs e)
        {
            string username = inputEmail.Value.ToString();
            string pwd = password.Value.ToString();

            if (pwd.Equals("asd"))
            {

                Response.Redirect("home.aspx");

            }
            else
            {
                loginerror.Visible = true;
                pwd = "";
                this.Dispose();
            }
        }
    }
}