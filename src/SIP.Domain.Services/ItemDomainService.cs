using DevWebReceitas.Domain.Entities;
using DevWebReceitas.Domain.Filters;
using DevWebReceitas.Domain.Interfaces.Repositories;
using DevWebReceitas.Domain.Interfaces.UoW;
using DevWebReceitas.Domain.Services.Interfaces;
using System;
using System.Collections.Generic;

namespace DevWebReceitas.Domain.Services
{
    public class ItemDomainService : IItemDomainService
    {
        private readonly IItemRepository _itemRepository;
        private readonly IUnitOfWork _uow;

        public ItemDomainService(IUnitOfWork uow, IItemRepository itemRepository)
        {
            _itemRepository = itemRepository;
            _uow = uow;
        }

        public void Create(Item entity)
        {
            using (var trans = _uow.Begin(_itemRepository, _itemRepository))
            {
                try
                {
                    _itemRepository.Create(entity);
                    trans.Commit();
                }
                catch
                {
                    trans.Rollback();
                    throw;
                }
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
            using (var trans = _uow.Begin(_itemRepository))
            {
                try
                {
                    _itemRepository.Remove(id);
                    trans.Commit();
                }
                catch
                {
                    trans.Rollback();
                    throw;
                }
            }
        }

        public void Update(Item entity)
        {
            entity.DataCadastro = DateTime.Now;
            using (var trans = _uow.Begin(_itemRepository, _itemRepository))
            {
                try
                {
                    _itemRepository.Update(entity);
                    trans.Commit();
                }
                catch
                {
                    trans.Rollback();
                    throw;
                }
            }
        }

        public IEnumerable<Item> FindByReceitaId(Guid id)
        {
            return _itemRepository.FindByReceitaId(id);
        }

        public void RemoveItemByReceitaId(Guid id)
        {
            using (var trans = _uow.Begin(_itemRepository))
            {
                try
                {
                    _itemRepository.RemoveItemByReceitaId(id);
                    trans.Commit();
                }
                catch
                {
                    trans.Rollback();
                    throw;
                }
            }
        }
    }
}

