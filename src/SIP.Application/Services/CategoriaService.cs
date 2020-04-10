using System;
using System.Collections.Generic;
using DevWebReceitas.Application.Dtos.Categoria;
using DevWebReceitas.Application.Interfaces;
using DevWebReceitas.Application.Mappers.Default;
using DevWebReceitas.Domain.Entities;
using DevWebReceitas.Domain.Filters;
using DevWebReceitas.Domain.Services.Interfaces;

namespace DevWebReceitas.Application.Services
{
    public class CategoriaService : ICategoriaService, IDisposable
    {
        private readonly ICategoriaDomainService _service;

        public CategoriaService(ICategoriaDomainService service)
        {
            _service = service;
        }

        public Guid Create(CategoriaInsertDto entity)
        {
            var objPersistencia = TypeConverter.ConvertTo<Categoria>(entity);
            objPersistencia.Codigo = Guid.NewGuid();
            _service.Create(objPersistencia);
            return objPersistencia.Codigo;
        }

        public IEnumerable<CategoriaDto> List(CategoriaFilter filter)
        {
            var list = _service.List(filter);
            return TypeConverter.ConvertTo<IEnumerable<CategoriaDto>>(list);
        }

        public void Remove(Guid id)
        {
            _service.Remove(id);
        }

        public CategoriaDto FindByCode(Guid code)
        {
            var Categoria = _service.FindByCode(code);
            return TypeConverter.ConvertTo<CategoriaDto>(Categoria);
        }

        public void Update(CategoriaDto entity)
        {
            _service.Update(TypeConverter.ConvertTo<Categoria>(entity));
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}



