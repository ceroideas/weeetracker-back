using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class ReportingStock
    {
        public int SidTercero { get; set; }
        public string Tercero { get; set; }
        public int SidDireccionTercero { get; set; }
        public string NombreDireccion { get; set; }
        public string Municipio { get; set; }
        public string Provincia { get; set; }
        public int SidEstadoRaee { get; set; }
        public string Estado { get; set; }
        public int SidFraccion { get; set; }
        public string Fraccion { get; set; }
        public int IdActivacion { get; set; }
        public string Activacion { get; set; }
        public int? Total { get; set; }
    }
}
