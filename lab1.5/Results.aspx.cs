using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace isptina2012
{
    public partial class Results : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lbPredmeti.Items.Add(new ListItem("Internet Tehnologii", "Prof. d-r Goce Armenski"));
                lbPredmeti.Items.Add(new ListItem("Internet", "Prof. d-r Igor Mishkovski"));
                lbPredmeti.Items.Add(new ListItem("Digitalna Elektronika", "Prof. d-r Ivan Chorbev"));

                if (Session["counter1"] == null)
                {
                    Session["counter1"] = 0;
                }
                if (Session["counter2"] == null)
                {
                    Session["counter2"] = 0;
                }
                if (Session["counter3"] == null)
                {
                    Session["counter3"] = 0;
                }

                lbGlasovi.Items.Add(Session["counter1"].ToString());
                lbGlasovi.Items.Add(Session["counter2"].ToString());
                lbGlasovi.Items.Add(Session["counter3"].ToString());
            }
        }
    }
}