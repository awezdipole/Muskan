using MuskanChildrenHospitalApp.Data;
using MuskanChildrenHospitalApp.Models.Work;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MuskanChildrenHospitalApp.Models.Interface
{
    public class PatientRepository : IPatientRepository
    {
        private readonly ApplicationDbContext _context;

        public PatientRepository(ApplicationDbContext context)
        {
            this._context = context;
        }
        public Patient Add(Patient patient)
        {
            _context.Patients.Add(patient);
            _context.SaveChanges();
            return patient;
        }

        public Patient Delete(int id)
        {
            Patient patient = _context.Patients.Find(id);
            if (patient != null)
            {
                _context.Patients.Remove(patient);
                _context.SaveChanges();
            }
            return patient;
        }

        public Patient GetPatient(int id)
        {
            Patient patient = _context.Patients.Find(id);
            return patient;
        }

        public IEnumerable<Patient> GetPatients()
        {
            return _context.Patients;
        }

        public Patient Update(Patient PatientChanges)
        {
            var Patints = _context.Patients.Attach(PatientChanges);
            Patints.State= Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return PatientChanges;
        }
    }
}
