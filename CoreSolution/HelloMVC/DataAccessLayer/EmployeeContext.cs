using HelloMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace HelloMVC.DataAccessLayer
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
    }
}