using Parcial1_JonathanMaria.DAL;
using Parcial1_JonathanMaria.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace Parcial1_JonathanMaria.BLL
{
    public class ProductosBLL
    {
        public static bool Guardar(Productos producto)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                if (db.Productos.Add(producto) != null)
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

        public static bool Modificar(Productos producto)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                var Anterior = db.Productos.Find(producto.ProductoId);
                foreach (var item in Anterior.Precios)
                {
                    if (!producto.Precios.Exists(d => d.PrecioId == item.PrecioId))
                        db.Entry(item).State = EntityState.Deleted;
                }
                db.Entry(producto).State = EntityState.Modified;
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


        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                var eliminar = db.Productos.Find(id);
                db.Entry(eliminar).State = EntityState.Deleted;
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

        public static Productos Buscar (int id)
        {
            Contexto db = new Contexto();
            Productos producto = new Productos();
            try
            {
                producto = db.Productos.Find(id);
                producto.Precios.Count();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return producto;
        }

        public static List<Productos> GetList(Expression<Func<Productos, bool>> producto)
        {
            List<Productos> Lista = new List<Productos>();
            Contexto db = new Contexto();
            try
            {
                Lista = db.Productos.Where(producto).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return Lista;
        }
    }
}
