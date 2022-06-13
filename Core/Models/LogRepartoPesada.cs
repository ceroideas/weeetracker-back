using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class LogRepartoPesada
    {
        public int PidLogRepartoPesadas { get; set; }
        public string Proceso { get; set; }
        public string Evento { get; set; }
        public DateTime? Fecha { get; set; }
    }
}
