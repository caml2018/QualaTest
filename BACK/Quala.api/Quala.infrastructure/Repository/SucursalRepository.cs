using Microsoft.Extensions.Configuration;
using Quala.application.Interfaces;
using Quala.domain.Entities.Models;
using Quala.infrastructure.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quala.infrastructure.Repository
{
    internal class SucursalRepository : ISucursalRepository
    {
        private readonly DbQualaTestContext _db;

        public SucursalRepository(DbQualaTestContext db)
        {
            _db = db;
        }

        public Sucursal Add(Sucursal entity)
        {
            try
            {
                entity.Estado = 1;
                _db.Add(entity);
                _db.SaveChanges();
                return entity;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al intentar Agregar la sucursal {ex.Message}");
            }
        }

        public void delete(int id)
        {
            try
            {
                var entity = this._db.Sucursals.FirstOrDefault(x => x.Id == id);
                if (entity != null)
                {
                    entity.Estado = 0;
                    this._db.Attach(entity);
                    this._db.Entry(entity).Property(p => p.Estado).IsModified = true;
                    this._db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al intentar Borra la Sucursal con id: {id} -> {ex.Message}");
            }
        }

        public Sucursal get(int id)
        {
            try
            {
                return _db.Sucursals.Where(x=>x.Id==id && x.Estado==1).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al intetar obtener el registro con el id: {id} -> {ex.Message}");
            }
        }

        public List<Sucursal> getAll()
        {
            try
            {
                return _db.Sucursals.Where(x=>x.Estado==1).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al intenter obtener todas las Sucursales -> {ex.Message}");
            }
        }

        public Sucursal update(Sucursal entity, int id)
        {
            try
            {
                this._db.Entry(this._db.Sucursals.FirstOrDefault(x => x.Id == entity.Id)).CurrentValues.SetValues(entity);
                this._db.SaveChanges();
                return entity;
            }
            catch (Exception ex)
            {

                throw new Exception($"Error al intenter actualizar las Sucursales -> {ex.Message}");
            }
        }
    }
}
