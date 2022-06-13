using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class ServiciosSinRetiradaConsultum
    {
        public string Nservicio { get; set; }
        public string Nalbaran { get; set; }
        public string CodigoExterno { get; set; }
        public DateTime Fecha { get; set; }
        public int SidTerceroEmisor { get; set; }
        public string Emisor { get; set; }
        public int? SidDireccionTerceroEmisor { get; set; }
        public string EmisorDir { get; set; }
        public string EmisorCentro { get; set; }
        public int? SidTerceroSolicitante { get; set; }
        public string Origen { get; set; }
        public int? SidDireccionTerceroSolicitante { get; set; }
        public string OrigenDir { get; set; }
        public string OrigenCentro { get; set; }
        public int SidTerceroDestinatario { get; set; }
        public string Destino { get; set; }
        public int SidDireccionTerceroDestinatario { get; set; }
        public string DestinoDir { get; set; }
        public string DestinoCentro { get; set; }
        public string SidFirmaProcedencia { get; set; }
        public string FirmaNombreProcedencia { get; set; }
        public string FirmaUrlProcedencia { get; set; }
        public string FirmaCargoProcedencia { get; set; }
        public int NumFirmas { get; set; }
        public int? SidTipoServicio { get; set; }
        public string TipoServicio { get; set; }
        public double? GpsX { get; set; }
        public double? GpsY { get; set; }
        public double? GpsZ { get; set; }
        public string Email { get; set; }
        public int SidEstado { get; set; }
        public string Estado { get; set; }
        public string Coordenadas { get; set; }
        public string SidFirmaTransporte { get; set; }
        public string FirmaUrlTransporte { get; set; }
        public string FirmaNombreTransporte { get; set; }
        public string FirmaCargoTransporte { get; set; }
    }
}
