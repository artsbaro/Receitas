using Dapper;
using DevWebReceitas.Domain.Entities;
using DevWebReceitas.Domain.Filters;
using DevWebReceitas.Domain.Interfaces.Repositories;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace DevWebReceitas.Infra.Data.Repository
{
    public class ItemRepository : RepositoryBase, IItemRepository
    {
        public ItemRepository(IConfiguration configuration) : base(configuration)
        {
        }

        public async Task CreateAsync(Item entity)
        {
            await Connection.ExecuteAsync(
                "SProc_Item_Insert",
                commandType: CommandType.StoredProcedure,
                param: entity,
                transaction: transaction
            );
        }

        public void Create(Item entity)
        {
            CreateAsync(entity).Wait();
        }


        public Task<Item> FindByIdAsync(Guid id)
        {
            return Connection.QueryFirstOrDefaultAsync<Item>(
               "SProc_Item_GetById",
               commandType: CommandType.StoredProcedure,
               transaction: transaction
            );
        }

        public Item FindById(Guid id)
        {
            return FindByIdAsync(id).Result;
        }

        public Task<IEnumerable<Item>> ListAsync(ItemFilter filter)
        {
            return Connection.QueryAsync<Item>(
               "SProc_Item_GetAll",
               commandType: CommandType.StoredProcedure,
               transaction: transaction
           );
        }

        public IEnumerable<Item> List(ItemFilter filter)
        {
            return ListAsync(filter).Result;
        }

        public async Task RemoveAsync(Guid id)
        {
            await Connection.ExecuteAsync(
                "SProc_Item_Delete",
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
            RemoveAsync(id).Wait();
        }

        public async Task UpdateAsync(Item entity)
        {
            await Connection.ExecuteAsync(
                "SProc_Ingrediente_Update",
                commandType: CommandType.StoredProcedure,
                param: entity,
                transaction: transaction
            );
        }

        public void Update(Item entity)
        {
            UpdateAsync(entity).Wait();
        }

        public void RemoveItemByReceitaId(Guid id)
        {
            RemoveItemByReceitaIdAsync(id).ConfigureAwait(false);
        }

        public async Task RemoveItemByReceitaIdAsync(Guid id)
        {
            await Connection.ExecuteAsync(
               "SProc_Item_DeleteByReceitaId",
               commandType: CommandType.StoredProcedure,
               param: new
               {
                   Id = id
               },
               transaction: transaction
           );
        }

        public async Task<IEnumerable<Item>> FindByReceitaIdAsync(Guid id)
        {
            return await Connection.QueryAsync<Item>(
               "SProc_Item_GetByReceitaId",
               commandType: CommandType.StoredProcedure,
               param: new { ReceitaId = id },
               transaction: transaction
            );
        }

        public IEnumerable<Item> FindByReceitaId(Guid id)
        {
            return FindByReceitaIdAsync(id).Result;
        }
    }
}
