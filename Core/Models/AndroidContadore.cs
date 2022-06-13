using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class AndroidContadore
    {
        public string Maquina { get; set; }
        public int ContCertificado { get; set; }
        public int ContRaeesCertificado { get; set; }
        public int ContFirmasCertificado { get; set; }
        public int ContFotosRaeesCertificado { get; set; }
        public int ContServicio { get; set; }
    }
}
