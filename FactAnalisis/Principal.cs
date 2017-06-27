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
            FormCollection fc = Application.OpenForms;
            bool FormFound = false;
            foreach (Form frm in fc)
            {
                if (frm.Name == "CargaArchivosForm")
                {
                    frm.Focus();
                    FormFound = true;
                }
            }
            if (FormFound == false)
            {
                CargaArchivosForm myForm = new CargaArchivosForm();
                myForm.MdiParent = this;
                myForm.Show();
            }
          
        }

        private void analisisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCollection fc = Application.OpenForms;
            bool FormFound = false;
            foreach (Form frm in fc)
            {
                if (frm.Name == "Analisis")
                {
                    frm.Focus();
                    FormFound = true;
                }
            }
            if (FormFound == false)
            {
                Analisis myForm = new Analisis();
                myForm.MdiParent = this;
                myForm.Show();
            }
        }
    }
}
