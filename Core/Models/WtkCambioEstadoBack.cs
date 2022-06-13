using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class WtkCambioEstadoBack
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public string SidRaee { get; set; }
        public string SidCertificado { get; set; }
        public int SidEstado { get; set; }
        public int? SidTercero { get; set; }
        public int? SidDireccionTercero { get; set; }
        public double? GpsX { get; set; }
        public double? GpsY { get; set; }
        public double? GpsZ { get; set; }
        public string Albaran { get; set; }
        public int? SidUsuario { get; set; }
    }
}
