using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MuskanChildrenHospitalApp.Models.Interface
{
     public interface IserviceRepository
    {
        service GetService(int service);
        IEnumerable<service> GetAllServices();
        service Add(service service);
        service Update(service service);
        service Delete(int id);
    }
}
