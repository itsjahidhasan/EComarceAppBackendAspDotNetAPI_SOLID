using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccess
    {
        static EhutBazardbEntities db;
        static DataAccess()
        {
            db = new EhutBazardbEntities();

        }

        public static IRepository<Admin,int> AdminDataAccess()
        {
            return new AdminRepo(db);
        }
        public static IRepository<ShopOwner, int> ShopOwnerDataAccess()
        {
            return new ShopOwnerRepo(db);
        }

    }
}
