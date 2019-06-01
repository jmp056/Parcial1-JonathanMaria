using Parcial1_JonathanMaria.Entidades;
using ProyectoParcial1.Entidades;
using System.Data.Entity;

namespace Parcial1_JonathanMaria.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Productos> Productos { get; set; }
        public DbSet<ValorTotalDeInventario> ValorTotalDeInventario { get; set; }
        public Contexto() : base("ConStr")
        {   }
    }
}
