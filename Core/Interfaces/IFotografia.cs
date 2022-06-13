using System;
using System.Collections.Generic;
using WeeeTrackerAPI.Entities;
using WeeeTrackerAPI.Models;

namespace WeeeTrackerAPI.Core.Interfaces
{
    public interface IFotografia
    {
        WtkCambioEstadoFotografium GuardarFotografia(WtkCambioEstadoFotografium fotografia);
        WtkCambioEstadoFotografium SetDatosFotografia(string fichero, int sidCambioEstado);
        bool AltaFotografia(List<Archivo> listaImagenes, int idCambioEstado, string rutaLocal, string rutaServidor);
    }
}
