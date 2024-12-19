using DAL.EF.TableModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class HealthGoalsDTO
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string GoalType { get; set; }
        public decimal TargetValue { get; set; }
        public string Unit { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
