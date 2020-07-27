using DevWebReceitas.Domain.Entities;
using DevWebReceitas.Domain.Filters;
using System;

namespace DevWebReceitas.Domain.Interfaces.Repositories
{
    public interface ICategoriaRepository : IRepository<Categoria, CategoriaFilter>
    {
        Categoria FindById(short id);
        void Remove(short id);
        void Remove(Guid codigo);
        Categoria FindByCode(Guid codigo);
    }
}
