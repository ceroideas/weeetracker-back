using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class FichaCompletaRaeeRecogidaRecepcion
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
        public float? PesoEstimado { get; set; }
        public float? PesoReal { get; set; }
        public float PesoCalculado { get; set; }
    }
}
