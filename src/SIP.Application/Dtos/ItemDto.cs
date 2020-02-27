using System;
using System.ComponentModel.DataAnnotations;

namespace DevWebReceitas.Application.Dtos
{
    public class ItemDto
    {
        [Required(ErrorMessage = "Quantidade não preenchida.")]
        public decimal Quantidade { get; set; }
        public IngredienteDto Ingrediente { get; set; }
        public Guid ReceitaId { get; set; }
        public string Obs { get; set; }
    }
}
