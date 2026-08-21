using AutoMapper;
using BLL.DTOs;
using DAL.EF.Tables;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Services
{
    public class DonorService
    {
        DonorRepo repo;
        Mapper mapper;
        public DonorService(DonorRepo repo)
        {
            this.repo = repo;
            mapper = MapperConfig.GetMapper();
        }
        public List<DonorDTO> Get()
        {
            var data = repo.Get();
            var res = mapper.Map<List<DonorDTO>>(data);
            return res;
        }
        public DonorDTO Get(int id)
        {
            var data = repo.Get(id);
            var res = mapper.Map<DonorDTO>(data);
            return res;
        }
        public bool Create(DonorDTO d)
        {
            var data = mapper.Map<Donor>(d);
            var res = repo.Create(data);
            return res;
        }
        public bool Update(DonorDTO d)
        {
            var data = mapper.Map<Donor>(d);
            var res = repo.Update(data);
            return res;
        }
        public bool Delete(int id)
        {
            return repo.Delete(id);
        }
    }
}