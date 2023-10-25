using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quala.domain.Interfaces
{
    public interface IQuery<T,Tid>
    {
        public T get(Tid id);
        public List<T> getAll();
    }
}
