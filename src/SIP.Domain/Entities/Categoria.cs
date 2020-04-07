
using System;

namespace DevWebReceitas.Domain.Entities
{
    public class Categoria : BaseEntity
    {
        public Guid Codigo { get; set; }
        public string Nome { get; set; }
    }
}
