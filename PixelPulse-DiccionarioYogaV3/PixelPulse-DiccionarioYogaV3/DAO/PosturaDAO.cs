using MySqlConnector;
using PixelPulse_DiccionarioYogaV3.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixelPulse_DiccionarioYogaV3.DAO
{
    public class PosturaDAO : ObjBaseDAO
    {
        // Método para eliminar una postura de la base de datos
        public static void Eliminar(object obj)
        {
            int idPostura = (int)obj;
            string query = "DELETE FROM postura WHERE idPostura = @id";
            using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
            {
                conexion.Open();
                using (MySqlCommand comando = new MySqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@id", idPostura);
                    comando.ExecuteNonQuery();
                }
            }

        }

        // Método para insertar una nueva postura en la base de datos
        public static void Insertar(object obj)
        {
            Postura postura = (Postura)obj;
            string query = "INSERT INTO postura (nombreSans, traduccionEs, traduccionEn, videoURL) VALUES (@nombreSans, @traduccionEs, @traduccionEn, @videoURL)";
            using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
            {
                conexion.Open();
                using (MySqlCommand comando = new MySqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@nombreSans", postura.NombreSans);
                    comando.Parameters.AddWithValue("@traduccionEs", postura.NombreEs);
                    comando.Parameters.AddWithValue("@traduccionEn", postura.NombreEn);
                    comando.Parameters.AddWithValue("@videoURL", postura.VideoURL);
                    comando.ExecuteNonQuery();
                }
            }
        }

        // Método para obtener una postura por su nombre en sánscrito
        public static object getBySans(object obj)
        {
            string nombreSans = (string)obj;
            Postura postura = new Postura();
            string query = "SELECT * FROM postura WHERE nombreSans = @nombre";
            using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
            {
                conexion.Open();
                using (MySqlCommand comando = new MySqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@nombre", nombreSans);
                    using (MySqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            postura.IdPostura = reader.GetInt32(0);
                            postura.NombreSans = reader.GetString(1);
                            postura.NombreEn = reader.GetString(2);
                            postura.NombreEs = reader.GetString(3);
                            postura.VideoURL = reader.GetString(4);
                        }
                    }
                }
            }
            return postura;
        }

        // Método para obtener la información de una postura y sus morfemas asociados
        public static object getPosturaInfo(object obj)
        {
            Postura postura = getBySans(obj) as Postura;
            return new PosturaDTO(postura, MorfemaDAO.getAllByPosturaId(postura.IdPostura));
        }

        public static void insertarRelacionMorfemaPostura(int idPostura, int idMorfema)
        {
            string query = "INSERT INTO postura_morfema (idPostura, idMorfema) VALUES (@idPostura, @idMorfema)";
            using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
            {
                conexion.Open();
                using (MySqlCommand comando = new MySqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@idPostura", idPostura);
                    comando.Parameters.AddWithValue("@idMorfema", idMorfema);
                    comando.ExecuteNonQuery();
                }
            }
        }
    }
}
