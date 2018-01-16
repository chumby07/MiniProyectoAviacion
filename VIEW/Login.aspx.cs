using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CONTROLLER;

namespace VIEW
{
    public partial class Login : System.Web.UI.Page
    {
        //Instancia del objeto de la clase controller
        Controller objController = new Controller();
        public int confirmar;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //Evento del boton registrar, que envia los parametros al controlador para realizar el registro
        //y este recibe un parametro que retorna el controlador para verificar el registro
        protected void register_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtIdentificacion.Text == "" || txtUserName.Text == "" || txtPassword.Text == "" || txtRol.Text == ""){

                Response.Write("<script>alert('Registro fallido debe llenar todos los campos');</script>");

            }
            else if ((confirmar = objController.RegisterUserController(txtName.Text, txtIdentificacion.Text, txtUserName.Text, txtPassword.Text, txtRol.Text)) == 1){
                    Response.Write("<script>alert('Registro Exitoso');</script>");
            }
            
            else { Response.Write("<script>alert('Registro Fallido');</script>"); }
            
        }

        //Evento del boton Login, que envia los parametros usuario y contraseña al controlador
        protected void login_Click1(object sender, EventArgs e)
        {
            confirmar = objController.LoginController(username.Text, password.Text);

            //En este sentencia anidada de if valido que tipo de usuario se logueo y lo envio a la pagina 
            //correspondiente a su rol y creo la variable de sesion correspondiente

            switch (confirmar)
            {
                case 1:
                    Session["Usuario"] = "admin";
                    Response.Redirect("HijaAdmin.aspx");
                break;

                case 2:
                    Session["Usuario"] = "cliente";
                    Session["Nombre"] = username.Text;
                    Response.Redirect("HijaCliente.aspx");
                break;

                case 0:
                    Response.Write("<script>alert('No Exitoso');</script>");
                    Response.Redirect("Login.aspx");
                break;

                default:
                break;
            }

            /*if (confirmar == 1){
                
            }
            else if (confirmar == 2){
                
            }
            else {
                
            }*/
        }
    }
}