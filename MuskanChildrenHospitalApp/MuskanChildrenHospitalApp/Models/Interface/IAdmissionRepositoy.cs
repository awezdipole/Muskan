using MuskanChildrenHospitalApp.Models.Work;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MuskanChildrenHospitalApp.Models.Interface
{
    public interface IAdmissionRepositoy
    {
        mkAddmision GetAddmision(int id);

        IEnumerable<mkAddmision> GetAddmisions();

        mkAddmision Add(mkAddmision addmision);
        mkAddmision Update(mkAddmision addmisionChanges);
        mkAddmision Delete(int id);
    }
}
