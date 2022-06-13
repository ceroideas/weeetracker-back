using Microsoft.Extensions.Configuration;
using WeeeTrackerAPI.Models;

namespace WeeeTrackerAPI.Core.Interfaces
{
    public interface IUserService
    {
        ContactosDireccionTercero getUsuario(string username, string password);
        ContactosDireccionTercero getUsuarioById(int idUsuario);
        object getUsuarioDirecciones(int idUsuario);
        object getPerfiles(ContactosDireccionTercero usuario);
        string Authenticate(IConfiguration config, string username, string password);
        object GetAll(int id);
    }
}
