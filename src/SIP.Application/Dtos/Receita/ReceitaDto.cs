using DevWebReceitas.Application.Attributes;
using DevWebReceitas.Application.Dtos.Categoria;
using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DevWebReceitas.Application.Dtos
{
    public class ReceitaDto
    {
        [Required(ErrorMessage = "Codigo não preenchido.")]
        public Guid Codigo { get; set; }

        [Required(ErrorMessage = "Categoria não preenchido.")]
        public CategoriaDto Categoria { get; set; }

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

        [Required(ErrorMessage = "Ingredientes não preenchido.")]
        [MinLength(3, ErrorMessage = "Ingredientes deve ter mais que 3 caracteres")]
        [MaxLength(4000, ErrorMessage = "Ingredientes deve ter menos que 4000 caracteres")]
        [DisplayName("Ingredientes")]
        public string Ingredientes { get; set; }

        [Required(ErrorMessage = "Please select a file.")]
        [DataType(DataType.Upload)]
        [MaxFileSize(5 * 1024 * 1024)]
        [AllowedExtensions(new string[] { ".jpg", ".png" })]
        public IFormFile Imagem { get; set; }
    }
}


