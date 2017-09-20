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


        public void confirmpay(string cusidd, int roomno)
        {
            cusid = cusidd;

            SqlCommand cmd = new SqlCommand();
            conString = ConfigurationManager.ConnectionStrings["paymatecontext"].ConnectionString;
            SqlConnection con = new SqlConnection(conString);

            cmd = new SqlCommand("select * from bankacc where dcusid='" + cusidd + "'", con);
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            rdr.Read();
            int bankamm = Convert.ToInt32(rdr[3].ToString());
            rdr.Close();
            cmd = new SqlCommand("select * from room where droomno='" + roomno + "'", con);
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


    }
}