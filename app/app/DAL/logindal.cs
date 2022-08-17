using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using app.Models;


namespace app.DAL
{
    public class logindal : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<login>().ToTable("tblsign");
            modelBuilder.Entity<register>().ToTable("tblreg");
            modelBuilder.Entity<contact>().ToTable("tblcon");

        }
        public DbSet<login> p1 { get; set; }
        public DbSet<register> p2 { get; set; }

        public DbSet <contact> p3 { get; set; }
        
    }
}