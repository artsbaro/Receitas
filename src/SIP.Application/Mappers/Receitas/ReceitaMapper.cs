using DevWebReceitas.Application.Dtos;
using DevWebReceitas.Application.Mappers.Default;
using DevWebReceitas.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace DevWebReceitas.Application.Mappers.Receitas
{
    public class ReceitaMapper : IReceitaMapper
    {
        public Receita Map(ReceitaDto source)
        {
            return TypeConverter.ConvertTo<Receita>(source);

            //return new Servidor
            //{
            //    DataNascimento = source.DataNascimento,
            //    NomeMae = source.NomeMae,
            //    Nome = source.Nome,
            //    NomePai = source.NomePai,
            //    NomeSocial = source.NomeSocial,
            //    Sexo = new Sexo { Id = source.Sexo.Id, Descricao = source.Sexo.Descricao },
            //    EstadoCivil = new EstadoCivil { Id = source.EstadoCivil.Id },
            //    FatorRH = new FatorRH { Id = source.FatorRH.Id },
            //    RacaCor = new RacaCor { Id = source.RacaCor.Id },
            //    TipoSanguineo = new TipoSanguineo { Id = source.TipoSanguineo.Id },
            //    MunicipioNascimento = new MunicipioNascimento { Id = source.MunicipioNascimento.Id},
            //    Enderecos = source.Enderecos.Select(e => new Endereco
            //    {
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

        public IEnumerable<Receita> Map(IEnumerable<ReceitaDto> source)
        {
            return source.Select(x => Map(x));
        }
    }
}
