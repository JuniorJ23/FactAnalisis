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
    public partial class Analisis : Office2007Form
    {
        private ArchivosFacturacion archFact;
        private Configuracion config;

        ConexionSQLite conexion;

        public Analisis()
        {
            InitializeComponent();
            archFact = ArchivosFacturacion.Instance;
            config = Configuracion.Instance;

            MessageBoxEx.EnableGlass = false;

            btnGenerarFactNeta.Enabled = false;

          

        }

        private async void btnMergeFact_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(archFact.rutaFactBruta) || string.IsNullOrEmpty(archFact.rutaNotas))
            {

                MessageBoxEx.Show(this, "NO SE HAN ESCOGIDO LOS ARCHIVOS DE FACTURACION Y DE NOTAS. POR FAVOR SIRVASE SELECCIONARLOS EN EL MENU DE ARCHIVO.", "MENSAJE DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (string.IsNullOrEmpty(config.rutaSQLite))
            {
                MessageBoxEx.Show(this, "NO SE HA ESCOGIDO LA RUTA DONDE SE ENCUENTRA EL ARCHIVO DE BD.", "MENSAJE DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            pgbAnalisis.Visible = true;
            pgbAnalisis.Style = eDotNetBarStyle.Windows7 ;

            btnMergeFact.Enabled = false;
            await Task.Run(() =>
            {
                try { 
                    conexion = new ConexionSQLite(Path.Combine(config.rutaSQLite, "facturacion.db"));

                    var engineNotas = new FileHelperEngine<NotasCSV>();
                    NotasCSV[] resultNotas = engineNotas.ReadFile(archFact.rutaNotas);
                    conexion.InsertarRegistrosNotas(resultNotas);


                    var engineBase = new DelimitedFileEngine<BaseCSV>();
                    engineBase.Encoding = Encoding.UTF8;
                    BaseCSV[] resultBases = engineBase.ReadFile(archFact.rutaFactBruta);
                    conexion.InsertarRegistrosBase(resultBases);
                }catch(Exception ex)
                {
                    MessageBoxEx.Show(this, "ERROR AL GENERAR ARCHIVO.\n" +ex.Message, "ERROR DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            });

            //btnImport.Enabled = true;
            pgbAnalisis.Visible = false;

            MessageBoxEx.Show(this, "PROCESO COMPLETADO SATISFACTORIAMENTE", "MENSAJE DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);


            btnGenerarFactNeta.Enabled = true;


        }
    }
}
