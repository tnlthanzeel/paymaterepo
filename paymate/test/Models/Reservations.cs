using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace test.Models
{
    public class Reservations
    {
        public int resid { get; set; }
        public string cusid { get; set; }
        public int roomno { get; set; }
        public DateTime cindate { get; set; }
        public DateTime coudate { get; set; }
        public int rstatus { get; set; }
        public int rtype { get; set; }
        string conString = "";



        public void addreservation(Reservations reservation)
        {
            conString = ConfigurationManager.ConnectionStrings["paymatecontext"].ConnectionString;
            SqlConnection con = new SqlConnection(conString);



            SqlCommand cmd = new SqlCommand("insert into reservation values('" + reservation.cusid + "','" + reservation.roomno + "','" + reservation.cindate + "','" + reservation.rstatus + "')", con);
            con.Open();
            cmd.ExecuteNonQuery();

            cmd = new SqlCommand("select * from room where droomno='" + roomno + "'", con);
            SqlDataReader rdr = cmd.ExecuteReader();
            rdr.Read();
            int paymentamount = Convert.ToInt32(rdr[2].ToString());
            rdr.Close();
            con.Close();

            Transaction transaction = new Transaction()
            {
                cusid = reservation.cusid,
                type = string.Format("Room Reserved At KingsBury | Room no: " + roomno + " | Res. Date: " + reservation.cindate.ToShortDateString()),
                amount = paymentamount
            };

            transaction.update(transaction);



        }



        public bool cancelreservation(Reservations reservation)
        {

            conString = ConfigurationManager.ConnectionStrings["paymatecontext"].ConnectionString;
            SqlConnection con = new SqlConnection(conString);


            SqlCommand cmd = new SqlCommand("select * from reservation where id='" + reservation.resid + "'", con);
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            bool result = rdr.Read();

            if (result == true)
            {
                roomno = int.Parse(rdr[2].ToString());
                cindate = DateTime.Parse(rdr[3].ToString());
            }
            con.Close();

            rdr.Close();
            if (result == false)
            {
                return false;
            }

            else if (result == true)
            {

                con.Open();
                cmd = new SqlCommand("update reservation set status='" + reservation.rstatus + "' where id='" + reservation.resid + "'", con);
                cmd.ExecuteNonQuery();

                Transaction transaction = new Transaction()
                {
                    cusid = reservation.cusid,
                    type = string.Format($"Room reservation cancelled | Room no: {roomno} | Res date: {cindate}"),
                    amount = 0
                };

                transaction.update(transaction);
            }
            rdr.Close();

            con.Close();
            return true;
        }
    }
}