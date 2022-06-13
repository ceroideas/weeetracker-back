using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class CertificadosConsultum
    {
        public string PidCertificado { get; set; }
        public string NroCertificado { get; set; }
        public int SidTipoCertificado { get; set; }
        public string Tipo { get; set; }
        public DateTime Fecha { get; set; }
        public int? SidSolicitud { get; set; }
        public int SidTerceroEmisor { get; set; }
        public string Emisor { get; set; }
        public int? SidTerceroSolicitante { get; set; }
        public string Origen { get; set; }
        public int SidTerceroDestinatario { get; set; }
        public string Destino { get; set; }
        public string Transportista { get; set; }
        public int? SidDireccionTerceroSolicitante { get; set; }
        public int SidDireccionTerceroDestinatario { get; set; }
        public string NroCertificadoReferencia { get; set; }
        public string OrigenNif { get; set; }
        public string EmisorNif { get; set; }
        public string DestinoNif { get; set; }
        public string TransportistaDocControl { get; set; }
        public string TransportistaNif { get; set; }
        public string TransportistaCodigo { get; set; }
        public string TransportistaExpedicion { get; set; }
        public string TransportistaMatricula { get; set; }
        public int? NumRaees { get; set; }
        public string OrigenDireccion { get; set; }
        public string DestinoDireccion { get; set; }
        public string TransportistaConductor { get; set; }
        public string TransportistaDni { get; set; }
        public string DestinoDireccionProvincia { get; set; }
        public string DestinoDireccionMunicipio { get; set; }
        public string DestinoDireccionPais { get; set; }
        public string OrigenDireccionProvincia { get; set; }
        public string OrigenDireccionMunicipio { get; set; }
        public string OrigenDireccionPais { get; set; }
        public int? Completo { get; set; }
        public int? NumRaeesCertificado { get; set; }
        public int? SidDireccionTerceroEmisor { get; set; }
        public string EmisorDireccion { get; set; }
        public string EmisorDireccionMunicipio { get; set; }
        public string EmisorDireccionProvincia { get; set; }
        public string EmisorDireccionPais { get; set; }
        public string EmisorCalleNombre { get; set; }
        public string OrigenCalleNombre { get; set; }
        public string DestinoCalleNombre { get; set; }
        public int SidEstadoCertificado { get; set; }
        public string EstadoCertificado { get; set; }
        public DateTime? FechaLiquidacion { get; set; }
        public DateTime? FechaOperacion { get; set; }
        public int? Servicio { get; set; }
        public string Email { get; set; }
        public int? NumFirmas { get; set; }
        public string ServicioDetail { get; set; }
        public string NumCertOrigen { get; set; }
    }
}
