using Parcial1_AP1.DAL;
using Parcial1_AP1.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1_AP1.BLL
{
    public class EvaluacionBLL
    {
        public static bool Guardar(Evaluacion evaluacion)
        {
            Contexto db = new Contexto();
            bool paso = false;

            try
            {
                if (db.Evaluacion.Add(evaluacion) != null)
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

        public static bool Modificar(Evaluacion evaluacion)
        {
            Contexto db = new Contexto();
            bool paso = false;

            try
            {
                db.Entry(evaluacion).State = EntityState.Modified;
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

        public static Evaluacion Buscar(int id)
        {
            Contexto db = new Contexto();
            Evaluacion evaluacion = new Evaluacion();
            

            try
            {
                evaluacion = db.Evaluacion.Find(id); 
                  
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }

            return evaluacion;
        }

        public static bool Eliminar(int id)
        {
            Contexto db = new Contexto();
            Evaluacion evaluacion = new Evaluacion();
            bool paso = false;

            try
            {
                var eliminar = db.Evaluacion.Find(id);
                db.Entry(eliminar).State = EntityState.Deleted;
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

        public static List<Evaluacion> GetList(Expression<Func<Evaluacion, bool>> evaluacion)
        {
            List<Evaluacion> Lista = new List<Evaluacion>();
            Contexto db = new Contexto();

            try
            {
                Lista = db.Evaluacion.Where(evaluacion).ToList();
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
