using DevWebReceitas.Domain.Interfaces.Repositories;
using DevWebReceitas.Domain.Interfaces.UoW;
using DevWebReceitas.Infra.Data.Repository;
using Microsoft.Extensions.Configuration;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DevWebReceitas.Infra.Data.UoW
{

    public class UnitOfWork : IUnitOfWork
    {
        #region Fields 
        private readonly IDbConnection connection;

        #endregion

        #region Constructor
        public UnitOfWork(IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString(RepositoryBase.CONNECTIONSTRING_KEY);

            if (string.IsNullOrWhiteSpace(connectionString))
                throw new ArgumentNullException("Connection string not found");

            connection = new SqlConnection(connectionString);
        }
        #endregion

        #region Begin
        public IUnitOfWorkTransaction Begin(params IRepository[] repositories)
        {

            if (repositories == null || repositories.Length == 0)
                throw new ArgumentNullException(nameof(repositories), "repositories is required");
            var unitOfWorkTransaction = new UnitOfWorkTransaction(connection, repositories);
            return unitOfWorkTransaction;
        }
        #endregion
    }
}
