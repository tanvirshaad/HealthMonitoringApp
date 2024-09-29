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
            var upWeight = (decimal)(initialMetrics.Weight - LatestMetrics.Weight);
            var downWeight = (decimal)(initialMetrics.Weight - goals.TargetWeight);
            var upSyBP = (decimal)(initialMetrics.SyBP - LatestMetrics.SyBP);
            var downSyBP = (decimal)(initialMetrics.SyBP - goals.TargetSyBP);
            var upDiBP = (decimal)(initialMetrics.DiBP - LatestMetrics.DiBP);
            var downDiBP = (decimal)(initialMetrics.DiBP - goals.TargetDiBP);
            decimal WeightProgress = 0;
            decimal SystolicBPProgress = 0;
            decimal DiastolicBPProgress = 0;
            if (upWeight != 0 && downWeight != 0)
            {
                WeightProgress = (decimal)(upWeight / downWeight) * 100;
            }
            if (upSyBP != 0 && downSyBP != 0)
            {
                SystolicBPProgress = (decimal)(upSyBP / downSyBP) * 100;
            }
            if (upDiBP != 0 && downDiBP != 0)
            {
                DiastolicBPProgress = (decimal)(upDiBP / downDiBP) * 100;
            }
            

            var progress = new HealthProgressDTO
            {
                WeightProgress = WeightProgress,
                SystolicBPProgress = SystolicBPProgress,
                DiastolicBPProgress = DiastolicBPProgress
            };
            return progress;
        }
    }
}
