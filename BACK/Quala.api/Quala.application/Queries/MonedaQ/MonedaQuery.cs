using Quala.application.Interfaces;
using Quala.domain.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quala.application.Queries.MonedaQ
{
    internal class MonedaQuery : IMonedaQuery
    {
        private readonly IMonedaRepository _monedaRepository;

        public MonedaQuery(IMonedaRepository monedaRepository)
        {
            _monedaRepository = monedaRepository;
        }

        public Monedum get(int id)
        {
            return _monedaRepository.get(id);
        }

        public List<Monedum> getAll()
        {
            return _monedaRepository.getAll();
        }
    }
}
