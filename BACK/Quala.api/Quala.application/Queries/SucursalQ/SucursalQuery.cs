using Quala.application.Interfaces;
using Quala.domain.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quala.application.Queries.SucursalQ
{
    internal class SucursalQuery : ISucursalQuery
    {
        private readonly ISucursalRepository _sucursalRepository;

        public SucursalQuery(ISucursalRepository sucursalRepository)
        {
            _sucursalRepository = sucursalRepository;
        }

        public Sucursal get(int id)
        {
            return _sucursalRepository.get(id);
        }

        public List<Sucursal> getAll()
        {
            return _sucursalRepository.getAll();    
        }
    }
}
