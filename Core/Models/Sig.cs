using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class Sig
    {
        public Sig()
        {
            Certificados = new HashSet<Certificado>();
        }

        public int PidSig { get; set; }
        public string Nombre { get; set; }
        public int Estado { get; set; }

        public virtual ICollection<Certificado> Certificados { get; set; }
    }
}
