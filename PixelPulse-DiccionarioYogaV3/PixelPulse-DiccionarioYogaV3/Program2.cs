using PixelPulse_DiccionarioYogaV3.DAO;
using PixelPulse_DiccionarioYogaV3.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixelPulse_DiccionarioYogaV3
{
    internal static class Program2
    {
        static void Main()
        {
            Postura postura = new Postura();
            postura.IdPostura = 1;
            postura.NombreSans = "Tadasana";
            postura.TraduccionEs = "Postura de la Montaña";
            postura.TraduccionEn = "mountain pose";
            postura.VideoURL = "https://www.youtube.com/embed/K0YpVejOGrg?si=XVVhEfl1udHdbUom";
            PosturaDAO.Insertar(postura);
        }


    }
}
