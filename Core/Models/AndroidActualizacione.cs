using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class AndroidActualizacione
    {
        public DateTime? FechaCambioUsuarios { get; set; }
        public DateTime? FechaCambioCentro { get; set; }
        public DateTime? FechaCambioResiduos { get; set; }
        public DateTime? FechaCambioMarcas { get; set; }
        public int? SidTercero { get; set; }
    }
}
