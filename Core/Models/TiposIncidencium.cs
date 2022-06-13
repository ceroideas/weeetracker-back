using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class TiposIncidencium
    {
        public int PidTipoIncidencia { get; set; }
        public string Nombre { get; set; }
        public int? TipoNotificacion { get; set; }
    }
}
