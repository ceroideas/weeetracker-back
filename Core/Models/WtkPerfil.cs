using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class WtkPerfil
    {
        public WtkPerfil()
        {
            SidUsuarios = new HashSet<WtkUsuario>();
        }

        public string Id { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<WtkUsuario> SidUsuarios { get; set; }
    }
}
