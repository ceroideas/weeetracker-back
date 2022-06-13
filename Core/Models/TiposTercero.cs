using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class TiposTercero
    {
        public TiposTercero()
        {
            DireccionesTerceroTiposTerceros = new HashSet<DireccionesTerceroTiposTercero>();
            TercerosTiposTerceros = new HashSet<TercerosTiposTercero>();
            WtkUsuarios = new HashSet<WtkUsuario>();
        }

        public int PidTipoTercero { get; set; }
        public string Nombre { get; set; }
        public int Estado { get; set; }

        public virtual ICollection<DireccionesTerceroTiposTercero> DireccionesTerceroTiposTerceros { get; set; }
        public virtual ICollection<TercerosTiposTercero> TercerosTiposTerceros { get; set; }
        public virtual ICollection<WtkUsuario> WtkUsuarios { get; set; }
    }
}
