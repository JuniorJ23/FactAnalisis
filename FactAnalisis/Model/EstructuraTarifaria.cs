using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactAnalisis.Model
{
    public class EstructuraTarifariaModel
    {
        public int ID { get; set; }
        public int IDGrupo { get; set; }
        public int IDCategoria { get; set; }
        public int IDRango { get; set; }
        public int IDPeriodo { get; set; }
        public double CargoFijo { get; set; }
        public double Agua { get; set; }
        public double Alcantarillado { get; set; }
    }
}
