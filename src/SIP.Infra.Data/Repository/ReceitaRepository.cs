using System.Collections.Generic;
using System.Data;
using Dapper;
using System;
using System.Linq;
using Microsoft.Extensions.Configuration;
using DevWebReceitas.Domain.Entities;
using DevWebReceitas.Domain.Filters;
using DevWebReceitas.Domain.Interfaces.Repositories;

namespace DevWebReceitas.Infra.Data.Repository
{
    public class ReceitaRepository : RepositoryBase, IReceitaRepository
    {
        public ReceitaRepository(IConfiguration configuration) : base(configuration)
        {
        }

        public void Create(Receita entity)
        {
            Connection.Execute(
                "SProc_Receita_Insert",
                commandType: CommandType.StoredProcedure,
                param: new
                {
                    entity.Codigo,
                    entity.Titulo,
                    entity.Descricao,
                    entity.ModoPreparo,
                    entity.CaminhoImagem,
                    entity.Ingredientes,
                    CategoriaId = entity.Categoria.Id,
                    entity.Ativo,
                    entity.DataCadastro
                }
            );
        }

        public void Remove(int id)
        {
            Connection.Execute(
                "SProc_Receita_Delete",
                commandType: CommandType.StoredProcedure,
                param: new
                {
                    Id = id
                }
            );
        }

        public void Remove(Guid code)
        {
            Connection.Execute(
                "SProc_Receita_DeleteByCode",
                commandType: CommandType.StoredProcedure,
                param: new
                {
                    Codigo = code
                }
            );
        }

        public Receita FindById(int id)
        {
            var obj = Connection.QuerySingleOrDefault("SProc_Receita_GetById",
            commandType: CommandType.StoredProcedure,
            param: new { Id = id });

            if (obj == null)
                throw new ArgumentException("Receita não encontrada");

            return MapFromDB(obj);
        }

        public Receita FindByCode(Guid code)
        {
            var obj = Connection.QuerySingleOrDefault("SProc_Receita_GetByCode",
            commandType: CommandType.StoredProcedure,
            param: new { Codigo = code });

            if (obj == null)
                throw new ArgumentException("Receita não encontrada");

            return MapFromDB(obj);
        }

        public IEnumerable<Receita> List(ReceitaFilter filter)
        {
            var result = Connection.Query(
           "SProc_Receita_GetAll",
           commandType: CommandType.StoredProcedure);

            return MapFromDB(result);
        }

        public void Update(Receita entity)
        {
            Connection.Execute(
                "SProc_Receita_Update",
                commandType: CommandType.StoredProcedure,
                param: new
                {
                    entity.Id,
                    entity.Codigo,
                    entity.Titulo,
                    entity.Descricao,
                    entity.ModoPreparo,
                    entity.CaminhoImagem,
                    entity.Ingredientes,
                    CategoriaId = entity.Categoria.Id,
                    entity.Ativo,
                    entity.DataCadastro
                }
            );
        }

        #region Map
        public Receita MapFromDB(dynamic obj)
        {
            return new Receita
            {
                Id = obj.Id,
                Codigo = obj.Codigo,
                Titulo = obj.Titulo,
                Descricao = obj.Descricao,
                ModoPreparo = obj.ModoPreparo,
                CaminhoImagem = obj.CaminhoImagem,
                Ingredientes = obj.Ingredientes,
                Categoria = new Categoria { Id = obj.CategoriaId, Nome = obj.CategoriaNome},
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
