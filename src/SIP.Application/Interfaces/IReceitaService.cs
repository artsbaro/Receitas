using DevWebReceitas.Application.Dtos;
using DevWebReceitas.Domain.Filters;
using System;
using System.Collections.Generic;

namespace DevWebReceitas.Application.Interfaces
{
    public interface IReceitaService
    {
        void Create(ReceitaDto entity);
        void Remove(Guid id);
        ReceitaDto FindById(Guid id);
        IEnumerable<ReceitaDto> List(ReceitaFilter filter);
        void Update(ReceitaDto entity);
    }
}
