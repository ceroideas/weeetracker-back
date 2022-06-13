using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class DireccionesTercero
    {
        public DireccionesTercero()
        {
            CertificadoSidDireccionTerceroDestinatarioNavigations = new HashSet<Certificado>();
            CertificadoSidDireccionTerceroSolicitanteNavigations = new HashSet<Certificado>();
            DireccionesTerceroContactosDireccionTerceros = new HashSet<DireccionesTerceroContactosDireccionTercero>();
            DireccionesTerceroTiposTerceros = new HashSet<DireccionesTerceroTiposTercero>();
            HistoricoPesada = new HashSet<HistoricoPesada>();
            IndicadoresDireccionTerceroFraccions = new HashSet<IndicadoresDireccionTerceroFraccion>();
            InventariosFisicos = new HashSet<InventariosFisico>();
            Pesada = new HashSet<Pesada>();
            Remesas = new HashSet<Remesa>();
            SolicitudeSidDireccionTerceroDestinoNavigations = new HashSet<Solicitude>();
            SolicitudeSidDireccionTerceroOrigenNavigations = new HashSet<Solicitude>();
            TercerosReutilizacion2017s = new HashSet<TercerosReutilizacion2017>();
            Terminales = new HashSet<Terminale>();
            WtkCambioEstados = new HashSet<WtkCambioEstado>();
            SidUsuarios = new HashSet<WtkUsuario>();
        }

        public int PidDireccionTercero { get; set; }
        public string Direccion { get; set; }
        public string Nombre { get; set; }
        public int SidProvincia { get; set; }
        public int SidPais { get; set; }
        public int SidTercero { get; set; }
        public int SidMunicipio { get; set; }
        public string CodigoPostal { get; set; }
        public int Estado { get; set; }
        public string TipoVia { get; set; }
        public double? CoordenadaX { get; set; }
        public double? CoordenadaY { get; set; }
        public int? CodGtr { get; set; }
        public int Pesado { get; set; }
        public int Inventario { get; set; }
        public int UsoRefTercero { get; set; }
        public int? CodTipo { get; set; }
        public string TipoDireccion { get; set; }
        public int? DiasPesado { get; set; }
        public Guid Rowguid { get; set; }

        public virtual Municipio SidMunicipioNavigation { get; set; }
        public virtual Paise SidPaisNavigation { get; set; }
        public virtual Provincia SidProvinciaNavigation { get; set; }
        public virtual Tercero SidTerceroNavigation { get; set; }
        public virtual ICollection<Certificado> CertificadoSidDireccionTerceroDestinatarioNavigations { get; set; }
        public virtual ICollection<Certificado> CertificadoSidDireccionTerceroSolicitanteNavigations { get; set; }
        public virtual ICollection<DireccionesTerceroContactosDireccionTercero> DireccionesTerceroContactosDireccionTerceros { get; set; }
        public virtual ICollection<DireccionesTerceroTiposTercero> DireccionesTerceroTiposTerceros { get; set; }
        public virtual ICollection<HistoricoPesada> HistoricoPesada { get; set; }
        public virtual ICollection<IndicadoresDireccionTerceroFraccion> IndicadoresDireccionTerceroFraccions { get; set; }
        public virtual ICollection<InventariosFisico> InventariosFisicos { get; set; }
        public virtual ICollection<Pesada> Pesada { get; set; }
        public virtual ICollection<Remesa> Remesas { get; set; }
        public virtual ICollection<Solicitude> SolicitudeSidDireccionTerceroDestinoNavigations { get; set; }
        public virtual ICollection<Solicitude> SolicitudeSidDireccionTerceroOrigenNavigations { get; set; }
        public virtual ICollection<TercerosReutilizacion2017> TercerosReutilizacion2017s { get; set; }
        public virtual ICollection<Terminale> Terminales { get; set; }
        public virtual ICollection<WtkCambioEstado> WtkCambioEstados { get; set; }

        public virtual ICollection<WtkUsuario> SidUsuarios { get; set; }
    }
}
