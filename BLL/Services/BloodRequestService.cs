using AutoMapper;
using BLL.DTOs;
using DAL.EF.Tables;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Services
{
    public class BloodRequestService
    {
        BloodRequestRepo repo;
        Mapper mapper;

        public BloodRequestService(BloodRequestRepo repo)
        {
            this.repo = repo;
            mapper = MapperConfig.GetMapper();
        }

        public List<BloodRequestDTO> Get()
        {
            var data = repo.Get();
            var res = mapper.Map<List<BloodRequestDTO>>(data);
            return res;
        }

        public BloodRequestDTO Get(int id)
        {
            var data = repo.Get(id);
            var res = mapper.Map<BloodRequestDTO>(data);
            return res;
        }

        public bool Create(BloodRequestDTO b)
        {
            var data = mapper.Map<BloodRequest>(b);
            var res = repo.Create(data);
            return res;
        }

        public bool Update(BloodRequestDTO b)
        {
            var data = mapper.Map<BloodRequest>(b);
            var res = repo.Update(data);
            return res;
        }

        public bool Delete(int id)
        {
            return repo.Delete(id);
        }
    }
}