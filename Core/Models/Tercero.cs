using System;
using System.Collections.Generic;

namespace WeeeTrackerAPI.Models
{
    public partial class Tercero
    {
        public Tercero()
        {
            Certificados = new HashSet<Certificado>();
            ContactosDireccionTerceros = new HashSet<ContactosDireccionTercero>();
            DireccionesTerceros = new HashSet<DireccionesTercero>();
            HistoricoPesada = new HashSet<HistoricoPesada>();
            InventariosFisicos = new HashSet<InventariosFisico>();
            Pesada = new HashSet<Pesada>();
            Remesas = new HashSet<Remesa>();
            SolicitudeSidTerceroDestinoNavigations = new HashSet<Solicitude>();
            SolicitudeSidTerceroOrigenNavigations = new HashSet<Solicitude>();
            TercerosExcluidos = new HashSet<TercerosExcluido>();
            TercerosReutilizacion2017s = new HashSet<TercerosReutilizacion2017>();
            TercerosTiposTerceros = new HashSet<TercerosTiposTercero>();
            Terminales = new HashSet<Terminale>();
            WtkCambioEstados = new HashSet<WtkCambioEstado>();
            WtkUsuarios = new HashSet<WtkUsuario>();
        }

        public int PidTercero { get; set; }
        public string Nombre { get; set; }
        public string Nif { get; set; }
        public int Estado { get; set; }
        public string NombreComercial { get; set; }
        public int? CodGtr { get; set; }
        public Guid Rowguid { get; set; }

        public virtual WtkTextoLopd WtkTextoLopd { get; set; }
        public virtual ICollection<Certificado> Certificados { get; set; }
        public virtual ICollection<ContactosDireccionTercero> ContactosDireccionTerceros { get; set; }
        public virtual ICollection<DireccionesTercero> DireccionesTerceros { get; set; }
        public virtual ICollection<HistoricoPesada> HistoricoPesada { get; set; }
        public virtual ICollection<InventariosFisico> InventariosFisicos { get; set; }
        public virtual ICollection<Pesada> Pesada { get; set; }
        public virtual ICollection<Remesa> Remesas { get; set; }
        public virtual ICollection<Solicitude> SolicitudeSidTerceroDestinoNavigations { get; set; }
        public virtual ICollection<Solicitude> SolicitudeSidTerceroOrigenNavigations { get; set; }
        public virtual ICollection<TercerosExcluido> TercerosExcluidos { get; set; }
        public virtual ICollection<TercerosReutilizacion2017> TercerosReutilizacion2017s { get; set; }
        public virtual ICollection<TercerosTiposTercero> TercerosTiposTerceros { get; set; }
        public virtual ICollection<Terminale> Terminales { get; set; }
        public virtual ICollection<WtkCambioEstado> WtkCambioEstados { get; set; }
        public virtual ICollection<WtkUsuario> WtkUsuarios { get; set; }
    }
}
