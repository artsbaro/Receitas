using System;

namespace DevWebReceitas.Domain.Entities
{
    public class Receita : BaseEntity
    {
        public Guid Codigo { get; set; }
        public Categoria Categoria { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public string ModoPreparo { get; set; }
        public string Ingredientes { get; set; }
        public byte[] Imagem { get; set; }
        public string CaminhoImagem { get; set; }
        public string NomeArquivo { get; set; }
        public bool Excluido { get; set; }
        public int Likes { get; set; }
        public int DisLikes { get; set; }

        public bool HasImage
        {
            get { return Imagem?.Length > 0; }
        }

        private void SetExclusao()
        {
            Excluido = true;
            SetInativo();
        }

        private void SetInativo()
        {
            Ativo = false;
        }
    }
}
