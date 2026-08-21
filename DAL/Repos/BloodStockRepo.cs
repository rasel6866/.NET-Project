using DAL.EF;
using DAL.EF.Tables;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repos
{
    public class BloodStockRepo
    {
        DbBloodContext db;
        public BloodStockRepo(DbBloodContext db)
        {
            this.db = db;
        }
        public bool Create(BloodStock b)
        {
            db.BloodStocks.Add(b);
            return db.SaveChanges() > 0;
        }
        public List<BloodStock> Get()
        {
            return db.BloodStocks.ToList();
        }
        public BloodStock Get(int id)
        {
            return db.BloodStocks.Find(id);
        }
        public bool Update(BloodStock b)
        {
            var exobj = Get(b.Id);
            db.Entry(exobj).CurrentValues.SetValues(b);
            return db.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var exobj = Get(id);
            db.BloodStocks.Remove(exobj);
            return db.SaveChanges() > 0;
        }
    }
}