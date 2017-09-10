using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using test.Models;

namespace test
{
    public partial class Bankbalance : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            cusidd.Text = Session["cusid"].ToString();

            Customer customer = new Customer();

            BankAccount banckaccount = customer.viewBbal(cusidd.Text);

            accountno.Text = banckaccount.accno.ToString();
            balance.Text = "Rs. " + banckaccount.accbal.ToString();


        }
    }
}