using System;
using System.Collections.Generic;

namespace DevWebReceitas.Domain.Interfaces.Repositories
{
    public interface IRepository { }

    public interface IRepository<T, TFiltro> : IRepository
    {
        void Create(T entity);
        void Update(T entity);
        void Remove(Guid id);
        IEnumerable<T> List(TFiltro filter);
        T FindById(Guid id);
    }
}
