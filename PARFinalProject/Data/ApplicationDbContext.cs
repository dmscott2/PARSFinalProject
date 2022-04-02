using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using parslib.Models;

namespace PARFinalProject.Data;


public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    public DbSet<Course> Courses { get; set; }
    //public DbSet<Instructor> Instructors { get; set; }
    //public DbSet<Administrator> Administrators { get; set; }
    //public DbSet<User> Users {get; set;}
    //public DbSet<Unit_Leader> Unit_Leaders { get; set; }
    //public DbSet<ProgramEvaluator> Program_Evaluators { get; set; }
    public DbSet<StudentOutcome> StudentOutcomes { get; set; }
    public DbSet<CourseLearningOutcome> CourseLearningOutcomes { get; set; }
    public DbSet<Rating> Ratings { get; set; }
    public DbSet<Measure> Measures { get; set; }
}