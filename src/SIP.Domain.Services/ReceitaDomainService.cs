using DevWebReceitas.Domain.Entities;
using DevWebReceitas.Domain.Filters;
using DevWebReceitas.Domain.Interfaces.Repositories;
using DevWebReceitas.Domain.Interfaces.UoW;
using DevWebReceitas.Domain.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DevWebReceitas.Domain.Services
{
    public class ReceitaDomainService : IReceitaDomainService
    {
        private readonly IReceitaRepository _receitaRepository;
        private readonly IItemRepository _itemRepository;
        private readonly IUnitOfWork _uow;

        public ReceitaDomainService(IReceitaRepository servidorRepository, IUnitOfWork uow, IItemRepository itemRepository)
        {
            _receitaRepository = servidorRepository;
            _uow = uow;
            _itemRepository = itemRepository;
        }

        public void Create(Receita entity)
        {
            using (var trans = _uow.Begin(_receitaRepository, _itemRepository))
            {
                try
                {
                    _receitaRepository.Create(entity);
                    foreach (var item in entity.Itens ?? Enumerable.Empty<Item>())
                    {
                        _itemRepository.Create(item);
                    }
                    trans.Commit();
                }
                catch
                {
                    trans.Rollback();
                    throw;
                }
            }
        }

        public Receita FindById(Guid id)
        {
            var servidor = _receitaRepository.FindById(id);
            return servidor;
        }

        public IEnumerable<Receita> List(ReceitaFilter filter)
        {
            return _receitaRepository.List(filter);
        }

        public void Remove(Guid id)
        {
            using (var trans = _uow.Begin(_receitaRepository, _itemRepository))
            {
                try
                {
                    _receitaRepository.Remove(id);
                    trans.Commit();
                }
                catch
                {
                    trans.Rollback();
                    throw;
                }
            }
        }

        public void Update(Receita entity)
        {
            entity.DataCadastro = DateTime.Now;
            using (var trans = _uow.Begin(_receitaRepository, _itemRepository))
            {
                try
                {
                    _receitaRepository.Update(entity);
                    foreach (var item in entity.Itens ?? Enumerable.Empty<Item>())
                    {
                        _itemRepository.Create(item);
                    }
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

