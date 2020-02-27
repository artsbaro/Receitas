using System;

namespace DevWebReceitas.Domain.Entities
{
    public class Item : BaseEntity
    {
        public decimal Quantidade { get; set; }
        public Ingrediente Ingrediente { get; set; }
        public Guid ReceitaId { get; set; }
        public string Obs { get; set; }
    }
}
