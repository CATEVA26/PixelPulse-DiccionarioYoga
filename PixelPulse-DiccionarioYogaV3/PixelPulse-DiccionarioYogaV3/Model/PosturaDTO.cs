using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixelPulse_DiccionarioYogaV3.Model
{
    public class PosturaDTO
    {
        private Postura postura;
        private List<Morfema> morfemas;

        public PosturaDTO(Postura postura, List<Morfema> morfemas)
        {
            this.postura = postura;
            this.morfemas = morfemas;
        }

        public Postura Postura { get => postura; set => postura = value; }
        public List<Morfema> Morfemas { get => morfemas; set => morfemas = value; }
    }
}
