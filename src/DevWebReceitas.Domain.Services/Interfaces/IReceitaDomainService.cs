using DevWebReceitas.Domain.Entities;
using DevWebReceitas.Domain.Filters;
using System;
using System.Collections.Generic;

namespace DevWebReceitas.Domain.Services.Interfaces
{
    public interface IReceitaDomainService : IDomainService<Receita, Guid>
    {
        void Create(Receita entity);
        void Update(Receita entity);
        void Remove(Guid codigo);
        IEnumerable<Receita> List(ReceitaFilter filter);
        byte[] FindImageByCode(Guid codigo);
        void Like(Guid codigo);
        void Dislike(Guid codigo);
        Receita FindByCode(Guid codigo);
    }
}
