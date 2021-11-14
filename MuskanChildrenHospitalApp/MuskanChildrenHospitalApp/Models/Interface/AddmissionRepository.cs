using MuskanChildrenHospitalApp.Data;
using MuskanChildrenHospitalApp.Models.Work;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MuskanChildrenHospitalApp.Models.Interface
{
    public class AddmissionRepository : IAdmissionRepositoy
    {
        private readonly ApplicationDbContext _context;
        private readonly IbedRepository ibedContext;
        private readonly IRoomRepository room;

        public AddmissionRepository(ApplicationDbContext context, IbedRepository ibedContext, IRoomRepository room) 
        {
            this._context = context;
            this.ibedContext = ibedContext;
            this.room = room;
        }


        public mkAddmision Add(mkAddmision addmision)
        {
            _context.Addmisions.Add(addmision);
            _context.SaveChanges();
            return addmision;
            
        }

        public mkAddmision Delete(int id)
        {
            mkAddmision addmision =  _context.Addmisions.Find(id);

            if(addmision != null)
            {
                _context.Addmisions.Remove(addmision);
                _context.SaveChanges();
            }
            return addmision;
        }

        public mkAddmision GetAddmision(int id)
        {
            mkAddmision addmision = _context.Addmisions.Find(id);
            return addmision;
        }

        public IEnumerable<mkAddmision> GetAddmisions()
        {
            //return _context.Addmisions.Join(_context.Patients, p=>p.PatientId, a=> a.id, (p,a)=> new {
            //    a.Name,p.DateOfDischarge,p.DateOfAddmission,p.RegNo,p.IsDischarge
            //}).ToList();

            return _context.Addmisions;
        }

        public mkAddmision Update(mkAddmision addmisionChanges)
        {
            var addmision = _context.Addmisions.Attach(addmisionChanges);
            addmision.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();

            return addmisionChanges;
        }
    }
}
