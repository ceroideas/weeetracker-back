using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class TiposContenedor
    {
        public TiposContenedor()
        {
            HistoricoCambioSidTipoDeContenedorAntesNavigations = new HashSet<HistoricoCambio>();
            HistoricoCambioSidTipoDeContenedorDespuesNavigations = new HashSet<HistoricoCambio>();
            Raees = new HashSet<Raee>();
        }

        public int PidTipoContenedor { get; set; }
        public string Nombre { get; set; }
        public int Estado { get; set; }
        public float? Tara { get; set; }
        public int? CodGtr { get; set; }
        public Guid Rowguid { get; set; }

        public virtual ICollection<HistoricoCambio> HistoricoCambioSidTipoDeContenedorAntesNavigations { get; set; }
        public virtual ICollection<HistoricoCambio> HistoricoCambioSidTipoDeContenedorDespuesNavigations { get; set; }
        public virtual ICollection<Raee> Raees { get; set; }
    }
}
