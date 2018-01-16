using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    public class Cliente
    {
        //Contexto de la conexion linq
        ConexionLinqDataContext objConexion = new ConexionLinqDataContext();
        public string r;

        //Metodo que recibe los parametros para registrar un nuevo usuario
        public int RegisterClientModel(string name, string identification, string username, string password, string rol)
        {
            //con el objeto de la conexion llamo el procedimineto almacenado que registra el nuevo usuario
            //y retorno un valor numérico para validar si registra o no
            if (objConexion.procInserClient(identification, password, username, name, rol) == 0){
                return 1;
            }
            else { return 0; }
        }

        //Metodo Login que recibe los parametros para validar el inicio de sesion
        //y retorno el rol del usuario si exsite.
        public int LoginModel(string user, string pass)
        {
            
            int re;
            var resut = from usu in objConexion.GetTable<tblUsuario>()
                        where (usu.Users == user && usu.Pass == pass)
                        select usu;

            foreach (tblUsuario tblC in resut) {
               r = tblC.Rol;
            }

            return re = Convert.ToInt32(r);
            
        }


        public string SelectPersons()
        {
            string name;
            var reslt = from us in objConexion.GetTable<tblUsuario>()
                        select us;

            foreach (tblUsuario tblC in reslt)
            {
                r = tblC.Nombre;
            }

            return name = Convert.ToString(r);
        }
    }
}
