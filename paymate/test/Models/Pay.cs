using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace test.Models
{
    public class Pay
    {
        public int paymentno { get; set; }
        public int paymentamount { get; set; }
        public long debitcardno { get; set; }
        public string cusid { get; set; }
        public DateTime paydate { get; set; }
        string conString = "";


        public int? confirmpay(string cusidd, params int[] paymentfor)
        {
            int? amt = 0;
            cusid = cusidd;

            SqlCommand cmd = new SqlCommand();
            conString = ConfigurationManager.ConnectionStrings["paymatecontext"].ConnectionString;
            SqlConnection con = new SqlConnection(conString);

            if (paymentfor[1] == 1)
            {
                cmd = new SqlCommand("select * from bankacc where dcusid='" + cusidd + "'", con);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                rdr.Read();
                int bankamm = Convert.ToInt32(rdr[3].ToString());
                rdr.Close();
                cmd = new SqlCommand("select * from room where droomno='" + paymentfor[0] + "'", con);
                rdr = cmd.ExecuteReader();
                rdr.Read();
                paymentamount = Convert.ToInt32(rdr[2].ToString());
                string temproomtype = rdr[3].ToString();
                rdr.Close();


                int updateamm = bankamm - paymentamount;
                cmd = new SqlCommand("update bankacc set daccbal='" + updateamm + "' where dcusid='" + cusidd + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();

                Transaction transaction = new Transaction()
                {
                    cusid = cusid,
                    type = "Payment for hotel room",
                    amount = paymentamount
                };

                transaction.update(transaction);


            }

            else if (paymentfor[1] == 2)
            {

                cmd = new SqlCommand("select * from bankacc where dcusid='" + cusidd + "'", con);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                rdr.Read();
                int bankamm = Convert.ToInt32(rdr[3].ToString());
                rdr.Close();
                cmd = new SqlCommand("select * from phonebill where dcusid='" + cusidd + "'", con);
                rdr = cmd.ExecuteReader();
                rdr.Read();
                paymentamount = Convert.ToInt32(rdr[3].ToString());
                string temproomtype = rdr[3].ToString();
                rdr.Close();


                int updateamm = bankamm - paymentfor[0];
                cmd = new SqlCommand("update bankacc set daccbal='" + updateamm + "' where dcusid='" + cusidd + "'", con);
                cmd.ExecuteNonQuery();

                int newphonebillamount = paymentamount - paymentfor[0];
                amt = newphonebillamount;
                cmd = new SqlCommand("update phonebill set dbillamount='" + newphonebillamount + "' where dcusid='" + cusidd + "'", con);
                cmd.ExecuteNonQuery();





                con.Close();

                Transaction transaction = new Transaction()
                {
                    cusid = cusid,
                    type = "Payment for Phone Bill",
                    amount = paymentfor[0]
                };

                transaction.update(transaction);




            }

            return amt == 0 ? null : amt;
        }


    }
}