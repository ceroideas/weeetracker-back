using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class EstadosRemesa
    {
        public EstadosRemesa()
        {
            Remesas = new HashSet<Remesa>();
        }

        public int PidEstadoRemesa { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Remesa> Remesas { get; set; }
    }
}
