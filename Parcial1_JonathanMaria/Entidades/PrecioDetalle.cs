using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoParcial1.Entidades
{
    public class PreciosDetalle
    {
        [Key]
        public int PrecioId { get; set; }
        public int ProductoId { get; set; }
        public string TipoPrecio { get; set; }
        public decimal Precio { get; set; }

        public PreciosDetalle()
        {
            PrecioId = 0;
            ProductoId = 0;
            TipoPrecio = string.Empty;
            Precio = 0;
        }
    }
}
