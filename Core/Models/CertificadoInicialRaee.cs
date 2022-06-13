using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class CertificadoInicialRaee
    {
        public int SidEstadoRaee { get; set; }
        public int SidTercero { get; set; }
        public int SidDireccionTercero { get; set; }
        public string SidRaee { get; set; }
        public string SidCertificado { get; set; }
        public DateTime Fecha { get; set; }
        public int? SuperiorAnyo { get; set; }
    }
}
