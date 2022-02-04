using DevWebReceitas.Domain.Entities;
using DevWebReceitas.Domain.Filters;
using System;
using System.Threading.Tasks;

namespace DevWebReceitas.Domain.Interfaces.Repositories
{
    public interface ICategoriaRepository : IRepository<Categoria, CategoriaFilter>
    {
        Task<Categoria> FindById(short id);
        void Remove(short id);
        void Remove(Guid codigo);
        Task<Categoria> FindByCode(Guid codigo);
    }
}
