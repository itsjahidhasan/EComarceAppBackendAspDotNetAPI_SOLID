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
        public static IRepository<Affiliator, int> AffiliatorDataAccess()
        {
            return new AffiliatorRepo(db);
        }
        public static IRepository<Customer, int> CustomerDataAccess()
        {
            return new CustomerRepo(db);
        }
        public static IRepository<Notice, int> NoticeDataAccess()
        {
            return new NoticeRepo(db);
        }
    }
}
