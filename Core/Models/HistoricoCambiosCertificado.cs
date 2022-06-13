using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class HistoricoCambiosCertificado
    {
        public int PidHistoricoCambioCertificado { get; set; }
        public DateTime? Fecha { get; set; }
        public string SidCertificado { get; set; }
        public int? SidEstadoAntes { get; set; }
        public int? SidEstadoDespues { get; set; }

        public virtual Certificado SidCertificadoNavigation { get; set; }
        public virtual EstadosCertificado SidEstadoAntesNavigation { get; set; }
        public virtual EstadosCertificado SidEstadoDespuesNavigation { get; set; }
    }
}
