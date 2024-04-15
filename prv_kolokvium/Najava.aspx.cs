using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace isptina2012
{
    public partial class Najava : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submit_Click(object sender, EventArgs e)
        {
            if(Page.IsValid)
            {
                Session["name"] = name.Text;
                Session["email"] = email.Text;
                Response.Redirect("Glasaj.aspx");
            }
        }
    }
}