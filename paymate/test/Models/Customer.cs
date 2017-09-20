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

        public int fundtransfer(string accountno)
        {

            conString = ConfigurationManager.ConnectionStrings["paymatecontext"].ConnectionString;
            SqlConnection con = new SqlConnection(conString);


            SqlCommand cmd = new SqlCommand("select * from bankacc where daccno='" + Convert.ToInt32(accountno) + "'", con);
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            bool accountexists = rdr.Read();
            con.Close();


            if (accountexists == true)
                return 1;


            else
                return 0;




        }


        public DataTable viewhotel()
        {

            conString = ConfigurationManager.ConnectionStrings["paymatecontext"].ConnectionString;
            SqlConnection con = new SqlConnection(conString);

            SqlCommand cmd = new SqlCommand("select droomno,dprice,droomtype from room", con);
            con.Open();
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable td = new DataTable();
            ad.Fill(td);
            con.Close();
            cmd.Dispose();
            ad.Dispose();
            return td;




        }

        public int reserveroom(Reservations reservation)
        {
            int isreserved = 0;

            conString = ConfigurationManager.ConnectionStrings["paymatecontext"].ConnectionString;
            SqlConnection con = new SqlConnection(conString);

            var reservedate = reservation.cindate.ToShortDateString();

            SqlCommand cmd = new SqlCommand("select * from reservation where date='" + reservedate + "' and droomno='" + reservation.roomno + "' and status=0", con);//if status 0, meand room already booked, else if status is one room available
            con.Open();
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable td = new DataTable();
            ad.Fill(td);
            con.Close();
            cmd.Dispose();
            ad.Dispose();

            return isreserved = td.Rows.Count == 0 ? 0 : 1;
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

        public DataTable viewTranslog(string cusid, Transaction transactdate)
        {

            conString = ConfigurationManager.ConnectionStrings["paymatecontext"].ConnectionString;
            SqlConnection con = new SqlConnection(conString);

            SqlCommand cmd = new SqlCommand("select * from log where dcusis='" + cusid + "' and date >= '" + transactdate.fromdate + "' and date <=  '" + transactdate.todate.AddDays(1) + "'", con);
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