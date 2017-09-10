using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace test.Models
{
    public class Admin
    {
        public string adminId { get; set; }
        public string adminpasswrod { get; set; }
        public string cusid { get; set; }
        public int bstate { get; set; }
        public string cuslname { get; set; }
        public string cusemail { get; set; }
        public string cusaddress { get; set; }
        public long cusphone { get; set; }
        public string debitcardtype { get; set; }
        public string debitcardno { get; set; }
        public string cusin { get; set; }
        public string conString = "";

        public bool login()
        {
            return true;
        }

        public DataTable viewcusdetail()
        {
            conString = System.Configuration.ConfigurationManager.ConnectionStrings["paymatecontext"].ConnectionString;
            SqlConnection con = new SqlConnection(conString);


            SqlCommand cmd = new SqlCommand("select * from customer where duserrole=2", con);
            con.Open();
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable td = new DataTable();

            ad.Fill(td);
            con.Close();
            return td;
        }

        public DataTable viewuser(string cusid)
        {
            conString = System.Configuration.ConfigurationManager.ConnectionStrings["paymatecontext"].ConnectionString;
            SqlConnection con = new SqlConnection(conString);


            SqlCommand cmd = new SqlCommand("select * from customer where dcusid='" + cusid + "'", con);
            con.Open();
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable td = new DataTable();

            ad.Fill(td);
            con.Close();
            cmd.Dispose();
            ad.Dispose();
            return td;



        }

        public DataTable buser(string cusid)
        {
            conString = System.Configuration.ConfigurationManager.ConnectionStrings["paymatecontext"].ConnectionString;
            SqlConnection con = new SqlConnection(conString);


            SqlCommand cmd = new SqlCommand("update customer set dcusblockstat=1 where dcusid='" + cusid + "'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            cmd = new SqlCommand("select * from customer where dcusid='" + cusid + "'", con);
            con.Open();
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable td = new DataTable();

            ad.Fill(td);
            con.Close();
            cmd.Dispose();
            ad.Dispose();
            return td;


        }

        public DataTable ubluser(string cusid)
        {
            conString = System.Configuration.ConfigurationManager.ConnectionStrings["paymatecontext"].ConnectionString;
            SqlConnection con = new SqlConnection(conString);


            SqlCommand cmd = new SqlCommand("update customer set dcusblockstat=0 where dcusid='" + cusid + "'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            cmd = new SqlCommand("select * from customer where dcusid='" + cusid + "'", con);
            con.Open();
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable td = new DataTable();

            ad.Fill(td);
            con.Close();
            cmd.Dispose();
            ad.Dispose();
            return td;


        }

        public void viewblist()
        { }


        public void addservices()
        { }

        public void removeservices()
        { }


    }
}