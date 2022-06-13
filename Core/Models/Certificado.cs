using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class Certificado
    {
        public Certificado()
        {
            HistoricoCambios = new HashSet<HistoricoCambio>();
            HistoricoCambiosCertificados = new HashSet<HistoricoCambiosCertificado>();
            HistoricoPesosRaees = new HashSet<HistoricoPesosRaee>();
            Incidencia = new HashSet<Incidencia>();
            Pesada = new HashSet<Pesada>();
            RaeesAlbaranesEcotrazos = new HashSet<RaeesAlbaranesEcotrazo>();
            RaeesCertificados = new HashSet<RaeesCertificado>();
            WtkCambioEstados = new HashSet<WtkCambioEstado>();
        }

        public string PidCertificado { get; set; }
        public int SidTipoCertificado { get; set; }
        public int SidSig { get; set; }
        public string NroCertificadoReferencia { get; set; }
        public string NroCertificado { get; set; }
        public DateTime Fecha { get; set; }
        public int? SidSolicitud { get; set; }
        public int? SidTerceroSolicitante { get; set; }
        public int? SidDireccionTerceroSolicitante { get; set; }
        public string AuxEntidad { get; set; }
        public string AuxReferencia { get; set; }
        public string AuxNif { get; set; }
        public string AuxDireccion { get; set; }
        public string AuxLocalidad { get; set; }
        public string AuxProvincia { get; set; }
        public string AuxTelefono { get; set; }
        public string TransportistaCodigo { get; set; }
        public string TransportistaDocControl { get; set; }
        public string TransportistaNombre { get; set; }
        public string TransportistaNif { get; set; }
        public string TransportistaExpedicion { get; set; }
        public string TransportistaMatricula { get; set; }
        public string TransportistaConductor { get; set; }
        public string TransportistaDni { get; set; }
        public int SidTerceroDestinatario { get; set; }
        public int SidDireccionTerceroDestinatario { get; set; }
        public int SidEstadoCertificado { get; set; }
        public string SidFirmaProcedencia { get; set; }
        public string SidFirmaTransporte { get; set; }
        public string SidFirmaDestino { get; set; }
        public string Observaciones { get; set; }
        public string AuxPais { get; set; }
        public int SidTerceroEmisor { get; set; }
        public int? SidDireccionTerceroEmisor { get; set; }
        public int? NumRaees { get; set; }
        public float? PesoEnviado { get; set; }
        public DateTime? UltimaActualizacion { get; set; }
        public DateTime? Completado { get; set; }
        public DateTime? FechaOperacion { get; set; }
        public DateTime? FechaLiquidacion { get; set; }
        public int? Servicio { get; set; }
        public string Email { get; set; }
        public int? NumFirmas { get; set; }
        public string NumCertOrigen { get; set; }

        public virtual TiposServicio ServicioNavigation { get; set; }
        public virtual DireccionesTercero SidDireccionTerceroDestinatarioNavigation { get; set; }
        public virtual DireccionesTercero SidDireccionTerceroSolicitanteNavigation { get; set; }
        public virtual EstadosCertificado SidEstadoCertificadoNavigation { get; set; }
        public virtual FirmasCertificado SidFirmaDestinoNavigation { get; set; }
        public virtual FirmasCertificado SidFirmaProcedenciaNavigation { get; set; }
        public virtual FirmasCertificado SidFirmaTransporteNavigation { get; set; }
        public virtual Sig SidSigNavigation { get; set; }
        public virtual Tercero SidTerceroEmisorNavigation { get; set; }
        public virtual TiposCertificado SidTipoCertificadoNavigation { get; set; }
        public virtual ICollection<HistoricoCambio> HistoricoCambios { get; set; }
        public virtual ICollection<HistoricoCambiosCertificado> HistoricoCambiosCertificados { get; set; }
        public virtual ICollection<HistoricoPesosRaee> HistoricoPesosRaees { get; set; }
        public virtual ICollection<Incidencia> Incidencia { get; set; }
        public virtual ICollection<Pesada> Pesada { get; set; }
        public virtual ICollection<RaeesAlbaranesEcotrazo> RaeesAlbaranesEcotrazos { get; set; }
        public virtual ICollection<RaeesCertificado> RaeesCertificados { get; set; }
        public virtual ICollection<WtkCambioEstado> WtkCambioEstados { get; set; }
    }
}
