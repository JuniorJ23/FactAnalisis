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
        bool asPrincipal = false;
        Configuracion config;
        public ConfigurationForm(bool asPrincipal)
        {
            this.asPrincipal = asPrincipal;
            InitializeComponent();
            config = Configuracion.Instance;

            txtHost.Value = config.Server;
            txtPuerto.Text = config.Port;
            txtUsername.Text = config.Username;
            txtPassword.Text = config.Password;
   

            if(string.IsNullOrEmpty(config.Port) || string.IsNullOrEmpty(config.Server) || string.IsNullOrEmpty(config.Password) || string.IsNullOrEmpty(config.Username))
            {
                btnAceptar.Enabled = false;
            }
            else
            {
                btnAceptar.Enabled = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

       

     

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtHost.Value))
            {
                configFormValidator.ErrorProvider.SetError(txtHost, "COMPLETE EL CAMPO DE HOST.");
                configFormValidator.Highlighter.SetHighlightColor(txtHost, DevComponents.DotNetBar.Validator.eHighlightColor.Orange);
                return;
            }

            if (string.IsNullOrEmpty(txtPuerto.Text))
            {
                configFormValidator.ErrorProvider.SetError(txtPuerto, "COMPLETE EL CAMPO DE PUERTO.");
                configFormValidator.Highlighter.SetHighlightColor(txtPuerto, DevComponents.DotNetBar.Validator.eHighlightColor.Orange);
                return;
            }

            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                configFormValidator.ErrorProvider.SetError(txtUsername, "COMPLETE EL CAMPO DE USUARIO.");
                configFormValidator.Highlighter.SetHighlightColor(txtUsername, DevComponents.DotNetBar.Validator.eHighlightColor.Orange);
                return;
            }

            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                configFormValidator.ErrorProvider.SetError(txtPassword, "COMPLETE EL CAMPO DE PASSWORD.");
                configFormValidator.Highlighter.SetHighlightColor(txtPassword, DevComponents.DotNetBar.Validator.eHighlightColor.Orange);
                return;
            }


           

            LimpiarValidacionDeCampos();

            
            

            MessageBoxEx.EnableGlass = false;
            DialogResult result = MessageBoxEx.Show(this, "VALORES CARGADOS CORRECTAMENTE", "INFORMACION DEL SISTEMA", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            if (result == DialogResult.OK)
            {
                if (asPrincipal)
                {
                    Close();
                    new Principal().Show();
                }
                else { 
                    Close();
                }

            }

        }

        private void LimpiarValidacionDeCampos()
        {
            configFormValidator.ErrorProvider.SetError(txtHost, null);
            configFormValidator.Highlighter.SetHighlightColor(txtHost, DevComponents.DotNetBar.Validator.eHighlightColor.None);

            configFormValidator.ErrorProvider.SetError(txtPuerto, null);
            configFormValidator.Highlighter.SetHighlightColor(txtPuerto, DevComponents.DotNetBar.Validator.eHighlightColor.None);

            configFormValidator.ErrorProvider.SetError(txtUsername, null);
            configFormValidator.Highlighter.SetHighlightColor(txtUsername, DevComponents.DotNetBar.Validator.eHighlightColor.None);

            configFormValidator.ErrorProvider.SetError(txtPassword, null);
            configFormValidator.Highlighter.SetHighlightColor(txtPassword, DevComponents.DotNetBar.Validator.eHighlightColor.None);

           
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            LimpiarValidacionDeCampos();
            config.Server = txtHost.Value;
            config.Port = txtPuerto.Text;
            config.Username = txtUsername.Text;
            config.Password = txtPassword.Text;
            try
            {
                ConexionPSQL psql = new ConexionPSQL();
                MessageBoxEx.Show("CONEXION EXITOSA.");
                btnAceptar.Enabled = true;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBoxEx.Show("ERROR EN LA CONEXION.");
            }
            
            
        }

        private void txtRutaExport_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblRutaExport_Click(object sender, EventArgs e)
        {

        }
    }
}
