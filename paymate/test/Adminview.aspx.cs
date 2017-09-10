using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using test.Models;

namespace test
{
    public partial class Adminview : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            loggedinas.Text = Session["loggedinas"].ToString();
        }

        protected void loaddetails_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();

            var dt = admin.viewcusdetail();
            customerdetails.DataSource = dt;
            customerdetails.DataBind();


        }

        protected void search_Click(object sender, EventArgs e)
        {
            var cusid = cusidd.Text;
            Admin admin = new Admin();

            
        }
    }
}