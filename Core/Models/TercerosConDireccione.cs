using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class TercerosConDireccione
    {
        public int PidTercero { get; set; }
        public string Nombre { get; set; }
        public string Nif { get; set; }
        public string Direccion { get; set; }
        public string Municipio { get; set; }
        public string Provincia { get; set; }
        public string Tipotercero { get; set; }
    }
}
