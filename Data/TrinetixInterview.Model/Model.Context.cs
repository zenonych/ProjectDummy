﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TrinetixInterview.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TrinetixInterviewEntities : DbContext
    {
        public TrinetixInterviewEntities()
            : base("name=TrinetixInterviewEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<FileName> FileNames { get; set; }
        public virtual DbSet<Word> Words { get; set; }
        public virtual DbSet<FilePath> FilePaths { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
    }
}
