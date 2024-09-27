using DAL.EF.TableModels;
using DAL.Interfaces;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccess
    {
        public static IRepo<User, int, bool> UserData()
        {
            return new UserRepo();
        }
        public static IRepo<HealthMetrics, int, bool> HealthMetricsData()
        {
            return new HealthMetricsRepo();
        }
        public static IRepo<HealthGoals, int, bool> HealthGoalsData()
        {
            return new HealthGoalsRepo();
        }
        public static IRepo<SharedData, int, bool> SharedData()
        {
            return new SharedDataRepo();
        }
        public static IRepo<HealthDevice, int, bool> HealthDeviceData()
        {
            return new HealthDeviceRepo();
        }
        public static IAuth AuthData()
        {
           return new UserRepo();
        }  
        
        public static IRepoNew<HealthMetrics, int> ProgressData()
        {
            return new HealthMetricsRepo();
        }
        public static IRepoNew<HealthGoals, int> HealthGoalsProgress()
        {
            return new HealthGoalsRepo();
        }
    }
}
