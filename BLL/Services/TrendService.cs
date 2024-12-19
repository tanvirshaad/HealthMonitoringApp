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
            var trends = new TrendDTO();
            metrics.ForEach(m =>
            {
                //get the metric types name
                trends.MetricTypes.Add(m.MetricType);
                //get the current value of the metric type
                trends.CurrentValues.Add(m.Value);
                //get the max value of the metric type
                trends.MaxValues.Add(metrics.Where(x => x.MetricType == m.MetricType).Max(x => x.Value));
                //get the min value of the metric type
                trends.MinValues.Add(metrics.Where(x => x.MetricType == m.MetricType).Min(x => x.Value));

                //get average value of current metric type
                trends.AvgValues.Add(metrics.Where(x => x.MetricType == m.MetricType).Average(x => x.Value));
            });

            

            return trends;
        }
    }
}
