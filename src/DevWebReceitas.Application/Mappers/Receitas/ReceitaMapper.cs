using DevWebReceitas.Application.Dtos.Receita;
using DevWebReceitas.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DevWebReceitas.Application.Mappers.Receitas
{
    public class ReceitaMapper : IReceitaMapper
    {
        public Receita Map(ReceitaInsertDto source)
        {
            //return TypeConverter.ConvertTo<Receita>(source);

            return new Receita
            {
                Titulo = source.Titulo,
                Descricao = source.Descricao,
                ModoPreparo = source.ModoPreparo,
                Codigo = Guid.NewGuid(),
                Ingredientes = source.Ingredientes,
                Categoria = new Categoria { Codigo = source.CodigoCategoria }
            };
        }

        public IEnumerable<Receita> Map(IEnumerable<ReceitaInsertDto> source)
        {
            return source.Select(x => Map(x));
        }
    }
}
