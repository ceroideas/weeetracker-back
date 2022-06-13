using System;
using WeeeTrackerAPI.Models;

namespace WeeeTrackerAPI.Core.Interfaces
{
    public interface IResiduo
    {
        object getResiduos();
        Residuo getResiduoById(int idResiduo);
    }
}
