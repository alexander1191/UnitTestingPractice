using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using StudentAPI.Models;
using StudentAPI.Services;

namespace StudentAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : ControllerBase
    {
        private IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet]
        public List<Student> GetAll()
        {
            return _studentService.GetAll();
        }

        [HttpGet("{ci}")]
        public Student GetByCi(int ci)
        {
            return _studentService.GetByCi(ci);
        }

        [HttpPost]
        public Student Create(Student student)
        {
            return _studentService.Create(student);
        }

        [HttpPut("{ci}")]
        public Student Update(int ci, Student updatedStudent)
        {
            return _studentService.Update(ci, updatedStudent);
        }

        [HttpDelete("{ci}")]
        public Student Delete(int ci)
        {
            return _studentService.Delete(ci);
        }

        [HttpGet("is-approved{ci}")]
        public bool HasApproved(int ci)
        {
            return _studentService.HasApproved(ci);
        }
    }
}
