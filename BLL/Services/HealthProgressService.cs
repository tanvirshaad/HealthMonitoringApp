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
            var metrics = DataAccess.ProgressData().GetByUserId(id);
            var goals = DataAccess.HealthGoalsProgress().GetByUserId(id);

            if (metrics == null || goals == null)
            {
                return null;
            }
            //needs to be changed to a more accurate formula
            var progress = new HealthProgressDTO
            {
                WeightProgress = ((goals.TargetWeight - metrics.Weight ) /metrics.Weight) * 100,
                SystolicBPProgress = (goals.TargetSyBP / metrics.SyBP ) * 100,
                DiastolicBPProgress = (goals.TargetDiBP / metrics.DiBP) * 100
            };
            return progress;
        }
    }
}
