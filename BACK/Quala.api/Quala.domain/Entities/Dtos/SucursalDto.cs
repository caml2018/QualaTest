using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quala.domain.Entities.Dtos
{
    public class SucursalDto
    {
        public int Id { get; set; }
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public string Direccion { get; set; }
        public string Identificacion { get; set; }
        public DateTime? Fechacreacion { get; set; }
        public int? MonedaId { get; set; }
    }
}
