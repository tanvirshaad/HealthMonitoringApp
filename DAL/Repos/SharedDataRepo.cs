using DAL.EF.TableModels;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class SharedDataRepo: Repo, IRepo<SharedData, int, bool>
    {
        public bool Create(SharedData obj)
        {
            db.SharedData.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var data = Get(id);
            db.SharedData.Remove(data);
            return db.SaveChanges() > 0;
        }

        public List<SharedData> Get()
        {
            return db.SharedData.ToList();
        }

        public SharedData Get(int id)
        {
            return db.SharedData.Find(id);
        }

        public bool Update(SharedData obj)
        {
            var exobj = Get(obj.Id);
            db.Entry(exobj).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }
    }
}
