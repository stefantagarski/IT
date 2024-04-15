using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace isptina2012
{
    public partial class Glasaj : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        protected void lbProfesori_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lbProfesori.SelectedValue == "GA")
            {
                lbPredmeti.Items.Clear();
                lbPredmeti.Items.Add("IPNKS");
                lbPredmeti.Items.Add("IT");
            }
            if (lbProfesori.SelectedValue == "IM")
            {
                lbPredmeti.Items.Clear();
                lbPredmeti.Items.Add("KMiB");
                lbPredmeti.Items.Add("OS");
            }
            if (lbProfesori.SelectedValue == "IC")
            {
                lbPredmeti.Items.Clear();
                lbPredmeti.Items.Add("OOP");
                lbPredmeti.Items.Add("ONVD");
            }
        }

        protected void glasajte_Click(object sender, EventArgs e)
        {
            Session["subject"] = lbPredmeti.SelectedItem.Text;
            Response.Redirect("UspesnoGlasanje.aspx");
        }
    }
}