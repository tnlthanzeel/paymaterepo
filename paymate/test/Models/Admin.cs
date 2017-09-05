using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace test.Models
{
    public class Admin
    {
        public string  adminId { get; set; }
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

        public bool login()
        {
            return true;
        }

        public   void   viewcusdetail()
        {

        }

        public void viewuser()
        { }

        public void buser()
        { }

        public void ubluser()
        { }

        public void viewblist()
        { }


        public void addservices()
        {}

        public void removeservices()
        { }


    }
}