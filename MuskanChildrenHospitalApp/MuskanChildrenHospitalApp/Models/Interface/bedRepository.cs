using MuskanChildrenHospitalApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MuskanChildrenHospitalApp.Models.Interface
{
    public class bedRepository : IbedRepository
    {
        private readonly ApplicationDbContext context;

        public bedRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public Bed Add(Bed bed)
        {
            context.Beds.Add(bed);
            context.SaveChanges();
            return bed;
        }

        public Bed Delete(int id)
        {
            Bed bed = context.Beds.Find(id);

            if (bed != null)
            {
                context.Beds.Remove(bed);
                context.SaveChanges();
            }
            return bed;
        }

        public Bed GetBed(int bed)
        {
            Bed beds = context.Beds.Find(bed);
            return beds;
        }

        public IEnumerable<Bed> GetBeds()
        {
            return context.Beds;
        }

        public Bed Update(Bed BedChanges)
        {
            var bed = context.Beds.Attach(BedChanges);
            bed.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();

            return BedChanges;
        }
    }
}
