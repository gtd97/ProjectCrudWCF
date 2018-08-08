using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WcfRepository.Model;

namespace WcfRepository
{
    [ServiceContract]
    public interface IRepository
    {
        [OperationContract]
        List<Alumno> GetAll();

        [OperationContract]
        Alumno GetByGuid(Guid guid);

        [OperationContract]
        Alumno Post(Alumno alumno);

        [OperationContract]
        Alumno Put(Guid guid, Alumno alumno);

        [OperationContract]
        bool Delete(Guid guid);
    }
}
