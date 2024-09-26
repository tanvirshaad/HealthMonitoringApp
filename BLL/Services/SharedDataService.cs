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
    public class SharedDataService
    {
        static Mapper GetMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<SharedData, SharedDataDTO>();
                cfg.CreateMap<SharedDataDTO, SharedData>();
            });
            return new Mapper(config);
        }

        public static bool Create(SharedDataDTO obj)
        {
            var data = GetMapper().Map<SharedData>(obj);
            return DataAccess.SharedData().Create(data);
        }
        public static List<SharedDataDTO> Get()
        {
            var data = DataAccess.SharedData().Get();
            return GetMapper().Map<List<SharedDataDTO>>(data);
        }
        public static SharedDataDTO Get(int id)
        {
            var data = DataAccess.SharedData().Get(id);
            return GetMapper().Map<SharedDataDTO>(data);
        }
        public static bool Update(SharedDataDTO obj)
        {
            var data = GetMapper().Map<SharedData>(obj);
            return DataAccess.SharedData().Update(data);
        }
        public static bool Delete(int id)
        {
            return DataAccess.SharedData().Delete(id);
        }
    }
}
