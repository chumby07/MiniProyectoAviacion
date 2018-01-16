using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CONTROLLER;

namespace VIEW
{
    public partial class Admin : System.Web.UI.MasterPage
    {

        //En el evento page_load del master Admin valido la variable de session
        //Si no es el usuario para la pagina lo redirijo al login
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Session["Usuario"].ToString() != "")
                {
                    if (Session["Usuario"].ToString() != "admin")
                    {
                        Response.Redirect("Login.aspx");
                    }
                    else { relAdmin.Value = Session["Usuario"].ToString(); }
                }
            }
            catch (Exception)
            {
                Response.Redirect("Login.aspx");
            }

            //objController.SelectPilotController();

        }

        protected void On_Click(object sender, EventArgs e)
        {
            //Evento click para cerrar sesion en la vista de administrador
            Session.Abandon();
            Response.Redirect("Login.aspx");
        }
    }
}