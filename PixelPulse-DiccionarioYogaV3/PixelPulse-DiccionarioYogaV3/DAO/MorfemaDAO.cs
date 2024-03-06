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

        public static void Eliminar(object obj)
        {
            throw new NotImplementedException();
        }

        public static void Insertar(object obj)
        {
            Morfema morfema = (Morfema)obj;
            string query = "INSERT INTO morfema (morfemaSans, morfemaEs) VALUES (@morfemaSans, @morfemaEs)";
            using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
            {
                conexion.Open();
                using (MySqlCommand comando = new MySqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@morfemaSans", morfema.MorfemaSans);
                    comando.Parameters.AddWithValue("@morfemaEs", morfema.MorfemaEs);
                    comando.ExecuteNonQuery();
                }
            }
        }
        
        public static Morfema getById(int idMorfema)
        {
            Morfema morfema = new Morfema();
            string query = "SELECT * FROM morfema WHERE idMorfema = @id";
            using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
            {
                conexion.Open();
                using (MySqlCommand comando = new MySqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@id", idMorfema);
                    using (MySqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            morfema.IdMorfema = reader.GetInt32(0);
                            morfema.MorfemaSans = reader.GetString(1);
                            morfema.MorfemaEs = reader.GetString(2);
                        }
                    }
                }
            }
            return morfema;
        }

        public static List<Morfema> getAllByPosturaId(object obj)
        {
            int idPostura = (int)obj;
            List<Morfema> listaMorfemas = new List<Morfema>();
            string query = "SELECT * FROM postura_morfema WHERE idPostura = @id";
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
                            Morfema morfema = getById(reader.GetInt32(2));
                            listaMorfemas.Add(morfema);
                        }
                    }
                }
            }
            return listaMorfemas;
        }

        public static List<Morfema> getAll()
        {
            List<Morfema> listaMorfemas = new List<Morfema>();
            string query = "SELECT * FROM morfema";
            using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
            {
                conexion.Open();
                using (MySqlCommand comando = new MySqlCommand(query, conexion))
                {
                    using (MySqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Morfema morfema = new Morfema();
                            morfema.IdMorfema = reader.GetInt32(0);
                            morfema.MorfemaSans = reader.GetString(1);
                            morfema.MorfemaEs = reader.GetString(2);
                            listaMorfemas.Add(morfema);
                        }
                    }
                }
            }
            return listaMorfemas;
        }
    }
}
