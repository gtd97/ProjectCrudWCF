using Autofac;
using Autofac.Integration.Wcf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wcf.Common.Module;
using Wcf.Repository.Model;
using WcfData;

namespace Wcf.Repository
{
    public class Repository : IService
    {
        ProjectCrudWcfEntities db;

        public Repository()
        {
            IContainer container = ModuleWcf.BuildContainer();
            AutofacHostFactory.Container = container;

            db = new ProjectCrudWcfEntities();
        }


        public List<Alumno> GetAll()
        {
            List<Alumno> listaAlumnos = db.Alumno.ToList();

            return listaAlumnos;
        }


        public Alumno GetByGuid(Guid guid)
        {
            Alumno alumno = db.Alumno.Where(x => x.Guid == guid).FirstOrDefault();

            return alumno;
        }


        public Alumno Post(Alumno alumno)
        {
            db.Alumno.Add(alumno);
            db.SaveChanges();

            Alumno alumnoInsertado = db.Alumno.Where(x => x.Guid == alumno.Guid).FirstOrDefault();

            return alumnoInsertado;
        }


        public Alumno Put(Guid guid, Alumno alumno)
        {
            try
            {
                Alumno alumnoEncontrado = db.Alumno.Where(x => x.Guid == guid).FirstOrDefault();

                alumnoEncontrado.Guid = alumno.Guid;
                alumnoEncontrado.Nombre = alumno.Nombre;
                alumnoEncontrado.Apellidos = alumno.Apellidos;
                alumnoEncontrado.Dni = alumno.Dni;

                db.SaveChanges();

                return GetByGuid(alumno.Guid);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public bool Delete(Guid guid)
        {
            try
            {
                Alumno alumno = db.Alumno.Where(x => x.Guid == guid).FirstOrDefault();

                db.Alumno.Remove(alumno);
                db.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
