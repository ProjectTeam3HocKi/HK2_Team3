﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ShoppingJewellery.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class JewelleryShopping_dbEntities : DbContext
    {
        public JewelleryShopping_dbEntities()
            : base("name=JewelleryShopping_dbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<GoldView> GoldViews { get; set; }
        public virtual DbSet<ViewFullItem> ViewFullItems { get; set; }
        public virtual DbSet<DisplayCommonPro> DisplayCommonProes { get; set; }
        public virtual DbSet<AdminLoginMst> AdminLoginMsts { get; set; }
        public virtual DbSet<UserRegMst> UserRegMsts { get; set; }
        public virtual DbSet<CatMst> CatMsts { get; set; }
        public virtual DbSet<JewelTypeMst> JewelTypeMsts { get; set; }
        public virtual DbSet<ProdMst> ProdMsts { get; set; }
        public virtual DbSet<ViewDisplayItem> ViewDisplayItems { get; set; }
        public virtual DbSet<Image> Images { get; set; }
    }
}