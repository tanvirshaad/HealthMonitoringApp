using AutoMapper;
using BLL.DTOs;
using DAL.EF.TableModels;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class HealthDeviceService
    {
        static Mapper GetMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<HealthDevice, HealthDeviceDTO>();
                cfg.CreateMap<HealthDeviceDTO, HealthDevice>();
            });
            return new Mapper(config);
        }

        public static bool Create(HealthDeviceDTO obj)
        {
            var data = GetMapper().Map<HealthDevice>(obj);
            data.DeviceAddedDate = DateTime.Now;
            return DataAccess.HealthDeviceData().Create(data);
        }
        public static List<HealthDeviceDTO> Get()
        {
            var data = DataAccess.HealthDeviceData().Get();
            return GetMapper().Map<List<HealthDeviceDTO>>(data);
        }
        public static HealthDeviceDTO Get(int id)
        {
            var data = DataAccess.HealthDeviceData().Get(id);
            return GetMapper().Map<HealthDeviceDTO>(data);
        }
        public static bool Update(HealthDeviceDTO obj)
        {
            var data = GetMapper().Map<HealthDevice>(obj);
            data.DeviceAddedDate = DateTime.Now;
            return DataAccess.HealthDeviceData().Update(data);
        }
        public static bool Delete(int id)
        {
            return DataAccess.HealthDeviceData().Delete(id);
        }
    }
}
