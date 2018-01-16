using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    public class Trayecto
    {
        //Contexto de la conexion Linq
        ConexionLinqDataContext con = new ConexionLinqDataContext();

        //Metodo que recibe los parametros para el registro de los trayectos
        public int RegisterRouteModel(string code, string origin, string destination, string price, string flightTime, string miles)
        {
            if (con.procInsertRoute(code, origin, destination, price, flightTime, miles) == 0)
            {
                return 1;
            }
            else { return 0; }
        }

        //Metodo que consulta los trayectos registradas en la base de datos
        public object SelectRouteModel()
        {
            object reslt = from route in con.GetTable<tblTrayecto>()
                           select new { route.Codigo, route.IdTrayecto };

            return reslt;
        }
    }
}
