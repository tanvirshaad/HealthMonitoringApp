using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;

namespace DAL.EF.TableModels
{
    public class User
    {
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "VARCHAR")]
        [StringLength(10)]
        public string Username { get; set; }
        [Required]
        [Column(TypeName = "VARCHAR")]
        [StringLength(10)]
        public string Password { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }

        //one to one relationship with HealthGoals
        /*public HealthGoals HealthGoals { get; set; }*/
        //one to many relationship with HealthMetrics
        public ICollection<HealthMetrics> HealthMetrics { get; set; }
        //one to many relationship with HealthDevices
        public ICollection<HealthDevice> HealthDevices { get; set; }
        //one to many relationship with SharedData
        public ICollection<SharedData> SharedDatas { get; set; }
        public User() { 
            HealthMetrics = new List<HealthMetrics>();
            HealthDevices = new List<HealthDevice>();
            SharedDatas = new List<SharedData>();
        }

    }
}
