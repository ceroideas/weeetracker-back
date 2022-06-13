using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class CertificadoInicialRaeesConDireccion
    {
        public string SidRaee { get; set; }
        public int SidEstadoRaee { get; set; }
        public string SidCertificado { get; set; }
        public DateTime FechaCertificado { get; set; }
        public int? SidTercero { get; set; }
        public int? SidDireccionTercero { get; set; }
        public string Nombre { get; set; }
        public string Provincia { get; set; }
        public string Municipio { get; set; }
        public string Direccion { get; set; }
    }
}
