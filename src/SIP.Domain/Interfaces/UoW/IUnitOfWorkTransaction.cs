using System;

namespace DevWebReceitas.Domain.Interfaces.UoW
{
    public interface IUnitOfWorkTransaction : IDisposable
    {
        void Commit();
        void Rollback();
    }
}
