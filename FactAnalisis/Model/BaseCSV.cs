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
        public string codudu;

        
        public int? escone;

        [FieldNullValue("")]
        public String codmed;

        
        public int? codcat;

        [FieldNullValue("")]
        public String nomcat;

        
        public string codtis;

        [FieldNullValue("")]
        public String codmof;

        [FieldConverter(ConverterKind.Date, "yyyy-MM-dd")]
        public DateTime? fleact;

        [FieldConverter(ConverterKind.Date, "yyyy-MM-dd")]
        public DateTime? fleant;

        
        public int? lecact;

        
        public int? lecant;

        
        public int? diflec;

        [FieldNullValue(0)]
        public int volfac;

        [FieldConverter(ConverterKind.Decimal, ".")]
        [FieldNullValue(typeof(decimal), "0")]
        public decimal imcafi;

        [FieldConverter(ConverterKind.Decimal, ".")]
        [FieldNullValue(typeof(decimal), "0")]
        public decimal imagua;

        [FieldConverter(ConverterKind.Decimal, ".")]
        [FieldNullValue(typeof(decimal), "0")]
        public decimal imalca;
    }
}
