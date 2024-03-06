using PixelPulse_DiccionarioYogaV3.DAO;
using PixelPulse_DiccionarioYogaV3.Model;
using Siticone.Desktop.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PixelPulse_DiccionarioYogaV3.View
{
    public partial class AniadirPostura : Form
    {
        List<Morfema> morfemas = new List<Morfema>();
        public AniadirPostura()
        {
            InitializeComponent();

            morfemas = MorfemaDAO.getAll();

            CargarMorfemas();
            MorfemaCB.SelectedIndex = 0;
        }

        public void CargarMorfemas()
        {
            MorfemaCB.Items.Clear();
            MorfemaCB.Items.Add("Seleccione...");
            morfemas = MorfemaDAO.getAll();
            foreach (Morfema morfema in morfemas)
            {
                MorfemaCB.Items.Add(morfema.MorfemaSans);
            }
        }

        private void AniadirMorfemaButton_Click(object sender, EventArgs e)
        {
            foreach (Morfema morfema in morfemas)
            {
                if (MorfemaCB.SelectedItem.ToString().Equals(morfema.MorfemaSans))
                {
                    Morfema morfemaSeleccionado = morfema;
                    MorfemasDG.Rows.Add(morfemaSeleccionado.IdMorfema, morfemaSeleccionado.MorfemaSans, morfemaSeleccionado.MorfemaEs);
                }
            }
        }

        private void GuardarPosturaB_Click(object sender, EventArgs e)
        {
            if (Validador.ValidarCampos(this)) 
            {
                Postura postura = new Postura();
                postura.NombreSans = NombreSansTB.Text;
                postura.NombreEn = NombreEsTB.Text;
                postura.NombreEn = NombreEnTB.Text;
                postura.VideoURL = VideoUrlTB.Text;

                PosturaDAO.Insertar(postura);

                Postura posturaAux = (Postura)PosturaDAO.getBySans(postura.NombreSans);


                foreach (DataGridViewRow row in MorfemasDG.Rows)
                {
                    int idMorfema = (int)row.Cells[0].Value;
                    PosturaDAO.insertarRelacionMorfemaPostura(posturaAux.IdPostura, idMorfema);
                }
                Close();
            }
        }

        private void MorfemasDG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // CLICK EN CELDA ELIMINAR CLIENTE
            if (MorfemasDG.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                if (e.RowIndex >= 0)
                {
                    MorfemasDG.Rows.RemoveAt(e.RowIndex);
                }
            }
        }

        private void CancelarB_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void NuevoMorfemaButton_Click(object sender, EventArgs e)
        {
            AniadirMorfema aniadirMorfema = new AniadirMorfema();
            aniadirMorfema.ShowDialog();
            CargarMorfemas();
        }


    }
}
