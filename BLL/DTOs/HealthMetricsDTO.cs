using DAL.EF.TableModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class HealthMetricsDTO
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string MetricType { get; set; }
        public decimal Value { get; set; }
        public string Unit { get; set; }
        public DateTime DateRecorded { get; set; }

    }
}
