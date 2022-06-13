using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class Paise
    {
        public Paise()
        {
            DireccionesTerceros = new HashSet<DireccionesTercero>();
            Provincia = new HashSet<Provincia>();
        }

        public int PidPais { get; set; }
        public string Nombre { get; set; }
        public int Estado { get; set; }
        public string Codigo { get; set; }
        public int? CodGtr { get; set; }
        public Guid Rowguid { get; set; }

        public virtual ICollection<DireccionesTercero> DireccionesTerceros { get; set; }
        public virtual ICollection<Provincia> Provincia { get; set; }
    }
}
