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
        private string morfemaSans;
        private string morfemaEs;

        public Morfema() { }

        public Morfema(int idMorfema, string morfemaSans, string morfemaEs)
        {
            this.idMorfema = idMorfema;
            this.morfemaSans = morfemaSans;
            this.morfemaEs = morfemaEs;
        }

        public Morfema(string morfemaSans, string morfemaEs)
        {
            this.morfemaSans = morfemaSans;
            this.morfemaEs = morfemaEs;
        }

        public int IdMorfema { get => idMorfema; set => idMorfema = value; }
        public string MorfemaSans { get => morfemaSans; set => morfemaSans = value; }
        public string MorfemaEs { get => morfemaEs; set => morfemaEs = value; }

    }
}
