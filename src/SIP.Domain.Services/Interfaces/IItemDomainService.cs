using DevWebReceitas.Domain.Entities;
using DevWebReceitas.Domain.Filters;
using System;
using System.Collections.Generic;

namespace DevWebReceitas.Domain.Services.Interfaces
{
    public interface IItemDomainService
    {
        void Create(Item entity);
        void Update(Item entity);
        void Remove(Guid id);
        IEnumerable<Item> List(ItemFilter filter);
        Item FindById(Guid id);

        IEnumerable<Item> FindByReceitaId(Guid id);

        void RemoveItemByReceitaId(Guid id);

        //Task CreateAsync(Receita entity);
        //Task UpdateAsync(Receita entity);
        //Task RemoveAsync(Guid id);
        //Task<IEnumerable<Receita>> ListAsync(ReceitaFilter filter);
        //Task<Receita> FindByIdAsync(Guid id);
    }
}
