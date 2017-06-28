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
    public partial class Analisis : Office2007Form
    {
        private ArchivosFacturacion archFact;

        public Analisis()
        {
            InitializeComponent();
            archFact = ArchivosFacturacion.Instance;
        }

        private void btnMergeFact_Click(object sender, EventArgs e)
        {

            if(string.IsNullOrEmpty(archFact.rutaFactBruta) || string.IsNullOrEmpty(archFact.rutaNotas))
            {
                MessageBoxEx.EnableGlass = false;
                MessageBoxEx.Show(this, "NO SE HAN ESCOGIDO LOS ARCHIVOS DE FACTURACION Y DE NOTAS. POR FAVOR SIRVASE SELECCIONARLOS EN EL MENU DE ARCHIVO.", "MENSAJE DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

        }
    }
}
