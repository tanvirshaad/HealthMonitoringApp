using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class TrendDTO
    {
        //list of currentValues
        public List<decimal> CurrentValues { get; set; }
        //list of metric types
        public List<string> MetricTypes { get; set; }
        //list of average values
        public List<decimal> AvgValues { get; set; }
        //list of max values
        public List<decimal> MaxValues { get; set; }
        //list of min values
        public List<decimal> MinValues { get; set; }

    }
}
