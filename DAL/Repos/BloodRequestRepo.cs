using DAL.EF;
using DAL.EF.Tables;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repos
{
    public class BloodRequestRepo
    {
        DbBloodContext db;
        public BloodRequestRepo(DbBloodContext db)
        {
            this.db = db;
        }
        public bool Create(BloodRequest b)
        {
            db.BloodRequests.Add(b);
            return db.SaveChanges() > 0;
        }
        public List<BloodRequest> Get()
        {
            return db.BloodRequests.ToList();
        }
        public BloodRequest Get(int id)
        {
            return db.BloodRequests.Find(id);
        }
        public bool Update(BloodRequest b)
        {
            var exobj = Get(b.Id);
            db.Entry(exobj).CurrentValues.SetValues(b);
            return db.SaveChanges() > 0;
        }
        public bool Delete(int id)
        {
            var exobj = Get(id);
            db.BloodRequests.Remove(exobj);
            return db.SaveChanges() > 0;
        }
    }
}