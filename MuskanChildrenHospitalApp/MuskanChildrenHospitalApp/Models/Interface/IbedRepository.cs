using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MuskanChildrenHospitalApp.Models.Interface
{
    public interface IbedRepository
    {
        Bed GetBed(int bed);
        IEnumerable<Bed> GetBeds();
        Bed Add(Bed bed);
        Bed Update(Bed BedChanges);
        Bed Delete(int id);
    }
}
