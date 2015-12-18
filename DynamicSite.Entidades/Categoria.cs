using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicSite.Entidades
{
    public class Categoria
    {

        public long Id { get; set; }

        public string Nome { get; set; }

        public int Ordem { get; set; }

        public string UrlAmigavel { get; set; }

        public long IdCategoriaPai { get; set; }

        public virtual ICollection<Categoria> SubCategorias { get; set; }

    }
}
