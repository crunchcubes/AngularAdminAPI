﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AngularAdmin.DataAccess.Entities
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class AngularAdminEntities : DbContext
    {
        public AngularAdminEntities()
            : base("name=AngularAdminEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Project> Project { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Task> Task { get; set; }
    }
}