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
    public class CategoriaRepository : RepositoryBase, ICategoriaRepository
    {
        public CategoriaRepository(IConfiguration configuration) : base(configuration)
        {
        }

        public void Create(Categoria entity)
        {
            Connection.Execute(
                "SProc_Categoria_Insert",
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


        public Categoria FindById(Guid id)
        {
            return Connection.QueryFirstOrDefault<Categoria>(
               "SProc_Categoria_GetById",
               commandType: CommandType.StoredProcedure,
                param: new
               {
                   Id = id
               }
            );
        }

        public IEnumerable<Categoria> List(CategoriaFilter filter)
        {
            return Connection.Query<Categoria>(
               "SProc_Categoria_GetAll",
               commandType: CommandType.StoredProcedure
           );
        }

        public void Remove(Guid id)
        {
            Connection.Execute(
                "SProc_Categoria_Delete",
                commandType: CommandType.StoredProcedure,
                param: new
                {
                    Id = id
                }
            );
        }

        public void Update(Categoria entity)
        {
            Connection.Execute(
                "SProc_Categoria_Update",
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
