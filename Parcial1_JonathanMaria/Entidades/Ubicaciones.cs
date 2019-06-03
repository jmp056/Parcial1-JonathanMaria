using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1_JonathanMaria.Entidades
{
    public class Ubicaciones
    {
        [Key]
        public int IdUbicacion { get; set; }
        public string Ubicacion { get; set; }

        public Ubicaciones()
        {
            IdUbicacion = 0;
            Ubicacion = string.Empty;
        }
    }
}
