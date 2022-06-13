using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class ConsultaContactosPorCentro
    {
        public int PidContactoDireccionTercero { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Contrasena { get; set; }
        public int SidDireccionTercero { get; set; }
    }
}
