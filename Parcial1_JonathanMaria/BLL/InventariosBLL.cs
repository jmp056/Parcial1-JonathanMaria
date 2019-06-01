using Parcial1_JonathanMaria.DAL;
using Parcial1_JonathanMaria.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoParcial1.BLL
{
    public class InventariosBLL
    {
        public static bool Guardar(Inventarios inventario)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                if (contexto.Inventarios.Add(inventario) != null)
                    paso = contexto.SaveChanges() > 0;

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }

        public static bool Modificar(Inventarios inventario)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Entry(inventario).State = EntityState.Modified;
                paso = (contexto.SaveChanges() > 0);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }

        public static List<Inventarios> GetList(Expression<Func<Inventarios, bool>> inventario)
        {
            List<Inventarios> Lista = new List<Inventarios>();
            Contexto contexto = new Contexto();

            try
            {
                Lista = contexto.Inventarios.Where(inventario).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return Lista;
        }

        public static Inventarios Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Inventarios inventario = new Inventarios();

            try
            {
                inventario = contexto.Inventarios.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return inventario;
        }
    }
}
