using PixelPulse_DiccionarioYogaV3.DAO;
using PixelPulse_DiccionarioYogaV3.Model;
using PixelPulse_DiccionarioYogaV3.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PixelPulse_DiccionarioYogaV3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void siticoneHtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void siticoneHtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void siticoneHtmlLabel4_Click(object sender, EventArgs e)
        {

        }

        private void lblTEs_Click(object sender, EventArgs e)
        {

        }

        private void BusquedaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter) {
                BusquedaButton_Click(sender, e);
            } else  {
                ResetearCampos();
            }
              
        }

        private async void BusquedaButton_Click(object sender, EventArgs e)
        {
            string textoAMorfema = BusquedaTextBox.Text.Trim();

            // Verificar si el texto está vacío o solo contiene números
            if (string.IsNullOrWhiteSpace(textoAMorfema))
            {
                ResetearCampos();
                MessageBox.Show("El campo de busqueda está vacío. \nPor favor, ingrese una palabra para traducir.",
                            "Error de entrada.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;  // Salir del método si hay un error
            }
            else if (textoAMorfema.All(char.IsDigit))
            {
                BusquedaTextBox.Text = "";
                MessageBox.Show("El campo de busqueda solo debe contener letras. \nPor favor, ingrese una palabra que no sea solo números.",
                            "Error de entrada.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;  // Salir del método si hay un error
            }
            // Verificar si la cadena contiene un signo de subrayado (_) o un punto (.)
            else if (textoAMorfema.Contains("_") || textoAMorfema.Contains("."))
            {
                MessageBox.Show("El campo de busqueda no debe contener signos de puntuación. \nPor favor, ingrese una palabra sin signos de puntuación.",
                            "Error de entrada.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            textoAMorfema = FormatearPalabra(textoAMorfema);
            PosturaDTO posturaDto = (PosturaDTO)PosturaDAO.getPosturaInfo(textoAMorfema);

            if (posturaDto.Postura.IdPostura == 0)
            {
                ResetearCampos();
                MessageBox.Show($"La palabra '{@textoAMorfema}' no se encuentra en el diccionario. \nPor favor, ingrese una palabra que esté en el diccionario.",
                                               $"Palabra no encontrada.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblPostura.Text = posturaDto.Postura.NombreSans;
            ESTextBox.Text = posturaDto.Postura.NombreEn;
            ENTextBox.Text = posturaDto.Postura.NombreEn;
            foreach (Morfema morfema in posturaDto.Morfemas)
            {
                MorfemaTextBox.Text += morfema.MorfemaSans + ": " + morfema.MorfemaEs + Environment.NewLine;
            }

            ReproducirVideo(posturaDto.Postura.VideoURL);
            BusquedaTextBox.Text = string.Empty;
        }

        private void ReproducirVideo(string url)
        {
            string html = "<html><head style=>";
            html += "<meta content='IE=Edge' http-equiv='X-UA-Compatible'/>";
            html += "<body style='margin: 0px; background-color: transparent;'>";
            html += "<iframe id='video' src='{0}' width='620' height='380' frameborder='0' allowfullscreen></iframe>";
            html += "</body>";
            html += "</head></html>";
            this.videoPostura.DocumentText = string.Format(html, url);

        }

        private void ResetearCampos()
        {
            lblPostura.Text = "Postura";
            ENTextBox.Text = "";
            ESTextBox.Text = "";
            MorfemaTextBox.Text = "";
            videoPostura.DocumentText = string.Empty;
        }

        private string FormatearPalabra(string oracion)
        {
            // Verifica si la cadena es nula o está vacía
            if (string.IsNullOrEmpty(oracion))
            {
                return oracion;
            }

            TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
            string oracionFormateada = textInfo.ToTitleCase(oracion.ToLower());

            return oracionFormateada;
        }

        private void siticoneHtmlLabel3_Click(object sender, EventArgs e)
        {

        }

        private void AsanaSutra_Load(object sender, EventArgs e)
        {

        }

        private void BusquedaTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            AniadirPostura aniadirPostura = new AniadirPostura();
            aniadirPostura.ShowDialog();
        }
    }
}
