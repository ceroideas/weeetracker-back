using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class EstadosCertificado
    {
        public EstadosCertificado()
        {
            Certificados = new HashSet<Certificado>();
            HistoricoCambiosCertificadoSidEstadoAntesNavigations = new HashSet<HistoricoCambiosCertificado>();
            HistoricoCambiosCertificadoSidEstadoDespuesNavigations = new HashSet<HistoricoCambiosCertificado>();
        }

        public int PidEstadoCertificado { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Certificado> Certificados { get; set; }
        public virtual ICollection<HistoricoCambiosCertificado> HistoricoCambiosCertificadoSidEstadoAntesNavigations { get; set; }
        public virtual ICollection<HistoricoCambiosCertificado> HistoricoCambiosCertificadoSidEstadoDespuesNavigations { get; set; }
    }
}
