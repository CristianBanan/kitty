using Kitty.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitty.Repositories
{
    public class LocationRepository
    {
        public void Add(Location location)
        {
            using(var db = new LocationDbContext())
            {
                db.locations.Add(location);
                db.SaveChanges();
            }
        }

        public void Update(Location location)
        {
            using (var db = new LocationDbContext())
            {
                db.Entry(location).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void Remove(Location location)
        {
            using (var db = new LocationDbContext())
            {
                db.locations.Remove(location);
                db.SaveChanges();
            }
        }

        public IEnumerable<Location> GetLocations()
        {
            using (var db = new LocationDbContext())
            {
                foreach(var item in db.locations)
                {
                    yield return item;
                }
            }
        }

    }
}
