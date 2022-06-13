using System;
using WeeeTrackerAPI.Models;

namespace WeeeTrackerAPI.Core.Interfaces
{
    public interface ICentro
    {
        object getCentros(ContactosDireccionTercero usuario);
    }
}
