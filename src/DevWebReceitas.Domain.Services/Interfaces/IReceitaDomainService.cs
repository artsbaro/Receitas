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
        Receita FindByCode(Guid code);
        byte[] FindImageByCode(Guid code);
        void Like(Guid codigo);
        void Dislike(Guid codigo);
    }
}
