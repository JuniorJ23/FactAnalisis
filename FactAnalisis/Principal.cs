using DevComponents.DotNetBar;
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
    public partial class Principal : Office2007Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void cargarFacturaciónBrutaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CargaArchivosForm myForm = new CargaArchivosForm();
            myForm.MdiParent = this;
            myForm.Show();
        }
    }
}
