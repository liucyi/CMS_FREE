using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicSite.Entidades
{
    public class Artigo
    {
        public long Id { get; set; }

        public DateTime DataCriacao { get;set; }

        public DateTime DataUltimaAtualizacao { get; set; }

        public string Titulo { get; set; }

        public string Previa { get; set; }

        public string TextoArtigo { get; set; }

        public string UrlReferencia { get; set; }

        public string UrlAmigavel { get; set; }

        public string Autor { get; set; }

        public long IdCategoria { get; set; }

        public virtual Categoria Categoria {get;set;}

    }
}
