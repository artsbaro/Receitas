using System;
using System.Collections.Generic;
using DevWebReceitas.Application.Dtos;
using DevWebReceitas.Application.Interfaces;
using DevWebReceitas.Application.Mappers.Receitas;
using DevWebReceitas.Domain.Filters;
using DevWebReceitas.Domain.Services.Interfaces;

namespace DevWebReceitas.Application.Services
{
    public class ReceitaService : IReceitaService, IDisposable
    {
        private readonly IReceitaDomainService _service;
        private readonly IReceitaMapper _servidorMapper;
        private readonly IReceitaDtoMapper _servidorDtoMapper;


        public ReceitaService(IReceitaDomainService service,
                                IReceitaMapper servidorMapper,
                                IReceitaDtoMapper servidorDtoMapper)
        {
            _service = service;
            _servidorMapper = servidorMapper;
            _servidorDtoMapper = servidorDtoMapper;
        }

        public void Create(ReceitaDto entity)
        {
            _service.Create(_servidorMapper.Map(entity));
        }

        public IEnumerable<ReceitaDto> List(ReceitaFilter filter)
        {
            var list = _service.List(filter);
            return _servidorDtoMapper.Map(list);
        }

        public void Remove(Guid id)
        {
            _service.Remove(id);
        }

        public ReceitaDto FindById(Guid id)
        {
            var servidor = _service.FindById(id);
            return _servidorDtoMapper.Map(servidor);
        }

        public void Update(ReceitaDto entity)
        {
            _service.Update(_servidorMapper.Map(entity));
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}



