using System;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Microsoft.Extensions.Options;
using WeeeTrackerAPI.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using WeeeTrackerAPI.Core.Interfaces;
using WeeeTrackerAPI.Common;
using Microsoft.AspNetCore.Identity;
using WeeeTrackerAPI.Entities;
using System.Collections.Generic;
using Newtonsoft.Json;

using BCrypt.Net;

namespace WeeeTrackerAPI.Services
{
    public class UserService : IUserService
    {
        private readonly AppSettings _appSettings;
        private ILogger _logger;

        private TerceroService _terceroService;
        private CentroService _centroService;
        private ResiduoEspecificoService _residuoEspecificoService;
        private MarcaService _marcaService;
        private ContactosDireccionTercero _usuario;
        private GVRBD3Context _context;

        public UserService(ILogger<UserService> logger, IOptions<AppSettings> appSettings, GVRBD3Context context)
        {
            _appSettings = appSettings.Value;
            _logger = logger;
            _context = context;

            _terceroService = new TerceroService(_context);
            _centroService = new CentroService(_context);
            _residuoEspecificoService = new ResiduoEspecificoService(_context);
            _marcaService = new MarcaService(_context);
        }

        public ContactosDireccionTercero getUsuario(string username, string password)
        {
            try
            {
                ContactosDireccionTercero usuario = _context.ContactosDireccionTerceros
                .Where(u => u.Email == username/* && u.Contrasena == password*/)
                .Include(u => u.SidTerceroNavigation)
                .Include(u => u.DireccionesTerceroContactosDireccionTerceros)
                .FirstOrDefault();

                foreach (var item in usuario.DireccionesTerceroContactosDireccionTerceros)
                {
                    var list = _context.DireccionesTerceros.Where(d => d.PidDireccionTercero == item.SidDireccionTercero).FirstOrDefault();
                }

                // usuario.SidTerceroNavigation = usuario.SidTerceroNavigation;

                if (usuario == null || !BCrypt.Net.BCrypt.Verify(password, usuario.Contrasena))
                    throw new Exception("El email o contraseña son incorrectas");
                /*WtkUsuario usuario = _context.WtkUsuarios
                    .Where(u => u.Usuario == username && u.Password == password)
                    .Include(u => u.SidPerfils
                    )
                    .Select(item => new WtkUsuario
                    {
                        Id = item.Id,
                        Usuario = item.Usuario,
                        Password = item.Password,
                        SidTercero = item.SidTercero,
                        SidTipoTercero = item.SidTipoTercero,
                        Estado = item.Estado,
                        SidPerfils = item.SidPerfils
                    })
                    .FirstOrDefault();*/

                return usuario;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message.ToString());
                return null;
            }
        }

        public ContactosDireccionTercero getUsuarioById(int idUsuario)
        {
            try
            {
                ContactosDireccionTercero usuario = _context.ContactosDireccionTerceros
                                            .Where(u =>
                                                u.PidContactoDireccionTercero == idUsuario
                                            )
                                            .Where(u => u.Estado == 1)
                                            // .Include(u => u.DireccionesTerceroContactosDireccionTerceros)
                                            .Include(u => u.SidTerceroNavigation)
                                            .FirstOrDefault();

                // foreach (var item in usuario.DireccionesTerceroContactosDireccionTerceros)
                // {
                //     var list = _context.DireccionesTerceros.Where(d => d.PidDireccionTercero == item.SidDireccionTercero).FirstOrDefault();
                //     item.SidDireccionTerceroNavigation = list;
                // }

                return usuario;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message.ToString());
                return null;
            }
        }

        public object getPerfiles(ContactosDireccionTercero usuario)
        {
            try
            {
                string[] perfiles = new string[0]; 
                // var perfiles = usuario.SidPerfils
                //     .Select(item => new
                //     {
                //         item.Nombre
                //     })
                //     .ToList();

                return perfiles;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message.ToString());
                return null;
            }
        }

        public object getUsuarioDirecciones(int id)
        {
            var lista = _context.DireccionesTerceroContactosDireccionTerceros
            .ToList();

            return lista;
        }

        public string Authenticate(IConfiguration config, string username, string password)
        {
            try
            {
                //----------------------------------------------------------------------------------------------------------------------------
                //Usuario autenticado y sus perfiles asociados.

                this._usuario = getUsuario(username, password);
                if (this._usuario == null)
                    return null;

                //----------------------------------------------------------------------------------------------------------------------------
                //Verificamos la password hasheada en la Base de Datos.

                //genera la password hasheada.
                //var hasher = new PasswordHasher<ContactosDireccionTercero>().HashPassword(_usuario, _usuario.Contrasena);

                //se la asigno a la password hardcode para simular la verificaci�n de la misma.
                //_usuario.Password = "AQAAAAEAACcQAAAAEO+TBI8TRfmXp3HuIj9QOScByhl6O0ctDihEkV9ecvrOUZPMSfbIhEJQ5iaHHet73A==";

                //Verificamos la password mediante el  hash.
                //PasswordVerificationResult pvr = new PasswordHasher<WtkUsuario>().VerifyHashedPassword(_usuario, _usuario.Password, password);
                //if (pvr == PasswordVerificationResult.Failed)
                //    return null;

                //----------------------------------------------------------------------------------------------------------------------------
                // Generaci�n del Token.
                
                var resp = _context.ResponsabilidadesRecogidaEntregas
                .Where(r => r.SidTercero == _usuario.SidTercero)
                .Where(r => r.Estado == 1)
                .ToList();

                return JWTHelper.GetToken(
                    config,
                    this._usuario,
                    _terceroService.getTercero(this._usuario),
                    _centroService.getCentros(this._usuario),
                    getPerfiles(this._usuario),
                    _residuoEspecificoService.getResiduos(),
                    _marcaService.getMarcas(),
                    resp
                );
                
                //----------------------------------------------------------------------------------------------------------------------------

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public object GetAll(int id)
        {
            var usuario = getUsuarioById(id);

            foreach (var item in usuario.DireccionesTerceroContactosDireccionTerceros)
            {
                var list = _context.DireccionesTerceros.Where(d => d.PidDireccionTercero == item.SidDireccionTercero).FirstOrDefault();
            }

            // var lista = _context.DireccionesTerceroContactosDireccionTerceros
            // .Where(p => p.SidContactoDireccionTercero == 47447)
            //     .ToList();

            // return new{lista};

            // if (usuario != null)
            // {
            //     return getUsuarioDirecciones(usuario.PidContactoDireccionTercero);
            // }

            // usuario.Contrasena = BCrypt.Net.BCrypt.HashPassword("1234");
            // usuario.Email = "daniel@ecolec.com";
            
            // _context.Entry(usuario).Property(x => x.Email).IsModified = true;
            // _context.Entry(usuario).Property(x => x.Contrasena).IsModified = true;
            // _context.ChangeTracker.DetectChanges();
            // _context.SaveChanges();
            
            return new{usuario = usuario};
        }
    }
}