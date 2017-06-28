using DevComponents.DotNetBar;
using FactAnalisis.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactAnalisis
{
    public partial class ConfigurationForm : Office2007Form
    {

        Configuracion config;
        public ConfigurationForm()
        {
            InitializeComponent();
            config = Configuracion.Instance;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRutaBD_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    LimpiarValidacionDeCampos();
                    txtRutaBD.Text = fbd.SelectedPath;
                }
            }
        }

        private void btnRutaExport_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    LimpiarValidacionDeCampos();
                    txtRutaExport.Text = fbd.SelectedPath;
                }
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtRutaBD.Text))
            {
                configFormValidator.ErrorProvider.SetError(txtRutaBD, "COMPLETE EL CAMPO DE RUTA DE LA BD.");
                configFormValidator.Highlighter.SetHighlightColor(txtRutaBD, DevComponents.DotNetBar.Validator.eHighlightColor.Orange);
                return;
            }

            if (string.IsNullOrEmpty(txtRutaExport.Text))
            {
                configFormValidator.ErrorProvider.SetError(txtRutaExport, "COMPLETE EL CAMPO DE RUTA DE EXPORTACION DBF.");
                configFormValidator.Highlighter.SetHighlightColor(txtRutaExport, DevComponents.DotNetBar.Validator.eHighlightColor.Orange);
                return;
            }

            LimpiarValidacionDeCampos();

            config.rutaSQLite = txtRutaBD.Text;
            config.rutaExportDBF = txtRutaExport.Text;

            MessageBoxEx.EnableGlass = false;
            DialogResult result = MessageBoxEx.Show(this, "Valores cargados correctamente", "Información del sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            if (result == DialogResult.OK)
            {
                Close();
            }

        }

        private void LimpiarValidacionDeCampos()
        {
            configFormValidator.ErrorProvider.SetError(txtRutaBD, null);
            configFormValidator.Highlighter.SetHighlightColor(txtRutaBD, DevComponents.DotNetBar.Validator.eHighlightColor.None);

            configFormValidator.ErrorProvider.SetError(txtRutaExport, null);
            configFormValidator.Highlighter.SetHighlightColor(txtRutaExport, DevComponents.DotNetBar.Validator.eHighlightColor.None);
        }
    }
}
