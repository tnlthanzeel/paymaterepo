using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.Reporting.WebForms;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace test
{
    public partial class ReservationReport : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void genresreport_Click(object sender, EventArgs e)
        {
            
            showreport();
        }

        private void showreport()
        {
            try
            {
                rptviewer.Reset();

                DataTable dt = getdata(DateTime.Parse(fromdate.Value).Date, DateTime.Parse(todate.Value).Date);

                ReportDataSource rds = new ReportDataSource("DataSet1", dt);

                rptviewer.LocalReport.DataSources.Add(rds);

                rptviewer.LocalReport.ReportPath = "ReservationResport.rdlc";

                ReportParameter[] rptparams = new ReportParameter[]
                {

                new ReportParameter("fromdate",fromdate.Value),
                new ReportParameter("todate",todate.Value)

                };


                rptviewer.LocalReport.SetParameters(rptparams);
                rptviewer.LocalReport.Refresh();

            }


            catch(Exception)
            {
                Response.Redirect("ReservationReport.aspx");
            }
        }



        private DataTable getdata(DateTime fromdate, DateTime todate)
        {
            DataTable dt = new DataTable();

            string conString = ConfigurationManager.ConnectionStrings["paymatecontext"].ConnectionString;

            using (SqlConnection con = new SqlConnection(conString))
            {
                SqlCommand cmd = new SqlCommand("spGetReservation", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Fromdate", SqlDbType.DateTime).Value = fromdate.Date;
                cmd.Parameters.Add("@Todate", SqlDbType.DateTime).Value = todate.Date;

                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(dt);
            }
            return dt;
        }
    }
}