using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using test.Models;

namespace test
{
    public partial class Mylog : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Session["cusid"] as string))
            {
                Customer customer = new Customer();

                var dt = customer.viewTranslog(Session["cusid"].ToString());
                logtable.DataSource = dt;
                logtable.DataBind();
                logtable.Visible = true;



            }

            else
                Response.Redirect("login.aspx");


        }
    }
}