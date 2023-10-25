using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quala.domain.Interfaces
{
    public interface IDelete <Tid>
    {
        public void delete(Tid id);
    }
}
