using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using EntitiFrameworkProject1;

namespace ObjectWCF
{

        [ServiceContract]
        interface InterfaceWCF
        {
            [OperationContract]
            void CreateMedia(string type, string place, string path);

            [OperationContract]
            List<string> GetMediaByPersonName(string name, string type);

            [OperationContract]
            List<string> GetMediaByLocation(string type, string place);

            [OperationContract]
            void AddPersonToMedia(string name, string path);

            [OperationContract]
            void RemoveMedia(string path);

        }

        [ServiceContract]
        interface IMediaPerson : InterfaceWCF
    {

        }
}
