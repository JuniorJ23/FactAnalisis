using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactAnalisis.Model
{
    public class BaseBD
    {
        public int codreg { get; set; }

        public int nuanio { get; set; }

        public int nummes { get; set; }

        public int codeps { get; set; }

        public int codamb { get; set; }

        public int codloc { get; set; }

        public String nomloc { get; set; }

        public String nomusu { get; set; }

        public String codcon { get; set; }

        public string codudu { get; set; }

        public int escone { get; set; }

        public String codmed { get; set; }

        public int codcat { get; set; }

        public String nomcat { get; set; }

        public string codtis { get; set; }

        public String codmof { get; set; }

        public DateTime? fleact { get; set; }

        public DateTime? fleant { get; set; }

        public int lecact { get; set; }

        public int lecant { get; set; }

        public int diflec { get; set; }

        public double volfac { get; set; }

        public double imcafi { get; set; }

        public double imagua { get; set; }

        public double imalca { get; set; }

        public double nimagua { get; set; }

        public double nimalca { get; set; }

        public int nvol { get; set; }

        public double imagua_nuevo { get; set; }

        public double imalca_nuevo { get; set; }

        public int num_unidades { get; set; }

        public double volagua { get; set; }

        public double volalca { get; set; }

        public double ncargo { get; set; }

        public bool estado { get; set; }
    }
}
