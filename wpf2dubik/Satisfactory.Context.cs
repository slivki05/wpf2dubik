﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace wpf2dubik
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;

    public partial class SatisfactoryEntities : DbContext
    {
        private static SatisfactoryEntities _context;
        public SatisfactoryEntities()
            : base("name=SatisfactoryEntities")
        {
        }

        public static SatisfactoryEntities GetContext()
        {
            if (_context == null)
                _context = new SatisfactoryEntities();

            return _context;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }

        public virtual DbSet<Agent> Agent { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<HistoryImplementations> HistoryImplementations { get; set; }
        public virtual DbSet<Material> Material { get; set; }
        public virtual DbSet<NecessaryMaterials> NecessaryMaterials { get; set; }
        public virtual DbSet<PointSale> PointSale { get; set; }
        public virtual DbSet<PossibleSuppliers> PossibleSuppliers { get; set; }
        public virtual DbSet<Production> Production { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<ProductSales> ProductSales { get; set; }
        public virtual DbSet<Provider> Provider { get; set; }
        public virtual DbSet<Supplies> Supplies { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        public virtual ObjectResult<string> TypeCom()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("TypeCom");
        }
    }
}
