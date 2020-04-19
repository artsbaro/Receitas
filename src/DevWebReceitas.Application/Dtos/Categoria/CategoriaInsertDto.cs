using System.ComponentModel.DataAnnotations;

namespace DevWebReceitas.Application.Dtos.Categoria
{
    public class CategoriaInsertDto
    {
        [Required(ErrorMessage = "Nome não preenchido.")]
        [MinLength(3, ErrorMessage = "Nome deve ter mais que 3 caracteres")]
        [MaxLength(128, ErrorMessage = "Nome deve ter menos que 128 caracteres")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "Nome não preenchido.")]
        [MinLength(3, ErrorMessage = "Nome deve ter mais que 3 caracteres")]
        [MaxLength(512, ErrorMessage = "Nome deve ter menos que 512 caracteres")]
        public string Descricao { get; set; }
    }
}
