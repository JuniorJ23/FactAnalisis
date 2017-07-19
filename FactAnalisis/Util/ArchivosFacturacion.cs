using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactAnalisis.Util
{
    public sealed class ArchivosFacturacion
    {
        private static ArchivosFacturacion instance = null;
        private static readonly object padlock = new object();


        public string rutaFactBruta { get; set; } 
        public string rutaNotas { get; set; }
        public string RutaExportDBF { get; set; }

        public bool GenerarFacturacinBruta { get; set; } = false;
        public bool GenerarFacturacionNeta { get; set; } = false;


        ArchivosFacturacion()
        {
            rutaFactBruta = "";
            rutaNotas = "";
            RutaExportDBF = "";
        }

         public static ArchivosFacturacion Instance
        {
            get
            {
                lock (padlock)
                {
                    if(instance == null)
                    {
                        instance = new ArchivosFacturacion();
                    }
                    return instance;
                }
            }
        }


    }
}
