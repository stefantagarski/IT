using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;
using Newtonsoft.Json.Linq;

namespace isptina2012
{
    public partial class UspesnoGlasanje : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                string sessionName = Session["name"].ToString();
                string sessionSubject = Session["subject"].ToString();
                string sessionEmail = Session["email"].ToString();
                Message.Text =  sessionName + " , Ви благoдариме за учествoтo вo акцијата за избoр на најинтересен предмет на ФИНКИ. Вашиoт избoр беше " + sessionSubject + ". Резултатите oд гласањето ќе ги добиете на електрoнска пошта, на " + sessionEmail;        
            }
        }

    }
}