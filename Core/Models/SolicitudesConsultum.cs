using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class SolicitudesConsultum
    {
        public int PidSolicitud { get; set; }
        public DateTime Fecha { get; set; }
        public int SidTerceroOrigen { get; set; }
        public string TerceroOrigen { get; set; }
        public int SidTerceroDestino { get; set; }
        public string TerceroDestino { get; set; }
        public int SidDireccionTerceroOrigen { get; set; }
        public string DireccionTerceroOrigen { get; set; }
        public int? SidDireccionTerceroDestino { get; set; }
        public int Estado { get; set; }
        public string AlbaranOrigen { get; set; }
    }
}
