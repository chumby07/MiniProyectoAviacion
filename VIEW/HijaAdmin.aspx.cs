using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CONTROLLER;

namespace VIEW
{
    public partial class HijaAdmin : System.Web.UI.Page
    {
        //Objtedo de la clase controller para conectar con esta capa.
        Controller objController = new Controller();

        //Variable goblal que nos sirve para validar el regitro de los 
        //diferentes formularios
        public int confirmar;

        protected void Page_Load(object sender, EventArgs e)
        {
            //cargar los pilos para la lista del formulario de los vuelos
            object pilot = objController.SelectPilotController();

            DdLPilot.DataSource = pilot;
            DdLPilot.DataTextField = "Nombre";
            DdLPilot.DataValueField = "IdPiloto";
            DdLPilot.DataBind();

            //Cargar aeronaves para lista del formulario de los vuelos
            object airp = objController.SelectAirplaneController();

            DdLAeronave.DataSource = airp;
            DdLAeronave.DataTextField = "Modelo";
            DdLAeronave.DataValueField = "IdAeronave";
            DdLAeronave.DataBind();

            //cargar rutas para lsta del formulario de los vuelos
            object rou = objController.SelectRouteController();

            DdLTrayecto.DataSource = rou;
            DdLTrayecto.DataTextField = "Codigo";
            DdLTrayecto.DataValueField = "IdTrayecto";
            DdLTrayecto.DataBind();

        }

        //Evento click del boton registrar piloto que envia los parametros al metodo con la capa controller
        //y recibe el retorno para validar si el registro es exitoso
        protected void btnRegisterPilot_Click(object sender, EventArgs e)
        {
            if (txtNombrePiloto.Text == "" || txtIdentificacionPiloto.Text == "")
            {
                MessageRegisterInvalid();
            }
            else if ((confirmar = objController.RegisterPilotController(txtNombrePiloto.Text, txtIdentificacionPiloto.Text)) == 1)
            {
                Message(confirmar);
            }
            else { Message(confirmar); }
        }

        //Evento click del boton registrar Aeronave que envia los parametros al metodo con la capa controller
        //y recibe el retorno para validar si el registro es exitoso
        protected void btnRegisterAirplane_Click(object sender, EventArgs e)
        {
            if (txtModelo.Text == "" || txtCantidad.Text == "" || txtCapacidadPasajeros.Text == "" || txtCapcidadCarga.Text == "" || txtAutonomia.Text == "")
            {
                MessageRegisterInvalid();
            }
            else if ((confirmar = objController.RegisterAirplaneController(txtModelo.Text, txtCantidad.Text, txtCapacidadPasajeros.Text, txtCapcidadCarga.Text, txtAutonomia.Text)) == 1)
            {
                Message(confirmar);
            }
            else { Message(confirmar); }
        }

        //Evento click del boton registrar Trayectos que envia los parametros al metodo con la capa controller
        //y recibe el retorno para validar si el registro es exitoso
        protected void btnRegisterRoute_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "" || txtOrigen.Text == "" || txtDestino.Text == "" || txtPrecio.Text == "" || txtTiempo.Text == "" || txtMillas.Text == "")
            {
                MessageRegisterInvalid();
            }
            else if ((confirmar = objController.RegisterRouteController(txtCodigo.Text, txtOrigen.Text, txtDestino.Text, txtPrecio.Text, txtTiempo.Text, txtMillas.Text)) == 1)
            {
                Message(confirmar);
            }
            else { Message(confirmar); }
        }

        //Evento click del boton registrar Vuelos que envia los parametros al metodo con la capa controller
        //y recibe el retorno para validar si el registro es exitoso
        protected void btnRegisterVuelo_Click(object sender, EventArgs e)
        {
            if (txtFechaSalida.Text == "" || txtHoraSalida.Text == "" || DdLTrayecto.Text == "" || DdLAeronave.Text == "" || DdLPilot.Text == "" || txtNombreVuelo.Text == "")
            {
                MessageRegisterInvalid();
            }
            else if ((confirmar = objController.ReGisterFlightController(txtFechaSalida.Text, txtHoraSalida.Text, txtFechaRegreso.Text, txtHoraRegreso.Text, DdLTrayecto.Text, DdLAeronave.Text, DdLPilot.Text, txtNombreVuelo.Text)) == 1)
            {
                Message(confirmar);
            }
            else { Message(confirmar); }
        }

        //Metodo para imprimir el mensaje de validacion de registro
        protected void Message(int con)
        {
            if (con == 1)
            {
                Response.Write("<script>alert('Registro Exitoso');</script>");
                Response.Redirect("HijaAdmin.aspx");
            }
            else { Response.Write("<script>alert('Registro Fallido');</script>"); }
        }

        //Metodo que imprime un mensaje si no lleno los datos del formulario
        protected void MessageRegisterInvalid()
        {
                Response.Write("<script>alert('Registro fallido debe llenar todos los campos');</script>");
                Response.Redirect("HijaAdmin.aspx");
        }
    }
}