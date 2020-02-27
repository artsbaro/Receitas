using DevWebReceitas.Domain.Entities;
using DevWebReceitas.Domain.Filters;
using System;
using System.Collections.Generic;

namespace DevWebReceitas.Domain.Services.Interfaces
{
    public interface IIngredienteDomainService
    {
        void Create(Ingrediente entity);
        void Update(Ingrediente entity);
        void Remove(Guid id);
        IEnumerable<Ingrediente> List(IngredienteFilter filter);
        Ingrediente FindById(Guid id);
    }
}
