using System.ComponentModel.DataAnnotations;

namespace Parcial1_JonathanMaria.Entidades
{
    public class Inventarios
    {
        [Key]
        public int InventarioId { get; set; }
        public float Valor { get; set; }

        public Inventarios()
        {
            InventarioId = 0;
            Valor = 0;
        }

    }
}
