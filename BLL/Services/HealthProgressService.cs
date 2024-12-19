using BLL.DTOs;
using DAL;
using DAL.EF.TableModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class HealthProgressService
    {
        //public static HealthProgressDTO GetProgress(int id)
        //{
        //    var metrics = DataAccess.ProgressData().GetAllByUserId(id).OrderBy(m => m.DateRecorded).ToList();
        //    var goals = DataAccess.HealthGoalsProgress().GetAllByUserId(id);

        //    if (metrics == null || goals == null)
        //    {
        //        return null;
        //    }

        //    var progress = new HealthProgressDTO();

        //    // Group metrics by their type
        //    var groupedMetrics = metrics.GroupBy(m => m.MetricType);

        //    foreach (var group in groupedMetrics)
        //    {
        //        var metricType = group.Key;
        //        var metricList = group.OrderBy(m => m.DateRecorded).ToList();
        //        var initialMetric = metricList.FirstOrDefault();
        //        var latestMetric = metricList.LastOrDefault();

        //        if (initialMetric == null || latestMetric == null)
        //        {
        //            continue;
        //        }

        //        var goal = goals.FirstOrDefault(g => g.GoalType == metricType);
        //        if (goal == null)
        //        {
        //            continue;
        //        }

        //        var upValue = (decimal)(initialMetric.Value - latestMetric.Value);
        //        var downValue = (decimal)(initialMetric.Value - goal.TargetValue);
        //        decimal progressValue = 0;

        //        if (upValue != 0 && downValue != 0)
        //        {
        //            progressValue = (upValue / downValue) * 100;
        //        }

        //        // Dynamically set the progress value based on the metric type
        //        SetProgressValue(progress, metricType, progressValue);
        //    }

        //    return progress;
        //}

        ////write the setProgressValue method here
        //private static void SetProgressValue(HealthProgressDTO progress, string metricType, decimal progressValue)
        //{
        //    // Use reflection to set the progress value based on the metric type
        //    var propertyName = $"{metricType}Progress";
        //    var property = typeof(HealthProgressDTO).GetProperty(propertyName, BindingFlags.Public | BindingFlags.Instance);

        //    if (property != null && property.PropertyType == typeof(decimal))
        //    {
        //        property.SetValue(progress, progressValue);
        //    }
        //}
        public static HealthProgressDTO GetProgress(string metricType, int id)
        {
            var goals = DataAccess.HealthGoalsProgress().GetAllByUserId(id);
            var goalMetric = goals.FirstOrDefault(g => g.GoalType == metricType);
            if(goalMetric == null)
            {
                return null;
            }
            var progress = new HealthProgressDTO();
            var metrics = DataAccess.ProgressData().GetAllByUserId(id).Where(m => m.MetricType == metricType).OrderBy(m => m.DateRecorded).ToList();
            if (metrics == null)
            {
                return null;
            }
            var initialMetric = metrics.FirstOrDefault();
            var latestMetric = metrics.LastOrDefault();
            if (initialMetric == null || latestMetric == null)
            {
                return null;
            }
            var upValue = (decimal)(initialMetric.Value - latestMetric.Value);
            var downValue = (decimal)(initialMetric.Value - goalMetric.TargetValue);
            decimal progressValue = 0;
            if (upValue != 0 && downValue != 0)
            {
                progressValue = (upValue / downValue) * 100;
            }
            progress.MetricType = metricType;
            progress.ProgressValue = progressValue;
            return progress;
        }

    }
}

