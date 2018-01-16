using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CONTROLLER;

namespace VIEW
{
    public partial class HijaCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Controller objController = new Controller();

            object vuelo = objController.SelectFlightController();

            DdLVuelo.DataSource = vuelo;
            DdLVuelo.DataTextField = "NombreVuelo";
            DdLVuelo.DataValueField = "IdVuelo";
            DdLVuelo.DataBind();
        }

        protected void btnReserveFlight_Click(object sender, EventArgs e)
        {

        }
    }
}