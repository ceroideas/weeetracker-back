using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class ContactosDireccionTercero
    {
        public ContactosDireccionTercero()
        {
            DireccionesTerceroContactosDireccionTerceros = new HashSet<DireccionesTerceroContactosDireccionTercero>();
        }

        public int PidContactoDireccionTercero { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Contrasena { get; set; }
        public int Estado { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public int? SidTercero { get; set; }
        public int? CodGtr { get; set; }
        public bool? PerfilGvr { get; set; }
        public Guid Rowguid { get; set; }

        public virtual Tercero SidTerceroNavigation { get; set; }
        public virtual ICollection<DireccionesTerceroContactosDireccionTercero> DireccionesTerceroContactosDireccionTerceros { get; set; }
    }
}
