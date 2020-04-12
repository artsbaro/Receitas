using DevWebReceitas.Application.Dtos.Categoria;
using DevWebReceitas.Domain.Filters;
using System;
using System.Collections.Generic;

namespace DevWebReceitas.Application.Interfaces
{
    public interface ICategoriaService
    {
        Guid Create(CategoriaInsertDto entity);
        void Remove(Guid codigo);
        CategoriaDto FindByCode(Guid codigo);
        IEnumerable<CategoriaDto> List(CategoriaFilter filter);
        void Update(CategoriaDto entity);
    }
}
