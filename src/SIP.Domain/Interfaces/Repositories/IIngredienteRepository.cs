using DevWebReceitas.Domain.Entities;
using DevWebReceitas.Domain.Filters;

namespace DevWebReceitas.Domain.Interfaces.Repositories
{
    public interface IIngredienteRepository : IRepository<Ingrediente, IngredienteFilter>
    {
        //void RemoveEnderecosByServidorId(Guid id);
        //IEnumerable<Ingrediente> FindByServidorId(Guid id);
    }
}
