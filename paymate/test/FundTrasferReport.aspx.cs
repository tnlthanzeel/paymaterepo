using Microsoft.Reporting.WebForms;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace test
{
    public partial class FundTrasferReport : System.Web.UI.Page
    {
        string uname;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Session["cusid"].ToString()))
                uname = Session["cusid"].ToString();

            else
                Response.Redirect("login.aspx");
        }

        protected void genfundtransferrep_Click(object sender, EventArgs e)
        {
            showreport();
        }

        private void showreport()
        {
            try
            {
                fundtrasnferreport.Reset();

                DataTable dt = getdata(DateTime.Parse(fromdate.Value).Date, DateTime.Parse(todate.Value).Date, uname);

                ReportDataSource rds = new ReportDataSource("DataSet1", dt);

                fundtrasnferreport.LocalReport.DataSources.Add(rds);

                fundtrasnferreport.LocalReport.ReportPath = "Fundtransferreport.rdlc";

                ReportParameter[] rptparams = new ReportParameter[]
                {

                new ReportParameter("fromdate",fromdate.Value),
                new ReportParameter("todate",todate.Value),
                new ReportParameter("cusid",uname)

                };


                fundtrasnferreport.LocalReport.SetParameters(rptparams);
                fundtrasnferreport.LocalReport.Refresh();

            }


            catch (Exception)
            {
                Response.Redirect("FundTrasferReport.aspx");
            }
        }



        private DataTable getdata(DateTime fromdate, DateTime todate, string uname)
        {
            DataTable dt = new DataTable();

            string conString = ConfigurationManager.ConnectionStrings["paymatecontext"].ConnectionString;

            using (SqlConnection con = new SqlConnection(conString))
            {
                SqlCommand cmd = new SqlCommand("spGetFundTransfer", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@fromdate", SqlDbType.DateTime).Value = fromdate.Date;
                cmd.Parameters.Add("@todate", SqlDbType.DateTime).Value = todate.Date;
                cmd.Parameters.Add("@cusid", SqlDbType.VarChar).Value = uname;

                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(dt);
            }
            return dt;
        }
    }
}