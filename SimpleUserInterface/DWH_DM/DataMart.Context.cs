﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SimpleUserInterface.DWH_DM
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class IoT_system_DataMartEntities : DbContext
    {
        public IoT_system_DataMartEntities()
            : base("name=IoT_system_DataMartEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<DataStore> DataStore { get; set; }
        public virtual DbSet<Date> Date { get; set; }
        public virtual DbSet<DeviceLocation> DeviceLocation { get; set; }
        public virtual DbSet<Scenario> Scenario { get; set; }
    }
}
