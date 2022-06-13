using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class WtkCambioEstadoFotografium
    {
        public int Id { get; set; }
        public int? SidCambioEstado { get; set; }
        public string Fichero { get; set; }

        public virtual WtkCambioEstado SidCambioEstadoNavigation { get; set; }
    }
}
