using BLL.DTOs;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class StatService
    {
        public static StatDTO GetStats(int id)
        {
            var metrics = DataAccess.ProgressData().GetAllByUserId(id);
            
            var latestMetrics = metrics.OrderByDescending(m => m.DateRecorded).FirstOrDefault();
            var weightList = metrics.Select(m => m.Weight).ToList();
            var systolicBPList = metrics.Select(m => m.SyBP).ToList();
            var diastolicBPList = metrics.Select(m => m.DiBP).ToList();
            var dateList = metrics.Select(m => m.DateRecorded).ToList();


            var stats = new StatDTO
            {
                
                WeightList = weightList,
                SystolicBPList = systolicBPList,
                DiastolicBPList = diastolicBPList,
                DateList = dateList
            };

            return stats;
        }
    }
}
