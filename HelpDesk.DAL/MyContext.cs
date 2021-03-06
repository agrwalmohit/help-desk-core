﻿using HelpDesk.Models.Entities;
using HelpDesk.Models.IdentityEntities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace HelpDesk.DAL
{
    public class MyContext : IdentityDbContext<ApplicationUser, ApplicationRole, string>
    {
        public MyContext()
        {

        }
        public MyContext(DbContextOptions<MyContext> options)
            : base(options)
        {
        }

        //public override int SaveChanges()
        //{
        //    var entities = from e in ChangeTracker.Entries()
        //                   where e.State == EntityState.Added
        //                       || e.State == EntityState.Modified
        //                   select e.Entity;
        //    foreach (var entity in entities)
        //    {
        //        var validationContext = new ValidationContext(entity);
        //        Validator.ValidateObject(entity, validationContext);
        //    }

        //    return base.SaveChanges();
        //}

        public virtual DbSet<Issue> Issues { get; set; }
        public virtual DbSet<IssueLog> IssueLogs { get; set; }
        public virtual DbSet<Photograph> Photographs { get; set; }
        public virtual DbSet<Survey> Surveys { get; set; }
    }
}
