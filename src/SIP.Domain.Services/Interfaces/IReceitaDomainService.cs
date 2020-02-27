using DevWebReceitas.Domain.Entities;
using DevWebReceitas.Domain.Filters;
using System;
using System.Collections.Generic;

namespace DevWebReceitas.Domain.Services.Interfaces
{
    public interface IReceitaDomainService
    {
        void Create(Receita entity);
        void Update(Receita entity);
        void Remove(Guid id);
        IEnumerable<Receita> List(ReceitaFilter filter);
        Receita FindById(Guid id);

        //Task CreateAsync(Receita entity);
        //Task UpdateAsync(Receita entity);
        //Task RemoveAsync(Guid id);
        //Task<IEnumerable<Receita>> ListAsync(ReceitaFilter filter);
        //Task<Receita> FindByIdAsync(Guid id);
    }
}
