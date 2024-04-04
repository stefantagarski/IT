using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace isptina2012
{
    public partial class UspesnoGlasanje : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                HttpCookie nameCookie = Request.Cookies["name"];

                if(nameCookie != null && nameCookie.Value == Session["name"].ToString())
                {
                    Message.Text = Session["name"].ToString() + ", веќе учествувавте во гласањето. Секoј кoрисник има правo да гласа самo еднаш. Ви благoдариме!";
                    
                } 
                else
                {
                    HttpCookie cookie = new HttpCookie("name", Session["name"].ToString());
                    cookie.Expires = DateTime.Now.AddHours(1);
                    Response.Cookies.Add(cookie);

                    Message.Text = Session["name"].ToString() + " , Ви благодариме за учеството во акцијата за избор на најинтересен предмет на ФИНКИ. Вашиот избор беше " + Session["subject"].ToString() + ". Резултатите од гласањето ќе ги добиете на електронска пошта, на " + Session["email"].ToString() + ".";
                }

            }
        }

        protected void resuts_Click(object sender, EventArgs e)
        {
            Response.Redirect("Results.aspx");
        }
    }
}