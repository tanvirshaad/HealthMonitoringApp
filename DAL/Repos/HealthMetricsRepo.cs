using DAL.EF.TableModels;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class HealthMetricsRepo : Repo, IRepo<HealthMetrics, int, bool>, IRepoNew<HealthMetrics, int>
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
        //get all the healthmetrics of a specific UserId
        public List<HealthMetrics> GetAllByUserId(int id)
        {
            return db.HealthMetrics.Where(x => x.UserId.Equals(id)).ToList();
        }
        //get healthmetric of a specific UserId
        public HealthMetrics GetByUserId(int id)
        {
            return db.HealthMetrics.SingleOrDefault(x => x.UserId.Equals(id));
            
        }
        /*
         var user = db.User.SingleOrDefault(
                x => x.Username.Equals(username) && x.Password.Equals(password)
            );
         */


        public bool Update(HealthMetrics obj)
        {
            var exobj = Get(obj.Id);
            db.Entry(exobj).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }
    }
}

