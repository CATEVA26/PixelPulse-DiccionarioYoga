using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixelPulse_DiccionarioYogaV3.Model
{
    // Clase que representa un morfema en el diccionario de yoga
    public class Morfema
    {
        // Campos privados de la clase Morfema
        private int idMorfema;
        private string morfemaSans;
        private string morfemaEs;

        // Constructor por defecto
        public Morfema() { }

        // Constructor con parámetros para inicializar todos los campos
        public Morfema(int idMorfema, string morfemaSans, string morfemaEs)
        {
            this.idMorfema = idMorfema;
            this.morfemaSans = morfemaSans;
            this.morfemaEs = morfemaEs;
        }

        // Constructor con parámetros para inicializar los campos morfemaSans y morfemaEs
        public Morfema(string morfemaSans, string morfemaEs)
        {
            this.morfemaSans = morfemaSans;
            this.morfemaEs = morfemaEs;
        }

        // Propiedades para acceder a los campos privados de la clase Morfema
        public int IdMorfema { get => idMorfema; set => idMorfema = value; }
        public string MorfemaSans { get => morfemaSans; set => morfemaSans = value; }
        public string MorfemaEs { get => morfemaEs; set => morfemaEs = value; }

    }
}
