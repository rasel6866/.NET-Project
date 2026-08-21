using AutoMapper;
using BLL.DTOs;
using DAL.EF.Tables;

namespace BLL
{
    public class MapperConfig
    {
        public static MapperConfiguration config = new MapperConfiguration(cfg => {

            cfg.CreateMap<User, UserDTO>().ReverseMap();

            cfg.CreateMap<Donor, DonorDTO>().ReverseMap();

            cfg.CreateMap<BloodStock, BloodStockDTO>().ReverseMap();

            cfg.CreateMap<BloodRequest, BloodRequestDTO>().ReverseMap();

        });

        public static Mapper GetMapper()
        {
            return new Mapper(config);
        }
    }
}