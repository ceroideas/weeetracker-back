using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class DireccionesTerceroPorTercero
    {
        public int SidTercero { get; set; }
        public int PidContactoDireccionTercero { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Contrasena { get; set; }
        public int SidDireccionTercero { get; set; }
    }
}
