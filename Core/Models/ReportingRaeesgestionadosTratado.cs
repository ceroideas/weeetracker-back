using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class ReportingRaeesgestionadosTratado
    {
        public string CódigoRaee { get; set; }
        public string Fracción { get; set; }
        public string ResiduoEspecífico { get; set; }
        public bool Canibalizado { get; set; }
        public DateTime FechaDeTratamiento { get; set; }
        public int CódigoTerceroDeTratamiento { get; set; }
        public string TerceroDeTratamiento { get; set; }
        public int CódigoDirecciónDeTratamiento { get; set; }
        public string DirecciónDeTratamiento { get; set; }
        public string CodigoPostal { get; set; }
        public string MunicipioDeTratamiento { get; set; }
        public string ProvinciaDeTratamiento { get; set; }
        public float? PesoEstimado { get; set; }
        public float? PesoReal { get; set; }
        public bool GrabacionVideo { get; set; }
        public float PesoCalculado { get; set; }
        public string Residuo { get; set; }
        public int PidResiduo { get; set; }
        public int? SidResiduo { get; set; }
        public int SidEstadoRaee { get; set; }
        public int Activo { get; set; }
        public int SidFraccion { get; set; }
    }
}
