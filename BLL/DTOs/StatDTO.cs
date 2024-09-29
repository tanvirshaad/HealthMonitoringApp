using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class StatDTO
    {
       
        
        //list of weight
        public List<int> WeightList { get; set; }
        //list of systolic blood pressure
        public List<int> SystolicBPList { get; set; }
        //list of diastolic blood pressure
        public List<int> DiastolicBPList { get; set; }
        // list of dates
        public List<DateTime> DateList { get; set; }

    }
}
