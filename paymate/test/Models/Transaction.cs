using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace test.Models
{
    public class Transaction
    {
        public int id { get; set; }
        public string type { get; set; }
        public string cusid { get; set; }
        public int amount { get; set; }
        public DateTime datetime { get; set; }
        public string conString = "";



        public void update(Transaction transaction)
        {
            conString = ConfigurationManager.ConnectionStrings["paymatecontext"].ConnectionString;
            SqlConnection con = new SqlConnection(conString);


            SqlCommand cmd = new SqlCommand("insert into log values('"+transaction.cusid+ "','" + transaction.type + "','" + transaction.amount + "','" + transaction.datetime + "')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

        }


    }
}