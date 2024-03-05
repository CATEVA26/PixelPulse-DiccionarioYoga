using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixelPulse_DiccionarioYogaV3.Model
{
    public class Morfema
    {
        private int idMorfema;
        private int idPostura;
        private string morfemaSans;
        private string morfemaEs;

        public Morfema() { }

        public Morfema(int idMorfema, int idPostura, string morfemaSans, string morfemaEs)
        {
            this.idMorfema = idMorfema;
            this.idPostura = idPostura;
            this.morfemaSans = morfemaSans;
            this.morfemaEs = morfemaEs;
        }

        public Morfema(int idPostura, string morfemaSans, string morfemaEs)
        {
            this.idPostura = idPostura;
            this.morfemaSans = morfemaSans;
            this.morfemaEs = morfemaEs;
        }

        public int IdMorfema { get => idMorfema; set => idMorfema = value; }
        public int IdPostura { get => idPostura; set => idPostura = value; }
        public string MorfemaSans { get => morfemaSans; set => morfemaSans = value; }
        public string MorfemaEs { get => morfemaEs; set => morfemaEs = value; }

    }
}
