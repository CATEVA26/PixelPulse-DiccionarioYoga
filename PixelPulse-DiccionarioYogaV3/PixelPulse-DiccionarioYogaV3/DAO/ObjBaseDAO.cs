using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixelPulse_DiccionarioYogaV3.DAO
{
    public abstract class ObjBaseDAO
    {
        public static string cadenaConexion = "server=localhost;port=3306;database=diccionarioasanas;user id=root;password=;";
        public static void Insertar(Object obj)
        {

        }
        public static void Eliminar(Object obj)
        {

        }
        public static Object BuscarBySans(Object obj)
        {
            return null;
        }
    }
}
