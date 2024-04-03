using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lab1
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
            lbPredmeti.Items.Add("Internet Tehnologii");
            lbPredmeti.Items.Add("Internet");
            lbPredmeti.Items.Add("Digitalna Elektronika");

            lbKrediti.Items.Add("6");
            lbKrediti.Items.Add("5.5");
            lbKrediti.Items.Add("5.5");
        }

        protected void lbPredmeti_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbProffesor.Text = LoadProffessorName(lbPredmeti.SelectedItem.Text);
        }

        private string LoadProffessorName(string subject)
        {
            if(subject == "Internet Tehnologii")
            {
                return "Prof. d-r Goce Armenski";
            }
            if (subject == "Internet")
            {
                return "Prof. d-r Igor Miskovski";
            }
            if (subject == "Digitalna Elektronika")
            {
                return "Prof. d-r Ivan Chorbev";
            }else
            {
                return "";
            }
        }

        protected void glasajte_Click(object sender, EventArgs e)
        {
          //  Response.Redirect($"UspesnoGlasanje.aspx?email={Session["UserEmail"]}");
          Response.Redirect("UspesnoGlasanje.aspx");
        }

        protected void add_Click(object sender, EventArgs e)
        {
            lbPredmeti.Items.Add(subject.Text);
            lbKrediti.Items.Add(credits.Text);
        }

        protected void remove_Click(object sender, EventArgs e)
        {
            if(lbPredmeti.SelectedIndex != -1)
            {
                lbKrediti.Items.RemoveAt(lbPredmeti.SelectedIndex);
                lbPredmeti.Items.RemoveAt(lbPredmeti.SelectedIndex);
            }
        }
    }
}
