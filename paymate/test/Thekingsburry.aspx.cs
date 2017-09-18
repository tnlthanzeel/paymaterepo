using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using test.Models;

namespace test
{
    public partial class Thekingsburry : System.Web.UI.Page
    {
        Customer customer = new Customer();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Session["cusid"] as string))
                Response.Redirect("login.aspx");

            else
            {
                var dt = customer.viewhotel();
                roomstable.DataSource = dt;
                roomstable.DataBind();

            }
        }
    }
}