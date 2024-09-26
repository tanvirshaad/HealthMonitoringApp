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
        public int Weight { get; set; }
        public int SyBP { get; set; }
        public int DiBP { get; set; }
        public DateTime DateRecorded { get; set; }

    }
}
