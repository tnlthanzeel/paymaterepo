using System;
using System.Configuration;
using System.Data.SqlClient;

namespace test
{
    public partial class login : System.Web.UI.Page
    {
        private string conString = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            conString = ConfigurationManager.ConnectionStrings["paymatecontext"].ConnectionString;
            loginerror.Visible = false;
            userblocked.Visible = false;
        }

        protected void btnlog_Click(object sender, EventArgs e)
        {
            string username = inputEmail.Value.ToString();
            string pwd = password.Value.ToString();

            
            SqlConnection con = new SqlConnection(conString);

            SqlCommand cmd = new SqlCommand("select * from customer where dcusid='"+username +"'",con);

            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            

            if (rdr.Read())
            {

                string uname= rdr[0].ToString();
                string upwd= rdr[1].ToString();
                int userrole = Convert.ToInt16(rdr[2]);
                int blockstat = Convert.ToInt16(rdr[3]);
                var cusname = rdr[4].ToString();

                Session["loggedinas"] = cusname;

                if (pwd.Equals(upwd) && username.Equals(uname) && userrole==1) // if userrole is 1, that user is an admin
                {

                    Response.Redirect("Adminview.aspx");

                }

                else if (pwd.Equals(upwd) && username.Equals(uname) && userrole == 2 && blockstat==0 ) //if userrole is 2, that user is an profile user, and if blockstat is 0 the customer is not blocked by the admin
                {

                    Response.Redirect("home.aspx");

                }

                else if (pwd.Equals(upwd) && username.Equals(uname) && userrole == 2 && blockstat == 1) //if userrole is 2, that user is an profile user, and if blockstat is 1 the customer is blocked by the admin
                {

                    userblocked.Visible = true;

                }


                else
                {
                    loginerror.Visible = true;

                    Dispose();
                    pwd = "";
                }

            }


            else
            {
                loginerror.Visible = true;

                Dispose();
                pwd = "";
            }

            con.Close();
            
        }
    }
}