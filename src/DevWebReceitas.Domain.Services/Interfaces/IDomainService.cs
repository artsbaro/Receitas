namespace DevWebReceitas.Domain.Services.Interfaces
{
    public interface IDomainService <T, TCode>
    {
        T FindByCode(TCode code);
    }
}
