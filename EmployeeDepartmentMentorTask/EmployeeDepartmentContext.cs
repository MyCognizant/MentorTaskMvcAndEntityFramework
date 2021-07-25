using EmployeeDepartmentMentorTask.Models;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace EmployeeDepartmentMentorTask
{
    public class EmployeeDepartmentContext : DbContext
    {
        // Your context has been configured to use a 'EmployeeDepartmentContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'EmployeeDepartmentMentorTask.EmployeeDepartmentContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'EmployeeDepartmentContext' 
        // connection string in the application configuration file.

        public DbSet<EmployeeModel> Employees { get; set; } 
        public DbSet<DepartmentModel> Departments { get; set;  }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);




            modelBuilder.Entity<EmployeeModel>()
                        .HasKey(e => e.EmployeeId)
                        .HasRequired<DepartmentModel>(e => e.Department)
                        .WithMany(d => d.Emloyees)
                        .HasForeignKey<int>(e => e.DepartmentId);

            modelBuilder.Entity<EmployeeModel>().
                Property(e => e.EmployeeId).
                HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
               
                

            modelBuilder.Entity<DepartmentModel>()
                    .Property(d => d.DepartmentId)
                    .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<DepartmentModel>()
                       .HasKey<int>(d => d.DepartmentId);


        }

        public EmployeeDepartmentContext()
            : base("name=EmployeeDepartmentContext")
        {

        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}