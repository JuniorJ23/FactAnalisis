using DevComponents.DotNetBar;
using FactAnalisis.Model;
using FactAnalisis.Util;
using FileHelpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactAnalisis
{
    public partial class CargaArchivosForm : Office2007Form
    {
        ArchivosFacturacion archivosFact;
        String inDir = @"C:\";
        public CargaArchivosForm()
        {
            InitializeComponent();
            archivosFact = ArchivosFacturacion.Instance;
            txtRutaFactBruta.Text = archivosFact.rutaFactBruta;
            txtRutaNotas.Text = archivosFact.rutaNotas;
            txtRutaExport.Text = archivosFact.RutaExportDBF;
            btnCargarFactBruta.Focus();
            MessageBoxEx.EnableGlass = false;
            

        }

        private void btnCargarFactBruta_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Filter = "CSV files (*.csv)|*.csv",
                InitialDirectory = inDir,
                Title = "INNCODE || ---> SELECCIONE EL ARCHIVO"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                LimpiarValidacionDeCampos();
                txtRutaFactBruta.Text = openFileDialog.FileName;
                string fullPath = openFileDialog.FileName;
                inDir = @fullPath.Substring(0, fullPath.LastIndexOf('\\'));
                txtRutaExport.Text = inDir;

                try { 
                    var engine = new DelimitedFileEngine<BaseCSV>();
                    engine.Encoding = Encoding.UTF8;
                    var result = engine.ReadFile(txtRutaFactBruta.Text);
                }catch(ConvertException ex){
                    txtRutaFactBruta.Text = "";
                  MessageBoxEx.Show(this, "ERROR AL PROCESAR ARCHIVO. PUEDE QUE SE DEBA A QUE ALGUNA DE LA COLUMNAS TENGAN UN CARACTER '|' DE MAS.\nPOR FAVOR PONGASE EN CONTACTO CON OFIN.\n" + ex.Message + "\nNUMERO REGISTRO ERROR: " + ex.LineNumber , 
                       "ERROR DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }catch(IOException ex)
                {
                    txtRutaFactBruta.Text = "";
                    MessageBoxEx.Show(this, "NO SE PUEDE TENER ACCESO AL ARCHIVO PORQUE ESTÁ SIENDO UTILIZADO POR OTRO POGRAMA.\n" + ex.Message,
                         "ERROR DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCargarNotas_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Filter = "CSV files (*.csv)|*.csv",
                InitialDirectory = inDir,
                Title = "Por favor, seleccione el archivo de Notas."
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                LimpiarValidacionDeCampos();
                txtRutaNotas.Text = openFileDialog.FileName;
                string fullPath = openFileDialog.FileName;
                inDir = @fullPath.Substring(0, fullPath.LastIndexOf('\\'));
                txtRutaExport.Text = inDir;

                try
                {
                    var engine = new FileHelperEngine<NotasCSV>();
                    engine.Encoding = Encoding.UTF8;
                    var result = engine.ReadFile(txtRutaNotas.Text);
                }
                catch (ConvertException ex)
                {
                    txtRutaNotas.Text = "";
                    MessageBoxEx.Show(this, "ERROR AL PROCESAR ARCHIVO. PUEDE QUE SE DEBA A QUE ALGUNA DE LA COLUMNAS TENGAN UN CARACTER '|' DE MAS.\nPOR FAVOR PONGASE EN CONTACTO CON OFIN.\n" + ex.Message + "\nNUMERO DE FILA CON ERROR: " + ex.LineNumber,
                         "ERROR DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (IOException ex)
                {
                    txtRutaNotas.Text = "";
                    MessageBoxEx.Show(this, "NO SE PUEDE TENER ACCESO AL ARCHIVO PORQUE ESTÁ SIENDO UTILIZADO POR OTRO POGRAMA.\n" + ex.Message,
                         "ERROR DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtRutaFactBruta.Text))
            {
                validatorCargaForm.ErrorProvider.SetError(txtRutaFactBruta,"Complete el campo de ruta de Facturacion Bruta");
                validatorCargaForm.Highlighter.SetHighlightColor(txtRutaFactBruta, DevComponents.DotNetBar.Validator.eHighlightColor.Orange);
                return;
            }


            if (string.IsNullOrEmpty(txtRutaNotas.Text))
            {
                validatorCargaForm.ErrorProvider.SetError(txtRutaNotas, "Complete el campo de ruta de Notas");
                validatorCargaForm.Highlighter.SetHighlightColor(txtRutaNotas, DevComponents.DotNetBar.Validator.eHighlightColor.Orange);
                return;
            }

            if (String.IsNullOrEmpty(txtRutaExport.Text))
            {
                validatorCargaForm.ErrorProvider.SetError(txtRutaExport, "Complete el campo de exportación de DBF");
                validatorCargaForm.Highlighter.SetHighlightColor(txtRutaExport, DevComponents.DotNetBar.Validator.eHighlightColor.Orange);
                return;
            }

            LimpiarValidacionDeCampos();
           
            archivosFact.rutaFactBruta = txtRutaFactBruta.Text;
            archivosFact.rutaNotas = txtRutaNotas.Text;
            archivosFact.RutaExportDBF = txtRutaExport.Text;
           
            DialogResult result = MessageBoxEx.Show(this,"VALORES CARGADOS CORRECTAMENTE","INFORMACION DEL SISTEMA",MessageBoxButtons.OKCancel,MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            if(result == DialogResult.OK)
            {
                Close();
            }
           
        }


        private void LimpiarValidacionDeCampos()
        {
            validatorCargaForm.ErrorProvider.SetError(txtRutaFactBruta, null);
            validatorCargaForm.Highlighter.SetHighlightColor(txtRutaFactBruta, DevComponents.DotNetBar.Validator.eHighlightColor.None);

            validatorCargaForm.ErrorProvider.SetError(txtRutaNotas, null);
            validatorCargaForm.Highlighter.SetHighlightColor(txtRutaNotas, DevComponents.DotNetBar.Validator.eHighlightColor.None);

            validatorCargaForm.ErrorProvider.SetError(txtRutaExport, null);
            validatorCargaForm.Highlighter.SetHighlightColor(txtRutaExport, DevComponents.DotNetBar.Validator.eHighlightColor.None);
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
    }
}
