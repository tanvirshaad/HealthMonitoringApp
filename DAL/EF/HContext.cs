using DAL.EF.TableModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF
{
    public class HContext: DbContext
    {
        public DbSet<HealthMetrics> HealthMetrics { get; set; }
        public DbSet<HealthGoals> HealthGoals { get; set; }
        public DbSet<SharedData> SharedData { get; set; }
        public DbSet<HealthDevice> HealthDevice { get; set; }
        public DbSet<User> User { get; set; }
    }
    
}
