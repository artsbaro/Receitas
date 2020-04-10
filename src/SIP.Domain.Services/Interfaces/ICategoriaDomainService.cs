using DevWebReceitas.Domain.Entities;
using DevWebReceitas.Domain.Filters;
using System;
using System.Collections.Generic;

namespace DevWebReceitas.Domain.Services.Interfaces
{
    public interface ICategoriaDomainService
    {
        void Create(Categoria entity);
        void Update(Categoria entity);
        void Remove(Guid id);
        IEnumerable<Categoria> List(CategoriaFilter filter);
        Categoria FindByCode(Guid code);
    }
}
