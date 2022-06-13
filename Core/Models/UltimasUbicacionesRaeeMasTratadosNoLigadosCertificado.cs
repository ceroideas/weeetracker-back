using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class UltimasUbicacionesRaeeMasTratadosNoLigadosCertificado
    {
        public string SidRaee { get; set; }
        public int IdActivacion { get; set; }
        public string Activacion { get; set; }
        public string Estado { get; set; }
        public int SidEstadoRaee { get; set; }
        public string SidCertificado { get; set; }
        public string Tercero { get; set; }
        public int? SidTercero { get; set; }
        public string DireccionTercero { get; set; }
        public int? SidDireccionTercero { get; set; }
        public DateTime? Fecha { get; set; }
        public string Fraccion { get; set; }
        public int SidFraccion { get; set; }
        public string ResiduoEspecifico { get; set; }
        public int SidResiduoEspecifico { get; set; }
    }
}
