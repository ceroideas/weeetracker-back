using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class EstadosRaee
    {
        public EstadosRaee()
        {
            HistoricoCambioSidEstadoAntesNavigations = new HashSet<HistoricoCambio>();
            HistoricoCambioSidEstadoDespuesNavigations = new HashSet<HistoricoCambio>();
            Raees = new HashSet<Raee>();
            WtkCambioEstados = new HashSet<WtkCambioEstado>();
        }

        public int PidEstadoRaee { get; set; }
        public string Nombre { get; set; }
        public int? Orden { get; set; }

        public virtual ICollection<HistoricoCambio> HistoricoCambioSidEstadoAntesNavigations { get; set; }
        public virtual ICollection<HistoricoCambio> HistoricoCambioSidEstadoDespuesNavigations { get; set; }
        public virtual ICollection<Raee> Raees { get; set; }
        public virtual ICollection<WtkCambioEstado> WtkCambioEstados { get; set; }
    }
}
