using System;
using System.Collections.Generic;
using DevWebReceitas.Application.Dtos;
using DevWebReceitas.Application.Extensions;
using DevWebReceitas.Application.Interfaces;
using DevWebReceitas.Application.Mappers.Default;
using DevWebReceitas.Application.Mappers.Receitas;
using DevWebReceitas.Domain.Entities;
using DevWebReceitas.Domain.Filters;
using DevWebReceitas.Domain.Services.Interfaces;

namespace DevWebReceitas.Application.Services
{
    public class ReceitaService : IReceitaService, IDisposable
    {
        private readonly IReceitaDomainService _service;
        private readonly IReceitaDtoMapper _receitaDtoMapper;


        public ReceitaService(IReceitaDomainService service,
                                IReceitaDtoMapper receitaDtoMapper)
        {
            _service = service;
            _receitaDtoMapper = receitaDtoMapper;
        }

        public Guid Create(ReceitaInsertDto dto)
        {
            var codigo = Guid.NewGuid();
            var objPersistencia = new Receita
            {
                Codigo = codigo,
                Titulo = dto.Titulo,
                Descricao = dto.Descricao,
                ModoPreparo = dto.ModoPreparo,
                Imagem = dto.Imagem.ConvertToBytes(),
                NomeArquivo = dto.Imagem.FileName,
                Ingredientes = dto.Ingredientes,
                Categoria = new Categoria { Codigo = dto.CodigoCategoria }
            };

            _service.Create(objPersistencia);
            return objPersistencia.Codigo;
        }

        public IEnumerable<ReceitaDto> List(ReceitaFilter filter)
        {
            var list = _service.List(filter);
            return _receitaDtoMapper.Map(list);
        }

        public void Remove(Guid codigo)
        {
            _service.Remove(codigo);
        }

        public ReceitaDto FindByCode(Guid codigo)
        {
            var receita = _service.FindByCode(codigo);
            return _receitaDtoMapper.Map(receita);
        }

        public byte[] FindImageByCode(Guid codigo)
        {
            return _service.FindImageByCode(codigo);
        }

        public void Update(ReceitaDto dto)
        {
            var objPersistencia = new Receita
            {
                Codigo = dto.Codigo,
                Titulo = dto.Titulo,
                Descricao = dto.Descricao,
                ModoPreparo = dto.ModoPreparo,
                Imagem = dto.Imagem.ConvertToBytes(),
                NomeArquivo = dto.Imagem.FileName,
                Ingredientes = dto.Ingredientes,
                Categoria = new Categoria { Codigo = dto.Categoria.Codigo }
            };

            _service.Update(objPersistencia);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}



