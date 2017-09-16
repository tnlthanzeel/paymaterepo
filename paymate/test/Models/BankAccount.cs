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


                bankaccount.accno = Convert.ToInt64(rdr[2]);
                bankaccount.accbal = Convert.ToInt64(rdr[3]);


            }

            con.Close();
            return bankaccount;

        }

        public int requestftransfer(string cusid, string ammount)
        {
            int result = 0;
            conString = ConfigurationManager.ConnectionStrings["paymatecontext"].ConnectionString;
            SqlConnection con = new SqlConnection(conString);


            SqlCommand cmd = new SqlCommand("select * from bankacc where dcusid='" + cusid + "'", con);
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();


            rdr.Read();

            if (Convert.ToInt32(ammount) < Convert.ToInt32(rdr[3].ToString()))
                result = 1;



            else
                result = 0;


            con.Close();
            return result;
        }

        public void verifypayment()
        { }

        public void transfer(string cusid, string ammount, string accno)
        {
            int transferfrom = 0, transferto = 0;
            SqlCommand cmd = new SqlCommand();
            conString = ConfigurationManager.ConnectionStrings["paymatecontext"].ConnectionString;
            SqlConnection con = new SqlConnection(conString);



            cmd = new SqlCommand("select * from bankacc where dcusid='" + cusid + "'", con);
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();

            rdr.Read();
            transferfrom = Convert.ToInt32(rdr[3].ToString()) - Convert.ToInt32(ammount.ToString());
            rdr.Close();
            cmd = new SqlCommand("update bankacc set daccbal='" + transferfrom + "' where dcusid='" + cusid + "'", con);
            cmd.ExecuteNonQuery();


            cmd = new SqlCommand("select * from bankacc where daccno='" + Convert.ToInt32(accno) + "'", con);
            rdr = cmd.ExecuteReader();

            rdr.Read();

            transferto = Convert.ToInt32(rdr[3].ToString()) + Convert.ToInt32(ammount.ToString());
            cmd = new SqlCommand("update bankacc set daccbal='" + transferto + "' where daccno='" + Convert.ToInt32(accno) + "'", con);
            rdr.Close();
            cmd.ExecuteNonQuery();



            con.Close();




        }
    }
}