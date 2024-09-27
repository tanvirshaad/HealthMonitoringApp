using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class HealthProgressDTO
    {
        public decimal WeightProgress { get; set; }
        public decimal SystolicBPProgress { get; set; }
        public decimal DiastolicBPProgress { get; set; }
    }
}
