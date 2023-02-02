using Microsoft.EntityFrameworkCore;
using StudentMVCCore.Models;

namespace StudentMVCCore.Repository
{
    
        public interface IStudentRepository
        {
            public bool InsertStudents(Student stud);
            public bool UpdateStudents(int id, Student stud);
            public bool DeleteStudents(int id);
            public Student GetStudent(int id);
            public DbSet<Student> GetAllStudents();
        }
    
}
