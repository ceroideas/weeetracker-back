using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class InventariosFisico
    {
        public InventariosFisico()
        {
            InventariosFisicosRaees = new HashSet<InventariosFisicosRaee>();
        }

        public string PidInventarioFisico { get; set; }
        public DateTime Fecha { get; set; }
        public int SidTercero { get; set; }
        public int SidDireccionTercero { get; set; }
        public bool Auditor { get; set; }

        public virtual DireccionesTercero SidDireccionTerceroNavigation { get; set; }
        public virtual Tercero SidTerceroNavigation { get; set; }
        public virtual ICollection<InventariosFisicosRaee> InventariosFisicosRaees { get; set; }
    }
}
