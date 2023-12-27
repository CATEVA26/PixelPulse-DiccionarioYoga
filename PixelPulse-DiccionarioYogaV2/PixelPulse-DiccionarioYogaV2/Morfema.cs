using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PixelPulse_DiccionarioYogaV2
{
    internal class Morfema
    {
        public static Dictionary<string, string> diccionarioSansEs = new Dictionary<string, string>() {
    {"Asana",Res.postura} ,
    {"Adho",Res.abajo},
    {"Ardha",Res.mitad},
    {"Urdhva",Res.arriba},
    {"Mukha",Res.rostro},
    {"Svana",Res.perro},
    {"Virabhadra",Res.guerrero},
    {"Vriksha",Res.arbol} ,
    {"Bala",Res.ninio},
    {"Bhujanga",Res.cobra},
    {"Paschi",Res.oeste},
    {"Setu",Res.puente},
    {"Shava",Res.cadaver},
    {"Trikona",Res.triangulo},
    {"Matsya",Res.pez},
    {"Mala",Res.guirnalda},
    {"Eka",Res.uno},
    {"Pada",Res.pie},
    {"Raja",Res.real},
    {"Kapota",Res.paloma},
    {"Hasta",Res.mano},
    {"Parivrtta",Res.invertido},
    {"Janu", Res.rodilla},
    {"Sirsa", Res.cabeza},
    {"Tada",Res.montania }

    };

        public static List<string> TraducirMorfema(string sans)
        {

            if (sans == null) return new List<string>();
            
            List<string> morfemas = new List<string>();

            string[] palabras = sans.Split(' ');

            if (TieneNumerosRomanos(palabras[palabras.Length - 1]))
            {
                string oracion = string.Join(" ", palabras.Take(palabras.Length - 1));
                return TraducirMorfema(oracion);
            }
            foreach (string palabra in palabras)
            {
                if (diccionarioSansEs.TryGetValue(palabra, out string traduccion))
                {
                    morfemas.Add(palabra + ": " + diccionarioSansEs[palabra]+"<br>");
                }
                else if (palabra.EndsWith("asana", StringComparison.OrdinalIgnoreCase))
                {
                    // Separar la palabra y agregar la 'A' a la otra parte
                    string otraParte = palabra.Substring(0, palabra.Length - 5);
                    try {
                        morfemas.AddRange(TraducirMorfema(otraParte + "a Asana"));
                    }catch (Exception e)
                    {
                        return morfemas;
                    }
                    
                }
                else
                {
                    return null;
                }
            }

            return morfemas;

        }
        private static bool TieneNumerosRomanos(string cadena)
        {
            cadena = cadena.ToUpper();
            string patron = @"^M{0,3}(CM|CD|D?C{0,3})(XC|XL|L?X{0,3})(IX|IV|V?I{0,3})$";
            return Regex.IsMatch(cadena, patron);
        }
    }
}
