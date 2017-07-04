using DevComponents.DotNetBar;
using FactAnalisis.Model;
using FactAnalisis.Util;
using FileHelpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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


            if (archFact.insertadasEnBD)
            {
                btnMergeFact.Enabled = false;
                if (archFact.notasInsertadasEnBD)
                {
                    btnGenerarFactNeta.Enabled = false;
                }
                else
                {
                    btnGenerarFactNeta.Enabled = true;
                }
            }
            else
            {
                btnMergeFact.Enabled = true;
                btnGenerarFactNeta.Enabled = false;
            }

            if (!string.IsNullOrEmpty(config.rutaSQLite)) { 
            conexion = new ConexionSQLite(Path.Combine(config.rutaSQLite, "facturacion.db"));
            }
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
                    CheckForIllegalCrossThreadCalls = false;



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
                    return;
                }

            });

            //btnImport.Enabled = true;
            pgbAnalisis.Visible = false;
            MessageBoxEx.Show(this, "PROCESO COMPLETADO SATISFACTORIAMENTE", "MENSAJE DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnGenerarFactNeta.Enabled = true;
            archFact.insertadasEnBD = true;
            
        }

        private async void btnGenerarFactNeta_Click(object sender, EventArgs e)
        {
            btnGenerarFactNeta.Enabled = false;
            pgbAnalisis.Visible = true;

            await Task.Run(()=>
            {
                CheckForIllegalCrossThreadCalls = false;
                List<BaseBD> lista = conexion.ObtenerTodaLaBase();
                

                Stopwatch sw = new Stopwatch();
                sw.Start();
                //lista = Procesamiento.Analisis(conexion, 3, lista);
                lista = AgregarNumeroDeUnidadesDeUso(lista);
                //conexion.ActualizarBase(lista);
                
                //conexion.ActualizarTipoDeConexion();
                sw.Stop();

                TimeSpan elapsedTime = sw.Elapsed;
                Console.WriteLine("Tiempo de demora en el Recorrer la lista y modificar solo algunos valores: " + elapsedTime.ToString());


            });
            pgbAnalisis.Visible = false;
            MessageBoxEx.Show(this, "PROCESO COMPLETADO SATISFACTORIAMENTE", "MENSAJE DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btnGenerarFactNeta.Enabled = false;
            archFact.notasInsertadasEnBD = true;
            buttonX1.Enabled = true;
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            dataGridBase.Visible = true;
            dataGridBase.DataSource = conexion.ObtenerTodaBase();
        }

        private List<BaseBD> AgregarNumeroDeUnidadesDeUso(List<BaseBD> lista)
        {
            var groups = lista.GroupBy(x => new { x.codcon })
                        .Select(group => new{Name = group.Key.codcon, Count = group.Count() });

            foreach (var x in groups)
            {
                Console.WriteLine(x.Count + " " + x.Name);
            }
            return lista;
        }
    }
}
