using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiFrameworkProject1;
using EntitiFrameworkProject1.API;

namespace ObjectWCF
{

    public class AppService : IMediaPerson
    {
       APIController _controller = new APIController();

        public AppService() { }

        void InterfaceWCF.CreateMedia(string type,string place, string path)
        {
            _controller.CreateMedia(type, place, path);
        }

        List<string> InterfaceWCF.GetMediaByPersonName(string name,string type)
        {
            return _controller.GetMediaByPersonName(name, type);
        }

        List<string> InterfaceWCF.GetMediaByLocation(string type, string place)
        {
            return _controller.GetMediaByLocation(type, place);
        }
        void InterfaceWCF.AddPersonToMedia(string name, string path)
        {
            _controller.AddPersonToMedia(name, path);
        }

        void InterfaceWCF.RemoveMedia(string path)
        {
            _controller.RemoveMedia(path);
        }

    }
}
