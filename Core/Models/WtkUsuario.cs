using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class WtkUsuario
    {
        public WtkUsuario()
        {
            WtkCambioEstados = new HashSet<WtkCambioEstado>();
            SidDireccions = new HashSet<DireccionesTercero>();
            SidPerfils = new HashSet<WtkPerfil>();
        }

        public int Id { get; set; }
        public string Usuario { get; set; }
        public string Password { get; set; }
        public int SidTercero { get; set; }
        public int SidTipoTercero { get; set; }
        public int Estado { get; set; }

        public virtual Tercero SidTerceroNavigation { get; set; }
        public virtual TiposTercero SidTipoTerceroNavigation { get; set; }
        public virtual ICollection<WtkCambioEstado> WtkCambioEstados { get; set; }

        public virtual ICollection<DireccionesTercero> SidDireccions { get; set; }
        public virtual ICollection<WtkPerfil> SidPerfils { get; set; }
    }
}
