using MySqlConnector;
using PixelPulse_DiccionarioYogaV3.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixelPulse_DiccionarioYogaV3.DAO
{
    public class MorfemaDAO : ObjBaseDAO
    {
        public static object BuscarBySans(object obj)
        {
            int idPostura = (int)obj;
            List<Morfema> listaMorfemas = new List<Morfema>();
            string query = "SELECT * FROM morfema WHERE idPostura = @id";
            using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
            {
                conexion.Open();
                using (MySqlCommand comando = new MySqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@id", idPostura);
                    using (MySqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Morfema morfema = new Morfema();
                            morfema.IdMorfema = reader.GetInt32(0);
                            morfema.IdPostura = reader.GetInt32(1);
                            morfema.MorfemaSans = reader.GetString(2);
                            morfema.MorfemaEs = reader.GetString(3);
                            listaMorfemas.Add(morfema);
                        }
                    }
                }
            }
            return listaMorfemas;
        }

        public static void Eliminar(object obj)
        {
            throw new NotImplementedException();
        }

        public static void Insertar(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
