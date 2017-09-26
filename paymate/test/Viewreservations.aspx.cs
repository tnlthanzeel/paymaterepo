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
        Customer customer = new Customer();

        protected void Page_Load(object sender, EventArgs e)
        {
            invalidid.Visible = false;
            noid.Visible = false;
            cancelsuccess.Visible = false;
            if (string.IsNullOrEmpty(Session["cusid"] as string))
                Response.Redirect("login.aspx");

            else
            {
               
                string cus = Session["cusid"].ToString();
                var dt = customer.cancelreservation(Session["cusid"].ToString());

                reservationstable.DataSource = dt;
                reservationstable.DataBind();

            }
        }

        protected void cancel_Click(object sender, EventArgs e)
        {


            try
            {
                if (Convert.ToInt16(cancelid.Value) < 0)
                {
                    invalidid.Visible = true;
                    return;
                }

                Reservations reservation = new Reservations()
                {
                    resid = Convert.ToInt16(cancelid.Value),
                    cusid = Session["cusid"].ToString(),
                    rstatus = 1
                };

                var result = reservation.cancelreservation(reservation);

                if (result == false)
                {
                    invalidid.Visible = true;
                    return;
                }

                else if(result==true)
                {
                    cancel.Enabled = false;
                    cancelsuccess.Visible = true;

                    var dt = customer.cancelreservation(Session["cusid"].ToString());

                    reservationstable.DataSource = dt;
                    reservationstable.DataBind();
                    return;

                    ;
                }
            }


            catch (Exception )
            {

                noid.Visible = true;
               
            }
        }
    }
}