using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CONTROLLER;

namespace VIEW
{
    public partial class PadreCliente : System.Web.UI.MasterPage
    {
        Controller objController = new Controller();
        //En el evento page_load del master cliente valido la variable de session
        //Si no es el usuario para la pagina lo redirijo al login
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Session["Usuario"].ToString() != "")
                {
                    if (Session["Usuario"].ToString() != "cliente")
                    {
                        Response.Redirect("Login.aspx");
                    }
                    else {
                        rolCliente.Value = Session["Usuario"].ToString();
                        lblUsuario.Text = "Bienvenido " + Session["Nombre"].ToString();
                    }
                }
            }
            catch (Exception)
            {
                Response.Redirect("Login.aspx");
            }

        }

        //Evento onclick para cerrar sesion en la vista de usuario - cliente
        protected void On_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("Login.aspx");
        }
    }
}