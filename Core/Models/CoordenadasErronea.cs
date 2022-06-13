using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class CoordenadasErronea
    {
        public int IdCoordError { get; set; }
        public double? Latitud { get; set; }
        public double? Longitud { get; set; }
    }
}
