using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODEL;

namespace CONTROLLER
{
    public class Controller
    {
        //Intacias de los objetos de la capa modelo
        Cliente objCliente = new Cliente();
        Piloto objPiloto = new Piloto();
        Aeronave objAeronave = new Aeronave();
        Trayecto objTrayecto = new Trayecto();
        Vuelos objVuelo = new Vuelos();

        //Variable global para validar el registro de los formularios
        public int reg;

        //Variable global para validar el login
        private int rol;

        //Metodo que recibe los parametros que se envia desde la vista, para registrar un nuevo usuario
        public int RegisterUserController(string name, string identification, string username, string password, string rol)
        {
            //Con este objeto llamo el metodo RegisterCleitne de la clase cliente para registrar 
            //un nuevo cliente y recibo un para que retorna para validar si registro.
            reg = objCliente.RegisterClientModel(name, identification, username, password, rol);
            return reg;
        }

        //Metodo que recibe los parametros para registrar un nuevo piloto
        //y se los envia al modelo
        public int RegisterPilotController(string name, string identification)
        {
            reg = objPiloto.RegisterPilotModel(name, identification);
            return reg;
        }

        //Metodo que recibe los parametros para registrar una nueva aeronave
        //y se los envia al modelo
        public int RegisterAirplaneController(string model, string unity, string capacityPass, string capacityWe, string autonomy)
        {
            reg = objAeronave.RegisterAirplaneModel(model, unity, capacityPass, capacityWe, autonomy);
            return reg;
        }

        //Metodo que recibe los parametros para registrar una nueva ruta o trayecto
        //y se los envia al modelo
        public int RegisterRouteController(string code, string origin, string destination, string price, string flightTime, string miles)
        {
            reg = objTrayecto.RegisterRouteModel(code, origin, destination, price, flightTime, miles);
            return reg;
        }

        //Metodo que recibe los parametros para registrar un nuevo vuelo
        //y se los envia al modelo
        public int ReGisterFlightController(string departureDate, string departureTime, string returnDate, string returnTime, string idRoute, string idAirplane, string IdPilot, string flightName)
        {
            reg = objVuelo.RegisterFlightModel(departureDate, departureTime, returnDate, returnTime, idRoute, idAirplane, IdPilot, flightName);
            return reg;
        }

        //Metodo que recibe los parametros que se envian desde la vista para validar el inicio de sesion
        public int LoginController(string user, string pass)
        {

            rol = objCliente.LoginModel(user, pass);
            if (rol == 1){
                return 1;
            }
            else if (rol == 2){
                return 2;
            }
            else { return 0; }

        }

        //Metodo que llama al metodo SelectFlightModel que le devuelve 
        //los vuelos registrados en la base de datos
        public object SelectFlightController()
        {
            object rest = objVuelo.SelectFlightModel();

            return rest;
        }

        //Metodo que llama al metodo SelectPilotModel que le devuelve 
        //los Pilotos registrados en la base de datos
        public object SelectPilotController()
        {
            object resp = objPiloto.SelectPilotModel();
            return resp;
        }

        //Metodo que llama al metodo SelectAirplaneMode que le devuelve 
        //las Aeronaves registrados en la base de datos
        public object SelectAirplaneController()
        {
            object air = objAeronave.SelectAirplaneModel();
            return air;
        }

        //Metodo que llama al metodo SelectRouteModel que le devuelve 
        //los Tryectos registrados en la base de datos
        public object SelectRouteController()
        {
            object rou = objTrayecto.SelectRouteModel();
            return rou;
        }

        //Metodo que llama al metodo SelectPersons que le devuelve 
        //los Usuarios registrados en la base de datos
        public string SelectUsuarioController()
        {
            string name = objCliente.SelectPersons();
            return name;
        }
    }
}
