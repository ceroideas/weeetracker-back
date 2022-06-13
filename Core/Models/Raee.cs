using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class Raee
    {
        public Raee()
        {
            HistoricoCambios = new HashSet<HistoricoCambio>();
            HistoricoPesosRaees = new HashSet<HistoricoPesosRaee>();
            RaeesAlbaranesEcotrazos = new HashSet<RaeesAlbaranesEcotrazo>();
            RaeesCertificados = new HashSet<RaeesCertificado>();
            VideosRaees = new HashSet<VideosRaee>();
            WtkCambioEstados = new HashSet<WtkCambioEstado>();
        }

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
        public int? SidMarca { get; set; }
        public float? DiasVida { get; set; }
        public float? DistanciaHastaTratamiento { get; set; }
        public float? DistanciaHastaTratamientoTramos { get; set; }
        public int Estado { get; set; }
        public int? SidResiduo { get; set; }
        public string CodigoRefTercero { get; set; }
        public int? Destino { get; set; }
        public string Serie { get; set; }
        public Guid Rowguid { get; set; }

        public virtual TiposDestino DestinoNavigation { get; set; }
        public virtual CertificadosTratamiento SidCertificadoTratamientoNavigation { get; set; }
        public virtual EstadosRaee SidEstadoRaeeNavigation { get; set; }
        public virtual Fraccione SidFraccionNavigation { get; set; }
        public virtual ResiduosEspecifico SidResiduoEspecificoNavigation { get; set; }
        public virtual Residuo SidResiduoNavigation { get; set; }
        public virtual TiposContenedor SidTipoContenedorNavigation { get; set; }
        public virtual ICollection<HistoricoCambio> HistoricoCambios { get; set; }
        public virtual ICollection<HistoricoPesosRaee> HistoricoPesosRaees { get; set; }
        public virtual ICollection<RaeesAlbaranesEcotrazo> RaeesAlbaranesEcotrazos { get; set; }
        public virtual ICollection<RaeesCertificado> RaeesCertificados { get; set; }
        public virtual ICollection<VideosRaee> VideosRaees { get; set; }
        public virtual ICollection<WtkCambioEstado> WtkCambioEstados { get; set; }
    }
}
