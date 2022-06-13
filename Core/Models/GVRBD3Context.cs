using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WeeeTrackerAPI.Models
{
    public partial class GVRBD3Context : DbContext
    {
        public GVRBD3Context()
        {
        }

        public GVRBD3Context(DbContextOptions<GVRBD3Context> options)
            : base(options)
        {
        }

        public virtual DbSet<AccesosTemporalesGvr> AccesosTemporalesGvrs { get; set; }
        public virtual DbSet<AndroidActualizacione> AndroidActualizaciones { get; set; }
        public virtual DbSet<AndroidCentro> AndroidCentros { get; set; }
        public virtual DbSet<AndroidContadore> AndroidContadores { get; set; }
        public virtual DbSet<AndroidMaquina> AndroidMaquinas { get; set; }
        public virtual DbSet<AndroidMarca> AndroidMarcas { get; set; }
        public virtual DbSet<AndroidResiduo> AndroidResiduos { get; set; }
        public virtual DbSet<AndroidServiciosSinRetiradum> AndroidServiciosSinRetirada { get; set; }
        public virtual DbSet<AndroidUsuario> AndroidUsuarios { get; set; }
        public virtual DbSet<AsignacionesEntrega> AsignacionesEntregas { get; set; }
        public virtual DbSet<AuxProcesarAutorizacione> AuxProcesarAutorizaciones { get; set; }
        public virtual DbSet<Ccaa> Ccaas { get; set; }
        public virtual DbSet<Ccaaprovincium> Ccaaprovincia { get; set; }
        public virtual DbSet<Certificado> Certificados { get; set; }
        public virtual DbSet<CertificadoInicialRaee> CertificadoInicialRaees { get; set; }
        public virtual DbSet<CertificadoInicialRaeesConDireccion> CertificadoInicialRaeesConDireccions { get; set; }
        public virtual DbSet<CertificadoInicialRaeesVold1> CertificadoInicialRaeesVold1s { get; set; }
        public virtual DbSet<CertificadoRaeesConDireccion> CertificadoRaeesConDireccions { get; set; }
        public virtual DbSet<CertificadosCompleto> CertificadosCompletos { get; set; }
        public virtual DbSet<CertificadosConsultum> CertificadosConsulta { get; set; }
        public virtual DbSet<CertificadosTratamiento> CertificadosTratamientos { get; set; }
        public virtual DbSet<ConfigPortal> ConfigPortals { get; set; }
        public virtual DbSet<Configuracione> Configuraciones { get; set; }
        public virtual DbSet<ConsultaContactosPorCentro> ConsultaContactosPorCentros { get; set; }
        public virtual DbSet<ContactosDireccionTercero> ContactosDireccionTerceros { get; set; }
        public virtual DbSet<ControlEtiquetasConsultum> ControlEtiquetasConsulta { get; set; }
        public virtual DbSet<ControlEtiquetasRemesa> ControlEtiquetasRemesas { get; set; }
        public virtual DbSet<ControlEtiquetasTercero> ControlEtiquetasTerceros { get; set; }
        public virtual DbSet<CoordenadasErronea> CoordenadasErroneas { get; set; }
        public virtual DbSet<DireccionesPublicacion> DireccionesPublicacions { get; set; }
        public virtual DbSet<DireccionesTercero> DireccionesTerceros { get; set; }
        public virtual DbSet<DireccionesTerceroContactosDireccionTercero> DireccionesTerceroContactosDireccionTerceros { get; set; }
        public virtual DbSet<DireccionesTerceroPorTercero> DireccionesTerceroPorTerceros { get; set; }
        public virtual DbSet<DireccionesTerceroTiposTercero> DireccionesTerceroTiposTerceros { get; set; }
        public virtual DbSet<EstadosCertificado> EstadosCertificados { get; set; }
        public virtual DbSet<EstadosIncidencium> EstadosIncidencia { get; set; }
        public virtual DbSet<EstadosRaee> EstadosRaees { get; set; }
        public virtual DbSet<EstadosRemesa> EstadosRemesas { get; set; }
        public virtual DbSet<FichaCompletaRaee> FichaCompletaRaees { get; set; }
        public virtual DbSet<FichaCompletaRaeeRecogidaRecepcion> FichaCompletaRaeeRecogidaRecepcions { get; set; }
        public virtual DbSet<FirmasCertificado> FirmasCertificados { get; set; }
        public virtual DbSet<FotosRaeecertificado> FotosRaeecertificados { get; set; }
        public virtual DbSet<Fraccione> Fracciones { get; set; }
        public virtual DbSet<FraccionesTiposContenedor> FraccionesTiposContenedors { get; set; }
        public virtual DbSet<GraficaOnlineWeeeTrace> GraficaOnlineWeeeTraces { get; set; }
        public virtual DbSet<GraficaPortal> GraficaPortals { get; set; }
        public virtual DbSet<HistoricoCambio> HistoricoCambios { get; set; }
        public virtual DbSet<HistoricoCambiosCertificado> HistoricoCambiosCertificados { get; set; }
        public virtual DbSet<HistoricoCambiosTiposCertificado> HistoricoCambiosTiposCertificados { get; set; }
        public virtual DbSet<HistoricoPesada> HistoricoPesadas { get; set; }
        public virtual DbSet<HistoricoPesosRaee> HistoricoPesosRaees { get; set; }
        public virtual DbSet<I49EmisorOrigen> I49EmisorOrigens { get; set; }
        public virtual DbSet<Incidencia> Incidencias { get; set; }
        public virtual DbSet<IndicadoresDireccionTerceroFraccion> IndicadoresDireccionTerceroFraccions { get; set; }
        public virtual DbSet<InfCicloVidum> InfCicloVida { get; set; }
        public virtual DbSet<Informe> Informes { get; set; }
        public virtual DbSet<InformeCicloVidum> InformeCicloVida { get; set; }
        public virtual DbSet<InventariosFisico> InventariosFisicos { get; set; }
        public virtual DbSet<InventariosFisicosRaee> InventariosFisicosRaees { get; set; }
        public virtual DbSet<LksEcoappComprobacionCentro> LksEcoappComprobacionCentros { get; set; }
        public virtual DbSet<LksEcoappComprobacionTercero> LksEcoappComprobacionTerceros { get; set; }
        public virtual DbSet<LksJobsCompletarCertificadosIndentificacionTercero> LksJobsCompletarCertificadosIndentificacionTerceros { get; set; }
        public virtual DbSet<LksRaeesProblemaEtiqueta> LksRaeesProblemaEtiquetas { get; set; }
        public virtual DbSet<LksTratarRaeesFormaManual> LksTratarRaeesFormaManuals { get; set; }
        public virtual DbSet<LogEventoPortal> LogEventoPortals { get; set; }
        public virtual DbSet<LogRepartoPesada> LogRepartoPesadas { get; set; }
        public virtual DbSet<Marca> Marcas { get; set; }
        public virtual DbSet<Municipio> Municipios { get; set; }
        public virtual DbSet<NumeroRaeeporDium> NumeroRaeeporDia { get; set; }
        public virtual DbSet<ObservacionesIncidencium> ObservacionesIncidencia { get; set; }
        public virtual DbSet<ObservacionesRaee> ObservacionesRaees { get; set; }
        public virtual DbSet<OriginalUltimasUbicacionesRaee> OriginalUltimasUbicacionesRaees { get; set; }
        public virtual DbSet<Paise> Paises { get; set; }
        public virtual DbSet<PaisesCodigoRaee> PaisesCodigoRaees { get; set; }
        public virtual DbSet<ParametrosGlobale> ParametrosGlobales { get; set; }
        public virtual DbSet<Permiso> Permisos { get; set; }
        public virtual DbSet<Pesada> Pesadas { get; set; }
        public virtual DbSet<PesadasErronea> PesadasErroneas { get; set; }
        public virtual DbSet<PesadasLksPteProcesar> PesadasLksPteProcesars { get; set; }
        public virtual DbSet<PesoEntradoEnSistemaPorDium> PesoEntradoEnSistemaPorDia { get; set; }
        public virtual DbSet<PesosEnviado> PesosEnviados { get; set; }
        public virtual DbSet<Provincia> Provincias { get; set; }
        public virtual DbSet<Raee> Raees { get; set; }
        public virtual DbSet<RaeeregistradoEnSistemaPorDium> RaeeregistradoEnSistemaPorDia { get; set; }
        public virtual DbSet<RaeesAReutilizar> RaeesAReutilizars { get; set; }
        public virtual DbSet<RaeesAlbaranesEcotrazo> RaeesAlbaranesEcotrazos { get; set; }
        public virtual DbSet<RaeesAmbitoTercero> RaeesAmbitoTerceros { get; set; }
        public virtual DbSet<RaeesAreutilizarBack> RaeesAreutilizarBacks { get; set; }
        public virtual DbSet<RaeesCertificado> RaeesCertificados { get; set; }
        public virtual DbSet<RaeesCertificadosUltimoId> RaeesCertificadosUltimoIds { get; set; }
        public virtual DbSet<RaeesConsultaOriginal> RaeesConsultaOriginals { get; set; }
        public virtual DbSet<RaeesConsultaRapidum> RaeesConsultaRapida { get; set; }
        public virtual DbSet<RaeesConsultum> RaeesConsulta { get; set; }
        public virtual DbSet<RaeesPrimerCertificado> RaeesPrimerCertificados { get; set; }
        public virtual DbSet<RaeesUltimaUbicacion> RaeesUltimaUbicacions { get; set; }
        public virtual DbSet<RaeetratadoConVideoPorDium> RaeetratadoConVideoPorDia { get; set; }
        public virtual DbSet<RaeetratadoPorDiaPorGestor> RaeetratadoPorDiaPorGestors { get; set; }
        public virtual DbSet<RaeetratadoPorDium> RaeetratadoPorDia { get; set; }
        public virtual DbSet<Remesa> Remesas { get; set; }
        public virtual DbSet<RemesasCopium> RemesasCopia { get; set; }
        public virtual DbSet<ReportingRaeesGestionado> ReportingRaeesGestionados { get; set; }
        public virtual DbSet<ReportingRaeesgestionadosEnTransito> ReportingRaeesgestionadosEnTransitos { get; set; }
        public virtual DbSet<ReportingRaeesgestionadosGestion> ReportingRaeesgestionadosGestions { get; set; }
        public virtual DbSet<ReportingRaeesgestionadosGestionResiduo> ReportingRaeesgestionadosGestionResiduos { get; set; }
        public virtual DbSet<ReportingRaeesgestionadosGestionResiduosV2> ReportingRaeesgestionadosGestionResiduosV2s { get; set; }
        public virtual DbSet<ReportingRaeesgestionadosGestionV2> ReportingRaeesgestionadosGestionV2s { get; set; }
        public virtual DbSet<ReportingRaeesgestionadosTratado> ReportingRaeesgestionadosTratados { get; set; }
        public virtual DbSet<ReportingStock> ReportingStocks { get; set; }
        public virtual DbSet<Residuo> Residuos { get; set; }
        public virtual DbSet<ResiduosEspecifico> ResiduosEspecificos { get; set; }
        public virtual DbSet<ResponsabilidadesRecogidaEntrega> ResponsabilidadesRecogidaEntregas { get; set; }
        public virtual DbSet<ResponsabilidadesTratamiento> ResponsabilidadesTratamientos { get; set; }
        public virtual DbSet<ResponsabilidadesTratamientoVersionAnterior> ResponsabilidadesTratamientoVersionAnteriors { get; set; }
        public virtual DbSet<ResposaRecogEntregaBack> ResposaRecogEntregaBacks { get; set; }
        public virtual DbSet<ResposaTratamientoBack> ResposaTratamientoBacks { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<ServiciosSinRetiradaConsultum> ServiciosSinRetiradaConsulta { get; set; }
        public virtual DbSet<Sig> Sigs { get; set; }
        public virtual DbSet<Solicitude> Solicitudes { get; set; }
        public virtual DbSet<SolicitudesConsultum> SolicitudesConsulta { get; set; }
        public virtual DbSet<Temporal> Temporals { get; set; }
        public virtual DbSet<Tercero> Terceros { get; set; }
        public virtual DbSet<TercerosConDireccione> TercerosConDirecciones { get; set; }
        public virtual DbSet<TercerosDireccionesContacto> TercerosDireccionesContactos { get; set; }
        public virtual DbSet<TercerosExcluido> TercerosExcluidos { get; set; }
        public virtual DbSet<TercerosReutilizacion2017> TercerosReutilizacion2017s { get; set; }
        public virtual DbSet<TercerosTiposTercero> TercerosTiposTerceros { get; set; }
        public virtual DbSet<Terminale> Terminales { get; set; }
        public virtual DbSet<TiposCertificado> TiposCertificados { get; set; }
        public virtual DbSet<TiposContenedor> TiposContenedors { get; set; }
        public virtual DbSet<TiposDestino> TiposDestinos { get; set; }
        public virtual DbSet<TiposEtiquetum> TiposEtiqueta { get; set; }
        public virtual DbSet<TiposIncidencium> TiposIncidencia { get; set; }
        public virtual DbSet<TiposLectura> TiposLecturas { get; set; }
        public virtual DbSet<TiposLecturaTratamiento> TiposLecturaTratamientos { get; set; }
        public virtual DbSet<TiposOperativa> TiposOperativas { get; set; }
        public virtual DbSet<TiposServicio> TiposServicios { get; set; }
        public virtual DbSet<TiposTercero> TiposTerceros { get; set; }
        public virtual DbSet<Tlog> Tlogs { get; set; }
        public virtual DbSet<Tratamiento> Tratamientos { get; set; }
        public virtual DbSet<TratamientosError> TratamientosErrors { get; set; }
        public virtual DbSet<UltimaUbicacionRaeeSinTratar> UltimaUbicacionRaeeSinTratars { get; set; }
        public virtual DbSet<UltimasUbicacionesRaee> UltimasUbicacionesRaees { get; set; }
        public virtual DbSet<UltimasUbicacionesRaeeMasTratadosNoLigadosCertificado> UltimasUbicacionesRaeeMasTratadosNoLigadosCertificados { get; set; }
        public virtual DbSet<UltimasUbicacionesRaeeVOld1> UltimasUbicacionesRaeeVOld1s { get; set; }
        public virtual DbSet<UltimasUbicacionesRaeeok> UltimasUbicacionesRaeeoks { get; set; }
        public virtual DbSet<UltimasUbicacionesRaeepdaOld> UltimasUbicacionesRaeepdaOlds { get; set; }
        public virtual DbSet<UltimasUbicacionesRaeepdum> UltimasUbicacionesRaeepda { get; set; }
        public virtual DbSet<UltimasUbicacionesRaeesinTratado> UltimasUbicacionesRaeesinTratados { get; set; }
        public virtual DbSet<UltimasUbicacionesRaeetratado> UltimasUbicacionesRaeetratados { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }
        public virtual DbSet<V4v3Mapeos2016> V4v3Mapeos2016s { get; set; }
        public virtual DbSet<VAuXRaeesconsulta11k> VAuXRaeesconsulta11ks { get; set; }
        public virtual DbSet<VAuXRaeesconsultum> VAuXRaeesconsulta { get; set; }
        public virtual DbSet<Version> Versions { get; set; }
        public virtual DbSet<VersionesPdum> VersionesPda { get; set; }
        public virtual DbSet<VersionesPublicacione> VersionesPublicaciones { get; set; }
        public virtual DbSet<VideosRaee> VideosRaees { get; set; }
        public virtual DbSet<VideosRaeeConfigRuta> VideosRaeeConfigRutas { get; set; }
        public virtual DbSet<VistaReplicacion> VistaReplicacions { get; set; }
        public virtual DbSet<WtkCambioEstado> WtkCambioEstados { get; set; }
        public virtual DbSet<WtkCambioEstadoBack> WtkCambioEstadoBacks { get; set; }
        public virtual DbSet<WtkCambioEstadoFirma> WtkCambioEstadoFirmas { get; set; }
        public virtual DbSet<WtkCambioEstadoFotografium> WtkCambioEstadoFotografia { get; set; }
        public virtual DbSet<WtkPerfil> WtkPerfils { get; set; }
        public virtual DbSet<WtkResiduoespecifico> WtkResiduoespecificos { get; set; }
        public virtual DbSet<WtkTextoLopd> WtkTextoLopds { get; set; }
        public virtual DbSet<WtkUsuario> WtkUsuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
// #warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=172.18.255.4;Database=GVRBD3;User Id=WTK;Password=WTK.2019;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccesosTemporalesGvr>(entity =>
            {
                entity.HasKey(e => e.AccesoId);

                entity.ToTable("AccesosTemporalesGVR");

                entity.Property(e => e.Certificado)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("certificado");

                entity.Property(e => e.Codigoacceso)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("codigoacceso");

                entity.Property(e => e.Creacion)
                    .HasColumnType("datetime")
                    .HasColumnName("creacion");

                entity.Property(e => e.Pesada)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("pesada");

                entity.Property(e => e.Usuario)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario");

                entity.Property(e => e.Validez)
                    .HasColumnType("datetime")
                    .HasColumnName("validez");
            });

            modelBuilder.Entity<AndroidActualizacione>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.FechaCambioCentro).HasColumnType("datetime");

                entity.Property(e => e.FechaCambioMarcas).HasColumnType("datetime");

                entity.Property(e => e.FechaCambioResiduos).HasColumnType("datetime");

                entity.Property(e => e.FechaCambioUsuarios).HasColumnType("datetime");

                entity.Property(e => e.SidTercero).HasColumnName("sidTercero");
            });

            modelBuilder.Entity<AndroidCentro>(entity =>
            {
                entity.HasKey(e => e.PidDireccionTercero)
                    .HasName("PK_CENTROSANDROID");

                entity.Property(e => e.PidDireccionTercero)
                    .ValueGeneratedNever()
                    .HasColumnName("pidDireccionTercero");

                entity.Property(e => e.Activo).HasDefaultValueSql("((1))");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechaModificacion)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.SidDireccionGenerica).HasColumnName("sidDireccionGenerica");

                entity.Property(e => e.SidTercero).HasColumnName("sidTercero");
            });

            modelBuilder.Entity<AndroidContadore>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Maquina)
                    .IsRequired()
                    .HasMaxLength(3);
            });

            modelBuilder.Entity<AndroidMaquina>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Imei)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("IMEI");

                entity.Property(e => e.Maquina)
                    .IsRequired()
                    .HasMaxLength(3);
            });

            modelBuilder.Entity<AndroidMarca>(entity =>
            {
                entity.HasKey(e => e.PidMarca);

                entity.Property(e => e.PidMarca)
                    .ValueGeneratedNever()
                    .HasColumnName("pidMarca");

                entity.Property(e => e.Activa)
                    .HasColumnName("activa")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechaModificacion)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.SidTercero).HasColumnName("sidTercero");
            });

            modelBuilder.Entity<AndroidResiduo>(entity =>
            {
                entity.HasKey(e => e.PidResiduoAndroid)
                    .HasName("PK_RESIDUOSANDROID");

                entity.Property(e => e.PidResiduoAndroid)
                    .ValueGeneratedNever()
                    .HasColumnName("pidResiduoAndroid");

                entity.Property(e => e.Activo).HasDefaultValueSql("((1))");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechaModificacion)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.SidFraccion).HasColumnName("sidFraccion");

                entity.Property(e => e.SidResiduo).HasColumnName("sidResiduo");

                entity.Property(e => e.SidResiduoEspecifico).HasColumnName("sidResiduoEspecifico");

                entity.Property(e => e.SidTercero).HasColumnName("sidTercero");
            });

            modelBuilder.Entity<AndroidServiciosSinRetiradum>(entity =>
            {
                entity.HasKey(e => e.PidCertificado)
                    .HasName("PK_ServicioSinRetirada");

                entity.Property(e => e.PidCertificado)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("pidCertificado");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha");

                entity.Property(e => e.GpsX).HasColumnName("gpsX");

                entity.Property(e => e.GpsY).HasColumnName("gpsY");

                entity.Property(e => e.GpsZ).HasColumnName("gpsZ");

                entity.Property(e => e.NroCertificadoReferencia)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("nroCertificadoReferencia");

                entity.Property(e => e.NumCertOrigen)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("numCertOrigen");

                entity.Property(e => e.NumFirmas).HasColumnName("numFirmas");

                entity.Property(e => e.Servicio).HasDefaultValueSql("((0))");

                entity.Property(e => e.SidDireccionTerceroDestinatario).HasColumnName("sidDireccionTerceroDestinatario");

                entity.Property(e => e.SidDireccionTerceroEmisor).HasColumnName("sidDireccionTerceroEmisor");

                entity.Property(e => e.SidDireccionTerceroSolicitante).HasColumnName("sidDireccionTerceroSolicitante");

                entity.Property(e => e.SidEstadoCertificado).HasColumnName("sidEstadoCertificado");

                entity.Property(e => e.SidFirmaProcedencia)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("sidFirmaProcedencia");

                entity.Property(e => e.SidFirmaTransporte)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("sidFirmaTransporte");

                entity.Property(e => e.SidTerceroDestinatario).HasColumnName("sidTerceroDestinatario");

                entity.Property(e => e.SidTerceroEmisor).HasColumnName("sidTerceroEmisor");

                entity.Property(e => e.SidTerceroSolicitante).HasColumnName("sidTerceroSolicitante");
            });

            modelBuilder.Entity<AndroidUsuario>(entity =>
            {
                entity.HasKey(e => e.PidUsuario)
                    .HasName("PK_USUARIOSANDROID");

                entity.Property(e => e.PidUsuario)
                    .ValueGeneratedNever()
                    .HasColumnName("pidUsuario");

                entity.Property(e => e.Activo).HasDefaultValueSql("((1))");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechaModificacion)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("password");

                entity.Property(e => e.SidDireccionTercero).HasColumnName("sidDireccionTercero");

                entity.Property(e => e.SidTercero).HasColumnName("sidTercero");
            });

            modelBuilder.Entity<AsignacionesEntrega>(entity =>
            {
                entity.HasKey(e => e.PidAsignacionEntrega);

                entity.ToTable("AsignacionesEntrega");

                entity.HasIndex(e => e.Estado, "Estado_AsignacionesEntrega")
                    .HasFillFactor(80);

                entity.HasIndex(e => e.Rowguid, "MSmerge_index_316839420")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.Property(e => e.PidAsignacionEntrega)
                    .ValueGeneratedNever()
                    .HasColumnName("pidAsignacionEntrega");

                entity.Property(e => e.Estado)
                    .HasColumnName("estado")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("rowguid")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.SidDireccionTerceroDestino).HasColumnName("sidDireccionTerceroDestino");

                entity.Property(e => e.SidDireccionTerceroOrigen).HasColumnName("sidDireccionTerceroOrigen");

                entity.Property(e => e.SidFraccionOrigen).HasColumnName("sidFraccionOrigen");

                entity.Property(e => e.SidTerceroDestino).HasColumnName("sidTerceroDestino");

                entity.Property(e => e.SidTerceroOrigen).HasColumnName("sidTerceroOrigen");
            });

            modelBuilder.Entity<AuxProcesarAutorizacione>(entity =>
            {
                entity.HasKey(e => e.PidAutorizacion);

                entity.ToTable("AuxProcesar_Autorizaciones");

                entity.Property(e => e.PidAutorizacion)
                    .ValueGeneratedNever()
                    .HasColumnName("pidAutorizacion");

                entity.Property(e => e.FechaFin)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaFin");

                entity.Property(e => e.FechaInicio)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaInicio");

                entity.Property(e => e.Operacion).HasColumnName("operacion");

                entity.Property(e => e.SidDireccionTercero).HasColumnName("sidDireccionTercero");

                entity.Property(e => e.SidFraccion).HasColumnName("sidFraccion");

                entity.Property(e => e.SidTercero).HasColumnName("sidTercero");
            });

            modelBuilder.Entity<Ccaa>(entity =>
            {
                entity.ToTable("CCAA");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Ccaaprovincium>(entity =>
            {
                entity.HasKey(e => new { e.Ccaaid, e.ProvinciaId });

                entity.ToTable("CCAAProvincia");

                entity.Property(e => e.Ccaaid).HasColumnName("CCAAId");
            });

            modelBuilder.Entity<Certificado>(entity =>
            {
                entity.HasKey(e => e.PidCertificado)
                    .HasName("PK_Certificados_1");

                entity.HasIndex(e => new { e.SidTipoCertificado, e.Fecha, e.SidDireccionTerceroDestinatario }, "IX_CALCULORECOGIDOS")
                    .HasFillFactor(80);

                entity.HasIndex(e => new { e.PidCertificado, e.Fecha }, "IX_CERT_FECHA")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.HasIndex(e => new { e.PidCertificado, e.NumRaees }, "IX_CERT_NUMRAEES")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.HasIndex(e => e.SidDireccionTerceroDestinatario, "IX_DESTINATARIO")
                    .HasFillFactor(80);

                entity.HasIndex(e => new { e.SidTerceroDestinatario, e.SidDireccionTerceroDestinatario }, "IX_DESTINATARIO_T_D")
                    .HasFillFactor(80);

                entity.HasIndex(e => e.Fecha, "IX_FECHA")
                    .HasFillFactor(80);

                entity.HasIndex(e => new { e.Fecha, e.SidTipoCertificado }, "IX_FECHA_TIPO")
                    .HasFillFactor(80);

                entity.HasIndex(e => new { e.SidTipoCertificado, e.SidSolicitud, e.SidTerceroSolicitante, e.SidDireccionTerceroSolicitante, e.SidTerceroDestinatario, e.SidDireccionTerceroDestinatario, e.SidEstadoCertificado }, "IX_GENERAL")
                    .HasFillFactor(80);

                entity.HasIndex(e => new { e.PidCertificado, e.SidEstadoCertificado }, "IX_PID_ESTADO")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.HasIndex(e => new { e.PidCertificado, e.SidEstadoCertificado, e.SidTerceroSolicitante, e.SidTerceroEmisor }, "IX_PID_ESTADO_ORIGEN_EMISOR")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.HasIndex(e => e.PidCertificado, "IX_Reporting_CertDestina")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.Property(e => e.PidCertificado)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("pidCertificado");

                entity.Property(e => e.AuxDireccion)
                    .HasMaxLength(256)
                    .HasColumnName("auxDireccion");

                entity.Property(e => e.AuxEntidad)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("auxEntidad");

                entity.Property(e => e.AuxLocalidad)
                    .HasMaxLength(256)
                    .HasColumnName("auxLocalidad");

                entity.Property(e => e.AuxNif)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("auxNIF");

                entity.Property(e => e.AuxPais)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("auxPais");

                entity.Property(e => e.AuxProvincia)
                    .HasMaxLength(256)
                    .HasColumnName("auxProvincia");

                entity.Property(e => e.AuxReferencia)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("auxReferencia");

                entity.Property(e => e.AuxTelefono)
                    .HasMaxLength(20)
                    .HasColumnName("auxTelefono");

                entity.Property(e => e.Completado)
                    .HasColumnType("datetime")
                    .HasColumnName("completado");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha");

                entity.Property(e => e.FechaLiquidacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaLiquidacion");

                entity.Property(e => e.FechaOperacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaOperacion");

                entity.Property(e => e.NroCertificado)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("nroCertificado");

                entity.Property(e => e.NroCertificadoReferencia)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("nroCertificadoReferencia");

                entity.Property(e => e.NumCertOrigen)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("numCertOrigen");

                entity.Property(e => e.NumFirmas)
                    .HasColumnName("numFirmas")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NumRaees).HasColumnName("numRaees");

                entity.Property(e => e.Observaciones)
                    .IsUnicode(false)
                    .HasColumnName("observaciones");

                entity.Property(e => e.PesoEnviado).HasColumnName("pesoEnviado");

                entity.Property(e => e.Servicio).HasDefaultValueSql("((0))");

                entity.Property(e => e.SidDireccionTerceroDestinatario).HasColumnName("sidDireccionTerceroDestinatario");

                entity.Property(e => e.SidDireccionTerceroEmisor).HasColumnName("sidDireccionTerceroEmisor");

                entity.Property(e => e.SidDireccionTerceroSolicitante).HasColumnName("sidDireccionTerceroSolicitante");

                entity.Property(e => e.SidEstadoCertificado).HasColumnName("sidEstadoCertificado");

                entity.Property(e => e.SidFirmaDestino)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("sidFirmaDestino");

                entity.Property(e => e.SidFirmaProcedencia)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("sidFirmaProcedencia");

                entity.Property(e => e.SidFirmaTransporte)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("sidFirmaTransporte");

                entity.Property(e => e.SidSig).HasColumnName("sidSIG");

                entity.Property(e => e.SidSolicitud).HasColumnName("sidSolicitud");

                entity.Property(e => e.SidTerceroDestinatario).HasColumnName("sidTerceroDestinatario");

                entity.Property(e => e.SidTerceroEmisor).HasColumnName("sidTerceroEmisor");

                entity.Property(e => e.SidTerceroSolicitante).HasColumnName("sidTerceroSolicitante");

                entity.Property(e => e.SidTipoCertificado).HasColumnName("sidTipoCertificado");

                entity.Property(e => e.TransportistaCodigo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("transportistaCodigo");

                entity.Property(e => e.TransportistaConductor)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("transportistaConductor");

                entity.Property(e => e.TransportistaDni)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("transportistaDNI");

                entity.Property(e => e.TransportistaDocControl)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("transportistaDocControl");

                entity.Property(e => e.TransportistaExpedicion)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("transportistaExpedicion");

                entity.Property(e => e.TransportistaMatricula)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("transportistaMatricula");

                entity.Property(e => e.TransportistaNif)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("transportistaNIF");

                entity.Property(e => e.TransportistaNombre)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("transportistaNombre");

                entity.Property(e => e.UltimaActualizacion)
                    .HasColumnType("datetime")
                    .HasColumnName("ultimaActualizacion");

                entity.HasOne(d => d.ServicioNavigation)
                    .WithMany(p => p.Certificados)
                    .HasForeignKey(d => d.Servicio)
                    .HasConstraintName("FK_Certificados_TiposServicio");

                entity.HasOne(d => d.SidDireccionTerceroDestinatarioNavigation)
                    .WithMany(p => p.CertificadoSidDireccionTerceroDestinatarioNavigations)
                    .HasForeignKey(d => d.SidDireccionTerceroDestinatario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Certificados_DireccionesTerceroDestinatario");

                entity.HasOne(d => d.SidDireccionTerceroSolicitanteNavigation)
                    .WithMany(p => p.CertificadoSidDireccionTerceroSolicitanteNavigations)
                    .HasForeignKey(d => d.SidDireccionTerceroSolicitante)
                    .HasConstraintName("FK_Certificados_DireccionesTerceroSolicitante");

                entity.HasOne(d => d.SidEstadoCertificadoNavigation)
                    .WithMany(p => p.Certificados)
                    .HasForeignKey(d => d.SidEstadoCertificado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Certificados_EstadosCertificado");

                entity.HasOne(d => d.SidFirmaDestinoNavigation)
                    .WithMany(p => p.CertificadoSidFirmaDestinoNavigations)
                    .HasForeignKey(d => d.SidFirmaDestino)
                    .HasConstraintName("FK_Certificados_FirmasCertificadoDestino");

                entity.HasOne(d => d.SidFirmaProcedenciaNavigation)
                    .WithMany(p => p.CertificadoSidFirmaProcedenciaNavigations)
                    .HasForeignKey(d => d.SidFirmaProcedencia)
                    .HasConstraintName("FK_Certificados_FirmasCertificadoProcedencia");

                entity.HasOne(d => d.SidFirmaTransporteNavigation)
                    .WithMany(p => p.CertificadoSidFirmaTransporteNavigations)
                    .HasForeignKey(d => d.SidFirmaTransporte)
                    .HasConstraintName("FK_Certificados_FirmasCertificadoTransporte");

                entity.HasOne(d => d.SidSigNavigation)
                    .WithMany(p => p.Certificados)
                    .HasForeignKey(d => d.SidSig)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Certificados_SIGs");

                entity.HasOne(d => d.SidTerceroEmisorNavigation)
                    .WithMany(p => p.Certificados)
                    .HasForeignKey(d => d.SidTerceroEmisor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Certificados_TercerosEmisor");

                entity.HasOne(d => d.SidTipoCertificadoNavigation)
                    .WithMany(p => p.Certificados)
                    .HasForeignKey(d => d.SidTipoCertificado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Certificados_TiposCertificado");
            });

            modelBuilder.Entity<CertificadoInicialRaee>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CertificadoInicialRAEEs");

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha");

                entity.Property(e => e.SidCertificado)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("sidCertificado");

                entity.Property(e => e.SidDireccionTercero).HasColumnName("sidDireccionTercero");

                entity.Property(e => e.SidEstadoRaee).HasColumnName("sidEstadoRAEE");

                entity.Property(e => e.SidRaee)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("sidRAEE");

                entity.Property(e => e.SidTercero).HasColumnName("sidTercero");

                entity.Property(e => e.SuperiorAnyo).HasColumnName("superiorAnyo");
            });

            modelBuilder.Entity<CertificadoInicialRaeesConDireccion>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CertificadoInicialRAEEsConDireccion");

                entity.Property(e => e.Direccion)
                    .IsUnicode(false)
                    .HasColumnName("direccion");

                entity.Property(e => e.FechaCertificado).HasColumnType("datetime");

                entity.Property(e => e.Municipio)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre).HasColumnName("nombre");

                entity.Property(e => e.Provincia)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.SidCertificado)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("sidCertificado");

                entity.Property(e => e.SidDireccionTercero).HasColumnName("sidDireccionTercero");

                entity.Property(e => e.SidEstadoRaee).HasColumnName("sidEstadoRAEE");

                entity.Property(e => e.SidRaee)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("sidRAEE");

                entity.Property(e => e.SidTercero).HasColumnName("sidTercero");
            });

            modelBuilder.Entity<CertificadoInicialRaeesVold1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CertificadoInicialRAEEs_Vold1");

                entity.Property(e => e.FechaCertificado).HasColumnType("datetime");

                entity.Property(e => e.SidCertificado)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("sidCertificado");

                entity.Property(e => e.SidDireccionTercero).HasColumnName("sidDireccionTercero");

                entity.Property(e => e.SidEstadoRaee).HasColumnName("sidEstadoRAEE");

                entity.Property(e => e.SidRaee)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("sidRAEE");

                entity.Property(e => e.SidTercero).HasColumnName("sidTercero");
            });

            modelBuilder.Entity<CertificadoRaeesConDireccion>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CertificadoRAEEsConDireccion");

                entity.Property(e => e.Direccion)
                    .IsUnicode(false)
                    .HasColumnName("direccion");

                entity.Property(e => e.FechaCertificado).HasColumnType("datetime");

                entity.Property(e => e.Municipio)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre).HasColumnName("nombre");

                entity.Property(e => e.Provincia)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.SidCertificado)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("sidCertificado");

                entity.Property(e => e.SidDireccionTercero).HasColumnName("sidDireccionTercero");

                entity.Property(e => e.SidEstadoRaee).HasColumnName("sidEstadoRAEE");

                entity.Property(e => e.SidRaee)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("sidRAEE");

                entity.Property(e => e.SidTercero).HasColumnName("sidTercero");

                entity.Property(e => e.SidTipoCertificado).HasColumnName("sidTipoCertificado");
            });

            modelBuilder.Entity<CertificadosCompleto>(entity =>
            {
                entity.HasKey(e => e.PidCertificado)
                    .HasName("PK_CertificadosEstado");

                entity.HasIndex(e => e.PidCertificado, "IX_CERT")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.Property(e => e.PidCertificado)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("pidCertificado");

                entity.Property(e => e.NraeesCertificado).HasColumnName("NRAEEsCertificado");
            });

            modelBuilder.Entity<CertificadosConsultum>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CertificadosConsulta");

                entity.Property(e => e.DestinoCalleNombre)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DestinoDireccion).IsUnicode(false);

                entity.Property(e => e.DestinoDireccionMunicipio)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("DestinoDireccion_Municipio");

                entity.Property(e => e.DestinoDireccionPais)
                    .IsRequired()
                    .HasColumnName("DestinoDireccion_Pais");

                entity.Property(e => e.DestinoDireccionProvincia)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("DestinoDireccion_Provincia");

                entity.Property(e => e.DestinoNif).HasColumnName("Destino_NIF");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Emisor).IsRequired();

                entity.Property(e => e.EmisorCalleNombre)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EmisorDireccion).IsUnicode(false);

                entity.Property(e => e.EmisorDireccionMunicipio)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("EmisorDireccion_Municipio");

                entity.Property(e => e.EmisorDireccionPais).HasColumnName("EmisorDireccion_Pais");

                entity.Property(e => e.EmisorDireccionProvincia)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("EmisorDireccion_Provincia");

                entity.Property(e => e.EmisorNif)
                    .IsRequired()
                    .HasColumnName("Emisor_NIF");

                entity.Property(e => e.EstadoCertificado)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha");

                entity.Property(e => e.FechaLiquidacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaLiquidacion");

                entity.Property(e => e.FechaOperacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaOperacion");

                entity.Property(e => e.NroCertificado)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("nroCertificado");

                entity.Property(e => e.NroCertificadoReferencia)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("nroCertificadoReferencia");

                entity.Property(e => e.NumCertOrigen)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("numCertOrigen");

                entity.Property(e => e.NumFirmas).HasColumnName("numFirmas");

                entity.Property(e => e.NumRaees).HasColumnName("numRaees");

                entity.Property(e => e.NumRaeesCertificado).HasColumnName("numRaeesCertificado");

                entity.Property(e => e.OrigenCalleNombre)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OrigenDireccion).IsUnicode(false);

                entity.Property(e => e.OrigenDireccionMunicipio)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("OrigenDireccion_Municipio");

                entity.Property(e => e.OrigenDireccionPais).HasColumnName("OrigenDireccion_Pais");

                entity.Property(e => e.OrigenDireccionProvincia)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("OrigenDireccion_Provincia");

                entity.Property(e => e.OrigenNif).HasColumnName("Origen_NIF");

                entity.Property(e => e.PidCertificado)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("pidCertificado");

                entity.Property(e => e.ServicioDetail).HasMaxLength(50);

                entity.Property(e => e.SidDireccionTerceroDestinatario).HasColumnName("sidDireccionTerceroDestinatario");

                entity.Property(e => e.SidDireccionTerceroEmisor).HasColumnName("sidDireccionTerceroEmisor");

                entity.Property(e => e.SidDireccionTerceroSolicitante).HasColumnName("sidDireccionTerceroSolicitante");

                entity.Property(e => e.SidEstadoCertificado).HasColumnName("sidEstadoCertificado");

                entity.Property(e => e.SidSolicitud).HasColumnName("sidSolicitud");

                entity.Property(e => e.SidTerceroDestinatario).HasColumnName("sidTerceroDestinatario");

                entity.Property(e => e.SidTerceroEmisor).HasColumnName("sidTerceroEmisor");

                entity.Property(e => e.SidTerceroSolicitante).HasColumnName("sidTerceroSolicitante");

                entity.Property(e => e.SidTipoCertificado).HasColumnName("sidTipoCertificado");

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Transportista)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.TransportistaCodigo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("transportistaCodigo");

                entity.Property(e => e.TransportistaConductor)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("transportistaConductor");

                entity.Property(e => e.TransportistaDni)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("transportistaDNI");

                entity.Property(e => e.TransportistaDocControl)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("transportistaDocControl");

                entity.Property(e => e.TransportistaExpedicion)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("transportistaExpedicion");

                entity.Property(e => e.TransportistaMatricula)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("transportistaMatricula");

                entity.Property(e => e.TransportistaNif)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("transportistaNIF");
            });

            modelBuilder.Entity<CertificadosTratamiento>(entity =>
            {
                entity.HasKey(e => e.PidCertificadoTratamiento);

                entity.ToTable("CertificadosTratamiento");

                entity.HasIndex(e => e.FechaTratamiento, "IX_FECHA")
                    .HasFillFactor(80);

                entity.HasIndex(e => new { e.SidTercero, e.SidDireccionTercero, e.FechaTratamiento }, "IX_GENERAL")
                    .HasFillFactor(80);

                entity.HasIndex(e => new { e.SidTercero, e.FechaTratamiento }, "IX_TER_FECHA")
                    .HasFillFactor(80);

                entity.HasIndex(e => new { e.SidTercero, e.FechaTratamiento, e.SidDireccionTercero, e.SidTipoLecturaTratamiento, e.GrabacionVideo }, "IX_TRATAMIENTOS")
                    .HasFillFactor(80);

                entity.Property(e => e.PidCertificadoTratamiento).HasColumnName("pidCertificadoTratamiento");

                entity.Property(e => e.CodigoInstalacionTratamiento).HasColumnName("codigoInstalacionTratamiento");

                entity.Property(e => e.FechaTratamiento)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaTratamiento");

                entity.Property(e => e.Incidencia).HasColumnName("incidencia");

                entity.Property(e => e.ObservacionesIncidencia)
                    .IsUnicode(false)
                    .HasColumnName("observacionesIncidencia");

                entity.Property(e => e.Reutilizacion).HasDefaultValueSql("((0))");

                entity.Property(e => e.SidDireccionTercero).HasColumnName("sidDireccionTercero");

                entity.Property(e => e.SidTercero).HasColumnName("sidTercero");

                entity.Property(e => e.SidTipoLecturaTratamiento).HasColumnName("sidTipoLecturaTratamiento");
            });

            modelBuilder.Entity<ConfigPortal>(entity =>
            {
                entity.HasKey(e => e.Proceso);

                entity.ToTable("ConfigPortal");

                entity.Property(e => e.Proceso)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Detalles).IsUnicode(false);
            });

            modelBuilder.Entity<Configuracione>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.NumPda)
                    .HasMaxLength(3)
                    .HasColumnName("NumPDA")
                    .IsFixedLength();

                entity.Property(e => e.NumSerie)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ConsultaContactosPorCentro>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ConsultaContactosPorCentro");

                entity.Property(e => e.Apellidos)
                    .IsRequired()
                    .HasColumnName("apellidos");

                entity.Property(e => e.Contrasena)
                    .IsRequired()
                    .HasColumnName("contrasena");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre");

                entity.Property(e => e.PidContactoDireccionTercero).HasColumnName("pidContactoDireccionTercero");

                entity.Property(e => e.SidDireccionTercero).HasColumnName("sidDireccionTercero");
            });

            modelBuilder.Entity<ContactosDireccionTercero>(entity =>
            {
                entity.HasKey(e => e.PidContactoDireccionTercero);

                entity.ToTable("ContactosDireccionTercero");

                entity.HasIndex(e => e.Estado, "Estado_ContactorDireccionTercero")
                    .HasFillFactor(80);

                entity.HasIndex(e => e.PidContactoDireccionTercero, "IX_FK_DireccionesTercerosContactosDireccionTercero")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.HasIndex(e => e.Rowguid, "MSmerge_index_659792637")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.Property(e => e.PidContactoDireccionTercero)
                    .ValueGeneratedNever()
                    .HasColumnName("pidContactoDireccionTercero");

                entity.Property(e => e.Apellidos)
                    .IsRequired()
                    .HasColumnName("apellidos");

                entity.Property(e => e.CodGtr).HasColumnName("codGTR");

                entity.Property(e => e.Contrasena)
                    .IsRequired()
                    .HasColumnName("contrasena");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .HasColumnName("email");

                entity.Property(e => e.Estado)
                    .HasColumnName("estado")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre");

                entity.Property(e => e.PerfilGvr).HasColumnName("perfilGVR");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("rowguid")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.SidTercero).HasColumnName("sidTercero");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(15)
                    .HasColumnName("telefono");

                entity.HasOne(d => d.SidTerceroNavigation)
                    .WithMany(p => p.ContactosDireccionTerceros)
                    .HasForeignKey(d => d.SidTercero)
                    .HasConstraintName("FK_ContactosDireccionTercero_Terceros");
            });

            modelBuilder.Entity<ControlEtiquetasConsultum>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ControlEtiquetasConsulta");

                entity.Property(e => e.Nif)
                    .IsRequired()
                    .HasColumnName("NIF");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre");

                entity.Property(e => e.SidDireccionTercero).HasColumnName("sidDireccionTercero");

                entity.Property(e => e.SidTercero).HasColumnName("sidTercero");

                entity.Property(e => e.TodasRemesas).HasColumnName("todasRemesas");

                entity.Property(e => e.TotConsumidos).HasColumnName("totConsumidos");

                entity.Property(e => e.TotEntregados).HasColumnName("totEntregados");

                entity.Property(e => e.TotPerdidos).HasColumnName("totPerdidos");
            });

            modelBuilder.Entity<ControlEtiquetasRemesa>(entity =>
            {
                entity.HasKey(e => e.PidRemesa);

                entity.ToTable("ControlEtiquetas_Remesas");

                entity.Property(e => e.PidRemesa)
                    .ValueGeneratedNever()
                    .HasColumnName("pidRemesa");

                entity.Property(e => e.TotConsumidos).HasColumnName("totConsumidos");

                entity.Property(e => e.TotEntregados).HasColumnName("totEntregados");

                entity.Property(e => e.TotPerdidos).HasColumnName("totPerdidos");
            });

            modelBuilder.Entity<ControlEtiquetasTercero>(entity =>
            {
                entity.HasKey(e => new { e.SidTercero, e.SidDireccionTercero, e.TodasRemesas })
                    .HasName("PK_ControlEtiquetas_Terceros_1");

                entity.ToTable("ControlEtiquetas_Terceros");

                entity.Property(e => e.SidTercero).HasColumnName("sidTercero");

                entity.Property(e => e.SidDireccionTercero).HasColumnName("sidDireccionTercero");

                entity.Property(e => e.TodasRemesas).HasColumnName("todasRemesas");

                entity.Property(e => e.TotConsumidos).HasColumnName("totConsumidos");

                entity.Property(e => e.TotEntregados).HasColumnName("totEntregados");

                entity.Property(e => e.TotPerdidos).HasColumnName("totPerdidos");
            });

            modelBuilder.Entity<CoordenadasErronea>(entity =>
            {
                entity.HasKey(e => e.IdCoordError);

                entity.Property(e => e.Latitud).HasColumnName("latitud");

                entity.Property(e => e.Longitud).HasColumnName("longitud");
            });

            modelBuilder.Entity<DireccionesPublicacion>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("DireccionesPublicacion");

                entity.Property(e => e.PidDireccionTercero).HasColumnName("pidDireccionTercero");
            });

            modelBuilder.Entity<DireccionesTercero>(entity =>
            {
                entity.HasKey(e => e.PidDireccionTercero)
                    .HasName("PK_DireccionesTerceros");

                entity.ToTable("DireccionesTercero");

                entity.HasIndex(e => new { e.PidDireccionTercero, e.Estado }, "Estado_DireccionesTercero")
                    .HasFillFactor(80);

                entity.HasIndex(e => e.SidPais, "IX_FK_PaisDireccionesTerceros")
                    .HasFillFactor(80);

                entity.HasIndex(e => e.SidProvincia, "IX_FK_ProvinciaDireccionesTerceros")
                    .HasFillFactor(80);

                entity.HasIndex(e => e.SidProvincia, "IX_PROVINCIA")
                    .HasFillFactor(80);

                entity.HasIndex(e => new { e.SidTercero, e.PidDireccionTercero }, "IX_terceros")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.HasIndex(e => e.Rowguid, "MSmerge_index_341887514")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.Property(e => e.PidDireccionTercero)
                    .ValueGeneratedNever()
                    .HasColumnName("pidDireccionTercero");

                entity.Property(e => e.CodGtr).HasColumnName("codGTR");

                entity.Property(e => e.CodTipo).HasColumnName("codTipo");

                entity.Property(e => e.CodigoPostal)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("codigoPostal");

                entity.Property(e => e.CoordenadaX).HasColumnName("coordenadaX");

                entity.Property(e => e.CoordenadaY).HasColumnName("coordenadaY");

                entity.Property(e => e.DiasPesado).HasColumnName("diasPesado");

                entity.Property(e => e.Direccion)
                    .IsUnicode(false)
                    .HasColumnName("direccion");

                entity.Property(e => e.Estado)
                    .HasColumnName("estado")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Inventario).HasColumnName("inventario");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.Pesado).HasColumnName("pesado");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("rowguid")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.SidMunicipio).HasColumnName("sidMunicipio");

                entity.Property(e => e.SidPais).HasColumnName("sidPais");

                entity.Property(e => e.SidProvincia).HasColumnName("sidProvincia");

                entity.Property(e => e.SidTercero).HasColumnName("sidTercero");

                entity.Property(e => e.TipoDireccion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("tipoDireccion");

                entity.Property(e => e.TipoVia)
                    .HasMaxLength(50)
                    .HasColumnName("tipoVia");

                entity.Property(e => e.UsoRefTercero).HasColumnName("usoRefTercero");

                entity.HasOne(d => d.SidMunicipioNavigation)
                    .WithMany(p => p.DireccionesTerceros)
                    .HasForeignKey(d => d.SidMunicipio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DireccionesTercero_Municipios");

                entity.HasOne(d => d.SidPaisNavigation)
                    .WithMany(p => p.DireccionesTerceros)
                    .HasForeignKey(d => d.SidPais)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PaisDireccionesTerceros");

                entity.HasOne(d => d.SidProvinciaNavigation)
                    .WithMany(p => p.DireccionesTerceros)
                    .HasForeignKey(d => d.SidProvincia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProvinciaDireccionesTerceros");

                entity.HasOne(d => d.SidTerceroNavigation)
                    .WithMany(p => p.DireccionesTerceros)
                    .HasForeignKey(d => d.SidTercero)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DireccionesTercero_Terceros");
            });

            modelBuilder.Entity<DireccionesTerceroContactosDireccionTercero>(entity =>
            {
                entity.HasKey(e => e.PidDireccionTerceroContactoDireccionTercero);

                entity.ToTable("DireccionesTerceroContactosDireccionTercero");

                entity.HasIndex(e => new { e.Estado, e.SidDireccionTercero }, "Estado_DireccionesTerceroContactosDireccionTercero")
                    .HasFillFactor(80);

                entity.HasIndex(e => e.Rowguid, "MSmerge_index_1555795829")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.Property(e => e.PidDireccionTerceroContactoDireccionTercero)
                    .ValueGeneratedNever()
                    .HasColumnName("pidDireccionTerceroContactoDireccionTercero");

                entity.Property(e => e.Estado)
                    .HasColumnName("estado")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("rowguid")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.SidContactoDireccionTercero).HasColumnName("sidContactoDireccionTercero");

                entity.Property(e => e.SidDireccionTercero).HasColumnName("sidDireccionTercero");

                entity.HasOne(d => d.SidContactoDireccionTerceroNavigation)
                    .WithMany(p => p.DireccionesTerceroContactosDireccionTerceros)
                    .HasForeignKey(d => d.SidContactoDireccionTercero)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DireccionesTerceroContactosDireccionTercero_ContactosDireccionTercero");

                entity.HasOne(d => d.SidDireccionTerceroNavigation)
                    .WithMany(p => p.DireccionesTerceroContactosDireccionTerceros)
                    .HasForeignKey(d => d.SidDireccionTercero)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DireccionesTerceroContactosDireccionTercero_DireccionesTercero");
            });

            modelBuilder.Entity<DireccionesTerceroPorTercero>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("DireccionesTerceroPorTerceros");

                entity.Property(e => e.Apellidos)
                    .IsRequired()
                    .HasColumnName("apellidos");

                entity.Property(e => e.Contrasena)
                    .IsRequired()
                    .HasColumnName("contrasena");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre");

                entity.Property(e => e.PidContactoDireccionTercero).HasColumnName("pidContactoDireccionTercero");

                entity.Property(e => e.SidDireccionTercero).HasColumnName("sidDireccionTercero");

                entity.Property(e => e.SidTercero).HasColumnName("sidTercero");
            });

            modelBuilder.Entity<DireccionesTerceroTiposTercero>(entity =>
            {
                entity.HasKey(e => e.PidDireccionTerceroTipoTercero);

                entity.ToTable("DireccionesTerceroTiposTercero");

                entity.HasIndex(e => new { e.Estado, e.SidDireccionesTercero }, "Estado_DireccionesTerceroTiposTercero")
                    .HasFillFactor(80);

                entity.HasIndex(e => e.Rowguid, "MSmerge_index_1475795544")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.Property(e => e.PidDireccionTerceroTipoTercero)
                    .ValueGeneratedNever()
                    .HasColumnName("pidDireccionTerceroTipoTercero");

                entity.Property(e => e.Estado)
                    .HasColumnName("estado")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("rowguid")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.SidDireccionesTercero).HasColumnName("sidDireccionesTercero");

                entity.Property(e => e.SidTipoTercero).HasColumnName("sidTipoTercero");

                entity.HasOne(d => d.SidDireccionesTerceroNavigation)
                    .WithMany(p => p.DireccionesTerceroTiposTerceros)
                    .HasForeignKey(d => d.SidDireccionesTercero)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DireccionesTerceroTiposTercero_DireccionesTercero");

                entity.HasOne(d => d.SidTipoTerceroNavigation)
                    .WithMany(p => p.DireccionesTerceroTiposTerceros)
                    .HasForeignKey(d => d.SidTipoTercero)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DireccionesTerceroTiposTercero_TiposTercero");
            });

            modelBuilder.Entity<EstadosCertificado>(entity =>
            {
                entity.HasKey(e => e.PidEstadoCertificado)
                    .HasName("PK_EstadosCertificados");

                entity.ToTable("EstadosCertificado");

                entity.Property(e => e.PidEstadoCertificado)
                    .ValueGeneratedNever()
                    .HasColumnName("pidEstadoCertificado");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<EstadosIncidencium>(entity =>
            {
                entity.HasKey(e => e.PidEstadoIncidencia);

                entity.Property(e => e.PidEstadoIncidencia)
                    .ValueGeneratedNever()
                    .HasColumnName("pidEstadoIncidencia");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<EstadosRaee>(entity =>
            {
                entity.HasKey(e => e.PidEstadoRaee)
                    .HasName("PK_ESTADOS");

                entity.ToTable("EstadosRAEE");

                entity.Property(e => e.PidEstadoRaee)
                    .ValueGeneratedNever()
                    .HasColumnName("pidEstadoRAEE");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("nombre");

                entity.Property(e => e.Orden).HasColumnName("orden");
            });

            modelBuilder.Entity<EstadosRemesa>(entity =>
            {
                entity.HasKey(e => e.PidEstadoRemesa);

                entity.ToTable("EstadosRemesa");

                entity.Property(e => e.PidEstadoRemesa).HasColumnName("pidEstadoRemesa");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<FichaCompletaRaee>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("FichaCompletaRAEE");

                entity.Property(e => e.Canibalizado).HasColumnName("canibalizado");

                entity.Property(e => e.CodigoPostal)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("codigoPostal");

                entity.Property(e => e.CódigoDirecciónDeGestion).HasColumnName("Código Dirección de Gestion");

                entity.Property(e => e.CódigoDirecciónDeTratamiento).HasColumnName("Código Dirección de Tratamiento");

                entity.Property(e => e.CódigoRaee)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Código RAEE");

                entity.Property(e => e.CódigoTerceroDeGestion).HasColumnName("Código Tercero de Gestion");

                entity.Property(e => e.CódigoTerceroDeTratamiento).HasColumnName("Código Tercero de Tratamiento");

                entity.Property(e => e.DireccionDeGestion)
                    .IsUnicode(false)
                    .HasColumnName("Direccion de Gestion");

                entity.Property(e => e.DirecciónDeTratamiento)
                    .IsUnicode(false)
                    .HasColumnName("Dirección de Tratamiento");

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.FechaDeGestion)
                    .HasColumnType("datetime")
                    .HasColumnName("Fecha de Gestion");

                entity.Property(e => e.FechaDeTratamiento)
                    .HasColumnType("datetime")
                    .HasColumnName("Fecha de Tratamiento");

                entity.Property(e => e.Fracción)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.MunicipioDeGestion)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("Municipio de Gestion");

                entity.Property(e => e.MunicipioDeTratamiento)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("Municipio de Tratamiento");

                entity.Property(e => e.PaisDeTratamiento).HasColumnName("Pais de Tratamiento");

                entity.Property(e => e.PesoCalculado).HasColumnName("pesoCalculado");

                entity.Property(e => e.PesoEstimado).HasColumnName("pesoEstimado");

                entity.Property(e => e.PesoReal).HasColumnName("pesoReal");

                entity.Property(e => e.PidEstadoRaee).HasColumnName("pidEstadoRAEE");

                entity.Property(e => e.PidResiduo).HasColumnName("pidResiduo");

                entity.Property(e => e.ProvinciaDeGestion)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("Provincia de Gestion");

                entity.Property(e => e.ProvinciaDeTratamiento)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("Provincia de Tratamiento");

                entity.Property(e => e.Residuo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ResiduoEspecífico)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("Residuo Específico");

                entity.Property(e => e.SidResiduo).HasColumnName("sidResiduo");

                entity.Property(e => e.TerceroDeGestion).HasColumnName("Tercero de Gestion");

                entity.Property(e => e.TerceroDeTratamiento).HasColumnName("Tercero de Tratamiento");

                entity.Property(e => e.TipoContenedor)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("Tipo Contenedor");
            });

            modelBuilder.Entity<FichaCompletaRaeeRecogidaRecepcion>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("FichaCompletaRAEE_RecogidaRecepcion");

                entity.Property(e => e.Canibalizado).HasColumnName("canibalizado");

                entity.Property(e => e.CódigoDirecciónDeGestion).HasColumnName("Código Dirección de Gestion");

                entity.Property(e => e.CódigoRaee)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Código RAEE");

                entity.Property(e => e.CódigoTerceroDeGestion).HasColumnName("Código Tercero de Gestion");

                entity.Property(e => e.DireccionDeGestion)
                    .IsUnicode(false)
                    .HasColumnName("Direccion de Gestion");

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.FechaDeGestion)
                    .HasColumnType("datetime")
                    .HasColumnName("Fecha de Gestion");

                entity.Property(e => e.Fracción)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.MunicipioDeGestion)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("Municipio de Gestion");

                entity.Property(e => e.PesoCalculado).HasColumnName("pesoCalculado");

                entity.Property(e => e.PesoEstimado).HasColumnName("pesoEstimado");

                entity.Property(e => e.PesoReal).HasColumnName("pesoReal");

                entity.Property(e => e.ProvinciaDeGestion)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("Provincia de Gestion");

                entity.Property(e => e.ResiduoEspecífico)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("Residuo Específico");

                entity.Property(e => e.TerceroDeGestion).HasColumnName("Tercero de Gestion");

                entity.Property(e => e.TipoContenedor)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("Tipo Contenedor");
            });

            modelBuilder.Entity<FirmasCertificado>(entity =>
            {
                entity.HasKey(e => e.PidFirmaCertificado);

                entity.ToTable("FirmasCertificado");

                entity.Property(e => e.PidFirmaCertificado)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("pidFirmaCertificado");

                entity.Property(e => e.Cargo)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("cargo");

                entity.Property(e => e.Firma)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("firma");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<FotosRaeecertificado>(entity =>
            {
                entity.HasKey(e => e.PidFotoRaeecertificado);

                entity.ToTable("FotosRAEECertificado");

                entity.Property(e => e.PidFotoRaeecertificado)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("pidFotoRAEECertificado");

                entity.Property(e => e.NombreFichero)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("nombreFichero");

                entity.Property(e => e.SidRaeecertificado)
                    .IsRequired()
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("sidRAEECertificado");
            });

            modelBuilder.Entity<Fraccione>(entity =>
            {
                entity.HasKey(e => e.PidFraccion)
                    .HasName("PK_FRACCIONES");

                entity.HasIndex(e => e.Estado, "Estado_Fracciones")
                    .HasFillFactor(80);

                entity.HasIndex(e => e.Rowguid, "MSmerge_index_851793321")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.Property(e => e.PidFraccion)
                    .ValueGeneratedNever()
                    .HasColumnName("pidFraccion");

                entity.Property(e => e.Estado)
                    .HasColumnName("estado")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("nombre");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("rowguid")
                    .HasDefaultValueSql("(newsequentialid())");
            });

            modelBuilder.Entity<FraccionesTiposContenedor>(entity =>
            {
                entity.HasKey(e => e.PidFraccionTipoContenedor);

                entity.ToTable("FraccionesTiposContenedor");

                entity.HasIndex(e => e.Estado, "Estado_FraccionesTiposContenedor")
                    .HasFillFactor(80);

                entity.HasIndex(e => e.Rowguid, "MSmerge_index_364839591")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.Property(e => e.PidFraccionTipoContenedor)
                    .ValueGeneratedNever()
                    .HasColumnName("pidFraccionTipoContenedor");

                entity.Property(e => e.Estado)
                    .HasColumnName("estado")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.PesoMedio).HasColumnName("pesoMedio");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("rowguid")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.SidFraccion).HasColumnName("sidFraccion");

                entity.Property(e => e.SidTipoContenedor).HasColumnName("sidTipoContenedor");
            });

            modelBuilder.Entity<GraficaOnlineWeeeTrace>(entity =>
            {
                entity.HasKey(e => e.PidGrafica);

                entity.ToTable("GraficaOnline_WeeeTrace");

                entity.HasIndex(e => e.Fecha, "IX_FECHA")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.Property(e => e.PidGrafica).HasColumnName("pidGrafica");

                entity.Property(e => e.Fecha)
                    .HasColumnType("date")
                    .HasColumnName("fecha");
            });

            modelBuilder.Entity<GraficaPortal>(entity =>
            {
                entity.HasKey(e => e.Pid);

                entity.ToTable("GraficaPortal");

                entity.Property(e => e.Pid).HasColumnName("pid");

                entity.Property(e => e.Fecha).HasColumnType("datetime");
            });

            modelBuilder.Entity<HistoricoCambio>(entity =>
            {
                entity.HasKey(e => e.PidHistoricoCambio);

                entity.HasIndex(e => new { e.Fecha, e.SidRaee }, "IX_FECHA")
                    .HasFillFactor(80);

                entity.HasIndex(e => new { e.Fecha, e.CanibalizadoAntes, e.SidRaee }, "IX_FECHA_CANI")
                    .HasFillFactor(80);

                entity.HasIndex(e => e.SidRaee, "IX_RAEE")
                    .HasFillFactor(80);

                entity.HasIndex(e => e.SidResiduoEspecificoAntes, "IX_RES_ESP_ANTES")
                    .HasFillFactor(80);

                entity.HasIndex(e => e.SidResiduoEspecificoDespues, "IX_RES_ESP_DESPUES")
                    .HasFillFactor(80);

                entity.Property(e => e.PidHistoricoCambio)
                    .ValueGeneratedNever()
                    .HasColumnName("pidHistoricoCambio");

                entity.Property(e => e.CanibalizadoAntes).HasColumnName("canibalizadoAntes");

                entity.Property(e => e.CanibalizadoDespues).HasColumnName("canibalizadoDespues");

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha");

                entity.Property(e => e.SidCertificado)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("sidCertificado");

                entity.Property(e => e.SidEstadoAntes).HasColumnName("sidEstadoAntes");

                entity.Property(e => e.SidEstadoDespues).HasColumnName("sidEstadoDespues");

                entity.Property(e => e.SidRaee)
                    .HasMaxLength(50)
                    .HasColumnName("sidRAEE");

                entity.Property(e => e.SidRaeecertificado)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("sidRAEECertificado");

                entity.Property(e => e.SidResiduoEspecificoAntes).HasColumnName("sidResiduoEspecificoAntes");

                entity.Property(e => e.SidResiduoEspecificoDespues).HasColumnName("sidResiduoEspecificoDespues");

                entity.Property(e => e.SidTipoDeContenedorAntes).HasColumnName("sidTipoDeContenedorAntes");

                entity.Property(e => e.SidTipoDeContenedorDespues).HasColumnName("sidTipoDeContenedorDespues");

                entity.HasOne(d => d.SidCertificadoNavigation)
                    .WithMany(p => p.HistoricoCambios)
                    .HasForeignKey(d => d.SidCertificado)
                    .HasConstraintName("FK_HistoricoCambios_Certificados");

                entity.HasOne(d => d.SidEstadoAntesNavigation)
                    .WithMany(p => p.HistoricoCambioSidEstadoAntesNavigations)
                    .HasForeignKey(d => d.SidEstadoAntes)
                    .HasConstraintName("FK_HistoricoCambios_EstadosRAEEAntes");

                entity.HasOne(d => d.SidEstadoDespuesNavigation)
                    .WithMany(p => p.HistoricoCambioSidEstadoDespuesNavigations)
                    .HasForeignKey(d => d.SidEstadoDespues)
                    .HasConstraintName("FK_HistoricoCambios_EstadosRAEEDespues");

                entity.HasOne(d => d.SidRaeeNavigation)
                    .WithMany(p => p.HistoricoCambios)
                    .HasForeignKey(d => d.SidRaee)
                    .HasConstraintName("FK_HistoricoCambios_RAEEs");

                entity.HasOne(d => d.SidResiduoEspecificoAntesNavigation)
                    .WithMany(p => p.HistoricoCambioSidResiduoEspecificoAntesNavigations)
                    .HasForeignKey(d => d.SidResiduoEspecificoAntes)
                    .HasConstraintName("FK_HistoricoCambios_ResiduosEspecificosAntes");

                entity.HasOne(d => d.SidResiduoEspecificoDespuesNavigation)
                    .WithMany(p => p.HistoricoCambioSidResiduoEspecificoDespuesNavigations)
                    .HasForeignKey(d => d.SidResiduoEspecificoDespues)
                    .HasConstraintName("FK_HistoricoCambios_ResiduosEspecificosDespues");

                entity.HasOne(d => d.SidTipoDeContenedorAntesNavigation)
                    .WithMany(p => p.HistoricoCambioSidTipoDeContenedorAntesNavigations)
                    .HasForeignKey(d => d.SidTipoDeContenedorAntes)
                    .HasConstraintName("FK_HistoricoCambios_TiposContenedorAntes");

                entity.HasOne(d => d.SidTipoDeContenedorDespuesNavigation)
                    .WithMany(p => p.HistoricoCambioSidTipoDeContenedorDespuesNavigations)
                    .HasForeignKey(d => d.SidTipoDeContenedorDespues)
                    .HasConstraintName("FK_HistoricoCambios_TiposContenedorDespues");
            });

            modelBuilder.Entity<HistoricoCambiosCertificado>(entity =>
            {
                entity.HasKey(e => e.PidHistoricoCambioCertificado);

                entity.Property(e => e.PidHistoricoCambioCertificado).HasColumnName("pidHistoricoCambioCertificado");

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha");

                entity.Property(e => e.SidCertificado)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("sidCertificado");

                entity.Property(e => e.SidEstadoAntes).HasColumnName("sidEstadoAntes");

                entity.Property(e => e.SidEstadoDespues).HasColumnName("sidEstadoDespues");

                entity.HasOne(d => d.SidCertificadoNavigation)
                    .WithMany(p => p.HistoricoCambiosCertificados)
                    .HasForeignKey(d => d.SidCertificado)
                    .HasConstraintName("FK_HistoricoCambiosCertificados_Certificados");

                entity.HasOne(d => d.SidEstadoAntesNavigation)
                    .WithMany(p => p.HistoricoCambiosCertificadoSidEstadoAntesNavigations)
                    .HasForeignKey(d => d.SidEstadoAntes)
                    .HasConstraintName("FK_HistoricoCambiosCertificados_EstadosCertificado_ANTES");

                entity.HasOne(d => d.SidEstadoDespuesNavigation)
                    .WithMany(p => p.HistoricoCambiosCertificadoSidEstadoDespuesNavigations)
                    .HasForeignKey(d => d.SidEstadoDespues)
                    .HasConstraintName("FK_HistoricoCambiosCertificados_EstadosCertificado_DESPUES");
            });

            modelBuilder.Entity<HistoricoCambiosTiposCertificado>(entity =>
            {
                entity.HasKey(e => e.PidCambioTipoCertificado);

                entity.ToTable("HistoricoCambiosTiposCertificado");

                entity.Property(e => e.PidCambioTipoCertificado).HasColumnName("pidCambioTipoCertificado");

                entity.Property(e => e.AnteriorCertificado)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha");

                entity.Property(e => e.NuevoCertificado)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HistoricoPesada>(entity =>
            {
                entity.HasKey(e => e.PidPesada);

                entity.Property(e => e.PidPesada).HasColumnName("pidPesada");

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha");

                entity.Property(e => e.Peso).HasColumnName("peso");

                entity.Property(e => e.SidCertificado)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("sidCertificado");

                entity.Property(e => e.SidCertificadoSubordinado)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("sidCertificadoSubordinado");

                entity.Property(e => e.SidDireccion).HasColumnName("sidDireccion");

                entity.Property(e => e.SidFraccion).HasColumnName("sidFraccion");

                entity.Property(e => e.SidTercero).HasColumnName("sidTercero");

                entity.HasOne(d => d.SidDireccionNavigation)
                    .WithMany(p => p.HistoricoPesada)
                    .HasForeignKey(d => d.SidDireccion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HistoricoPesadas_DireccionesTercero");

                entity.HasOne(d => d.SidFraccionNavigation)
                    .WithMany(p => p.HistoricoPesada)
                    .HasForeignKey(d => d.SidFraccion)
                    .HasConstraintName("FK_HistoricoPesadas_Fracciones");

                entity.HasOne(d => d.SidTerceroNavigation)
                    .WithMany(p => p.HistoricoPesada)
                    .HasForeignKey(d => d.SidTercero)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HistoricoPesadas_Terceros");
            });

            modelBuilder.Entity<HistoricoPesosRaee>(entity =>
            {
                entity.HasKey(e => e.PidHistorico);

                entity.ToTable("HistoricoPesosRAEE");

                entity.Property(e => e.PidHistorico).HasColumnName("pidHistorico");

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha");

                entity.Property(e => e.Peso).HasColumnName("peso");

                entity.Property(e => e.SidCertificado)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("sidCertificado");

                entity.Property(e => e.SidRaee)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("sidRAEE");

                entity.HasOne(d => d.SidCertificadoNavigation)
                    .WithMany(p => p.HistoricoPesosRaees)
                    .HasForeignKey(d => d.SidCertificado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HistoricoPesosRAEE_Certificados");

                entity.HasOne(d => d.SidRaeeNavigation)
                    .WithMany(p => p.HistoricoPesosRaees)
                    .HasForeignKey(d => d.SidRaee)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HistoricoPesosRAEE_RAEEs");
            });

            modelBuilder.Entity<I49EmisorOrigen>(entity =>
            {
                entity.HasKey(e => new { e.EmisorTercero, e.EmisorDireccion, e.OrigenTercero, e.OrigenDireccion });

                entity.ToTable("i49_EmisorOrigen");
            });

            modelBuilder.Entity<Incidencia>(entity =>
            {
                entity.HasKey(e => e.PidIncidencia);

                entity.HasIndex(e => e.SidCertificado, "IX_CERTIFICADO")
                    .HasFillFactor(80);

                entity.HasIndex(e => e.Fecha, "IX_FECHA")
                    .HasFillFactor(80);

                entity.HasIndex(e => new { e.Fecha, e.SidTipoIncidencia }, "IX_FECHA_TIPO")
                    .HasFillFactor(80);

                entity.HasIndex(e => e.SidRaee, "IX_RAEE")
                    .HasFillFactor(80);

                entity.HasIndex(e => e.SidTercero, "IX_TERCERO")
                    .HasFillFactor(80);

                entity.Property(e => e.PidIncidencia)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("pidIncidencia");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha");

                entity.Property(e => e.FechaCambioEstado)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaCambioEstado");

                entity.Property(e => e.SidCertificado)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("sidCertificado");

                entity.Property(e => e.SidEstadoIncidencia).HasColumnName("sidEstadoIncidencia");

                entity.Property(e => e.SidRaee)
                    .HasMaxLength(50)
                    .HasColumnName("sidRAEE");

                entity.Property(e => e.SidTercero).HasColumnName("sidTercero");

                entity.Property(e => e.SidTipoIncidencia).HasColumnName("sidTipoIncidencia");

                entity.HasOne(d => d.SidCertificadoNavigation)
                    .WithMany(p => p.Incidencia)
                    .HasForeignKey(d => d.SidCertificado)
                    .HasConstraintName("FK_Incidencias_Certificados");
            });

            modelBuilder.Entity<IndicadoresDireccionTerceroFraccion>(entity =>
            {
                entity.HasKey(e => e.PidIndicadorDireccionTerceroFraccion);

                entity.ToTable("IndicadoresDireccionTerceroFraccion");

                entity.HasIndex(e => new { e.Mes, e.Anyo, e.SidDireccionTercero, e.SidFraccion }, "IX_MES_ANIO_DIR_FRA")
                    .HasFillFactor(80);

                entity.Property(e => e.PidIndicadorDireccionTerceroFraccion).HasColumnName("pidIndicadorDireccionTerceroFraccion");

                entity.Property(e => e.Anyo).HasColumnName("anyo");

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha");

                entity.Property(e => e.Mes).HasColumnName("mes");

                entity.Property(e => e.NumRaeeconFoto).HasColumnName("NumRAEEconFoto");

                entity.Property(e => e.NumRaeelecturas).HasColumnName("NumRAEELecturas");

                entity.Property(e => e.NumRaeeperdidos).HasColumnName("NumRAEEPerdidos");

                entity.Property(e => e.NumRaeerecogido).HasColumnName("NumRAEERecogido");

                entity.Property(e => e.NumRaeerecogidoCanibalizado).HasColumnName("NumRAEERecogidoCanibalizado");

                entity.Property(e => e.NumRaeerecogidoInicial).HasColumnName("NumRAEERecogidoInicial");

                entity.Property(e => e.NumRaeetratado).HasColumnName("NumRAEETratado");

                entity.Property(e => e.NumRaeetratadoComoPlanta).HasColumnName("NumRAEETratadoComoPlanta");

                entity.Property(e => e.NumRaeetratadoComoPlantaCanibalizado).HasColumnName("NumRAEETratadoComoPlantaCanibalizado");

                entity.Property(e => e.SidDireccionTercero).HasColumnName("sidDireccionTercero");

                entity.Property(e => e.SidFraccion).HasColumnName("sidFraccion");

                entity.Property(e => e.SumVidaRaee).HasColumnName("SumVidaRAEE");

                entity.Property(e => e.SumVidaRaeetercero).HasColumnName("SumVidaRAEETercero");

                entity.Property(e => e.SumVidaRaeetratadoComoPlanta).HasColumnName("SumVidaRAEETratadoComoPlanta");

                entity.Property(e => e.Trimestre).HasColumnName("trimestre");

                entity.HasOne(d => d.SidDireccionTerceroNavigation)
                    .WithMany(p => p.IndicadoresDireccionTerceroFraccions)
                    .HasForeignKey(d => d.SidDireccionTercero)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IndicadoresDireccionTerceroFraccion_DireccionesTercero");

                entity.HasOne(d => d.SidFraccionNavigation)
                    .WithMany(p => p.IndicadoresDireccionTerceroFraccions)
                    .HasForeignKey(d => d.SidFraccion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IndicadoresDireccionTerceroFraccion_Fracciones");
            });

            modelBuilder.Entity<InfCicloVidum>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Inf_CicloVida");

                entity.Property(e => e.CerTratDireccionGestor)
                    .HasMaxLength(50)
                    .HasColumnName("CerTrat_DireccionGestor");

                entity.Property(e => e.CerTratFecha)
                    .HasColumnType("datetime")
                    .HasColumnName("CerTrat_Fecha");

                entity.Property(e => e.CerTratGestor)
                    .HasMaxLength(50)
                    .HasColumnName("CerTrat_Gestor");

                entity.Property(e => e.CerTratSidDireccionGestor).HasColumnName("CerTrat_sidDireccionGestor");

                entity.Property(e => e.CerTratSidGestor).HasColumnName("CerTrat_sidGestor");

                entity.Property(e => e.CerTratSidTipoLectura).HasColumnName("CerTrat_sidTipoLectura");

                entity.Property(e => e.CerTratTipo)
                    .HasMaxLength(50)
                    .HasColumnName("CerTrat_Tipo");

                entity.Property(e => e.CerTratVideo).HasColumnName("CerTrat_Video");

                entity.Property(e => e.DiasIdentificacionTorecogRecept).HasColumnName("DiasIdentificacionTORecogRecept");

                entity.Property(e => e.DiasRecogReceptTotratamiento).HasColumnName("DiasRecogReceptTOTratamiento");

                entity.Property(e => e.FechaInforme).HasColumnType("datetime");

                entity.Property(e => e.NcerEntre).HasColumnName("NCer_Entre");

                entity.Property(e => e.NcerIdent).HasColumnName("NCer_Ident");

                entity.Property(e => e.NcerRecep).HasColumnName("NCer_Recep");

                entity.Property(e => e.NcerRecog).HasColumnName("NCer_Recog");

                entity.Property(e => e.NcerTrata).HasColumnName("NCer_Trata");

                entity.Property(e => e.Pcident)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PCIdent");

                entity.Property(e => e.PcidentDirEmisor)
                    .HasMaxLength(50)
                    .HasColumnName("PCIdent_DirEmisor");

                entity.Property(e => e.PcidentEmisor)
                    .HasMaxLength(50)
                    .HasColumnName("PCIdent_Emisor");

                entity.Property(e => e.PcidentFecha)
                    .HasColumnType("datetime")
                    .HasColumnName("PCIdent_Fecha");

                entity.Property(e => e.PcidentNcerGvr)
                    .HasMaxLength(50)
                    .HasColumnName("PCIdent_NCerGVR");

                entity.Property(e => e.PcidentSidDirEmisor).HasColumnName("PCIdent_sidDirEmisor");

                entity.Property(e => e.PcidentSidEmisor).HasColumnName("PCIdent_sidEmisor");

                entity.Property(e => e.PcrcRda)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PCRcRda");

                entity.Property(e => e.PcrcRdaDirEmisor)
                    .HasMaxLength(50)
                    .HasColumnName("PCRcRda_DirEmisor");

                entity.Property(e => e.PcrcRdaEmisor)
                    .HasMaxLength(50)
                    .HasColumnName("PCRcRda_Emisor");

                entity.Property(e => e.PcrcRdaFecha)
                    .HasColumnType("datetime")
                    .HasColumnName("PCRcRda_Fecha");

                entity.Property(e => e.PcrcRdaNcerGvr)
                    .HasMaxLength(50)
                    .HasColumnName("PCRcRda_NCerGVR");

                entity.Property(e => e.PcrcRdaSidDirEmisor).HasColumnName("PCRcRda_sidDirEmisor");

                entity.Property(e => e.PcrcRdaSidEmisor).HasColumnName("PCRcRda_sidEmisor");

                entity.Property(e => e.PidInformeCicloVida)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("pidInformeCicloVida");

                entity.Property(e => e.Raee)
                    .HasMaxLength(50)
                    .HasColumnName("RAEE");

                entity.Property(e => e.RaeeDireccionGestorActual)
                    .HasMaxLength(50)
                    .HasColumnName("RAEE_DireccionGestorActual");

                entity.Property(e => e.RaeeEstadoRaee)
                    .HasMaxLength(50)
                    .HasColumnName("RAEE_EstadoRAEE");

                entity.Property(e => e.RaeeFraccion)
                    .HasMaxLength(50)
                    .HasColumnName("RAEE_Fraccion");

                entity.Property(e => e.RaeeGestorActual)
                    .HasMaxLength(50)
                    .HasColumnName("RAEE_GestorActual");

                entity.Property(e => e.RaeePesoEstimado).HasColumnName("RAEE_pesoEstimado");

                entity.Property(e => e.RaeePesoReal).HasColumnName("RAEE_pesoReal");

                entity.Property(e => e.RaeeResiduo)
                    .HasMaxLength(50)
                    .HasColumnName("RAEE_Residuo");

                entity.Property(e => e.RaeeResiduoEspecifico)
                    .HasMaxLength(50)
                    .HasColumnName("RAEE_ResiduoEspecifico");

                entity.Property(e => e.RaeeSidDireccionGestorActual).HasColumnName("RAEE_sidDireccionGestorActual");

                entity.Property(e => e.RaeeSidEstadoRaee).HasColumnName("RAEE_sidEstadoRAEE");

                entity.Property(e => e.RaeeSidFraccion).HasColumnName("RAEE_sidFraccion");

                entity.Property(e => e.RaeeSidGestorActual).HasColumnName("RAEE_sidGestorActual");

                entity.Property(e => e.RaeeSidResiduo).HasColumnName("RAEE_sidResiduo");

                entity.Property(e => e.RaeeSidResiduoEspecifico).HasColumnName("RAEE_sidResiduoEspecifico");

                entity.Property(e => e.UcrcRda)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("UCRcRda");

                entity.Property(e => e.UcrcRdaDirEmisor)
                    .HasMaxLength(50)
                    .HasColumnName("UCRcRda_DirEmisor");

                entity.Property(e => e.UcrcRdaEmisor)
                    .HasMaxLength(50)
                    .HasColumnName("UCRcRda_Emisor");

                entity.Property(e => e.UcrcRdaFecha)
                    .HasColumnType("datetime")
                    .HasColumnName("UCRcRda_Fecha");

                entity.Property(e => e.UcrcRdaNcerGvr)
                    .HasMaxLength(50)
                    .HasColumnName("UCRcRda_NCerGVR");

                entity.Property(e => e.UcrcRdaSidDirEmisor).HasColumnName("UCRcRda_sidDirEmisor");

                entity.Property(e => e.UcrcRdaSidEmisor).HasColumnName("UCRcRda_sidEmisor");
            });

            modelBuilder.Entity<Informe>(entity =>
            {
                entity.HasKey(e => e.PidInforme);

                entity.Property(e => e.PidInforme).HasColumnName("pidInforme");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ruta)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Server)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo).HasDefaultValueSql("((1))");

                entity.Property(e => e.Url)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("URL");

                entity.Property(e => e.Usuario)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<InformeCicloVidum>(entity =>
            {
                entity.HasKey(e => e.PidInformeCicloVida)
                    .HasName("PK_InformeCicloVidaV2");

                entity.HasIndex(e => e.CerTratFecha, "IX_FECHA_TRAT")
                    .HasFillFactor(80);

                entity.HasIndex(e => e.CerTratYear, "IX_YEAR")
                    .HasFillFactor(80);

                entity.HasIndex(e => e.Raee, "RAEE")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.Property(e => e.PidInformeCicloVida).HasColumnName("pidInformeCicloVida");

                entity.Property(e => e.CerTratCcaaTratamiento)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("CerTrat_CCAA_Tratamiento");

                entity.Property(e => e.CerTratDireccionGestor)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("CerTrat_DireccionGestor");

                entity.Property(e => e.CerTratFecha)
                    .HasColumnType("datetime")
                    .HasColumnName("CerTrat_Fecha");

                entity.Property(e => e.CerTratGestor)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("CerTrat_Gestor");

                entity.Property(e => e.CerTratMunicipioTratamiento)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("CerTrat_Municipio_Tratamiento");

                entity.Property(e => e.CerTratProvTratamiento)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("CerTrat_Prov_Tratamiento");

                entity.Property(e => e.CerTratSidDireccionGestor).HasColumnName("CerTrat_sidDireccionGestor");

                entity.Property(e => e.CerTratSidGestor).HasColumnName("CerTrat_sidGestor");

                entity.Property(e => e.CerTratSidTipoLectura).HasColumnName("CerTrat_sidTipoLectura");

                entity.Property(e => e.CerTratTipo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CerTrat_Tipo");

                entity.Property(e => e.CerTratVideo).HasColumnName("CerTrat_Video");

                entity.Property(e => e.CerTratYear).HasColumnName("CerTrat_YEAR");

                entity.Property(e => e.DiasIdentificacionTorecogRecept).HasColumnName("DiasIdentificacionTORecogRecept");

                entity.Property(e => e.DiasRecogReceptTotratamiento).HasColumnName("DiasRecogReceptTOTratamiento");

                entity.Property(e => e.FechaInforme).HasColumnType("datetime");

                entity.Property(e => e.NcerEntre).HasColumnName("NCer_Entre");

                entity.Property(e => e.NcerIdent).HasColumnName("NCer_Ident");

                entity.Property(e => e.NcerRecep).HasColumnName("NCer_Recep");

                entity.Property(e => e.NcerRecog).HasColumnName("NCer_Recog");

                entity.Property(e => e.NcerTrata).HasColumnName("NCer_Trata");

                entity.Property(e => e.PcCcaaOrigen)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("PC_CCAA_Origen");

                entity.Property(e => e.PcDirOrigen)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("PC_Dir_Origen");

                entity.Property(e => e.PcMunicipioOrigen)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("PC_Municipio_Origen");

                entity.Property(e => e.PcNcer)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PC_NCer");

                entity.Property(e => e.PcNcerGvr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PC_NCerGVR");

                entity.Property(e => e.PcProvOrigen)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("PC_Prov_Origen");

                entity.Property(e => e.PcSidDirOrigen).HasColumnName("PC_sidDir_Origen");

                entity.Property(e => e.PcSidTerOrigen).HasColumnName("PC_sidTer_Origen");

                entity.Property(e => e.PcTerOrigen)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("PC_Ter_Origen");

                entity.Property(e => e.Pcident)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PCIdent");

                entity.Property(e => e.PcidentCcaaEmisor)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("PCIdent_CCAA_Emisor");

                entity.Property(e => e.PcidentDirEmisor)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("PCIdent_DirEmisor");

                entity.Property(e => e.PcidentEmisor)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("PCIdent_Emisor");

                entity.Property(e => e.PcidentFecha)
                    .HasColumnType("datetime")
                    .HasColumnName("PCIdent_Fecha");

                entity.Property(e => e.PcidentMunicipioEmisor)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("PCIdent_Municipio_Emisor");

                entity.Property(e => e.PcidentNcerGvr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PCIdent_NCerGVR");

                entity.Property(e => e.PcidentProvEmisor)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("PCIdent_Prov_Emisor");

                entity.Property(e => e.PcidentSidDirEmisor).HasColumnName("PCIdent_sidDirEmisor");

                entity.Property(e => e.PcidentSidEmisor).HasColumnName("PCIdent_sidEmisor");

                entity.Property(e => e.PcrcRda)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PCRcRda");

                entity.Property(e => e.PcrcRdaAlbaranOrigen)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("PCRcRda_AlbaranOrigen");

                entity.Property(e => e.PcrcRdaCcaaEmisor)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("PCRcRda_CCAA_Emisor");

                entity.Property(e => e.PcrcRdaCcaaOrigen)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("PCRcRda_CCAA_Origen");

                entity.Property(e => e.PcrcRdaDirEmisor)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("PCRcRda_DirEmisor");

                entity.Property(e => e.PcrcRdaDirOrigen)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("PCRcRda_DirOrigen");

                entity.Property(e => e.PcrcRdaEmisor)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("PCRcRda_Emisor");

                entity.Property(e => e.PcrcRdaFecha)
                    .HasColumnType("datetime")
                    .HasColumnName("PCRcRda_Fecha");

                entity.Property(e => e.PcrcRdaMunicipioEmisor)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("PCRcRda_Municipio_Emisor");

                entity.Property(e => e.PcrcRdaMunicipioOrigen)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("PCRcRda_Municipio_Origen");

                entity.Property(e => e.PcrcRdaNcerGvr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PCRcRda_NCerGVR");

                entity.Property(e => e.PcrcRdaProvEmisor)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("PCRcRda_Prov_Emisor");

                entity.Property(e => e.PcrcRdaProvOrigen)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("PCRcRda_Prov_Origen");

                entity.Property(e => e.PcrcRdaSidDirEmisor).HasColumnName("PCRcRda_sidDirEmisor");

                entity.Property(e => e.PcrcRdaSidDirOrigen).HasColumnName("PCRcRda_sidDirOrigen");

                entity.Property(e => e.PcrcRdaSidEmisor).HasColumnName("PCRcRda_sidEmisor");

                entity.Property(e => e.PcrcRdaSidTerOrigen).HasColumnName("PCRcRda_sidTerOrigen");

                entity.Property(e => e.PcrcRdaTerOrigen)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("PCRcRda_TerOrigen");

                entity.Property(e => e.Raee)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RAEE");

                entity.Property(e => e.RaeeDestino)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("RAEE_Destino");

                entity.Property(e => e.RaeeDireccionGestorActual)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("RAEE_DireccionGestorActual");

                entity.Property(e => e.RaeeEcotrazo)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("RAEE_Ecotrazo");

                entity.Property(e => e.RaeeEstadoRaee)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RAEE_EstadoRAEE");

                entity.Property(e => e.RaeeFraccion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RAEE_Fraccion");

                entity.Property(e => e.RaeeGestorActual)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("RAEE_GestorActual");

                entity.Property(e => e.RaeeGestorCcaa)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("RAEE_Gestor_CCAA");

                entity.Property(e => e.RaeeGestorMunicipio)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("RAEE_Gestor_Municipio");

                entity.Property(e => e.RaeeGestorProv)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("RAEE_Gestor_Prov");

                entity.Property(e => e.RaeeMarca)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("RAEE_Marca");

                entity.Property(e => e.RaeePesoEstimado).HasColumnName("RAEE_pesoEstimado");

                entity.Property(e => e.RaeePesoReal).HasColumnName("RAEE_pesoReal");

                entity.Property(e => e.RaeeResiduo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RAEE_Residuo");

                entity.Property(e => e.RaeeResiduoEspecifico)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RAEE_ResiduoEspecifico");

                entity.Property(e => e.RaeeSerie)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("RAEE_Serie");

                entity.Property(e => e.RaeeSidDireccionGestorActual).HasColumnName("RAEE_sidDireccionGestorActual");

                entity.Property(e => e.RaeeSidEstadoRaee).HasColumnName("RAEE_sidEstadoRAEE");

                entity.Property(e => e.RaeeSidFraccion).HasColumnName("RAEE_sidFraccion");

                entity.Property(e => e.RaeeSidGestorActual).HasColumnName("RAEE_sidGestorActual");

                entity.Property(e => e.RaeeSidResiduo).HasColumnName("RAEE_sidResiduo");

                entity.Property(e => e.RaeeSidResiduoEspecifico).HasColumnName("RAEE_sidResiduoEspecifico");

                entity.Property(e => e.UcCcaaEmisor)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("UC_CCAA_Emisor");

                entity.Property(e => e.UcDirEmisor)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("UC_Dir_Emisor");

                entity.Property(e => e.UcMunicipioEmisor)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("UC_Municipio_Emisor");

                entity.Property(e => e.UcNcer)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("UC_NCer");

                entity.Property(e => e.UcNcerGvr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UC_NCerGVR");

                entity.Property(e => e.UcProvEmisor)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("UC_Prov_Emisor");

                entity.Property(e => e.UcSidDirEmisor).HasColumnName("UC_sidDir_Emisor");

                entity.Property(e => e.UcSidTerEmisor).HasColumnName("UC_sidTer_Emisor");

                entity.Property(e => e.UcTerEmisor)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("UC_Ter_Emisor");

                entity.Property(e => e.UcrcRda)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("UCRcRda");

                entity.Property(e => e.UcrcRdaCcaaEmisor)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("UCRcRda_CCAA_Emisor");

                entity.Property(e => e.UcrcRdaDirEmisor)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("UCRcRda_DirEmisor");

                entity.Property(e => e.UcrcRdaEmisor)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("UCRcRda_Emisor");

                entity.Property(e => e.UcrcRdaFecha)
                    .HasColumnType("datetime")
                    .HasColumnName("UCRcRda_Fecha");

                entity.Property(e => e.UcrcRdaMunicipioEmisor)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("UCRcRda_Municipio_Emisor");

                entity.Property(e => e.UcrcRdaNcerGvr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UCRcRda_NCerGVR");

                entity.Property(e => e.UcrcRdaProvEmisor)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("UCRcRda_Prov_Emisor");

                entity.Property(e => e.UcrcRdaSidDirEmisor).HasColumnName("UCRcRda_sidDirEmisor");

                entity.Property(e => e.UcrcRdaSidEmisor).HasColumnName("UCRcRda_sidEmisor");
            });

            modelBuilder.Entity<InventariosFisico>(entity =>
            {
                entity.HasKey(e => e.PidInventarioFisico);

                entity.Property(e => e.PidInventarioFisico)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("pidInventarioFisico");

                entity.Property(e => e.Auditor).HasColumnName("auditor");

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha");

                entity.Property(e => e.SidDireccionTercero).HasColumnName("sidDireccionTercero");

                entity.Property(e => e.SidTercero).HasColumnName("sidTercero");

                entity.HasOne(d => d.SidDireccionTerceroNavigation)
                    .WithMany(p => p.InventariosFisicos)
                    .HasForeignKey(d => d.SidDireccionTercero)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InventariosFisicos_DireccionesTercero");

                entity.HasOne(d => d.SidTerceroNavigation)
                    .WithMany(p => p.InventariosFisicos)
                    .HasForeignKey(d => d.SidTercero)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InventariosFisicos_Terceros");
            });

            modelBuilder.Entity<InventariosFisicosRaee>(entity =>
            {
                entity.HasKey(e => e.PidInventarioFisicoRaee);

                entity.ToTable("InventariosFisicosRAEEs");

                entity.Property(e => e.PidInventarioFisicoRaee)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("pidInventarioFisicoRAEE");

                entity.Property(e => e.SidInventarioFisico)
                    .IsRequired()
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("sidInventarioFisico");

                entity.Property(e => e.SidRaee)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("sidRAEE");

                entity.HasOne(d => d.SidInventarioFisicoNavigation)
                    .WithMany(p => p.InventariosFisicosRaees)
                    .HasForeignKey(d => d.SidInventarioFisico)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InventariosFisicosRAEEs_InventariosFisicos");
            });

            modelBuilder.Entity<LksEcoappComprobacionCentro>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LKS_ECOAPP_Comprobacion_Centros");

                entity.Property(e => e.CodEcoapp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("codECOAPP");

                entity.Property(e => e.CodGtr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("codGTR");

                entity.Property(e => e.Encontrado).HasColumnName("encontrado");
            });

            modelBuilder.Entity<LksEcoappComprobacionTercero>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LKS_ECOAPP_Comprobacion_Terceros");

                entity.Property(e => e.CodEcoapp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("codECOAPP");

                entity.Property(e => e.CodGtr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("codGTR");

                entity.Property(e => e.Encontrado).HasColumnName("encontrado");
            });

            modelBuilder.Entity<LksJobsCompletarCertificadosIndentificacionTercero>(entity =>
            {
                entity.HasKey(e => e.SidTercero)
                    .HasName("PK_Terceros_Completar_CertificadosIndentficacion");

                entity.ToTable("LKS_Jobs_Completar_Certificados_Indentificacion_Terceros");

                entity.Property(e => e.SidTercero)
                    .ValueGeneratedNever()
                    .HasColumnName("sidTercero");
            });

            modelBuilder.Entity<LksRaeesProblemaEtiqueta>(entity =>
            {
                entity.HasKey(e => e.OldRaee);

                entity.ToTable("LKS_RAEEs_PROBLEMA_ETIQUETAS");

                entity.HasIndex(e => new { e.OldRaee, e.NewRaee }, "IX_DATPS")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.Property(e => e.OldRaee)
                    .HasMaxLength(50)
                    .HasColumnName("old_RAEE");

                entity.Property(e => e.NewRaee)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("new_RAEE");

                entity.Property(e => e.Pass)
                    .HasColumnName("pass")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<LksTratarRaeesFormaManual>(entity =>
            {
                entity.HasKey(e => e.Raee);

                entity.ToTable("LKS_Tratar_RAEES_FormaManual");

                entity.Property(e => e.Raee)
                    .HasMaxLength(50)
                    .HasColumnName("RAEE");
            });

            modelBuilder.Entity<LogEventoPortal>(entity =>
            {
                entity.HasKey(e => e.PidLogEventoPortal);

                entity.ToTable("LogEventoPortal");

                entity.HasIndex(e => e.EntidadAfectada, "IX_ENTIDADAFECTADA")
                    .HasFillFactor(80);

                entity.Property(e => e.PidLogEventoPortal).HasColumnName("pidLogEventoPortal");

                entity.Property(e => e.Detalles).HasColumnName("detalles");

                entity.Property(e => e.EntidadAfectada)
                    .HasMaxLength(50)
                    .HasColumnName("entidadAfectada");

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha");

                entity.Property(e => e.Proceso)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("proceso");

                entity.Property(e => e.Usuario)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario");
            });

            modelBuilder.Entity<LogRepartoPesada>(entity =>
            {
                entity.HasKey(e => e.PidLogRepartoPesadas);

                entity.Property(e => e.PidLogRepartoPesadas).HasColumnName("pidLogRepartoPesadas");

                entity.Property(e => e.Evento)
                    .IsRequired()
                    .HasColumnName("evento");

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha");

                entity.Property(e => e.Proceso)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("proceso");
            });

            modelBuilder.Entity<Marca>(entity =>
            {
                entity.HasKey(e => e.PidMarca);

                entity.HasIndex(e => e.Activa, "Estado_Marcas")
                    .HasFillFactor(80);

                entity.HasIndex(e => e.Rowguid, "MSmerge_index_2059154381")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.Property(e => e.PidMarca)
                    .ValueGeneratedNever()
                    .HasColumnName("pidMarca");

                entity.Property(e => e.Activa).HasColumnName("activa");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("rowguid")
                    .HasDefaultValueSql("(newsequentialid())");
            });

            modelBuilder.Entity<Municipio>(entity =>
            {
                entity.HasKey(e => e.PidMunicipio);

                entity.HasIndex(e => e.Estado, "Estado_Municipios")
                    .HasFillFactor(80);

                entity.HasIndex(e => e.Rowguid, "MSmerge_index_995793834")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.Property(e => e.PidMunicipio)
                    .ValueGeneratedNever()
                    .HasColumnName("pidMunicipio");

                entity.Property(e => e.CodGtr).HasColumnName("codGTR");

                entity.Property(e => e.Estado)
                    .HasColumnName("estado")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("rowguid")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.SidProvincia).HasColumnName("sidProvincia");

                entity.HasOne(d => d.SidProvinciaNavigation)
                    .WithMany(p => p.Municipios)
                    .HasForeignKey(d => d.SidProvincia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Municipios_Provincias");
            });

            modelBuilder.Entity<NumeroRaeeporDium>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("NumeroRAEEporDia");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.NumeroRaeeentradoEnSistema).HasColumnName("NumeroRAEEEntradoEnSistema");

                entity.Property(e => e.NumeroRaeetratado).HasColumnName("NumeroRAEETratado");

                entity.Property(e => e.NumeroRaeetratadoConVideo).HasColumnName("NumeroRAEETratadoConVideo");

                entity.Property(e => e.NumeroRaeetratadoSinVideo).HasColumnName("NumeroRAEETratadoSinVideo");
            });

            modelBuilder.Entity<ObservacionesIncidencium>(entity =>
            {
                entity.HasKey(e => e.PidObservacionIncidencia);

                entity.Property(e => e.PidObservacionIncidencia).HasColumnName("pidObservacionIncidencia");

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha");

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.SidIncidencia)
                    .IsRequired()
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("sidIncidencia");

                entity.Property(e => e.SidUsuario).HasColumnName("sidUsuario");

                entity.Property(e => e.Texto)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("texto");
            });

            modelBuilder.Entity<ObservacionesRaee>(entity =>
            {
                entity.HasKey(e => e.PidObservacionRaee);

                entity.ToTable("ObservacionesRAEE");

                entity.Property(e => e.PidObservacionRaee).HasColumnName("pidObservacionRAEE");

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha");

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.SidRaee)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("sidRAEE");

                entity.Property(e => e.SidUsuario).HasColumnName("sidUsuario");

                entity.Property(e => e.Texto)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("texto");
            });

            modelBuilder.Entity<OriginalUltimasUbicacionesRaee>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("OriginalUltimasUbicacionesRAEE");

                entity.Property(e => e.Canibalizado).HasColumnName("canibalizado");

                entity.Property(e => e.PesoEstimado).HasColumnName("pesoEstimado");

                entity.Property(e => e.PesoReal).HasColumnName("pesoReal");

                entity.Property(e => e.PidRaee)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("pidRAEE");

                entity.Property(e => e.SidCertificadoTratamiento).HasColumnName("sidCertificadoTratamiento");

                entity.Property(e => e.SidDireccionTercero).HasColumnName("sidDireccionTercero");

                entity.Property(e => e.SidEstadoRaee).HasColumnName("sidEstadoRAEE");

                entity.Property(e => e.SidFraccion).HasColumnName("sidFraccion");

                entity.Property(e => e.SidMarca).HasColumnName("sidMarca");

                entity.Property(e => e.SidPaisCodigoRaee).HasColumnName("sidPaisCodigoRAEE");

                entity.Property(e => e.SidResiduoEspecifico).HasColumnName("sidResiduoEspecifico");

                entity.Property(e => e.SidSig).HasColumnName("sidSIG");

                entity.Property(e => e.SidTerceroDestinatario).HasColumnName("sidTerceroDestinatario");

                entity.Property(e => e.SidTipoContenedor).HasColumnName("sidTipoContenedor");

                entity.Property(e => e.SidTipoEtiqueta).HasColumnName("sidTipoEtiqueta");
            });

            modelBuilder.Entity<Paise>(entity =>
            {
                entity.HasKey(e => e.PidPais)
                    .HasName("PK_Pais");

                entity.HasIndex(e => e.Estado, "Estado_Paises")
                    .HasFillFactor(80);

                entity.HasIndex(e => e.Rowguid, "MSmerge_index_1731796456")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.Property(e => e.PidPais).HasColumnName("pidPais");

                entity.Property(e => e.CodGtr).HasColumnName("codGTR");

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasColumnName("codigo");

                entity.Property(e => e.Estado)
                    .HasColumnName("estado")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("rowguid")
                    .HasDefaultValueSql("(newsequentialid())");
            });

            modelBuilder.Entity<PaisesCodigoRaee>(entity =>
            {
                entity.HasKey(e => e.PidPaisCodigoRaee);

                entity.ToTable("PaisesCodigoRAEE");

                entity.Property(e => e.PidPaisCodigoRaee)
                    .ValueGeneratedNever()
                    .HasColumnName("pidPaisCodigoRAEE");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<ParametrosGlobale>(entity =>
            {
                entity.HasKey(e => e.PidParametroGlobal);

                entity.HasIndex(e => e.Estado, "Estado_ParametrosGlobales")
                    .HasFillFactor(80);

                entity.HasIndex(e => e.Rowguid, "MSmerge_index_945438442")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.Property(e => e.PidParametroGlobal).HasColumnName("pidParametroGlobal");

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("codigo");

                entity.Property(e => e.Estado)
                    .HasColumnName("estado")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("rowguid")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.Valor)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("valor");
            });

            modelBuilder.Entity<Permiso>(entity =>
            {
                entity.HasKey(e => e.PidPermiso);

                entity.Property(e => e.PidPermiso).HasColumnName("pidPermiso");

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("codigo");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.HasMany(d => d.SidRols)
                    .WithMany(p => p.SidPermisos)
                    .UsingEntity<Dictionary<string, object>>(
                        "RolesPermiso",
                        l => l.HasOne<Role>().WithMany().HasForeignKey("SidRol").HasConstraintName("FK_RolesPermisos_Role"),
                        r => r.HasOne<Permiso>().WithMany().HasForeignKey("SidPermiso").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_RolesPermisos_Permiso"),
                        j =>
                        {
                            j.HasKey("SidPermiso", "SidRol").IsClustered(false);

                            j.ToTable("RolesPermisos");

                            j.HasIndex(new[] { "SidRol" }, "IX_FK_RolesPermisos_Role").HasFillFactor(80);
                        });
            });

            modelBuilder.Entity<Pesada>(entity =>
            {
                entity.HasKey(e => e.PidPesada);

                entity.Property(e => e.PidPesada).HasColumnName("pidPesada");

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha");

                entity.Property(e => e.Peso).HasColumnName("peso");

                entity.Property(e => e.SidCertificado)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("sidCertificado");

                entity.Property(e => e.SidCertificadoSubordinado)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("sidCertificadoSubordinado");

                entity.Property(e => e.SidDireccion).HasColumnName("sidDireccion");

                entity.Property(e => e.SidFraccion).HasColumnName("sidFraccion");

                entity.Property(e => e.SidTercero).HasColumnName("sidTercero");

                entity.HasOne(d => d.SidCertificadoNavigation)
                    .WithMany(p => p.Pesada)
                    .HasForeignKey(d => d.SidCertificado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Pesadas_Certificados");

                entity.HasOne(d => d.SidDireccionNavigation)
                    .WithMany(p => p.Pesada)
                    .HasForeignKey(d => d.SidDireccion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Pesadas_DireccionesTercero");

                entity.HasOne(d => d.SidFraccionNavigation)
                    .WithMany(p => p.Pesada)
                    .HasForeignKey(d => d.SidFraccion)
                    .HasConstraintName("FK_Pesadas_Fracciones");

                entity.HasOne(d => d.SidTerceroNavigation)
                    .WithMany(p => p.Pesada)
                    .HasForeignKey(d => d.SidTercero)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Pesadas_Terceros");
            });

            modelBuilder.Entity<PesadasErronea>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha");

                entity.Property(e => e.Peso).HasColumnName("peso");

                entity.Property(e => e.PidPesada)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("pidPesada");

                entity.Property(e => e.SidCertificado)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("sidCertificado");

                entity.Property(e => e.SidCertificadoSubordinado)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("sidCertificadoSubordinado");

                entity.Property(e => e.SidDireccion).HasColumnName("sidDireccion");

                entity.Property(e => e.SidFraccion).HasColumnName("sidFraccion");

                entity.Property(e => e.SidTercero).HasColumnName("sidTercero");
            });

            modelBuilder.Entity<PesadasLksPteProcesar>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Pesadas_LKS_PTE_PROCESAR");

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha");

                entity.Property(e => e.Peso).HasColumnName("peso");

                entity.Property(e => e.PidPesada)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("pidPesada");

                entity.Property(e => e.SidCertificado)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("sidCertificado");

                entity.Property(e => e.SidCertificadoSubordinado)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("sidCertificadoSubordinado");

                entity.Property(e => e.SidDireccion).HasColumnName("sidDireccion");

                entity.Property(e => e.SidFraccion).HasColumnName("sidFraccion");

                entity.Property(e => e.SidTercero).HasColumnName("sidTercero");
            });

            modelBuilder.Entity<PesoEntradoEnSistemaPorDium>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PesoEntradoEnSistemaPorDia");

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha");

                entity.Property(e => e.NumeroRaeeentradoEnSistema).HasColumnName("NumeroRAEEEntradoEnSistema");
            });

            modelBuilder.Entity<PesosEnviado>(entity =>
            {
                entity.HasKey(e => e.PidCertificado);

                entity.Property(e => e.PidCertificado)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("pidCertificado");
            });

            modelBuilder.Entity<Provincia>(entity =>
            {
                entity.HasKey(e => e.PidProvincia)
                    .HasName("PK_Provincia");

                entity.HasIndex(e => e.Estado, "Estado_Provincias")
                    .HasFillFactor(80);

                entity.HasIndex(e => e.Rowguid, "MSmerge_index_1875796969")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.Property(e => e.PidProvincia)
                    .ValueGeneratedNever()
                    .HasColumnName("pidProvincia");

                entity.Property(e => e.CodGtr).HasColumnName("codGTR");

                entity.Property(e => e.Estado)
                    .HasColumnName("estado")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("rowguid")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.SidPais).HasColumnName("sidPais");

                entity.HasOne(d => d.SidPaisNavigation)
                    .WithMany(p => p.Provincia)
                    .HasForeignKey(d => d.SidPais)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Provincias_Paises");
            });

            modelBuilder.Entity<Raee>(entity =>
            {
                entity.HasKey(e => e.PidRaee)
                    .HasName("PK_RAEE");

                entity.ToTable("RAEEs");

                entity.HasIndex(e => new { e.SidEstadoRaee, e.Estado }, "Estado_RAEEs")
                    .HasFillFactor(80);

                entity.HasIndex(e => e.Estado, "IX_ANULADO")
                    .HasFillFactor(80);

                entity.HasIndex(e => e.SidCertificadoTratamiento, "IX_CERT_TRATA")
                    .HasFillFactor(80);

                entity.HasIndex(e => e.SidEstadoRaee, "IX_ESTADO")
                    .HasFillFactor(80);

                entity.HasIndex(e => e.SidFraccion, "IX_FRACC")
                    .HasFillFactor(80);

                entity.HasIndex(e => new { e.PidRaee, e.SidEstadoRaee }, "IX_RAEE_ESTADO")
                    .HasFillFactor(80);

                entity.HasIndex(e => new { e.PidRaee, e.SidCertificadoTratamiento }, "IX_RAEE_TRAT")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.HasIndex(e => new { e.SidResiduo, e.SidResiduoEspecifico, e.SidFraccion, e.PidRaee }, "IX_Report")
                    .HasFillFactor(80);

                entity.HasIndex(e => e.Rowguid, "MSmerge_index_790553079")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.Property(e => e.PidRaee)
                    .HasMaxLength(50)
                    .HasColumnName("pidRAEE");

                entity.Property(e => e.Canibalizado).HasColumnName("canibalizado");

                entity.Property(e => e.CodigoRefTercero)
                    .HasMaxLength(15)
                    .HasColumnName("codigoRefTercero");

                entity.Property(e => e.Destino)
                    .HasColumnName("destino")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Estado)
                    .HasColumnName("estado")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.PesoEstimado).HasColumnName("pesoEstimado");

                entity.Property(e => e.PesoReal).HasColumnName("pesoReal");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("rowguid")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.Serie)
                    .HasMaxLength(50)
                    .HasColumnName("serie");

                entity.Property(e => e.SidCertificadoTratamiento).HasColumnName("sidCertificadoTratamiento");

                entity.Property(e => e.SidEstadoRaee).HasColumnName("sidEstadoRAEE");

                entity.Property(e => e.SidFraccion).HasColumnName("sidFraccion");

                entity.Property(e => e.SidMarca).HasColumnName("sidMarca");

                entity.Property(e => e.SidPaisCodigoRaee).HasColumnName("sidPaisCodigoRAEE");

                entity.Property(e => e.SidResiduo).HasColumnName("sidResiduo");

                entity.Property(e => e.SidResiduoEspecifico).HasColumnName("sidResiduoEspecifico");

                entity.Property(e => e.SidSig).HasColumnName("sidSIG");

                entity.Property(e => e.SidTipoContenedor).HasColumnName("sidTipoContenedor");

                entity.Property(e => e.SidTipoEtiqueta).HasColumnName("sidTipoEtiqueta");

                entity.HasOne(d => d.DestinoNavigation)
                    .WithMany(p => p.Raees)
                    .HasForeignKey(d => d.Destino)
                    .HasConstraintName("FK_RAEEs_TiposDestino");

                entity.HasOne(d => d.SidCertificadoTratamientoNavigation)
                    .WithMany(p => p.Raees)
                    .HasForeignKey(d => d.SidCertificadoTratamiento)
                    .HasConstraintName("FK_RAEEs_CertificadosTratamiento");

                entity.HasOne(d => d.SidEstadoRaeeNavigation)
                    .WithMany(p => p.Raees)
                    .HasForeignKey(d => d.SidEstadoRaee)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RAEEs_EstadosRAEE");

                entity.HasOne(d => d.SidFraccionNavigation)
                    .WithMany(p => p.Raees)
                    .HasForeignKey(d => d.SidFraccion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RAEEs_Fracciones");

                entity.HasOne(d => d.SidResiduoNavigation)
                    .WithMany(p => p.Raees)
                    .HasForeignKey(d => d.SidResiduo)
                    .HasConstraintName("FK_RAEEs_Residuos");

                entity.HasOne(d => d.SidResiduoEspecificoNavigation)
                    .WithMany(p => p.Raees)
                    .HasForeignKey(d => d.SidResiduoEspecifico)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RAEEs_ResiduosEspecificos");

                entity.HasOne(d => d.SidTipoContenedorNavigation)
                    .WithMany(p => p.Raees)
                    .HasForeignKey(d => d.SidTipoContenedor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RAEEs_TiposContenedor");
            });

            modelBuilder.Entity<RaeeregistradoEnSistemaPorDium>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("RAEERegistradoEnSistemaPorDia");

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha");

                entity.Property(e => e.NumeroRaeeentradoEnSistema).HasColumnName("NumeroRAEEEntradoEnSistema");
            });

            modelBuilder.Entity<RaeesAReutilizar>(entity =>
            {
                entity.HasKey(e => e.Raee);

                entity.ToTable("RAEEs_aReutilizar");

                entity.Property(e => e.Raee)
                    .HasMaxLength(50)
                    .HasColumnName("RAEE");

                entity.Property(e => e.FechaReutilizacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaReutilizacion");

                entity.Property(e => e.SidDireccionTercero).HasColumnName("sidDireccionTercero");

                entity.Property(e => e.SidTercero).HasColumnName("sidTercero");
            });

            modelBuilder.Entity<RaeesAlbaranesEcotrazo>(entity =>
            {
                entity.HasKey(e => e.PidRaeesAlbaranesEcotrazo);

                entity.ToTable("RaeesAlbaranesEcotrazo");

                entity.Property(e => e.PidRaeesAlbaranesEcotrazo).HasColumnName("pidRaeesAlbaranesEcotrazo");

                entity.Property(e => e.AlbaranEcotrazo)
                    .IsRequired()
                    .HasMaxLength(256)
                    .HasColumnName("albaranEcotrazo");

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha");

                entity.Property(e => e.SidCertificado)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("sidCertificado");

                entity.Property(e => e.SidRaee)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("sidRaee");

                entity.HasOne(d => d.SidCertificadoNavigation)
                    .WithMany(p => p.RaeesAlbaranesEcotrazos)
                    .HasForeignKey(d => d.SidCertificado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RaeesAlbaranesEcotrazo_Certificados");

                entity.HasOne(d => d.SidRaeeNavigation)
                    .WithMany(p => p.RaeesAlbaranesEcotrazos)
                    .HasForeignKey(d => d.SidRaee)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RaeesAlbaranesEcotrazo_RAEEs");
            });

            modelBuilder.Entity<RaeesAmbitoTercero>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("RAEEsAmbitoTercero");

                entity.Property(e => e.Canibalizado).HasColumnName("canibalizado");

                entity.Property(e => e.PesoEstimado).HasColumnName("pesoEstimado");

                entity.Property(e => e.PesoReal).HasColumnName("pesoReal");

                entity.Property(e => e.PidRaee)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("pidRAEE");

                entity.Property(e => e.SidCertificadoTratamiento).HasColumnName("sidCertificadoTratamiento");

                entity.Property(e => e.SidEstadoRaee).HasColumnName("sidEstadoRAEE");

                entity.Property(e => e.SidFraccion).HasColumnName("sidFraccion");

                entity.Property(e => e.SidMarca).HasColumnName("sidMarca");

                entity.Property(e => e.SidPaisCodigoRaee).HasColumnName("sidPaisCodigoRAEE");

                entity.Property(e => e.SidResiduoEspecifico).HasColumnName("sidResiduoEspecifico");

                entity.Property(e => e.SidSig).HasColumnName("sidSIG");

                entity.Property(e => e.SidTercero).HasColumnName("sidTercero");

                entity.Property(e => e.SidTipoContenedor).HasColumnName("sidTipoContenedor");

                entity.Property(e => e.SidTipoEtiqueta).HasColumnName("sidTipoEtiqueta");
            });

            modelBuilder.Entity<RaeesAreutilizarBack>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Raees_AReutilizarBack");

                entity.Property(e => e.FechaReutilizacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaReutilizacion");

                entity.Property(e => e.Raee)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("RAEE");

                entity.Property(e => e.SidDireccionTercero).HasColumnName("sidDireccionTercero");

                entity.Property(e => e.SidTercero).HasColumnName("sidTercero");
            });

            modelBuilder.Entity<RaeesCertificado>(entity =>
            {
                entity.HasKey(e => e.PidRaeecertificado);

                entity.ToTable("RAEEsCertificados");

                entity.HasIndex(e => e.SidCertificado, "IX_CERT")
                    .HasFillFactor(80);

                entity.HasIndex(e => new { e.SidCertificado, e.SidRaee }, "IX_GENERAL")
                    .HasFillFactor(80);

                entity.HasIndex(e => e.SidRaee, "IX_RAEE")
                    .HasFillFactor(80);

                entity.Property(e => e.PidRaeecertificado)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("pidRAEECertificado");

                entity.Property(e => e.GpsX).HasColumnName("gpsX");

                entity.Property(e => e.GpsY).HasColumnName("gpsY");

                entity.Property(e => e.GpsZ).HasColumnName("gpsZ");

                entity.Property(e => e.Peso).HasColumnName("peso");

                entity.Property(e => e.SidCertificado)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("sidCertificado");

                entity.Property(e => e.SidRaee)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("sidRAEE");

                entity.Property(e => e.SidTipoDeLectora).HasColumnName("sidTipoDeLectora");

                entity.HasOne(d => d.SidCertificadoNavigation)
                    .WithMany(p => p.RaeesCertificados)
                    .HasForeignKey(d => d.SidCertificado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RAEEsCertificados_Certificados");

                entity.HasOne(d => d.SidRaeeNavigation)
                    .WithMany(p => p.RaeesCertificados)
                    .HasForeignKey(d => d.SidRaee)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RAEEsCertificados_RAEEs");
            });

            modelBuilder.Entity<RaeesCertificadosUltimoId>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RAEEsCertificados_UltimoID");

                entity.Property(e => e.Ano)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("ANO");

                entity.Property(e => e.IdRaeeCert)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("ID_RaeeCert");

                entity.Property(e => e.Mes)
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RaeesConsultaOriginal>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("RAEEsConsulta_Original");

                entity.Property(e => e.Canibalizado).HasColumnName("canibalizado");

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.FechaTratamiento)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaTratamiento");

                entity.Property(e => e.Fraccion)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Marca)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.PesoEstimado).HasColumnName("pesoEstimado");

                entity.Property(e => e.PesoReal).HasColumnName("pesoReal");

                entity.Property(e => e.PidRaee)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("pidRAEE");

                entity.Property(e => e.Residuo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ResiduoEspecifico)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.SidCertificadoTratamiento).HasColumnName("sidCertificadoTratamiento");

                entity.Property(e => e.SidEstadoRaee).HasColumnName("sidEstadoRAEE");

                entity.Property(e => e.SidFraccion).HasColumnName("sidFraccion");

                entity.Property(e => e.SidMarca).HasColumnName("sidMarca");

                entity.Property(e => e.SidResiduo).HasColumnName("sidResiduo");

                entity.Property(e => e.SidResiduoEspecifico).HasColumnName("sidResiduoEspecifico");

                entity.Property(e => e.TipoContenedor)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.TratamientoCalle)
                    .IsUnicode(false)
                    .HasColumnName("Tratamiento_Calle");

                entity.Property(e => e.TratamientoDireccion)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Tratamiento_Direccion");

                entity.Property(e => e.TratamientoSidDireccionTercero).HasColumnName("Tratamiento_sidDireccionTercero");

                entity.Property(e => e.TratamientoSidTercero).HasColumnName("Tratamiento_sidTercero");

                entity.Property(e => e.TratamientoSidTipoLecturaTratamiento).HasColumnName("Tratamiento_sidTipoLecturaTratamiento");

                entity.Property(e => e.TratamientoTipoLecturaTratamiento)
                    .HasMaxLength(255)
                    .HasColumnName("Tratamiento_TipoLecturaTratamiento");

                entity.Property(e => e.UltimaUbicacionFecha).HasColumnType("datetime");

                entity.Property(e => e.Video).HasMaxLength(50);
            });

            modelBuilder.Entity<RaeesConsultaRapidum>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("RAEEsConsultaRapida");

                entity.Property(e => e.Canibalizado).HasColumnName("canibalizado");

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.FechaTratamiento)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaTratamiento");

                entity.Property(e => e.Fraccion)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Marca)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.PesoEstimado).HasColumnName("pesoEstimado");

                entity.Property(e => e.PesoReal).HasColumnName("pesoReal");

                entity.Property(e => e.PidRaee)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("pidRAEE");

                entity.Property(e => e.Residuo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ResiduoEspecifico)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.SidCertificadoTratamiento).HasColumnName("sidCertificadoTratamiento");

                entity.Property(e => e.SidEstadoRaee).HasColumnName("sidEstadoRAEE");

                entity.Property(e => e.SidFraccion).HasColumnName("sidFraccion");

                entity.Property(e => e.SidMarca).HasColumnName("sidMarca");

                entity.Property(e => e.SidResiduo).HasColumnName("sidResiduo");

                entity.Property(e => e.SidResiduoEspecifico).HasColumnName("sidResiduoEspecifico");

                entity.Property(e => e.TipoContenedor)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.TratamientoCalle)
                    .IsUnicode(false)
                    .HasColumnName("Tratamiento_Calle");

                entity.Property(e => e.TratamientoDireccion)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Tratamiento_Direccion");

                entity.Property(e => e.TratamientoSidDireccionTercero).HasColumnName("Tratamiento_sidDireccionTercero");

                entity.Property(e => e.TratamientoSidTercero).HasColumnName("Tratamiento_sidTercero");

                entity.Property(e => e.TratamientoSidTipoLecturaTratamiento).HasColumnName("Tratamiento_sidTipoLecturaTratamiento");

                entity.Property(e => e.TratamientoTipoLecturaTratamiento)
                    .HasMaxLength(255)
                    .HasColumnName("Tratamiento_TipoLecturaTratamiento");
            });

            modelBuilder.Entity<RaeesConsultum>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("RAEEsConsulta");

                entity.Property(e => e.Canibalizado).HasColumnName("canibalizado");

                entity.Property(e => e.Destino).HasColumnName("destino");

                entity.Property(e => e.DestinoDetail).HasMaxLength(50);

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.FechaTratamiento)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaTratamiento");

                entity.Property(e => e.Fraccion)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Marca)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.PesoEstimado).HasColumnName("pesoEstimado");

                entity.Property(e => e.PesoReal).HasColumnName("pesoReal");

                entity.Property(e => e.PidRaee)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("pidRAEE");

                entity.Property(e => e.Residuo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ResiduoEspecifico)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Serie)
                    .HasMaxLength(50)
                    .HasColumnName("serie");

                entity.Property(e => e.SidCertificadoTratamiento).HasColumnName("sidCertificadoTratamiento");

                entity.Property(e => e.SidEstadoRaee).HasColumnName("sidEstadoRAEE");

                entity.Property(e => e.SidFraccion).HasColumnName("sidFraccion");

                entity.Property(e => e.SidMarca).HasColumnName("sidMarca");

                entity.Property(e => e.SidResiduo).HasColumnName("sidResiduo");

                entity.Property(e => e.SidResiduoEspecifico).HasColumnName("sidResiduoEspecifico");

                entity.Property(e => e.TipoContenedor)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.TratamientoCalle)
                    .IsUnicode(false)
                    .HasColumnName("Tratamiento_Calle");

                entity.Property(e => e.TratamientoDireccion)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Tratamiento_Direccion");

                entity.Property(e => e.TratamientoSidDireccionTercero).HasColumnName("Tratamiento_sidDireccionTercero");

                entity.Property(e => e.TratamientoSidTercero).HasColumnName("Tratamiento_sidTercero");

                entity.Property(e => e.TratamientoSidTipoLecturaTratamiento).HasColumnName("Tratamiento_sidTipoLecturaTratamiento");

                entity.Property(e => e.TratamientoTipoLecturaTratamiento)
                    .HasMaxLength(255)
                    .HasColumnName("Tratamiento_TipoLecturaTratamiento");

                entity.Property(e => e.UltimaUbicacionFecha).HasColumnType("datetime");

                entity.Property(e => e.Video)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("video");
            });

            modelBuilder.Entity<RaeesPrimerCertificado>(entity =>
            {
                entity.HasKey(e => e.SidRaee);

                entity.ToTable("RAEEsPrimerCertificado");

                entity.HasIndex(e => e.FechaCertificado, "IX_FECHA")
                    .HasFillFactor(80);

                entity.Property(e => e.SidRaee)
                    .HasMaxLength(50)
                    .HasColumnName("sidRAEE");

                entity.Property(e => e.FechaCertificado).HasColumnType("datetime");

                entity.Property(e => e.SidCertificado)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("sidCertificado");
            });

            modelBuilder.Entity<RaeesUltimaUbicacion>(entity =>
            {
                entity.HasKey(e => e.Raee)
                    .HasName("PK_REEs_UltimaUbicacion");

                entity.ToTable("RAEEs_UltimaUbicacion");

                entity.HasIndex(e => e.Certificado, "IX_CERTIFICADO")
                    .HasFillFactor(80);

                entity.HasIndex(e => e.SidDireccionTercero, "IX_DIRECCION")
                    .HasFillFactor(80);

                entity.HasIndex(e => e.SidTercero, "IX_TERCERO")
                    .HasFillFactor(80);

                entity.HasIndex(e => new { e.SidTercero, e.SidDireccionTercero }, "IX_TERCERO_DIRECCION")
                    .HasFillFactor(80);

                entity.HasIndex(e => e.Video, "IX_VIDEO")
                    .HasFillFactor(80);

                entity.Property(e => e.Raee)
                    .HasMaxLength(50)
                    .HasColumnName("RAEE");

                entity.Property(e => e.Certificado)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha");

                entity.Property(e => e.SidDireccionTercero).HasColumnName("sidDireccionTercero");

                entity.Property(e => e.SidTercero).HasColumnName("sidTercero");

                entity.Property(e => e.Video)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("video");
            });

            modelBuilder.Entity<RaeetratadoConVideoPorDium>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("RAEETratadoConVideoPorDia");

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha");

                entity.Property(e => e.NumeroRaeetratadoConVideo).HasColumnName("NumeroRAEETratadoConVideo");
            });

            modelBuilder.Entity<RaeetratadoPorDiaPorGestor>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("RAEETratadoPorDiaPorGestor");

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha");

                entity.Property(e => e.Nombre).HasColumnName("nombre");

                entity.Property(e => e.NumeroRaeetratado).HasColumnName("NumeroRAEETratado");

                entity.Property(e => e.NumeroRaeetratadoConVideo).HasColumnName("NumeroRAEETratadoConVideo");

                entity.Property(e => e.SidTercero).HasColumnName("sidTercero");
            });

            modelBuilder.Entity<RaeetratadoPorDium>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("RAEETratadoPorDia");

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha");

                entity.Property(e => e.NumeroRaeetratado).HasColumnName("NumeroRAEETratado");
            });

            modelBuilder.Entity<Remesa>(entity =>
            {
                entity.HasKey(e => e.PidRemesa);

                entity.Property(e => e.PidRemesa).HasColumnName("pidRemesa");

                entity.Property(e => e.CodigoFinRango)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("codigoFinRango");

                entity.Property(e => e.CodigoFinTratado)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("codigoFinTratado");

                entity.Property(e => e.CodigoInicioRango)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("codigoInicioRango");

                entity.Property(e => e.CodigoInicioTratado)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("codigoInicioTratado");

                entity.Property(e => e.FechaEntrega)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEntrega");

                entity.Property(e => e.ReferenciaProducto)
                    .HasMaxLength(50)
                    .HasColumnName("referenciaProducto");

                entity.Property(e => e.ReferenciaRemesa)
                    .HasMaxLength(50)
                    .HasColumnName("referenciaRemesa");

                entity.Property(e => e.SidDireccionTercero).HasColumnName("sidDireccionTercero");

                entity.Property(e => e.SidEstadoRemesa).HasColumnName("sidEstadoRemesa");

                entity.Property(e => e.SidTercero).HasColumnName("sidTercero");

                entity.HasOne(d => d.SidDireccionTerceroNavigation)
                    .WithMany(p => p.Remesas)
                    .HasForeignKey(d => d.SidDireccionTercero)
                    .HasConstraintName("FK_Remesas_DireccionesTercero");

                entity.HasOne(d => d.SidEstadoRemesaNavigation)
                    .WithMany(p => p.Remesas)
                    .HasForeignKey(d => d.SidEstadoRemesa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Remesas_EstadosRemesa");

                entity.HasOne(d => d.SidTerceroNavigation)
                    .WithMany(p => p.Remesas)
                    .HasForeignKey(d => d.SidTercero)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Remesas_Terceros");
            });

            modelBuilder.Entity<RemesasCopium>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CodigoFinRango)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("codigoFinRango");

                entity.Property(e => e.CodigoFinTratado)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("codigoFinTratado");

                entity.Property(e => e.CodigoInicioRango)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("codigoInicioRango");

                entity.Property(e => e.CodigoInicioTratado)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("codigoInicioTratado");

                entity.Property(e => e.FechaEntrega)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEntrega");

                entity.Property(e => e.PidRemesa)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("pidRemesa");

                entity.Property(e => e.ReferenciaProducto)
                    .HasMaxLength(50)
                    .HasColumnName("referenciaProducto");

                entity.Property(e => e.ReferenciaRemesa)
                    .HasMaxLength(50)
                    .HasColumnName("referenciaRemesa");

                entity.Property(e => e.SidDireccionTercero).HasColumnName("sidDireccionTercero");

                entity.Property(e => e.SidEstadoRemesa).HasColumnName("sidEstadoRemesa");

                entity.Property(e => e.SidTercero).HasColumnName("sidTercero");
            });

            modelBuilder.Entity<ReportingRaeesGestionado>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Reporting_RAEES_Gestionado");

                entity.HasIndex(e => new { e.FechaDeGestion, e.SidTercero }, "IX_FECHA_TERCERO")
                    .HasFillFactor(80);

                entity.HasIndex(e => e.FechaDeGestion, "IX_Fecha")
                    .HasFillFactor(80);

                entity.Property(e => e.CódigoRaee)
                    .HasMaxLength(50)
                    .HasColumnName("Código_RAEE");

                entity.Property(e => e.Dirección)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.FechaDeGestion)
                    .HasColumnType("datetime")
                    .HasColumnName("Fecha de Gestion");

                entity.Property(e => e.Fracción).HasMaxLength(255);

                entity.Property(e => e.Municipio)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.PesoCalculado).HasColumnName("pesoCalculado");

                entity.Property(e => e.Provincia)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.Residuo).HasMaxLength(50);

                entity.Property(e => e.ResiduoEspecífico)
                    .HasMaxLength(255)
                    .HasColumnName("Residuo_Específico");

                entity.Property(e => e.SidCertificado)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("sidCertificado");

                entity.Property(e => e.SidDireccionTercero).HasColumnName("sidDireccionTercero");

                entity.Property(e => e.SidEstadoRaee).HasColumnName("sidEstadoRAEE");

                entity.Property(e => e.SidFraccion).HasColumnName("sidFraccion");

                entity.Property(e => e.SidResiduo).HasColumnName("sidResiduo");

                entity.Property(e => e.SidResiduoEspecifico).HasColumnName("sidResiduoEspecifico");

                entity.Property(e => e.SidTercero).HasColumnName("sidTercero");
            });

            modelBuilder.Entity<ReportingRaeesgestionadosEnTransito>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Reporting_RAEESGestionados_EnTransito");

                entity.Property(e => e.Canibalizado).HasColumnName("canibalizado");

                entity.Property(e => e.CódigoDirecciónDeGestion).HasColumnName("Código Dirección de Gestion");

                entity.Property(e => e.CódigoRaee)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Código RAEE");

                entity.Property(e => e.CódigoTerceroDeGestion).HasColumnName("Código Tercero de Gestion");

                entity.Property(e => e.DireccionDeGestion)
                    .IsUnicode(false)
                    .HasColumnName("Direccion de Gestion");

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.FechaDeGestion)
                    .HasColumnType("datetime")
                    .HasColumnName("Fecha de Gestion");

                entity.Property(e => e.Fracción)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.MunicipioDeGestion)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("Municipio de Gestion");

                entity.Property(e => e.PesoCalculado).HasColumnName("pesoCalculado");

                entity.Property(e => e.PesoEstimado).HasColumnName("pesoEstimado");

                entity.Property(e => e.PesoReal).HasColumnName("pesoReal");

                entity.Property(e => e.ProvinciaDeGestion)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("Provincia de Gestion");

                entity.Property(e => e.ResiduoEspecífico)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("Residuo Específico");

                entity.Property(e => e.TerceroDeGestion).HasColumnName("Tercero de Gestion");

                entity.Property(e => e.TipoContenedor)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("Tipo Contenedor");
            });

            modelBuilder.Entity<ReportingRaeesgestionadosGestion>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Reporting_RAEESGestionados_Gestion");

                entity.Property(e => e.CódigoRaee)
                    .HasMaxLength(50)
                    .HasColumnName("Código_RAEE");

                entity.Property(e => e.Dirección)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FechaDeGestion)
                    .HasColumnType("datetime")
                    .HasColumnName("Fecha de Gestion");

                entity.Property(e => e.Fracción).HasMaxLength(255);

                entity.Property(e => e.Municipio)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.PesoCalculado).HasColumnName("pesoCalculado");

                entity.Property(e => e.Provincia)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.Residuo).HasMaxLength(50);

                entity.Property(e => e.ResiduoEspecífico)
                    .HasMaxLength(255)
                    .HasColumnName("Residuo_Específico");

                entity.Property(e => e.SidCertificado)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("sidCertificado");

                entity.Property(e => e.SidDireccionTercero).HasColumnName("sidDireccionTercero");

                entity.Property(e => e.SidFraccion).HasColumnName("sidFraccion");

                entity.Property(e => e.SidResiduo).HasColumnName("sidResiduo");

                entity.Property(e => e.SidResiduoEspecifico).HasColumnName("sidResiduoEspecifico");

                entity.Property(e => e.SidTercero).HasColumnName("sidTercero");
            });

            modelBuilder.Entity<ReportingRaeesgestionadosGestionResiduo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Reporting_RAEESGestionados_Gestion_Residuos");

                entity.Property(e => e.CódigoRaee)
                    .HasMaxLength(50)
                    .HasColumnName("Código_RAEE");

                entity.Property(e => e.FechaDeGestion)
                    .HasColumnType("datetime")
                    .HasColumnName("Fecha de Gestion");

                entity.Property(e => e.Fracción).HasMaxLength(255);

                entity.Property(e => e.PesoCalculado).HasColumnName("pesoCalculado");

                entity.Property(e => e.Residuo).HasMaxLength(50);

                entity.Property(e => e.ResiduoEspecífico)
                    .HasMaxLength(255)
                    .HasColumnName("Residuo_Específico");

                entity.Property(e => e.SidCertificado)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("sidCertificado");

                entity.Property(e => e.SidDireccionTercero).HasColumnName("sidDireccionTercero");

                entity.Property(e => e.SidFraccion).HasColumnName("sidFraccion");

                entity.Property(e => e.SidResiduo).HasColumnName("sidResiduo");

                entity.Property(e => e.SidResiduoEspecifico).HasColumnName("sidResiduoEspecifico");

                entity.Property(e => e.SidTercero).HasColumnName("sidTercero");
            });

            modelBuilder.Entity<ReportingRaeesgestionadosGestionResiduosV2>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Reporting_RAEESGestionados_Gestion_Residuos_v2");

                entity.Property(e => e.CódigoRaee)
                    .HasMaxLength(50)
                    .HasColumnName("Código_RAEE");

                entity.Property(e => e.FechaDeGestion)
                    .HasColumnType("datetime")
                    .HasColumnName("Fecha de Gestion");

                entity.Property(e => e.Fracción).HasMaxLength(255);

                entity.Property(e => e.PesoCalculado).HasColumnName("pesoCalculado");

                entity.Property(e => e.Residuo).HasMaxLength(50);

                entity.Property(e => e.ResiduoEspecífico)
                    .HasMaxLength(255)
                    .HasColumnName("Residuo_Específico");

                entity.Property(e => e.SidCertificado)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("sidCertificado");

                entity.Property(e => e.SidDireccionTercero).HasColumnName("sidDireccionTercero");

                entity.Property(e => e.SidFraccion).HasColumnName("sidFraccion");

                entity.Property(e => e.SidResiduo).HasColumnName("sidResiduo");

                entity.Property(e => e.SidResiduoEspecifico).HasColumnName("sidResiduoEspecifico");

                entity.Property(e => e.SidTercero).HasColumnName("sidTercero");
            });

            modelBuilder.Entity<ReportingRaeesgestionadosGestionV2>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Reporting_RAEESGestionados_Gestion_V2");

                entity.Property(e => e.CódigoRaee)
                    .HasMaxLength(50)
                    .HasColumnName("Código_RAEE");

                entity.Property(e => e.Dirección)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FechaDeGestion)
                    .HasColumnType("datetime")
                    .HasColumnName("Fecha de Gestion");

                entity.Property(e => e.Fracción).HasMaxLength(255);

                entity.Property(e => e.Municipio)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.PesoCalculado).HasColumnName("pesoCalculado");

                entity.Property(e => e.Provincia)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.Residuo).HasMaxLength(50);

                entity.Property(e => e.ResiduoEspecífico)
                    .HasMaxLength(255)
                    .HasColumnName("Residuo_Específico");

                entity.Property(e => e.SidCertificado)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("sidCertificado");

                entity.Property(e => e.SidDireccionTercero).HasColumnName("sidDireccionTercero");

                entity.Property(e => e.SidFraccion).HasColumnName("sidFraccion");

                entity.Property(e => e.SidResiduo).HasColumnName("sidResiduo");

                entity.Property(e => e.SidResiduoEspecifico).HasColumnName("sidResiduoEspecifico");

                entity.Property(e => e.SidTercero).HasColumnName("sidTercero");
            });

            modelBuilder.Entity<ReportingRaeesgestionadosTratado>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Reporting_RAEESGestionados_Tratado");

                entity.Property(e => e.Canibalizado).HasColumnName("canibalizado");

                entity.Property(e => e.CodigoPostal)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("codigoPostal");

                entity.Property(e => e.CódigoDirecciónDeTratamiento).HasColumnName("Código Dirección de Tratamiento");

                entity.Property(e => e.CódigoRaee)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Código RAEE");

                entity.Property(e => e.CódigoTerceroDeTratamiento).HasColumnName("Código Tercero de Tratamiento");

                entity.Property(e => e.DirecciónDeTratamiento)
                    .IsUnicode(false)
                    .HasColumnName("Dirección de Tratamiento");

                entity.Property(e => e.FechaDeTratamiento)
                    .HasColumnType("datetime")
                    .HasColumnName("Fecha de Tratamiento");

                entity.Property(e => e.Fracción)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.MunicipioDeTratamiento)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("Municipio de Tratamiento");

                entity.Property(e => e.PesoCalculado).HasColumnName("pesoCalculado");

                entity.Property(e => e.PesoEstimado).HasColumnName("pesoEstimado");

                entity.Property(e => e.PesoReal).HasColumnName("pesoReal");

                entity.Property(e => e.PidResiduo).HasColumnName("pidResiduo");

                entity.Property(e => e.ProvinciaDeTratamiento)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("Provincia de Tratamiento");

                entity.Property(e => e.Residuo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ResiduoEspecífico)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("Residuo Específico");

                entity.Property(e => e.SidEstadoRaee).HasColumnName("sidEstadoRAEE");

                entity.Property(e => e.SidFraccion).HasColumnName("sidFraccion");

                entity.Property(e => e.SidResiduo).HasColumnName("sidResiduo");

                entity.Property(e => e.TerceroDeTratamiento)
                    .IsRequired()
                    .HasColumnName("Tercero de Tratamiento");
            });

            modelBuilder.Entity<ReportingStock>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Reporting_Stocks");

                entity.Property(e => e.Activacion)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.Estado).HasMaxLength(255);

                entity.Property(e => e.Fraccion).HasMaxLength(255);

                entity.Property(e => e.IdActivacion).HasColumnName("idActivacion");

                entity.Property(e => e.Municipio)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.NombreDireccion)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Provincia)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.SidDireccionTercero).HasColumnName("sidDireccionTercero");

                entity.Property(e => e.SidEstadoRaee).HasColumnName("sidEstadoRAEE");

                entity.Property(e => e.SidFraccion).HasColumnName("sidFraccion");

                entity.Property(e => e.SidTercero).HasColumnName("sidTercero");
            });

            modelBuilder.Entity<Residuo>(entity =>
            {
                entity.HasKey(e => e.PidResiduo);

                entity.HasIndex(e => e.Estado, "Estado_Residuos")
                    .HasFillFactor(80);

                entity.HasIndex(e => e.Rowguid, "MSmerge_index_1171794461")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.Property(e => e.PidResiduo)
                    .ValueGeneratedNever()
                    .HasColumnName("pidResiduo");

                entity.Property(e => e.CodGtr).HasColumnName("codGTR");

                entity.Property(e => e.Estado)
                    .HasColumnName("estado")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("nombre");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("rowguid")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.SidFraccion).HasColumnName("sidFraccion");

                entity.HasOne(d => d.SidFraccionNavigation)
                    .WithMany(p => p.Residuos)
                    .HasForeignKey(d => d.SidFraccion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Residuos_Fracciones");
            });

            modelBuilder.Entity<ResiduosEspecifico>(entity =>
            {
                entity.HasKey(e => e.PidResiduoEspecifico)
                    .HasName("PK_RESIDUOESPECIFICO");

                entity.HasIndex(e => e.Estado, "Estado_ResiduosEspecificos")
                    .HasFillFactor(80);

                entity.HasIndex(e => e.Rowguid, "MSmerge_index_915793549")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.Property(e => e.PidResiduoEspecifico)
                    .ValueGeneratedNever()
                    .HasColumnName("pidResiduoEspecifico");

                entity.Property(e => e.CodGtr).HasColumnName("codGTR");

                entity.Property(e => e.Estado)
                    .HasColumnName("estado")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("nombre");

                entity.Property(e => e.PesoEstimado).HasColumnName("pesoEstimado");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("rowguid")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.SidFraccion).HasColumnName("sidFraccion");

                entity.Property(e => e.SidResiduo).HasColumnName("sidResiduo");

                entity.HasOne(d => d.SidFraccionNavigation)
                    .WithMany(p => p.ResiduosEspecificos)
                    .HasForeignKey(d => d.SidFraccion)
                    .HasConstraintName("FK_ResiduosEspecificos_Fracciones");

                entity.HasOne(d => d.SidResiduoNavigation)
                    .WithMany(p => p.ResiduosEspecificos)
                    .HasForeignKey(d => d.SidResiduo)
                    .HasConstraintName("FK_ResiduosEspecificos_Residuos");
            });

            modelBuilder.Entity<ResponsabilidadesRecogidaEntrega>(entity =>
            {
                entity.ToTable("ResponsabilidadesRecogidaEntrega");

                entity.HasIndex(e => e.Estado, "Estado_ResponsabilidadesRecogidaEntrega")
                    .HasFillFactor(80);

                entity.HasIndex(e => e.Rowguid, "MSmerge_index_383651689")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Estado)
                    .HasColumnName("estado")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.PidResponsabilidadRecogidaEntrega).HasColumnName("pidResponsabilidadRecogidaEntrega");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("rowguid")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.SidDireccionTercero).HasColumnName("sidDireccionTercero");

                entity.Property(e => e.SidFraccion).HasColumnName("sidFraccion");

                entity.Property(e => e.SidTercero).HasColumnName("sidTercero");

                entity.Property(e => e.SidTipoContenedor).HasColumnName("sidTipoContenedor");

                entity.Property(e => e.TipoOperacion)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasColumnName("tipoOperacion");
            });

            modelBuilder.Entity<ResponsabilidadesTratamiento>(entity =>
            {
                entity.ToTable("ResponsabilidadesTratamiento");

                entity.HasIndex(e => e.Estado, "Estado_ResponsabilidadesTratamiento")
                    .HasFillFactor(80);

                entity.HasIndex(e => e.Rowguid, "MSmerge_index_479652031")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Estado)
                    .HasColumnName("estado")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.PidResponsabilidadTratamiento).HasColumnName("pidResponsabilidadTratamiento");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("rowguid")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.SidDireccionTercero).HasColumnName("sidDireccionTercero");

                entity.Property(e => e.SidFraccion).HasColumnName("sidFraccion");

                entity.Property(e => e.SidResiduo).HasColumnName("sidResiduo");

                entity.Property(e => e.SidTercero).HasColumnName("sidTercero");

                entity.Property(e => e.SidTipoContenedor).HasColumnName("sidTipoContenedor");

                entity.Property(e => e.TipoOperacion)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasColumnName("tipoOperacion");
            });

            modelBuilder.Entity<ResponsabilidadesTratamientoVersionAnterior>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ResponsabilidadesTratamiento_versionAnterior");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.PidResponsabilidadTratamiento).HasColumnName("pidResponsabilidadTratamiento");

                entity.Property(e => e.Rowguid).HasColumnName("rowguid");

                entity.Property(e => e.SidDireccionTercero).HasColumnName("sidDireccionTercero");

                entity.Property(e => e.SidFraccion).HasColumnName("sidFraccion");

                entity.Property(e => e.SidResiduo).HasColumnName("sidResiduo");

                entity.Property(e => e.SidTercero).HasColumnName("sidTercero");

                entity.Property(e => e.SidTipoContenedor).HasColumnName("sidTipoContenedor");

                entity.Property(e => e.TipoOperacion)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasColumnName("tipoOperacion");
            });

            modelBuilder.Entity<ResposaRecogEntregaBack>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Resposa_RecogEntrega_back");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.PidResponsabilidadRecogidaEntrega).HasColumnName("pidResponsabilidadRecogidaEntrega");

                entity.Property(e => e.Rowguid).HasColumnName("rowguid");

                entity.Property(e => e.SidDireccionTercero).HasColumnName("sidDireccionTercero");

                entity.Property(e => e.SidFraccion).HasColumnName("sidFraccion");

                entity.Property(e => e.SidTercero).HasColumnName("sidTercero");

                entity.Property(e => e.SidTipoContenedor).HasColumnName("sidTipoContenedor");

                entity.Property(e => e.TipoOperacion)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasColumnName("tipoOperacion");
            });

            modelBuilder.Entity<ResposaTratamientoBack>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Resposa_Tratamiento_back");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.PidResponsabilidadTratamiento).HasColumnName("pidResponsabilidadTratamiento");

                entity.Property(e => e.Rowguid).HasColumnName("rowguid");

                entity.Property(e => e.SidDireccionTercero).HasColumnName("sidDireccionTercero");

                entity.Property(e => e.SidFraccion).HasColumnName("sidFraccion");

                entity.Property(e => e.SidResiduo).HasColumnName("sidResiduo");

                entity.Property(e => e.SidTercero).HasColumnName("sidTercero");

                entity.Property(e => e.SidTipoContenedor).HasColumnName("sidTipoContenedor");

                entity.Property(e => e.TipoOperacion)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasColumnName("tipoOperacion");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.HasKey(e => e.PidRol);

                entity.Property(e => e.PidRol).HasColumnName("pidRol");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<ServiciosSinRetiradaConsultum>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ServiciosSinRetiradaConsulta");

                entity.Property(e => e.CodigoExterno)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.Coordenadas)
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.DestinoCentro)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DestinoDir).IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.EmisorCentro)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EmisorDir).IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha");

                entity.Property(e => e.FirmaCargoProcedencia)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("Firma_cargo_Procedencia");

                entity.Property(e => e.FirmaCargoTransporte)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("Firma_cargo_Transporte");

                entity.Property(e => e.FirmaNombreProcedencia)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("Firma_nombre_Procedencia");

                entity.Property(e => e.FirmaNombreTransporte)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("Firma_nombre_Transporte");

                entity.Property(e => e.FirmaUrlProcedencia)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("Firma_url_Procedencia");

                entity.Property(e => e.FirmaUrlTransporte)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("Firma_url_Transporte");

                entity.Property(e => e.GpsX).HasColumnName("gpsX");

                entity.Property(e => e.GpsY).HasColumnName("gpsY");

                entity.Property(e => e.GpsZ).HasColumnName("gpsZ");

                entity.Property(e => e.Nalbaran)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("NAlbaran");

                entity.Property(e => e.Nservicio)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("NServicio");

                entity.Property(e => e.NumFirmas).HasColumnName("numFirmas");

                entity.Property(e => e.OrigenCentro)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OrigenDir).IsUnicode(false);

                entity.Property(e => e.SidDireccionTerceroDestinatario).HasColumnName("sidDireccionTerceroDestinatario");

                entity.Property(e => e.SidDireccionTerceroEmisor).HasColumnName("sidDireccionTerceroEmisor");

                entity.Property(e => e.SidDireccionTerceroSolicitante).HasColumnName("sidDireccionTerceroSolicitante");

                entity.Property(e => e.SidEstado).HasColumnName("sidEstado");

                entity.Property(e => e.SidFirmaProcedencia)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("sidFirmaProcedencia");

                entity.Property(e => e.SidFirmaTransporte)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("sidFirmaTransporte");

                entity.Property(e => e.SidTerceroDestinatario).HasColumnName("sidTerceroDestinatario");

                entity.Property(e => e.SidTerceroEmisor).HasColumnName("sidTerceroEmisor");

                entity.Property(e => e.SidTerceroSolicitante).HasColumnName("sidTerceroSolicitante");

                entity.Property(e => e.SidTipoServicio).HasColumnName("sidTipoServicio");

                entity.Property(e => e.TipoServicio).HasMaxLength(50);
            });

            modelBuilder.Entity<Sig>(entity =>
            {
                entity.HasKey(e => e.PidSig)
                    .HasName("PK_SIGS");

                entity.ToTable("SIGs");

                entity.Property(e => e.PidSig)
                    .ValueGeneratedNever()
                    .HasColumnName("pidSIG");

                entity.Property(e => e.Estado)
                    .HasColumnName("estado")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<Solicitude>(entity =>
            {
                entity.HasKey(e => e.PidSolicitud);

                entity.HasIndex(e => e.Estado, "Estado_Solicitudes")
                    .HasFillFactor(80);

                entity.HasIndex(e => new { e.SidDireccionTerceroOrigen, e.Estado }, "IX_DIRORI_ESTADO")
                    .HasFillFactor(80);

                entity.HasIndex(e => new { e.SidDireccionTerceroDestino, e.Estado }, "IX_DIRSOL_ESTADO")
                    .HasFillFactor(80);

                entity.HasIndex(e => e.SidTerceroOrigen, "IX_FK_TercerosSolicitud")
                    .HasFillFactor(80);

                entity.HasIndex(e => e.SidTerceroDestino, "IX_FK_TercerosSolicitud1")
                    .HasFillFactor(80);

                entity.HasIndex(e => e.Rowguid, "MSmerge_index_1075794119")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.Property(e => e.PidSolicitud)
                    .ValueGeneratedNever()
                    .HasColumnName("pidSolicitud");

                entity.Property(e => e.Accion)
                    .HasMaxLength(255)
                    .HasColumnName("accion");

                entity.Property(e => e.AlbaranOrigen)
                    .HasMaxLength(255)
                    .HasColumnName("albaranOrigen");

                entity.Property(e => e.Estado)
                    .HasColumnName("estado")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha");

                entity.Property(e => e.FechaAnulacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaAnulacion");

                entity.Property(e => e.Observaciones).HasMaxLength(255);

                entity.Property(e => e.Rowguid)
                    .HasColumnName("rowguid")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.SidDireccionTerceroDestino).HasColumnName("sidDireccionTerceroDestino");

                entity.Property(e => e.SidDireccionTerceroOrigen).HasColumnName("sidDireccionTerceroOrigen");

                entity.Property(e => e.SidTerceroDestino).HasColumnName("sidTerceroDestino");

                entity.Property(e => e.SidTerceroOrigen).HasColumnName("sidTerceroOrigen");

                entity.HasOne(d => d.SidDireccionTerceroDestinoNavigation)
                    .WithMany(p => p.SolicitudeSidDireccionTerceroDestinoNavigations)
                    .HasForeignKey(d => d.SidDireccionTerceroDestino)
                    .HasConstraintName("DestinoDireccion");

                entity.HasOne(d => d.SidDireccionTerceroOrigenNavigation)
                    .WithMany(p => p.SolicitudeSidDireccionTerceroOrigenNavigations)
                    .HasForeignKey(d => d.SidDireccionTerceroOrigen)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("OrigenDireccion");

                entity.HasOne(d => d.SidTerceroDestinoNavigation)
                    .WithMany(p => p.SolicitudeSidTerceroDestinoNavigations)
                    .HasForeignKey(d => d.SidTerceroDestino)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Destino");

                entity.HasOne(d => d.SidTerceroOrigenNavigation)
                    .WithMany(p => p.SolicitudeSidTerceroOrigenNavigations)
                    .HasForeignKey(d => d.SidTerceroOrigen)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Origen");
            });

            modelBuilder.Entity<SolicitudesConsultum>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SolicitudesConsulta");

                entity.Property(e => e.AlbaranOrigen)
                    .HasMaxLength(255)
                    .HasColumnName("albaranOrigen");

                entity.Property(e => e.DireccionTerceroOrigen).IsUnicode(false);

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha");

                entity.Property(e => e.PidSolicitud).HasColumnName("pidSolicitud");

                entity.Property(e => e.SidDireccionTerceroDestino).HasColumnName("sidDireccionTerceroDestino");

                entity.Property(e => e.SidDireccionTerceroOrigen).HasColumnName("sidDireccionTerceroOrigen");

                entity.Property(e => e.SidTerceroDestino).HasColumnName("sidTerceroDestino");

                entity.Property(e => e.SidTerceroOrigen).HasColumnName("sidTerceroOrigen");
            });

            modelBuilder.Entity<Temporal>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("temporal");

                entity.Property(e => e.PidCertificado)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("pidCertificado");
            });

            modelBuilder.Entity<Tercero>(entity =>
            {
                entity.HasKey(e => e.PidTercero);

                entity.HasIndex(e => e.Estado, "Estado_Terceros")
                    .HasFillFactor(80);

                entity.HasIndex(e => new { e.CodGtr, e.PidTercero }, "IX_GTR_PID")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.HasIndex(e => e.PidTercero, "IX_TERCERO")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.HasIndex(e => e.PidTercero, "IX_TipoTercero")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.HasIndex(e => e.Rowguid, "MSmerge_index_307791383")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.Property(e => e.PidTercero)
                    .ValueGeneratedNever()
                    .HasColumnName("pidTercero");

                entity.Property(e => e.CodGtr).HasColumnName("codGTR");

                entity.Property(e => e.Estado)
                    .HasColumnName("estado")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Nif)
                    .IsRequired()
                    .HasColumnName("NIF");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre");

                entity.Property(e => e.NombreComercial)
                    .HasMaxLength(255)
                    .HasColumnName("nombreComercial");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("rowguid")
                    .HasDefaultValueSql("(newsequentialid())");
            });

            modelBuilder.Entity<TercerosConDireccione>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("TercerosConDirecciones");

                entity.Property(e => e.Direccion)
                    .IsUnicode(false)
                    .HasColumnName("direccion");

                entity.Property(e => e.Municipio)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("municipio");

                entity.Property(e => e.Nif)
                    .IsRequired()
                    .HasColumnName("NIF");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre");

                entity.Property(e => e.PidTercero).HasColumnName("pidTercero");

                entity.Property(e => e.Provincia)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("provincia");

                entity.Property(e => e.Tipotercero)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("tipotercero");
            });

            modelBuilder.Entity<TercerosDireccionesContacto>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("TercerosDireccionesContactos");

                entity.Property(e => e.Apellidos).HasColumnName("apellidos");

                entity.Property(e => e.Centro)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoPostal)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("codigoPostal");

                entity.Property(e => e.ContactosDireccionTerceroNombre).HasColumnName("ContactosDireccionTercero nombre");

                entity.Property(e => e.Direccion)
                    .IsUnicode(false)
                    .HasColumnName("direccion");

                entity.Property(e => e.EstadoContactoTercero).HasColumnName("Estado Contacto Tercero");

                entity.Property(e => e.EstadoDirecciónTercero).HasColumnName("Estado Dirección Tercero");

                entity.Property(e => e.EstadoTercero).HasColumnName("Estado Tercero");

                entity.Property(e => e.MunicipiosNombre)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("Municipios nombre");

                entity.Property(e => e.Nif)
                    .IsRequired()
                    .HasColumnName("NIF");

                entity.Property(e => e.PidContactoDireccionTercero).HasColumnName("pidContactoDireccionTercero");

                entity.Property(e => e.PidDireccionTercero).HasColumnName("pidDireccionTercero");

                entity.Property(e => e.PidTercero).HasColumnName("pidTercero");

                entity.Property(e => e.ProvinciasNombre)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("Provincias nombre");

                entity.Property(e => e.TercerosNombre)
                    .IsRequired()
                    .HasColumnName("Terceros nombre");
            });

            modelBuilder.Entity<TercerosExcluido>(entity =>
            {
                entity.HasKey(e => e.PidTerceroExcluido);

                entity.Property(e => e.PidTerceroExcluido).HasColumnName("pidTerceroExcluido");

                entity.Property(e => e.SidTercero).HasColumnName("sidTercero");

                entity.HasOne(d => d.SidTerceroNavigation)
                    .WithMany(p => p.TercerosExcluidos)
                    .HasForeignKey(d => d.SidTercero)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TercerosExcluidos_TercerosExcluidos");
            });

            modelBuilder.Entity<TercerosReutilizacion2017>(entity =>
            {
                entity.HasKey(e => new { e.SidTercero, e.SidDireccionTercero });

                entity.ToTable("TercerosReutilizacion2017");

                entity.Property(e => e.SidTercero).HasColumnName("sidTercero");

                entity.Property(e => e.SidDireccionTercero).HasColumnName("sidDireccionTercero");

                entity.Property(e => e.FechaTratamientosReutilizar)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaTratamientosReutilizar");

                entity.HasOne(d => d.SidDireccionTerceroNavigation)
                    .WithMany(p => p.TercerosReutilizacion2017s)
                    .HasForeignKey(d => d.SidDireccionTercero)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TercerosReutilizacion2017_DireccionesTercero");

                entity.HasOne(d => d.SidTerceroNavigation)
                    .WithMany(p => p.TercerosReutilizacion2017s)
                    .HasForeignKey(d => d.SidTercero)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TercerosReutilizacion2017_Terceros");
            });

            modelBuilder.Entity<TercerosTiposTercero>(entity =>
            {
                entity.HasKey(e => e.PidTerceroTipoTercero);

                entity.ToTable("TercerosTiposTercero");

                entity.HasIndex(e => e.Estado, "Estado_TercerosTIposTercero")
                    .HasFillFactor(80);

                entity.HasIndex(e => e.Rowguid, "MSmerge_index_508840104")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.Property(e => e.PidTerceroTipoTercero)
                    .ValueGeneratedNever()
                    .HasColumnName("pidTerceroTipoTercero");

                entity.Property(e => e.Estado)
                    .HasColumnName("estado")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("rowguid")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.SidTercero).HasColumnName("sidTercero");

                entity.Property(e => e.SidTipoTercero).HasColumnName("sidTipoTercero");

                entity.HasOne(d => d.SidTerceroNavigation)
                    .WithMany(p => p.TercerosTiposTerceros)
                    .HasForeignKey(d => d.SidTercero)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TercerosTiposTercero_Terceros");

                entity.HasOne(d => d.SidTipoTerceroNavigation)
                    .WithMany(p => p.TercerosTiposTerceros)
                    .HasForeignKey(d => d.SidTipoTercero)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TercerosTiposTercero_TiposTercero");
            });

            modelBuilder.Entity<Terminale>(entity =>
            {
                entity.HasKey(e => new { e.SidTercero, e.SidDireccion });

                entity.Property(e => e.SidTercero).HasColumnName("sidTercero");

                entity.Property(e => e.SidDireccion).HasColumnName("sidDireccion");

                entity.Property(e => e.Terminal)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.SidDireccionNavigation)
                    .WithMany(p => p.Terminales)
                    .HasForeignKey(d => d.SidDireccion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Terminales_DireccionesTercero");

                entity.HasOne(d => d.SidTerceroNavigation)
                    .WithMany(p => p.Terminales)
                    .HasForeignKey(d => d.SidTercero)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Terminales_Terceros");
            });

            modelBuilder.Entity<TiposCertificado>(entity =>
            {
                entity.HasKey(e => e.PidTipoCertificado)
                    .HasName("PK_Certificados_Tipo");

                entity.ToTable("TiposCertificado");

                entity.Property(e => e.PidTipoCertificado)
                    .ValueGeneratedNever()
                    .HasColumnName("pidTipoCertificado");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("nombre");

                entity.Property(e => e.Sigla)
                    .HasMaxLength(10)
                    .HasColumnName("sigla")
                    .IsFixedLength();
            });

            modelBuilder.Entity<TiposContenedor>(entity =>
            {
                entity.HasKey(e => e.PidTipoContenedor)
                    .HasName("PK_TIPOSDECONTENEDOR");

                entity.ToTable("TiposContenedor");

                entity.HasIndex(e => e.Estado, "Estado_TiposContenedor")
                    .HasFillFactor(80);

                entity.HasIndex(e => e.Rowguid, "MSmerge_index_963793720")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.Property(e => e.PidTipoContenedor)
                    .ValueGeneratedNever()
                    .HasColumnName("pidTipoContenedor");

                entity.Property(e => e.CodGtr).HasColumnName("codGTR");

                entity.Property(e => e.Estado)
                    .HasColumnName("estado")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("nombre");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("rowguid")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.Tara).HasColumnName("tara");
            });

            modelBuilder.Entity<TiposDestino>(entity =>
            {
                entity.HasKey(e => e.PidTipoDestino)
                    .HasName("PK_TiposDestinoCertificados");

                entity.ToTable("TiposDestino");

                entity.Property(e => e.PidTipoDestino)
                    .ValueGeneratedNever()
                    .HasColumnName("pidTipoDestino");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<TiposEtiquetum>(entity =>
            {
                entity.HasKey(e => e.PidTipoEtiqueta)
                    .HasName("PK_TIPOSETIQUETAS");

                entity.Property(e => e.PidTipoEtiqueta)
                    .ValueGeneratedNever()
                    .HasColumnName("pidTipoEtiqueta");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<TiposIncidencium>(entity =>
            {
                entity.HasKey(e => e.PidTipoIncidencia);

                entity.Property(e => e.PidTipoIncidencia)
                    .ValueGeneratedNever()
                    .HasColumnName("pidTipoIncidencia");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<TiposLectura>(entity =>
            {
                entity.HasKey(e => e.PidTipoLectura)
                    .HasName("PK_TIPODELECTORA");

                entity.ToTable("TiposLectura");

                entity.Property(e => e.PidTipoLectura)
                    .ValueGeneratedNever()
                    .HasColumnName("pidTipoLectura");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<TiposLecturaTratamiento>(entity =>
            {
                entity.HasKey(e => e.PidTipoLecturaTratamiento)
                    .HasName("PK_TIPODELECTORATRATAMIENTO");

                entity.ToTable("TiposLecturaTratamiento");

                entity.Property(e => e.PidTipoLecturaTratamiento)
                    .ValueGeneratedNever()
                    .HasColumnName("pidTipoLecturaTratamiento");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<TiposOperativa>(entity =>
            {
                entity.HasKey(e => e.PidTipoOperativa);

                entity.ToTable("TiposOperativa");

                entity.Property(e => e.PidTipoOperativa)
                    .HasMaxLength(3)
                    .HasColumnName("pidTipoOperativa");

                entity.Property(e => e.Estado)
                    .HasColumnName("estado")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("nombre");

                entity.Property(e => e.NombreCodigo)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasColumnName("nombreCodigo");
            });

            modelBuilder.Entity<TiposServicio>(entity =>
            {
                entity.HasKey(e => e.PidTipoServicio)
                    .HasName("PK_TiposServicioCertificados");

                entity.ToTable("TiposServicio");

                entity.Property(e => e.PidTipoServicio)
                    .ValueGeneratedNever()
                    .HasColumnName("pidTipoServicio");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("nombre");

                entity.Property(e => e.Tipo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("tipo")
                    .IsFixedLength();
            });

            modelBuilder.Entity<TiposTercero>(entity =>
            {
                entity.HasKey(e => e.PidTipoTercero)
                    .HasName("PK_TipoTerceros");

                entity.ToTable("TiposTercero");

                entity.Property(e => e.PidTipoTercero)
                    .ValueGeneratedNever()
                    .HasColumnName("pidTipoTercero");

                entity.Property(e => e.Estado)
                    .HasColumnName("estado")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<Tlog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tlog");

                entity.Property(e => e.Descripcion).HasColumnName("descripcion");

                entity.Property(e => e.Idlog)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("idlog");
            });

            modelBuilder.Entity<Tratamiento>(entity =>
            {
                entity.HasKey(e => e.PidTratamiento);

                entity.Property(e => e.PidTratamiento)
                    .HasMaxLength(50)
                    .HasColumnName("pidTratamiento");

                entity.Property(e => e.Etiquetas).IsRequired();

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.NroCertificado)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("nroCertificado");

                entity.Property(e => e.Rfids)
                    .IsRequired()
                    .HasColumnName("RFIDs");
            });

            modelBuilder.Entity<TratamientosError>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TratamientosError");

                entity.Property(e => e.Etiquetas).IsRequired();

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.NroCertificado)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("nroCertificado");

                entity.Property(e => e.PidTratamiento)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("pidTratamiento");

                entity.Property(e => e.Rfids)
                    .IsRequired()
                    .HasColumnName("RFIDs");
            });

            modelBuilder.Entity<UltimaUbicacionRaeeSinTratar>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("UltimaUbicacionRAEE_SinTratar");

                entity.Property(e => e.DireccionTercero).IsUnicode(false);

                entity.Property(e => e.Estado).HasMaxLength(255);

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha");

                entity.Property(e => e.Fraccion).HasMaxLength(255);

                entity.Property(e => e.Residuo).HasMaxLength(50);

                entity.Property(e => e.ResiduoEspecifico).HasMaxLength(255);

                entity.Property(e => e.SidCertificado)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("sidCertificado");

                entity.Property(e => e.SidDireccionTercero).HasColumnName("sidDireccionTercero");

                entity.Property(e => e.SidEstadoRaee).HasColumnName("sidEstadoRAEE");

                entity.Property(e => e.SidFraccion).HasColumnName("sidFraccion");

                entity.Property(e => e.SidRaee)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("sidRAEE");

                entity.Property(e => e.SidResiduo).HasColumnName("sidResiduo");

                entity.Property(e => e.SidResiduoEspecifico).HasColumnName("sidResiduoEspecifico");

                entity.Property(e => e.SidTercero).HasColumnName("sidTercero");
            });

            modelBuilder.Entity<UltimasUbicacionesRaee>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("UltimasUbicacionesRAEE");

                entity.Property(e => e.DireccionTercero).IsUnicode(false);

                entity.Property(e => e.Estado).HasMaxLength(255);

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha");

                entity.Property(e => e.Fraccion).HasMaxLength(255);

                entity.Property(e => e.Residuo).HasMaxLength(50);

                entity.Property(e => e.ResiduoEspecifico).HasMaxLength(255);

                entity.Property(e => e.SidCertificado)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("sidCertificado");

                entity.Property(e => e.SidDireccionTercero).HasColumnName("sidDireccionTercero");

                entity.Property(e => e.SidEstadoRaee).HasColumnName("sidEstadoRAEE");

                entity.Property(e => e.SidFraccion).HasColumnName("sidFraccion");

                entity.Property(e => e.SidRaee)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("sidRAEE");

                entity.Property(e => e.SidResiduo).HasColumnName("sidResiduo");

                entity.Property(e => e.SidResiduoEspecifico).HasColumnName("sidResiduoEspecifico");

                entity.Property(e => e.SidTercero).HasColumnName("sidTercero");
            });

            modelBuilder.Entity<UltimasUbicacionesRaeeMasTratadosNoLigadosCertificado>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("UltimasUbicacionesRAEE_MasTratadosNoLigadosCertificados");

                entity.Property(e => e.Activacion)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.DireccionTercero).IsUnicode(false);

                entity.Property(e => e.Estado).HasMaxLength(255);

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha");

                entity.Property(e => e.Fraccion).HasMaxLength(255);

                entity.Property(e => e.IdActivacion).HasColumnName("idActivacion");

                entity.Property(e => e.ResiduoEspecifico).HasMaxLength(255);

                entity.Property(e => e.SidCertificado)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("sidCertificado");

                entity.Property(e => e.SidDireccionTercero).HasColumnName("sidDireccionTercero");

                entity.Property(e => e.SidEstadoRaee).HasColumnName("sidEstadoRAEE");

                entity.Property(e => e.SidFraccion).HasColumnName("sidFraccion");

                entity.Property(e => e.SidRaee)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("sidRAEE");

                entity.Property(e => e.SidResiduoEspecifico).HasColumnName("sidResiduoEspecifico");

                entity.Property(e => e.SidTercero).HasColumnName("sidTercero");
            });

            modelBuilder.Entity<UltimasUbicacionesRaeeVOld1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("UltimasUbicacionesRAEE_V_old1");

                entity.Property(e => e.DireccionTercero).IsUnicode(false);

                entity.Property(e => e.Estado).HasMaxLength(255);

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha");

                entity.Property(e => e.Fraccion).HasMaxLength(255);

                entity.Property(e => e.Residuo).HasMaxLength(50);

                entity.Property(e => e.ResiduoEspecifico).HasMaxLength(255);

                entity.Property(e => e.SidCertificado)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("sidCertificado");

                entity.Property(e => e.SidDireccionTercero).HasColumnName("sidDireccionTercero");

                entity.Property(e => e.SidEstadoRaee).HasColumnName("sidEstadoRAEE");

                entity.Property(e => e.SidFraccion).HasColumnName("sidFraccion");

                entity.Property(e => e.SidRaee)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("sidRAEE");

                entity.Property(e => e.SidResiduo).HasColumnName("sidResiduo");

                entity.Property(e => e.SidResiduoEspecifico).HasColumnName("sidResiduoEspecifico");

                entity.Property(e => e.SidTercero).HasColumnName("sidTercero");
            });

            modelBuilder.Entity<UltimasUbicacionesRaeeok>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("UltimasUbicacionesRAEEOK");

                entity.Property(e => e.DireccionTercero).IsUnicode(false);

                entity.Property(e => e.Estado).HasMaxLength(255);

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha");

                entity.Property(e => e.Fraccion).HasMaxLength(255);

                entity.Property(e => e.ResiduoEspecifico).HasMaxLength(255);

                entity.Property(e => e.SidCertificado)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("sidCertificado");

                entity.Property(e => e.SidDireccionTercero).HasColumnName("sidDireccionTercero");

                entity.Property(e => e.SidEstadoRaee).HasColumnName("sidEstadoRAEE");

                entity.Property(e => e.SidFraccion).HasColumnName("sidFraccion");

                entity.Property(e => e.SidRaee)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("sidRAEE");

                entity.Property(e => e.SidResiduoEspecifico).HasColumnName("sidResiduoEspecifico");

                entity.Property(e => e.SidTercero).HasColumnName("sidTercero");
            });

            modelBuilder.Entity<UltimasUbicacionesRaeepdaOld>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("UltimasUbicacionesRAEEPDA_OLD");

                entity.Property(e => e.Canibalizado).HasColumnName("canibalizado");

                entity.Property(e => e.PesoEstimado).HasColumnName("pesoEstimado");

                entity.Property(e => e.PesoReal).HasColumnName("pesoReal");

                entity.Property(e => e.PidRaee)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("pidRAEE");

                entity.Property(e => e.SidCertificadoTratamiento).HasColumnName("sidCertificadoTratamiento");

                entity.Property(e => e.SidDireccionTercero).HasColumnName("sidDireccionTercero");

                entity.Property(e => e.SidEstadoRaee).HasColumnName("sidEstadoRAEE");

                entity.Property(e => e.SidFraccion).HasColumnName("sidFraccion");

                entity.Property(e => e.SidMarca).HasColumnName("sidMarca");

                entity.Property(e => e.SidPaisCodigoRaee).HasColumnName("sidPaisCodigoRAEE");

                entity.Property(e => e.SidResiduo).HasColumnName("sidResiduo");

                entity.Property(e => e.SidResiduoEspecifico).HasColumnName("sidResiduoEspecifico");

                entity.Property(e => e.SidSig).HasColumnName("sidSIG");

                entity.Property(e => e.SidTerceroDestinatario).HasColumnName("sidTerceroDestinatario");

                entity.Property(e => e.SidTipoCertificado).HasColumnName("sidTipoCertificado");

                entity.Property(e => e.SidTipoContenedor).HasColumnName("sidTipoContenedor");

                entity.Property(e => e.SidTipoEtiqueta).HasColumnName("sidTipoEtiqueta");
            });

            modelBuilder.Entity<UltimasUbicacionesRaeepdum>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("UltimasUbicacionesRAEEPDA");

                entity.Property(e => e.Canibalizado).HasColumnName("canibalizado");

                entity.Property(e => e.PesoEstimado).HasColumnName("pesoEstimado");

                entity.Property(e => e.PesoReal).HasColumnName("pesoReal");

                entity.Property(e => e.PidRaee)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("pidRAEE");

                entity.Property(e => e.SidCertificadoTratamiento).HasColumnName("sidCertificadoTratamiento");

                entity.Property(e => e.SidDireccionTercero).HasColumnName("sidDireccionTercero");

                entity.Property(e => e.SidEstadoRaee).HasColumnName("sidEstadoRAEE");

                entity.Property(e => e.SidFraccion).HasColumnName("sidFraccion");

                entity.Property(e => e.SidMarca).HasColumnName("sidMarca");

                entity.Property(e => e.SidPaisCodigoRaee).HasColumnName("sidPaisCodigoRAEE");

                entity.Property(e => e.SidResiduo).HasColumnName("sidResiduo");

                entity.Property(e => e.SidResiduoEspecifico).HasColumnName("sidResiduoEspecifico");

                entity.Property(e => e.SidSig).HasColumnName("sidSIG");

                entity.Property(e => e.SidTerceroDestinatario).HasColumnName("sidTerceroDestinatario");

                entity.Property(e => e.SidTipoCertificado).HasColumnName("sidTipoCertificado");

                entity.Property(e => e.SidTipoContenedor).HasColumnName("sidTipoContenedor");

                entity.Property(e => e.SidTipoEtiqueta).HasColumnName("sidTipoEtiqueta");
            });

            modelBuilder.Entity<UltimasUbicacionesRaeesinTratado>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("UltimasUbicacionesRAEESinTratados");

                entity.Property(e => e.DireccionTercero).IsUnicode(false);

                entity.Property(e => e.Estado).HasMaxLength(255);

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha");

                entity.Property(e => e.Fraccion).HasMaxLength(255);

                entity.Property(e => e.ResiduoEspecifico).HasMaxLength(255);

                entity.Property(e => e.SidCertificado)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("sidCertificado");

                entity.Property(e => e.SidDireccionTercero).HasColumnName("sidDireccionTercero");

                entity.Property(e => e.SidEstadoRaee).HasColumnName("sidEstadoRAEE");

                entity.Property(e => e.SidFraccion).HasColumnName("sidFraccion");

                entity.Property(e => e.SidRaee)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("sidRAEE");

                entity.Property(e => e.SidResiduoEspecifico).HasColumnName("sidResiduoEspecifico");

                entity.Property(e => e.SidTercero).HasColumnName("sidTercero");
            });

            modelBuilder.Entity<UltimasUbicacionesRaeetratado>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("UltimasUbicacionesRAEETratados");

                entity.Property(e => e.DireccionTercero).IsUnicode(false);

                entity.Property(e => e.Estado).HasMaxLength(255);

                entity.Property(e => e.FechaTratamiento)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaTratamiento");

                entity.Property(e => e.Fraccion).HasMaxLength(255);

                entity.Property(e => e.PidRaee)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("pidRAEE");

                entity.Property(e => e.ResiduoEspecifico).HasMaxLength(255);

                entity.Property(e => e.SidCertificado)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("sidCertificado");

                entity.Property(e => e.SidDireccionTercero).HasColumnName("sidDireccionTercero");

                entity.Property(e => e.SidEstadoRaee).HasColumnName("sidEstadoRAEE");

                entity.Property(e => e.SidFraccion).HasColumnName("sidFraccion");

                entity.Property(e => e.SidResiduoEspecifico).HasColumnName("sidResiduoEspecifico");

                entity.Property(e => e.SidTercero).HasColumnName("sidTercero");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.PidUsuario);

                entity.HasIndex(e => e.SidRol, "IX_FK_GVR_USUARIOS_GVR_ROLES")
                    .HasFillFactor(80);

                entity.Property(e => e.PidUsuario).HasColumnName("pidUsuario");

                entity.Property(e => e.Activo).HasColumnName("activo");

                entity.Property(e => e.Apellidos)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("apellidos");

                entity.Property(e => e.Caduca)
                    .HasColumnType("datetime")
                    .HasColumnName("caduca");

                entity.Property(e => e.Contrasena)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("contrasena");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Intento).HasColumnName("intento");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.SidEstado).HasColumnName("sidEstado");

                entity.Property(e => e.SidRol).HasColumnName("sidRol");

                entity.HasOne(d => d.SidRolNavigation)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.SidRol)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GVR_USUARIOS_GVR_ROLES");
            });

            modelBuilder.Entity<V4v3Mapeos2016>(entity =>
            {
                entity.HasKey(e => new { e.Tipo, e.Old })
                    .HasName("PK_MAPEOS_2016");

                entity.ToTable("V4V3_MAPEOS_2016");

                entity.Property(e => e.Tipo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("TIPO");

                entity.Property(e => e.Old).HasColumnName("OLD");

                entity.Property(e => e.New).HasColumnName("NEW");
            });

            modelBuilder.Entity<VAuXRaeesconsulta11k>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_AuX_RAEESConsulta_11K");

                entity.Property(e => e.Canibalizado).HasColumnName("canibalizado");

                entity.Property(e => e.Estado).HasMaxLength(255);

                entity.Property(e => e.FechaTratamiento)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaTratamiento");

                entity.Property(e => e.Fraccion).HasMaxLength(255);

                entity.Property(e => e.Marca)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.PesoEstimado).HasColumnName("pesoEstimado");

                entity.Property(e => e.PesoReal).HasColumnName("pesoReal");

                entity.Property(e => e.PidRaee)
                    .HasMaxLength(50)
                    .HasColumnName("pidRAEE");

                entity.Property(e => e.ResiduoEspecifico).HasMaxLength(255);

                entity.Property(e => e.SidCertificadoTratamiento).HasColumnName("sidCertificadoTratamiento");

                entity.Property(e => e.SidEstadoRaee).HasColumnName("sidEstadoRAEE");

                entity.Property(e => e.SidFraccion).HasColumnName("sidFraccion");

                entity.Property(e => e.SidMarca).HasColumnName("sidMarca");

                entity.Property(e => e.SidResiduoEspecifico).HasColumnName("sidResiduoEspecifico");

                entity.Property(e => e.TipoContenedor).HasMaxLength(255);

                entity.Property(e => e.TratamientoDireccion)
                    .IsUnicode(false)
                    .HasColumnName("Tratamiento_Direccion");

                entity.Property(e => e.TratamientoSidDireccionTercero).HasColumnName("Tratamiento_sidDireccionTercero");

                entity.Property(e => e.TratamientoSidTercero).HasColumnName("Tratamiento_sidTercero");

                entity.Property(e => e.TratamientoSidTipoLecturaTratamiento).HasColumnName("Tratamiento_sidTipoLecturaTratamiento");

                entity.Property(e => e.TratamientoTipoLecturaTratamiento)
                    .HasMaxLength(255)
                    .HasColumnName("Tratamiento_TipoLecturaTratamiento");

                entity.Property(e => e.UltimaUbicacionFecha).HasColumnType("datetime");

                entity.Property(e => e.Video).HasMaxLength(50);
            });

            modelBuilder.Entity<VAuXRaeesconsultum>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_AuX_RAEESConsulta");

                entity.Property(e => e.Canibalizado).HasColumnName("canibalizado");

                entity.Property(e => e.Estado).HasMaxLength(255);

                entity.Property(e => e.FechaTratamiento)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaTratamiento");

                entity.Property(e => e.Fraccion).HasMaxLength(255);

                entity.Property(e => e.Marca)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.PesoEstimado).HasColumnName("pesoEstimado");

                entity.Property(e => e.PesoReal).HasColumnName("pesoReal");

                entity.Property(e => e.PidRaee)
                    .HasMaxLength(50)
                    .HasColumnName("pidRAEE");

                entity.Property(e => e.ResiduoEspecifico).HasMaxLength(255);

                entity.Property(e => e.SidCertificadoTratamiento).HasColumnName("sidCertificadoTratamiento");

                entity.Property(e => e.SidEstadoRaee).HasColumnName("sidEstadoRAEE");

                entity.Property(e => e.SidFraccion).HasColumnName("sidFraccion");

                entity.Property(e => e.SidMarca).HasColumnName("sidMarca");

                entity.Property(e => e.SidResiduoEspecifico).HasColumnName("sidResiduoEspecifico");

                entity.Property(e => e.TipoContenedor).HasMaxLength(255);

                entity.Property(e => e.TratamientoDireccion)
                    .IsUnicode(false)
                    .HasColumnName("Tratamiento_Direccion");

                entity.Property(e => e.TratamientoSidDireccionTercero).HasColumnName("Tratamiento_sidDireccionTercero");

                entity.Property(e => e.TratamientoSidTercero).HasColumnName("Tratamiento_sidTercero");

                entity.Property(e => e.TratamientoSidTipoLecturaTratamiento).HasColumnName("Tratamiento_sidTipoLecturaTratamiento");

                entity.Property(e => e.TratamientoTipoLecturaTratamiento)
                    .HasMaxLength(255)
                    .HasColumnName("Tratamiento_TipoLecturaTratamiento");

                entity.Property(e => e.Video).HasMaxLength(50);
            });

            modelBuilder.Entity<Version>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Version");

                entity.Property(e => e.Version1)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasColumnName("Version")
                    .IsFixedLength();
            });

            modelBuilder.Entity<VersionesPdum>(entity =>
            {
                entity.HasKey(e => new { e.NumPda, e.NombrePrograma });

                entity.ToTable("VersionesPDA");

                entity.Property(e => e.NumPda)
                    .HasMaxLength(3)
                    .HasColumnName("numPDA")
                    .IsFixedLength();

                entity.Property(e => e.NombrePrograma)
                    .HasMaxLength(100)
                    .HasColumnName("nombrePrograma");

                entity.Property(e => e.Bd)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("BD");

                entity.Property(e => e.FechaBloqueo)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaBloqueo");

                entity.Property(e => e.PublicacionInventario)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("publicacionInventario");

                entity.Property(e => e.PublicacionMaestros)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("publicacionMaestros");

                entity.Property(e => e.PublicacionRaees)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("publicacionRaees");

                entity.Property(e => e.TextoBloqueo)
                    .HasMaxLength(255)
                    .HasColumnName("textoBloqueo");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("version");
            });

            modelBuilder.Entity<VersionesPublicacione>(entity =>
            {
                entity.HasKey(e => new { e.Version, e.NombrePrograma });

                entity.Property(e => e.Version)
                    .HasMaxLength(50)
                    .HasColumnName("version");

                entity.Property(e => e.NombrePrograma)
                    .HasMaxLength(100)
                    .HasColumnName("nombrePrograma");

                entity.Property(e => e.Activa)
                    .IsRequired()
                    .HasColumnName("activa")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Bd)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("BD");

                entity.Property(e => e.PublicacionInventario)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("publicacionInventario");

                entity.Property(e => e.PublicacionMaestros)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("publicacionMaestros");

                entity.Property(e => e.PublicacionRaees)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("publicacionRaees");
            });

            modelBuilder.Entity<VideosRaee>(entity =>
            {
                entity.HasKey(e => e.PidVideoRaee)
                    .IsClustered(false);

                entity.ToTable("VideosRAEE");

                entity.HasIndex(e => e.SidRaee, "IX_RAEE")
                    .HasFillFactor(80);

                entity.Property(e => e.PidVideoRaee).HasColumnName("pidVideoRAEE");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Hora)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.NombreFichero)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("nombreFichero");

                entity.Property(e => e.SidRaee)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("sidRAEE");

                entity.HasOne(d => d.SidRaeeNavigation)
                    .WithMany(p => p.VideosRaees)
                    .HasForeignKey(d => d.SidRaee)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VideosRAEE_RAEEs");
            });

            modelBuilder.Entity<VideosRaeeConfigRuta>(entity =>
            {
                entity.HasKey(e => e.PidConfigVideos)
                    .HasName("PK_ConfigVideosRAEEs_Rutas");

                entity.ToTable("VideosRAEE_ConfigRutas");

                entity.Property(e => e.PidConfigVideos).HasColumnName("pidConfigVideos");

                entity.Property(e => e.Ruta)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("ruta");
            });

            modelBuilder.Entity<VistaReplicacion>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VistaReplicacion");

                entity.Property(e => e.Canibalizado).HasColumnName("canibalizado");

                entity.Property(e => e.Expr1)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PesoEstimado).HasColumnName("pesoEstimado");

                entity.Property(e => e.PesoReal).HasColumnName("pesoReal");

                entity.Property(e => e.PidRaee)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("pidRAEE");

                entity.Property(e => e.SidCertificadoTratamiento).HasColumnName("sidCertificadoTratamiento");

                entity.Property(e => e.SidDireccionTercero).HasColumnName("sidDireccionTercero");

                entity.Property(e => e.SidEstadoRaee).HasColumnName("sidEstadoRAEE");

                entity.Property(e => e.SidFraccion).HasColumnName("sidFraccion");

                entity.Property(e => e.SidMarca).HasColumnName("sidMarca");

                entity.Property(e => e.SidPaisCodigoRaee).HasColumnName("sidPaisCodigoRAEE");

                entity.Property(e => e.SidResiduoEspecifico).HasColumnName("sidResiduoEspecifico");

                entity.Property(e => e.SidSig).HasColumnName("sidSIG");

                entity.Property(e => e.SidTercero).HasColumnName("sidTercero");

                entity.Property(e => e.SidTipoContenedor).HasColumnName("sidTipoContenedor");

                entity.Property(e => e.SidTipoEtiqueta).HasColumnName("sidTipoEtiqueta");
            });

            modelBuilder.Entity<WtkCambioEstado>(entity =>
            {
                entity.ToTable("WTK_CAMBIO_ESTADO");

                entity.HasIndex(e => e.Fecha, "IX_ESTADO")
                    .HasFillFactor(80);

                entity.HasIndex(e => e.SidRaee, "IX_RAEE")
                    .HasFillFactor(80);

                entity.HasIndex(e => new { e.SidCertificado, e.SidEstado }, "Indice_CertEstado")
                    .HasFillFactor(80);

                entity.Property(e => e.Albaran)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha");

                entity.Property(e => e.GpsX).HasColumnName("gpsX");

                entity.Property(e => e.GpsY).HasColumnName("gpsY");

                entity.Property(e => e.GpsZ).HasColumnName("gpsZ");

                entity.Property(e => e.SidCertificado)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("sidCertificado");

                entity.Property(e => e.SidDireccionTercero).HasColumnName("sidDireccionTercero");

                entity.Property(e => e.SidEstado).HasColumnName("sidEstado");

                entity.Property(e => e.SidRaee)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("sidRAEE");

                entity.Property(e => e.SidTercero).HasColumnName("sidTercero");

                entity.Property(e => e.SidUsuario).HasColumnName("sidUsuario");

                entity.HasOne(d => d.SidCertificadoNavigation)
                    .WithMany(p => p.WtkCambioEstados)
                    .HasForeignKey(d => d.SidCertificado)
                    .HasConstraintName("FK_WTK_CAMBIO_ESTADO_Certificados");

                entity.HasOne(d => d.SidDireccionTerceroNavigation)
                    .WithMany(p => p.WtkCambioEstados)
                    .HasForeignKey(d => d.SidDireccionTercero)
                    .HasConstraintName("FK_WTK_CAMBIO_ESTADO_DireccionesTercero");

                entity.HasOne(d => d.SidEstadoNavigation)
                    .WithMany(p => p.WtkCambioEstados)
                    .HasForeignKey(d => d.SidEstado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WTK_CAMBIO_ESTADO_EstadosRAEE");

                entity.HasOne(d => d.SidRaeeNavigation)
                    .WithMany(p => p.WtkCambioEstados)
                    .HasForeignKey(d => d.SidRaee)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WTK_CAMBIO_ESTADO_RAEEs");

                entity.HasOne(d => d.SidTerceroNavigation)
                    .WithMany(p => p.WtkCambioEstados)
                    .HasForeignKey(d => d.SidTercero)
                    .HasConstraintName("FK_WTK_CAMBIO_ESTADO_Terceros");

                entity.HasOne(d => d.SidUsuarioNavigation)
                    .WithMany(p => p.WtkCambioEstados)
                    .HasForeignKey(d => d.SidUsuario)
                    .HasConstraintName("FK_WTK_CAMBIO_ESTADO_WTK_USUARIO");
            });

            modelBuilder.Entity<WtkCambioEstadoBack>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("WTK_CAMBIO_ESTADO_BACK");

                entity.Property(e => e.Albaran)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha");

                entity.Property(e => e.GpsX).HasColumnName("gpsX");

                entity.Property(e => e.GpsY).HasColumnName("gpsY");

                entity.Property(e => e.GpsZ).HasColumnName("gpsZ");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.SidCertificado)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("sidCertificado");

                entity.Property(e => e.SidDireccionTercero).HasColumnName("sidDireccionTercero");

                entity.Property(e => e.SidEstado).HasColumnName("sidEstado");

                entity.Property(e => e.SidRaee)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("sidRAEE");

                entity.Property(e => e.SidTercero).HasColumnName("sidTercero");

                entity.Property(e => e.SidUsuario).HasColumnName("sidUsuario");
            });

            modelBuilder.Entity<WtkCambioEstadoFirma>(entity =>
            {
                entity.ToTable("WTK_CAMBIO_ESTADO_FIRMA");

                entity.Property(e => e.Firma)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("firma");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.SidCambioEstado).HasColumnName("sidCambioEstado");

                entity.HasOne(d => d.SidCambioEstadoNavigation)
                    .WithMany(p => p.WtkCambioEstadoFirmas)
                    .HasForeignKey(d => d.SidCambioEstado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WTK_CAMBIO_ESTADO_FIRMA_WTK_CAMBIO_ESTADO");
            });

            modelBuilder.Entity<WtkCambioEstadoFotografium>(entity =>
            {
                entity.ToTable("WTK_CAMBIO_ESTADO_FOTOGRAFIA");

                entity.Property(e => e.Fichero)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("fichero");

                entity.Property(e => e.SidCambioEstado).HasColumnName("sidCambioEstado");

                entity.HasOne(d => d.SidCambioEstadoNavigation)
                    .WithMany(p => p.WtkCambioEstadoFotografia)
                    .HasForeignKey(d => d.SidCambioEstado)
                    .HasConstraintName("FK_WTK_CAMBIO_ESTADO_FOTOGRAFIA_WTK_CAMBIO_ESTADO");
            });

            modelBuilder.Entity<WtkPerfil>(entity =>
            {
                entity.ToTable("WTK_PERFIL");

                entity.Property(e => e.Id)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WtkResiduoespecifico>(entity =>
            {
                entity.ToTable("WTK_RESIDUOESPECIFICO");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WtkTextoLopd>(entity =>
            {
                entity.ToTable("WTK_TEXTO_LOPD");

                entity.HasIndex(e => e.SidTercero, "UQ__WTK_TEXT__4BDAAAEE198C97F9")
                    .IsUnique();

                entity.Property(e => e.SidTercero).HasColumnName("sidTercero");

                entity.Property(e => e.Texto).IsUnicode(false);

                entity.HasOne(d => d.SidTerceroNavigation)
                    .WithOne(p => p.WtkTextoLopd)
                    .HasForeignKey<WtkTextoLopd>(d => d.SidTercero)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WTK_TEXTO_LOPD_Terceros");
            });

            modelBuilder.Entity<WtkUsuario>(entity =>
            {
                entity.ToTable("WTK_USUARIO");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SidTercero).HasColumnName("sidTercero");

                entity.Property(e => e.SidTipoTercero).HasColumnName("sidTipoTercero");

                entity.Property(e => e.Usuario)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.SidTerceroNavigation)
                    .WithMany(p => p.WtkUsuarios)
                    .HasForeignKey(d => d.SidTercero)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WTK_USUARIO_Terceros");

                entity.HasOne(d => d.SidTipoTerceroNavigation)
                    .WithMany(p => p.WtkUsuarios)
                    .HasForeignKey(d => d.SidTipoTercero)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WTK_USUARIO_TiposTercero");

                entity.HasMany(d => d.SidDireccions)
                    .WithMany(p => p.SidUsuarios)
                    .UsingEntity<Dictionary<string, object>>(
                        "WtkUsuarioDireccione",
                        l => l.HasOne<DireccionesTercero>().WithMany().HasForeignKey("SidDireccion").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_WTK_USUARIO_DIRECCIONES_DireccionesTercero"),
                        r => r.HasOne<WtkUsuario>().WithMany().HasForeignKey("SidUsuario").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_WTK_USUARIO_DIRECCIONES_WTK_USUARIO"),
                        j =>
                        {
                            j.HasKey("SidUsuario", "SidDireccion");

                            j.ToTable("WTK_USUARIO_DIRECCIONES");

                            j.IndexerProperty<int>("SidUsuario").HasColumnName("sidUsuario");

                            j.IndexerProperty<int>("SidDireccion").HasColumnName("sidDireccion");
                        });

                entity.HasMany(d => d.SidPerfils)
                    .WithMany(p => p.SidUsuarios)
                    .UsingEntity<Dictionary<string, object>>(
                        "WtkUsuarioPerfile",
                        l => l.HasOne<WtkPerfil>().WithMany().HasForeignKey("SidPerfil").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_WTK_USUARIO_PERFILES_WTK_PERFIL"),
                        r => r.HasOne<WtkUsuario>().WithMany().HasForeignKey("SidUsuario").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_WTK_USUARIO_PERFILES_WTK_USUARIOS"),
                        j =>
                        {
                            j.HasKey("SidUsuario", "SidPerfil");

                            j.ToTable("WTK_USUARIO_PERFILES");

                            j.IndexerProperty<int>("SidUsuario").HasColumnName("sidUsuario");

                            j.IndexerProperty<string>("SidPerfil").HasMaxLength(1).IsUnicode(false).HasColumnName("sidPerfil");
                        });
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
