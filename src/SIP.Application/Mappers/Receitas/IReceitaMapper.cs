using DevWebReceitas.Application.Dtos;
using DevWebReceitas.Domain.Entities;

namespace DevWebReceitas.Application.Mappers.Receitas
{
    public interface IReceitaMapper : IMapper<ReceitaInsertDto, Receita>
    {
    }
}
