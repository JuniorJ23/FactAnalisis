using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactAnalisis.Util
{
    public sealed class Configuracion
    {
        private static Configuracion instance = null;
        private static readonly object padlock = new object();


        public string rutaSQLite { get; set; }
        public string rutaExportDBF { get; set; }


        Configuracion()
        {
            rutaSQLite = "";
            rutaExportDBF = "";
        }

        public static Configuracion Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new Configuracion();
                    }
                    return instance;
                }
            }
        }


    }
}
