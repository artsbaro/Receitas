using Dapper;
using DevWebReceitas.Domain.Entities;
using DevWebReceitas.Domain.Filters;
using DevWebReceitas.Domain.Interfaces.Repositories;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;

namespace DevWebReceitas.Infra.Data.Repository
{
    public class IngredienteRepository : RepositoryBase, IIngredienteRepository
    {
        public IngredienteRepository(IConfiguration configuration) : base(configuration)
        {
        }

        public void Create(Ingrediente entity)
        {
            Connection.Execute(
                "SProc_Ingrediente_Insert",
                commandType: CommandType.StoredProcedure,
                param: new
                {
                    entity.Id,
                    entity.Nome,
                    entity.Ativo,
                    entity.DataCadastro
                }
            );
        }


        public Ingrediente FindById(Guid id)
        {
            return Connection.QueryFirstOrDefault<Ingrediente>(
               "SProc_Ingrediente_GetById",
               commandType: CommandType.StoredProcedure,
                param: new
               {
                   Id = id
               }
            );
        }

        public IEnumerable<Ingrediente> List(IngredienteFilter filter)
        {
            return Connection.Query<Ingrediente>(
               "SProc_Ingrediente_GetAll",
               commandType: CommandType.StoredProcedure
           );
        }

        public void Remove(Guid id)
        {
            Connection.Execute(
                "SProc_Ingrediente_Delete",
                commandType: CommandType.StoredProcedure,
                param: new
                {
                    Id = id
                }
            );
        }

        public void Update(Ingrediente entity)
        {
            Connection.Execute(
                "SProc_Ingrediente_Update",
                commandType: CommandType.StoredProcedure,
                param: new {
                    entity.Id,
                    entity.Nome,
                    entity.Ativo,
                    entity.DataUltimaAlteracao
                }
            );
        }
    }
}
