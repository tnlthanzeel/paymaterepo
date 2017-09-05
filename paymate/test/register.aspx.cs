using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using test.Models;

namespace test
{
    public partial class register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }



        protected void btnreg_Click(object sender, EventArgs e)
        {


            Customer customer = new Customer()
            {
                CusName = name.Value.ToString(),
                CusId = emailId.Value.ToString(),
                CardNumber = Convert.ToInt64(cardno.Value.ToString()),
                CardType = Request.Form["cardtype"].ToString(),
                CusAddress = address.Value.ToString(),
                CusBlockStat = 0,
                CusNic = nicnumber.Value.ToString(),
                CusPhone = mobilenumber.Value.ToString(),
                CusPwd= passwordinput.Value.ToString()


            };

            customer.cregister(customer);
            Session["loggedinas"] = customer.CusName;
             Response.Redirect("home.aspx");
        }
    }
}