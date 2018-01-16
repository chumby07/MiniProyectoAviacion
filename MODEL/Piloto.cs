using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    public class Piloto
    {
        //Objeto de conexion
        ConexionLinqDataContext con = new ConexionLinqDataContext();

        //Metodo que recibe los parametros para el registro de los pilotos
        public int RegisterPilotModel(string name, string identification)
        {
            if (con.procInsertPilot(name, identification) == 0)
            {
                return 1;
            }
            else { return 0; }

        }

        //Metodo que consulta los pilotos registrados en la base de datos
        public object SelectPilotModel()
        {
            object reslt = from pilot in con.GetTable<tblPiloto>()
                           select new { pilot.Nombre, pilot.IdPiloto };

            return reslt;
        }
    }
}
