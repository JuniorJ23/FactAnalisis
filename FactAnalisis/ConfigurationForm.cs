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
                    txtRutaExport.Text = fbd.SelectedPath;
                }
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtRutaBD.Text))
            {
                return;
            }

            if (string.IsNullOrEmpty(txtRutaExport.Text))
            {
                return;
            }

            config.rutaSQLite = txtRutaBD.Text;
            config.rutaExportDBF = txtRutaExport.Text;

        }
    }
}
