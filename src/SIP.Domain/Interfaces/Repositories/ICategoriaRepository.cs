using DevWebReceitas.Domain.Entities;
using DevWebReceitas.Domain.Filters;

namespace DevWebReceitas.Domain.Interfaces.Repositories
{
    public interface ICategoriaRepository : IRepository<Categoria, CategoriaFilter>
    {
        //void RemoveEnderecosByServidorId(Guid id);
        //IEnumerable<Ingrediente> FindByServidorId(Guid id);
    }
}
