//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class ShopOwner
    {
        public ShopOwner()
        {
            this.Shop_Product = new HashSet<Shop_Product>();
            this.Tokens = new HashSet<Token>();
        }
    
        public int ShopO_Id { get; set; }
        public string ShopO_Name { get; set; }
        public string ShopO_Username { get; set; }
        public string ShopO_Password { get; set; }
        public string ShopO_Email { get; set; }
        public string ShopO_Phone { get; set; }
        public string ShopO_Shopname { get; set; }
        public string ShopO_Description { get; set; }
        public int User_Type { get; set; }
        public string User_Validation { get; set; }
    
        public virtual ICollection<Shop_Product> Shop_Product { get; set; }
        public virtual ICollection<Token> Tokens { get; set; }
    }
}