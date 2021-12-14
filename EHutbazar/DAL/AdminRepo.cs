using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AdminRepo : IRepository<Admin, int>
    {
        EhutBazardbEntities db;
        public AdminRepo(EhutBazardbEntities db)
        {
            this.db = db;
        }

        

        public Admin Get(int id)
        {
            return db.Admins.FirstOrDefault(e => e.Admin_Id == id);

        }

        public List<Admin> GetAll()
        {
            return db.Admins.ToList();
        }

        public void Insert(Admin entity)
        {
            db.Admins.Add(entity);
            db.SaveChanges();
        }

        public void Upadte(Admin entity)
        {
            var s = db.Admins.FirstOrDefault(en => en.Admin_Id == entity.Admin_Id);
            db.Entry(s).CurrentValues.SetValues(entity);
            db.SaveChanges();
        }
        public void Delete(int id)
        {
            var s = db.Admins.FirstOrDefault(e => e.Admin_Id == id);
            db.Admins.Remove(s);
            db.SaveChanges();
        }
    }
}
