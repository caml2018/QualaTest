using Quala.application.Interfaces;
using Quala.domain.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quala.application.Commands.SucursalC
{
    internal class SucursalWrite : ISucursalWrite
    {
        private readonly ISucursalRepository _sucursalRepository;

        public SucursalWrite(ISucursalRepository sucursalRepository)
        {
            _sucursalRepository = sucursalRepository;
        }

        public Sucursal Add(Sucursal entity)
        {
            return _sucursalRepository.Add(entity);
        }

        public void delete(int id)
        {
            _sucursalRepository.delete(id);
        }

        public Sucursal update(Sucursal entity, int id)
        {
            return _sucursalRepository.update(entity, id);
        }
    }
}
