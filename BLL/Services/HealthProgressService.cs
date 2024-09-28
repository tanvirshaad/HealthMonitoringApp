using BLL.DTOs;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class HealthProgressService
    {
        public static HealthProgressDTO GetProgress(int id)
        {
            var metrics = DataAccess.ProgressData().GetAllByUserId(id).OrderBy(m => m.DateRecorded).ToList();
            var LatestMetrics = metrics.LastOrDefault();
            var initialMetrics = metrics.FirstOrDefault();
            var goals = DataAccess.HealthGoalsProgress().GetByUserId(id);

            if (metrics == null || goals == null)
            {
                return null;
            }
            //needs to be changed to a more accurate formula
            var progress = new HealthProgressDTO
            {
                WeightProgress = ((initialMetrics.Weight - LatestMetrics.Weight) / (initialMetrics.Weight - goals.TargetWeight)) * 100,
                //weightprogress is giving 0.0 as output why?



                /*SystolicBPProgress = (goals.TargetSyBP / metrics.SyBP ) * 100,
                DiastolicBPProgress = (goals.TargetDiBP / metrics.DiBP) * 100*/
                SystolicBPProgress = initialMetrics.Weight
            };
            return progress;
        }
    }
}
