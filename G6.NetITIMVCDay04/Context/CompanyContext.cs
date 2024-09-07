using G6.NetITIMVCDay04.Models;
using Microsoft.EntityFrameworkCore;

namespace G6.NetITIMVCDay04.Context
{
    public class CompanyContext : DbContext
    {
        /*--------------------------------------------------------*/
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;DataBase=G6.NetITIMVCDay04;Trusted_Connection=true;Encrypt=false;");
        }
        /*--------------------------------------------------------*/
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            /*----------------------------------------------------*/
            // Seading
            var _Departments = new List<Department>
            {
                new Department { Id = 1, Name = "HR" },
                new Department { Id = 2, Name = "PR" },
                new Department { Id = 3, Name = "Social Media" },
                new Department { Id = 4, Name = "Finance" },
                new Department { Id = 5, Name = "SD" },
            };
            /*----------------------------------------------------*/
            var _Employees = new List<Employee>
            {
                new Employee { Id = 1, Name = "Ramy", Age = 20, Salary = 1234, Address = "Ismaila", Email = "email@mail.com", DepartmentId = 1 },
                new Employee { Id = 2, Name = "Ali", Age = 25, Salary = 2234, Address = "Ismaila", Email = "email@mail.com", DepartmentId = 2 },
                new Employee { Id = 3, Name = "Mohamed", Age = 30, Salary = 3234, Address = "Ismaila", Email = "email@mail.com", DepartmentId = 3 },
                new Employee { Id = 4, Name = "Ahmed", Age = 35, Salary = 4234, Address = "Ismaila", Email = "email@mail.com", DepartmentId = 4 },
                new Employee { Id = 5, Name = "Hala", Age = 40, Salary = 5234, Address = "Ismaila", Email = "email@mail.com", DepartmentId = 5 },
                new Employee { Id = 6, Name = "Mai", Age = 45, Salary = 6234, Address = "Ismaila", Email = "email@mail.com", DepartmentId = 1 },
                new Employee { Id = 7, Name = "Omar", Age = 50, Salary = 7234, Address = "Ismaila", Email = "email@mail.com", DepartmentId = 2 },
                new Employee { Id = 8, Name = "Sara", Age = 55, Salary = 8234, Address = "Ismaila", Email = "email@mail.com", DepartmentId = 3 },
                new Employee { Id = 9, Name = "Mostafa", Age = 30, Salary = 9234, Address = "Ismaila", Email = "email@mail.com", DepartmentId = 4 },
                new Employee { Id = 10, Name = "Nour", Age = 40, Salary = 10234, Address = "Ismaila", Email = "email@mail.com", DepartmentId = 5 },
            };
            /*----------------------------------------------------*/
            modelBuilder.Entity<Department>().HasData(_Departments);
            modelBuilder.Entity<Employee>().HasData(_Employees);
            /*----------------------------------------------------*/
        }
        /*--------------------------------------------------------*/
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        /*--------------------------------------------------------*/
    }
}
