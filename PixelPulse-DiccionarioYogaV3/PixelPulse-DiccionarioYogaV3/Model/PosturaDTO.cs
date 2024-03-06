using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixelPulse_DiccionarioYogaV3.Model
{
    // Clase que representa un objeto de transferencia de datos (DTO) para una postura
    public class PosturaDTO
    {
        // Campos privados de la clase PosturaDTO
        private Postura postura;
        private List<Morfema> morfemas;

        // Constructor con parámetros para inicializar los campos postura y morfemas
        public PosturaDTO(Postura postura, List<Morfema> morfemas)
        {
            this.postura = postura;
            this.morfemas = morfemas;
        }

        // Propiedades para acceder a los campos privados de la clase PosturaDTO
        public Postura Postura { get => postura; set => postura = value; }
        public List<Morfema> Morfemas { get => morfemas; set => morfemas = value; }
    }
}
