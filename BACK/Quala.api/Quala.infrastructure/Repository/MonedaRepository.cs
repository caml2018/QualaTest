using Quala.application.Interfaces;
using Quala.domain.Entities.Models;
using Quala.infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Quala.infrastructure.Repository
{
    internal class MonedaRepository : IMonedaRepository
    {
        private readonly DbQualaTestContext _db;

        public MonedaRepository(DbQualaTestContext db)
        {
            _db = db;
        }
        public Monedum get(int id)
        {
            try
            {
                return _db.Moneda.Where(x => x.Id == id && x.Estado == 1).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al intetar obtener Moneda con el id: {id} -> {ex.Message}");
            }
        }

        public List<Monedum> getAll()
        {
            try
            {
                return _db.Moneda.Where(x=>x.Estado==1).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al intenter obtener todas las Monedas -> {ex.Message}");
            }
        }
    }
}
