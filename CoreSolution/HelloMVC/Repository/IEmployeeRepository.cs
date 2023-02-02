using HelloMVC.Models;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace HelloMVC.Repository
{
    interface IEmployeeRepository
    {
        DbSet<Employee> GetEmployees();
        Task<Employee> GetEmployee(int employeeId);
    }
}