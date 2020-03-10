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
                param: new {
                    entity.Id,
                    entity.Quantidade,
                    IngredienteId = entity.Ingrediente.Id,
                    entity.ReceitaId,
                    entity.Obs,
                    entity.Ativo,
                    entity.DataCadastro
                }
            );
        }

        public void Create(Item entity)
        {
            Connection.Execute(
                "SProc_Item_Insert",
                commandType: CommandType.StoredProcedure,
                param: new
                {
                    entity.Id,
                    entity.Quantidade,
                    IngredienteId = entity.Ingrediente.Id,
                    entity.ReceitaId,
                    entity.Obs,
                    entity.Ativo,
                    entity.DataCadastro
                }
            );
        }


        public Task<Item> FindByIdAsync(Guid id)
        {
            return Connection.QueryFirstOrDefaultAsync<Item>(
               "SProc_Item_GetById",
               commandType: CommandType.StoredProcedure
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
               commandType: CommandType.StoredProcedure
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
                }
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
                param: entity
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
               }
           );
        }

        public async Task<IEnumerable<Item>> FindByReceitaIdAsync(Guid id)
        {
            return await Connection.QueryAsync<Item>(
               "SProc_Item_GetByReceitaId",
               commandType: CommandType.StoredProcedure,
               param: new { ReceitaId = id }
            );
        }

        public IEnumerable<Item> FindByReceitaId(Guid id)
        {
            return FindByReceitaIdAsync(id).Result;
        }
    }
}
