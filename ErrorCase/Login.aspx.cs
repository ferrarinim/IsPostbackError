using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ErrorCase
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Debug.WriteLine($"IsPostBack = {IsPostBack}");
        } 

        protected void btn_Click(object sender, EventArgs e)
        {
            Debug.WriteLine($"btn_Click");
        }
    }
}