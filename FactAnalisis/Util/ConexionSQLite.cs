using Devart.Data.SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactAnalisis.Util
{
    public class ConexionSQLite
    {
        private SQLiteConnection Connection;

        public ConexionSQLite(string ruta)
        {
            ConnectToDatabase(ruta);
        }

        private void ConnectToDatabase(string ruta)
        {
            Connection = new SQLiteConnection("Data Source=" + ruta);
            Connection.Open();
        }

    }
}
