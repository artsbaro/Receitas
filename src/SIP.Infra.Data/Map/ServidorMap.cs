using Dapper.FluentMap.Mapping;
using DevWebReceitas.Domain.Entities;


namespace DevWebReceitas.Infra.Data.Map
{
    public class ServidorMap : EntityMap<Receita>
    {
        public ServidorMap()
        {
            //Map(s => s.Sexo.Id)
            //    .ToColumn("SexoId", false);
        }
    }
}
