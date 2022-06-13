using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class ReportingRaeesgestionadosGestionResiduosV2
    {
        public int? SidResiduoEspecifico { get; set; }
        public int? SidFraccion { get; set; }
        public int? SidResiduo { get; set; }
        public float PesoCalculado { get; set; }
        public string CódigoRaee { get; set; }
        public string Fracción { get; set; }
        public string Residuo { get; set; }
        public string ResiduoEspecífico { get; set; }
        public DateTime FechaDeGestion { get; set; }
        public int? SidTercero { get; set; }
        public int? SidDireccionTercero { get; set; }
        public string SidCertificado { get; set; }
    }
}
