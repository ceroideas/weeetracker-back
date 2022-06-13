using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class RaeetratadoPorDiaPorGestor
    {
        public DateTime? Fecha { get; set; }
        public int? NumeroRaeetratado { get; set; }
        public int? NumeroRaeetratadoConVideo { get; set; }
        public int SidTercero { get; set; }
        public string Nombre { get; set; }
    }
}
