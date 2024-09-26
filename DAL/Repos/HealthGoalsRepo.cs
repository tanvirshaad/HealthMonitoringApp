using DAL.EF.TableModels;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class HealthGoalsRepo: Repo, IRepo<HealthGoals, int, bool>
    {
        public bool Create(HealthGoals obj)
        {
            db.HealthGoals.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var data = Get(id);
            db.HealthGoals.Remove(data);
            return db.SaveChanges() > 0;
        }

        public List<HealthGoals> Get()
        {
            return db.HealthGoals.ToList();
        }

        public HealthGoals Get(int id)
        {
            return db.HealthGoals.Find(id);
        }

        public bool Update(HealthGoals obj)
        {
            var exobj = Get(obj.Id);
            db.Entry(exobj).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }
    }
}
