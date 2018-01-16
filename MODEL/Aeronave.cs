using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    public class Aeronave
    {
        //Contexto de la conexion Linq
        ConexionLinqDataContext con = new ConexionLinqDataContext();

        //Metodo que recibe los parametros para el registro de las Aeronaves
        public int RegisterAirplaneModel(string model, string unity, string capacityPass, string capacityWe, string autonomy)
        {
            if (con.procInsertAirplane(model, Convert.ToInt32(unity), Convert.ToInt32(capacityPass), capacityWe, Convert.ToInt32(autonomy)) == 0)
            {
                return 1;
            }
            else { return 0; }
        }

        //Metodo que consulta las Aeronaves registradas en la base de datos
        public object SelectAirplaneModel()
        {
            object reslt = from Airplane in con.GetTable<tblAeronave>()
                           select new { Airplane.Modelo, Airplane.IdAeronave };

            return reslt;
        }
    }
}
