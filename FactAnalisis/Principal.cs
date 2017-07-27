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
    public partial class Principal : Office2007Form
    {
        Configuracion config;
        public Principal()
        {
            InitializeComponent();
            config = Configuracion.Instance;
            lblHostValue.Text = config.Server;
            lblValuePort.Text = config.Port;
        }

      

        private void buttonItem1_Click(object sender, EventArgs e)
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

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
           
        }

        private void btnAnalisis_Click(object sender, EventArgs e)
        {
            
            ArchivosFacturacion archFact = ArchivosFacturacion.Instance;

            MessageBoxEx.EnableGlass = false;

            if (string.IsNullOrEmpty(archFact.rutaFactBruta) || string.IsNullOrEmpty(archFact.rutaNotas))
            {

                MessageBoxEx.Show(this, "NO SE HAN ESCOGIDO LOS ARCHIVOS DE FACTURACION Y DE NOTAS. POR FAVOR SIRVASE SELECCIONARLOS.", "MENSAJE DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }



            if (string.IsNullOrEmpty(config.Server) || string.IsNullOrEmpty(config.Port) || string.IsNullOrEmpty(config.Username) || string.IsNullOrEmpty(config.Password))
            {
                MessageBoxEx.Show(this, "NO SE HAN COMPLETADO LOS DATOS DE CONFIGURACION.", "MENSAJE DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

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

        private void btnChangeConfig_Click(object sender, EventArgs e)
        {
            FormCollection fc = Application.OpenForms;
            bool FormFound = false;
            foreach (Form frm in fc)
            {
                if (frm.Name == "ConfigurationForm")
                {
                    frm.Focus();
                    FormFound = true;
                }
            }
            if (FormFound == false)
            {
                ConfigurationForm myForm = new ConfigurationForm(false);
                myForm.MdiParent = this;
                myForm.Show();
            }
        }

        private void Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnEstructuraTarif_Click(object sender, EventArgs e)
        {
            FormCollection fc = Application.OpenForms;
            bool FormFound = false;
            foreach (Form frm in fc)
            {
                if (frm.Name == "EstructuraTarifaria")
                {
                    frm.Focus();
                    FormFound = true;
                }
            }
            if (FormFound == false)
            {
                EstructuraTarifaria myForm = new EstructuraTarifaria();
                myForm.MdiParent = this;
                myForm.Show();
            }
        }
    }
}
