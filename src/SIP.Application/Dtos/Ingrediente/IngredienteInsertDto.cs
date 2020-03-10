﻿using System.ComponentModel.DataAnnotations;

namespace DevWebReceitas.Application.Dtos.Ingrediente
{
    public class IngredienteInsertDto
    {
        [Required(ErrorMessage = "Nome não preenchido.")]
        [MinLength(3, ErrorMessage = "Nome deve ter mais que 3 caracteres")]
        [MaxLength(128, ErrorMessage = "Nome deve ter menos que 150 caracteres")]
        public string Nome { get; set; }
    }
}
