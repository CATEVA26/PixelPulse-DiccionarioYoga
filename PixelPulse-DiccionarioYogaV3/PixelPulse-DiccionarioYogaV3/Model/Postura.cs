using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixelPulse_DiccionarioYogaV3.Model
{
    // Clase que representa una postura en el diccionario de yoga
    public class Postura
    {
        // Campos privados de la clase Postura
        private int idPostura;
        private string nombreSans;
        private string nombreEs;
        private string nombreEn;
        private string videoURL;

        // Constructor por defecto
        public Postura() { }

        // Constructor con parámetros para inicializar todos los campos
        public Postura(int idPostura, string nombreSans, string traduccionEs, string traduccionEn, string videoURL)
        {
            this.idPostura = idPostura;
            this.nombreSans = nombreSans;
            this.nombreEs = traduccionEs;
            this.nombreEn = traduccionEn;
            this.videoURL = videoURL;
        }

        // Constructor con parámetros para inicializar los campos nombreSans, nombreEs, nombreEn y videoURL
        public Postura(string nombreSans, string traduccionEs, string traduccionEn, string videoURL)
        {
            this.nombreSans = nombreSans;
            this.nombreEs = traduccionEs;
            this.nombreEn = traduccionEn;
            this.videoURL = videoURL;
        }

        // Propiedades para acceder a los campos privados de la clase Postura
        public int IdPostura { get => idPostura; set => idPostura = value; }
        public string NombreSans { get => nombreSans; set => nombreSans = value; }
        public string NombreEs { get => nombreEs; set => nombreEs = value; }
        public string NombreEn { get => nombreEn; set => nombreEn = value; }
        public string VideoURL { get => videoURL; set => videoURL = value; }
    }
}
