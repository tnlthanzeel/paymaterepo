using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace test.Models
{
    public class Telephone
    {

        public long tnumber { get; set; }
        public double billamount { get; set; }

        string conString = "";


        public Telephone viewtbill(Customer customer)
        {
            conString = ConfigurationManager.ConnectionStrings["paymatecontext"].ConnectionString;
            SqlConnection con = new SqlConnection(conString);


            SqlCommand cmd = new SqlCommand("select * from phonebill where dcusid='" + customer.CusId + "'", con);
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            Telephone telephone = new Telephone();
            if (rdr.Read())
            {
                telephone.tnumber = Convert.ToInt64(rdr[2]);
                telephone.billamount = Convert.ToInt64(rdr[3]);
            }

            con.Close();
            return telephone;

        }



        public bool requesttpay(int paymentammount)
        {
            return paymentammount < 0 ? true : false;

        }
    }
}