using DevWebReceitas.Domain.Entities;
using DevWebReceitas.Domain.Filters;
using DevWebReceitas.Domain.Interfaces.Repositories;
using DevWebReceitas.Domain.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Transactions;

namespace DevWebReceitas.Domain.Services
{
    public class IngredienteDomainService : IIngredienteDomainService
    {
        private readonly IIngredienteRepository _ingredienteRepository;

        public IngredienteDomainService(IIngredienteRepository ingredienteRepository)
        {
            _ingredienteRepository = ingredienteRepository;
        }

        public void Create(Ingrediente entity)
        {
            using (var trans = new TransactionScope())
            {
                _ingredienteRepository.Create(entity);
                trans.Complete();
            }
        }

        public Ingrediente FindById(Guid id)
        {
            return _ingredienteRepository.FindById(id);
        }

        public IEnumerable<Ingrediente> List(IngredienteFilter filter)
        {
            return _ingredienteRepository.List(filter);
        }

        public void Remove(Guid id)
        {
            using (var trans = new TransactionScope())
            {
                _ingredienteRepository.Remove(id);
                trans.Complete();
            }
        }

        public void Update(Ingrediente entity)
        {
            entity.DataUltimaAlteracao = DateTime.Now;
            using (var trans = new TransactionScope())
            {
                _ingredienteRepository.Update(entity);
                trans.Complete();
            }
        }
    }
}
