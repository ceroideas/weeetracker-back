using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class NumeroRaeeporDium
    {
        public DateTime? Fecha { get; set; }
        public int? NumeroRaeeentradoEnSistema { get; set; }
        public int NumeroRaeetratado { get; set; }
        public int NumeroRaeetratadoConVideo { get; set; }
        public int? NumeroRaeetratadoSinVideo { get; set; }
    }
}
