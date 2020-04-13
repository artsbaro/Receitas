using System;

namespace DevWebReceitas.Domain.Entities
{
    public abstract class BaseEntity
    {
        public virtual int Id { get; set; }
        public virtual DateTime DataCadastro { get; set; }
        public virtual DateTime? DataUltimaAlteracao { get; set; }
        public virtual bool Ativo { get; set; }

        public BaseEntity()
        {
            DataCadastro = DateTime.Now;
            Ativo = true;
        }
    }
}