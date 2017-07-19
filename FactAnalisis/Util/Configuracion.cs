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

        public string Server { get; set; }
        public string Port { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }


        Configuracion()
        {
            Server = "127.0.0.1";
            Port = "5786";
            Username = "postgres";
            Password = "123456";
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
