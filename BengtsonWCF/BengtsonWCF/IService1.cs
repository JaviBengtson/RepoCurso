using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace BengtsonWCF
{
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        User GetUser(int value); 

    }

    [DataContract]
    public class User
    {
        [DataMember]
        public string Nombre{ get ;set; }

        [DataMember]
        public string Apellido{get; set;}
    }
}
