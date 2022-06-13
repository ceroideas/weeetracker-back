using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class TiposDestino
    {
        public TiposDestino()
        {
            Raees = new HashSet<Raee>();
        }

        public int PidTipoDestino { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Raee> Raees { get; set; }
    }
}
