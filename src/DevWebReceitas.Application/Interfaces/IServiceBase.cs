using System;

namespace DevWebReceitas.Application.Interfaces
{
    public interface IServiceBase<T>
    {
        T FindByCode(Guid codigo);
    }
}
