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
            if(!IsPostBack)
            {
                LoadInitialData();
            }
        }

        protected void LoadInitialData()
        {
            lbPredmeti.Items.Add(new ListItem("Internet Tehnologii", "Prof. d-r Goce Armenski"));
            lbPredmeti.Items.Add(new ListItem("Internet", "Prof. d-r Igor Mishkovski"));
            lbPredmeti.Items.Add(new ListItem("Digitalna Elektronika", "Prof. d-r Ivan Chorbev"));

            lbKrediti.Items.Add("6");
            lbKrediti.Items.Add("5.5");
            lbKrediti.Items.Add("5.5");
        }

        protected void lbPredmeti_SelectedIndexChanged(object sender, EventArgs e)
        {

            lbKrediti.SelectedIndex = lbPredmeti.SelectedIndex;

            
            if (lbPredmeti.SelectedIndex == 0)
            {
                lbProffesor.Text = lbPredmeti.SelectedValue.ToString();
                
            }
            else if (lbPredmeti.SelectedIndex == 1)
            {
                lbProffesor.Text = lbPredmeti.SelectedValue.ToString();
                
            }
            else if (lbPredmeti.SelectedIndex == 2)
            {
                lbProffesor.Text = lbPredmeti.SelectedValue.ToString();
                
            }
        }

        protected void glasajte_Click(object sender, EventArgs e)
        {

            if(lbPredmeti.SelectedIndex == 0)
            {
                if (Session["counter1"] == null)
                {
                    Session["counter1"] = 0;
                }

                int counter1 = (int)Session["counter1"] + 1;
                Session["counter1"] = counter1;
            }
            else if (lbPredmeti.SelectedIndex == 1)
            {
                if (Session["counter2"] == null)
                {
                    Session["counter2"] = 0;
                }

                int counter2 = (int)Session["counter2"] + 1;
                Session["counter2"] = counter2;
            }
            else if (lbPredmeti.SelectedIndex == 2)
            {
                if (Session["counter3"] == null)
                {
                    Session["counter3"] = 0;
                }

                int counter3 = (int)Session["counter3"] + 1;
                Session["counter3"] = counter3;
            }


            Session["subject"] = lbPredmeti.SelectedItem.Text;
            Response.Redirect("UspesnoGlasanje.aspx");
        }
    }
}