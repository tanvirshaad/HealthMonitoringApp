using DAL.EF.TableModels;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class UserRepo: Repo, IRepo<User, int, bool>
    {
        public bool Create(User obj)
        {
            db.User.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var data = Get(id);
            db.User.Remove(data);
            return db.SaveChanges() > 0;
        }

        public List<User> Get()
        {
            return db.User.ToList();
        }

        public User Get(int id)
        {
            return db.User.Find(id);
        }

        public bool Update(User obj)
        {
            var exobj = Get(obj.Id);
            db.Entry(exobj).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }
    }
}
