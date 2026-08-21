using DAL.EF;
using DAL.EF.Tables;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repos
{
    public class DonorRepo
    {
        DbBloodContext db;
        public DonorRepo(DbBloodContext db)
        {
            this.db = db;
        }
        public bool Create(Donor d)
        {
            db.Donors.Add(d);
            return db.SaveChanges() > 0;
        }
        public List<Donor> Get()
        {
            return db.Donors.ToList();
        }
        public Donor Get(int id)
        {
            return db.Donors.Find(id);
        }
        public bool Update(Donor d)
        {
            var exobj = Get(d.Id);
            db.Entry(exobj).CurrentValues.SetValues(d);
            return db.SaveChanges() > 0;
        }
        public bool Delete(int id)
        {
            var exobj = Get(id);
            db.Donors.Remove(exobj);
            return db.SaveChanges() > 0;
        }
    }
}
    

