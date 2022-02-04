using DevWebReceitas.Domain.Entities;
using DevWebReceitas.Domain.Filters;
using DevWebReceitas.Domain.Interfaces.Repositories;
using DevWebReceitas.Domain.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
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

        public async Task<Categoria> FindByCode(Guid codigo)
        {
            return await _CategoriaRepository.FindByCode(codigo);
        }

        public Categoria FindById(int id)
        {
            return _CategoriaRepository.FindById(id);
        }

        public IEnumerable<Categoria> List(CategoriaFilter filter)
        {
            return _CategoriaRepository.List(filter);
        }

        public void Remove(Guid codigo)
        {
            using (var trans = new TransactionScope())
            {
                var categoria = FindByCode(codigo);
                _CategoriaRepository.Remove(categoria.Id);
                trans.Complete();
            }
        }

        public void Update(Categoria entity)
        {
            using (var trans = new TransactionScope())
            {
                var categoria = FindByCode(entity.Codigo);

                entity.Id = (short)categoria.Id;
                entity.DataUltimaAlteracao = DateTime.Now;
                _CategoriaRepository.Update(entity);
                trans.Complete();
            }
        }
    }
}
