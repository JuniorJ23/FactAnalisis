using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileHelpers;

namespace FactAnalisis.Model
{
    [IgnoreFirst(1)] 
    [DelimitedRecord("|")]
    public class BaseCSV
    {
        public int codreg;

        public int nuanio;

        public int nummes;

        public int codeps;

        public int codamb;

        public int codloc;

        public String nomloc;

        public String nomusu;

        public String codcon;

        [FieldNullValue("")]
        public String codudu;

        [FieldNullValue(0)]
        public int escone;

        [FieldNullValue("")]
        public String codmed;

        [FieldNullValue(0)]
        public int codcat;

        [FieldNullValue("")]
        public String nomcat;

        [FieldNullValue(0)]
        public int codtis;

        [FieldNullValue("")]
        public String codmof;

        [FieldConverter(ConverterKind.Date, "yyyy-MM-dd")]
        [FieldNullValue(typeof(DateTime), "1900-01-01")]
        public DateTime fleact;

        [FieldConverter(ConverterKind.Date, "yyyy-MM-dd")]
        [FieldNullValue(typeof(DateTime), "1900-01-01")]
        public DateTime fleant;

        [FieldNullValue(0)]
        public int lecact;

        [FieldNullValue(0)]
        public int lecant;

        [FieldNullValue(0)]
        public int diflec;

        [FieldNullValue(0)]
        public int volfac;

        [FieldNullValue(typeof(decimal), "0")]
        public decimal imcafi;

        [FieldNullValue(typeof(decimal), "0")]
        public decimal imagua;

        [FieldNullValue(typeof(decimal), "0")]
        public decimal imalca;
    }
}
