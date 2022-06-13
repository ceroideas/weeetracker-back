using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class Permiso
    {
        public Permiso()
        {
            SidRols = new HashSet<Role>();
        }

        public int PidPermiso { get; set; }
        public string Nombre { get; set; }
        public string Codigo { get; set; }

        public virtual ICollection<Role> SidRols { get; set; }
    }
}
