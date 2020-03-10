using DevWebReceitas.Application.Dtos.Item;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DevWebReceitas.Application.Dtos
{
    public class ReceitaDto
    {
        public Guid Id { get; set; }

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
        public IEnumerable<ItemDto> Itens { get; set; }
    }
}


