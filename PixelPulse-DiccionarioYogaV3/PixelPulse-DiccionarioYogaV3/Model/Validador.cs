using Siticone.Desktop.UI.WinForms; // Importación del espacio de nombres para controles Siticone
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; // Importación del espacio de nombres para controles de Windows Forms

namespace PixelPulse_DiccionarioYogaV3.Model
{
    // Clase estática que proporciona métodos para validar campos en controles Windows Forms
    public static class Validador
    {
        // Método para validar campos en un control padre
        public static bool ValidarCampos(Control parentControl)
        {
            foreach (Control control in parentControl.Controls)
            {
                // Verificar si el control es un TextBox de Siticone
                if (control is SiticoneTextBox textBox)
                {
                    // Verificar si el texto del TextBox está vacío o contiene solo espacios en blanco
                    if (string.IsNullOrWhiteSpace(textBox.Text))
                    {
                        // Mostrar mensaje de error si el campo está vacío
                        MessageBox.Show($"El campo {textBox.Name} no puede estar vacío.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false; // Indicar que la validación falló
                    }
                }
                // Verificar si el control es un DataGridView de Siticone
                else if (control is SiticoneDataGridView dataGridView)
                {
                    // Verificar si el DataGridView no contiene filas
                    if (dataGridView.Rows.Count == 0)
                    {
                        // Mostrar mensaje de error si el DataGridView no contiene filas
                        MessageBox.Show("La tabla debe tener al menos una fila.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false; // Indicar que la validación falló
                    }
                }
            }
            return true; // Indicar que la validación fue exitosa si no se encontraron problemas
        }
    }
}
