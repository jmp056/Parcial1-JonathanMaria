using Parcial1_JonathanMaria.DAL;
using ProyectoParcial1.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoParcial1.BLL
{
    class ValorTotalDeInventarioBLL
    {
        public static bool Guardar(ValorTotalDeInventario valortotaldeinventario)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                if (db.ValorTotalDeInventario.Add(valortotaldeinventario) != null)
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

        public static bool Modificar(ValorTotalDeInventario valortotaldeinventario)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                db.Entry(valortotaldeinventario).State = EntityState.Modified;
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
                var eliminar = db.ValorTotalDeInventario.Find(id);
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
    }
}
