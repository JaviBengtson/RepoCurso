using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace BengtsonWCF
{
    public class Service1 : IService1
    {      

        public User GetUser(int userId) 
        {
            return new User
            {
                Nombre = "Nose",
                Apellido = "Martinez"

            };
        }

	
	}
}
