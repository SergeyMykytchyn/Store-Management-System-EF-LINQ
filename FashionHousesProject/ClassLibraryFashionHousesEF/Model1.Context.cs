﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClassLibraryFashionHousesEF
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class FashionHousesEntities : DbContext
    {
        public FashionHousesEntities()
            : base("name=FashionHousesEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Clothes> Clothes { get; set; }
        public virtual DbSet<ClothesInShop> ClothesInShop { get; set; }
        public virtual DbSet<Designers> Designers { get; set; }
        public virtual DbSet<Divisions> Divisions { get; set; }
        public virtual DbSet<FashionHouses> FashionHouses { get; set; }
        public virtual DbSet<Presidents> Presidents { get; set; }
        public virtual DbSet<ShopClothes> ShopClothes { get; set; }
    }
}