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
    
    public partial class Affiliator
    {
        public Affiliator()
        {
            this.Tokens = new HashSet<Token>();
        }
    
        public int Affiliate_Id { get; set; }
        public string Affiliate_Name { get; set; }
        public string Affiliate_Username { get; set; }
        public string Affiliate_Password { get; set; }
        public string Affiliate_Email { get; set; }
        public string Affiliate_Phone { get; set; }
        public int Affiliate_UserType { get; set; }
        public string Affiliate_Code { get; set; }
        public string Authorization { get; set; }
    
        public virtual ICollection<Token> Tokens { get; set; }
    }
}