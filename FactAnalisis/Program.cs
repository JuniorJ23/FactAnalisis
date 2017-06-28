using FactAnalisis.Util;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactAnalisis
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            AppDomain.CurrentDomain.ProcessExit += new EventHandler(OnProcessExit);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Principal());
        }

        static void OnProcessExit(object sender, EventArgs e)
        {
            Configuracion config = Configuracion.Instance;
            if (!string.IsNullOrEmpty(config.rutaSQLite))
            {
                ConexionSQLite conexion = new ConexionSQLite(Path.Combine(config.rutaSQLite,"facturacion.db"));
                conexion.LimpiarTablasBaseYNotas();
            }
            
        }
    }
}
