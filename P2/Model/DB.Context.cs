﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntitiFrameworkProject1
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DBContainer : DbContext
    {
        public DBContainer()
            : base("name=DBContainer")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Media> MediaSet { get; set; }
        public virtual DbSet<Person> PersonSet { get; set; }
        public virtual DbSet<LinkMediaPerson> LinkMediaPersonSet { get; set; }
    }
}
