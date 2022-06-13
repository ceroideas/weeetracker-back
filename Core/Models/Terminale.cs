using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class Terminale
    {
        public int SidTercero { get; set; }
        public int SidDireccion { get; set; }
        public string Terminal { get; set; }

        public virtual DireccionesTercero SidDireccionNavigation { get; set; }
        public virtual Tercero SidTerceroNavigation { get; set; }
    }
}
