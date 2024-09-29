using BLL.DTOs;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class TrendService
    {
        public static TrendDTO GetTrend(int id)
        {
            var metrics = DataAccess.ProgressData().GetAllByUserId(id);
            var avgWeight = (decimal)metrics.Average(m => m.Weight);
            var avgSystolicBP = (decimal)metrics.Average(m => m.SyBP);
            var avgDiastolicBP = (decimal)metrics.Average(m => m.DiBP);
            var maxWeight = metrics.Max(m => m.Weight);
            var minWeight = metrics.Min(m => m.Weight);
            var maxSystolicBP = metrics.Max(m => m.SyBP);
            var minSystolicBP = metrics.Min(m => m.SyBP);
            var maxDiastolicBP = metrics.Max(m => m.DiBP);
            var minDiastolicBP = metrics.Min(m => m.DiBP);
            var latestMetrics = metrics.OrderByDescending(m => m.DateRecorded).FirstOrDefault();

            var trends = new TrendDTO
            {
                CurrentWeight = latestMetrics.Weight,
                CurrentSystolicBP = latestMetrics.SyBP,
                CurrentDiastolicBP = latestMetrics.DiBP,
                AvgWeight = avgWeight,
                AvgSystolicBP = avgSystolicBP,
                AvgDiastolicBP = avgDiastolicBP,
                MaxWeight = maxWeight,
                MinWeight = minWeight,
                MaxSystolicBP = maxSystolicBP,
                MinSystolicBP = minSystolicBP,
                MaxDiastolicBP = maxDiastolicBP,
                MinDiastolicBP = minDiastolicBP
            };

            return trends;
        }
    }
}
