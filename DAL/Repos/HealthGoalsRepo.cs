using DAL.EF.TableModels;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class HealthGoalsRepo : Repo, IRepo<HealthGoals, int, bool>, IRepoNew<HealthGoals, int>
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
        //get healthgoals of a specific UserId
        public HealthGoals GetByUserId(int id)
        {
            return db.HealthGoals.SingleOrDefault(x => x.UserId.Equals(id));

        }
        //get all the healthgoals of a specific UserId
        public List<HealthGoals> GetAllByUserId(int id)
        {
            return db.HealthGoals.Where(x => x.UserId.Equals(id)).ToList();
        }
    }
}

