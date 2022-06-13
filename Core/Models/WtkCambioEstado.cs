using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class WtkCambioEstado
    {
        public WtkCambioEstado()
        {
            WtkCambioEstadoFirmas = new HashSet<WtkCambioEstadoFirma>();
            WtkCambioEstadoFotografia = new HashSet<WtkCambioEstadoFotografium>();
        }

        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public string SidRaee { get; set; }
        public string SidCertificado { get; set; }
        public int SidEstado { get; set; }
        public int? SidTercero { get; set; }
        public int? SidDireccionTercero { get; set; }
        public double? GpsX { get; set; }
        public double? GpsY { get; set; }
        public double? GpsZ { get; set; }
        public string Albaran { get; set; }
        public int? SidUsuario { get; set; }

        public virtual Certificado SidCertificadoNavigation { get; set; }
        public virtual DireccionesTercero SidDireccionTerceroNavigation { get; set; }
        public virtual EstadosRaee SidEstadoNavigation { get; set; }
        public virtual Raee SidRaeeNavigation { get; set; }
        public virtual Tercero SidTerceroNavigation { get; set; }
        public virtual WtkUsuario SidUsuarioNavigation { get; set; }
        public virtual ICollection<WtkCambioEstadoFirma> WtkCambioEstadoFirmas { get; set; }
        public virtual ICollection<WtkCambioEstadoFotografium> WtkCambioEstadoFotografia { get; set; }
    }
}
