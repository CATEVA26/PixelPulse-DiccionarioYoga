using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixelPulse_DiccionarioYogaV3.Model
{
    public class Postura
    {
        private int idPostura;
        private string nombreSans;
        private string nombreEs;
        private string nombreEn;
        private string videoURL;

        public Postura() { }

        public Postura(int idPostura, string nombreSans, string traduccionEs, string traduccionEn, string videoURL)
        {
            this.idPostura = idPostura;
            this.nombreSans = nombreSans;
            this.nombreEs = traduccionEs;
            this.nombreEn = traduccionEn;
            this.videoURL = videoURL;
        }

        public Postura(string nombreSans, string traduccionEs, string traduccionEn, string videoURL)
        {
            this.nombreSans = nombreSans;
            this.nombreEs = traduccionEs;
            this.nombreEn = traduccionEn;
            this.videoURL = videoURL;
        }

        public int IdPostura { get => idPostura; set => idPostura = value; }
        public string NombreSans { get => nombreSans; set => nombreSans = value; }
        public string TraduccionEs { get => nombreEs; set => nombreEs = value; }
        public string TraduccionEn { get => nombreEn; set => nombreEn = value; }
        public string VideoURL { get => videoURL; set => videoURL = value; }
        
    }
}
