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
    public class ShopOwnerService
    {
        public static List<ShopOwnerModel> GetAll()
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<ShopOwner, ShopOwnerModel>();
            });
            var mapper = new Mapper(config);
            var da = DataAccess.ShopOwnerDataAccess();
            var data = mapper.Map<List<ShopOwnerModel>>(da.GetAll());
            return data;
        }

    }
    
}
