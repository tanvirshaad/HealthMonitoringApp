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
    public class HealthGoalsService
    {
        static Mapper GetMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<HealthGoals, HealthGoalsDTO>();
                cfg.CreateMap<HealthGoalsDTO, HealthGoals>();
            });
            return new Mapper(config);
        }

        public static bool Create(HealthGoalsDTO obj)
        {
            var data = GetMapper().Map<HealthGoals>(obj);
            data.StartDate = DateTime.Now;
            return DataAccess.HealthGoalsData().Create(data);
        }
        public static List<HealthGoalsDTO> Get()
        {
            var data = DataAccess.HealthGoalsData().Get();
            return GetMapper().Map<List<HealthGoalsDTO>>(data);
        }
        public static HealthGoalsDTO Get(int id)
        {
            var data = DataAccess.HealthGoalsData().Get(id);
            return GetMapper().Map<HealthGoalsDTO>(data);
        }
        public static bool Update(HealthGoalsDTO obj)
        {
            var data = GetMapper().Map<HealthGoals>(obj);
            data.StartDate = DateTime.Now;
            return DataAccess.HealthGoalsData().Update(data);
        }
        public static bool Delete(int id)
        {
            return DataAccess.HealthGoalsData().Delete(id);
        }
    }
}
