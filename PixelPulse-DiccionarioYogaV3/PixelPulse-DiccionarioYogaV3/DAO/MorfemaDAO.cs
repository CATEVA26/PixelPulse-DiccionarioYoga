using MySqlConnector;
using PixelPulse_DiccionarioYogaV3.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixelPulse_DiccionarioYogaV3.DAO
{
    // Clase para acceder a los datos relacionados con los morfemas
    public class MorfemaDAO : ObjBaseDAO
    {
        // Método para eliminar un morfema de la base de datos (no implementado)
        public static void Eliminar(object obj)
        {
            throw new NotImplementedException(); // Excepción de método no implementado
        }

        // Método para insertar un nuevo morfema en la base de datos
        public static void Insertar(object obj)
        {
            Morfema morfema = (Morfema)obj; // Conversión del objeto a tipo Morfema
            string query = "INSERT INTO morfema (morfemaSans, morfemaEs) VALUES (@morfemaSans, @morfemaEs)";
            using (MySqlConnection conexion = new MySqlConnection(cadenaConexion)) // Inicio de la conexión a la base de datos
            {
                conexion.Open(); // Apertura de la conexión
                using (MySqlCommand comando = new MySqlCommand(query, conexion)) // Creación de un comando SQL
                {
                    // Asignación de parámetros al comando
                    comando.Parameters.AddWithValue("@morfemaSans", morfema.MorfemaSans);
                    comando.Parameters.AddWithValue("@morfemaEs", morfema.MorfemaEs);
                    comando.ExecuteNonQuery(); // Ejecución del comando SQL
                }
            }
        }

        // Método para obtener un morfema por su identificador
        public static Morfema getById(int idMorfema)
        {
            Morfema morfema = new Morfema(); // Creación de un nuevo objeto Morfema
            string query = "SELECT * FROM morfema WHERE idMorfema = @id";
            using (MySqlConnection conexion = new MySqlConnection(cadenaConexion)) // Inicio de la conexión a la base de datos
            {
                conexion.Open(); // Apertura de la conexión
                using (MySqlCommand comando = new MySqlCommand(query, conexion)) // Creación de un comando SQL
                {
                    comando.Parameters.AddWithValue("@id", idMorfema); // Asignación de parámetros al comando
                    using (MySqlDataReader reader = comando.ExecuteReader()) // Lectura de datos mediante un DataReader
                    {
                        while (reader.Read()) // Iteración sobre los resultados obtenidos
                        {
                            // Asignación de valores al objeto Morfema
                            morfema.IdMorfema = reader.GetInt32(0);
                            morfema.MorfemaSans = reader.GetString(1);
                            morfema.MorfemaEs = reader.GetString(2);
                        }
                    }
                }
            }
            return morfema; // Devolución del objeto Morfema
        }

        // Método para obtener todos los morfemas asociados a una postura
        public static List<Morfema> getAllByPosturaId(object obj)
        {
            int idPostura = (int)obj; // Conversión del objeto a tipo entero (idPostura)
            List<Morfema> listaMorfemas = new List<Morfema>(); // Creación de una lista de objetos Morfema
            string query = "SELECT * FROM postura_morfema WHERE idPostura = @id";
            using (MySqlConnection conexion = new MySqlConnection(cadenaConexion)) // Inicio de la conexión a la base de datos
            {
                conexion.Open(); // Apertura de la conexión
                using (MySqlCommand comando = new MySqlCommand(query, conexion)) // Creación de un comando SQL
                {
                    comando.Parameters.AddWithValue("@id", idPostura); // Asignación de parámetros al comando
                    using (MySqlDataReader reader = comando.ExecuteReader()) // Lectura de datos mediante un DataReader
                    {
                        while (reader.Read()) // Iteración sobre los resultados obtenidos
                        {
                            Morfema morfema = getById(reader.GetInt32(2)); // Obtención del morfema por su identificador
                            listaMorfemas.Add(morfema); // Agregación del morfema a la lista
                        }
                    }
                }
            }
            return listaMorfemas; // Devolución de la lista de morfemas
        }

        // Método para obtener todos los morfemas almacenados en la base de datos
        public static List<Morfema> getAll()
        {
            List<Morfema> listaMorfemas = new List<Morfema>(); // Creación de una lista de objetos Morfema
            string query = "SELECT * FROM morfema";
            using (MySqlConnection conexion = new MySqlConnection(cadenaConexion)) // Inicio de la conexión a la base de datos
            {
                conexion.Open(); // Apertura de la conexión
                using (MySqlCommand comando = new MySqlCommand(query, conexion)) // Creación de un comando SQL
                {
                    using (MySqlDataReader reader = comando.ExecuteReader()) // Lectura de datos mediante un DataReader
                    {
                        while (reader.Read()) // Iteración sobre los resultados obtenidos
                        {
                            Morfema morfema = new Morfema(); // Creación de un nuevo objeto Morfema
                            // Asignación de valores al objeto Morfema
                            morfema.IdMorfema = reader.GetInt32(0);
                            morfema.MorfemaSans = reader.GetString(1);
                            morfema.MorfemaEs = reader.GetString(2);
                            listaMorfemas.Add(morfema); // Agregación del morfema a la lista
                        }
                    }
                }
            }
            return listaMorfemas; // Devolución de la lista de morfemas
        }
    }
}