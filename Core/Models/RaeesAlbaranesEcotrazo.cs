using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class RaeesAlbaranesEcotrazo
    {
        public int PidRaeesAlbaranesEcotrazo { get; set; }
        public string SidRaee { get; set; }
        public string SidCertificado { get; set; }
        public string AlbaranEcotrazo { get; set; }
        public DateTime Fecha { get; set; }

        public virtual Certificado SidCertificadoNavigation { get; set; }
        public virtual Raee SidRaeeNavigation { get; set; }
    }
}
