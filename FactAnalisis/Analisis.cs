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

        ConexionPSQL conexion;
        

        public Analisis()
        {
            InitializeComponent();
            archFact = ArchivosFacturacion.Instance;
            config = Configuracion.Instance;

            MessageBoxEx.EnableGlass = false;
            
            conexion = new ConexionPSQL();

            if (archFact.GenerarFacturacinBruta)
            {
                btnMergeFact.Enabled = false;
            }
            else
            {
                conexion.LimpiarTablasBaseYNotas();
            }

            
        }


        private void LlenarComboDeObservacion()
        {
            
        }

        private async void btnMergeFact_Click(object sender, EventArgs e)
        {
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
                    conexion.InsertarRegistrosEnBaseFacturacion(resultBases);


                    notifyIcon1.Visible = true;
                    notifyIcon1.Icon = SystemIcons.Information;
                    notifyIcon1.BalloonTipTitle = "MENSAJE DEL SISTEMA";
                    notifyIcon1.BalloonTipText = "PROCESO COMPLETADO SATISFACTORIAMENTE.";
                    notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                    notifyIcon1.ShowBalloonTip(1000);

                    


                }
                catch(Exception ex)
                {
                    MessageBoxEx.Show(this, "ERROR AL GENERAR ARCHIVO.\n" +ex.Message, "ERROR DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            });

            FlashWindowHelper.Flash(this);
            //btnImport.Enabled = true;
            pgbAnalisis.Visible = false;
           // MessageBoxEx.Show(this, "PROCESO COMPLETADO SATISFACTORIAMENTE", "MENSAJE DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            archFact.GenerarFacturacinBruta = true;
            if (!archFact.GenerarFacturacionNeta)
            {
                btnGenerarFactNeta.Enabled = true;
            }
        }

        private async void btnGenerarFactNeta_Click(object sender, EventArgs e)
        {
            pgbAnalisis.Visible = true;
            pgbAnalisis.Style = eDotNetBarStyle.Windows7;
            btnGenerarFactNeta.Enabled = false;
            await Task.Run(()=>
            {
                try
                {
                    CheckForIllegalCrossThreadCalls = false;
                    conexion.GenerarFacturacionNeta();
                    conexion.InsertarNotas();
                    conexion.LimpiarNotasYVolumen();
                    conexion.CorregirDomestica2ElAlto();
                    notifyIcon1.Visible = true;
                    notifyIcon1.Icon = SystemIcons.Information;
                    notifyIcon1.BalloonTipTitle = "MENSAJE DEL SISTEMA";
                    notifyIcon1.BalloonTipText = "PROCESO COMPLETADO SATISFACTORIAMENTE.";
                    notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                    notifyIcon1.ShowBalloonTip(1000);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    MessageBoxEx.Show(this, "ERROR AL GENERAR FACTURACION NETA.\n" + ex.Message, "ERROR DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            });

            pgbAnalisis.Visible = false;
            //MessageBoxEx.Show(this, "PROCESO COMPLETADO SATISFACTORIAMENTE", "MENSAJE DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            buttonX1.Enabled = true;
            btnExportar.Enabled = true;
            archFact.GenerarFacturacionNeta = true;
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            buttonX1.Enabled = false;
       
                switch (cmbObservaciones.SelectedIndex)
                {
                    case 0:
                        dataGridBase.DataSource = conexion.ObtenerBaseCompleta();
                        txtTotalRegistros.Text = ""+dataGridBase.RowCount;
                        break;
                    case 1:
                        dataGridBase.DataSource = conexion.ObtenerSinCodigosDeUnidadDeUso();
                        txtTotalRegistros.Text = "" + dataGridBase.RowCount;
                        break;
                    case 2:
                        dataGridBase.DataSource = conexion.ObtenerServicioAguaActivoYConImportesAlcantarillado();
                        txtTotalRegistros.Text = "" + dataGridBase.RowCount;
                        if (dataGridBase.RowCount > 0) btnCorregir.Visible = true;
                        break;
                    case 3:
                        dataGridBase.DataSource = conexion.ObtenerActivosConImportes0PorRebajaYConVolumen();
                        txtTotalRegistros.Text = "" + dataGridBase.RowCount;
                        if (dataGridBase.RowCount > 0) btnCorregir.Visible = true;
                        break;
                    case 4:
                        dataGridBase.DataSource = conexion.ObtenerServicioAlcantarilladoActivoYConImportesAgua();
                        txtTotalRegistros.Text = "" + dataGridBase.RowCount;
                        if (dataGridBase.RowCount > 0) btnCorregir.Visible = true;
                        break;
                    case 5:
                        dataGridBase.DataSource = conexion.ObtenerCortadosConImportes();
                        txtTotalRegistros.Text = "" + dataGridBase.RowCount;
                        if (dataGridBase.RowCount > 0) btnCorregir.Visible = true;
                        break;
                    case 6:
                        dataGridBase.DataSource = conexion.ObtenerUsuariosConImportesYSinVolumen();
                        txtTotalRegistros.Text = "" + dataGridBase.RowCount;
                        if (dataGridBase.RowCount > 0) btnCorregir.Visible = true;
                        break;
                    case 7:
                        dataGridBase.DataSource = conexion.ObtenerUsuariosConVolumenYSinImportes();
                        txtTotalRegistros.Text = "" + dataGridBase.RowCount;
                        if (dataGridBase.RowCount > 0) btnCorregir.Visible = true;
                        break;

                    case 8:
                        dataGridBase.DataSource = conexion.ObtenerUsuariosActivosSinVolumenYSinImportes();
                        txtTotalRegistros.Text = "" + dataGridBase.RowCount;
                        if (dataGridBase.RowCount > 0) btnCorregir.Visible = true;
                        break;
                    default:
                        dataGridBase.DataSource = conexion.ObtenerBaseCompleta();
                        txtTotalRegistros.Text = "" + dataGridBase.RowCount;
                        break;
                }
            MessageBoxEx.Show(this, "PROCESO COMPLETADO SATISFACTORIAMENTE", "MENSAJE DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataGridBase.Visible = true;
            buttonX1.Enabled = true;
        }

        private void btnCorregir_Click(object sender, EventArgs e)
        {

            switch (cmbObservaciones.SelectedIndex)
            {
                case 3:
                    conexion.CorregirActivosConImportes0PorRebajaYConVolumen();
                    //MessageBoxEx.Show(this, "PROCESO COMPLETADO SATISFACTORIAMENTE", "MENSAJE DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnCorregir.Visible = false;
                    break;
                case 5:
                    conexion.CorregirCortadosConImportes();
                   // MessageBoxEx.Show(this, "PROCESO COMPLETADO SATISFACTORIAMENTE", "MENSAJE DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnCorregir.Visible = false;
                    break;
                case 6:
                    conexion.GenerarDesanalisis();
                    conexion.CorregirUsuariosConImportesYSinVolumen();
                    conexion.LimpiarNotasYVolumen();
                   // MessageBoxEx.Show(this, "PROCESO COMPLETADO SATISFACTORIAMENTE", "MENSAJE DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnCorregir.Visible = false;
                    break;
                case 7:
                    conexion.CorregirUsuariosConVolumenYSinImportes();
                    btnCorregir.Visible = false;
                    break;

                case 8:
                    conexion.CorregirObtenerUsuariosActivosSinVolumenYSinImportes();
                    btnCorregir.Visible = false;
                    break;

            }

            notifyIcon1.Visible = true;
            notifyIcon1.Icon = SystemIcons.Information;
            notifyIcon1.BalloonTipTitle = "MENSAJE DEL SISTEMA";
            notifyIcon1.BalloonTipText = "PROCESO COMPLETADO SATISFACTORIAMENTE.";
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.ShowBalloonTip(1000);

        }

        private async void btnExportar_Click(object sender, EventArgs e)
        {
            pgbAnalisis.Visible = true;
            pgbAnalisis.Style = eDotNetBarStyle.Windows7;

            btnExportar.Enabled = false;

            await Task.Run(()=>
            {
                try
                {
                    CheckForIllegalCrossThreadCalls = false;
                    conexion.NormalizarSegunSUNASS();
                    DataTable baseCompleta = conexion.ObtenerBaseCompleta();
                    baseCompleta.Columns.Remove("estado");
                    baseCompleta.Columns.Remove("ncargo");
                    baseCompleta.Columns.Remove("volalca");
                    baseCompleta.Columns.Remove("volagua");
                    baseCompleta.Columns.Remove("num_unidades");
                    baseCompleta.Columns.Remove("imalca_nuevo");
                    baseCompleta.Columns.Remove("imagua_nuevo");
                    baseCompleta.Columns.Remove("nvol");
                    baseCompleta.Columns.Remove("nimalca");
                    baseCompleta.Columns.Remove("nimagua");

                    DataSet toPass = new DataSet();
                    toPass.Tables.Add(baseCompleta);
                    DBFUtil.DataSetIntoDBF(archFact.RutaExportDBF, "base", toPass);

                    //MessageBoxEx.Show(this, "PROCESO COMPLETADO SATISFACTORIAMENTE", "MENSAJE DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    notifyIcon1.Visible = true;
                    notifyIcon1.Icon = SystemIcons.Information;
                    notifyIcon1.BalloonTipTitle = "MENSAJE DEL SISTEMA";
                    notifyIcon1.BalloonTipText = "ARCHIVO DBF GENERADO SATISFACTORIAMENTE.";
                    notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                    notifyIcon1.ShowBalloonTip(1000);
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex);
                    //MessageBoxEx.Show(this, "ERROR AL EXPORTAR ARCHIVO.\n" + ex.Message, "ERROR DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    notifyIcon1.Visible = true;
                    notifyIcon1.Icon = SystemIcons.Error;
                    notifyIcon1.BalloonTipTitle = "ERROR DEL SISTEMA";
                    notifyIcon1.BalloonTipText = "ERROR AL EXPORTAR ARCHIVO.\n" + ex.Message;
                    notifyIcon1.BalloonTipIcon = ToolTipIcon.Error;
                    notifyIcon1.ShowBalloonTip(1000);
                    return;
                }
            });

            pgbAnalisis.Visible = false;
            btnExportar.Enabled = true;
            

        }
    }
}
