using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class Role
    {
        public Role()
        {
            Usuarios = new HashSet<Usuario>();
            SidPermisos = new HashSet<Permiso>();
        }

        public int PidRol { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Usuario> Usuarios { get; set; }

        public virtual ICollection<Permiso> SidPermisos { get; set; }
    }
}
