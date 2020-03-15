using DevWebReceitas.Domain.Entities;
using DevWebReceitas.Domain.Filters;
using DevWebReceitas.Domain.Interfaces.Repositories;
using DevWebReceitas.Domain.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Transactions;

namespace DevWebReceitas.Domain.Services
{
    public class ReceitaDomainService : IReceitaDomainService
    {
        private readonly IReceitaRepository _receitaRepository;
        private readonly IItemRepository _itemRepository;

        public ReceitaDomainService(IReceitaRepository receitaRepository, IItemRepository itemRepository)
        {
            _receitaRepository = receitaRepository;
            _itemRepository = itemRepository;
        }

        public void Create(Receita entity)
        {
            using (var trans = new TransactionScope())
            {
                _receitaRepository.Create(entity);
                foreach (var item in entity.Itens ?? Enumerable.Empty<Item>())
                {
                    _itemRepository.Create(item);
                }
                trans.Complete();
            }
        }

        public Receita FindById(Guid id)
        {
            var receita = _receitaRepository.FindById(id);
            receita.Itens = _itemRepository.FindByReceitaId(receita.Id);
            return receita;
        }

        public IEnumerable<Receita> List(ReceitaFilter filter)
        {
            return _receitaRepository.List(filter);
        }

        public void Remove(Guid id)
        {
            _receitaRepository.Remove(id);
        }

        public void Update(Receita entity)
        {
            entity.DataUltimaAlteracao = DateTime.Now;
            using (var trans = new TransactionScope())
            {
                _receitaRepository.Update(entity);
                foreach (var item in entity.Itens ?? Enumerable.Empty<Item>())
                {
                    _itemRepository.Create(item);
                }
                trans.Complete();
            }
        }
    }
}

