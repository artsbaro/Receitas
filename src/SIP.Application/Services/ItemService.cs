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
    public class ItemService : IItemService, IDisposable
    {
        private readonly IItemDomainService _service;

        public ItemService(IItemDomainService service)
        {
            _service = service;
        }

        public void Create(ItemDto entity)
        {
            _service.Create(TypeConverter.ConvertTo<Item>(entity));
        }

        public IEnumerable<ItemDto> List(ItemFilter filter)
        {
            var list = _service.List(filter);
            return TypeConverter.ConvertTo<IEnumerable<ItemDto>>(list);
        }

        public void Remove(Guid id)
        {
            _service.Remove(id);
        }

        public ItemDto FindById(Guid id)
        {
            var item = _service.FindById(id);
            return TypeConverter.ConvertTo<ItemDto>(item);
        }

        public void Update(ItemDto entity)
        {
            _service.Update(TypeConverter.ConvertTo<Item>(entity));
        }

        public void RemoveItemByReceitaId(Guid id)
        {
            _service.RemoveItemByReceitaId(id);
        }

        public IEnumerable<ItemDto> List(Guid id)
        {
            var list = _service.FindByReceitaId(id);
            return TypeConverter.ConvertTo<IEnumerable<ItemDto>>(list);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}



