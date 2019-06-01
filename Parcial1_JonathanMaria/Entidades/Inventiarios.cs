using System.ComponentModel.DataAnnotations;

namespace Parcial1_JonathanMaria.Entidades
{
    public class Inventarios
    {
        [Key]
        int Id;
        float Valor;

        Inventarios()
        {
            Id = 0;
            Valor = 0;
        }

    }
}
