using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentMVCCore.DataAccessLayer;
using StudentMVCCore.Models;
using StudentMVCCore.Repository;

namespace StudentMVCCore.Controllers
{
    public class StudentController : Controller
    {
         IStudentRepository repo;
        public StudentController(StudentContext con)
        {
            repo = new StudentRepository(con);
        }
        [HttpGet]
        public async Task<IActionResult> GetAllStudentsAction()
        {
            return View(await repo.GetAllStudents().ToListAsync());
        }
        public async Task<IActionResult> GetStudentById(int id)
        {
            var stud = repo.GetStudent(id);
            if (stud == null)
            {
                return NotFound();
            }
            else
            {
                return View(stud);
            }
        }
        public ActionResult InsertStudentAction()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> InsertStudent(Student student)
        {
            repo.InsertStudents(student);
            return RedirectToAction("GetAllStudentsAction");
        }
        public IActionResult DeleteStudent()
        {
            return View();
        }
        public async Task<IActionResult> DeleteStudentById(int id)
        {
            repo.DeleteStudents(id);
            return RedirectToAction("GetAllStudentsAction");
        }
        public ActionResult UpdateStudent()
        {
            return View();
        }
        
        [HttpPost]
        public async Task<IActionResult> UpdateStudentById(int id, Student student)
        {
            repo.UpdateStudents(id, student);
            return RedirectToAction("GetAllStudentsAction");
        }
    }
}
