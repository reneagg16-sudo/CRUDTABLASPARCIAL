using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDTablas.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public virtual ICollection<Producto> Productos { get; set; } = new List<Producto>();
    }
}
