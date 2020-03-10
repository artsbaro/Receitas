using DevWebReceitas.Application.Dtos.Ingrediente;
using DevWebReceitas.Domain.Filters;
using System;
using System.Collections.Generic;

namespace DevWebReceitas.Application.Interfaces
{
    public interface IIngredienteService
    {
        Guid Create(IngredienteInsertDto entity);
        void Remove(Guid id);
        IngredienteDto FindById(Guid id);
        IEnumerable<IngredienteDto> List(IngredienteFilter filter);
        void Update(IngredienteDto entity);
    }
}
