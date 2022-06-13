using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class FirmasCertificado
    {
        public FirmasCertificado()
        {
            CertificadoSidFirmaDestinoNavigations = new HashSet<Certificado>();
            CertificadoSidFirmaProcedenciaNavigations = new HashSet<Certificado>();
            CertificadoSidFirmaTransporteNavigations = new HashSet<Certificado>();
        }

        public string PidFirmaCertificado { get; set; }
        public string Firma { get; set; }
        public string Nombre { get; set; }
        public string Cargo { get; set; }

        public virtual ICollection<Certificado> CertificadoSidFirmaDestinoNavigations { get; set; }
        public virtual ICollection<Certificado> CertificadoSidFirmaProcedenciaNavigations { get; set; }
        public virtual ICollection<Certificado> CertificadoSidFirmaTransporteNavigations { get; set; }
    }
}
