using DevWebReceitas.Application.Attributes;
using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DevWebReceitas.Application.Dtos
{
    public class ReceitaInsertDto
    {
        [Required(ErrorMessage = "Titulo não preenchido.")]
        [MinLength(3, ErrorMessage = "Titulo deve ter mais que 3 caracteres")]
        [MaxLength(150, ErrorMessage = "Titulo deve ter menos que 150 caracteres")]
        [DisplayName("Titulo")]
        public string Titulo { get; set; }

        [MinLength(3, ErrorMessage = "Descricao deve ter mais que 3 caracteres")]
        [MaxLength(256, ErrorMessage = "Descricao deve ter menos que 256 caracteres")]
        [DisplayName("Descricao")]
        public string Descricao { get; set; }

        [MinLength(3, ErrorMessage = "Modo de Preparo deve ter mais que 3 caracteres")]
        [DisplayName("Modo de Preparo")]
        public string ModoPreparo { get; set; }

        [Required(ErrorMessage = "CategoriaId não preenchido.")]
        public short CategoriaId { get; set; }

        [Required(ErrorMessage = "Ingredientes não preenchido.")]
        [MinLength(3, ErrorMessage = "Ingredientes deve ter mais que 3 caracteres")]
        [MaxLength(4000, ErrorMessage = "Ingredientes deve ter menos que 4000 caracteres")]
        [DisplayName("Ingredientes")]
        public string Ingredientes { get; set; }

        public IFormFile Imagem { get; set; }
    }
}