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
        public int TargetWeight { get; set; }
        public int TargetSyBP { get; set; }
        public int TargetDiBP { get; set; }
        public DateTime StartDate { get; set; }
    }
}
