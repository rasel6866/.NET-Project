using DAL.EF;
using DAL.EF.Tables;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repos
{
    public class UserRepo
    {
        DbBloodContext db;

        public UserRepo(DbBloodContext db)
        {
            this.db = db;
        }
        public bool Create(User u)
        {
            db.Users.Add(u);
            return db.SaveChanges() > 0;
        }
        public List<User> Get()
        {
            return db.Users.ToList();
        }
        public User? Get(int id)
        {
            return db.Users.Find(id);
        }
        public User? Get(string email, string password)
        {
            return db.Users.FirstOrDefault(x =>
                x.Email.Equals(email) &&
                x.Password.Equals(password));
        }
        public bool Update(User u)
        {
            var exobj = Get(u.Id);
            db.Entry(exobj!).CurrentValues.SetValues(u);
            return db.SaveChanges() > 0;
        }
        public bool Delete(int id)
        {
            var exobj = Get(id);
            db.Users.Remove(exobj!);
            return db.SaveChanges() > 0;
        }
    }
}