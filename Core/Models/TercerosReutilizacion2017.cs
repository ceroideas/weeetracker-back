using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class TercerosReutilizacion2017
    {
        public int SidTercero { get; set; }
        public int SidDireccionTercero { get; set; }
        public DateTime FechaTratamientosReutilizar { get; set; }

        public virtual DireccionesTercero SidDireccionTerceroNavigation { get; set; }
        public virtual Tercero SidTerceroNavigation { get; set; }
    }
}
