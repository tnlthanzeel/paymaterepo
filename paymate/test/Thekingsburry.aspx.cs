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
                reserved.Visible = false;
                pay.Visible = false;
                roomavailable.Visible = false;
                verifypay.Visible = false;
                insufficient.Visible = false;
                noroomno.Visible = false;
                roombooked.Visible = false;
                selectdate.Visible = false;
                invaliddate.Visible = false;
                var dt = customer.viewhotel();
                roomstable.DataSource = dt;
                roomstable.DataBind();

            }
        }

        protected void reserv_Click(object sender, EventArgs e)
        {
            pay.Enabled = true;
            try
            {
                reserved.Visible = false;
                verifypay.Visible = false;
                insufficient.Visible = false;
                pay.Visible = false;
                roomavailable.Visible = false;
                noroomno.Visible = false;
                roomavailable.Visible = false;
                pay.Visible = false;
                selectdate.Visible = false;
                invaliddate.Visible = false;
                roombooked.Visible = false;

                var info = TimeZoneInfo.FindSystemTimeZoneById("Sri Lanka Standard Time");

                DateTimeOffset localServerTime = DateTimeOffset.Now;

                DateTimeOffset slt = TimeZoneInfo.ConvertTime(localServerTime, info);

                DateTime sltime = slt.DateTime;


                if (string.IsNullOrEmpty(reservationdate.Value))
                {

                    selectdate.Visible = true;
                    return;
                }

                else if (!string.IsNullOrEmpty(reservationdate.Value) && Convert.ToDateTime(reservationdate.Value) < sltime)
                {
                    invaliddate.Visible = true;
                    return;
                }

                Reservations reservation = new Reservations()
                {
                    cindate = Convert.ToDateTime(reservationdate.Value),
                    roomno = Convert.ToInt16(roomnumber.Value)
                };

                var isreserved = customer.reserveroom(reservation);

                if (isreserved == 1)
                {
                    roombooked.Visible = true;
                    return;
                }

                else
                {
                    pay.Visible = true;
                    roomavailable.Visible = true;

                }

            }

            catch (Exception)
            {
                noroomno.Visible = true;
            }
        }

        protected void pay_Click(object sender, EventArgs e)
        {

            pay.Visible = true;
            
            BankAccount bankaccount = new BankAccount();
            bool lowaccbal = bankaccount.verifypayment(Session["cusid"].ToString(), Convert.ToInt16(roomnumber.Value));

            if (lowaccbal == true)
            {
                roomavailable.Visible = false;
                insufficient.Visible = true;
                return;
            }

            else if (lowaccbal == false)
            {
                Pay pay = new Pay();
                pay.confirmpay(Session["cusid"].ToString(), Convert.ToInt16(roomnumber.Value));

                Reservations reservation = new Reservations()
                {
                    cindate = Convert.ToDateTime(reservationdate.Value),
                    cusid = Session["cusid"].ToString(),
                    roomno = Convert.ToInt16(roomnumber.Value),
                    rstatus = 0

                };

                reservation.addreservation(reservation);
                reserved.Visible = true;
            }

            pay.Enabled = false;

        }
    }
}