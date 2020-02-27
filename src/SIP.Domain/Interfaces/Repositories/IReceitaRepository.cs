using DevWebReceitas.Domain.Entities;
using DevWebReceitas.Domain.Filters;

namespace DevWebReceitas.Domain.Interfaces.Repositories
{
    public interface IReceitaRepository : IRepository<Receita, ReceitaFilter>
    {

    }
}

