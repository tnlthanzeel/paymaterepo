using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using test.Models;

namespace test
{
    public partial class Fundtransfer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Session["loggedinas"] as string))
            {
                accnoempty.Visible = false;
                invalidaccno.Visible = false;
                lowbalance.Visible = false;
                transfersuccess.Visible = false;
            }
            else
                Response.Redirect("login.aspx");
        }

        protected void Transfer_Click(object sender, EventArgs e)
        {
            BankAccount bankaccount = new BankAccount();
            if (string.IsNullOrEmpty(AccountNo.Text) || Convert.ToInt32(Amount.Text)<=0)
            {
                accnoempty.Visible = true;
                return;
            }
            

            else
            {
                Customer customer = new Customer();
                int result = customer.fundtransfer(AccountNo.Text);

                if (result == 1)
                {

                    result = bankaccount.requestftransfer(Session["cusid"].ToString(), Amount.Text);

                    if (result == 1)
                    {
                        bankaccount.transfer(Session["cusid"].ToString(), Amount.Text, AccountNo.Text);

                        Transfer.Enabled = false;

                        Transaction transaction = new Transaction()
                        {
                            cusid= Session["cusid"].ToString(),
                            amount=Convert.ToInt32(Amount.Text),
                            datetime=DateTime.Now,
                            type="Fund Transaction"
                        };

                        transaction.update(transaction);
                        

                        transfersuccess.Visible = true;
                    }

                    else
                        lowbalance.Visible = true;
                }

                else
                    invalidaccno.Visible = true;
            }
        }
    }
}