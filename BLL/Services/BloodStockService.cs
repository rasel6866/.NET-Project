using AutoMapper;
using BLL.DTOs;
using DAL.EF.Tables;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Services
{
    public class BloodStockService
    {
        BloodStockRepo repo;
        Mapper mapper;

        public BloodStockService(BloodStockRepo repo)
        {
            this.repo = repo;
            mapper = MapperConfig.GetMapper();
        }

        public List<BloodStockDTO> Get()
        {
            var data = repo.Get();
            var res = mapper.Map<List<BloodStockDTO>>(data);
            return res;
        }

        public BloodStockDTO Get(int id)
        {
            var data = repo.Get(id);
            var res = mapper.Map<BloodStockDTO>(data);
            return res;
        }

        public bool Create(BloodStockDTO b)
        {
            var data = mapper.Map<BloodStock>(b);
            var res = repo.Create(data);
            return res;
        }

        public bool Update(BloodStockDTO b)
        {
            var data = mapper.Map<BloodStock>(b);
            var res = repo.Update(data);
            return res;
        }

        public bool Delete(int id)
        {
            return repo.Delete(id);
        }
    }
}