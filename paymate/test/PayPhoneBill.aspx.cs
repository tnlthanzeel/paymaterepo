using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using test.Models;

namespace test
{
    public partial class PayPhoneBill : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            invalidammount.Visible = false;
            insufficentammount.Visible = false;
            paymentsuccessfull.Visible = false;

            if (!string.IsNullOrEmpty(Session["loggedinas"] as string))
            {

                Customer customer = new Customer()
                {
                    CusId = Session["cusid"].ToString()
                };
                Telephone telephone = customer.pbill(customer);

                phonenumberlabel.Text = telephone.tnumber.ToString();

                phonebillammount.Text = telephone.billamount.ToString();
            }
            else
                Response.Redirect("login.aspx");
        }

        protected void paybill_Click(object sender, EventArgs e)
        {
            invalidammount.Visible = false;
            insufficentammount.Visible = false;
            paymentsuccessfull.Visible = false;

            Telephone telephone = new Telephone();
            bool result = telephone.requesttpay(Convert.ToInt32(PaymantAmount.Text.ToString()));

            if (result == true)
            {

                invalidammount.Visible = true;
                return;

            }

            else
            {

                BankAccount bankaccount = new BankAccount();

                result = bankaccount.verifypayment(Session["cusid"].ToString(), Convert.ToInt32(PaymantAmount.Text.ToString()), 2);//2 for telephone bill payment

                if (result == true)
                {
                    insufficentammount.Visible = true;
                    return;
                }

                else
                {
                    Pay pay = new Pay();
                    int? amt = pay.confirmpay(Session["cusid"].ToString(), Convert.ToInt32(PaymantAmount.Text.ToString()), 2);

                    paybill.Enabled = false;
                    phonebillammount.Text = amt.ToString();
                    paymentsuccessfull.Visible = true;


                }
            }
        }
    }
}