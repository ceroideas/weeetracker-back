using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class Residuo
    {
        public Residuo()
        {
            Raees = new HashSet<Raee>();
            ResiduosEspecificos = new HashSet<ResiduosEspecifico>();
        }

        public int PidResiduo { get; set; }
        public int SidFraccion { get; set; }
        public int Estado { get; set; }
        public string Nombre { get; set; }
        public int? CodGtr { get; set; }
        public Guid Rowguid { get; set; }

        public virtual Fraccione SidFraccionNavigation { get; set; }
        public virtual ICollection<Raee> Raees { get; set; }
        public virtual ICollection<ResiduosEspecifico> ResiduosEspecificos { get; set; }
    }
}
