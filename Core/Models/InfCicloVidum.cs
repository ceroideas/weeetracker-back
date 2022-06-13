using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class InfCicloVidum
    {
        public int PidInformeCicloVida { get; set; }
        public DateTime? FechaInforme { get; set; }
        public string Raee { get; set; }
        public int? RaeeSidFraccion { get; set; }
        public string RaeeFraccion { get; set; }
        public int? RaeeSidResiduoEspecifico { get; set; }
        public string RaeeResiduoEspecifico { get; set; }
        public int? RaeeSidResiduo { get; set; }
        public string RaeeResiduo { get; set; }
        public float? RaeePesoEstimado { get; set; }
        public float? RaeePesoReal { get; set; }
        public int? RaeeSidEstadoRaee { get; set; }
        public string RaeeEstadoRaee { get; set; }
        public int? RaeeSidGestorActual { get; set; }
        public string RaeeGestorActual { get; set; }
        public int? RaeeSidDireccionGestorActual { get; set; }
        public string RaeeDireccionGestorActual { get; set; }
        public string Pcident { get; set; }
        public int? PcidentSidEmisor { get; set; }
        public string PcidentEmisor { get; set; }
        public int? PcidentSidDirEmisor { get; set; }
        public string PcidentDirEmisor { get; set; }
        public string PcidentNcerGvr { get; set; }
        public DateTime? PcidentFecha { get; set; }
        public string PcrcRda { get; set; }
        public int? PcrcRdaSidEmisor { get; set; }
        public string PcrcRdaEmisor { get; set; }
        public int? PcrcRdaSidDirEmisor { get; set; }
        public string PcrcRdaDirEmisor { get; set; }
        public string PcrcRdaNcerGvr { get; set; }
        public DateTime? PcrcRdaFecha { get; set; }
        public string UcrcRda { get; set; }
        public int? UcrcRdaSidEmisor { get; set; }
        public string UcrcRdaEmisor { get; set; }
        public int? UcrcRdaSidDirEmisor { get; set; }
        public string UcrcRdaDirEmisor { get; set; }
        public string UcrcRdaNcerGvr { get; set; }
        public DateTime? UcrcRdaFecha { get; set; }
        public int? CerTrat { get; set; }
        public int? CerTratSidGestor { get; set; }
        public string CerTratGestor { get; set; }
        public int? CerTratSidDireccionGestor { get; set; }
        public string CerTratDireccionGestor { get; set; }
        public DateTime? CerTratFecha { get; set; }
        public int? CerTratSidTipoLectura { get; set; }
        public string CerTratTipo { get; set; }
        public int? CerTratVideo { get; set; }
        public int? DiasIdentificacionTorecogRecept { get; set; }
        public int? DiasRecogReceptTotratamiento { get; set; }
        public int? NcerIdent { get; set; }
        public int? NcerRecog { get; set; }
        public int? NcerEntre { get; set; }
        public int? NcerRecep { get; set; }
        public int? NcerTrata { get; set; }
    }
}
