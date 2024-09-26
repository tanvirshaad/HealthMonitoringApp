using DAL.EF.TableModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class SharedDataDTO
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Provider { get; set; }
        public DateTime DateShared { get; set; }
    }
}
