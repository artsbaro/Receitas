using DevWebReceitas.Application.Dtos.Categoria;
using DevWebReceitas.Domain.Filters;
using System;
using System.Collections.Generic;

namespace DevWebReceitas.Application.Interfaces
{
    public interface ICategoriaService : IServiceBase<CategoriaDto>
    {
        Guid Create(CategoriaInsertDto dto);
        void Remove(Guid codigo);
        IEnumerable<CategoriaDto> List(CategoriaFilter filter);
        void Update(CategoriaDto dto);
    }
}
