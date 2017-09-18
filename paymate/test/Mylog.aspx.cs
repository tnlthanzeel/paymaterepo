using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using test.Models;

namespace test
{
    public partial class Mylog : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Session["cusid"] as string))
                Response.Redirect("login.aspx");

            else
            {
                dateerror.Visible = false;
                nodata.Visible = false;
            }

        }

        protected void processlog_Click(object sender, EventArgs e)
        {
            try
            {
                nodata.Visible = false;
                dateerror.Visible = false;

                Customer customer = new Customer();
                Transaction transactdate = new Transaction()
                {
                    fromdate = Convert.ToDateTime(fromdate.Value),
                    todate = Convert.ToDateTime(todate.Value)
                };
                var dt = customer.viewTranslog(Session["cusid"].ToString(), transactdate);
                logtable.DataSource = dt;
                logtable.DataBind();

                if (dt.Rows.Count != 0)
                    logtable.Visible = true;

                else
                    nodata.Visible = true;



            }

            catch (Exception)
            {
                dateerror.Visible = true;
            }
        }
    }
}