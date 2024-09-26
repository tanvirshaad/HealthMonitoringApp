﻿using DAL.EF.TableModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class HealthDeviceDTO
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string DeviceName { get; set; }

        public DateTime DeviceAddedDate { get; set; }
    }
}
