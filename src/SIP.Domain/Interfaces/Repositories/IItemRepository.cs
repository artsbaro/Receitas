using DevWebReceitas.Domain.Entities;
using DevWebReceitas.Domain.Filters;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DevWebReceitas.Domain.Interfaces.Repositories
{
    public interface IItemRepository : IRepository<Item, ItemFilter>
    {
        void RemoveItemByReceitaId(Guid id);
        IEnumerable<Item> FindByReceitaId(Guid id);

        Task RemoveItemByReceitaIdAsync(Guid id);

        Task<IEnumerable<Item>> FindByReceitaIdAsync(Guid id);
    }
}
