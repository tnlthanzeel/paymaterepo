﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace test
{
    public partial class Adminview : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            loggedinas.Text = Session["loggedinas"].ToString();
        }

        protected void loaddetails_Click(object sender, EventArgs e)
        {
            Response.Write("loading table");
        }
    }
}