﻿//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MEMSservice.DAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MEMSEntities : DbContext
    {
        public MEMSEntities()
            : base("name=MEMSEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<T_Base_companytype> T_Base_companytype { get; set; }
        public DbSet<T_Base_customertype> T_Base_customertype { get; set; }
        public DbSet<T_Base_profession> T_Base_profession { get; set; }
        public DbSet<T_Base_suppliertype> T_Base_suppliertype { get; set; }
        public DbSet<T_Customer> T_Customer { get; set; }
        public DbSet<T_Customer_address> T_Customer_address { get; set; }
        public DbSet<T_Customer_contacts> T_Customer_contacts { get; set; }
        public DbSet<T_Suppliers> T_Suppliers { get; set; }
        public DbSet<T_Suppliers_contacts> T_Suppliers_contacts { get; set; }
        public DbSet<T_Crafts> T_Crafts { get; set; }
        public DbSet<T_CraftsPrice> T_CraftsPrice { get; set; }
        public DbSet<T_Product> T_Product { get; set; }
        public DbSet<T_ProductbasicPrice> T_ProductbasicPrice { get; set; }
        public DbSet<T_FileMgr> T_FileMgr { get; set; }
        public DbSet<T_ProductType> T_ProductType { get; set; }
    }
}
