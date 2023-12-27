using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZstdSharp;

namespace ProyectoYoga_PixelPulse
{

    internal class Postura
    {
        private string? descripcion;
        private List<string> morfemas;
        private Dictionary<string, string> traducciones = new() {
            {"Tadasana","Postura de la Montaña"},
            {"Adho Mukha Svanasana","Perro mirando hacia abajo"},
            {"Virabhadrasana I","Guerrero I"},
            {"Virabhadrasana Ii","Guerrero II"},
            {"Vrikshasana","Postura del Árbol"},
            {"Balasana","Postura del Niño"},
            {"Ardha Bhujangasana","Postura de la Cobra a la mitad"},
            {"Paschimottanasana","Flexión hacia adelante sentado"},
            {"Setu Bandhasana","Postura del Puente"},
            {"Shavasana","Postura del Cadáver"},
            {"Trikonasana","Postura del Triángulo"},
            {"Kumbhakasana","Postura de la Plancha"},
            {"Urdhva Mukha Svanasana","Perro mirando hacia arriba"},
            {"Matsyasana","Postura del Pez"},
            {"Utkatasana","Postura de la Silla"},
            {"Malasana","Postura de la Guirnalda" },
            {"Eka Pada Rajakapotasana","Postura de la Paloma" },
            {"Urdhva Hastasana","Saludo hacia arriba" },
            {"Parivrtta Trikonasana","Postura del Triángulo Invertido" },
            {"Parivrtta Janu Sirsasana","Postura de la Cabeza a la Rodilla Invertida" }

        };
        public Postura(string fraseAtraducir)
        {
            morfemas = Morfema.TraducirMorfema(fraseAtraducir);
            descripcion = TraducirAEs(fraseAtraducir);
        }

        public string? TraducirAEs(string fraseAtraducir)
        {
            string[] palabrasSans = fraseAtraducir.Split(new[] { '\t', '\n', '\r', ',', '.' });
            Console.WriteLine(palabrasSans[0]);
            List<string> palabrasTraducidas = new List<string>();

            foreach (string palabraSans in palabrasSans)
            {

                if (traducciones.TryGetValue(palabraSans, out string traduccion))
                {
                    palabrasTraducidas.Add(traduccion);
                }
                else
                {
                    if (!Morfema.diccionarioSansEs.ContainsKey(palabraSans))
                    {
                        return null;
                    }

                }
            }

            // Concatena las palabras traducidas para formar el texto traducido
            return string.Join(" ", palabrasTraducidas);
        }
        public string GetDescripcion()
        {
            return descripcion ?? string.Empty;
        }

        public void AgregarDescripcion()
        {
            throw new NotImplementedException();
        }

        public List<string> GetMorfemas() { return morfemas; }
    }



}
