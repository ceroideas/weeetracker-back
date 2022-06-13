using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class Remesa
    {
        public int PidRemesa { get; set; }
        public int SidTercero { get; set; }
        public int? SidDireccionTercero { get; set; }
        public DateTime FechaEntrega { get; set; }
        public string CodigoInicioRango { get; set; }
        public string CodigoFinRango { get; set; }
        public string CodigoInicioTratado { get; set; }
        public string CodigoFinTratado { get; set; }
        public int SidEstadoRemesa { get; set; }
        public string ReferenciaRemesa { get; set; }
        public string ReferenciaProducto { get; set; }

        public virtual DireccionesTercero SidDireccionTerceroNavigation { get; set; }
        public virtual EstadosRemesa SidEstadoRemesaNavigation { get; set; }
        public virtual Tercero SidTerceroNavigation { get; set; }
    }
}
