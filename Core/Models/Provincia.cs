using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class Provincia
    {
        public Provincia()
        {
            DireccionesTerceros = new HashSet<DireccionesTercero>();
            Municipios = new HashSet<Municipio>();
        }

        public int PidProvincia { get; set; }
        public string Nombre { get; set; }
        public int SidPais { get; set; }
        public int Estado { get; set; }
        public int? CodGtr { get; set; }
        public Guid Rowguid { get; set; }

        public virtual Paise SidPaisNavigation { get; set; }
        public virtual ICollection<DireccionesTercero> DireccionesTerceros { get; set; }
        public virtual ICollection<Municipio> Municipios { get; set; }
    }
}
