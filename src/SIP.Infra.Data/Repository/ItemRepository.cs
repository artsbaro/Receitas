using Dapper;
using DevWebReceitas.Domain.Entities;
using DevWebReceitas.Domain.Filters;
using DevWebReceitas.Domain.Interfaces.Repositories;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace DevWebReceitas.Infra.Data.Repository
{
    public class ItemRepository : RepositoryBase, IItemRepository
    {
        public ItemRepository(IConfiguration configuration) : base(configuration)
        {
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

        public Item FindById(Guid id)
        {
            var result = Connection.QueryFirstOrDefault(
               "SProc_Item_GetById",
               commandType: CommandType.StoredProcedure
            );

            return MapFromDB(result);
        }

        public IEnumerable<Item> List(ItemFilter filter)
        {
            return Connection.Query<Item>(
               "SProc_Item_GetAll",
               commandType: CommandType.StoredProcedure
            );
        }

        public void Remove(Guid id)
        {
            Connection.Execute(
                "SProc_Item_Delete",
                commandType: CommandType.StoredProcedure,
                param: new
                {
                    Id = id
                }
            );
        }

        public void Update(Item entity)
        {
            Connection.Execute(
                 "SProc_Ingrediente_Update",
                 commandType: CommandType.StoredProcedure,
                 param: entity
             );
        }

        public void RemoveItemByReceitaId(Guid id)
        {
            Connection.Execute(
               "SProc_Item_DeleteByReceitaId",
               commandType: CommandType.StoredProcedure,
               param: new
               {
                   Id = id
               }
            );
        }

        public IEnumerable<Item> FindByReceitaId(Guid id)
        {
            var result = Connection.Query(
               "SProc_Item_GetByReceitaId",
               commandType: CommandType.StoredProcedure,
               param: new { ReceitaId = id }
            );

            return MapFromDB(result);
        }

        #region Map
        public Item MapFromDB(dynamic obj)
        {
            return new Item
            {
                Id = obj.Id,
                Ativo = obj.Ativo,
                DataCadastro = obj.DataCadastro,
                Obs = obj.Obs,
                Quantidade = obj.Quantidade,
                ReceitaId = obj.ReceitaId,
                DataUltimaAlteracao = obj.DataUltimaAlteracao,
                Ingrediente = new Ingrediente { 
                    Id = obj.IngredienteId,
                    Nome = obj.IngredienteNome
                }
            };
        }

        public IEnumerable<Item> MapFromDB(IEnumerable<dynamic> obj)
        {
            return obj.Select(x => (Item)MapFromDB(x));
        }
        #endregion
    }
}
