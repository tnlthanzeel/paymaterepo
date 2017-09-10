using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace test.Models
{
    public class BankAccount
    {
        public string cusid { get; set; }
        public long accno { get; set; }
        public double accbal { get; set; }
        string conString = "";

        public BankAccount viewbbal(string cusidd)
        {

            conString = ConfigurationManager.ConnectionStrings["paymatecontext"].ConnectionString;
            SqlConnection con = new SqlConnection(conString);


            SqlCommand cmd = new SqlCommand("select * from bankacc where dcusid='" + cusidd + "'", con);
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            BankAccount bankaccount = new BankAccount();
            if (rdr.Read())
            {


                bankaccount.accno = Convert.ToInt64(rdr[1]);
                bankaccount.accbal = Convert.ToInt64(rdr[2]);


            }

            con.Close();
            return bankaccount;

        }

        public void requestftransfer()
        { }

        public void verifypayment()
        { }

        public void transer()
        {

        }
    }
}