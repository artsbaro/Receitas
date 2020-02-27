using DevWebReceitas.Domain.Interfaces.Repositories;
using DevWebReceitas.Domain.Interfaces.UoW;
using DevWebReceitas.Infra.Data.Repository;
using System;
using System.Collections.Generic;
using System.Data;

namespace DevWebReceitas.Infra.Data.UoW
{
    public class UnitOfWorkTransaction : IUnitOfWorkTransaction
    {
        #region Fields
        private IDbTransaction transaction;
        private IDbConnection connection;
        private Dictionary<RepositoryBase, IDbConnection> repositoriesDictionary = new Dictionary<RepositoryBase, IDbConnection>();
        private bool disposed;
        #endregion

        #region Constructor
        public UnitOfWorkTransaction(IDbConnection connection, params IRepository[] repositories)
        {
            this.connection = connection;
            ConfigureConnections(connection, repositories);
        }

        private void ConfigureConnections(IDbConnection connection, IRepository[] repositories)
        {
            connection.Open();
            transaction = connection.BeginTransaction();
            foreach (var repository in repositories)
            {
                var respotoryBase = repository as RepositoryBase;

                if (respotoryBase == null)
                    throw new InvalidOperationException("Invalid RepositoryBase");

                repositoriesDictionary.Add(respotoryBase, respotoryBase.Connection);

                respotoryBase.SetTransaction(transaction);
            }
        }
        #endregion

        #region Commit/Rollback
        public void Commit()
        {
            try
            {
                transaction.Commit();
            }
            catch
            {
                transaction.Rollback();
                throw;
            }
            finally
            {
                transaction.Dispose();
            }
        }

        public void Rollback()
        {
            try
            {
                transaction.Rollback();
            }
            finally
            {
                transaction.Dispose();
            }
        }
        #endregion

        #region Dispose
        public void Dispose()
        {
            dispose(true);
            GC.SuppressFinalize(this);
        }

        private void dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    if (transaction != null)
                    {
                        transaction.Dispose();
                        transaction = null;
                    }
                    if (connection != null)
                        connection = null;
                }
                disposing = true;
                ResetRepositoriesConnections();
            }
        }

        private void ResetRepositoriesConnections()
        {
            foreach (var respotiory in repositoriesDictionary)
                respotiory.Key.SetConnection(respotiory.Value);
        }
        ~UnitOfWorkTransaction()
        {
            ResetRepositoriesConnections();
            dispose(false);
        }
        #endregion
    }
}
