using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lab1
{
    public partial class UspesnoGlasanje : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lastLabel.Text = "Резултатите од гласањето ќе ги добиете по електронска пошта, на Е-MAIL: stefan@tagarski.com";
            }
        }
    }
}