using System;
using DevWebReceitas.Application.Dtos.Categoria;
using DevWebReceitas.Application.Dtos.Ingrediente;

namespace DevWebReceitas.Application.Dtos.Item
{
    public class ItemDto
    {
        public Guid Id { get; set; }
        public decimal Quantidade { get; set; }
        public CategoriaDto Ingrediente { get; set; }
        public string Obs { get; set; }
    }
}
