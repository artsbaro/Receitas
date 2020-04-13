using DevWebReceitas.Domain.Entities;
using DevWebReceitas.Domain.Filters;
using System;

namespace DevWebReceitas.Domain.Interfaces.Repositories
{
    public interface IReceitaRepository : IRepository<Receita, ReceitaFilter>
    {
        Receita FindByCode(Guid codigo);
        void Remove(Guid codigo);
    }
}

