using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileHelpers;

namespace FactAnalisis.Model
{
    [DelimitedRecord("|")]
    public class NotasCSV
    {
        [FieldConverter(ConverterKind.Date, "yyyy-MM-dd")]
        public DateTime fecha_emision;

        public String num_inscripcion;

        public int id_provincia;

        public int id_distrito;

        [FieldNullValue("")]
        public String nota_serie;

        [FieldNullValue("")]
        public String nota_codigo;

        [FieldNullValue("")]
        public String nota_verificacoion;

        [FieldNullValue("")]
        public String estado_nota;

        [FieldNullValue("")]
        public String refac_serie;

        [FieldNullValue("")]
        public String refac_codigo;

        [FieldNullValue("")]
        public String refa_verificacion;

        [FieldNullValue("")]
        public String estado_recibo;

        [FieldNullValue("")]
        public String tipo_nota;

        [FieldNullValue(0)]
        public int volumen_agua_facturado;

        [FieldNullValue(0)]
        public int volumen_desague_facturado;

        [FieldNullValue(0)]
        public int volumen_agua_nota;

        [FieldNullValue(0)]
        public int volumen_desague_nota;

        [FieldNullValue(typeof(decimal), "0")]
        public decimal importe_agua_facturado;

        [FieldNullValue(typeof(decimal), "0")]
        public decimal importe_desague_facturado;

        [FieldNullValue(typeof(decimal), "0")]
        public decimal importe_cuenta_agua_nota;

        [FieldNullValue(typeof(decimal), "0")]
        public decimal importe_cuenta_desague_nota;

        [FieldNullValue(typeof(decimal), "0")]
        public decimal importe_cuenta_cargo_fijo_nota;
    }
}
