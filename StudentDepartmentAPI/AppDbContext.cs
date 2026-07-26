using Microsoft.EntityFrameworkCore;
using StudentDepartmentAPI.Models;


namespace StudentDepartmentAPI
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Student> Students { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seeding Departments
            modelBuilder.Entity<Department>().HasData(
                new Department { Id = 1, Name = "Computer Science" },
                new Department { Id = 2, Name = "Mathematics" },
                new Department { Id = 3, Name = "Physics" }
            );

            // Seeding Students
            modelBuilder.Entity<Student>().HasData(
                new Student { Id = 1, Name = "John Doe", DepartmentId = 1 },
                new Student { Id = 2, Name = "Jane Smith", DepartmentId = 2 },
                new Student { Id = 3, Name = "Alice Brown", DepartmentId = 3 }
            );
        }
    }

}
