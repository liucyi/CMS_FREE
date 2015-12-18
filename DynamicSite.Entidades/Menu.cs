using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicSite.Entidades
{
    public class Menu
    {
        public long Id { get; set; }

        public string Nome { get; set; }

        public int Ordem { get; set; }

        public string UrlAmigavel { get; set; }

        public long IdMenuPai { get; set; }

        public virtual ICollection<Menu> SubMenus { get; set; }

    }
}
