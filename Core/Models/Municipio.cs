using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class Municipio
    {
        public Municipio()
        {
            DireccionesTerceros = new HashSet<DireccionesTercero>();
        }

        public int PidMunicipio { get; set; }
        public string Nombre { get; set; }
        public int SidProvincia { get; set; }
        public int Estado { get; set; }
        public int? CodGtr { get; set; }
        public Guid Rowguid { get; set; }

        public virtual Provincia SidProvinciaNavigation { get; set; }
        public virtual ICollection<DireccionesTercero> DireccionesTerceros { get; set; }
    }
}
