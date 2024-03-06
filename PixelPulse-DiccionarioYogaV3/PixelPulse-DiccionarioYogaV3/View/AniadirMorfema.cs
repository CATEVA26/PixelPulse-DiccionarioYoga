using PixelPulse_DiccionarioYogaV3.DAO;
using PixelPulse_DiccionarioYogaV3.Model;
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
    public partial class AniadirMorfema : Form
    {
        public AniadirMorfema()
        {
            InitializeComponent();
        }

        private void GuardarPosturaB_Click(object sender, EventArgs e)
        {
            if (Validador.ValidarCampos(this))
            {
                Morfema morfema = new Morfema();
                morfema.MorfemaSans = MorfemaSansTB.Text;
                morfema.MorfemaEs = MorfemaEsTB.Text;

                MorfemaDAO.Insertar(morfema);
                Close();
            }
        }

        private void CancelarB_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
