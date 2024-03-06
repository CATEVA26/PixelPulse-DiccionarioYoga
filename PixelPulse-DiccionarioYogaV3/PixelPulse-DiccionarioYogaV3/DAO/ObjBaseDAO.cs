using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixelPulse_DiccionarioYogaV3.DAO
{
    // Clase base abstracta para los objetos DAO
    public abstract class ObjBaseDAO
    {
        // Cadena de conexión a la base de datos
        public static string cadenaConexion = "server=localhost;port=3306;database=diccionarioasanas;user id=root;password=;";

        // Método abstracto para insertar objetos en la base de datos
        public static void Insertar(Object obj){ }

        // Método abstracto para insertar objetos en la base de datos
        public static void Eliminar(Object obj){ }
    }
}
