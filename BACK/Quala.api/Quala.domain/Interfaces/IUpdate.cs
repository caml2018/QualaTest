using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quala.domain.Interfaces
{
    public interface IUpdate<T,Tid>
    {
        public T update(T entity, Tid id);
    }
}
