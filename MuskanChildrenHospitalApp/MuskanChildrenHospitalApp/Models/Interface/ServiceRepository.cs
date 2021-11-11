using MuskanChildrenHospitalApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MuskanChildrenHospitalApp.Models.Interface
{
    public class ServiceRepository : IserviceRepository
    {
        private readonly ApplicationDbContext _context;

        public ServiceRepository(ApplicationDbContext context)
        {
            this._context = context;
        }
        public service Add(service Xservice)
        {
            _context.Services.Add(Xservice);
            _context.SaveChanges();
            return Xservice;
        }

        public service Delete(int id)
        {
           service s= _context.Services.Find(id);
            if (s != null)
            {
                _context.Remove(s);
                _context.SaveChanges();
            }
            return s;
        }

        public IEnumerable<service> GetAllServices()
        {
            return _context.Services;
        }

        public service GetService(int id)
        {
            service s = _context.Services.Find(id);
            return s;
        }

        public service Update(service UpdateService)
        {
            var s = _context.Services.Attach(UpdateService);
            s.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return UpdateService;
        }
    }
}
