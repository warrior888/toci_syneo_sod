﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Toci.Syneo.Sod.Dal.Gatekeeper.Interfaces
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SyneoSodEntities : DbContext
    {
        public SyneoSodEntities()
            : base("name=SyneoSodEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<DbColumnType> DbColumnTypes { get; set; }
        public virtual DbSet<FormsCommunicationHierarchy> FormsCommunicationHierarchies { get; set; }
        public virtual DbSet<Priviledge> Priviledges { get; set; }
        public virtual DbSet<ProceedingDecision> ProceedingDecisions { get; set; }
        public virtual DbSet<SodDefinitionRoot> SodDefinitionRoots { get; set; }
        public virtual DbSet<SodFormElementChoice> SodFormElementChoices { get; set; }
        public virtual DbSet<SodForm> SodForms { get; set; }
        public virtual DbSet<SodTemplate> SodTemplates { get; set; }
        public virtual DbSet<SodUser> SodUsers { get; set; }
        public virtual DbSet<SodUsersPriviledge> SodUsersPriviledges { get; set; }
        public virtual DbSet<StoreOfDataPerForm> StoreOfDataPerForms { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<SystemUser> SystemUsers { get; set; }
        public virtual DbSet<UsersType> UsersTypes { get; set; }
    }
}
