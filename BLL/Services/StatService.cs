using BLL.DTOs;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class StatService
    {
        public static StatDTO GetStats(int id)
        {
            var metrics = DataAccess.ProgressData().GetAllByUserId(id);
            metrics = metrics.OrderBy(m => m.DateRecorded).ToList();
            
            var stats = new StatDTO
            {
                MetricType = new List<string>(),
                MetricValue = new List<decimal>(),
                DateList = new List<DateTime>()
            };

            metrics.ForEach(metric =>
            {
                stats.MetricType.Add(metric.MetricType);
                stats.MetricValue.Add(metric.Value);
                stats.DateList.Add(metric.DateRecorded);
            });

            return stats;
        }
    }
}
