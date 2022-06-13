using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class VideosRaee
    {
        public int PidVideoRaee { get; set; }
        public int? TipoEtiqueta { get; set; }
        public string SidRaee { get; set; }
        public string NombreFichero { get; set; }
        public DateTime? Fecha { get; set; }
        public string Hora { get; set; }

        public virtual Raee SidRaeeNavigation { get; set; }
    }
}
