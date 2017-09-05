using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace test.Models
{
    public class Pay
    {
        public int  paymentno { get; set; }
        public double paymentamount { get; set; }
        public long debitcardno { get; set; }
        public string cusid { get; set; }
        public DateTime paydate { get; set; }

        public void confirmpay()
        { }


    }
}