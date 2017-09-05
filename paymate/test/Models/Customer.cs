using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace test.Models
{
    public class Customer
    {
        public string CusId { get; set; }
        public string  CusPwd { get; set; }
        public int CusBlockStat { get; set; }
        public string CusName { get; set; }
        public string CusNic { get; set; }
        public string CusPhone { get; set; }
        public string CusAddress { get; set; }
        public string CardType { get; set; }
        public long CardNumber { get; set; }


        public void cregister()
        {

        }


        public bool clogin()
        {
            return true;
        }


        public void pay()
        { }

        public void viewBbal()
        { }

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

        public void viewTranslog()
        { }
    }
}