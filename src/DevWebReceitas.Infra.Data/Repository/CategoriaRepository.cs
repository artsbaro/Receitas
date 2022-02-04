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
                    entity.Codigo,
                    entity.Titulo,
                    entity.Descricao,
                    entity.Ativo,
                    entity.DataCadastro
                }
            );
        }


        public async Task<Categoria> FindById(short id)
        {
            return await Connection.QueryFirstOrDefaultAsync<Categoria>(
               "SProc_Categoria_GetById",
               commandType: CommandType.StoredProcedure,
                param: new
                {
                    Id = id
                }
            );
        }

        public async Task<Categoria> FindByCode(Guid codigo)
        {
            return await Connection.QueryFirstOrDefaultAsync<Categoria>(
               "SProc_Categoria_GetByCode",
               commandType: CommandType.StoredProcedure,
                param: new
                {
                    Codigo = codigo
                }
            );
        }

        public IEnumerable<Categoria> List(CategoriaFilter filter)
        {
            return Connection.Query<Categoria>(
               "SProc_Categoria_GetByFilter",
               commandType: CommandType.StoredProcedure,
                param: new
                {
                    filter.Titulo,
                    filter.Descricao
                });
        }

        public void Remove(short id)
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

        public void Remove(Guid codigo)
        {
            Connection.Execute(
                "SProc_Categoria_Delete",
                commandType: CommandType.StoredProcedure,
                param: new
                {
                    Codigo = codigo
                }
            );
        }

        public void Update(Categoria entity)
        {
            Connection.Execute(
                "SProc_Categoria_Update",
                commandType: CommandType.StoredProcedure,
                param: new
                {
                    entity.Id,
                    entity.Titulo,
                    entity.Descricao,
                    entity.Codigo,
                    entity.Ativo,
                    entity.DataUltimaAlteracao
                }
            );
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public Categoria FindById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
