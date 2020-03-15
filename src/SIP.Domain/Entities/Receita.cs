using System.Collections.Generic;

namespace DevWebReceitas.Domain.Entities
{
    public class Receita : BaseEntity
    {
        public Categoria Categoria { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public string ModoPreparo { get; set; }
        public IEnumerable<Item> Itens { get; set; }
    }
}
