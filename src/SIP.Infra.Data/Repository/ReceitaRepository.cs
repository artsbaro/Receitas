using System.Collections.Generic;
using System.Data;
using Dapper;
using System;
using System.Linq;
using Microsoft.Extensions.Configuration;
using DevWebReceitas.Domain.Entities;
using DevWebReceitas.Domain.Filters;
using DevWebReceitas.Domain.Interfaces.Repositories;
using System.Threading.Tasks;

namespace DevWebReceitas.Infra.Data.Repository
{
    public class ReceitaRepository : RepositoryBase, IReceitaRepository
    {
        public ReceitaRepository(IConfiguration configuration) : base(configuration)
        {
        }

        public async Task CreateAsync(Receita entity)
        {
            await Connection.ExecuteAsync(
                "SProc_Receita_Insert",
                commandType: CommandType.StoredProcedure,
                param: new
                {
                    entity.Id,                    
                    entity.Titulo,
                    entity.Descricao,
                    entity.ModoPreparo,
                    entity.Ativo,
                    entity.DataCadastro
                },
                transaction: transaction
            );
        }

        public void Create(Receita entity)
        {
            CreateAsync(entity).ConfigureAwait(false);
        }

        public async Task RemoveAsync(Guid id)
        {
            await Connection.ExecuteAsync(
                "SProc_Receita_Delete",
                commandType: CommandType.StoredProcedure,
                param: new
                {
                    Id = id
                },
                transaction: transaction
            );
        }

        public void Remove(Guid id)
        {
            RemoveAsync(id).ConfigureAwait(false);  
        }

        public Task<Receita> FindByIdAsync(Guid id)
        {
            var obj = Connection.QuerySingleOrDefault("SProc_Receita_GetById",
                transaction: transaction,
                commandType: CommandType.StoredProcedure,
                param: new { Id = id });

            if (obj == null)
                throw new ArgumentException("Receita não encontrado");

            return MapFromDB(obj);
        }

        public Receita FindById(Guid id)
        {
            return FindByIdAsync(id).Result;
        }

        public Task<IEnumerable<Receita>> ListAsync(ReceitaFilter filter)
        {
            var result = Connection.Query(
               "SProc_Receita_GetAll",
               commandType: CommandType.StoredProcedure,
               transaction: transaction);

            return Task.Run(() => MapFromDB(result));
        }

        public IEnumerable<Receita> List(ReceitaFilter filter)
        {
            return ListAsync(filter).Result;
        }

        public async Task UpdateAsync(Receita entity)
        {
            await Connection.ExecuteAsync(
                "SProc_Receita_Update",
                commandType: CommandType.StoredProcedure,
                param: new
                {
                    entity.Id,
                    entity.Titulo,
                    entity.Descricao,
                    entity.ModoPreparo,
                    entity.Ativo,
                    entity.DataCadastro
                },
                transaction: transaction
            );
        }

        public void Update(Receita entity)
        {
            UpdateAsync(entity).ConfigureAwait(false);
        }

        #region Map
        public Receita MapFromDB(dynamic obj)
        {
            return new Receita
            {
                Id = obj.Id,
                Titulo = obj.Titulo,
                Descricao = obj.Descricao,
                ModoPreparo = obj.ModoPreparo,
                Ativo = obj.Ativo,
                DataCadastro = obj.DataCadastro,
            };
        }

        public IEnumerable<Receita> MapFromDB(IEnumerable<dynamic> obj)
        {
            return obj.Select(x => (Receita)MapFromDB(x));
        }
        #endregion
    }
}
