using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class AndroidMaquina
    {
        public string Imei { get; set; }
        public string Maquina { get; set; }
        public int Gestor { get; set; }
        public int? Centro { get; set; }
    }
}
