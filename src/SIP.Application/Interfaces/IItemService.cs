using DevWebReceitas.Application.Dtos;
using DevWebReceitas.Domain.Filters;
using System;
using System.Collections.Generic;

namespace DevWebReceitas.Application.Interfaces
{
    public interface IItemService
    {
        void Create(ItemDto entity);
        void Remove(Guid id);
        ItemDto FindById(Guid id);
        IEnumerable<ItemDto> List(ItemFilter filter);
        void Update(ItemDto entity);
        void RemoveItemByReceitaId(Guid id);
    }
}
