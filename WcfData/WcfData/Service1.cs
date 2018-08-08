using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfRepository;
using WcfRepository.Model;

namespace WcfData
{ 
    public class Service1 : IService1
    {
        private IRepository repo;
        
        public Service1(IRepository repo)
        {
            this.repo = repo;
        }


        public List<Alumno> GetAll()
        {
            List<Alumno> listaAlumnos = repo.GetAll();

            return listaAlumnos;
        }


        public Alumno GetByGuid(Guid guid)
        {
            Alumno alumno = repo.GetByGuid(guid);
            
            return alumno;
        }


        public Alumno Post(Alumno alumno)
        {
            Alumno alumnoInsertado = repo.Post(alumno);

            return alumnoInsertado;
        }


        public Alumno Put(Guid guid, Alumno alumno)
        {
            try
            {
                Alumno alumnoEncontrado = repo.Put(guid, alumno);

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
                bool alumno = repo.Delete(guid);
                
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
