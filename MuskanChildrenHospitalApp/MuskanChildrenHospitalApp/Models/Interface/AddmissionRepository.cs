using MuskanChildrenHospitalApp.Data;
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


        public Addmision Add(Addmision addmision)
        {
            _context.Addmisions.Add(addmision);
            _context.SaveChanges();
            return addmision;
            
        }

        public Addmision Delete(int id)
        {
          Addmision addmision=  _context.Addmisions.Find(id);

            if(addmision != null)
            {
                _context.Addmisions.Remove(addmision);
                _context.SaveChanges();
            }
            return addmision;
        }

        public Addmision GetAddmision(int id)
        {
            Addmision addmision = _context.Addmisions.Find(id);
            return addmision;
        }

        public IEnumerable<Addmision> GetAddmisions()
        {
            return _context.Addmisions;
        }

        public Addmision Update(Addmision addmisionChanges)
        {
            var addmision = _context.Addmisions.Attach(addmisionChanges);
            addmision.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();

            return addmisionChanges;
        }
    }
}
