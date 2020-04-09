using DevWebReceitas.Application.Dtos;
using DevWebReceitas.Domain.Filters;
using System;
using System.Collections.Generic;

namespace DevWebReceitas.Application.Interfaces
{
    public interface IReceitaService
    {
        Guid Create(ReceitaInsertDto entity);
        void Remove(Guid id);
        ReceitaDto FindByCode(Guid code);
        IEnumerable<ReceitaDto> List(ReceitaFilter filter);
        void Update(ReceitaDto entity);

        byte[] FindImageByCode(Guid id);
    }
}
