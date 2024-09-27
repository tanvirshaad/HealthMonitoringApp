using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.EF.TableModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class HealthMetricsService
    {
        static Mapper GetMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<HealthMetrics, HealthMetricsDTO>();
                cfg.CreateMap<HealthMetricsDTO, HealthMetrics>();
            });
            return new Mapper(config);
        }

        public static bool Create(HealthMetricsDTO obj)
        {
            var data = GetMapper().Map<HealthMetrics>(obj);
            
            data.DateRecorded = DateTime.Now;
            return DataAccess.HealthMetricsData().Create(data);
        }
        public static List<HealthMetricsDTO> Get()
        {
            var data = DataAccess.HealthMetricsData().Get();
            return GetMapper().Map<List<HealthMetricsDTO>>(data);
        }
        public static HealthMetricsDTO Get(int id)
        {
            var data = DataAccess.HealthMetricsData().Get(id);
            return GetMapper().Map<HealthMetricsDTO>(data);
        }
        //get healthmetric of a single UserId
        public static HealthMetricsDTO GetByUserId(int id)
        {
            var data = DataAccess.ProgressData().GetByUserId(id);
            return GetMapper().Map<HealthMetricsDTO>(data);
        }

        public static bool Update(HealthMetricsDTO obj)
        {
            var data = GetMapper().Map<HealthMetrics>(obj);
            data.DateRecorded = DateTime.Now;
            return DataAccess.HealthMetricsData().Update(data);
        }
        public static bool Delete(int id)
        {
            return DataAccess.HealthMetricsData().Delete(id);
        }
    }
}
