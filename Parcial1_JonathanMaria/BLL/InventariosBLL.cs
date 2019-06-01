using Parcial1_JonathanMaria.DAL;
using Parcial1_JonathanMaria.Entidades;
using System;
using System.Data.Entity;

namespace Parcial1_JonathanMaria.BLL
{
    public class InventariosBLL
    {
        public static bool Nuevo(Inventarios inventario)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                if (db.Inventarios.Add(inventario) != null)
                    paso = db.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return paso;
        }

        public static bool Existente(Inventarios inventario)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                db.Entry(inventario).State = EntityState.Modified;
                paso = (db.SaveChanges() > 0);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return paso;
        }

        public static Inventarios Buscar(int id)
        {
            Contexto db = new Contexto();
           Inventarios inventario = new Inventarios();
            try
            {
                inventario = db.Inventarios.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return inventario;
        }
    }
}
