using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.TableModels
{
    public class HealthMetrics
    {
        public int Id { get; set; }
        public virtual User User { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
        public string MetricType { get; set; }
        public decimal Value { get; set; }
        public string Unit { get; set; }
        public DateTime DateRecorded { get; set; }
    }
}
