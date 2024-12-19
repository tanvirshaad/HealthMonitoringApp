using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.TableModels
{
    public class HealthGoals
    {
        
        public int Id { get; set; }
        public virtual User User { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
        public string GoalType { get; set; }
        public decimal TargetValue { get; set; }
        public string Unit { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
