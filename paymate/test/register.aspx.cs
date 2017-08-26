using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace test
{
    public partial class register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        

        protected void btnreg_Click(object sender, EventArgs e)
        {
            string useremail = emailId.Value.ToString();




            Response.Redirect("home.aspx");
        }
    }
}