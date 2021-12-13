using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class DataAccess
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

    }
}
