﻿using DevComponents.DotNetBar;
using FactAnalisis.Model;
using FactAnalisis.Util;
using FileHelpers;
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
    public partial class CargaArchivosForm : Office2007Form
    {
        ArchivosFacturacion archivosFact;
        public CargaArchivosForm()
        {
            InitializeComponent();
            archivosFact = ArchivosFacturacion.Instance;
            txtRutaFactBruta.Text = archivosFact.rutaFactBruta;
            txtRutaNotas.Text = archivosFact.rutaNotas;
            btnCargarFactBruta.Focus();
            MessageBoxEx.EnableGlass = false;

        }

        private void btnCargarFactBruta_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Filter = "CSV files (*.csv)|*.csv",
                InitialDirectory = @"C:\",
                Title = "Por favor, seleccione el archivo de Facturación Bruta."
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                LimpiarValidacionDeCampos();
                txtRutaFactBruta.Text = openFileDialog.FileName;

                try { 
                    var engine = new DelimitedFileEngine<BaseCSV>();
                    engine.Encoding = Encoding.UTF8;
                    var result = engine.ReadFile(txtRutaFactBruta.Text);
                }catch(ConvertException ex){
                    txtRutaFactBruta.Text = "";
                  MessageBoxEx.Show(this, "ERROR AL PROCESAR ARCHIVO. PUEDE QUE SE DEBA A QUE ALGUNA DE LA COLUMNAS TENGAN UN CARACTER '|' DE MAS.\nPOR FAVOR PONGASE EN CONTACTO CON OFIN.\n" + ex.Message + "\nNUMERO REGISTRO ERROR: " + ex.LineNumber , 
                       "ERROR DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCargarNotas_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Filter = "CSV files (*.csv)|*.csv",
                InitialDirectory = @"C:\",
                Title = "Por favor, seleccione el archivo de Notas."
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                LimpiarValidacionDeCampos();
                txtRutaNotas.Text = openFileDialog.FileName;
                try
                {
                    var engine = new FileHelperEngine<NotasCSV>();
                    engine.Encoding = Encoding.UTF8;
                    var result = engine.ReadFile(txtRutaNotas.Text);
                }
                catch (ConvertException ex)
                {
                    txtRutaNotas.Text = "";
                    MessageBoxEx.Show(this, "ERROR AL PROCESAR ARCHIVO. PUEDE QUE SE DEBA A QUE ALGUNA DE LA COLUMNAS TENGAN UN CARACTER '|' DE MAS.\nPOR FAVOR PONGASE EN CONTACTO CON OFIN.\n" + ex.Message + "\nNUMERO REGISTRO ERROR: " + ex.LineNumber,
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

            LimpiarValidacionDeCampos();
           
            archivosFact.rutaFactBruta = txtRutaFactBruta.Text;
            archivosFact.rutaNotas = txtRutaNotas.Text;
           
            DialogResult result = MessageBoxEx.Show(this,"Valores cargados correctamente","Información del sistema",MessageBoxButtons.OKCancel,MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
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
        }
    }
}
