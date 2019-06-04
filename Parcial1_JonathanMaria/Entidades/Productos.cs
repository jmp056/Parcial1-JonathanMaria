using System.ComponentModel.DataAnnotations;

namespace Parcial1_JonathanMaria.Entidades
{
    public class Productos
    {
        [Key]
        public int ProductoId { get; set; }
        public string Descripcion { get; set; }
        public int Existencia { get; set; }
        public float Costo { get; set; }
        public float ValorEnInventario { get; set; }

        public Productos()
        {
            ProductoId = 0;
            Descripcion = string.Empty;
            Existencia = 0;
            Costo = 0;
            ValorEnInventario = 0;
        }
    }
}
