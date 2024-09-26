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
        public int Weight { get; set; }
        public int SyBP { get; set; }
        public int DiBP { get; set; }
        public DateTime DateRecorded { get; set; }
    }
}
