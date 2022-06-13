using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class ControlEtiquetasConsultum
    {
        public int SidTercero { get; set; }
        public int SidDireccionTercero { get; set; }
        public string Nombre { get; set; }
        public string Nif { get; set; }
        public int? TotEntregados { get; set; }
        public int? TotPerdidos { get; set; }
        public int? TotConsumidos { get; set; }
        public int TodasRemesas { get; set; }
    }
}
