using System;
using System.Collections.Generic;
using DevWebReceitas.Application.Dtos;
using DevWebReceitas.Application.Interfaces;
using DevWebReceitas.Application.Mappers.Default;
using DevWebReceitas.Domain.Entities;
using DevWebReceitas.Domain.Filters;
using DevWebReceitas.Domain.Services.Interfaces;

namespace DevWebReceitas.Application.Services
{
    public class IngredienteService : IIngredienteService, IDisposable
    {
        private readonly IIngredienteDomainService _service;

        public IngredienteService(IIngredienteDomainService service)
        {
            _service = service;
        }

        public void Create(IngredienteDto entity)
        {
            _service.Create(TypeConverter.ConvertTo<Ingrediente>(entity));
        }

        public IEnumerable<IngredienteDto> List(IngredienteFilter filter)
        {
            var list = _service.List(filter);
            return TypeConverter.ConvertTo<IEnumerable<IngredienteDto>>(list);
        }

        public void Remove(Guid id)
        {
            _service.Remove(id);
        }

        public IngredienteDto FindById(Guid id)
        {
            var ingrediente = _service.FindById(id);
            return TypeConverter.ConvertTo<IngredienteDto>(ingrediente);
        }

        public void Update(IngredienteDto entity)
        {
            _service.Update(TypeConverter.ConvertTo<Ingrediente>(entity));
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}



