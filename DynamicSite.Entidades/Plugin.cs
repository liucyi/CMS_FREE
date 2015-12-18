using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicSite.Entidades
{
    public class Plugin
    {
        public long Id { get; set; }

        public Tipo TipoPlugin { get; set; }

        public string Nome { get; set; }

        public DateTime DataCriacao { get; set; }

        public DateTime DataAtivacao { get; set; }

        public bool Ativo { get; set; }

        public int Ordem { get; set; }
        

    }
}
