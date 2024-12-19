using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class StatDTO
    {
       
        

        public List<string> MetricType { get; set; }

        public List<decimal> MetricValue { get; set; }

        public List<DateTime> DateList { get; set; }

    }
}
