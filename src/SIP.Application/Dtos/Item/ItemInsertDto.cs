using System;
using System.ComponentModel.DataAnnotations;

namespace DevWebReceitas.Application.Dtos.Item
{
    public class ItemInsertDto
    {
        [Required(ErrorMessage = "Quantidade não preenchida.")]
        public decimal Quantidade { get; set; }
        [Required(ErrorMessage = "IngredienteId não informado.")]
        public Guid IngredienteId { get; set; }
        public string Obs { get; set; }
    }
}
