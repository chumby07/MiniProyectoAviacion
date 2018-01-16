using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    public class Vuelos
    {
        //Contexto de la conexion Linq
        ConexionLinqDataContext con = new ConexionLinqDataContext();

        //Metodo que recibe los parametros para el registro de los vuelos
        public int RegisterFlightModel(string departureDate, string departureTime, string returnDate, string returnTime, string idRoute, string idAirplane, string IdPilot, string flightName)
        {
            if (con.procInsertFlight(departureDate, departureTime, returnDate, returnTime, Convert.ToInt32(idRoute), Convert.ToInt32(idAirplane), Convert.ToInt32(IdPilot), flightName) == 0)
            {
                return 1;
            }
            else { return 0; }
        }

        //Metodo que consulta los vuelos registradas en la base de datos
        public object SelectFlightModel()
        {
            var Vuelos = from vue in con.GetTable<tblVuelo>()
                         where vue.CapacidadVuelo > 0
                         select new { vue.IdVuelo, vue.NombreVuelo };

            return Vuelos;
        }
    }
}
