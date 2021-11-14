using MuskanChildrenHospitalApp.Models.Work;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MuskanChildrenHospitalApp.Models.Interface
{
    public interface IPatientRepository
    {
        Patient GetPatient(int id);

        IEnumerable<Patient> GetPatients();

        Patient Add(Patient patient);
        Patient Update(Patient PatientChanges);
        Patient Delete(int id);
    }
}
