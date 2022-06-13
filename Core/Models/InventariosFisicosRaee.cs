using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class InventariosFisicosRaee
    {
        public string PidInventarioFisicoRaee { get; set; }
        public string SidInventarioFisico { get; set; }
        public string SidRaee { get; set; }

        public virtual InventariosFisico SidInventarioFisicoNavigation { get; set; }
    }
}
