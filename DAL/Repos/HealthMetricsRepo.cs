using DAL.EF.TableModels;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class HealthMetricsRepo : Repo, IRepo<HealthMetrics, int, bool>
    {
        public bool Create(HealthMetrics obj)
        {
            db.HealthMetrics.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var data = Get(id);
            db.HealthMetrics.Remove(data);
            return db.SaveChanges() > 0;
        }

        public List<HealthMetrics> Get()
        {
            return db.HealthMetrics.ToList();
        }

        public HealthMetrics Get(int id)
        {
            return db.HealthMetrics.Find(id);
        }

        public bool Update(HealthMetrics obj)
        {
            var exobj = Get(obj.Id);
            db.Entry(exobj).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }
    }
}
