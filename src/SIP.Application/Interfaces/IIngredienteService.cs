using DevWebReceitas.Application.Dtos;
using DevWebReceitas.Domain.Filters;
using System;
using System.Collections.Generic;

namespace DevWebReceitas.Application.Interfaces
{
    public interface IIngredienteService
    {
        void Create(IngredienteDto entity);
        void Remove(Guid id);
        IngredienteDto FindById(Guid id);
        IEnumerable<IngredienteDto> List(IngredienteFilter filter);
        void Update(IngredienteDto entity);
    }
}
