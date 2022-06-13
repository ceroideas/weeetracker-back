using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class HistoricoPesada
    {
        public int PidPesada { get; set; }
        public DateTime Fecha { get; set; }
        public string SidCertificado { get; set; }
        public float Peso { get; set; }
        public int? SidFraccion { get; set; }
        public int SidTercero { get; set; }
        public int SidDireccion { get; set; }
        public string SidCertificadoSubordinado { get; set; }

        public virtual DireccionesTercero SidDireccionNavigation { get; set; }
        public virtual Fraccione SidFraccionNavigation { get; set; }
        public virtual Tercero SidTerceroNavigation { get; set; }
    }
}
