using System;

namespace DevWebReceitas.Application.Interfaces
{
    public interface IServiceBase<out T>
    {
        T FindByCode(Guid codigo);
    }
}
