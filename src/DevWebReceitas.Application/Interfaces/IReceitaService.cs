using DevWebReceitas.Application.Dtos.Receita;
using DevWebReceitas.Domain.Filters;
using System;
using System.Collections.Generic;

namespace DevWebReceitas.Application.Interfaces
{
    public interface IReceitaService
    {
        Guid Create(ReceitaInsertDto dto);
        void Remove(Guid codigo);
        ReceitaDto FindByCode(Guid codigo);
        ReceitaEditDto FindByCodeEditDto(Guid codigo);
        IEnumerable<ReceitaDto> List(ReceitaFilter filter);
        void Update(ReceitaEditDto dto);
        void Update(ReceitaDto dto);

        byte[] FindImageByCode(Guid codigo);

        void Like(Guid codigo);
        void Dislike(Guid codigo);
    }
}
