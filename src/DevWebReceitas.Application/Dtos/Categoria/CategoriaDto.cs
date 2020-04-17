using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DevWebReceitas.Application.Dtos.Categoria
{
    public class CategoriaDto
    {
        [Required(ErrorMessage ="Codigo não preenchido.")]
        public Guid Codigo { get; set; }

        [Required(ErrorMessage = "Nome não preenchido.")]
        [MinLength(3, ErrorMessage = "Nome deve ter mais que 3 caracteres")]
        [MaxLength(128, ErrorMessage = "Nome deve ter menos que 128 caracteres")]
        [DisplayName("Título")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "Nome não preenchido.")]
        [MinLength(3, ErrorMessage = "Nome deve ter mais que 3 caracteres")]
        [MaxLength(512, ErrorMessage = "Nome deve ter menos que 512 caracteres")]
        [DisplayName("Descrição")]
        public string Descricao { get; set; }
    }
}
