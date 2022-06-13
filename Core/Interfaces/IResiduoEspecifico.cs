using System;
using WeeeTrackerAPI.Models;

namespace WeeeTrackerAPI.Core.Interfaces
{
    public interface IResiduoEspecifico
    {
        object getResiduos();
        ResiduosEspecifico getResiduoEspecificoById(int idResiduoEspecifico);
    }
}
