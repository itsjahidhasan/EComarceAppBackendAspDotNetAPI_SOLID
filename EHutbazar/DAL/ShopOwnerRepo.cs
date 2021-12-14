using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ShopOwnerRepo : IRepository<ShopOwner, int>
    {
        EhutBazardbEntities db;
        public ShopOwnerRepo(EhutBazardbEntities db)
        {
            this.db = db;
        }



        public ShopOwner Get(int id)
        {
            return db.ShopOwners.FirstOrDefault(e => e.ShopO_Id == id);

        }

        public List<ShopOwner> GetAll()
        {
            return db.ShopOwners.ToList();
        }

        public void Insert(ShopOwner entity)
        {
            db.ShopOwners.Add(entity);
            db.SaveChanges();
        }

        public void Upadte(ShopOwner entity)
        {
            var s = db.ShopOwners.FirstOrDefault(en => en.ShopO_Id == entity.ShopO_Id);
            db.Entry(s).CurrentValues.SetValues(entity);
            db.SaveChanges();
        }
        public void Delete(int id)
        {
            var s = db.ShopOwners.FirstOrDefault(e => e.ShopO_Id == id);
            db.ShopOwners.Remove(s);
            db.SaveChanges();
        }
    }
}
