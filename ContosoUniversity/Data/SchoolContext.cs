﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContosoUniversity.Models;
using Microsoft.EntityFrameworkCore;

namespace ContosoUniversity.Data
{
    //Database conext class to specify which entities are included in the data model
    public class SchoolContext: DbContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        {
        }
        // DbSet property for each entity set corresponding to a database table
        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }

        //Change tables to singular names
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().ToTable("Course");
            modelBuilder.Entity<Enrollment>().ToTable("Enrollment");
            modelBuilder.Entity<Student>().ToTable("Student");
        }
    }
}
//When the database is created, EF creates tables that have names the same as the DbSet property names.
//Property names for collections are typically plural (Students rather than Student), but developers disagree 
//about whether table names should be pluralized or not. For these tutorials you'll override the default behavior
//by specifying singular table names in the DbContext.