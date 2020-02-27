using System.Collections.Generic;
using System.Linq;
using DevWebReceitas.Application.Dtos;
using DevWebReceitas.Application.Mappers.Default;
using DevWebReceitas.Domain.Entities;

namespace DevWebReceitas.Application.Mappers.Receitas
{
    public class ReceitaDtoMapper : IReceitaDtoMapper
    {
        public ReceitaDto Map(Receita source)
        {
            return TypeConverter.ConvertTo<ReceitaDto>(source);

            //return new ServidorDto
            //{
            //    Id = source.Id,
            //    DataNascimento = source.DataNascimento,
            //    NomeMae = source.NomeMae,
            //    Nome = source.Nome,
            //    NomePai = source.NomePai,
            //    NomeSocial = source.NomeSocial,
            //    Sexo = new SexoDto { Id = source.Sexo.Id, Descricao = source.Sexo.Descricao },
            //    EstadoCivil = new EstadoCivilDto { Id = source.EstadoCivil.Id, Descricao = source.EstadoCivil.Descricao },
            //    FatorRH = new FatorRHDto { Id = source.FatorRH.Id, Descricao = source.FatorRH.Descricao },
            //    RacaCor = new RacaCorDto { Id = source.RacaCor.Id, Descricao = source.RacaCor.Descricao },
            //    TipoSanguineo = new TipoSanguineoDto { Id = source.TipoSanguineo.Id, Descricao = source.TipoSanguineo.Descricao },
            //    Enderecos = source.Enderecos == null ? Enumerable.Empty<EnderecoDto>() : source.Enderecos.Select(e => new EnderecoDto
            //    {
            //        Id = e.Id,
            //        Bairro = e.Bairro,
            //        Cep = e.Cep,
            //        Cidade = e.Cidade,
            //        Logradouro = e.Logradouro,
            //        Complemento = e.Complemento,
            //        Numero = e.Numero,
            //        ServidorId = e.ServidorId,
            //        TipoLogradouro = e.TipoLogradouro,
            //        Uf = e.Uf
            //    })
            //};
        }

        public IEnumerable<ReceitaDto> Map(IEnumerable<Receita> source)
        {
            return source.Select(x => Map(x));
        }
    }
}
