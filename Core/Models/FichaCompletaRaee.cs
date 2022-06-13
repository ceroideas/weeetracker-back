using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class FichaCompletaRaee
    {
        public string CódigoRaee { get; set; }
        public string Fracción { get; set; }
        public string ResiduoEspecífico { get; set; }
        public string TipoContenedor { get; set; }
        public bool Canibalizado { get; set; }
        public string Estado { get; set; }
        public DateTime? FechaDeGestion { get; set; }
        public int? CódigoTerceroDeGestion { get; set; }
        public string TerceroDeGestion { get; set; }
        public int? CódigoDirecciónDeGestion { get; set; }
        public string ProvinciaDeGestion { get; set; }
        public string MunicipioDeGestion { get; set; }
        public string DireccionDeGestion { get; set; }
        public DateTime? FechaDeTratamiento { get; set; }
        public int? CódigoTerceroDeTratamiento { get; set; }
        public string TerceroDeTratamiento { get; set; }
        public int? CódigoDirecciónDeTratamiento { get; set; }
        public string DirecciónDeTratamiento { get; set; }
        public string CodigoPostal { get; set; }
        public string MunicipioDeTratamiento { get; set; }
        public string ProvinciaDeTratamiento { get; set; }
        public string PaisDeTratamiento { get; set; }
        public float? PesoEstimado { get; set; }
        public float? PesoReal { get; set; }
        public bool? GrabacionVideo { get; set; }
        public float PesoCalculado { get; set; }
        public string Residuo { get; set; }
        public int PidResiduo { get; set; }
        public int? SidResiduo { get; set; }
        public int PidEstadoRaee { get; set; }
    }
}
