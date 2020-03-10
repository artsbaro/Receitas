using DevWebReceitas.Application.Dtos;
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
                Itens = source.Itens.Select(x => new Item
                {
                    Id = Guid.NewGuid(),
                    Quantidade = x.Quantidade,
                    Obs = x.Obs,
                    Ingrediente = new Ingrediente { Id = x.IngredienteId }
                })
            };
        }

        public IEnumerable<Receita> Map(IEnumerable<ReceitaInsertDto> source)
        {
            return source.Select(x => Map(x));
        }
    }
}
