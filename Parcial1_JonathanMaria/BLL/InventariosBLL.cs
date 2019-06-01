using Parcial1_JonathanMaria.DAL;
using Parcial1_JonathanMaria.Entidades;
using System;
using System.Data.Entity;

namespace Parcial1_JonathanMaria.BLL
{
    class InventariosBLL
    {
        public static bool Guardar(Inventarios inventario)
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

        public static bool Modificar(Inventarios inventario)
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
    }
}
