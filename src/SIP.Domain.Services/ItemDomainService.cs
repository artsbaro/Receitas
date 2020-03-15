using DevWebReceitas.Domain.Entities;
using DevWebReceitas.Domain.Filters;
using DevWebReceitas.Domain.Interfaces.Repositories;
using DevWebReceitas.Domain.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Transactions;

namespace DevWebReceitas.Domain.Services
{
    public class ItemDomainService : IItemDomainService
    {
        private readonly IItemRepository _itemRepository;

        public ItemDomainService(IItemRepository itemRepository)
        {
            _itemRepository = itemRepository;
        }

        public void Create(Item entity)
        {
            using (var trans = new TransactionScope())
            {
                _itemRepository.Create(entity);
                trans.Complete();
            }
        }

        public Item FindById(Guid id)
        {
            var item = _itemRepository.FindById(id);
            return item;
        }

        public IEnumerable<Item> List(ItemFilter filter)
        {
            return _itemRepository.List(filter);
        }

        public void Remove(Guid id)
        {
            using (var trans = new TransactionScope())
            {
                _itemRepository.Remove(id);
                trans.Complete();
            }
        }

        public void Update(Item entity)
        {
            using (var trans = new TransactionScope())
            {
                entity.DataCadastro = DateTime.Now;
                _itemRepository.Update(entity);
                trans.Complete();
            }
        }

        public IEnumerable<Item> FindByReceitaId(Guid id)
        {
            return _itemRepository.FindByReceitaId(id);
        }

        public void RemoveItemByReceitaId(Guid id)
        {
            using (var trans = new TransactionScope())
            {
                _itemRepository.RemoveItemByReceitaId(id);
                trans.Complete();
            }
        }
    }
}

