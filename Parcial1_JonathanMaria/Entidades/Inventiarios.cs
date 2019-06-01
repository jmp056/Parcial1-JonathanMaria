using System.ComponentModel.DataAnnotations;

namespace Parcial1_JonathanMaria.Entidades
{
    public class Inventarios
    {
        [Key]
        public int Id { get; set; }
        public float Valor { get; set; }

        public Inventarios()
        {
            Id = 0;
            Valor = 0;
        }

    }
}
