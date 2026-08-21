using AutoMapper;
using BLL.DTOs;
using DAL.EF.Tables;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Services
{
    public class UserService
    {
        UserRepo repo;
        Mapper mapper;

        public UserService(UserRepo repo)
        {
            this.repo = repo;
            mapper = MapperConfig.GetMapper();
        }

        public List<UserDTO> Get()
        {
            var data = repo.Get();
            var res = mapper.Map<List<UserDTO>>(data);
            return res;
        }

        public UserDTO Get(int id)
        {
            var data = repo.Get(id);
            var res = mapper.Map<UserDTO>(data);
            return res;
        }

        public bool Create(UserDTO u)
        {
            var data = mapper.Map<User>(u);
            var res = repo.Create(data);
            return res;
        }

        public bool Update(UserDTO u)
        {
            var data = mapper.Map<User>(u);
            var res = repo.Update(data);
            return res;
        }

        public bool Delete(int id)
        {
            return repo.Delete(id);
        }
        public UserDTO Get(string email, string password)
        {
            var data = repo.Get(email, password);

            return mapper.Map<UserDTO>(data);
        }
    }
}