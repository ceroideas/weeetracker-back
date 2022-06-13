using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class TiposCertificado
    {
        public TiposCertificado()
        {
            Certificados = new HashSet<Certificado>();
        }

        public int PidTipoCertificado { get; set; }
        public string Nombre { get; set; }
        public string Sigla { get; set; }

        public virtual ICollection<Certificado> Certificados { get; set; }
    }
}
