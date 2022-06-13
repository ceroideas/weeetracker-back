using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class TercerosTiposTercero
    {
        public int PidTerceroTipoTercero { get; set; }
        public int SidTercero { get; set; }
        public int SidTipoTercero { get; set; }
        public int Estado { get; set; }
        public Guid Rowguid { get; set; }

        public virtual Tercero SidTerceroNavigation { get; set; }
        public virtual TiposTercero SidTipoTerceroNavigation { get; set; }
    }
}
