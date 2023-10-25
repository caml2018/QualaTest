using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quala.domain.Interfaces
{
    public interface ICreate<T>
    {
        public T Add(T entity);
    }
}
