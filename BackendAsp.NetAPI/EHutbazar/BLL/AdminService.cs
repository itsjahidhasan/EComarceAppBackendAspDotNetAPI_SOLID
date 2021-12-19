using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEL;
using DAL;
using AutoMapper;

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

        public static AdminModel Get(int id)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Admin, AdminModel>();
            });
            var mapper = new Mapper(config);
            var da = DataAccess.AdminDataAccess();
            var data = mapper.Map<AdminModel>(da.Get(id));
            return data;
        }

        public static void Insert(AdminModel admin)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Admin, AdminModel>();
            });
            var mapper = new Mapper(config);
            var da = DataAccess.AdminDataAccess();
            var upload = mapper.Map<AdminModel, Admin>(admin);
            da.Insert(upload);

        }

        public static void Upadte(AdminModel admin)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Admin, AdminModel>();
            });
            var mapper = new Mapper(config);
            var da = DataAccess.AdminDataAccess();
            var upload = mapper.Map<AdminModel, Admin>(admin);
            da.Update(upload);
        }
        public static void Delete(int id)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Admin, AdminModel>();
            });
            var mapper = new Mapper(config);
            var da = DataAccess.AdminDataAccess();
            da.Delete(id);
        }

        public static TokenModel Authenticate(AdminModel admin)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Admin, AdminModel>();
                
            });
            var mapper = new Mapper(config);
            var da = DataAccess.AuthDataAccess();
            var data = mapper.Map<AdminModel, Admin>(admin);
            var result = da.Authenticate(data);
            //var token = Mapper.Map<TokenModel, Token>(result);
            var token = new TokenModel();
            if(result != null)
            {
                token.Id = result.Id;
                token.User_Id = result.User_Id;
                token.AccessToken = result.AccessToken;
                token.UserType = result.UserType;
            }
            return token;
        }
        public static bool IsAuthenticated(string token)
        {
            var rs = DataAccess.AuthDataAccess().IsAuthenticated(token);
            return rs;

        }
        public static bool Logout(string token)
        {
            return DataAccess.AuthDataAccess().Logout(token);
        }


    }
}
