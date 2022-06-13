using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class RaeesConsultaOriginal
    {
        public string PidRaee { get; set; }
        public string Fraccion { get; set; }
        public string ResiduoEspecifico { get; set; }
        public string TipoContenedor { get; set; }
        public string Estado { get; set; }
        public DateTime? FechaTratamiento { get; set; }
        public string TratadoPor { get; set; }
        public bool Canibalizado { get; set; }
        public int SidResiduoEspecifico { get; set; }
        public int SidEstadoRaee { get; set; }
        public int? SidCertificadoTratamiento { get; set; }
        public int? TratamientoSidTercero { get; set; }
        public int? TratamientoSidDireccionTercero { get; set; }
        public int? TratamientoSidTipoLecturaTratamiento { get; set; }
        public string TratamientoTipoLecturaTratamiento { get; set; }
        public string TratamientoCalle { get; set; }
        public int SidFraccion { get; set; }
        public float? PesoEstimado { get; set; }
        public float? PesoReal { get; set; }
        public int? SidMarca { get; set; }
        public string Marca { get; set; }
        public string Video { get; set; }
        public int? UltimaUbicacionTercero { get; set; }
        public int? UltimaUbicacionDireccion { get; set; }
        public DateTime? UltimaUbicacionFecha { get; set; }
        public string Residuo { get; set; }
        public int? SidResiduo { get; set; }
        public string TratamientoDireccion { get; set; }
    }
}
