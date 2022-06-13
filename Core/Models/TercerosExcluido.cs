using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class TercerosExcluido
    {
        public int PidTerceroExcluido { get; set; }
        public int SidTercero { get; set; }

        public virtual Tercero SidTerceroNavigation { get; set; }
    }
}
