using Quala.domain.Entities.Models;
using Quala.domain.Interfaces.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quala.application.Commands.SucursalC
{
    public interface ISucursalWrite:IBaseEntityCommand<Sucursal,int>
    {
    }
}
