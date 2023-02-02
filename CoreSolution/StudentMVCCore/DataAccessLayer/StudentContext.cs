using Microsoft.EntityFrameworkCore;
using StudentMVCCore.Models;

namespace StudentMVCCore.DataAccessLayer
{
    
        public class StudentContext : DbContext
        {
            public StudentContext(DbContextOptions<StudentContext> options) : base(options)
            { }
            public DbSet<Student> Students { get; set; }
        }
    
}
