using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class Fraccione
    {
        public Fraccione()
        {
            HistoricoPesada = new HashSet<HistoricoPesada>();
            IndicadoresDireccionTerceroFraccions = new HashSet<IndicadoresDireccionTerceroFraccion>();
            Pesada = new HashSet<Pesada>();
            Raees = new HashSet<Raee>();
            Residuos = new HashSet<Residuo>();
            ResiduosEspecificos = new HashSet<ResiduosEspecifico>();
        }

        public int PidFraccion { get; set; }
        public string Nombre { get; set; }
        public int Estado { get; set; }
        public Guid Rowguid { get; set; }

        public virtual ICollection<HistoricoPesada> HistoricoPesada { get; set; }
        public virtual ICollection<IndicadoresDireccionTerceroFraccion> IndicadoresDireccionTerceroFraccions { get; set; }
        public virtual ICollection<Pesada> Pesada { get; set; }
        public virtual ICollection<Raee> Raees { get; set; }
        public virtual ICollection<Residuo> Residuos { get; set; }
        public virtual ICollection<ResiduosEspecifico> ResiduosEspecificos { get; set; }
    }
}
