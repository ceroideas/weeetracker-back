using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class ResiduosEspecifico
    {
        public ResiduosEspecifico()
        {
            HistoricoCambioSidResiduoEspecificoAntesNavigations = new HashSet<HistoricoCambio>();
            HistoricoCambioSidResiduoEspecificoDespuesNavigations = new HashSet<HistoricoCambio>();
            Raees = new HashSet<Raee>();
        }

        public int PidResiduoEspecifico { get; set; }
        public string Nombre { get; set; }
        public float? PesoEstimado { get; set; }
        public int Estado { get; set; }
        public int? SidResiduo { get; set; }
        public int? SidFraccion { get; set; }
        public int? CodGtr { get; set; }
        public Guid Rowguid { get; set; }

        public virtual Fraccione SidFraccionNavigation { get; set; }
        public virtual Residuo SidResiduoNavigation { get; set; }
        public virtual ICollection<HistoricoCambio> HistoricoCambioSidResiduoEspecificoAntesNavigations { get; set; }
        public virtual ICollection<HistoricoCambio> HistoricoCambioSidResiduoEspecificoDespuesNavigations { get; set; }
        public virtual ICollection<Raee> Raees { get; set; }
    }
}
