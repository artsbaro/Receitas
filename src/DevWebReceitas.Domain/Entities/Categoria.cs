using System;

namespace DevWebReceitas.Domain.Entities
{
    public class Categoria 
    {
        public virtual short Id { get; set; }
        public virtual DateTime DataCadastro { get; set; }
        public virtual DateTime? DataUltimaAlteracao { get; set; }
        public virtual bool Ativo { get; set; }
        public Guid Codigo { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }

        public Categoria()
        {
            DataCadastro = DateTime.Now;
            Ativo = true;            
        }
    }
}
