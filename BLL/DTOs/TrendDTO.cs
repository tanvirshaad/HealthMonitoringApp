using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class TrendDTO
    {
        public int CurrentWeight { get; set; }
        public int CurrentSystolicBP { get; set; }
        public int CurrentDiastolicBP { get; set; }
        public decimal AvgWeight { get; set; }
        public decimal AvgSystolicBP { get; set; }
        public decimal AvgDiastolicBP { get; set; }
        public int MaxWeight { get; set; }
        public int MinWeight { get; set; }
        public int MaxSystolicBP { get; set; }
        public int MinSystolicBP { get; set; }
        public int MaxDiastolicBP { get; set; }
        public int MinDiastolicBP { get; set; }
    }
}
