using System;
using System.Collections.Generic;

#nullable disable

namespace Quala.domain.Entities.Models
{
    public partial class Monedum
    {
        public Monedum()
        {
            Sucursals = new HashSet<Sucursal>();
        }

        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public int? Estado { get; set; }

        public virtual ICollection<Sucursal> Sucursals { get; set; }
    }
}
