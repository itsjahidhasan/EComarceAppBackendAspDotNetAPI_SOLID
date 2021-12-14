using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using AutoMapper;
using BEL;

namespace BLL
{
    public class AdminService
    {
        public static List<AdminModel> GetAll()
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Admin, AdminModel>();
            });
            var mapper = new Mapper(config);
            var da = DataAccess.AdminDataAccess();
            var data = mapper.Map<List<AdminModel>>(da.GetAll());
            return data;
        }
        
    }
}
