using DevWebReceitas.Domain.Entities;
using DevWebReceitas.Domain.Filters;
using DevWebReceitas.Domain.Interfaces.Repositories;
using DevWebReceitas.Domain.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Transactions;

namespace DevWebReceitas.Domain.Services
{
    public class CategoriaDomainService : ICategoriaDomainService
    {
        private readonly ICategoriaRepository _CategoriaRepository;

        public CategoriaDomainService(ICategoriaRepository CategoriaRepository)
        {
            _CategoriaRepository = CategoriaRepository;
        }

        public void Create(Categoria entity)
        {
            using (var trans = new TransactionScope())
            {
                _CategoriaRepository.Create(entity);
                trans.Complete();
            }
        }

        public Categoria FindByCode(Guid code)
        {
            return _CategoriaRepository.FindByCode(code);
        }

        public Categoria FindById(int id)
        {
            return _CategoriaRepository.FindById(id);
        }

        public IEnumerable<Categoria> List(CategoriaFilter filter)
        {
            return _CategoriaRepository.List(filter);
        }

        public void Remove(Guid id)
        {
            using (var trans = new TransactionScope())
            {
                _CategoriaRepository.Remove(id);
                trans.Complete();
            }
        }

        public void Update(Categoria entity)
        {
            entity.DataUltimaAlteracao = DateTime.Now;
            using (var trans = new TransactionScope())
            {
                _CategoriaRepository.Update(entity);
                trans.Complete();
            }
        }
    }
}
