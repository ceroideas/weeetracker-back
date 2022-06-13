using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class OriginalUltimasUbicacionesRaee
    {
        public int SidDireccionTercero { get; set; }
        public string PidRaee { get; set; }
        public int SidSig { get; set; }
        public int SidTipoEtiqueta { get; set; }
        public int SidResiduoEspecifico { get; set; }
        public int SidTipoContenedor { get; set; }
        public float? PesoEstimado { get; set; }
        public float? PesoReal { get; set; }
        public bool Canibalizado { get; set; }
        public int SidEstadoRaee { get; set; }
        public int? SidCertificadoTratamiento { get; set; }
        public int SidFraccion { get; set; }
        public int SidPaisCodigoRaee { get; set; }
        public int SidTerceroDestinatario { get; set; }
        public int? SidMarca { get; set; }
    }
}
