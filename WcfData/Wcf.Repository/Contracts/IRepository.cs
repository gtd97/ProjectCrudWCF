using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Wcf.Repository.Model;

namespace WcfData
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IService
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
