﻿using DevWebReceitas.Application.Dtos.Receita;
using DevWebReceitas.Domain.Entities;

namespace DevWebReceitas.Application.Mappers.Receitas
{
    public interface IReceitaDtoMapper : IMapper<Receita, ReceitaDto>
    {
    }
}
