using System.Collections.Generic;
using System.Linq;
using DevWebReceitas.Application.Dtos.Receita;
using DevWebReceitas.Application.Mappers.Default;
using DevWebReceitas.Domain.Entities;

namespace DevWebReceitas.Application.Mappers.Receitas
{
    public class ReceitaDtoMapper : IReceitaDtoMapper
    {
        public ReceitaDto Map(Receita source)
        {
            return TypeConverter.ConvertTo<ReceitaDto>(source);
        }

        public IEnumerable<ReceitaDto> Map(IEnumerable<Receita> source)
        {
            return source.Select(x => Map(x));
        }
    }
}
