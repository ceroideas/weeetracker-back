using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class HistoricoCambio
    {
        public int PidHistoricoCambio { get; set; }
        public DateTime? Fecha { get; set; }
        public string SidCertificado { get; set; }
        public int? SidResiduoEspecificoAntes { get; set; }
        public int? SidResiduoEspecificoDespues { get; set; }
        public int? SidTipoDeContenedorAntes { get; set; }
        public int? SidTipoDeContenedorDespues { get; set; }
        public bool? CanibalizadoAntes { get; set; }
        public bool? CanibalizadoDespues { get; set; }
        public int? SidEstadoAntes { get; set; }
        public int? SidEstadoDespues { get; set; }
        public string SidRaee { get; set; }
        public string SidRaeecertificado { get; set; }

        public virtual Certificado SidCertificadoNavigation { get; set; }
        public virtual EstadosRaee SidEstadoAntesNavigation { get; set; }
        public virtual EstadosRaee SidEstadoDespuesNavigation { get; set; }
        public virtual Raee SidRaeeNavigation { get; set; }
        public virtual ResiduosEspecifico SidResiduoEspecificoAntesNavigation { get; set; }
        public virtual ResiduosEspecifico SidResiduoEspecificoDespuesNavigation { get; set; }
        public virtual TiposContenedor SidTipoDeContenedorAntesNavigation { get; set; }
        public virtual TiposContenedor SidTipoDeContenedorDespuesNavigation { get; set; }
    }
}
