using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicSite.Entidades
{
    public class Template
    {
        public long Id { get; set; }

        public string Nome { get; set; }

        public string Descricao { get; set; }

        public string Autor { get; set; }

        public DateTime DataCriacao { get; set; }

        public decimal Versao { get; set; }

        public bool PadraoSite { get; set; }

        public bool EhAdministrativo { get; set; }

    }
}
