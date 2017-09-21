using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using test.Models;

namespace test
{
    public partial class Viewreservations : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Session["cusid"] as string))
                Response.Redirect("login.aspx");

            else
            {
                Customer customer = new Customer();
                string cus = Session["cusid"].ToString();
                var dt = customer.cancelreservation(Session["cusid"].ToString());
              
            }
        }
    }
}