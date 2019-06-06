using Parcial1_JonathanMaria.DAL;
using Parcial1_JonathanMaria.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace Parcial1_JonathanMaria.BLL
{
    public class UbicacionesBLL
    {
        public static bool Guardar(Ubicaciones ubicacion)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                if (db.Ubicaciones.Add(ubicacion) != null)
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

        public static bool Modificar(Ubicaciones ubicacion)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                db.Entry(ubicacion).State = EntityState.Modified;
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
                var eliminar = db.Ubicaciones.Find(id);
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

        public static Ubicaciones Buscar(int id)
        {
            Contexto db = new Contexto();
            Ubicaciones ubicacion = new Ubicaciones();
            try
            {
                ubicacion = db.Ubicaciones.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return ubicacion;
        }

        public static bool Existe(string descipcion)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                if (db.Ubicaciones.Any(p => p.Descripcion.Equals(descipcion)))
                    paso = true;
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

        public static List<Ubicaciones> GetList(Expression<Func<Ubicaciones, bool>> ubicacion)
        {
            List<Ubicaciones> Lista = new List<Ubicaciones>();
            Contexto db = new Contexto();
            try
            {
                Lista = db.Ubicaciones.Where(ubicacion).ToList();
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
