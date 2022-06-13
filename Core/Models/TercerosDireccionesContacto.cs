using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class TercerosDireccionesContacto
    {
        public int PidTercero { get; set; }
        public string TercerosNombre { get; set; }
        public string Nif { get; set; }
        public int? PidDireccionTercero { get; set; }
        public string Direccion { get; set; }
        public string CodigoPostal { get; set; }
        public string ProvinciasNombre { get; set; }
        public string MunicipiosNombre { get; set; }
        public int? PidContactoDireccionTercero { get; set; }
        public string ContactosDireccionTerceroNombre { get; set; }
        public string Apellidos { get; set; }
        public string Centro { get; set; }
        public int EstadoTercero { get; set; }
        public int? EstadoDirecciónTercero { get; set; }
        public int? EstadoContactoTercero { get; set; }
    }
}
