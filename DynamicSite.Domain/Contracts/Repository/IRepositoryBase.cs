using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicSite.Domain.Contracts.Repository
{
    public interface IRepositoryBase<T>
    {
        void Create(T objeto );

        void Update(T objeto);

        void Delete(T objeto);

        IList<T> FindAll();

        T FindId(long ID);

        IList<T> FindAll(int startPage, int maxResult);

    }
}
