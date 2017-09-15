using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using test.Models;

namespace test
{
    public partial class Adminview : System.Web.UI.Page
    {
        Admin admin = new Admin();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Session["loggedinas"] as string))
            {
                loggedinas.Text = Session["loggedinas"].ToString();
                norecord.Visible = false;
                customerdetails.Visible = false;
                blocked.Visible = false;
                unblocked.Visible = false;

            }

            else
                Response.Redirect("login.aspx");


        }

        protected void loaddetails_Click(object sender, EventArgs e)
        {

            var dt = admin.viewcusdetail();
            customerdetails.DataSource = dt;
            customerdetails.DataBind();
            customerdetails.Visible = true;


        }

        protected void search_Click(object sender, EventArgs e)
        {

            var dt = admin.viewuser(cusidd.Text);


            if (dt.Rows.Count == 0)
            {
                norecord.Visible = true;
            }

            else
            {
                customerdetails.Visible = true;
                customerdetails.DataSource = dt;
                customerdetails.DataBind();
                dt.Dispose();

            }
        }

        protected void blockuser_Click(object sender, EventArgs e)
        {
            var dt = admin.buser(cusidd.Text);
            if (dt.Rows.Count == 0)
            {
                norecord.Visible = true;
            }

            else
            {

                customerdetails.Visible = true;
                customerdetails.DataSource = dt;
                customerdetails.DataBind();
                //customerdetails.HeaderRow.Cells[0].Text = "Customer ID";
                dt.Dispose();
                blocked.Visible = true;

            }

        }

        protected void unblockuser_Click(object sender, EventArgs e)
        {

            var dt = admin.ubluser(cusidd.Text);
            if (dt.Rows.Count == 0)
            {
                norecord.Visible = true;
            }

            else
            {
                customerdetails.Visible = true;
                customerdetails.DataSource = dt;
                customerdetails.DataBind();
                dt.Dispose();
                unblocked.Visible = true;
            }
        }

        protected void blockedusers_Click(object sender, EventArgs e)
        {
            var dt = admin.viewblist();
            if (dt.Rows.Count == 0)
            {
                norecord.Visible = true;
            }

            else
            {
                customerdetails.Visible = true;
                customerdetails.DataSource = dt;
                customerdetails.DataBind();
                dt.Dispose();

            }

        }


    }
}