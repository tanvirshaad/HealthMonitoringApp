using DAL.EF.TableModels;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class HealthDeviceRepo : Repo, IRepo<HealthDevice, int, bool>
    {
        public bool Create(HealthDevice obj)
        {
            db.HealthDevice.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var data = Get(id);
            db.HealthDevice.Remove(data);
            return db.SaveChanges() > 0;
        }

        public List<HealthDevice> Get()
        {
            return db.HealthDevice.ToList();
        }

        public HealthDevice Get(int id)
        {
            return db.HealthDevice.Find(id);
        }

        public bool Update(HealthDevice obj)
        {
            var exobj = Get(obj.Id);
            db.Entry(exobj).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }
    }
}
