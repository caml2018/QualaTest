using System;
using System.Collections.Generic;

#nullable disable

namespace Quala.domain.Entities.Models
{
    public partial class Sucursal
    {
        public int Id { get; set; }
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public string Direccion { get; set; }
        public string Identificacion { get; set; }
        public DateTime? Fechacreacion { get; set; }
        public int? MonedaId { get; set; }
        public int? Estado { get; set; }

        public virtual Monedum Moneda { get; set; }
    }
}
