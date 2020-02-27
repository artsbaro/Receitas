using DevWebReceitas.Domain.Interfaces.Repositories;

namespace DevWebReceitas.Domain.Interfaces.UoW
{
    public interface IUnitOfWork
    {
        IUnitOfWorkTransaction Begin(params IRepository[] repositories);
    }
}
