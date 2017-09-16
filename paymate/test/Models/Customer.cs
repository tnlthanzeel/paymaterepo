using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace test.Models
{
    public class Customer
    {
        public string CusId { get; set; }
        public string CusPwd { get; set; }
        public int CusBlockStat { get; set; }
        public string CusName { get; set; }
        public string CusNic { get; set; }
        public string CusPhone { get; set; }
        public string CusAddress { get; set; }
        public string CardType { get; set; }
        public string CardNumber { get; set; }
        public string conString = "";

        public int cregister(Customer newcustomer)
        {
            conString = ConfigurationManager.ConnectionStrings["paymatecontext"].ConnectionString;
            SqlConnection con = new SqlConnection(conString);


            SqlCommand cmd = new SqlCommand("select * from customer where dcusid='" + newcustomer.CusId + "'", con);
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            bool useremailexists = rdr.Read();
            con.Close();

            if (useremailexists == false)
            {
                cmd = new SqlCommand("insert into customer values('" + newcustomer.CusId + "','" + newcustomer.CusPwd + "', 2 ,'" + newcustomer.CusBlockStat + "','" + newcustomer.CusName + "','" + newcustomer.CusNic + "','" + newcustomer.CusPhone + "','" + newcustomer.CusAddress + "','" + newcustomer.CardType + "','" + newcustomer.CardNumber + "')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                return 0;// 0 means for register success 
            }

            else
                return 1; // 1 means email address is already in use, so not registered 

        }


        public bool clogin()
        {
            return true;
        }


        public void pay()
        { }

        public BankAccount viewBbal(string cusid)
        {
            BankAccount bankaccount = new BankAccount();
            return bankaccount.viewbbal(cusid);

        }

        public void fundtransfer()
        { }


        public void viewhotel()
        { }

        public void reserveroom()
        {

        }


        public void cancelreservation()
        { }


        public void pbill()
        {

        }

        public void cbill()
        { }

        public void wbill()
        { }

        public void insurance()
        { }

        public DataTable viewTranslog(string cusid)
        {

            conString = ConfigurationManager.ConnectionStrings["paymatecontext"].ConnectionString;
            SqlConnection con = new SqlConnection(conString);

            con.Open();
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable td = new DataTable();
            ad.Fill(td);
            con.Close();
            cmd.Dispose();
            ad.Dispose();
            return td;


        }
    }
}