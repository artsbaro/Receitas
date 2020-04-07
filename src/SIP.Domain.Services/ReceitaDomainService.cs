using DevWebReceitas.Domain.Entities;
using DevWebReceitas.Domain.Filters;
using DevWebReceitas.Domain.Interfaces.Repositories;
using DevWebReceitas.Domain.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Transactions;

namespace DevWebReceitas.Domain.Services
{
    public class ReceitaDomainService : IReceitaDomainService
    {
        private readonly IReceitaRepository _receitaRepository;

        public ReceitaDomainService(IReceitaRepository receitaRepository)
        {
            _receitaRepository = receitaRepository;
        }

        public void Create(Receita entity)
        {
            using (var trans = new TransactionScope())
            {
                _receitaRepository.Create(entity);
                trans.Complete();
            }
        }

        public Receita FindById(int id)
        {
            var receita = _receitaRepository.FindById(id);
            return receita;
        }

        public Receita FindByCode(Guid code)
        {
            var receita = _receitaRepository.FindByCode(code);
            return receita;
        }

        public IEnumerable<Receita> List(ReceitaFilter filter)
        {
            return _receitaRepository.List(filter);
        }

        public void Remove(int id)
        {
            _receitaRepository.Remove(id);
        }

        public void Remove(Guid code)
        {
            _receitaRepository.Remove(code);
        }

        public void Update(Receita entity)
        {
            entity.DataUltimaAlteracao = DateTime.Now;
            using (var trans = new TransactionScope())
            {
                _receitaRepository.Update(entity);
                trans.Complete();
            }
        }
    }
}

