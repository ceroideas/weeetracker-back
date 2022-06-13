using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class PesadasLksPteProcesar
    {
        public int PidPesada { get; set; }
        public DateTime Fecha { get; set; }
        public string SidCertificado { get; set; }
        public float Peso { get; set; }
        public int? SidFraccion { get; set; }
        public int SidTercero { get; set; }
        public int SidDireccion { get; set; }
        public string SidCertificadoSubordinado { get; set; }
    }
}
