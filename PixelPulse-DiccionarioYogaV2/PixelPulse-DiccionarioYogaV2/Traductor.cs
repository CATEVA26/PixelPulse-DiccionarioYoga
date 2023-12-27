using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PixelPulse_DiccionarioYogaV2
{
    internal class Traductor
    {
        private readonly HttpClient _httpClient;
        public Traductor() {
            _httpClient = new HttpClient();
        
        }
        public async Task<string> Traducir(string inputText)
        {
            string apiUrl = "https://api-inference.huggingface.co/models/Helsinki-NLP/opus-mt-es-en";
            string apiKey = "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";
            inputText = inputText.Contains("Guerrero") ? inputText += "." : inputText;

            try
            {
                // Configurar encabezados de la solicitud
                _httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");

                // Crear objeto con la estructura esperada por la API
                var requestData = new { inputs = inputText };

                // Convertir objeto a cadena JSON
                string jsonData = Newtonsoft.Json.JsonConvert.SerializeObject(requestData);

                // Crear contenido para la solicitud POST
                var content = new StringContent(jsonData, Encoding.UTF8, "application/json");

                // Realizar solicitud POST a la API
                HttpResponseMessage response = await _httpClient.PostAsync(apiUrl, content);

                // Verificar si la solicitud fue exitosa (código de estado 200-299)
                if (response.IsSuccessStatusCode)
                {
                    // Leer el contenido de la respuesta como una cadena
                    string responseBody = await response.Content.ReadAsStringAsync();
                    string respondeBody = responseBody.Replace('[',' ').Replace(']',' ');
                    var data = JObject.Parse(respondeBody);
                    var transalation = Convert.ToString(data["translation_text"]); ;

                    return transalation;
                }
                else
                {
                    return " ";
                }
            }
            catch (Exception ex)
            {
                return $"Error en la solicitud: {ex.Message}";
            }
        }
    }
}
