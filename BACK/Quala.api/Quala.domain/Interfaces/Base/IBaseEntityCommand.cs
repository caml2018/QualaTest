using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quala.domain.Interfaces.Base
{
    public interface IBaseEntityCommand<T,Tid>:ICreate<T>,IUpdate<T,Tid>,IDelete<Tid> 
    {
    }
}
