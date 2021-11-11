using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MuskanChildrenHospitalApp.Models.Interface
{
    public interface IAdmissionRepositoy
    {
        Addmision GetAddmision(int id);

        IEnumerable<Addmision> GetAddmisions();

        Addmision Add(Addmision addmision);
        Addmision Update(Addmision addmisionChanges);
        Addmision Delete(int id);
    }
}
